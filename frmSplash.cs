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

using System.ComponentModel;
using Microsoft.VisualBasic.PowerPacks;
using Symbol.RFID3;
using static Symbol.RFID3.Events;
using libzkfpcsharp;
using Microsoft.VisualBasic.CompilerServices;
using iPOS;

namespace iPOS
{
	public partial class frmSplash : System.Windows.Forms.Form
	{
		public frmSplash()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmSplash defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmSplash Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmSplash();
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
		byte xx;
		internal RFIDReader m_ReaderAPI;
		private UpdateRead m_UpdateReadHandler = null;
		private UpdateStatus m_UpdateStatusHandler = null;
		ushort[] antID;
		int[] rxValues;
		int[] txValues;
		public void Form1_Load(object sender, System.EventArgs e)
		{
			lblversi.Text = "Version " + this.GetType().Assembly.GetName().Version.ToString();
			Module1.Main();
			ProgressBar1.Visible = true;
			ProgressBar1.Value = 0;
			Module1.LoadClose = false;
			CheckForIllegalCrossThreadCalls = false;
			Module1.NewMember = false;
			BackgroundWorker1.WorkerReportsProgress = true;
			BackgroundWorker1.WorkerSupportsCancellation = true;
			BackgroundWorker1.RunWorkerAsync();
		}
		private void Mulai()
		{
			ProgressBar1.Value = 0;
			try
			{
				setLabelTxt("Processing... Check Connections!!", Label2);
			}
			catch (Exception)
			{
				
			}
			DataSet RsAddLinked = new DataSet();
			OpenKoneksi(Module1.ConnLocal, "Local");
			
			if (Module1.VSvr ==".")
			{
				Module1.VPing = "OFFLINE";
			}
			else
			{
				if (Module1.Linked())
				{
					OpenKoneksi(Module1.ConnServer, "Server");
				}
			}
			
			
			BackgroundWorker1.ReportProgress(Conversion.Int(10));
			try
			{
				setLabelTxt("Processing... Create Linked!!", Label2);
			}
			catch (Exception)
			{
				
			}
			RsAddLinked = Module1.getSqldb("select srvname from master..sysservers where srvname='" + Module1.ReadIni("Local", "ServerName") + "'", Module1.ConnLocal);
			if (RsAddLinked.Tables[0].Rows.Count == 0)
			{
				Module1.getSqldb("exec sp_addlinkedserver '" + Module1.ReadIni("Local", "ServerName") + "'", Module1.ConnLocal);
				Module1.getSqldb("EXEC master.dbo.sp_addlinkedsrvlogin @rmtsrvname=N'" + Module1.ReadIni("Local", "ServerName") + "',@useself=N'False',@locallogin=N'sa',@rmtuser=N'sa',@rmtpassword='" + Module1.decrypt(Module1.ReadIni("Local", "Password")) + "'", Module1.ConnLocal);
			}
			RsAddLinked.Clear();
			BackgroundWorker1.ReportProgress(Conversion.Int(20));
			try
			{
				setLabelTxt("Processing... Create Linked Server!!", Label2);
			}
			catch (Exception)
			{
				
			}
			RsAddLinked = Module1.getSqldb("select srvname from master..sysservers where srvname='" + Module1.ReadIni("Server", "ServerName") + "'", Module1.ConnLocal);
			if (RsAddLinked.Tables[0].Rows.Count == 0 && !string.IsNullOrEmpty(Module1.VSvr))
			{
				Module1.getSqldb("exec sp_addlinkedserver '" + Module1.ReadIni("Server", "ServerName") + "'", Module1.ConnLocal);
				Module1.getSqldb("select srvname from master..sysservers where srvname='" + Module1.ReadIni("Server", "ServerName") + "'", Module1.ConnLocal);
			}
			RsAddLinked.Clear();
			RsAddLinked = null;
			BackgroundWorker1.ReportProgress(Conversion.Int(30));
			try
			{
				setLabelTxt("Processing... Declare Parameters!!", Label2);
			}
			catch (Exception)
			{
				
			}
			Isi_Parameter();
			BackgroundWorker1.ReportProgress(Conversion.Int(40));
			Cek_CashOpen();
			BackgroundWorker1.ReportProgress(Conversion.Int(50));
			Cek_AdaPromo();
			try
			{
				setLabelTxt("Processing... Promo Checking!!", Label2);
			}
			catch (Exception)
			{
				
			}
			BackgroundWorker1.ReportProgress(Conversion.Int(60));
			//CheckFinger()
			//If Linked() Then Call Cek_SOD("server")
			//Try
			//    setLabelTxt("Processing... SOD Checking!!", Label2)
			//Catch ex As Exception
			
			//End Try
			//BackgroundWorker1.ReportProgress(Int(70))
			//Call Cek_SOD("local")
			//BackgroundWorker1.ReportProgress(Int(80))
			//Try
			//    setLabelTxt("Processing... Card Checking!!", Label2)
			//Catch ex As Exception
			
			//End Try
			if (Module1.RFIDType == "zebra")
			{
				if (Module1.RFIDStatus == false)
				{
					CheckCon();
				}
			}
			
			//If RFIDType = "zebra" Then
			//    CheckCon()
			//End If
			
			
			BackgroundWorker1.ReportProgress(Conversion.Int(90));
			//Call Isi_key()
			if (Module1.RFIDStatus == true)
			{
				SetReader();
			}
			
			//If RFIDType = "zebra" Then
			//    SetReader()
			//End If
			
			BackgroundWorker1.ReportProgress(Conversion.Int(100));
			if (Module1.RFIDStatus == true)
			{
				try
				{
					if (this.m_ReaderAPI.Actions.TagAccess.OperationSequence.Length > 0)
					{
						this.m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence();
					}
					else
					{
						this.m_ReaderAPI.Actions.Inventory.Stop();
					}
					this.m_ReaderAPI.Disconnect();
					//Me.m_IsConnected = False
					//workEventArgs.Result = "Disconnect Succeed"
				}
				catch (OperationFailureException)
				{
					//workEventArgs.Result = ofe.Result
				}
			}
			//If RFIDType = "zebra" Then
			//    Try
			//        If (Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Length > 0) Then
			//            Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence()
			//        Else
			//            Me.m_ReaderAPI.Actions.Inventory.Stop()
			//        End If
			//        Me.m_ReaderAPI.Disconnect()
			//        'Me.m_IsConnected = False
			//        'workEventArgs.Result = "Disconnect Succeed"
			//    Catch ofe As OperationFailureException
			//        'workEventArgs.Result = ofe.Result
			//    End Try
			//End If
			
		}
		
