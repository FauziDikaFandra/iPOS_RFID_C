// VBConversions Note: VB project level imports
using System.Collections.Generic;
using System;
using System.Linq;
using System.Drawing;
using System.Diagnostics;
using System.Data;
using System.Xml.Linq;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;
// End of VB project level imports

using Symbol.RFID3;
//using Symbol.RFID3.TagAccess.Sequence;
using static Symbol.RFID3.Events;
using System.ComponentModel;
using System.Threading;
using iPOS;

namespace iPOS
{
	
	public partial class frmShowStock
	{
		public frmShowStock()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmShowStock defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmShowStock Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmShowStock();
					defaultInstance.FormClosed += new System.Windows.Forms.FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
			set
			{
				defaultInstance = value;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		internal RFIDReader m_ReaderAPI;
		
		public Hashtable m_TagTable;
		private UpdateStatus m_UpdateStatusHandler = null;
		private UpdateRead m_UpdateReadHandler = null;
		bool NextStep;
		DataSet ds = new DataSet();
		DataSet dsDG = new DataSet();
		private void Closebtn_Click(object sender, EventArgs e)
		{
			//Application.Exit()
			frmFirstForm.Default.Show();
		}
		
		public void txtItemCode_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				ShowDG(txtItemCode.Text.ToString().Trim(), false);
			}
			if (e.KeyCode == Keys.Enter)
			{
				//Menghilangkan Bunyi Beep
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}
		
