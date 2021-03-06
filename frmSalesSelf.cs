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

using VB = Microsoft.VisualBasic;
using System.Data.SqlClient;
using Symbol.RFID3;
//using Symbol.RFID3.TagAccess.Sequence;
using static Symbol.RFID3.Events;
using System.ComponentModel;
using System.Threading;
using iPOS;

//Imports RACReaderAPI
//Imports RACReaderAPI.MyInterface
//Imports RACReaderAPI.Models
namespace iPOS
{
	
	public partial class frmSalesSelf : System.Windows.Forms.Form
	{
		public frmSalesSelf()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmSalesSelf defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmSalesSelf Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmSalesSelf();
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
		//Implements IAsynchronousMessage
		string[] Qty;
		DataSet dsSales = new DataSet();
		string PLU_SPG;
		string VTukar_Point;
		short TxtNom;
		int xdisc_value;
		//Shared param_Set As Param_Set = New Param_Set()
		internal RFIDReader m_ReaderAPI;
		//Shared rfid_Option As RFID_Option = New RFID_Option()
		public Hashtable m_TagTable;
		private UpdateStatus m_UpdateStatusHandler = null;
		private UpdateRead m_UpdateReadHandler = null;
		bool RFIDStatus;
		private int rowIndex = 0;
		bool awal = true;
		public void Update_MySTAR()
		{
			DataSet RsMem = new DataSet();
			
			RsMem = Module1.getSqldb("select card_number, point_of_card_program from sales_transactions where transaction_number = '" + vno_trans.Text + "'", Module1.ConnLocal);
			if (RsMem.Tables[0].Rows.Count > 0)
			{
				Point.MySTAR(Strings.Trim(System.Convert.ToString(RsMem.Tables[0].Rows[0]["card_number"])));
			}
			txtcard_no.Text = Strings.UCase(System.Convert.ToString(RsMem.Tables[0].Rows[0]["card_number"]));
			Module1.Star_No = Strings.UCase(System.Convert.ToString(RsMem.Tables[0].Rows[0]["card_number"]));
			
			txtcust_name.Text = Module1.Star_Nm;
			txtcust_id.Text = Module1.Star_Id;
			//txtpoint.Text = CStr(Star_Pt)
			Module1.VBonus_Point = System.Convert.ToByte(RsMem.Tables[0].Rows[0]["Point_Of_Card_Program"]);
			RsMem.Clear();
			RsMem = null;
		}
		
		
		
		private string Gen_No()
		{
			string returnValue = "";
			DataSet RsCari = new DataSet();
			
			RsCari = Module1.getSqldb("SELECT  max (CAST(RIGHT(Transaction_Number, 4) AS int)) AS nomor " + "FROM Sales_Transactions where LEFT(transaction_number,16)='" + Module1.VBranch_ID + Module1.VReg_ID + "-" + Strings.Format(Module1.GetSrvDate(), "ddMMyyyy") + "' ", Module1.ConnLocal);
			
			if (Information.IsDBNull(RsCari.Tables[0].Rows[0]["nomor"]))
			{
				returnValue = Module1.VBranch_ID + Module1.VReg_ID + "-" + Strings.Format(Module1.GetSrvDate(), "ddMMyyyy") + "-0001";
			}
			else
			{
				returnValue = Module1.VBranch_ID + Module1.VReg_ID + "-" + Strings.Format(Module1.GetSrvDate(), "ddMMyyyy") + "-" + VB.Strings.Right("000" + System.Convert.ToString(System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["nomor"]) + 1), 4);
			}
			RsCari.Clear();
			RsCari = null;
			return returnValue;
		}
		
		
		//no1
		//Private Sub Bayar_Point()
		
		//    Dim RsByrPoint As New DataSet
		
		//    RsByrPoint = getSqldb("select SUM(qty*points_received) as byr_pt, SUM(qty*flag_void) as byr_rp from Sales_Transaction_Details where transaction_number='" & vno_trans.Text & "'", ConnLocal)
		
		//    If RsByrPoint.Tables(0).Rows.Count > 0 And RsByrPoint.Tables(0).Rows(0).Item("byr_pt") > 0 Then
		//        If RsByrPoint.Tables(0).Rows(0).Item("byr_pt") < Star_Pt Then
		//            VTukar_Point = Pay_Point(RsByrPoint.Tables(0).Rows(0).Item("byr_pt"), Star_No, vno_trans.Text, RsByrPoint.Tables(0).Rows(0).Item("byr_rp"))
		//            If VTukar_Point <> "GAGAL" Then
		//                getSqldb("Delete from paid where transaction_number='" & vno_trans.Text & "'", ConnLocal)
		
		//                getSqldb("INSERT Into Paid(Transaction_Number, Payment_Types, Seq, Currency_ID, " & "Currency_Rate, Credit_Card_No, Credit_Card_Name, Paid_Amount, Shift) VALUES ('" & vno_trans.Text & "','5','1','IDR','1','" & Star_No & "','" & VTukar_Point & "'," & RsByrPoint.Tables(0).Rows(0).Item("byr_rp") & ",'" & VShift & "')", ConnLocal)
		
		//                VDiscBySTAR = RsByrPoint.Tables(0).Rows(0).Item("byr_rp")
		//            Else
		//                MsgBox("Pembayaran dengan point reward GAGAL", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
		//            End If
		//        Else
		//            MsgBox("Point reward tidak mencukupi untuk pembayaran", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
		//        End If
		//    End If
		//    RsByrPoint.Clear()
		//    RsByrPoint = Nothing
		//End Sub
		
		//no1
		//Private Function Cari_Item_Rewards(ByRef kode As Object) As String
		//    Dim RsCari As New DataSet
		
		//    RsCari = getSqldb("select plu, point, rupiah from item_rewards where plu = '" & Trim(kode) & "' and getdate() Between Start_Date And End_Date and aktif=1 ", ConnServer)
		
		//    If RsCari.Tables(0).Rows.Count > 0 Then
		//        If MsgBox("Apakah item ini akan dibayar dengan point rewards?", MsgBoxStyle.YesNo + MsgBoxStyle.OkOnly, "Oops..") = MsgBoxResult.Yes Then
		
		//            getSqldb("update sales_transaction_details set points_received='" & RsCari.Tables(0).Rows(0).Item("Point") & "' , flag_void='" & RsCari.Tables(0).Rows(0).Item("rupiah") & "' where plu='" & kode & "' and transaction_number='" & vno_trans.Text & "'", ConnLocal)
		//        End If
		//    End If
		
		//    RsCari.Clear()
		//    RsCari = Nothing
		//    Return kode
		//End Function
		public void txtkode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			string Cmd;
			