		public void CheckFinger()
		{
			int ret = zkfperrdef.ZKFP_ERR_OK;
			if ((zkfp2.Init()) == zkfperrdef.ZKFP_ERR_OK)
			{
				int nCount = zkfp2.GetDeviceCount();
				if (nCount > 0)
				{
					Module1.FingerOK = true;
				}
				else
				{
					Module1.FingerOK = false;
					zkfp2.Terminate();
				}
			}
			else
			{
			}
		}
		
		
		public void CheckCon()
		{
			m_ReaderAPI = new RFIDReader(Module1.IPReader, UInt32.Parse("5084"), (uint) 0);
			try
			{
				m_ReaderAPI.Connect();
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
				
			}
			catch (OperationFailureException)
			{
				//MsgBox(operationException.Result)
				MessageBox.Show("RFID Offline !!!");
				Module1.RFIDStatus = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				Module1.RFIDStatus = false;
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
		
		private delegate void UpdateRead(Symbol.RFID3.Events.ReadEventData eventData);
		private delegate void UpdateStatus(Symbol.RFID3.Events.StatusEventData eventData);
		private void myUpdateStatus(Events.StatusEventData eventData)
		{
			switch (eventData.StatusEventType)
			{
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.INVENTORY_START_EVENT:
					//functionCallStatusLabel.Text = "Inventory started"
					break;
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.INVENTORY_STOP_EVENT:
					//functionCallStatusLabel.Text = "Inventory stopped"
					//ReadOtherBank()
					break;
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ACCESS_START_EVENT:
					//functionCallStatusLabel.Text = "Access Operation started"
					break;
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ACCESS_STOP_EVENT:
					//functionCallStatusLabel.Text = "Access Operation stopped"
					break;
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.BUFFER_FULL_WARNING_EVENT:
					//functionCallStatusLabel.Text = " Buffer full warning"
					//myUpdateRead(Nothing)
					break;
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.BUFFER_FULL_EVENT:
					//functionCallStatusLabel.Text = "Buffer full"
					//myUpdateRead(Nothing)
					break;
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.DISCONNECTION_EVENT:
					//functionCallStatusLabel.Text = "Disconnection Event " & eventData.DisconnectionEventData.DisconnectEventInfo.ToString()
					break;
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.ANTENNA_EVENT:
					//functionCallStatusLabel.Text = "Antenna Status Update"
					break;
				case Symbol.RFID3.Events.STATUS_EVENT_TYPE.READER_EXCEPTION_EVENT:
					//functionCallStatusLabel.Text = "Reader ExceptionEvent " & eventData.ReaderExceptionEventData.ReaderExceptionEventInfo
					break;
				default:
					break;
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
		
		
		
		private void SetReader()
		{
			try
			{
				
				ushort[] antID = m_ReaderAPI.Config.Antennas.AvailableAntennas;
				Antennas.Config antConfig = m_ReaderAPI.Config.Antennas[antID[0]].GetConfig();
				antConfig.TransmitPowerIndex = System.Convert.ToUInt16(Module1.PowerIndex);
				
				m_ReaderAPI.Config.Antennas[antID[0]].SetConfig(antConfig);
				
			}
			catch (InvalidUsageException)
			{
				
			}
			catch (OperationFailureException)
			{
				
			}
			catch (Exception)
			{
				
			}
		}
		
		private void setLabelTxt(string text, Label lbl)
		{
			if (lbl.InvokeRequired)
			{
				lbl.Invoke(new setLabelTxtInvoker(setLabelTxt), text, lbl);
			}
			else
			{
				lbl.Text = text;
			}
		}
		
		
		
		private delegate void setLabelTxtInvoker(string text, Label lbl);
		private void Cek_SOD(string StrSvr)
		{
			DataSet RsSOD = new DataSet();
			
			Module1.StrSQL = "select flag_sod from branches where branch_id ='" + Module1.VBranch_ID + "'";
			
			switch (StrSvr)
			{
				case "server":
					RsSOD = Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
					if (System.Convert.ToInt32(RsSOD.Tables[0].Rows[0]["Flag_SOD"]) == 0)
					{
						Interaction.MsgBox("Server belum SOD..", (int) Constants.vbCritical + Constants.vbOKOnly, "Oops..");
						ProjectData.EndApp();
					}
					break;
					
				case "local":
					RsSOD = Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
					if (Module1.VPing == "ONLINE" && System.Convert.ToInt32(RsSOD.Tables[0].Rows[0]["Flag_SOD"]) == 0)
					{
						frmSOD.Default.Text = "SOD";
						frmSOD.Default.ShowDialog();
					}
					break;
			}
		}
		
		private void Cek_Card()
		{
			DataSet RsCcard = new DataSet();
			
			RsCcard = Module1.getSqldb("select count(*) as berapa from customer_master_member", Module1.ConnLocal);
			if (System.Convert.ToInt32(RsCcard.Tables[0].Rows[0]["Berapa"]) == 0)
			{
				Module1.getSqldb("update branches set flag_sod=0 where Branch_ID = '" + Module1.VBranch_ID + "'", Module1.ConnLocal);
				Interaction.MsgBox("SOD belum selesai, jalankan iPOS sekali lagi...", (int) Constants.vbCritical + Constants.vbOKOnly, "Oops..");
				ProjectData.EndApp();
			}
		}
		
		private void Cek_CashOpen()
		{
			DataSet RsCash = new DataSet();
			
			Module1.StrSQL = "select modal from cash where branch_id = '" + Module1.VBranch_ID + "' and Cash_Register_ID='" +
				Module1.VReg_ID + " ' and shift='" + System.Convert.ToString(Module1.VShift) + "' and datetime='" + System.Convert.ToString(Module1.GetSrvDate().Date) + "'";
			
			if (Module1.VPing == "ONLINE")
			{
				RsCash = Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
			}
			else
			{
				RsCash = Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
			}
			Module1.VCopen = (RsCash.Tables[0].Rows.Count == 0) ? false : true;
		}
		
		private void Cek_AdaPromo()
		{
			DataSet RsPro = new DataSet();
			
			RsPro = Module1.getSqldb("select promo_id from promo_hdr where getdate() Between Start_Date And End_Date And aktif=1",
				Module1.ConnLocal);
			
			Module1.VAda_Promo = System.Convert.ToBoolean(RsPro.Tables[0].Rows.Count);
			RsPro.Clear();
			RsPro = Module1.getSqldb("select distinct list_id from Item_Master_Listing where getdate() Between Start_Date And End_Date and active=1",
				Module1.ConnLocal);
			Module1.VAda_Promo = System.Convert.ToBoolean(RsPro.Tables[0].Rows.Count);
			RsPro.Clear();
			RsPro = Module1.getSqldb("Select * from informasi", Module1.ConnLocal);
			if (RsPro.Tables[0].Rows.Count > 0)
			{
				Module1.Tulis[16] = RsPro.Tables[0].Rows[0]["pesan1"] + Constants.vbNewLine + RsPro.Tables[0].Rows[0]["pesan2"] + Constants.vbNewLine +
					RsPro.Tables[0].Rows[0]["pesan3"] + Constants.vbNewLine + RsPro.Tables[0].Rows[0]["pesan4"] + Constants.vbNewLine +
					RsPro.Tables[0].Rows[0]["pesan5"] + Constants.vbNewLine + RsPro.Tables[0].Rows[0]["pesan6"] + Constants.vbNewLine +
					RsPro.Tables[0].Rows[0]["pesan7"] + Constants.vbNewLine + RsPro.Tables[0].Rows[0]["pesan8"];
			}
		}
		
		//Private Sub Isi_key()
		//    Dim RsIsi As New DataSet
		
		//    RsIsi = getSqldb("select form, menu, keycode from key_map", ConnLocal)
		//    For Each ro As DataRow In RsIsi.Tables(0).Rows
		//        If ro("KeyCode") < 122 And ro("KeyCode") > 26 Then KeyStroke(ro("KeyCode") - 27) = ro("Menu")
		//    Next
		
		//End Sub
		
		private bool Isi_Parameter()
		{
			bool returnValue = false;
			try
			{
				returnValue = true;
				DataSet Rst = new DataSet();
				DateTime tgl_aktif = default(DateTime);
				Rst = Module1.getSqldb("Select * from Branches Where Branch_ID = '" + Module1.VBranch_ID + "' ", Module1.ConnLocal);
				if (Rst.Tables[0].Rows.Count == 0)
				{
					if (Module1.VPing == "ONLINE")
					{
						Module1.getSqldb("insert into Branches(Branch_ID, Branch_Name, Company_Name, Address1, Address2, City, Zip_Code, Country, Phone," +
							"Fax, Loyalty_Check, Flag_SOD, Date_Yesterday, Date_Current, Password_Valid, Voucher_Get_Point)" +
							"(select Branch_id, Branch_Name, Company_Name, Address1, Address2, City, Zip_Code, Country, Phone," +
							"Fax , Loyalty_Check, 0, Date_Yesterday, Date_Current, Password_Valid, Voucher_Get_Point " +
							"FROM [" + Module1.ReadIni("Server", "ServerName") + "]." +
							Module1.ReadIni("Server", "DatabaseName") +".dbo.branches  " +
							"where branch_id = '" + Module1.VBranch_ID + "')", Module1.ConnLocal);
					}
					else
					{
						Interaction.MsgBox("Tabel Branches tidak lengkap", (int) Constants.vbCritical + Constants.vbOKOnly, "Oops..");
						return false;
						
					}
				}
				else
				{
					Module1.Tulis[10] = System.Convert.ToString(Rst.Tables[0].Rows[0]["branch_name"]);
					Module1.Tulis[11] = System.Convert.ToString(Rst.Tables[0].Rows[0]["company_name"]);
					Module1.Tulis[12] = System.Convert.ToString(Rst.Tables[0].Rows[0]["address1"]);
					Module1.Tulis[13] = System.Convert.ToString(Rst.Tables[0].Rows[0]["address2"]);
					Module1.Tulis[14] = System.Convert.ToString(Rst.Tables[0].Rows[0]["city"]);
					Module1.Tulis[15] = System.Convert.ToString(Rst.Tables[0].Rows[0]["zip_code"]);
					tgl_aktif = System.Convert.ToDateTime(Rst.Tables[0].Rows[0]["date_current"]);
				}
				
				
				if (Module1.VPing == "ONLINE")
				{
					Rst.Clear();
					Rst = Module1.getSqldb("Select * from [Parameters] Where [Type] = 'HargaPoint'", Module1.ConnServer);
					if (Rst.Tables[0].Rows.Count == 0)
					{
						Module1.VHargaPoint = "1000";
					}
					else
					{
						Module1.VHargaPoint = System.Convert.ToString(Rst.Tables[0].Rows[0]["Value"]);
					}
				}
				else
				{
					Module1.VHargaPoint = "1000";
				}
				
				
				Rst.Clear();
				Rst = Module1.getSqldb("Select * from Cash_Register Where Branch_ID = '" + Module1.VBranch_ID + "' and Cash_register_Id = '" +
					Module1.VReg_ID + "' ", Module1.ConnLocal);
				
				if (Rst.Tables[0].Rows.Count == 0)
				{
					if (Module1.VPing == "ONLINE")
					{
						Module1.getSqldb("insert into Cash_Register(Branch_ID, Cash_Register_ID, Spending_Program_ID, Store_Type, Void_Flag, Item_Correct_Flag, Return_Flag, Cancel_Flag, Discount_Flag, Tax_Flag," +
							"Calc_Point_Flag, Bill_No, Shift, Reset_Date, Last_Reset_Date, Disc_1, Disc_2, Disc_3, Disc_4, Disc_5, Disc_6, Disc_7, Footer_1, Footer_2, Footer_3, Footer_4, Footer_5, Footer_6, Active_Status, ZReset_Status, NPWP, SMessage1, SMessage2)" +
							"(select Branch_ID, Cash_Register_ID, Spending_Program_ID, Store_Type, Void_Flag, Item_Correct_Flag, Return_Flag, Cancel_Flag, Discount_Flag, Tax_Flag," +
							"Calc_Point_Flag, Bill_No, Shift, Reset_Date, Last_Reset_Date, Disc_1, Disc_2, Disc_3, Disc_4, Disc_5, Disc_6, Disc_7, Footer_1, Footer_2, Footer_3, Footer_4, Footer_5, Footer_6, Active_Status, ZReset_Status, NPWP, SMessage1, SMessage2 " +
							"FROM [" + Module1.ReadIni("Server", "ServerName") + "]." +
							Module1.ReadIni("Server", "DatabaseName") +".dbo.cash_register  " +
							"where branch_id = '" + Module1.VBranch_ID + "' and Cash_Register_ID='" + Module1.VReg_ID + " ')", Module1.ConnLocal);
					}
					else
					{
						Interaction.MsgBox("Tabel Cash Register tidak lengkap", (int) Constants.vbCritical + Constants.vbOKOnly, "Oops..");
						return false;
						
					}
				}
				else
				{
					if (System.Convert.ToDateTime(Rst.Tables[0].Rows[0]["reset_date"]) > Module1.GetSrvDate().Date)
					{
						if (tgl_aktif > Module1.GetSrvDate().Date)
						{
							Interaction.MsgBox("Transaksi hari ini sudah closed (Z-Reset)", (int) Constants.vbCritical + Constants.vbOKOnly, "Oops..");
							ProjectData.EndApp();
						}
					}
					
					Module1.VShift = System.Convert.ToInt32(Rst.Tables[0].Rows[0]["Shift"]);
					
					Module1.Tulis[1] = System.Convert.ToString(Rst.Tables[0].Rows[0]["Footer_1"]);
					Module1.Tulis[2] = System.Convert.ToString(Rst.Tables[0].Rows[0]["Footer_2"]);
					Module1.Tulis[3] = System.Convert.ToString(Rst.Tables[0].Rows[0]["Footer_3"]);
					Module1.Tulis[4] = System.Convert.ToString(Rst.Tables[0].Rows[0]["Footer_4"]);
					Module1.Tulis[5] = System.Convert.ToString(Rst.Tables[0].Rows[0]["Footer_5"]);
					Module1.Tulis[6] = System.Convert.ToString(Rst.Tables[0].Rows[0]["Footer_6"]);
					Module1.Tulis[7] = System.Convert.ToString(Rst.Tables[0].Rows[0]["SMessage1"]);
					Module1.Tulis[8] = System.Convert.ToString(Rst.Tables[0].Rows[0]["SMessage2"]);
					Module1.Tulis[9] = System.Convert.ToString(Rst.Tables[0].Rows[0]["NPWP"]);
					return returnValue;
				}
			}
			catch (Exception)
			{
				Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) Constants.vbCritical + Constants.vbOKOnly, "Oops..");
				Module1.SaveLog(this.Name + " " + "Isi_Parameter " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			return returnValue;
		}
		
		public object CEKLPT(bool cek)
		{
			object strOut = null;
			string strPRT = "";
			if (Module1.PPort.ToString().ToLower() == "lpt1")
			{
				strPRT = System.Convert.ToString(379);
				while (cek != false)
				{
					//UPGRADE_WARNING: Couldn't resolve default property of object strOut. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					strOut = Conversion.Str(Module1.Inp(System.Convert.ToInt32(Conversion.Val("&H" + strPRT))));
					//UPGRADE_WARNING: Couldn't resolve default property of object strOut. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					//Module1.Out(System.Convert.ToInt32(Conversion.Val("&H" + strPRT)), System.Convert.ToInt32(Conversion.Val(strOut)));
					//UPGRADE_WARNING: Couldn't resolve default property of object strOut. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					if (double.Parse(strPRT) == 379 & (int) strOut == 127)
					{
						Interaction.MsgBox("Printer belum dinyalakan", MsgBoxStyle.Exclamation, "Warning");
					}
					else
					{
						//UPGRADE_WARNING: Couldn't resolve default property of object strOut. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						if (double.Parse(strPRT) == 379 & (int) strOut == 119 | (int) strOut == 103)
						{
							Interaction.MsgBox("Kertas Printer Habis", MsgBoxStyle.Exclamation, "Warning");
						}
						else
						{
							cek = false;
						}
					}
				}
			}
			return cek;
		}
		
		
		
		private void OpenKoneksi(string SrvName, object Strheader)
		{
			try
			{
				DataSet dsCek = new DataSet();
				dsCek = Module1.getSqldb("Select top 1 * from item_master", SrvName);
			}
			catch
			{
				if (Information.Err().Number == double.Parse("-2147467259"))
				{
					//UPGRADE_WARNING: Couldn't resolve default property of object Strheader. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Interaction.MsgBox("Database " + System.Convert.ToString(Strheader) + " tidak terkoneksi. " + Constants.vbNewLine + "Harap hubungi IT. ", (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				}
				else
				{
					Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				}
				Module1.SaveLog("OpenKoneksi " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number));
				ProjectData.EndApp();
			}
		}
		
		public void BackgroundWorker1_DoWork(System.Object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			Mulai();
		}
		
		public void BackgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
		{
			ProgressBar1.Visible = false;
			if (Isi_Parameter())
			{
				this.Hide();
				//Call CEKLPT(True)
				Module1.EODFirstForm = false;
				frmSOD.Default.Show();
				//If VPing = "ONLINE" Then
				//    FirstForm.Show()
				//    'frmShowStock.Show()
				//End If
			}
		}
		
		public void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			ProgressBar1.Value = e.ProgressPercentage;
		}
		
	}
	
}