		public void ShowDG(string Item, bool RFIDJ)
		{
			if (RFIDJ == true)
			{
				Item = HexToString(Microsoft.VisualBasic.Strings.Left(Item, 26));
				txtItemCode.Text = Item;
				(new Microsoft.VisualBasic.Devices.Audio()).Play(Application.StartupPath + "/Beep.wav", AudioPlayMode.Background);
			}
			DataGridView1.DataSource = null;
			ds.Clear();
			dsDG.Clear();
			if (Module1.VPing == "ONLINE")
			{
				ds = Module1.getSqldb("select distinct RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand,(SELECT Count(*) from Item_Master_RFID Where Location = 0 and flag = 0 and status = 1 and plu = a.plu) as Warehouse," +
					"(SELECT Count(*) from Item_Master_RFID Where Location = 1 and flag = 0 and status = 1 and plu = a.plu) as Floor,ISNULL(last_stok,0) as Stock from Item_Master a left join Item_Master_RFID b on a.Article_Code = b.Article_Code left join " +
					"Location c on b.Location = c.Location left join t_stok d on a.PLU = d.plu where " +
					"CONVERT(varchar(6),date, 112) = CONVERT(varchar(6),GETDATE(), 112) And (a.PLU " +
					"= '" + Item + "' or b.EPC = '" + Item + "') and isnull(status,1) = 1", Module1.ConnServer);
				///''apabila sudah ditempel semua
				//dsDG = getSqldb("Declare @art as varchar(20) Declare @brnd as varchar(20)" &
				//            "set @brnd =(select top 1 brand from item_master a inner join Item_Master_RFID b On a.plu = b.plu  where a.PLU = '" & Item & "' Or b.EPC = '" & Item & "')" &
				//            "set @art = (select top 1 case when LEN(a.Article_Code) > 8 Then SUBSTRING(a.Article_Code,1,8) Else SUBSTRING(a.Article_Code,1,6) " &
				//            "End As Article from Item_Master a left join Item_Master_RFID b On a.Article_Code = b.Article_Code where a.PLU = '" & Item & "' Or b.EPC = '" & Item & "') " &
				//            "select DISTINCT RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand,(SELECT Count(*) from Item_Master_RFID Where Location = 0 and flag = 0 and status = 1 and plu = a.plu) as Warehouse," &
				//          "(SELECT Count(*) from Item_Master_RFID Where Location = 1 and flag = 0 and status = 1 and plu = a.plu) as Floor, ISNULL(last_stok,0) as Stock from Item_Master a left join Item_Master_RFID b on a.Article_Code = b.Article_Code left join " &
				//            "Location c on b.Location = c.Location  left join t_stok d on a.PLU = d.plu where " &
				//            "CONVERT(varchar(6),date, 112) = CONVERT(varchar(6),GETDATE(), 112) And (a.article_code " &
				//            " Like '' +@art+ '%') And a.PLU <> (select top 1 a.PLU from item_master a inner join Item_Master_RFID b On a.plu = b.plu  where a.PLU = '" & Item & "' Or b.EPC = '" & Item & "') and a.brand = @brnd ", ConnServer)
				///''belum semua
				dsDG = Module1.getSqldb("Declare @art as varchar(20) Declare @brnd as varchar(20)" +
					"set @brnd =(select top 1 brand from item_master a left join Item_Master_RFID b On a.plu = b.plu  where a.PLU = '" + Item + "' Or b.EPC = '" + Item + "'  and b.status = 1)" +
					"set @art = (select top 1 case when LEN(a.Article_Code) > 8 Then SUBSTRING(a.Article_Code,1,8) Else SUBSTRING(a.Article_Code,1,6) " +
					"End As Article from Item_Master a left join Item_Master_RFID b On a.Article_Code = b.Article_Code where a.PLU = '" + Item + "' Or b.EPC = '" + Item + "'  and b.status = 1) " +
					"select DISTINCT RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand, (SELECT Count(*) from Item_Master_RFID Where Location = 0 and flag = 0 and status = 1 and plu = a.plu) as Warehouse," +
					"(SELECT Count(*) from Item_Master_RFID Where Location = 1 and flag = 0 and status = 1 and plu = a.plu) as Floor, ISNULL(last_stok,0) as Stock from Item_Master a left join Item_Master_RFID b on a.Article_Code = b.Article_Code left join " +
					"Location c on b.Location = c.Location  left join t_stok d on a.PLU = d.plu where " +
					"CONVERT(varchar(6),date, 112) = CONVERT(varchar(6),GETDATE(), 112) And (a.article_code " +
					" Like '' +@art+ '%') And a.Description <> 'TIDAK AKTIF' and a.PLU <> (select top 1 a.PLU from item_master a left join Item_Master_RFID b On a.plu = b.plu  where a.PLU = '" + Item + "' Or b.EPC = '" + Item + "') and a.brand = @brnd ", Module1.ConnServer);
			}
			else
			{
				ds = Module1.getSqldb("select  RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand,'0' as Warehouse,'0' as Floor,'0' as Stock from Item_Master where PLU " +
					"= '" + Item + "')", Module1.ConnLocal);
				dsDG = Module1.getSqldb("select top 10 RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand,'0' as Warehouse,'0' as Floor,'0' as Stock from Item_Master where PLU " +
					"like '%" + Item + "%' )", Module1.ConnLocal);
			}
			
			if (ds.Tables[0].Rows.Count > 0)
			{
				if (ds.Tables[0].Rows.Count > 1 && dsDG.Tables[0].Rows.Count > 0)
				{
					DataGridView1.DataSource = dsDG.Tables[0];
					DataGridView1.Columns["Price"].DefaultCellStyle.Format = "N0";
					DataGridView1.Columns["Warehouse"].DefaultCellStyle.Format = "N0";
					DataGridView1.Columns["PLU"].Width = 150;
					DataGridView1.Columns["Description"].Width = 300;
					DataGridView1.Columns["Price"].Width = 100;
					DataGridView1.Columns["Brand"].Visible = false;
					DataGridView1.Columns["Warehouse"].Width = 120;
					DataGridView1.Columns["Floor"].Width = 70;
					DataGridView1.Columns["Stock"].Width = 70;
					DataGridView1.Columns["Stock"].HeaderText = "SAP";
					DataGridView1.Refresh();
				}
				else
				{
					PLU.Text = System.Convert.ToString(ds.Tables[0].Rows[0]["PLU"]);
					Desc.Text = System.Convert.ToString(ds.Tables[0].Rows[0]["Description"]);
					///''apabila sudah ditempel semua
					whs.Text = System.Convert.ToString(ds.Tables[0].Rows[0]["Warehouse"]);
					floor.Text = System.Convert.ToString(ds.Tables[0].Rows[0]["Floor"]);
					///''belum semua
					//whs.Text = ds.Tables(0).Rows(0).Item("Stock")
					//floor.Text = 0
					Stock.Text = System.Convert.ToString(ds.Tables[0].Rows[0]["Stock"]);
				}
			}
			else
			{
				PLU.Text = "_";
				Desc.Text = "_";
				whs.Text = "_";
				floor.Text = "_";
				Stock.Text = "_";
			}
			
			if (dsDG.Tables[0].Rows.Count > 0)
			{
				if (ds.Tables[0].Rows.Count > 1 && dsDG.Tables[0].Rows.Count > 0)
				{
					PLU.Text = System.Convert.ToString(ds.Tables[0].Rows[0]["PLU"]);
					Desc.Text = System.Convert.ToString(ds.Tables[0].Rows[0]["Description"]);
					///''apabila sudah ditempel semua
					whs.Text = System.Convert.ToString(ds.Tables[0].Rows[0]["Warehouse"]);
					floor.Text = System.Convert.ToString(ds.Tables[0].Rows[0]["Floor"]);
					///''belum semua
					//whs.Text = ds.Tables(0).Rows(0).Item("Stock")
					//floor.Text = 0
					Stock.Text = System.Convert.ToString(ds.Tables[0].Rows[0]["Stock"]);
				}
				else
				{
					DataGridView1.DataSource = dsDG.Tables[0];
					DataGridView1.Columns["Price"].DefaultCellStyle.Format = "N0";
					DataGridView1.Columns["Warehouse"].DefaultCellStyle.Format = "N0";
					DataGridView1.Columns["PLU"].Width = 150;
					DataGridView1.Columns["Description"].Width = 300;
					DataGridView1.Columns["Price"].Width = 100;
					DataGridView1.Columns["Brand"].Visible = false;
					DataGridView1.Columns["Warehouse"].Width = 120;
					DataGridView1.Columns["Floor"].Width = 70;
					DataGridView1.Columns["Stock"].Width = 70;
					DataGridView1.Columns["Stock"].HeaderText = "SAP";
					DataGridView1.Refresh();
				}
				
			}
			txtItemCode.Select(0, txtItemCode.Text.Length);
			txtItemCode.Focus();
		}
		