			string[] CekPLU;
			string RealPLU = "";
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					CekPLU = txtkode.Text.Split('*');
					//On Error Goto ErrH VBConversions Warning: could not be converted to try/catch - logic too complex
					if (CekPLU[0].Length > 10)
					{
						RealPLU = CekPLU[0];
					}
					else
					{
						RealPLU = CekPLU[1];
					}
					if (RealPLU.Trim().Length > 14)
					{
						
					}
					else
					{
						if (Cari_PLU(VB.Strings.Right(RealPLU.Trim(), 14)) == true)
						{
							DataSet dsCekPaid = new DataSet();
							Qty = txtkode.Text.Split('*');
							vqty.Text = System.Convert.ToString((System.Convert.ToString(System.Convert.ToInt32(Qty[0])).Length > 10) ? 1 : (System.Convert.ToInt32(Qty[0])));
							if (vqty.Text == "")
							{
								vqty.Text = System.Convert.ToString(1);
							}
							if (this.Text == "REFUND")
							{
								vqty.Text = System.Convert.ToString((double.Parse(vqty.Text)) * -1);
							}
							
							//vflag = 0 Barang Direct, vflag = 1 Barang Konsinyasi
							//If CDbl(vflag.Text) = 0 And CDbl(vdisc1.Text) <> 0 And vpromo.Text <> "disc" Then
							//    If Not Super(1) Then Exit Sub
							//End If
							
							Module1.VOK = false;
							if (double.Parse(vflag.Text) == 1)
							{
								this.TopMost = false;
								frmHarga.Default.ShowDialog();
								frmHarga.Default.TopMost = true;
							}
							
							//vdiscrp1.Text = CDec(CDbl(vqty.Text) * CDbl(vharga.Text) * CDbl(vdisc1.Text) / 100).ToString("N0")
							//vdiscrp2.Text = CDec((CDbl(vqty.Text) * CDbl(vharga.Text) - CDbl(vdiscrp1.Text)) * CDbl(vdisc2.Text) / 100).ToString("N0")
							vtotal.Text = System.Convert.ToString((double.Parse(vqty.Text)) * double.Parse(vharga.Text));
							
							if (Module1.VOK == true || double.Parse(vflag.Text) == 0)
							{
								vgtotal.Text = System.Convert.ToString(Conversion.Val(vgtotal.Text) + Conversion.Val(vtotal.Text));
								lblqty.Text = System.Convert.ToString(Conversion.Val(lblqty.Text.Replace(" Pcs", "")) + double.Parse(vqty.Text));
								lblqty.Text = lblqty.Text + " pcs";
								lblgrand_total.Text = System.Convert.ToString((decimal.Parse(vgtotal.Text)).ToString("N0"));
								dsCekPaid = Module1.getSqldb("SELECT * from paid where transaction_number = '" + vno_trans.Text + "' And Payment_types <> '31'", Module1.ConnLocal);
								if (dsCekPaid.Tables[0].Rows.Count > 0)
								{
									txtkode.Focus();
									return;
								}
								Simpan_Header();
								Simpan_Detail();
								Cetak.CDisplay(VB.Strings.Left(vdesc.Text, 20), VB.Strings.Left(vqty.Text + " pcs Rp. " + (decimal.Parse(vgtotal.Text)).ToString("N0"), 20));
								//PEMBAYARAN DENGAN POINT REWARDS
								//no1
								//If Star_No <> "CM000-00000" Then
								//    If Linked() Then Call Cari_Item_Rewards((txtkode.Text))
								//End If
							}
							ViewRelease(vno_trans.Text);
							
						}
					}
					System.Windows.Forms.SendKeys.Send("{home}+{end}");
					txtkode.Focus();
					goto _1;
ErrH:
					Interaction.MsgBox("PLU tidak terdaftar", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
					System.Windows.Forms.SendKeys.Send("{home}+{end}");
					txtkode.Focus();
					break;
				case (System.Windows.Forms.Keys) 27:
					Kosong();
					break;
				case (System.Windows.Forms.Keys) 38:
					break;
					//Grid1.MovePrevious()
				case (System.Windows.Forms.Keys) 40:
					break;
					//Grid1.MoveNext()
				default:
					//On Error Resume Next VBConversions Warning: On Error Resume Next not supported in C#
					//Cmd = Module1.KeyStroke[e.KeyCode];
					break;
			}
_1:
			if (e.KeyCode == Keys.Enter)
			{
				//Menghilangkan Bunyi Beep
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
			
		}
		public void ViewRelease(string no)
		{
			
			dsSales.Clear();
			dsSales = Module1.getSqldb("SELECT Seq, Flag_Paket_Discount, RTRIM(PLU) As PLU, Item_Description, Price, Qty, Discount_Percentage, " +
				"Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, flag_void,RTRIM(Epc_Code) as Epc_Code FROM Sales_Transaction_Details " +
				"where transaction_number='" + no + "'", Module1.ConnLocal);
			if (dsSales.Tables[0].Rows.Count > 0)
			{
				DataGridView1.DataSource = dsSales.Tables[0];
				DataGridView1.Columns[0].HeaderText = "No";
				DataGridView1.Columns[0].Width = 30;
				DataGridView1.Columns[1].HeaderText = "SPG";
				DataGridView1.Columns[1].Width = 40;
				//DataGridView1.Columns(1).Visible = False
				DataGridView1.Columns[2].HeaderText = "PLU";
				DataGridView1.Columns[2].Width = 90;
				DataGridView1.Columns[3].HeaderText = "Deskripsi";
				DataGridView1.Columns[3].Width = 130;
				DataGridView1.Columns[4].HeaderText = "Harga";
				DataGridView1.Columns[4].Width = 60;
				DataGridView1.Columns[4].DefaultCellStyle.Format = "N0";
				DataGridView1.Columns[5].HeaderText = "Qty";
				DataGridView1.Columns[5].Width = 30;
				DataGridView1.Columns[5].DefaultCellStyle.Format = "N0";
				DataGridView1.Columns[6].HeaderText = "Disc1";
				DataGridView1.Columns[6].Width = 40;
				DataGridView1.Columns[6].Visible = false;
				DataGridView1.Columns[6].DefaultCellStyle.Format = "N0";
				DataGridView1.Columns[7].HeaderText = "Disc";
				DataGridView1.Columns[7].Width = 50;
				DataGridView1.Columns[7].Visible = true;
				DataGridView1.Columns[7].DefaultCellStyle.Format = "N0";
				DataGridView1.Columns[8].HeaderText = "Disc2";
				DataGridView1.Columns[8].Width = 40;
				DataGridView1.Columns[8].Visible = false;
				DataGridView1.Columns[8].DefaultCellStyle.Format = "N0";
				DataGridView1.Columns[9].HeaderText = "Disc2 Rp";
				DataGridView1.Columns[9].Width = 80;
				DataGridView1.Columns[9].Visible = false;
				DataGridView1.Columns[9].DefaultCellStyle.Format = "N0";
				DataGridView1.Columns[10].HeaderText = "Jumlah";
				DataGridView1.Columns[10].Width = 70;
				DataGridView1.Columns[10].DefaultCellStyle.Format = "N0";
				DataGridView1.Columns[11].Visible = false;
				DataGridView1.Columns[12].Visible = false;
				Kosong();
				vgtotal.Text = System.Convert.ToString(0);
				lblqty.Text = System.Convert.ToString(0);
				if (dsSales.Tables[0].Rows.Count > 0)
				{
					foreach (DataRow ro in dsSales.Tables[0].Rows)
					{
						vgtotal.Text = vgtotal.Text + ro["Net_Price"];
						lblqty.Text = System.Convert.ToString(Conversion.Val(lblqty.Text.Replace(" pcs", "")) + System.Convert.ToDouble(ro["Qty"]));
					}
				}
				lblqty.Text = lblqty.Text + " pcs";
				lblgrand_total.Text = System.Convert.ToString((decimal.Parse(vgtotal.Text)).ToString("N0"));
				txtkode.Select();
				txtkode.Focus();
			}
		}
		public void Simpan_Header()
		{
			try
			{
				DataSet RsCari = new DataSet();
				
				RsCari = Module1.getSqldb("SELECT Transaction_Number FROM Sales_Transactions where transaction_number='" + vno_trans.Text + "' ", Module1.ConnLocal);
				
				if (RsCari.Tables[0].Rows.Count == 0)
				{
					Module1.StrSQL = System.Convert.ToString("INSERT INTO Sales_Transactions(Transaction_Number, Cashier_ID, Customer_ID, Card_Number, Spending_Program_ID, " +
						"Transaction_Date, Total_Discount, " + "Points_Of_Spending_Program, Point_Of_Item_Program, Point_Of_Card_Program, " +
						"Payment_Program_ID, Branch_ID, Cash_Register_ID, Total_Paid, Net_Price, Tax, " + "Net_Amount, Change_Amount, " +
						"Flag_Arrange, WorkManShip, Flag_Return, Register_Return, Transaction_Date_Return, Transaction_Number_Return, " +
						"Last_Point, " + "Get_Point, Status, Upload_Status, Transaction_Time, Store_Type)" + "" +
						"VALUES ('" + vno_trans.Text + "','" + Module1.VKasir_ID + "','" + txtcust_id.Text + "','" + txtcard_no.Text + "'," +
						"'0','" + System.Convert.ToString(Module1.GetSrvDate().Date) + "',0,0,0," + System.Convert.ToString(Module1.VBonus_Point) + ",'','" + Module1.VBranch_ID + "','" + Module1.VReg_ID + "'," +
						"0,0,0," + vgtotal.Text + ",0,0,0,'" + System.Convert.ToString(this.Text.Trim() == "SALES" ? 0 : 1) + "','',NULL,'',0,0,'01','00'," +
						"'" + Strings.Format(Module1.GetSrvDate(), "HH:mm") + "','1')");
				}
				else
				{
					Module1.StrSQL = "update sales_transactions set net_amount=" + vgtotal.Text + ", card_number='" + txtcard_no.Text + "'," +
						"customer_id='" + txtcust_id.Text + "', Point_Of_Card_Program=" + System.Convert.ToString(Module1.VBonus_Point) + " where " +
						"transaction_number='" + vno_trans.Text + "' ";
				}
				Module1.SaveLog(this.Name + " " + "Simpan_Header " + vno_trans.Text + " " + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
_0:
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				RsCari.Clear();
				RsCari = null;
			}
			catch
			{
				Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				Module1.SaveLog(this.Name + " " + "Simpan_Header " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			
		}
		
		public void Simpan_HeaderRFID()
		{
			try
			{
				DataSet RsCari = new DataSet();
				vqty.Text = System.Convert.ToString(Module1.vqtyRFID);
				vdiscrp1.Text = System.Convert.ToString(Module1.vdiscrp1RFID);
				vdiscrp2.Text = System.Convert.ToString(Module1.vdiscrp2RFID);
				vtotal.Text = System.Convert.ToString(Module1.vtotalRFID);
				vgtotal.Text = System.Convert.ToString(Module1.vgtotalRFID);
				txtcust_id.Text = Module1.txtcust_idRFID;
				RsCari = Module1.getSqldb("SELECT Transaction_Number FROM Sales_Transactions where transaction_number='" + Module1.vno_transRFID + "' ", Module1.ConnLocal);
				
				if (RsCari.Tables[0].Rows.Count == 0)
				{
					Module1.StrSQL = System.Convert.ToString("INSERT INTO Sales_Transactions(Transaction_Number, Cashier_ID, Customer_ID, Card_Number, Spending_Program_ID, " +
						"Transaction_Date, Total_Discount, " + "Points_Of_Spending_Program, Point_Of_Item_Program, Point_Of_Card_Program, " +
						"Payment_Program_ID, Branch_ID, Cash_Register_ID, Total_Paid, Net_Price, Tax, " + "Net_Amount, Change_Amount, " +
						"Flag_Arrange, WorkManShip, Flag_Return, Register_Return, Transaction_Date_Return, Transaction_Number_Return, " +
						"Last_Point, " + "Get_Point, Status, Upload_Status, Transaction_Time, Store_Type)" + "" +
						"VALUES ('" + Module1.vno_transRFID + "','" + Module1.VKasir_ID + "','" + txtcust_id.Text + "','" + txtcard_no.Text + "'," +
						"'0','" + System.Convert.ToString(Module1.GetSrvDate().Date) + "',0,0,0," + System.Convert.ToString(Module1.VBonus_Point) + ",'','" + Module1.VBranch_ID + "','" + Module1.VReg_ID + "'," +
						"0,0,0," + vgtotal.Text + ",0,0,0,'" + System.Convert.ToString(this.Text.Trim() == "SALES" ? 0 : 1) + "','',NULL,'',0,0,'01','00'," +
						"'" + Strings.Format(Module1.GetSrvDate(), "HH:mm") + "','1')");
				}
				else
				{
					Module1.StrSQL = "update sales_transactions set net_amount=" + vgtotal.Text + ", card_number='" + txtcard_no.Text + "'," +
						"customer_id='" + txtcust_id.Text + "', Point_Of_Card_Program=" + System.Convert.ToString(Module1.VBonus_Point) + " where " +
						"transaction_number='" + Module1.vno_transRFID + "' ";
				}
_0:
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				Module1.SaveLog(this.Name + " " + "Simpan_Header_Rapid " + vno_trans.Text + " " + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
				RsCari.Clear();
				RsCari = null;
			}
			catch
			{
				Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				Module1.SaveLog(this.Name + " " + "Simpan_Header_Rapid " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			
		}
		
		public void Simpan_HeaderRFIDZebra()
		{
			try
			{
				DataSet RsCari = new DataSet();
				vqty.Text = System.Convert.ToString(Module1.vqtyRFID);
				vdiscrp1.Text = System.Convert.ToString(Module1.vdiscrp1RFID);
				vdiscrp2.Text = System.Convert.ToString(Module1.vdiscrp2RFID);
				vtotal.Text = System.Convert.ToString(Module1.vtotalRFID);
				vgtotal.Text = System.Convert.ToString(Module1.vgtotalRFID);
				RsCari = Module1.getSqldb("SELECT Transaction_Number FROM Sales_Transactions where transaction_number='" + vno_trans.Text + "' ", Module1.ConnLocal);
				
				if (RsCari.Tables[0].Rows.Count == 0)
				{
					Module1.StrSQL = System.Convert.ToString("INSERT INTO Sales_Transactions(Transaction_Number, Cashier_ID, Customer_ID, Card_Number, Spending_Program_ID, " +
						"Transaction_Date, Total_Discount, " + "Points_Of_Spending_Program, Point_Of_Item_Program, Point_Of_Card_Program, " +
						"Payment_Program_ID, Branch_ID, Cash_Register_ID, Total_Paid, Net_Price, Tax, " + "Net_Amount, Change_Amount, " +
						"Flag_Arrange, WorkManShip, Flag_Return, Register_Return, Transaction_Date_Return, Transaction_Number_Return, " +
						"Last_Point, " + "Get_Point, Status, Upload_Status, Transaction_Time, Store_Type)" + "" +
						"VALUES ('" + vno_trans.Text + "','" + Module1.VKasir_ID + "','" + txtcust_id.Text + "','" + txtcard_no.Text + "'," +
						"'0','" + System.Convert.ToString(Module1.GetSrvDate().Date) + "',0,0,0," + System.Convert.ToString(Module1.VBonus_Point) + ",'','" + Module1.VBranch_ID + "','" + Module1.VReg_ID + "'," +
						"0,0,0," + vgtotal.Text + ",0,0,0,'" + System.Convert.ToString(this.Text.Trim() == "SALES" ? 0 : 1) + "','',NULL,'',0,0,'01','00'," +
						"'" + Strings.Format(Module1.GetSrvDate(), "HH:mm") + "','1')");
				}
				else
				{
					Module1.StrSQL = "update sales_transactions set net_amount=" + vgtotal.Text + ", card_number='" + txtcard_no.Text + "'," +
						"customer_id='" + txtcust_id.Text + "', Point_Of_Card_Program=" + System.Convert.ToString(Module1.VBonus_Point) + " where " +
						"transaction_number='" + vno_trans.Text + "' ";
				}
_0:
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				Module1.SaveLog(this.Name + " " + "Simpan_Header_Zebra " + vno_trans.Text + " " + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
				RsCari.Clear();
				RsCari = null;
			}
			catch
			{
				Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				Module1.SaveLog(this.Name + " " + "Simpan_Header_Zebra " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			
		}
		
		private string Gen_Seq(string no)
		{
			string returnValue = "";
			DataSet RsCari = new DataSet();
			
			RsCari = Module1.getSqldb("select ISNULL(MAX(seq),0) as urut from Sales_Transaction_Details where Transaction_Number = '" + no + "'", Module1.ConnLocal);
			returnValue = System.Convert.ToString(System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["urut"]) + 1);
			RsCari.Clear();
			RsCari = null;
			return returnValue;
		}
		private string Siapa_SPG(object kode)
		{
			string returnValue = "";
			DataSet RsCari = new DataSet();
			
			RsCari = Module1.getSqldb("select spg_id, spg_name from spg where spg_id = '" + Strings.Trim(System.Convert.ToString(kode)) + "'", Module1.ConnLocal);
			
			returnValue = System.Convert.ToString((RsCari.Tables[0].Rows.Count > 0) ? (RsCari.Tables[0].Rows[0]["spg_name"]) : "");
			
			RsCari.Clear();
			RsCari = null;
			return returnValue;
		}
		
		
		private void Cek_Promo()
		{
			DataSet RsPromo = new DataSet();
			DataSet RsAmbil = new DataSet();
			DataSet RsKaryawan = new DataSet();
			short xqty = 0;
			int xharga = 0;
			int xdisc1_amt = 0;
			byte xdisc1 = 0;
			byte Pro_tipe = 0;
			byte Pro_Disc = 0;
			string Pro_Nm = "";
			string Nama_Promo = "";
			DataSet DsSales2 = new DataSet();
			SqlConnection m_con = default(SqlConnection);
			m_con = new System.Data.SqlClient.SqlConnection(Module1.ConnLocal);
			System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
			System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
			DsSales2.Clear();
			cmd = m_con.CreateCommand();
			cmd.CommandText = "SELECT * FROM Sales_Transaction_Details " +
				"where transaction_number='" + vno_trans.Text + "'";
			cmd.CommandTimeout = 120;
			da.SelectCommand = cmd;
			if (m_con.State == ConnectionState.Open)
			{
				m_con.Close();
			}
			m_con.Open();
_1:
			try
			{
				System.Data.SqlClient.SqlCommandBuilder ObjCmdBuil = new System.Data.SqlClient.SqlCommandBuilder(da);
				da.Fill(DsSales2);
				vgtotal.Text = System.Convert.ToString(0);
				if (DsSales2.Tables[0].Rows.Count > 0)
				{
					foreach (DataRow ro in DsSales2.Tables[0].Rows)
					{
						xqty = System.Convert.ToInt16(ro["Qty"]);
						xharga = System.Convert.ToInt32(ro["price"]);
						
						Cari_Promo(System.Convert.ToString(ro["plu"]), vno_trans.Text, ref Pro_tipe, ref Pro_Nm, ref Pro_Disc, System.Convert.ToByte(ro["Seq"]), " and tipe not in (5,6)");
						
						if (Pro_tipe == ((byte) 0)) //tidak ada promo
						{
							xdisc1 = System.Convert.ToByte(ro["Discount_Percentage"]);
						}
						else if (((Pro_tipe == ((byte) 2)) || (Pro_tipe == ((byte) 17))) || (Pro_tipe == ((byte) 18)))
						{
							xdisc1 = Pro_Disc;
							ro["ExtraDisc_pct"] = 0;
							ro["ExtraDisc_amt"] = 0;
						}
						else if (Pro_tipe == ((byte) 7))
						{
							xdisc1 = Pro_Disc;
						}
						else
						{
							xdisc1 = (byte) 0;
						}
loncat:
						
						xdisc1_amt = System.Convert.ToInt32(xqty * xharga * (xdisc1 / 100));
						ro["Discount_Percentage"] = xdisc1;
						ro["Discount_Amount"] = xdisc1_amt;
						ro["Net_Price"] = xqty * xharga - xdisc1_amt - System.Convert.ToInt32(ro["ExtraDisc_amt"]);
						vgtotal.Text = vgtotal.Text + ro["Net_Price"];
					}
					da.Update(DsSales2);
				}
				
			}
			catch (Exception ex)
			{
				//GoTo 1
				MessageBox.Show(ex.Message);
			}
			m_con.Close();
			lblgrand_total.Text = System.Convert.ToString((decimal.Parse(vgtotal.Text)).ToString("N0"));
			
		}
		
		private void Cek_Promo2()
		{
			DataSet RsPromo = new DataSet();
			DataSet RsAmbil = new DataSet();
			DataSet RsKaryawan = new DataSet();
			short xqty = 0;
			int xharga = 0;
			int xdisc1_amt = 0;
			byte xdisc1 = 0;
			byte Pro_tipe = 0;
			byte Pro_Disc = 0;
			string Pro_Nm = "";
			string Nama_Promo = "";
			DataSet DsSales2 = new DataSet();
			SqlConnection m_con = default(SqlConnection);
			m_con = new System.Data.SqlClient.SqlConnection(Module1.ConnLocal);
			System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter();
			System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
			DsSales2.Clear();
			cmd = m_con.CreateCommand();
			cmd.CommandText = "SELECT * FROM Sales_Transaction_Details " +
				"where transaction_number='" + vno_trans.Text + "'";
			cmd.CommandTimeout = 120;
			da.SelectCommand = cmd;
			if (m_con.State == ConnectionState.Open)
			{
				m_con.Close();
			}
			m_con.Open();
_1:
			try
			{
				System.Data.SqlClient.SqlCommandBuilder ObjCmdBuil = new System.Data.SqlClient.SqlCommandBuilder(da);
				da.Fill(DsSales2);
				vgtotal.Text = System.Convert.ToString(0);
				if (DsSales2.Tables[0].Rows.Count > 0)
				{
					foreach (DataRow ro in DsSales2.Tables[0].Rows)
					{
						xdisc1 = System.Convert.ToByte(ro["Discount_Percentage"]);
						xqty = System.Convert.ToInt16(ro["Qty"]);
						xharga = System.Convert.ToInt32(ro["price"]);
						
						Cari_Promo(System.Convert.ToString(ro["plu"]), vno_trans.Text, ref Pro_tipe, ref Pro_Nm, ref Pro_Disc, System.Convert.ToByte(ro["Seq"]), " and tipe in (5,6)");
						
						if ((Pro_tipe == ((byte) 5)) || (Pro_tipe == ((byte) 6)))
						{
							Module1.VDiscBySTAR += System.Convert.ToInt32((xqty * xharga - System.Convert.ToInt32(ro["Discount_Amount"]) - System.Convert.ToInt32(ro["ExtraDisc_amt"])) * Pro_Disc / 100);
							Nama_Promo = Pro_Nm;
						}
loncat:
						
						xdisc1_amt = System.Convert.ToInt32(xqty * xharga * (xdisc1 / 100));
						ro["Discount_Percentage"] = xdisc1;
						ro["Discount_Amount"] = xdisc1_amt;
						ro["Net_Price"] = xqty * xharga - xdisc1_amt - System.Convert.ToInt32(ro["ExtraDisc_amt"]);
						vgtotal.Text = vgtotal.Text + ro["Net_Price"];
					}
					da.Update(DsSales2);
				}
				
			}
			catch (Exception ex)
			{
				//GoTo 1
				MessageBox.Show(ex.Message);
			}
			m_con.Close();
			
			if (Module1.VDiscBySTAR != 0)
			{
				Module1.getSqldb("INSERT Into Paid(Transaction_Number, Payment_Types, Seq, Currency_ID, Currency_Rate, Credit_Card_No, Credit_Card_Name, Paid_Amount, Shift) " +
					" VALUES ('" + vno_trans.Text + "','31','1','IDR','1','','" + Nama_Promo + "'," + System.Convert.ToString(Module1.VDiscBySTAR) + ",'" + System.Convert.ToString(Module1.VShift) + "')", Module1.ConnLocal);
			}
			lblgrand_total.Text = System.Convert.ToString((decimal.Parse(vgtotal.Text)).ToString("N0"));
			ViewRelease(vno_trans.Text);
		}
		
		private bool Cari_SPG(object kode)
		{
			bool returnValue = false;
			DataSet RsCari = new DataSet();
			
			returnValue = false;
			
			RsCari = Module1.getSqldb("select spg_id, spg_name from spg where spg_id = '" + Strings.Trim(System.Convert.ToString(kode)) + "'", Module1.ConnLocal);
			
			if (RsCari.Tables[0].Rows.Count > 0)
			{
				vspg.Text = System.Convert.ToString(RsCari.Tables[0].Rows[0]["spg_id"]);
				returnValue = true;
			}
			else
			{
				vspg.Text = "";
				Interaction.MsgBox("ID SPG tidak terdaftar", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
			}
			RsCari.Clear();
			RsCari = null;
			return returnValue;
		}
		private bool Cari_PLU(object kode)
		{
			bool returnValue = false;
			DataSet RsCari = new DataSet();
			DataSet RsCari2 = new DataSet();
			string StrSQLPLU = "";
			returnValue = false;
			vpromo.Text = "";
			if (this.Text == "SALES")
			{
				Module1.StrSQL = "select a.Plu,Description,Normal_Price,Current_Price,a.Flag,disc_percent,b.TID  from item_master a inner join Item_Master_RFID b on a.article_code = b.article_code where EPC = '" + System.Convert.ToString(kode) + "' and a.description <> 'TIDAK AKTIF' And b.flag = 0 And b.Status = 1 And LTRIM(RTRIM(TID)) <> ''";
			}
			else
			{
				Module1.StrSQL = "select a.Plu,Description,Normal_Price,Current_Price,a.Flag,disc_percent,b.TID  from item_master a inner join Item_Master_RFID b on a.article_code = b.article_code where EPC = '" + System.Convert.ToString(kode) + "' and a.description <> 'TIDAK AKTIF' And b.flag = 1 And b.Status = 1  And LTRIM(RTRIM(TID)) <> ''";
			}
			StrSQLPLU = "select Plu,Description,Normal_Price,Current_Price,Flag, disc_percent from item_master where plu = '" + System.Convert.ToString(kode) + "' and description <> 'TIDAK AKTIF'";
			
			//If Linked() Then
			//    RsCari = getSqldb(StrSQL, ConnServer)
			//Else
			//    RsCari = getSqldb(StrSQL, ConnLocal)
			//End If
			
			//tanpa cek PING
			if (Module1.VPing == "ONLINE")
			{
				RsCari = Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
				RsCari2 = Module1.getSqldb(StrSQLPLU, Module1.ConnServer);
			}
			else
			{
				RsCari = Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				RsCari2 = Module1.getSqldb(StrSQLPLU, Module1.ConnLocal);
			}
			
			if (RsCari.Tables[0].Rows.Count > 0)
			{
				vplu.Text = System.Convert.ToString(RsCari.Tables[0].Rows[0]["plu"]);
				vdesc.Text = System.Convert.ToString(RsCari.Tables[0].Rows[0]["Description"]);
				vharga.Text = System.Convert.ToString((System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["flag"]) == 0) ? (RsCari.Tables[0].Rows[0]["current_Price"]) : 0);
				vflag.Text = System.Convert.ToString(RsCari.Tables[0].Rows[0]["flag"]);
				vrfid.Text = System.Convert.ToString(RsCari.Tables[0].Rows[0]["TID"]);
				if (System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["disc_percent"]) > 0)
				{
					vpromo.Text = "disc";
					vdisc1.Text = System.Convert.ToString(RsCari.Tables[0].Rows[0]["disc_percent"]);
				}
				returnValue = true;
			}
			else
			{
				if (RsCari2.Tables[0].Rows.Count > 0)
				{
					vplu.Text = System.Convert.ToString(RsCari2.Tables[0].Rows[0]["plu"]);
					vdesc.Text = System.Convert.ToString(RsCari2.Tables[0].Rows[0]["Description"]);
					vharga.Text = System.Convert.ToString((System.Convert.ToInt32(RsCari2.Tables[0].Rows[0]["flag"]) == 0) ? (RsCari2.Tables[0].Rows[0]["current_Price"]) : 0);
					vflag.Text = System.Convert.ToString(RsCari2.Tables[0].Rows[0]["flag"]);
					//vrfid.Text = RsCari2.Tables(0).Rows(0).Item("TID")
					if (System.Convert.ToInt32(RsCari2.Tables[0].Rows[0]["disc_percent"]) > 0)
					{
						vpromo.Text = "disc";
						vdisc1.Text = System.Convert.ToString(RsCari2.Tables[0].Rows[0]["disc_percent"]);
					}
					returnValue = true;
				}
				else
				{
					vplu.Text = "";
					vdesc.Text = "";
					vharga.Text = System.Convert.ToString(0);
					vflag.Text = "";
					Interaction.MsgBox("PLU tidak terdaftar", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
				}
			}
			RsCari.Clear();
			RsCari = null;
			return returnValue;
		}
		
		public void Simpan_Detail()
		{
			try
			{
				Module1.getSqldb("INSERT INTO Sales_Transaction_Details(Transaction_Number, Seq, PLU, Item_Description, Price, Qty, Amount, " +
					"Discount_Percentage, Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, Points_Received, Flag_Void, Flag_Status, Flag_Paket_Discount,Epc_Code) " +
					"VALUES ('" + vno_trans.Text + "','" + Gen_Seq(vno_trans.Text) + "','" + vplu.Text + "','" + Module1.UbahChar(vdesc.Text) + "','" + vharga.Text + "','" + vqty.Text + "','" + System.Convert.ToString(System.Convert.ToInt32(vqty.Text) * double.Parse(vharga.Text)) + "','0','0','0','0','" + vtotal.Text + "','0','0','0','" + Module1.VKasir_ID + "','" + vrfid.Text + "')", Module1.ConnLocal);
				Module1.SaveLog(this.Name + " " + "Simpan_Detail" + vno_trans.Text + " " + vplu.Text + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			catch
			{
				Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				Module1.SaveLog(this.Name + " " + "Simpan_Detail " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			
		}
		
		public void Simpan_DetailRFID()
		{
			try
			{
				Module1.getSqldb("INSERT INTO Sales_Transaction_Details(Transaction_Number, Seq, PLU, Item_Description, Price, Qty, Amount, " +
					"Discount_Percentage, Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, Points_Received, Flag_Void, Flag_Status, Flag_Paket_Discount,Epc_Code) " +
					"VALUES ('" + Module1.vno_transRFID + "','" + Gen_Seq(Module1.vno_transRFID) + "','" + vplu.Text.Trim() + "','" + Module1.UbahChar(vdesc.Text) + "','" + vharga.Text + "','" + vqty.Text + "','" + System.Convert.ToString(System.Convert.ToInt32(vqty.Text) * double.Parse(vharga.Text)) + "','" + vdisc1.Text + "','" + vdiscrp1.Text + "','" + vdisc2.Text + "','" + vdiscrp2.Text + "','" + vtotal.Text + "','0','0','0','" + Module1.VKasir_ID + "','" + vrfid.Text.Trim() + "')", Module1.ConnLocal);
				Module1.SaveLog(this.Name + " " + "Simpan_Detail_Rapid " + vno_trans.Text + " " + vplu.Text + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			catch
			{
				Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				Module1.SaveLog(this.Name + " " + "Simpan_Detail_Rapid " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			
		}
		
		public void Simpan_DetailRFIDZebra()
		{
			try
			{
				DataSet dsR = new DataSet();
				dsR = Module1.getSqldb("select * from Sales_Transaction_Details where Transaction_Number = '" + vno_trans.Text + "' and Epc_Code = '" + vrfid.Text.Trim() + "'", Module1.ConnLocal);
				if (dsR.Tables[0].Rows.Count == 0)
				{
					Module1.getSqldb("INSERT INTO Sales_Transaction_Details(Transaction_Number, Seq, PLU, Item_Description, Price, Qty, Amount, " +
						"Discount_Percentage, Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, Points_Received, Flag_Void, Flag_Status, Flag_Paket_Discount,Epc_Code) " +
						"VALUES ('" + vno_trans.Text + "','" + Gen_Seq(vno_trans.Text) + "','" + vplu.Text.Trim() + "','" + Module1.UbahChar(vdesc.Text) + "','" + vharga.Text + "','" + vqty.Text + "','" + System.Convert.ToString(System.Convert.ToInt32(vqty.Text) * double.Parse(vharga.Text)) + "','0','0','0','0','" + vtotal.Text + "','0','0','0','" + Module1.VKasir_ID + "','" + vrfid.Text.Trim() + "')", Module1.ConnLocal);
					Module1.SaveLog(this.Name + " " + "Simpan_Detail_Zebra " + vno_trans.Text + " " + vplu.Text + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
					return;
				}
			}
			catch
			{
				goto ErrH;
			}
ErrH:
			Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
			Module1.SaveLog(this.Name + " " + "Simpan_Detail_Zebra " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
		}
		
		private void Cari_Promo(string codebar, string No_trans, ref byte Promo_Tipe, ref string Promo_Nm, ref byte Promo_Disc, byte Seq, string ExPromo)
		{
			DataSet RsPromo = new DataSet();
			DataSet RsHitung = new DataSet();
			DataSet RsHitung2 = new DataSet();
			byte diskon = 0;
			int min_belanja = 0;
			int jml = 0;
			
			diskon = (byte) 0;
			Promo_Tipe = (byte) 0;
			Promo_Nm = "";
			Promo_Disc = (byte) 0;
			RsPromo = Module1.getSqldb("select ph.promo_id, promo_name, min_purchase, min_member, disc, tipe, txt1, txt2 from promo_hdr ph inner join " + "promo_dtl pd on ph.promo_id=pd.promo_id where getdate() Between Start_Date And End_Date and aktif=1 " + "and tipe <30 " + ExPromo + " and  PLU ='" + codebar + "' order by tipe desc", Module1.ConnLocal);
			
			if (RsPromo.Tables[0].Rows.Count == 0)
			{
				RsPromo.Clear();
				RsPromo = null;
				return;
			}
			
			DataSet rshitmin = new DataSet();
			foreach (DataRow ro in RsPromo.Tables[0].Rows)
			{
				if (VB.Strings.Left(Module1.Star_Id, 6) == "10000000" || string.IsNullOrEmpty(Module1.Star_Id))
				{
					min_belanja = System.Convert.ToInt32(RsPromo.Tables[0].Rows[0]["min_purchase"]);
				}
				else
				{
					min_belanja = System.Convert.ToInt32(RsPromo.Tables[0].Rows[0]["min_member"]);
				}
				if ((int) (RsPromo.Tables[0].Rows[0]["tipe"]) == 2)
				{
					if (System.Convert.ToInt32(RsPromo.Tables[0].Rows[0]["disc"]) > diskon)
					{
						if (min_belanja > 0)
						{
							RsHitung = Module1.getSqldb("select SUM(qty*price) as berapa from Sales_Transaction_Details sd inner join " +
								"PROMO_DTL pd on sd.PLU = pd.PLU " + "where Transaction_Number='" + No_trans + "' " +
								"and promo_id='" + RsPromo.Tables[0].Rows[0]["promo_id"] + "'", Module1.ConnLocal);
							if (System.Convert.ToInt32(RsHitung.Tables[0].Rows[0]["Berapa"]) > 0) //sales
							{
								if (System.Convert.ToInt32(RsHitung.Tables[0].Rows[0]["Berapa"]) >= min_belanja)
								{
									diskon = System.Convert.ToByte(RsPromo.Tables[0].Rows[0]["disc"]);
								}
							}
							else //refund
							{
								if (System.Convert.ToInt32(RsHitung.Tables[0].Rows[0]["Berapa"]) <= (-1 * min_belanja))
								{
									diskon = System.Convert.ToByte(RsPromo.Tables[0].Rows[0]["disc"]);
								}
							}
							Promo_Nm = System.Convert.ToString(RsPromo.Tables[0].Rows[0]["promo_name"]);
							Promo_Tipe = System.Convert.ToByte(RsPromo.Tables[0].Rows[0]["tipe"]);
							RsHitung.Clear();
							RsHitung = null;
						}
						else
						{
							diskon = System.Convert.ToByte(RsPromo.Tables[0].Rows[0]["disc"]);
							Promo_Tipe = System.Convert.ToByte(RsPromo.Tables[0].Rows[0]["tipe"]);
							Promo_Nm = System.Convert.ToString(RsPromo.Tables[0].Rows[0]["promo_name"]);
						}
					}
					Promo_Disc = diskon;
				}
				else if ((int) (RsPromo.Tables[0].Rows[0]["tipe"]) == 5)
				{
					RsHitung = Module1.getSqldb("select SUM(qty*price-Discount_Amount-ExtraDisc_Amt) as berapa from Sales_Transaction_Details sd inner join " +
						"PROMO_DTL pd on sd.PLU = pd.PLU " + "where Transaction_Number='" + No_trans + "' " +
						"and promo_id='" + System.Convert.ToString(ro["promo_id"]) + "'", Module1.ConnLocal);
					if (System.Convert.ToInt32(RsHitung.Tables[0].Rows[0]["Berapa"]) > 0) //sales
					{
						if (System.Convert.ToInt32(RsHitung.Tables[0].Rows[0]["Berapa"]) >= min_belanja)
						{
							Promo_Tipe = System.Convert.ToByte(ro["Tipe"]);
							Promo_Nm = System.Convert.ToString(ro["promo_name"]);
							Promo_Disc = System.Convert.ToByte(ro["disc"]);
						}
					}
					else //refund
					{
						if (System.Convert.ToInt32(RsHitung.Tables[0].Rows[0]["Berapa"]) <= (-1 * min_belanja))
						{
							Promo_Tipe = System.Convert.ToByte(ro["Tipe"]);
							Promo_Nm = System.Convert.ToString(ro["promo_name"]);
							Promo_Disc = System.Convert.ToByte(ro["disc"]);
						}
					}
					RsHitung.Clear();
					RsHitung = null;
				}
				else if (((int) (RsPromo.Tables[0].Rows[0]["tipe"]) == 6) || ((int) (RsPromo.Tables[0].Rows[0]["tipe"]) == 7))
				{
					RsHitung = Module1.getSqldb("select SUM(qty*price-Discount_Amount-ExtraDisc_Amt) as berapa from Sales_Transaction_Details sd inner join " +
						"PROMO_DTL pd on sd.PLU = pd.PLU " + "where Transaction_Number='" + No_trans + "' " +
						"and promo_id='" + System.Convert.ToString(ro["promo_id"]) + "'", Module1.ConnLocal);
					if (System.Convert.ToInt32(RsHitung.Tables[0].Rows[0]["Berapa"]) > 0) //sales
					{
						if (System.Convert.ToInt32(RsHitung.Tables[0].Rows[0]["Berapa"]) >= min_belanja)
						{
							RsHitung2 = Module1.getSqldb("select * from Sales_Transaction_Details sd inner join PROMO_DTL pd on sd.PLU = pd.PLU " +
								"where Transaction_Number='" + No_trans + "' and flag_void=0 and qty=1 and promo_id='" + System.Convert.ToString(ro["promo_id"]) + "'", Module1.ConnLocal);
							
							jml = System.Convert.ToInt32(Point.roundDown(System.Convert.ToDouble((double) RsHitung2.Tables[0].Rows.Count / 2)));
							
							RsHitung2.Clear();
							RsHitung2 = Module1.getSqldb("select * from(select top " + System.Convert.ToString(jml) + " sd.seq, sd.plu from  Sales_Transaction_Details sd inner join PROMO_DTL pd " +
								"on sd.PLU = pd.PLU where Transaction_Number='" + No_trans + "' and flag_void=0 and qty=1 and promo_id='" + System.Convert.ToString(ro["promo_id"]) + "' order by amount, net_price ) aa " +
								"where PLU = '" + codebar + "' and seq='" + System.Convert.ToString(Seq) + "'", Module1.ConnLocal);
							Promo_Tipe = System.Convert.ToByte(ro["Tipe"]);
							Promo_Nm = System.Convert.ToString(ro["promo_name"]);
							if (RsHitung2.Tables[0].Rows.Count > 0)
							{
								Promo_Disc = System.Convert.ToByte(ro["disc"]);
							}
							else
							{
								Promo_Disc = (byte) 0;
							}
							
						}
					}
					else //refund
					{
						if (System.Convert.ToInt32(RsHitung.Tables[0].Rows[0]["Berapa"]) <= (-1 * min_belanja))
						{
							RsHitung2 = Module1.getSqldb("select * from Sales_Transaction_Details sd inner join PROMO_DTL pd on sd.PLU = pd.PLU " +
								"where Transaction_Number='" + No_trans + "' and flag_void=0 and qty=-1 and promo_id='" + System.Convert.ToString(ro["promo_id"]) + "'", Module1.ConnLocal);
							
							jml = System.Convert.ToInt32(Point.roundDown(System.Convert.ToDouble((double) RsHitung2.Tables[0].Rows.Count / 2)));
							
							RsHitung2.Clear();
							RsHitung2 = Module1.getSqldb("select * from(select top " + System.Convert.ToString(jml) + " sd.seq, sd.plu from  Sales_Transaction_Details sd inner join PROMO_DTL pd " +
								"on sd.PLU = pd.PLU where Transaction_Number='" + No_trans + "' and flag_void=0 and qty=-1 and promo_id='" + System.Convert.ToString(ro["promo_id"]) + "' order by amount desc, net_price desc) aa " +
								"where PLU = '" + codebar + "' and seq='" + System.Convert.ToString(Seq) + "'", Module1.ConnLocal);
							Promo_Tipe = System.Convert.ToByte(ro["Tipe"]);
							Promo_Nm = System.Convert.ToString(ro["promo_name"]);
							if (RsHitung2.Tables[0].Rows.Count > 0)
							{
								Promo_Disc = System.Convert.ToByte(ro["disc"]);
							}
							else
							{
								Promo_Disc = (byte) 0;
							}
						}
					}
					RsHitung.Clear();
					RsHitung = null;
				}
			}
			RsPromo.Clear();
			RsPromo = null;
		}
		public void Kosong()
		{
			//lblkode.Text = "ID SPG"
			vspg.Text = "";
			vplu.Text = "";
			vdesc.Text = "";
			vqty.Text = "0";
			vharga.Text = "0";
			vtotal.Text = "0";
			vflag.Text = "";
			txtkode.Text = "";
			vrfid.Text = "";
			//lblgrand_total.Text = "0"
			//lblqty.Text = "0 Pcs"
		}
		private void Cek_Harga()
		{
			DataSet dsCheck = new DataSet();
			dsCheck = Module1.getSqldb("select distinct list_id from Item_Master_Listing where getdate() Between Start_Date And End_Date and active=1", Module1.ConnLocal);
			foreach (DataRow ro in dsCheck.Tables[0].Rows)
			{
				if (this.Text == "SALES")
				{
					Module1.getSqldb("spp_Price_Check '" + vno_trans.Text + "','" + System.Convert.ToString(ro["list_id"]) + "','1'", Module1.ConnLocal);
				}
				else
				{
					Module1.getSqldb("spp_Price_Check '" + vno_trans.Text + "','" + System.Convert.ToString(ro["list_id"]) + "','0'", Module1.ConnLocal);
				}
			}
			ViewRelease(vno_trans.Text);
		}
		
		//Private Sub Button1_Click(sender As Object, e As EventArgs)
		//    vflag.Text = 0
		//    vqty.Text = 1
		//    If Me.Text = "REFUND" Then vqty.Text = CStr(CDbl(vqty.Text) * -1)
		//    If CDbl(vflag.Text) = 0 And CDbl(vdisc1.Text) <> 0 Then
		//        If Not Super(1) Then Exit Sub
		//    End If
		//    RFIDOKE = False
		//    Timer1.Enabled = True
		//    'Exec(vno_trans.Text, txtcust_id.Text, txtcard_no.Text)
		//End Sub
		
		public void Timer1_Tick(object sender, EventArgs e)
		{
			if (Module1.RFIDOKE == true)
			{
				if (Module1.RFIDType == "zebra")
				{
				}
				else
				{
					vno_trans.Text = Module1.vno_transRFID;
				}
				
				//vqty.Text = vqtyRFID
				//vdiscrp1.Text = vdiscrp1RFID
				//vdiscrp2.Text = vdiscrp2RFID
				//vtotal.Text = vtotalRFID
				//vgtotal.Text = vgtotalRFID
				//txtcust_id.Text = txtcust_idRFID
				//txtcard_no.Text = txtcard_noRFID
				//lblqty.Text = lblqtyRFID
				//lblgrand_total.Text = CDec(lblgrand_totalRFID).ToString("N0")
				
				ViewRelease(vno_trans.Text);
				Cetak.CDisplay(VB.Strings.Left(vdesc.Text, 20), VB.Strings.Left(vqty.Text + " pcs Rp. " + (decimal.Parse(vgtotal.Text)).ToString("N0"), 20));
				Timer1.Enabled = false;
				Module1.RFIDOKE = false;
			}
			
		}
		
		
		private delegate void UpdateStatus(Symbol.RFID3.Events.StatusEventData eventData);
		private delegate void UpdateRead(Symbol.RFID3.Events.ReadEventData eventData);
		
		
		
		//Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
		//    If File.Exists(Application.StartupPath & "\POS.txt") Then
		//        Using sr As New StreamReader(Application.StartupPath & "\POS.txt")
		//            vflag.Text = 0
		//            vqty.Text = 1
		//            If Me.Text = "REFUND" Then vqty.Text = CStr(CDbl(vqty.Text) * -1)
		//            If CDbl(vflag.Text) = 0 And CDbl(vdisc1.Text) <> 0 Then
		//                If Not Super(1) Then Exit Sub
		//            End If
		//            Do While sr.Peek() >= 0
		//                If Cari_PLU_RFID(Trim(sr.ReadLine().Trim)) = True Then
		//                    vdiscrp1.Text = CDec(CDbl(vqty.Text) * CDbl(vharga.Text) * CDbl(vdisc1.Text) / 100).ToString("N0")
		//                    vdiscrp2.Text = CDec((CDbl(vqty.Text) * CDbl(vharga.Text) - CDbl(vdiscrp1.Text)) * CDbl(vdisc2.Text) / 100).ToString("N0")
		//                    vtotal.Text = CStr(CDbl(vqty.Text) * CDbl(vharga.Text) - CDbl(vdiscrp1.Text) - CDbl(vdiscrp2.Text))
		//                    vgtotal.Text = CStr(Val(vgtotal.Text) + Val(vtotal.Text))
		//                    lblqty.Text = CStr(Val(lblqty.Text) + CDbl(vqty.Text))
		//                    lblgrand_total.Text = CDec(vgtotal.Text).ToString("N0")
		//                    Call Simpan_Header()
		//                    Call Simpan_Detail()
		//                End If
		//            Loop
		//        End Using
		//    End If
		//    ViewRelease(vno_trans.Text)
		//    Call CDisplay(VB.Left(vdesc.Text, 20), VB.Left(CStr(vqty.Text) & " pcs Rp. " & CDec(vgtotal.Text).ToString("N0"), 20))
		//    txtkode.Focus()
		//End Sub
		//Private Sub GPIControlMsg(ByVal gpiIndex As Integer, ByVal gpiState As Integer, ByVal startOrStop As Integer) Implements IAsynchronousMessage.GPIControlMsg
		
		//End Sub
		//Private Sub WriteDebugMsg(ByVal msg As String) Implements IAsynchronousMessage.WriteDebugMsg
		
		//End Sub
		
		//Public Shared Sub CheckCon()
		//    If (MyReader.CreateTcpConn(conID, example)) Then
		//        MsgBox("Connected!!!")
		//    End If
		//End Sub
		
		public void CheckConZebra()
		{
			m_ReaderAPI = new RFIDReader(Module1.IPReader, UInt32.Parse(Module1.PortReader), (uint) 0);
			try
			{
				if (m_ReaderAPI.IsConnected == false)
				{
					m_ReaderAPI.Connect();
					//MsgBox("Connect Succeed", MsgBoxStyle.Information, "Information")
					RFIDStatus = true;
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
				}
			}
			catch (OperationFailureException)
			{
				//MsgBox(operationException.Result)
				Interaction.MsgBox("Connect RFID Failed!!", MsgBoxStyle.Critical, "Attention");
				RFIDStatus = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		public void DisConZebra()
		{
			
			m_ReaderAPI = new RFIDReader(Module1.IPReader, UInt32.Parse(Module1.PortReader), (uint) 0);
			try
			{
				if (m_ReaderAPI.IsConnected == true)
				{
					m_ReaderAPI.Disconnect();
					MessageBox.Show("Disconnect Successfull");
				}
			}
			catch (OperationFailureException operationException)
			{
				MessageBox.Show("error");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
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
		//Public Shared Sub Exec(ByVal no As String, ByVal cust_id As String, ByVal card_no As String)
		//    Try
		//        vno_transRFID = no
		//        txtcust_idRFID = cust_id
		//        txtcard_noRFID = card_no
		//        Dim antNum As New eAntennaNo()
		//        'no antena
		//        antNum = eAntennaNo._1
		//        Dim readType As New eReadType()
		//        readType = eReadType.Single
		//        If MyReader._Tag6C.GetEPC_TID_UserData(conID, antNum, readType, 0, 2) = 0 Then
		
		//        End If
		//    Catch ex As Exception
		//        MsgBox("Gagal " + ex.ToString())
		//    End Try
		//End Sub
		
		
		//Private Sub OutPutTags(ByVal tag As Tag_Model) Implements IAsynchronousMessage.OutPutTags
		//    If Cari_PLU_RFID(Trim(tag.EPC.ToString)) = True Then
		//        vqtyRFID = 1
		//        vdiscrp1RFID = CDec(CDbl(vqtyRFID) * CDbl(vharga.Text) * CDbl(vdisc1.Text) / 100).ToString("N0")
		//        vdiscrp2RFID = CDec((CDbl(vqtyRFID) * CDbl(vharga.Text) - CDbl(vdiscrp1RFID)) * CDbl(vdisc2.Text) / 100).ToString("N0")
		//        vtotalRFID = CStr(CDbl(vqtyRFID) * CDbl(vharga.Text) - CDbl(vdiscrp1RFID) - CDbl(vdiscrp2RFID))
		//        vgtotalRFID = CStr(Val(vgtotal.Text) + Val(vtotalRFID))
		//        lblqtyRFID = lblqtyRFID + CDbl(vqtyRFID)
		//        'lblqty.Text = CStr(Val(lblqty.Text) + CDbl(vqtyRFID))
		//        lblgrand_totalRFID = CDec(vgtotalRFID).ToString("N0")
		//        'lblgrand_total.Text = CDec(vgtotalRFID).ToString("N0")
		
		//        Call Simpan_HeaderRFID()
		//        Call Simpan_DetailRFID()
		
		
		
		//    End If
		//End Sub
		
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
		
		
		
		private bool Cari_PLU_RFID(object kode)
		{
			bool returnValue = false;
			DataSet RsCari = new DataSet();
			returnValue = false;
			vpromo.Text = "";
			if (this.Text == "SALES")
			{
				Module1.StrSQL = "select a.Plu,Description,Normal_Price,Current_Price,a.Flag,disc_percent,b.TID  from item_master a inner join Item_Master_RFID b on a.article_code = b.article_code where EPC = '" + HexToString(Microsoft.VisualBasic.Strings.Left(System.Convert.ToString(kode), 26)) + "' and a.description <> 'TIDAK AKTIF' And b.flag = 0 And b.Status = 1  And LTRIM(RTRIM(TID)) <> ''";
			}
			else
			{
				Module1.StrSQL = "select a.Plu,Description,Normal_Price,Current_Price,a.Flag,disc_percent,b.TID  from item_master a inner join Item_Master_RFID b on a.article_code = b.article_code where EPC = '" + HexToString(Microsoft.VisualBasic.Strings.Left(System.Convert.ToString(kode), 26)) + "' and a.description <> 'TIDAK AKTIF' And b.flag = 1 And b.Status = 1  And LTRIM(RTRIM(TID)) <> ''";
			}
			foreach (DataGridViewRow row in DataGridView1.Rows)
			{
				if (row.Cells[12].Value.ToString().Trim() == (string) kode)
				{
					return returnValue;
				}
			}
			
			//If Linked() Then
			//    RsCari = getSqldb(StrSQL, ConnServer)
			//Else
			//    RsCari = getSqldb(StrSQL, ConnLocal)
			//End If
			
			//tanpa cek PING
			if (Module1.VPing == "ONLINE")
			{
				RsCari = Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
			}
			else
			{
				RsCari = Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
			}
			
			if (RsCari.Tables[0].Rows.Count > 0)
			{
				vplu.Text = System.Convert.ToString(RsCari.Tables[0].Rows[0]["plu"]);
				vdesc.Text = System.Convert.ToString(RsCari.Tables[0].Rows[0]["Description"]);
				vharga.Text = System.Convert.ToString((System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["flag"]) == 0) ? (RsCari.Tables[0].Rows[0]["current_Price"]) : 0);
				vflag.Text = System.Convert.ToString(RsCari.Tables[0].Rows[0]["flag"]);
				vrfid.Text = System.Convert.ToString(RsCari.Tables[0].Rows[0]["TID"]);
				if (System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["disc_percent"]) > 0)
				{
					vpromo.Text = "disc";
					vdisc1.Text = System.Convert.ToString(RsCari.Tables[0].Rows[0]["disc_percent"]);
				}
				returnValue = true;
			}
			else
			{
				vplu.Text = "";
				vdesc.Text = "";
				vharga.Text = System.Convert.ToString(0);
				vflag.Text = "";
				vrfid.Text = "";
				//MsgBox("PLU tidak terdaftar", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
			}
			RsCari.Clear();
			RsCari = null;
			return returnValue;
		}
		
		//Private Sub OutPutTagsOver() Implements IAsynchronousMessage.OutPutTagsOver
		//    'VNomor = vno_transRFID
		
		//    RFIDOKE = True
		//End Sub
		
		//Private Sub PortClosing(ByVal connID As String) Implements IAsynchronousMessage.PortClosing
		//End Sub
		
		//Private Sub PortConnecting(ByVal connID As String) Implements IAsynchronousMessage.PortConnecting
		//End Sub
		
		//Private Sub WriteLog(ByVal msg As String) Implements IAsynchronousMessage.WriteLog
		//End Sub
		
		private void Button2_Click(object sender, EventArgs e)
		{
			vflag.Text = "0";
			vqty.Text = "1";
			if (this.Text == "REFUND")
			{
				vqty.Text = System.Convert.ToString((double.Parse(vqty.Text)) * -1);
			}
			if (double.Parse(vflag.Text) == 0 && double.Parse(vdisc1.Text) != 0)
			{
				if (!Module1.Super("1"))
				{
					return;
				}
			}
			Module1.RFIDOKE = false;
			Timer1.Enabled = true;
			//Exec(vno_trans.Text, txtcust_id.Text, txtcard_no.Text)
		}
		
		public void RfidScan2_Click(object sender, EventArgs e)
		{
			if (RFIDStatus == false)
			{
				if (Module1.RFIDType == "zebra")
				{
					CheckConZebra();
				}
				txtkode.Focus();
				return;
			}
			//Call Kosong()
			try
			{
				if (RFIDStatus == false)
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
					RfidScan2.Image = Image.FromFile(Application.StartupPath + "/RFID_Refresh.ico").GetThumbnailImage(26, 26, null, IntPtr.Zero);
					RfidScan2.Text = "REFRESH";
					RfidScan2.ImageAlign = ContentAlignment.MiddleCenter;
					RfidScan2.TextAlign = ContentAlignment.BottomCenter;
					RfidScan2.TextImageRelation = TextImageRelation.Overlay;
					RfidScan2.ForeColor = Color.Green;
					RFIDStatus = true;
					Module1.getSqldb("delete from sales_transaction_details where transaction_number = '" + vno_trans.Text + "' and ISNULL(Epc_Code,'') <> ''", Module1.ConnLocal);
					Module1.getSqldb("delete from sales_transaction_details where transaction_number = '" + vno_trans.Text + "' and plu in (select PLU from Bag)", Module1.ConnLocal);
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
					RFIDStatus = false;
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
					RfidScan2.Image = Image.FromFile(Application.StartupPath + "/RFID_Refresh.ico").GetThumbnailImage(26, 26, null, IntPtr.Zero);
					RfidScan2.Text = "REFRESH";
					RfidScan2.ImageAlign = ContentAlignment.MiddleCenter;
					RfidScan2.TextAlign = ContentAlignment.BottomCenter;
					RfidScan2.TextImageRelation = TextImageRelation.Overlay;
					RfidScan2.ForeColor = Color.Green;
					RFIDStatus = true;
					Module1.getSqldb("delete from sales_transaction_details where transaction_number = '" + vno_trans.Text + "' and ISNULL(Epc_Code,'') <> ''", Module1.ConnLocal);
					Module1.getSqldb("delete from sales_transaction_details where transaction_number = '" + vno_trans.Text + "' and plu in (select PLU from Bag)", Module1.ConnLocal);
					m_TagTable.Clear();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			//Try
			//    If RfidScan2.Text = "RFID ON" Then
			//        If (Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Length > 0) Then
			//            Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence()
			//        Else
			//            Me.m_ReaderAPI.Actions.Inventory.Stop()
			//        End If
			//        RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_DEACTIVE.ico").GetThumbnailImage(20, 20, Nothing, IntPtr.Zero)
			//        RfidScan2.Text = "RFID OFF"
			//        RfidScan2.ImageAlign = ContentAlignment.MiddleCenter
			//        RfidScan2.TextAlign = ContentAlignment.BottomCenter
			//        RfidScan2.TextImageRelation = TextImageRelation.Overlay
			//        RfidScan2.ForeColor = Color.Red
			//        RFIDStatus = False
			//        OneReadAll = False
			//    Else
			
			//        Dim op As New Operation
			//        op.AccessOperationCode = ACCESS_OPERATION_CODE.ACCESS_OPERATION_READ
			//        op.ReadAccessParams.MemoryBank = MEMORY_BANK.MEMORY_BANK_EPC
			//        op.ReadAccessParams.ByteCount = 0
			//        op.ReadAccessParams.ByteOffset = 0
			//        op.ReadAccessParams.AccessPassword = 0
			//        Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Add(op)
			//        OneReadAll = True
			//        Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.PerformSequence(Nothing, Nothing, Nothing)
			//        If DataGridView1.Rows.Count > 0 Then
			//            DataGridView1.DataSource = Nothing
			//        End If
			
			//        RfidScan2.Image = Image.FromFile(Application.StartupPath & "/RFID_ACTIVE.ico").GetThumbnailImage(24, 24, Nothing, IntPtr.Zero)
			//        RfidScan2.Text = "RFID ON"
			//        RfidScan2.ImageAlign = ContentAlignment.MiddleCenter
			//        RfidScan2.TextAlign = ContentAlignment.BottomCenter
			//        RfidScan2.TextImageRelation = TextImageRelation.Overlay
			//        RfidScan2.ForeColor = Color.Green
			//        RFIDStatus = True
			//        getSqldb("delete from sales_transaction_details where transaction_number = '" & vno_trans.Text & "'", ConnLocal)
			//        m_TagTable.Clear()
			//    End If
			//Catch ex As Exception
			//    MsgBox(ex.Message)
			//End Try
			DataSet dsReload = new DataSet();
			int cnt = 1;
			dsReload = Module1.getSqldb("select * from sales_transaction_details where transaction_number = '" + vno_trans.Text + "' Order BY Seq", Module1.ConnLocal);
			if (dsReload.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow ro in dsReload.Tables[0].Rows)
				{
					Module1.getSqldb("update sales_transaction_details set seq = '" + System.Convert.ToString(cnt) + "' where transaction_number = '" + System.Convert.ToString(ro["transaction_number"]) + "' " +
						" and Seq = '" + System.Convert.ToString(ro["Seq"]) + "'", Module1.ConnLocal);
					cnt++;
				}
			}
			
			vspg.Text = Module1.VKasir_ID;
			
			//------------
			Module1.SaveLog(this.Name + " " + "Refresh_Transaction_Zebra " + vno_trans.Text + " " + Module1.VSuper_Nm + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			
			dsSales = Module1.getSqldb("SELECT Seq, Flag_Paket_Discount, PLU, Item_Description, Price, Qty, Discount_Percentage, " + "Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, flag_void FROM Sales_Transaction_Details " + "where transaction_number='" + vno_trans.Text + "'", Module1.ConnLocal);
			if (Module1.RFIDType == "zebra")
			{
				RfidScan2.Visible = true;
			}
			else
			{
				RfidScan2.Visible = false;
			}
			
			vgtotal.Text = System.Convert.ToString(0);
			lblqty.Text = System.Convert.ToString(0);
			if (dsSales.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow ro in dsSales.Tables[0].Rows)
				{
					vgtotal.Text = vgtotal.Text + ro["Net_Price"];
					lblqty.Text = System.Convert.ToString(Conversion.Val(lblqty.Text) + System.Convert.ToDouble(ro["Qty"]));
				}
			}
			lblgrand_total.Text = System.Convert.ToString((decimal.Parse(vgtotal.Text)).ToString("N0"));
			Simpan_Header();
			ViewRelease(vno_trans.Text);
			txtkode.Select();
			txtkode.Focus();
			
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
						//Dim tagID As String = tag.MemoryBankData
						string tagID = tag.TagID;
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
								if (Cari_PLU_RFID(tag.TagID.Trim()) == true)
								{
									DataSet dsCekPaid = new DataSet();
									Module1.vqtyRFID = 1;
									if (this.Text == "REFUND")
									{
										Module1.vqtyRFID *= -1;
									}
									if (double.Parse(vflag.Text) == 1)
									{
										this.TopMost = false;
										frmHarga.Default.ShowDialog();
										frmHarga.Default.TopMost = true;
									}
									else
									{
										if (this.Text == "REFUND")
										{
											this.TopMost = false;
											frmHarga.Default.ShowDialog();
											frmHarga.Default.TopMost = true;
										}
									}
									Module1.vtotalRFID = decimal.Parse(System.Convert.ToString((Module1.vqtyRFID) * (double.Parse(vharga.Text)) - ((double) Module1.vdiscrp1RFID) - (double) Module1.vdiscrp2RFID));
									Module1.vgtotalRFID = decimal.Parse(System.Convert.ToString(Conversion.Val(vgtotal.Text) + Conversion.Val(System.Convert.ToString(Module1.vtotalRFID))));
									Module1.lblqtyRFID = System.Convert.ToInt32(Module1.lblqtyRFID + Module1.vqtyRFID);
									//lblqty.Text = CStr(Val(lblqty.Text) + CDbl(vqtyRFID))
									Module1.lblgrand_totalRFID = System.Convert.ToInt32((Module1.vgtotalRFID).ToString("N0"));
									//lblgrand_total.Text = CDec(vgtotalRFID).ToString("N0")
									dsCekPaid = Module1.getSqldb("SELECT * from paid where transaction_number = '" + vno_trans.Text + "'", Module1.ConnLocal);
									if (dsCekPaid.Tables[0].Rows.Count > 0)
									{
										txtkode.Focus();
										return;
									}
									Simpan_HeaderRFIDZebra();
									Simpan_DetailRFIDZebra();
									
									//vno_trans.Text = vno_transRFID
									
									
									ViewRelease(vno_trans.Text);
									(new Microsoft.VisualBasic.Devices.Audio()).Play(Application.StartupPath + "/Beep.wav", AudioPlayMode.Background);
									Cetak.CDisplay(VB.Strings.Left(vdesc.Text, 20), VB.Strings.Left(vqty.Text + " pcs Rp. " + (decimal.Parse(vgtotal.Text)).ToString("N0"), 20));
								}
							}
							
							lock(m_TagTable.SyncRoot)
							{
								m_TagTable.Add(tagID, tag.MemoryBankData);
							}
						}
					}
				}
			}
		}
		
		//Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
		//    If (Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.Length > 0) Then
		//        Me.m_ReaderAPI.Actions.TagAccess.OperationSequence.StopSequence()
		//    Else
		//        Me.m_ReaderAPI.Actions.Inventory.Stop()
		//    End If
		
		//    'Me.m_ReaderAPI.Disconnect()
		
		//End Sub
		
		public void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			
			try
			{
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
				RFIDStatus = false;
				Module1.OneReadAll = false;
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
			if (System.Convert.ToInt32(Module1.SecLev) == 9)
			{
				frmMain.Default.Show();
			}
			else
			{
				frmLogin.Default.Show();
			}
			
			return;
		}
		
		public void vno_trans_TextChanged(object sender, EventArgs e)
		{
			lblno.Text = "TRANS# " + VB.Strings.Right(vno_trans.Text, 4);
		}
		
		public void _btnNum_0_Click(System.Object sender, System.EventArgs e)
		{
			Button btn = (Button) sender;
			txtkode.Focus();
			if (System.Convert.ToInt32(btn.Tag) < 11)
			{
				if (txtkode.SelectionLength == txtkode.Text.Length)
				{
					txtkode.Clear();
				}
				txtkode.Text = txtkode.Text + btn.Text;
			}
			txtkode.SelectionStart = txtkode.Text.Length;
			switch (System.Convert.ToInt32(btn.Tag))
			{
				case 11:
					string Cmd;
					
					string[] CekPLU;
					string RealPLU = "";
					
					CekPLU = txtkode.Text.Split('*');
					//On Error Goto ErrH VBConversions Warning: could not be converted to try/catch - logic too complex
					if (CekPLU[0].Length > 10)
					{
						RealPLU = CekPLU[0];
					}
					else
					{
						RealPLU = CekPLU[1];
					}
					if (RealPLU.Trim().Length > 14)
					{
						
					}
					else
					{
						if (Cari_PLU(VB.Strings.Right(RealPLU.Trim(), 14)) == true)
						{
							DataSet dsCekPaid = new DataSet();
							Qty = txtkode.Text.Split('*');
							vqty.Text = System.Convert.ToString((System.Convert.ToString(System.Convert.ToInt32(Qty[0])).Length > 10) ? 1 : (System.Convert.ToInt32(Qty[0])));
							if (vqty.Text == "")
							{
								vqty.Text = System.Convert.ToString(1);
							}
							if (this.Text == "REFUND")
							{
								vqty.Text = System.Convert.ToString((double.Parse(vqty.Text)) * -1);
							}
							
							//vflag = 0 Barang Direct, vflag = 1 Barang Konsinyasi
							//If CDbl(vflag.Text) = 0 And vpromo.Text <> "disc" Then
							//    If Not Super(1) Then Exit Sub
							//End If
							
							Module1.VOK = false;
							if (double.Parse(vflag.Text) == 1)
							{
								frmHarga.Default.ShowDialog();
							}
							
							
							vtotal.Text = System.Convert.ToString((double.Parse(vqty.Text)) * double.Parse(vharga.Text));
							
							if (Module1.VOK == true || double.Parse(vflag.Text) == 0)
							{
								vgtotal.Text = System.Convert.ToString(Conversion.Val(vgtotal.Text) + Conversion.Val(vtotal.Text));
								lblqty.Text = System.Convert.ToString(Conversion.Val(lblqty.Text.Replace(" Pcs", "")) + double.Parse(vqty.Text));
								lblqty.Text = lblqty.Text + " pcs";
								lblgrand_total.Text = System.Convert.ToString((decimal.Parse(vgtotal.Text)).ToString("N0"));
								dsCekPaid = Module1.getSqldb("SELECT * from paid where transaction_number = '" + vno_trans.Text + "'", Module1.ConnLocal);
								if (dsCekPaid.Tables[0].Rows.Count > 0)
								{
									txtkode.Focus();
									return;
								}
								Simpan_Header();
								Simpan_Detail();
								Cetak.CDisplay(VB.Strings.Left(vdesc.Text, 20), VB.Strings.Left(vqty.Text + " pcs Rp. " + (decimal.Parse(vgtotal.Text)).ToString("N0"), 20));
								//PEMBAYARAN DENGAN POINT REWARDS
								//no1
								//If Star_No <> "CM000-00000" Then
								//    If Linked() Then Call Cari_Item_Rewards((txtkode.Text))
								//End If
							}
							ViewRelease(vno_trans.Text);
							
						}
					}
					System.Windows.Forms.SendKeys.Send("{home}+{end}");
					txtkode.Focus();
					goto _1;
ErrH:
					Interaction.MsgBox("PLU tidak terdaftar", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
					System.Windows.Forms.SendKeys.Send("{home}+{end}");
					txtkode.Focus();
_1:
					break;
					
				case 12:
					System.Windows.Forms.SendKeys.Send("{end}+{backspace}");
					break;
				case 13:
					txtkode.Text = "";
					break;
				case 14:
					this.Close();
					break;
					//Me.BackgroundWorker1.RunWorkerAsync()
					//BackgroundWorker1.WorkerReportsProgress = True
					//BackgroundWorker1.WorkerSupportsCancellation = True
					//BackgroundWorker1.RunWorkerAsync()
					
			}
		}
		
		public void txtkode_TextChanged(object sender, EventArgs e)
		{
			if (txtkode.TextLength > 16)
			{
				txtkode.Text = VB.Strings.Left(txtkode.Text, 14);
			}
		}
		
		public void _CmdNav_1_Click(object sender, EventArgs e)
		{
			if (DataGridView1.Rows.Count == 0)
			{
				return;
			}
			DataGridView1.ClearSelection();
			if (DataGridView1.CurrentRow.Index == 0)
			{
				DataGridView1.CurrentCell = DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells[2];
				DataGridView1.Rows[DataGridView1.CurrentRow.Index].Selected = true;
				DataGridView1.Focus();
			}
			else
			{
				DataGridView1.CurrentCell = DataGridView1.Rows[DataGridView1.CurrentRow.Index - 1].Cells[2];
				DataGridView1.Rows[DataGridView1.CurrentRow.Index].Selected = true;
				DataGridView1.Focus();
			}
			txtkode.Focus();
		}
		
		public void _CmdNav_2_Click(object sender, EventArgs e)
		{
			if (DataGridView1.Rows.Count == 0)
			{
				return;
			}
			DataGridView1.ClearSelection();
			if (DataGridView1.CurrentRow.Index == DataGridView1.RowCount - 1)
			{
				DataGridView1.CurrentCell = DataGridView1.Rows[DataGridView1.CurrentRow.Index].Cells[2];
				DataGridView1.Rows[DataGridView1.CurrentRow.Index].Selected = true;
				DataGridView1.Focus();
			}
			else
			{
				DataGridView1.CurrentCell = DataGridView1.Rows[DataGridView1.CurrentRow.Index + 1].Cells[2];
				DataGridView1.Rows[DataGridView1.CurrentRow.Index].Selected = true;
				DataGridView1.Focus();
			}
			txtkode.Focus();
		}
		
		private void _cmdsales_3_Click(object sender, EventArgs e)
		{
			if (DataGridView1.RowCount > 0)
			{
				foreach (DataGridViewRow ro in DataGridView1.SelectedRows)
				{
					if (!this.DataGridView1.Rows[ro.Index].IsNewRow)
					{
						//If Not Super(2) Then Exit Sub
						Module1.getSqldb("delete from Sales_Transaction_Details where transaction_number='" + vno_trans.Text + "' and seq='" + System.Convert.ToString(DataGridView1[0, ro.Index].Value) + "'", Module1.ConnLocal);
						lock(m_TagTable.SyncRoot)
						{
							m_TagTable.Remove(DataGridView1[12, ro.Index].Value.ToString().Trim());
						}
						vgtotal.Text = System.Convert.ToString((double.Parse(vgtotal.Text)) - Conversion.Val(DataGridView1[10, ro.Index].Value));
						lblqty.Text = System.Convert.ToString(Conversion.Val(lblqty.Text.Replace(" Pcs", "")) - Conversion.Val(DataGridView1[5, ro.Index].Value));
						lblqty.Text = lblqty.Text + " pcs";
						lblgrand_total.Text = System.Convert.ToString((decimal.Parse(vgtotal.Text)).ToString("N0"));
						Simpan_Header();
						txtkode.Focus();
					}
				}
			}
			ViewRelease(vno_trans.Text);
			
		}
		
		public void _cmdsales_0_Click(object sender, EventArgs e)
		{
			if (dsSales.Tables[0].Rows.Count == 0)
			{
				return;
			}
			Module1.VDiscBySTAR = 0;
			if (cmdsales[9].Enabled)
			{
				if (dsSales.Tables[0].Rows.Count == 0)
				{
					return;
				}
				Cek_Harga();
				Cek_Promo();
				Cek_Promo2();
				Simpan_Header();
				Cetak.CDisplay("TOTAL :", "Rp. " + ((decimal) ((double.Parse(vgtotal.Text)) - Module1.VDiscBySTAR)).ToString("N0"));
			}
			Module1.VNomor = vno_trans.Text;
			Cetak.CDisplay("TOTAL :", "Rp. " + ((decimal) ((double.Parse(vgtotal.Text)) - Module1.VDiscBySTAR)).ToString("N0"));
			if (Module1.VDiscBySTAR > 0)
			{
				Interaction.MsgBox("Anda Mendapat Potongan Senilai Rp. " + Module1.VDiscBySTAR.ToString("N0"), MsgBoxStyle.Information, "Information");
			}
			this.Enabled = false;
			Module1.GotoPayment = true;
			frmPaymentSelf.Default.vpay.Text = System.Convert.ToString((double.Parse(vgtotal.Text)) - Module1.VDiscBySTAR);
			frmPaymentSelf.Default.vstatus.Text = this.Text;
			frmPaymentSelf.Default.ShowDialog();
			txtkode.Text = "";
			txtkode.Focus();
		}
		
		public void _cmdsales_9_Click(object sender, EventArgs e)
		{
			if (dsSales.Tables[0].Rows.Count == 0)
			{
				return;
			}
			Module1.VDiscBySTAR = 0;
			Module1.getSqldb("delete from Paid where Transaction_Number = '" + vno_trans.Text + "'", Module1.ConnLocal);
			if (Module1.VPing == "ONLINE")
			{
				Module1.getSqldb("delete from Paid where Transaction_Number = '" + vno_trans.Text + "'", Module1.ConnServer);
			}
			Cek_Harga();
			Cek_Promo();
			Cek_Promo2();
			Simpan_Header();
			Cetak.CDisplay("TOTAL :", "Rp. " + ((decimal) ((double.Parse(vgtotal.Text)) - Module1.VDiscBySTAR)).ToString("N0"));
		}
		
		public void Button6_Click(object sender, EventArgs e)
		{
			InputMember.Default.ShowDialog();
			Module1.getSqldb("UPDATE Sales_Transactions set customer_id = '" + txtcust_id.Text + "', card_number = '" + txtcard_no.Text + "' where Transaction_Number='" + vno_trans.Text + "'", Module1.ConnLocal);
			txtkode.Focus();
		}
		
		public void DataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				//Me.DataGridView1.Rows(e.RowIndex).Selected = True
				this.rowIndex = e.RowIndex;
				//Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(e.RowIndex).Cells(2)
				this.ContextMenuStrip1.Show(this.DataGridView1, e.Location);
				ContextMenuStrip1.Show(Cursor.Position);
			}
		}
		
		public void ContextMenuStrip1_Click(object sender, EventArgs e)
		{
			if (DataGridView1.RowCount > 0)
			{
				foreach (DataGridViewRow ro in DataGridView1.SelectedRows)
				{
					if (!this.DataGridView1.Rows[ro.Index].IsNewRow)
					{
						//If Not Super(2) Then Exit Sub
						Module1.getSqldb("delete from Sales_Transaction_Details where transaction_number='" + vno_trans.Text + "' and seq='" + System.Convert.ToString(DataGridView1[0, ro.Index].Value) + "'", Module1.ConnLocal);
						lock(m_TagTable.SyncRoot)
						{
							m_TagTable.Remove(DataGridView1[12, ro.Index].Value.ToString().Trim());
						}
						vgtotal.Text = System.Convert.ToString((double.Parse(vgtotal.Text)) - Conversion.Val(DataGridView1[10, ro.Index].Value));
						lblqty.Text = System.Convert.ToString(Conversion.Val(lblqty.Text.Replace(" Pcs", "")) - Conversion.Val(DataGridView1[5, ro.Index].Value));
						lblqty.Text = lblqty.Text + " pcs";
						lblgrand_total.Text = System.Convert.ToString((decimal.Parse(vgtotal.Text)).ToString("N0"));
						Simpan_Header();
						txtkode.Focus();
					}
				}
			}
			ViewRelease(vno_trans.Text);
		}
		
		public void Button1_Click(object sender, EventArgs e)
		{
			if (txtkode.Text == "ID SPG")
			{
				Interaction.MsgBox("Isi dahulu ID SPG", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
				txtkode.Focus();
				return;
			}
			this.TopMost = false;
			frmView2.Default.ShowDialog();
			frmView2.Default.TopMost = true;
			txtkode.Focus();
			if (txtkode.Text != "")
			{
				System.Windows.Forms.SendKeys.Send("{Enter}");
			}
		}
		
		public void frmSales_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (RFIDStatus == true)
			{
				BackgroundWorker1.WorkerReportsProgress = true;
				BackgroundWorker1.WorkerSupportsCancellation = true;
				BackgroundWorker1.RunWorkerAsync();
			}
			else
			{
				if (System.Convert.ToInt32(Module1.SecLev) == 9)
				{
					frmMain.Default.Show();
				}
				else
				{
					frmLogin.Default.Show();
				}
				
				return;
			}
		}
		
		public void frmSalesSelf_Load(object sender, EventArgs e)
		{
			Module1.VNomor = "";
			this.Show();
			
			Kosong();
			RFIDStatus = false;
			cmdsales[9].Enabled = Module1.VAda_Promo;
			vno_trans.Text = Module1.VNomor;
			if (vno_trans.Text != "")
			{
				Update_MySTAR();
			}
			else
			{
				vno_trans.Text = Gen_No();
			}
			//Tanpa SPG
			vspg.Text = Module1.VKasir_ID;
			
			//------------
			dsSales = Module1.getSqldb("SELECT Seq, Flag_Paket_Discount, PLU, Item_Description, Price, Qty, Discount_Percentage, " + "Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, flag_void FROM Sales_Transaction_Details " + "where transaction_number='" + vno_trans.Text + "'", Module1.ConnLocal);
			if (Module1.RFIDType == "zebra")
			{
				//RfidScan2.Visible = True
			}
			else
			{
				RFIDStatus = false;
				//RfidScan2.Visible = False
			}
			this.m_UpdateStatusHandler = new UpdateStatus(this.myUpdateStatus);
			this.m_UpdateReadHandler = new UpdateRead(this.myUpdateRead);
			this.m_TagTable = new Hashtable();
			vgtotal.Text = System.Convert.ToString(0);
			lblqty.Text = System.Convert.ToString(0);
			if (dsSales.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow ro in dsSales.Tables[0].Rows)
				{
					vgtotal.Text = vgtotal.Text + ro["Net_Price"];
					lblqty.Text = System.Convert.ToString(Conversion.Val(lblqty.Text.Replace(" pcs", "")) + System.Convert.ToDouble(ro["Qty"]));
				}
			}
			lblqty.Text = lblqty.Text + " pcs";
			if (Module1.RFIDType == "zebra")
			{
				CheckConZebra();
			}
			if (RFIDStatus == false)
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
				RfidScan2.Image = Image.FromFile(Application.StartupPath + "/RFID_Refresh.ico").GetThumbnailImage(26, 26, null, IntPtr.Zero);
				RfidScan2.Text = "REFRESH";
				RfidScan2.ImageAlign = ContentAlignment.MiddleCenter;
				RfidScan2.TextAlign = ContentAlignment.BottomCenter;
				RfidScan2.TextImageRelation = TextImageRelation.Overlay;
				RfidScan2.ForeColor = Color.Green;
			}
			awal = false;
			Module1.OneReadAll = false;
			lblgrand_total.Text = System.Convert.ToString((decimal.Parse(vgtotal.Text)).ToString("N0"));
			txtkode.Select();
			txtkode.Focus();
		}
		
		public void Button2_Click_1(object sender, EventArgs e)
		{
			DataSet dsBag = new DataSet();
			if (Module1.VPing == "ONLINE")
			{
				dsBag = Module1.getSqldb("Select * from Bag where Bag = 'PAPER BAG' and Size = 'X'", Module1.ConnServer);
			}
			else
			{
				dsBag = Module1.getSqldb("Select * from Bag where Bag = 'PAPER BAG' and Size = 'X'", Module1.ConnLocal);
			}
			
			if (dsBag.Tables[0].Rows.Count > 0)
			{
				txtkode.Text = Strings.Trim(System.Convert.ToString(dsBag.Tables[0].Rows[0]["PLU"]));
			}
			else
			{
				txtkode.Text = "";
			}
			txtkode.Focus();
			if (txtkode.Text != "")
			{
				System.Windows.Forms.SendKeys.Send("{Enter}");
			}
		}
		
		public void Button3_Click(object sender, EventArgs e)
		{
			this.TopMost = false;
			frmSizeBag.Default.Text = "PLASTIC";
			frmSizeBag.Default.ShowDialog();
			frmSizeBag.Default.Tag = "";
			frmSizeBag.Default.TopMost = true;
			txtkode.Focus();
			if (txtkode.Text != "")
			{
				System.Windows.Forms.SendKeys.Send("{Enter}");
			}
		}
		
		public void Button4_Click(object sender, EventArgs e)
		{
			this.TopMost = false;
			frmSizeBag.Default.Text = "TOTE BAG";
			frmSizeBag.Default.ShowDialog();
			frmSizeBag.Default.Tag = "";
			frmSizeBag.Default.TopMost = true;
			txtkode.Focus();
			if (txtkode.Text != "")
			{
				System.Windows.Forms.SendKeys.Send("{Enter}");
			}
		}
		
		public void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rwindex = 0;
			if (e.ColumnIndex == 1)
			{
				rwindex = e.RowIndex;
				Module1.spg_btn = System.Convert.ToString(DataGridView1[e.ColumnIndex, rwindex].Value);
				this.TopMost = false;
				frmSPG.Default.ShowDialog();
				frmSPG.Default.TopMost = true;
				Module1.getSqldb("Update sales_transaction_details set flag_paket_discount = '" + Module1.spg_btn + "' where transaction_number = '" + vno_trans.Text + "' and Seq = '" + System.Convert.ToString(DataGridView1[0, e.RowIndex].Value) + "'", Module1.ConnLocal);
				DataGridView1[e.ColumnIndex, rwindex].Value = Module1.spg_btn;
			}
		}
	}
	
	
}
