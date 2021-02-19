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
using Microsoft.VisualBasic.PowerPacks;
using System.Data.SqlClient;
using System.IO;
using iPOS;

namespace iPOS
{
	public partial class frmPaymentSelf : System.Windows.Forms.Form
	{
		public frmPaymentSelf()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmPaymentSelf defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmPaymentSelf Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmPaymentSelf();
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
		string lokasi;
		string VTukar_Point;
		int TotPay;
		int RoundOfPay;
		DataSet Tdata1 = new DataSet();
		DataSet Tdata2 = new DataSet();
		bool t_load = false;
		int cnt = 0;
		string Response;
		string DCC = "";
		int CodePayType;
		
		public void ClosePayment()
		{
			DataSet RsHapus = new DataSet();
			DataSet RsAmbil = new DataSet();
			Module1.getSqldb("delete from Paid where Transaction_Number = '" + vno_trans.Text + "'", Module1.ConnLocal);
			//tanpa cek PING
			if (Module1.VPing == "ONLINE")
			{
				Module1.getSqldb("delete from Paid where Transaction_Number = '" + vno_trans.Text + "'", Module1.ConnServer);
			}
			Module1.SaveLog(this.Name + " " + "Close Payment " + vno_trans.Text + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			Module1.GotoPayment = false;
			txtno_kartu.Clear();
			Module1.VNomor = vno_trans.Text;
			frmSalesSelf.Default.Enabled = true;
			Module1.VDiscBySTAR = 0;
			this.Close();
		}
		private string Gen_Seq()
		{
			string returnValue = "";
			DataSet RsCari = new DataSet();
			
			RsCari = Module1.getSqldb("select ISNULL(MAX(seq),0) as urut from paid where Transaction_Number = '" + vno_trans.Text + "'", Module1.ConnLocal);
			returnValue = System.Convert.ToString(System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["urut"]) + 1);
			RsCari.Clear();
			RsCari = null;
			return returnValue;
		}
		
		
		
		
		private bool Simpan_Detail(double bayar, string card_no, ref string card_num)
		{
			bool returnValue = false;
			try
			{
				DataSet dsCek = new DataSet();
				returnValue = false;
				//Menghindari Bug Duplicate Payment
				dsCek = Module1.getSqldb("select sum(Paid_Amount) as Paid_Amount from paid where transaction_number = '" + vno_trans.Text + "' and payment_types <> '31' having sum(Paid_Amount) is not null", Module1.ConnLocal);
				if (dsCek.Tables[0].Rows.Count > 0)
				{
					if (double.Parse(lbltotal.Text) <= System.Convert.ToDouble(dsCek.Tables[0].Rows[0]["Paid_Amount"]))
					{
						goto _1;
					}
				}
				//selesai
				Module1.getSqldb("INSERT Into Paid(Transaction_Number, Payment_Types, Seq, Currency_ID, Currency_Rate, Credit_Card_No, " +
					"Credit_Card_Name, Paid_Amount, Shift) VALUES ('" + vno_trans.Text + "','" + System.Convert.ToString(CodePayType) + "','" + Gen_Seq() + "','IDR','1','" + card_no + "','" + Module1.UbahChar(card_num) + "'," + System.Convert.ToString(bayar) + ",'" + System.Convert.ToString(Module1.VShift) + "')", Module1.ConnLocal);
				Module1.SaveLog(this.Name + " " + "Simpan_Paid " + vno_trans.Text + " " + System.Convert.ToString(bayar) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
_1:
				
				vpay.Text = System.Convert.ToString(double.Parse(vpay.Text) - (bayar + RoundOfPay));
				return true;
				
			}
			catch (Exception)
			{
				Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				Module1.SaveLog(this.Name + " " + "Simpan_Paid " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			
			return returnValue;
		}
		private void Cek_Lunas()
		{
			try
			{
				int l;
				DataSet RsCari = new DataSet();
				string strRf = "";
				if (double.Parse(vpay.Text) <= 0 && vstatus.Text.Trim() == "SALES") //jika lunas
				{
					if (RoundOfPay != 0)
					{
						Module1.getSqldb("Insert Into Paid select top 1 '" + vno_trans.Text + "','36',(Select top 1 seq + 1 from paid where transaction_number = '" + vno_trans.Text + "' Order By Seq desc),'IDR','1','','ROUNDING'," + System.Convert.ToString(RoundOfPay) + ",Shift from paid where transaction_number = '" + vno_trans.Text + "'", Module1.ConnLocal);
					}
					
					Paid_To_Sales(vno_trans.Text, System.Convert.ToInt32((double.Parse(lbltotal.Text)) + RoundOfPay), 0);
					goto lanjut;
				}
				
				if (double.Parse(vpay.Text) >= 0 && vstatus.Text.Trim() == "REFUND") //jika lunas
				{
					if (RoundOfPay != 0)
					{
						Module1.getSqldb("Insert Into Paid select top 1 '" + vno_trans.Text + "','36',(Select top 1 seq + 1 from paid where transaction_number = '" + vno_trans.Text + "' Order By Seq desc),'IDR','1','','ROUNDING'," + System.Convert.ToString(RoundOfPay) + ",Shift from paid where transaction_number = '" + vno_trans.Text + "'", Module1.ConnLocal);
					}
					Paid_To_Sales(vno_trans.Text, int.Parse(lbltotal.Text), 0);
					goto lanjut;
				}
				RoundOfPay = System.Convert.ToInt32(double.Parse(vpay.Text) - (Conversion.Int(double.Parse(vpay.Text) / 100)) * 100);
				if (double.Parse(vpay.Text) < 0)
				{
					if (double.Parse(vpay.Text) != Conversion.Int(double.Parse(vpay.Text) / 100) * 100)
					{
						RoundOfPay = System.Convert.ToInt32(double.Parse(vpay.Text) - (Conversion.Int(double.Parse(vpay.Text) / 100) + 1) * 100);
					}
					else
					{
						RoundOfPay = 0;
					}
				}
				//karena tidak ada pembayaran cash
				RoundOfPay = 0;
				//------
				lbltotal.Text = System.Convert.ToString((TotPay - RoundOfPay).ToString("N0"));
				return;
lanjut:
				if (vstatus.Text.Trim() == "SALES")
				{
					strRf = "update a set a.flag = 1 from Item_Master_RFID a inner join sales_transaction_details b on a.plu = b.plu and a.TID = b.epc_code " +
						"where b.transaction_number = '" + vno_trans.Text + "'";
				}
				else
				{
					strRf = "update a set a.flag = 0 from Item_Master_RFID a inner join sales_transaction_details b on a.plu = b.plu and a.TID = b.epc_code " +
						"where b.transaction_number = '" + vno_trans.Text + "'";
				}
				Module1.getSqldb(strRf, Module1.ConnLocal);
				
				
				if (Module1.VPing == "ONLINE")
				{
					Upload_to_Server(vno_trans.Text);
					Module1.getSqldb(strRf, Module1.ConnServer);
					//getSqldb("Update newvoc Set v_flag = 'R',V_REC = CONVERT(VARCHAR(10), GETDATE(), 120)  where V_NO in (Select credit_card_no from paid " &
					//         "where payment_types = 8 And transaction_number = '" & vno_trans.Text & "')", ConnServer)
				}
				Cetak.CetakStruk(vstatus.Text, vno_trans.Text);
				//Call CetakStruk(vstatus.Text, vno_trans.Text)
				//If txtcard_no.Text.Trim <> "CM000-00000" Then Call Save_Point(vno_trans.Text, txtcard_no.Text)
				//Call OpenLaci(0) ' buka drawer tanpa print
				
				
				
				l = 0;
				
				if (l == 0)
				{
					if (vstatus.Text.Trim() == "SALES")
					{
						string temp_No_trans = vno_trans.Text;
						CetakPromo(ref temp_No_trans);
						vno_trans.Text = temp_No_trans;
					}
				}
				
				//If Linked() Then Call CetakStrukPayPoint(txtcard_no.Text, VB.Left(Star_Nm, 22), vno_trans.Text)
				
				//tanpa cek PING
				//If VPing = "ONLINE" Then Call CetakStrukPayPoint(txtcard_no.Text, VB.Left(Star_Nm, 22), vno_trans.Text)
				
				
				
				if (vstatus.Text.Trim() == "SALES")
				{
					frmSalesSelf.Default.lblgrand_total.Text = "0";
				}
				else
				{
					frmSalesSelf.Default.lblgrand_total.Text = "0";
				}
				frmSalesSelf.Default.DataGridView1.DataSource = null;
				frmSalesSelf.Default.vno_trans.Text = Gen_No();
				frmSalesSelf.Default.Enabled = true;
				frmSalesSelf.Default.txtkode.Text = "";
				frmSalesSelf.Default.txtkode.Focus();
				Cetak.CDisplay("CHANGE :", "Rp. " + frmSalesSelf.Default.lblgrand_total.Text);
				vpay.Text = "0";
				Kosong();
				Module1.VNomor = "";
				
				//Star_Pt = 0
				//Star_Nm = "ONE TIME CUSTOMER"
				//Star_Id = "10000000"
				//Star_Freq = ""
				//Star_Omz = ""
				//Star_Phone = ""
				//Star_Email = ""
				//Star_updsts = 9
				//Exp_Point = ""
				//Expired_Date = ""
				
				//frmSales.txtcard_no.Text = txtcard_no.Text
				//frmSales.txtcust_name.Text = "ONE TIME CUSTOMER"
				//frmSales.txtcust_id.Text = "10000000"
				
				//frmSales.Update_MySTAR()
				
				//frmSales.lblqty.Text = "0 Pcs"
				//frmSales.txtkode.Text = ""
				//frmSales.txtkode.Focus()
				//frmSales.txtkode.Select()
				//frmSales.txtkode.SelectionStart = 0
				
				
				frmSalesSelf.Default.Close();
				frmLogin.Default.Show();
				this.Close();
				return;
			}
			catch (Exception)
			{
				Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				Module1.SaveLog(this.Name + " " + "Cek Lunas " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			
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
		
		private void Paid_To_Sales(string nomor, int total, int kembali)
		{
			DataSet RsHitung = new DataSet();
			try
			{
				RsHitung = Module1.getSqldb("select sum(discount_amount+extradisc_amt) as hemat " + "from sales_transaction_details where transaction_number='" + nomor + "'", Module1.ConnLocal);
				
				Module1.StrSQL = "update sales_transactions set total_paid =" + System.Convert.ToString(total + kembali) + ", change_amount=" + System.Convert.ToString(kembali) + ", total_discount=" + RsHitung.Tables[0].Rows[0]["hemat"] + ", status='00' , net_price=net_amount , transaction_time='" + Strings.Format(Module1.GetSrvDate(), "HH:mm") + "' where transaction_number = '" + nomor + "'";
				
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				RsHitung.Clear();
				RsHitung = null;
			}
			catch
			{
				Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				Module1.SaveLog(this.Name + " " + "Paid_To_Sales " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			
		}
		private void Upload_to_Server(string nomor)
		{
			try
			{
				//On Error Resume Next
				string Dbs = "";
				string Svr = "";
				
				Svr = "[" + Module1.VSvr + "]";
				Dbs = Module1.ReadIni("Server", "DatabaseName");
				
				Module1.StrSQL = "Insert " + Svr +"." + Dbs +".dbo.Sales_Transactions (Transaction_Number, Cashier_ID, Customer_ID, Card_Number, Spending_Program_ID, " +
					"Transaction_Date, Total_Discount, Points_Of_Spending_Program, Point_Of_Item_Program, Point_Of_Card_Program, " +
					"Payment_Program_ID, Branch_ID, Cash_Register_ID, Total_Paid, Net_Price, Tax, Net_Amount, Change_Amount, " +
					"Flag_Arrange, WorkManShip, Flag_Return, Register_Return, Transaction_Date_Return, Transaction_Number_Return, " +
					"Last_Point, Get_Point, Status, Upload_Status, Transaction_Time, Store_Type) " +
					"(SELECT  Transaction_Number, Cashier_ID, Customer_ID, Card_Number, Spending_Program_ID, Transaction_Date, Total_Discount, Points_Of_Spending_Program, " +
					"Point_Of_Item_Program, Point_Of_Card_Program, Payment_Program_ID, Branch_ID, Cash_Register_ID, Total_Paid, Net_Price, Tax, Net_Amount, Change_Amount, " +
					"Flag_Arrange, WorkManShip, Flag_Return, Register_Return, Transaction_Date_Return, Transaction_Number_Return, Last_Point, Get_Point, Status, Upload_Status, " +
					"Transaction_Time , Store_Type " +
					"FROM Sales_Transactions where Transaction_Number='" + nomor + "')";
				
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "Insert " + Svr +"." + Dbs +".dbo.Sales_Transaction_details (Transaction_Number, Seq, PLU, Item_Description, Price, Qty, Amount, " +
					"Discount_Percentage, Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, Points_Received, Flag_Void, " + "Flag_Status, Flag_Paket_Discount,Epc_Code) " +
					"(select Transaction_Number, Seq, PLU, Item_Description, Price, Qty, Amount, " +
					"Discount_Percentage, Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, Points_Received, Flag_Void, " +
					"Flag_Status , Flag_Paket_Discount, Epc_Code " +
					"FROM Sales_Transaction_details where Transaction_Number='" + nomor + "')";
				
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "Insert " + Svr +"." + Dbs +".dbo.paid(Transaction_Number, Payment_Types, Seq, Currency_ID, Currency_Rate, " +
					"Credit_Card_No, Credit_Card_Name, Paid_Amount, Shift) " + "(select Transaction_Number, Payment_Types, Seq, Currency_ID, Currency_Rate, Credit_Card_No, " +
					"Credit_Card_Name , Paid_Amount, Shift " +
					"FROM paid where Transaction_Number='" + nomor + "')";
				
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.getSqldb("Update sales_transactions set upload_status='99' where transaction_number='" + nomor + "'", Module1.ConnLocal);
				Module1.SaveLog(this.Name + " " + "Upload_to_Server " + Module1.VSuper_Nm + " " + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			catch
			{
				Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				Module1.SaveLog(this.Name + " " + "Upload_to_Server " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			
		}
		
		
		
		
		public void txtno_kartu_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (Strings.Asc(e.KeyChar) != 8)
			{
				if (Strings.Asc(e.KeyChar) < 48 || Strings.Asc(e.KeyChar) > 57)
				{
					e.Handled = true;
				}
			}
		}
		public void txtno_kartu_TextChanged(object sender, EventArgs e)
		{
			if (txtno_kartu.Text.Length > 16)
			{
				txtno_kartu.Text = VB.Strings.Left(txtno_kartu.Text, 16);
			}
		}
		
		
		public void Kosong()
		{
			txtno_kartu.Clear();
			Module1.VDiscBySTAR = 0;
			Module1.GotoPayment = false;
		}
		
		public void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (t_load == false)
			{
				return;
			}
			lokasi = "";
			RoundOfPay = 0;
			lbltotal.Text = System.Convert.ToString((TotPay).ToString("N0"));
			txtno_kartu.Select();
			txtno_kartu.Focus();
			txtno_kartu.SelectionStart = 0;
			txtno_kartu.SelectionLength = txtno_kartu.Text.Length;
		}
		
		public void txtno_kartu_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					if ((vstatus.Text.Trim() == "SALES" && string.Compare(lbltotal.Text, vpay.Text) <= 0) || (vstatus.Text.Trim() == "REFUND" && string.Compare(lbltotal.Text, vpay.Text) >= 0))
					{
						Cek_ECR();
						if (Module1.isECR == 1)
						{
							return;
						}
						string temp_card_num = "";
						if (Simpan_Detail(double.Parse(lbltotal.Text), VB.Strings.Left(txtno_kartu.Text, 16), ref temp_card_num))
						{
							txtno_kartu.Text = "";
							Cek_Lunas();
						}
					}
					else
					{
						Interaction.MsgBox("Pembayaran dengan kartu kredit/debit tidak boleh " + Constants.vbNewLine + "melebihi sisa yang harus dibayar", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
						txtno_kartu.Focus();
					}
					break;
			}
			
		}
		
		public void _btnNum_0_Click(System.Object sender, System.EventArgs e)
		{
			Button btn = (Button) sender;
			txtno_kartu.Focus();
			if (System.Convert.ToInt32(btn.Tag) < 11)
			{
				if (txtno_kartu.SelectionLength == txtno_kartu.Text.Length)
				{
					txtno_kartu.Clear();
				}
				txtno_kartu.Text = txtno_kartu.Text + btn.Text;
			}
			txtno_kartu.SelectionStart = txtno_kartu.Text.Length;
			switch (System.Convert.ToInt32(btn.Tag))
			{
				case 11:
					if ((vstatus.Text.Trim() == "SALES" && string.Compare(lbltotal.Text, vpay.Text) <= 0) || (vstatus.Text.Trim() == "REFUND" && string.Compare(lbltotal.Text, vpay.Text) >= 0))
					{
						//Cek_ECR()
						//If isECR = 1 Then
						//    If Simpan_Detail(lbltotal.Text, VB.Left(txtno_kartu.Text, 16), "") Then
						//        txtno_kartu.Text = ""
						//        Call Cek_Lunas()
						//    End If
						//End If
						//If isECR = 2 And txtno_kartu.Enabled = False And txtno_kartu.Text.Length > 10 Then
						//    If Simpan_Detail(lbltotal.Text, VB.Left(txtno_kartu.Text, 16), "") Then
						//        txtno_kartu.Text = ""
						//        Call Cek_Lunas()
						//    End If
						//    isECR = 1
						//    Exit Sub
						//Else
						//    If isECR = 1 Then
						//        If CodePayType <> 6 Then
						//            MsgBox("ECR Connections Failed !!!")
						//            txtno_kartu.Enabled = True
						//            txtno_kartu.Clear()
						//            txtno_kartu.Select()
						//            txtno_kartu.Focus()
						//            ClosePayment()
						//            Exit Sub
						//        End If
						//    End If
						
						//End If
						if (txtno_kartu.Text.Length == 0)
						{
							MessageBox.Show("Please Insert Card No !!");
							txtno_kartu.Focus();
							return;
						}
						
						string temp_card_num = "";
						if (Simpan_Detail(double.Parse(lbltotal.Text), VB.Strings.Left(txtno_kartu.Text, 16), ref temp_card_num))
						{
							txtno_kartu.Text = "";
							Cek_Lunas();
						}
					}
					else
					{
						Interaction.MsgBox("Pembayaran dengan kartu kredit/debit tidak boleh " + Constants.vbNewLine + "melebihi sisa yang harus dibayar", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
						if (Module1.isECR == 2)
						{
							Module1.isECR = 1;
						}
						txtno_kartu.Focus();
					}
					break;
				case 12:
					System.Windows.Forms.SendKeys.Send("{end}+{backspace}");
					break;
				case 13:
					txtno_kartu.Text = "";
					break;
			}
		}
		
		public void _cmdpay_0_Click(object sender, EventArgs e)
		{
			ClosePayment();
		}
		
		public void Cek_ECR()
		{
			if (Module1.isECR == 1)
			{
				try
				{
					lblPleaseWait.Visible = true;
					lblCancel.Visible = true;
					Frame2.Enabled = false;
					_cmdpay_0.Enabled = false;
					SerialPort1.Encoding = System.Text.Encoding.GetEncoding(28591);
					//Dim input As String = "0150013031" &
					//    ConvertHex(CDec(lbltotal.Text & "00").ToString.PadLeft(12, "0"c)) &
					//    "303030303030303030303030" &
					//    "31363838373030363237323031383932202020" &
					//    "32313130" &
					//    "30303030303030302020202020204E4E4E202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202003"
					//input = "02" & input & LRC(input)
					//input tanpa kartu
					string input = "0150013031" +
						ConvertHex(System.Convert.ToString((decimal.Parse(lbltotal.Text + "00")).ToString().PadLeft(12, '0'))) +
						"303030303030303030303030" +
						"20202020202020202020202020202020202020" +
						"20202020" +
						"30303030303030302020202020204E4E4E202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202003";
					input = "02" + input + LRC(input);
					
					List<byte> bytes = new List<byte>();
					string cc;
					for (int i = 0; i <= input.Length - 2; i += 2)
					{
						try
						{
							cc = input.Substring(i, 2);
							bytes.Add(Convert.ToByte(input.Substring(i, 2), 16));
						}
						catch (Exception)
						{
							
						}
					}
					byte[] process_CMD = bytes.ToArray();
					SerialPort1.PortName = "COM" + System.Convert.ToString(Module1.ECRComm);
					try
					{
						if (SerialPort1.IsOpen == true)
						{
							SerialPort1.Close();
						}
						SerialPort1.Open();
						SerialPort1.Write(process_CMD, 0, process_CMD.Length);
						SerialPort1.Close();
						
						Timer1.Enabled = true;
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
						//If MsgBox("Don't Use ECR BCA ??", MsgBoxStyle.YesNo, "Informations") = vbYes Then
						//    isECR = 0
						//End If
						Timer1.Enabled = false;
						Timer1.Stop();
						txtno_kartu.Enabled = true;
						Frame2.Enabled = true;
						_cmdpay_0.Enabled = true;
						lblPleaseWait.Visible = false;
						lblCancel.Visible = false;
						if (CodePayType != 6)
						{
							ClosePayment();
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					Timer1.Enabled = false;
					Timer1.Stop();
					txtno_kartu.Enabled = true;
					Frame2.Enabled = true;
					_cmdpay_0.Enabled = true;
					lblPleaseWait.Visible = false;
					lblCancel.Visible = false;
					if (CodePayType != 6)
					{
						ClosePayment();
					}
				}
				
			}
			else
			{
				txtno_kartu.Enabled = true;
			}
		}
		
		private string ConvertHex(string data)
		{
			string Hasil = "";
			for (int x = 0; x <= data.Length - 1; x++)
			{
				Hasil = Hasil + "3" + data.Substring(x, 1);
			}
			data = Hasil;
			return data;
		}
		
		private string LRC(string data)
		{
			string binStr = "";
			int[] bin = new int[9];
			int Decimals = 0;
			string Hexadecimal = "";
			for (int x = 0; x <= data.Length - 2; x += 2)
			{
				binStr = System.Convert.ToString(Convert.ToString(Convert.ToInt32(data.Substring(x, 2), 16), 2).PadLeft(8, '0'));
				for (int i = 0; i <= 7; i++)
				{
					bin[i + 1] += System.Convert.ToInt32(binStr.Substring(i, 1));
				}
			}
			Decimals = Convert.ToInt32(bin[1] % 2 + bin[2] % 2 + bin[3] % 2 + bin[4] % 2 + bin[5] % 2 + bin[6] % 2 + bin[7] % 2 + bin[8] % 2);
			Hexadecimal = Convert.ToString(Decimals, 16).ToUpper();
			return Hexadecimal;
		}
		
		public void Timer1_Tick(object sender, EventArgs e)
		{
			cnt++;
			if (cnt > 2000)
			{
				Timer1.Stop();
				lblPleaseWait.Visible = false;
				lblCancel.Visible = false;
				if (Interaction.MsgBox("Connections Time Out !!! Try Again??", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
				{
					cnt = 11;
					lblPleaseWait.Visible = true;
					lblCancel.Visible = true;
					Timer1.Start();
				}
				else
				{
					Timer1.Enabled = false;
					Timer1.Stop();
					Frame2.Enabled = true;
					lblPleaseWait.Visible = false;
					lblCancel.Visible = false;
					_cmdpay_0.Enabled = true;
					txtno_kartu.Enabled = true;
					txtno_kartu.Focus();
					if (CodePayType != 6)
					{
						ClosePayment();
					}
					return;
				}
			}
			
			if (cnt > 10)
			{
				if (SerialPort1.IsOpen == false)
				{
					SerialPort1.Open();
				}
				string buff = "";
				short i = 0;
				string d = "";
				int count;
				count = SerialPort1.BytesToRead;
				
				Response = "";
				buff = SerialPort1.ReadExisting();
				
				for (i = 1; i <= buff.Length; i++)
				{
					d = Conversion.Hex(Strings.Asc(buff.Substring(i - 1, 1)));
					Response = Response + d;
				}
				
				if (Response == "6")
				{
					Response = "";
				}
				
				if (!string.IsNullOrEmpty(Response))
				{
					SerialPort1.Close();
					string ResponseASCII = "";
					ResponseASCII = HexToString(Response.Substring(8, Response.Length - 12));
					if (ResponseASCII.Substring(47, 2) != "00")
					{
						Timer1.Enabled = false;
						Timer1.Stop();
						this.TopMost = false;
						MessageBox.Show("Respon Failed From EDC Device !!!");
						this.TopMost = true;
						Frame2.Enabled = true;
						lblPleaseWait.Visible = false;
						lblCancel.Visible = false;
						_cmdpay_0.Enabled = true;
						txtno_kartu.Enabled = true;
						txtno_kartu.Focus();
						if (CodePayType != 6)
						{
							ClosePayment();
						}
						
						return;
					}
					Timer1.Enabled = false;
					Timer1.Stop();
					if (ResponseASCII.Substring(162, 1) == "Y")
					{
						DCC = "*" + ResponseASCII.Substring(177, 3) + "*";
					}
					else
					{
						DCC = "";
					}
					txtno_kartu.Text = VB.Strings.Left(ResponseASCII.Substring(24, 19), 16);
					txtno_kartu.Enabled = false;
					//Frame2.Enabled = True
					//lblPleaseWait.Visible = False
					//lblCancel.Visible = False
					Module1.isECR = 2;
					
					//tambahan langsung print setelah dapat respon dari EDC
					if ((vstatus.Text.Trim() == "SALES" && string.Compare(lbltotal.Text, vpay.Text) <= 0) || (vstatus.Text.Trim() == "REFUND" && string.Compare(lbltotal.Text, vpay.Text) >= 0))
					{
						//Cek_ECR()
						//If isECR = 1 Then
						//    If Simpan_Detail(lbltotal.Text, VB.Left(txtno_kartu.Text, 16), "") Then
						//        txtno_kartu.Text = ""
						//        Call Cek_Lunas()
						//    End If
						//End If
						if (Module1.isECR == 2 && txtno_kartu.Enabled == false && txtno_kartu.Text.Length > 10)
						{
							if (Simpan_Detail(double.Parse(lbltotal.Text), VB.Strings.Left(txtno_kartu.Text, 16), ref DCC))
							{
								txtno_kartu.Text = "";
								Cek_Lunas();
							}
							Module1.isECR = 1;
							Frame2.Enabled = true;
							lblPleaseWait.Visible = false;
							lblCancel.Visible = false;
							return;
						}
						else
						{
							if (Module1.isECR == 1)
							{
								MessageBox.Show("ECR Connections Failed !!!");
								txtno_kartu.Enabled = true;
								txtno_kartu.Clear();
								txtno_kartu.Select();
								txtno_kartu.Focus();
								if (CodePayType != 6)
								{
									ClosePayment();
								}
								return;
							}
						}
						string temp_card_num = "";
						if (Simpan_Detail(double.Parse(lbltotal.Text), VB.Strings.Left(txtno_kartu.Text, 16), ref temp_card_num))
						{
							txtno_kartu.Text = "";
							Cek_Lunas();
							Frame2.Enabled = true;
							lblPleaseWait.Visible = false;
							lblCancel.Visible = false;
						}
					}
					else
					{
						Interaction.MsgBox("Pembayaran dengan kartu kredit/debit tidak boleh " + Constants.vbNewLine + "melebihi sisa yang harus dibayar", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
						if (Module1.isECR == 2)
						{
							Module1.isECR = 1;
						}
						txtno_kartu.Focus();
					}
				}
			}
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
		
		private void CetakPromo(ref string No_trans)
		{
			DataSet RsPromo = new DataSet();
			DataSet RsBayar = new DataSet();
			short JmlKupon = 0;
			int NilaiOK = 0;
			int ByrNonVoc = 0;
			string Msg = "";
			int min_belanja = 0;
			
			Module1.StrSQL = "SELECT promo_hdr.promo_id, promo_name, min_purchase, min_member, disc, tipe, voucher, lipat, ismsg, isprn , " +
				"SUM(Sales_Transaction_Details.Net_Price) As Belanja, islimit, qtylimit, qtyout, isnull(txt1,'') as txt1, " +
				"isnull(txt2,'') as txt2, isnull(txt3,'') as txt3, isnull(txt4,'') as txt4 FROM Promo_Hdr INNER JOIN " +
				"Promo_Dtl ON Promo_Hdr.promo_id = Promo_Dtl.promo_id INNER JOIN Sales_Transaction_Details ON Promo_Dtl.PLU = " +
				"Sales_Transaction_Details.PLU WHERE (Sales_Transaction_Details.Transaction_Number = '" + No_trans + "') " +
				"AND getdate() Between Start_Date And End_Date And aktif=1 GROUP BY promo_hdr.promo_id, promo_name, " +
				"min_purchase, min_member, disc, tipe, voucher, lipat, ismsg, isprn, islimit, qtylimit, qtyout, txt1, " +
				"txt2, txt3, txt4 Having (promo_hdr.tipe > 30) And SUM(Sales_Transaction_Details.Net_Price)>0 order " +
				"by promo_hdr.promo_id";
			
			//If Linked() Then
			//    RsPromo = getSqldb(StrSQL, ConnServer)
			//Else
			//    RsPromo = getSqldb(StrSQL, ConnLocal)
			//End If
			//tanpa cek PING
			if (Module1.VPing == "ONLINE")
			{
				RsPromo = Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
			}
			else
			{
				RsPromo = Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
			}
			
			if (RsPromo.Tables[0].Rows.Count == 0)
			{
				RsPromo.Clear();
				RsPromo = null;
				return;
			}
			
			RsBayar = Module1.getSqldb("SELECT Transaction_Number, SUM(Paid_Amount) AS Bayar From Paid where(Payment_Types Not in " +
				"('8','5')) " + "GROUP BY Transaction_Number " + "HAVING (Transaction_Number = '" + No_trans + "')", Module1.ConnLocal);
			
			if (RsBayar.Tables[0].Rows.Count > 0)
			{
				ByrNonVoc = System.Convert.ToInt32(RsBayar.Tables[0].Rows[0]["bayar"]);
			}
			else
			{
				ByrNonVoc = 0;
			}
			RsBayar.Clear();
			RsBayar = null;
			
			DataSet RsLagi1 = new DataSet();
			DataSet RsBayarAll = new DataSet();
			DataSet RsLagi = new DataSet();
			string[] NilaiTransx = new string[11];
			string[] NilaiInfox = new string[11];
			foreach (DataRow ro in RsPromo.Tables[0].Rows)
			{
				if (VB.Strings.Left(Module1.Star_Id, 6) == "100000" || string.IsNullOrEmpty(Module1.Star_Id))
				{
					min_belanja = System.Convert.ToInt32(ro["min_purchase"]);
				}
				else
				{
					min_belanja = System.Convert.ToInt32(ro["min_member"]);
				}
				
				Msg = "";
				if ((int) (ro["tipe"]) == 31) //GWP
				{
					JmlKupon = (short) 0;
					if ((int) ro["voucher"] == 0 && (int) ro["lipat"] == 0)
					{
						if (ByrNonVoc < System.Convert.ToInt32(ro["Belanja"]))
						{
							NilaiOK = ByrNonVoc;
						}
						else
						{
							NilaiOK = System.Convert.ToInt32(ro["Belanja"]);
						}
						
						if (NilaiOK >= min_belanja)
						{
							JmlKupon = (short) 1;
						}
					}
					else if ((int) ro["voucher"] == 1 && (int) ro["lipat"] == 0)
					{
						if (System.Convert.ToInt32(ro["Belanja"]) >= min_belanja)
						{
							NilaiOK = System.Convert.ToInt32(ro["Belanja"]);
							JmlKupon = (short) 1;
						}
					}
					else if ((int) ro["voucher"] == 0 && (int) ro["lipat"] == 1)
					{
						if (ByrNonVoc < System.Convert.ToInt32(ro["Belanja"]))
						{
							NilaiOK = ByrNonVoc;
						}
						else
						{
							NilaiOK = System.Convert.ToInt32(ro["Belanja"]);
						}
						
						if (NilaiOK >= min_belanja)
						{
							JmlKupon = (short) (Point.roundDown((double) NilaiOK / min_belanja));
						}
					}
					else if ((int) ro["voucher"] == 1 && (int) ro["lipat"] == 1)
					{
						if (System.Convert.ToInt32(ro["Belanja"]) >= min_belanja)
						{
							NilaiOK = System.Convert.ToInt32(ro["Belanja"]);
							JmlKupon = (short) (Point.roundDown((double) NilaiOK / min_belanja));
						}
					}
					
					if (JmlKupon > 0)
					{
						if ((int) ro["islimit"] == 1)
						{
							if (System.Convert.ToDouble(ro["QtyLimit"]) < System.Convert.ToDouble(System.Convert.ToInt32(ro["QtyOut"]) + JmlKupon))
							{
								Interaction.MsgBox("Hadiah " + System.Convert.ToString(ro["promo_name"]) + " sudah habis", MsgBoxStyle.Information, "Oops..");
								goto lanjut;
							}
							
							Module1.StrSQL = "insert into promo_sales(promo_id,transaction_number,nilai,qty_promo,status) values ('" + System.Convert.ToString(ro["promo_id"]) + "', '" + No_trans + "', " + System.Convert.ToString(NilaiOK) + ", " + System.Convert.ToString(JmlKupon) + ", '00')";
							
							Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
							//If Linked() Then
							//    getSqldb(StrSQL, ConnServer)
							//    getSqldb("Update promo_sales set status='99' where promo_id = '" & ro("promo_id").Value & "' and transaction_number='" & No_trans & "'", ConnLocal)
							//End If
							
							//tanpa cek PING
							if (Module1.VPing == "ONLINE")
							{
								Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
								Module1.getSqldb("Update promo_sales set status='99' where promo_id = '" + System.Convert.ToString(ro["promo_id"]) + "' and transaction_number='" + No_trans + "'", Module1.ConnLocal);
							}
							
							Module1.StrSQL = "update promo_hdr set qtyout=qtyout+ " + System.Convert.ToString(JmlKupon) + " where promo_id='" + System.Convert.ToString(ro["promo_id"]) + "'";
							
							Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
							//If Linked() Then getSqldb(StrSQL, ConnServer)
							
							//tanpa cek PING
							if (Module1.VPing == "ONLINE")
							{
								Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
							}
						}
						
						if ((int) ro["tipe"] == 31) //GWP Normal
						{
							if ((string) ro["txt1"] != "")
							{
								Msg = ro["txt1"] + Constants.vbNewLine;
							}
							if ((string) ro["txt2"] != "")
							{
								Msg = Msg + ro["txt2"] + " = " + System.Convert.ToString(JmlKupon) + " pcs";
							}
							if ((string) ro["txt3"] != "")
							{
								Msg = Msg + (Constants.vbNewLine + ro["txt3"]);
							}
							if ((string) ro["txt4"] != "")
							{
								Msg = Msg + (Constants.vbNewLine + ro["txt4"]);
							}
							Msg = Msg + Constants.vbNewLine + Constants.vbNewLine + "Nilai Transaksi : Rp." + (NilaiOK).ToString("N0");
							Msg = Msg + Constants.vbNewLine + "Struk ini hanya berlaku tgl " + Strings.Format(Module1.GetSrvDate(), "dd MMM yy");
						}
						
						if (VB.Strings.Left(Module1.Star_No, 3) != "LM-")
						{
							Msg = Msg + Constants.vbNewLine + "MyLAKON Card : " + Module1.Star_No;
						}
						if ((int) ro["isprn"] == 1)
						{
							Cetak.CetakStruk_Promo(System.Convert.ToString(ro["promo_id"]), No_trans, Msg);
						}
						if ((int) ro["ismsg"] == 1)
						{
							Interaction.MsgBox(Msg, MsgBoxStyle.Information, "Oops..");
						}
						if ((int) ro["islimit"] == 1)
						{
							Interaction.MsgBox("Sisa Stok Hadiah " + System.Convert.ToString(ro["promo_name"]) + " " + System.Convert.ToString(System.Convert.ToDouble(System.Convert.ToInt32(ro["QtyLimit"]) - System.Convert.ToDouble(ro["QtyOut"])) - 1) + " pcs", MsgBoxStyle.Information, "Oops..");
						}
					}
				}
lanjut:
				1.GetHashCode() ; //VBConversions note: C# requires an executable line here, so a dummy line was added.
			}
			Module1.SaveLog(this.Name + " " + "Cetak Promo " + Module1.VSuper_Nm + " " + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			RsPromo.Clear();
			RsPromo = null;
			return;
ErrH:
			Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
			Module1.SaveLog(this.Name + " " + "Cetak Promo " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
		}
		
		public void Label4_Click(object sender, EventArgs e)
		{
			this.TopMost = false;
			if (!Module1.Super("2"))
			{
				return;
			}
			this.TopMost = true;
			Frame2.Enabled = true;
			lblPleaseWait.Visible = false;
			lblCancel.Visible = false;
			_cmdpay_0.Enabled = true;
			txtno_kartu.Enabled = true;
		}
		
		public void frmPaymentSelf_Load(object sender, EventArgs e)
		{
			vno_trans.Text = Module1.VNomor;
			lblPleaseWait.Visible = false;
			lblCancel.Visible = false;
			t_load = false;
			rbBcaCard.Checked = true;
			CodePayType = 3;
			ArrayList c = new ArrayList();
			Module1.m_con = new SqlConnection(Module1.ConnLocal);
			try
			{
				string strsql = "";
				strsql = "SELECT Payment_Types, Description From Payment_Types where Seq<30 And Types in ('DC','CC','OV')  ORDER BY Description";
				
				if (Module1.m_con.State == ConnectionState.Closed)
				{
					Module1.m_con.Open();
				}
				SqlCommand cmd2 = new SqlCommand(strsql, Module1.m_con);
				
				SqlDataReader objreader2 = cmd2.ExecuteReader();
				while (objreader2.Read())
				{
					c.Add(new CCombo(Strings.Trim(System.Convert.ToString(objreader2["Payment_Types"])), Strings.Trim(objreader2["Description"].ToString())));
				}
				Module1.m_con.Close();
				ComboBox1.DataSource = c;
				ComboBox1.DisplayMember = "Number_Name";
				ComboBox1.ValueMember = "ID";
				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString());
			}
			TotPay = System.Convert.ToInt32(vpay.Text);
			lbltotal.Text = System.Convert.ToString((decimal.Parse(vpay.Text)).ToString("N0"));
			//Tambahan Harga Point Variable
			RoundOfPay = 0;
			t_load = true;
			RoundOfPay = System.Convert.ToInt32(double.Parse(vpay.Text) - (Conversion.Int(double.Parse(vpay.Text) / 100)) * 100);
			if (double.Parse(vpay.Text) < 0)
			{
				if (double.Parse(vpay.Text) != Conversion.Int(double.Parse(vpay.Text) / 100) * 100)
				{
					RoundOfPay = System.Convert.ToInt32(double.Parse(vpay.Text) - (Conversion.Int(double.Parse(vpay.Text) / 100) + 1) * 100);
				}
				else
				{
					RoundOfPay = 0;
				}
			}
			//karena tidak ada pembayaran cash
			RoundOfPay = 0;
			//------
			lbltotal.Text = System.Convert.ToString((TotPay - RoundOfPay).ToString("N0"));
			lbltotal.Text = System.Convert.ToString((TotPay).ToString("N0"));
			txtno_kartu.Enabled = false;
			if (TotPay > 0)
			{
				Cek_ECR();
			}
			
			txtno_kartu.Select();
			txtno_kartu.Focus();
		}
		
		public void rbBcaCard_CheckedChanged(object sender, EventArgs e)
		{
			lblPayTypes.Text = "BCA CARD";
			CodePayType = 3;
			txtno_kartu.Focus();
		}
		
		public void rbDebitBCA_CheckedChanged(object sender, EventArgs e)
		{
			lblPayTypes.Text = "BCA DEBIT";
			CodePayType = 4;
			txtno_kartu.Focus();
		}
		
		public void rbGopay_CheckedChanged(object sender, EventArgs e)
		{
			lblPayTypes.Text = "GO PAY";
			CodePayType = 6;
			txtno_kartu.Focus();
		}
		
		public void rbVisa_CheckedChanged(object sender, EventArgs e)
		{
			lblPayTypes.Text = "VISA";
			CodePayType = 2;
			txtno_kartu.Focus();
		}
		
		public void rbMaster_CheckedChanged(object sender, EventArgs e)
		{
			lblPayTypes.Text = "MASTER";
			CodePayType = 2;
			txtno_kartu.Focus();
		}
		
		public void rbAnother_CheckedChanged(object sender, EventArgs e)
		{
			lblPayTypes.Text = "OTHER BANK";
			CodePayType = 10;
			txtno_kartu.Focus();
		}
		
	}
}