		//Sub ShowDG(ByVal Item As String, ByVal RFIDJ As Boolean) 'RFID apabila belum di tempel semua
		//    If RFIDJ = True Then
		//        Item = HexToString(Microsoft.VisualBasic.Left(Item, 26))
		//        txtItemCode.Text = Item
		//        My.Computer.Audio.Play(Application.StartupPath & "/Beep.wav", AudioPlayMode.Background)
		//    End If
		//    DataGridView1.DataSource = Nothing
		//    ds.Clear()
		//        dsDG.Clear()
		//    If VPing = "ONLINE" Then
		
		//        'For x As Integer = 0 To 1
		//        ds = getSqldb("select RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand,ISNULL(last_stok,0) as Stock " &
		//                  "from Item_Master a left join Item_Master_RFID b on a.Article_Code = b.Article_Code left join " &
		//                  "Location c on b.Location = c.Location left join t_stok d on a.PLU = d.plu where " &
		//                  "CONVERT(varchar(6),date, 112) = CONVERT(varchar(6),GETDATE(), 112) And (a.PLU " &
		//                  "= '" & Item & "' or b.EPC = '" & Item & "')", ConnServer)
		//        'Next
		//        'For x As Integer = 0 To 1
		//        dsDG = getSqldb("Declare @art as varchar(20) Declare @brnd as varchar(20)" &
		//                                    "set @brnd =(select top 1 brand from item_master a left join Item_Master_RFID b On a.plu = b.plu  where a.PLU = '" & Item & "' Or b.EPC = '" & Item & "')" &
		//                                    "set @art = (select distinct case when LEN(a.Article_Code) > 8 Then SUBSTRING(a.Article_Code,1,8) Else SUBSTRING(a.Article_Code,1,6) " &
		//                                    "End As Article from Item_Master a left join Item_Master_RFID b On a.Article_Code = b.Article_Code where a.PLU = '" & Item & "' Or b.EPC = '" & Item & "') " &
		//                                    "select DISTINCT RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand,ISNULL(last_stok,0) as Stock " &
		//                                    "from Item_Master a left join Item_Master_RFID b on a.Article_Code = b.Article_Code left join " &
		//                                    "Location c on b.Location = c.Location  left join t_stok d on a.PLU = d.plu where " &
		//                                    "CONVERT(varchar(6),date, 112) = CONVERT(varchar(6),GETDATE(), 112) And (a.article_code " &
		//                                    " Like '' +@art+ '%') And a.PLU <> (select top 1 a.PLU from item_master a left join Item_Master_RFID b On a.plu = b.plu  where a.PLU = '" & Item & "' Or b.EPC = '" & Item & "') and a.brand = @brnd ", ConnServer)
		//            'Next
		
		//            Else
		//        ds = getSqldb("select  RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand,'OFFLINE' from Item_Master where PLU " &
		//                  "= '" & Item & "'", ConnLocal)
		//        dsDG = getSqldb("select top 10 RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,'OFFLINE' from Item_Master where PLU " &
		//                  "like '%" & Item & "%'", ConnLocal)
		//    End If
		
		//    'If ds.Tables(0).Rows.Count = 0 Then
		//    '    PLU.Text = "_"
		//    '    Desc.Text = "_"
		//    '    Stock.Text = "_"
		//    '    Exit Sub
		//    'End If
		
		//    If ds.Tables(0).Rows.Count > 0 Then
		//        If ds.Tables(0).Rows.Count > 1 And dsDG.Tables(0).Rows.Count > 0 Then
		//            DataGridView1.DataSource = ds.Tables(0)
		//            DataGridView1.Columns("Price").DefaultCellStyle.Format = "N0"
		//            DataGridView1.Columns("Stock").DefaultCellStyle.Format = "N0"
		//            DataGridView1.Columns("PLU").Width = 150
		//            DataGridView1.Columns("Description").Width = 340
		//            DataGridView1.Columns("Price").Width = 100
		//            DataGridView1.Columns("Brand").Visible = False
		//            DataGridView1.Columns("Stock").Width = 100
		//            DataGridView1.Refresh()
		//        Else
		//            PLU.Text = ds.Tables(0).Rows(0).Item("PLU")
		//            Desc.Text = ds.Tables(0).Rows(0).Item("Description")
		//            Stock.Text = ds.Tables(0).Rows(0).Item("Stock")
		//        End If
		//    Else
		//        PLU.Text = "_"
		//            Desc.Text = "_"
		//            Stock.Text = "_"
		//        End If
		
		//        If dsDG.Tables(0).Rows.Count > 0 Then
		//        If ds.Tables(0).Rows.Count > 1 And dsDG.Tables(0).Rows.Count > 0 Then
		//            PLU.Text = dsDG.Tables(0).Rows(0).Item("PLU")
		//            Desc.Text = dsDG.Tables(0).Rows(0).Item("Description")
		//            Stock.Text = dsDG.Tables(0).Rows(0).Item("Stock")
		//        Else
		//            DataGridView1.DataSource = dsDG.Tables(0)
		//            DataGridView1.Columns("Price").DefaultCellStyle.Format = "N0"
		//            DataGridView1.Columns("Stock").DefaultCellStyle.Format = "N0"
		//            DataGridView1.Columns("PLU").Width = 150
		//            DataGridView1.Columns("Description").Width = 340
		//            DataGridView1.Columns("Price").Width = 100
		//            DataGridView1.Columns("Brand").Visible = False
		//            DataGridView1.Columns("Stock").Width = 100
		//            DataGridView1.Refresh()
		//        End If
		
		//    End If
		//    txtItemCode.Select(0, txtItemCode.Text.Length)
		//        txtItemCode.Focus()
		//End Sub
		
		public void Show_Stock_Load(object sender, EventArgs e)
		{
			DataGridView1.Font = new Font("Arial", 12);
			txtItemCode.Select(0, txtItemCode.Text.Length);
			txtItemCode.Focus();
			NextStep = false;
			Module1.RFIDStatus = false;
			this.m_UpdateStatusHandler = new UpdateStatus(this.myUpdateStatus);
			this.m_UpdateReadHandler = new UpdateRead(this.myUpdateRead);
			this.m_TagTable = new Hashtable();
			CheckForIllegalCrossThreadCalls = false;
			if (Module1.RFIDType == "zebra")
			{
				CheckConZebra();
			}
			if (Module1.RFIDStatus == false)
			{
				RfidScan2.Image = Image.FromFile(Application.StartupPath + "/RFID_DEACTIVE.ico").GetThumbnailImage(22, 22, null, IntPtr.Zero);
				RfidScan2.Text = "RFID OFF";
				RfidScan2.ImageAlign = ContentAlignment.MiddleCenter;
				RfidScan2.TextAlign = ContentAlignment.BottomCenter;
				RfidScan2.TextImageRelation = TextImageRelation.Overlay;
				RfidScan2.ForeColor = Color.Red;
			}
			else
			{
				//RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_ACTIVE.ico").GetThumbnailImage(26, 26, Nothing, IntPtr.Zero)
				//RfidScan2.Text = "RFID ON"
				RfidScan2.Image = Image.FromFile(Application.StartupPath + "/RFID_Refresh3.ico").GetThumbnailImage(26, 26, null, IntPtr.Zero);
				RfidScan2.Text = "REFRESH";
				RfidScan2.ImageAlign = ContentAlignment.MiddleCenter;
				RfidScan2.TextAlign = ContentAlignment.BottomCenter;
				RfidScan2.TextImageRelation = TextImageRelation.Overlay;
				RfidScan2.ForeColor = Color.Green;
			}
			Module1.OneReadAll = false;
			Cetak.CDisplay("  ", "*** LAKON ***");
		}
		
		private void Button1_Click(object sender, EventArgs e)
		{
			NextStep = true;
			//Try
			//    If (Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Length > 0) Then
			//        Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence()
			//        Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.DeleteAll()
			//    Else
			//        Me.m_ReaderAPI.Actions.Inventory.Stop()
			//    End If
			//    RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_DEACTIVE.ico").GetThumbnailImage(20, 20, Nothing, IntPtr.Zero)
			//    RfidScan2.Text = "RFID OFF"
			//    RfidScan2.ImageAlign = ContentAlignment.MiddleCenter
			//    RfidScan2.TextAlign = ContentAlignment.BottomCenter
			//    RfidScan2.TextImageRelation = TextImageRelation.Overlay
			//    RfidScan2.ForeColor = Color.Red
			//    RFIDStatus = False
			//    OneReadAll = False
			//Catch ex As Exception
			
			//End Try
			
			this.Close();
		}
		
		public void CheckConZebra()
		{
			m_ReaderAPI = new RFIDReader(Module1.IPReader, UInt32.Parse(Module1.PortReader), (uint) 0);
			try
			{
				if (m_ReaderAPI.IsConnected == false)
				{
					m_ReaderAPI.Connect();
					//MsgBox("Connect Succeed", MsgBoxStyle.Information, "Information")
					Module1.RFIDStatus = true;
					this.m_ReaderAPI.Events.ReadNotify += new Symbol.RFID3.Events.ReadNotifyHandler(this.Events_ReadNotify);
					this.m_ReaderAPI.Events.AttachTagDataWithReadEvent = false;
					this.m_ReaderAPI.Events.StatusNotify += new Symbol.RFID3.Events.StatusNotifyHandler(this.Events_StatusNotify);
					this.m_ReaderAPI.Events.NotifyGPIEvent = true;
					this.m_ReaderAPI.Events.NotifyReaderDisconnectEvent = true;
					this.m_ReaderAPI.Events.NotifyAccessStartEvent = true;
					this.m_ReaderAPI.Events.NotifyAccessStopEvent = true;
					this.m_ReaderAPI.Events.NotifyInventoryStartEvent = true;
					this.m_ReaderAPI.Events.NotifyInventoryStopEvent = true;
					
					this.m_ReaderAPI.Actions.TagAccess.OperationSequence.DeleteAll();
					if (Module1.OneReadAll == true)
					{
						this.m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence();
					}
					Module1.RFIDOKE = false;
					//Timer1.Enabled = True
					Symbol.RFID3.TagAccess.Sequence.Operation op = new Symbol.RFID3.TagAccess.Sequence.Operation();
					op.AccessOperationCode = ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ;
					op.ReadAccessParams.MemoryBank = MEMORY_BANK.MEMORY_BANK_TID;
					op.ReadAccessParams.ByteCount = (uint) 0;
					op.ReadAccessParams.ByteOffset = (uint) 0;
					op.ReadAccessParams.AccessPassword = (uint) 0;
					this.m_ReaderAPI.Actions.TagAccess.OperationSequence.Add(op);
					Module1.OneReadAll = true;
					this.m_ReaderAPI.Actions.TagAccess.OperationSequence.PerformSequence(null, null, null);
					
					//If DataGridView1.Rows.Count > 0 Then
					//    DataGridView1.DataSource = Nothing
					//End If
				}
			}
			catch (OperationFailureException)
			{
				MessageBox.Show("RFID Offline !!!");
				Module1.RFIDStatus = false;
				txtItemCode.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Module1.RFIDStatus = false;
			}
		}
		
		private delegate void UpdateStatus(Symbol.RFID3.Events.StatusEventData eventData);
		private delegate void UpdateRead(Symbol.RFID3.Events.ReadEventData eventData);
		
		
		
		private string getTagEvent(TagData tag)
		{
			string eventString = "None";
			switch (tag.TagEvent)
			{
				case TAG_EVENT.NEW_TAG_VISIBLE:
					return "New";
				case TAG_EVENT.TAG_NOT_VISIBLE:
					return "Gone";
				case TAG_EVENT.TAG_BACK_TO_VISIBILITY:
					return "Back";
				case TAG_EVENT.NONE:
					return eventString;
			}
			return "None";
		}
		
		public string HexToString(string hex)
		{
			System.Text.StringBuilder text = new System.Text.StringBuilder(hex.Length / 2);
			for (int i = 0; i <= hex.Length - 2; i += 2)
			{
				text.Append(Strings.Chr(Convert.ToByte(hex.Substring(i, 2), 16)));
			}
			return text.ToString();
		}
		
		private void myUpdateStatus(Events.StatusEventData eventData)
		{
			switch (eventData.StatusEventType)
			{
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.INVENTORY_START_EVENT:
					break;
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.INVENTORY_STOP_EVENT:
					break;
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ACCESS_START_EVENT:
					break;
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ACCESS_STOP_EVENT:
					break;
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.BUFFER_FULL_WARNING_EVENT:
					myUpdateRead(null);
					break;
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.BUFFER_FULL_EVENT:
					myUpdateRead(null);
					break;
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.DISCONNECTION_EVENT:
					break;
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ANTENNA_EVENT:
					break;
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.READER_EXCEPTION_EVENT:
					break;
				default:
					break;
			}
		}
		
		private void myUpdateRead(Symbol.RFID3.Events.ReadEventData eventData)
		{
			if (Module1.GotoPayment == true)
			{
				return;
			}
			int index = 0;
			int isFoundIndex = 0;
			Symbol.RFID3.TagData[] tagData = m_ReaderAPI.Actions.GetReadTags(1000);
			if (tagData != null)
			{
				for (int nIndex = 0; nIndex <= tagData.Length - 1; nIndex++)
				{
					if (tagData[nIndex].OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_NONE || (tagData[nIndex].OpCode == ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ && tagData[nIndex].OpStatus == ACCESS_OPERATION_STATUS.ACCESS_SUCCESS))
					{
						Symbol.RFID3.TagData tag = tagData[nIndex];
						string tagID = tag.TagID;
						string TIDData = tag.MemoryBankData;
						bool isFound = false;
						lock(m_TagTable.SyncRoot)
						{
							isFound = m_TagTable.ContainsKey(tagID);
							if (!isFound)
							{
								isFound = m_TagTable.ContainsKey(tagID);
							}
						}
						if (isFound)
						{
							Module1.RFIDOKE = true;
							
							//vqty.Text = lblqtyRFID
							//Me.m_ReaderAPI.Actions.Inventory.Stop()
						}
						else
						{
							//Dim memoryBank As String = tag.MemoryBank.ToString()
							//index = memoryBank.LastIndexOf("_"c)
							//If index <> -1 Then
							//    memoryBank = memoryBank.Substring(index + 1)
							//End If
							
							if (tag.MemoryBankData.Length > 0)
							{
								ShowDG(tag.TagID.Trim(), true);
							}
							
							//txtItemCode.Text = HexToString(Microsoft.VisualBasic.Left(Trim(tag.TagID), 26))
							//My.Computer.Audio.Play(Application.StartupPath & "/Beep.wav", AudioPlayMode.Background)
							//ShowDG(txtItemCode.Text.ToString.Trim, False)
							lock(m_TagTable.SyncRoot)
							{
								m_TagTable.Add(tagID, tag.TagID);
							}
						}
					}
				}
			}
		}
		
		private void Events_ReadNotify(object sender, Symbol.RFID3.Events.ReadEventArgs readEventArgs)
		{
			try
			{
				base.Invoke(this.m_UpdateReadHandler, new object[] {null});
			}
			catch (Exception)
			{
			}
		}
		
		public void Events_StatusNotify(object sender, Symbol.RFID3.Events.StatusEventArgs statusEventArgs)
		{
			try
			{
				base.Invoke(this.m_UpdateStatusHandler, new object[] {statusEventArgs.StatusEventData});
			}
			catch (Exception)
			{
			}
		}
		public void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			try
			{
				Module1.OneReadAll = false;
				if (this.m_ReaderAPI.Actions.TagAccess.OperationSequence.Length > 0)
				{
					this.m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence();
					this.m_ReaderAPI.Actions.Inventory.Stop();
				}
				else
				{
					this.m_ReaderAPI.Actions.Inventory.Stop();
				}
				this.m_ReaderAPI.Disconnect();
				
				if (m_ReaderAPI.IsConnected == true)
				{
					m_ReaderAPI.Disconnect();
				}
				
				//Me.m_IsConnected = False
				//workEventArgs.Result = "Disconnect Succeed"
			}
			catch (OperationFailureException)
			{
				//workEventArgs.Result = ofe.Result
			}
		}
		
		
		public void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			this.Close();
			//If NextStep = True Then
			//    frmLogin.Show()
			//End If
			return;
		}
		
		public void RfidScan2_Click(object sender, EventArgs e)
		{
			if (Module1.RFIDStatus == false)
			{
				if (Module1.RFIDType == "zebra")
				{
					CheckConZebra();
				}
				txtItemCode.Focus();
				return;
			}
			try
			{
				DataGridView1.DataSource = null;
				PLU.Text = "_";
				Desc.Text = "_";
				Stock.Text = "_";
				txtItemCode.Clear();
				if (Module1.RFIDStatus == false)
				{
					Symbol.RFID3.TagAccess.Sequence.Operation op = new Symbol.RFID3.TagAccess.Sequence.Operation();
					op.AccessOperationCode = ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ;
					op.ReadAccessParams.MemoryBank = MEMORY_BANK.MEMORY_BANK_EPC;
					op.ReadAccessParams.ByteCount = (uint) 0;
					op.ReadAccessParams.ByteOffset = (uint) 0;
					op.ReadAccessParams.AccessPassword = (uint) 0;
					this.m_ReaderAPI.Actions.TagAccess.OperationSequence.Add(op);
					Module1.OneReadAll = true;
					this.m_ReaderAPI.Actions.TagAccess.OperationSequence.PerformSequence(null, null, null);
					if (DataGridView1.Rows.Count > 0)
					{
						DataGridView1.DataSource = null;
					}
					
					//RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_ACTIVE.ico").GetThumbnailImage(24, 24, Nothing, IntPtr.Zero)
					//RfidScan2.Text = "RFID ON"
					RfidScan2.Image = Image.FromFile(Application.StartupPath + "/RFID_Refresh3.ico").GetThumbnailImage(26, 26, null, IntPtr.Zero);
					RfidScan2.Text = "REFRESH";
					RfidScan2.ImageAlign = ContentAlignment.MiddleCenter;
					RfidScan2.TextAlign = ContentAlignment.BottomCenter;
					RfidScan2.TextImageRelation = TextImageRelation.Overlay;
					RfidScan2.ForeColor = Color.Green;
					Module1.RFIDStatus = true;
					m_TagTable.Clear();
				}
				else
				{
					if (this.m_ReaderAPI.Actions.TagAccess.OperationSequence.Length > 0)
					{
						this.m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence();
						this.m_ReaderAPI.Actions.TagAccess.OperationSequence.DeleteAll();
					}
					else
					{
						this.m_ReaderAPI.Actions.Inventory.Stop();
					}
					RfidScan2.Image = Image.FromFile(Application.StartupPath + "/RFID_DEACTIVE.ico").GetThumbnailImage(20, 20, null, IntPtr.Zero);
					RfidScan2.Text = "RFID OFF";
					RfidScan2.ImageAlign = ContentAlignment.MiddleCenter;
					RfidScan2.TextAlign = ContentAlignment.BottomCenter;
					RfidScan2.TextImageRelation = TextImageRelation.Overlay;
					RfidScan2.ForeColor = Color.Red;
					Module1.RFIDStatus = false;
					Module1.OneReadAll = false;
					
					Symbol.RFID3.TagAccess.Sequence.Operation op = new Symbol.RFID3.TagAccess.Sequence.Operation();
					op.AccessOperationCode = ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ;
					op.ReadAccessParams.MemoryBank = MEMORY_BANK.MEMORY_BANK_EPC;
					op.ReadAccessParams.ByteCount = (uint) 0;
					op.ReadAccessParams.ByteOffset = (uint) 0;
					op.ReadAccessParams.AccessPassword = (uint) 0;
					this.m_ReaderAPI.Actions.TagAccess.OperationSequence.Add(op);
					Module1.OneReadAll = true;
					this.m_ReaderAPI.Actions.TagAccess.OperationSequence.PerformSequence(null, null, null);
					if (DataGridView1.Rows.Count > 0)
					{
						DataGridView1.DataSource = null;
					}
					
					//RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_ACTIVE.ico").GetThumbnailImage(24, 24, Nothing, IntPtr.Zero)
					//RfidScan2.Text = "RFID ON"
					RfidScan2.Image = Image.FromFile(Application.StartupPath + "/RFID_Refresh3.ico").GetThumbnailImage(26, 26, null, IntPtr.Zero);
					RfidScan2.Text = "REFRESH";
					RfidScan2.ImageAlign = ContentAlignment.MiddleCenter;
					RfidScan2.TextAlign = ContentAlignment.BottomCenter;
					RfidScan2.TextImageRelation = TextImageRelation.Overlay;
					RfidScan2.ForeColor = Color.Green;
					Module1.RFIDStatus = true;
					m_TagTable.Clear();
				}
			}
			catch (Exception ex)
			{
				txtItemCode.Focus();
				MessageBox.Show(ex.Message);
			}
		}
		
		private void Button3_Click(object sender, EventArgs e)
		{
			this.Close();
			frmFirstForm.Default.Show();
		}
		
		public void Button1_Click_1(object sender, EventArgs e)
		{
			this.Close();
			frmFirstForm.Default.Show();
		}
		
		public void frmShowStock_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (Module1.RFIDStatus == true)
			{
				BackgroundWorker1.WorkerReportsProgress = true;
				BackgroundWorker1.WorkerSupportsCancellation = true;
				BackgroundWorker1.RunWorkerAsync();
			}
			else
			{
				if (NextStep == true)
				{
					frmLogin.Default.Show();
				}
			}
		}
	}
}
