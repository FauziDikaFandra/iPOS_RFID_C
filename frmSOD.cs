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
using Microsoft.VisualBasic.CompilerServices;
using iPOS;

namespace iPOS
{
	
	public partial class frmSOD : System.Windows.Forms.Form
	{
		public frmSOD()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmSOD defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmSOD Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmSOD();
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
		string Dbs;
		string Svr;
		public void Chk_CheckStateChanged(System.Object eventSender, System.EventArgs eventArgs)
		{
			short Index = 1;
		}
		public void frmSOD_Load(System.Object sender, System.EventArgs e)
		{
			//CheckForIllegalCrossThreadCalls = False
			Dbs = Module1.ReadIni("Server", "DatabaseName");
			Svr = "[" + Module1.VSvr + "]";
		}
		public void frmSOD_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			//CheckForIllegalCrossThreadCalls = False
			DataSet RsSOD = new DataSet();
			
			Module1.StrSQL = "select flag_sod from branches where branch_id ='" + Module1.VBranch_ID + "'";
			
			if (Module1.VPing == "ONLINE")
			{
				RsSOD = Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
				if (System.Convert.ToInt32(System.Convert.ToInt32(RsSOD.Tables[0].Rows[0]["Flag_SOD"])) == 0)
				{
					Interaction.MsgBox("Server belum SOD..", (int) Constants.vbCritical + Constants.vbOKOnly, "Oops..");
					this.Close();
					ProjectData.EndApp();
				}
			}
			
			// "server"
			
			
			// "local"
			RsSOD = Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
			if (Module1.VPing == "ONLINE")
			{
				if (System.Convert.ToInt32(RsSOD.Tables[0].Rows[0]["Flag_SOD"]) == 0)
				{
					this.Text = "SOD";
					Proses_SOD();
					//frmLogin.Show()
				}
				else
				{
					this.Text = "EOD";
					BackgroundWorker1.WorkerReportsProgress = true;
					BackgroundWorker1.WorkerSupportsCancellation = true;
					BackgroundWorker1.RunWorkerAsync();
					//Proses_EOD()
					
				}
			}
			else
			{
				
				if (System.Convert.ToInt32(RsSOD.Tables[0].Rows[0]["Flag_SOD"]) == 0)
				{
					this.Text = "SOD OFFLINE";
					Module1.getSqldb("update branches set flag_sod=1,date_current = getdate() where branch_id='" + Module1.VBranch_ID + "'", Module1.ConnLocal);
					Module1.SaveLog(this.Name + " SOD OFFLINE SUCESS!!! @" + System.Convert.ToString(DateTime.Now));
}

frmLogin.Default.Show();
this.Close();
}

//ProgressBar1.Visible = True
//ProgressBar1.Value = 0
//CheckForIllegalCrossThreadCalls = False
//BackgroundWorker1.WorkerReportsProgress = True
//BackgroundWorker1.WorkerSupportsCancellation = True
//BackgroundWorker1.RunWorkerAsync()
}
private void Proses_SOD()
{
try
{
ProgressBar1.Value = 0;
byte b = 0;
lblmsg.Text = "DOWNLOAD DATA..";
		Frame2.Visible = false;
		Frame1.Visible = true;
		decimal Prg = 0;
		Module1.getSqldb("exec spp_BackupLocalTable", Module1.ConnLocal);
		for (b = 0; b <= 10; b++)
		{
			Prg += (decimal) ((double) 100 / 10);
			Chk[b].CheckState = System.Windows.Forms.CheckState.Checked;
			if (b == ((byte) 0))
			{
				Module1.getSqldb("exec spp_DownLoadItemMaster '" + Svr + "','" + Dbs + "',''", Module1.ConnLocal);
				//Case 1 : getSqldb("exec spp_DownLoadPaymentTypes '" & Svr & "','" & Dbs & "'", ConnLocal)
				//Case 2 : getSqldb("exec spp_DownLoadBinCard '" & Svr & "','" & Dbs & "'", ConnLocal)
			}
			else if (b == ((byte) 3))
			{
				Module1.getSqldb("exec spp_DownLoadUsers '" + Svr + "','" + Dbs + "'", Module1.ConnLocal);
				//Case 4 : getSqldb("exec spp_DownLoadBranchAttributes '" & VBranch_ID & "','" & Svr & "','" & Dbs & "'", ConnLocal)
			}
			else if (b == ((byte) 5))
			{
				Module1.getSqldb("exec spp_DownLoadMC '" + Svr + "','" + Dbs + "'", Module1.ConnLocal);
			}
			else if (b == ((byte) 6))
			{
				Module1.getSqldb("exec spp_DownLoadUserBO '" + Svr + "','" + Dbs + "'", Module1.ConnLocal);
			}
			else if (b == ((byte) 7))
			{
				Module1.getSqldb("exec spp_DownloadCashRegister '" + Module1.VReg_ID + "','" + Module1.VBranch_ID + "','" + Svr + "','" + Dbs + "'", Module1.ConnLocal);
				//Case 8 : getSqldb("exec spp_DownLoadCpoint '" & Svr & "','" & Dbs & "'", ConnLocal)
			}
			else if (b == ((byte) 9))
			{
				Module1.getSqldb("exec spp_DownLoadOthers '" + Svr + "','" + Dbs + "'", Module1.ConnLocal);
			}
			else if (b == ((byte) 10))
			{
				Module1.getSqldb("exec spp_DownLoadRFID '" + Svr + "','" + Dbs + "'", Module1.ConnLocal);
			}
			//If Int(Prg) <= 100 Then
			//    BackgroundWorker1.ReportProgress(Int(Prg))
			//End If
			
		}
		
		Module1.getSqldb("update branches set flag_sod=1,date_current = getdate() where branch_id='" + Module1.VBranch_ID + "'", Module1.ConnLocal);
		//Me.Close()
		//Exit Sub
		
		frmFirstForm.Default.Show();
		//frmShowStock.Show()
	}
	catch (Exception)
	{
		Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) Constants.vbCritical + Constants.vbOKOnly, "Oops..");
		Module1.SaveLog(this.Name + " " + "SOD " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
	}
}
private void Proses_EOD()
{
	try
	{
		ProgressBar1.Value = 0;
		lblmsg.Text = "UPLOAD DATA..";
		Frame2.Visible = true;
		Frame1.Visible = false;
		if (Module1.VPing == "ONLINE")
		{
			BackgroundWorker1.ReportProgress(Conversion.Int(20));
			Naikin_Data();
			BackgroundWorker1.ReportProgress(Conversion.Int(40));
			//Call Naikin_Promo()
			BackgroundWorker1.ReportProgress(Conversion.Int(60));
			//Call Naikin_Point()
			//Call Update_RfidCode()
			BackgroundWorker1.ReportProgress(Conversion.Int(80));
		}
		this.Close();
		return;
	}
	catch (Exception)
	{
		//MsgBox(UCase(Err.Description), vbCritical + vbOKOnly, "Oops..")
		Module1.SaveLog(this.Name + " " + "EOD " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
	}
}
private void Naikin_Data()
{
	try
	{
		DataSet RsA = new DataSet();
		RsA = Module1.getSqldb("SELECT Transaction_Number From SALES_TRANSACTIONS Where upload_Status ='00' And Status <> '01'", Module1.ConnLocal);
		
		if (RsA.Tables[0].Rows.Count > 0)
		{
			foreach (DataRow ro in RsA.Tables[0].Rows)
			{
				Module1.StrSQL = "DELETE " + Svr +"." + Dbs +".dbo.Sales_Transactions  WHERE transaction_number= '" + System.Convert.ToString(ro["Transaction_Number"]) + "'";
				
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "Insert " + Svr +"." + Dbs +".dbo.Sales_Transactions " +
					"(Transaction_Number, Cashier_ID, Customer_ID, Card_Number, Spending_Program_ID, Transaction_Date " +
					", Total_Discount, Points_Of_Spending_Program, Point_Of_Item_Program, Point_Of_Card_Program, Payment_program_ID " +
					", Branch_ID, Cash_Register_ID, Total_Paid, Net_Price, Tax, Net_Amount, Change_Amount, Flag_Arrange, WorkManShip " +
					", Flag_Return, Register_Return, Transaction_Date_Return, Transaction_Number_Return, Last_Point, Get_Point " +
					", Status, upload_status, Transaction_Time, Store_Type ) " +
					"SELECT Transaction_Number, Cashier_ID, Customer_ID, Card_Number, Spending_Program_ID, Transaction_Date, " +
					"Total_Discount, Points_Of_Spending_Program, Point_Of_Item_Program, Point_Of_Card_Program, Payment_program_ID, " +
					"Branch_ID, Cash_Register_ID, Total_Paid, Net_Price, Tax, Net_Amount, Change_Amount, Flag_Arrange, WorkManShip, " +
					"Flag_Return, Register_Return, Transaction_Date_Return, Transaction_Number_Return, Last_Point, Get_Point, " +
					"Status , upload_status, Transaction_Time, Store_Type " +
					"FROM SALES_TRANSACTIONS  WHERE transaction_number= '" + System.Convert.ToString(ro["Transaction_Number"]) + "'";
				
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "DELETE " + Svr +"." + Dbs +".dbo.Sales_Transaction_Details WHERE transaction_number= '" + System.Convert.ToString(ro["Transaction_Number"]) + "'";
				
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "Insert " + Svr +"." + Dbs +".dbo.Sales_Transaction_details " +
					"(Transaction_Number, Seq, PLU, Item_Description, Price, Qty, Amount, Discount_Percentage,  " +
					"Discount_Amount, extradisc_pct, extradisc_amt, Net_Price, Points_Received, Flag_Void, Flag_Status, Flag_Paket_Discount,Epc_Code) " +
					"SELECT Transaction_Number, Seq, PLU, Item_Description, Price, Qty, Amount, Discount_Percentage,  " +
					"Discount_Amount, extradisc_pct, extradisc_amt, Net_Price, Points_Received, Flag_Void, Flag_Status, Flag_Paket_Discount,Epc_Code " +
					"FROM Sales_Transaction_details WHERE transaction_number= '" + System.Convert.ToString(ro["Transaction_Number"]) + "'";
				
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "DELETE " + Svr +"." + Dbs +".dbo.paid WHERE transaction_number= '" + System.Convert.ToString(ro["Transaction_Number"]) + "'";
				
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "Insert " + Svr +"." + Dbs +".dbo.paid " +
					"(Transaction_Number, Payment_Types, Seq, Currency_ID, Currency_Rate, Credit_Card_No,  " +
					"Credit_Card_Name, Paid_Amount, Shift)  " +
					"SELECT Transaction_Number, Payment_Types, Seq, Currency_ID, Currency_Rate, Credit_Card_No,   " +
					"Credit_Card_Name, Paid_Amount, Shift  " +
					"From PAID  WHERE transaction_number= '" + System.Convert.ToString(ro["Transaction_Number"]) + "'";
				
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "update sales_transactions set upload_status='99' WHERE transaction_number= '" + System.Convert.ToString(ro["Transaction_Number"]) + "'";
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "delete from " + Svr +"." + Dbs +".dbo.cash where branch_id='" + Module1.VBranch_ID + "' and Cash_Register_ID ='" + Module1.VReg_ID + "' and Datetime = '" + System.Convert.ToString(
					Module1.GetSrvDate().Date) + "'";
				
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "Insert  " + Svr +"." + Dbs +".dbo.cash " +
					"(Branch_ID, Datetime, Cash_Register_ID, Shift, User_ID, Modal, Cash, Voucher, " +
					"Other_Voucher, Credit_Card, Debet_Card, Credit_Sales, Entertainment, Deposit, Other_Income, Netto, " +
					"Discount, Tax, [Returns] , No_Sale, Cancel) " +
					"SELECT Branch_ID, Datetime, Cash_Register_ID, Shift, User_ID, Modal, Cash, Voucher, " +
					"Other_Voucher, Credit_Card, Debet_Card, Credit_Sales, Entertainment, Deposit, Other_Income, Netto,  " +
					"Discount, Tax, [Returns], No_Sale, Cancel  " +
					"FROM Cash where branch_id='" + Module1.VBranch_ID + "' and Cash_Register_ID ='" + Module1.VReg_ID + "' and Datetime = '" + System.Convert.ToString(
					Module1.GetSrvDate().Date) + "'";
				
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				//--update EPC
				//StrSQL = "update a set a.epc_code = b.epc_code from " & Svr & "." & Dbs & ".dbo.sales_transaction_details a inner join sales_transaction_details b " &
				//         "on a.transaction_number = b.transaction_number And a.plu = b.plu And a.seq = b.seq " &
				//         "where b.transaction_number = '" & ro("Transaction_Number") & "'"
				//getSqldb(StrSQL, ConnLocal)
			}
		}
	}
	catch (Exception)
	{
		Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) Constants.vbCritical + Constants.vbOKOnly, "Oops..");
		Module1.SaveLog(this.Name + " " + "Naikin_Data " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
	}
}
private void Naikin_Promo()
{
	try
	{
		DataSet RsA = new DataSet();
		RsA = Module1.getSqldb("SELECT Transaction_Number, qty_promo, promo_id From promo_sales Where Status ='00'", Module1.ConnLocal);
		
		if (RsA.Tables[0].Rows.Count > 0)
		{
			foreach (DataRow ro in RsA.Tables[0].Rows)
			{
				Module1.StrSQL = "DELETE " + Svr +"." + Dbs +".dbo.promo_sales WHERE transaction_number= '" + System.Convert.ToString(ro["Transaction_Number"]) + "'";
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "Insert " + Svr +"." + Dbs +".dbo.promo_sales " +
					"(promo_id, transaction_number, nilai, qty_promo, status ) " +
					"SELECT  promo_id, transaction_number, nilai, qty_promo, '99'" +
					"FROM promo_sales  WHERE transaction_number= '" + System.Convert.ToString(ro["Transaction_Number"]) + "'";
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "update promo_sales set status='99' WHERE transaction_number= '" + System.Convert.ToString(ro["Transaction_Number"]) + "'";
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "update " + Svr +"." + Dbs +".dbo.promo_hdr set qtyout=qtyout+ " + System.Convert.ToString(ro["qty_promo"]) + " where promo_id='" + System.Convert.ToString(ro["promo_id"]) + "' and islimit=1";
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
			}
		}
	}
	catch (Exception)
	{
		Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) Constants.vbCritical + Constants.vbOKOnly, "Oops..");
		Module1.SaveLog(this.Name + " " + "Naikin_Promo " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
	}
}
private void Naikin_Point()
{
	try
	{
		DataSet RsA = new DataSet();
		RsA = Module1.getSqldb("SELECT * From customer_transaction_h_membercard a inner join customer_transaction_d_membercard b " +
			"On a.CustTrans_Nr =  b.CustTrans_Nr Where a.data_Status ='00' or b.data_Status = '00'", Module1.ConnLocal);
		
		if (RsA.Tables[0].Rows.Count > 0)
		{
			foreach (DataRow ro in RsA.Tables[0].Rows)
			{
				Module1.StrSQL = "DELETE FROM " + Svr +"." + Dbs +".dbo.customer_transaction_h_membercard WHERE CustTrans_Nr= '" + System.Convert.ToString(ro["CustTrans_Nr"]) + "'";
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "DELETE FROM " + Svr +"." + Dbs +".dbo.customer_transaction_d_membercard WHERE CustTrans_Nr= '" + System.Convert.ToString(ro["CustTrans_Nr"]) + "'";
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "Insert " + Svr +"." + Dbs +".dbo.customer_transaction_h_membercard " +
					"(CustTrans_Nr, CustTrans_Date, Card_Nr, CustTrans_TotAmount, CustTrans_Point, User_ID, Trans_Time, Data_Status ) " +
					"SELECT  CustTrans_Nr, CustTrans_Date, Card_Nr, CustTrans_TotAmount, CustTrans_Point, User_ID, Trans_Time, '00'" +
					"FROM customer_transaction_h_membercard  WHERE CustTrans_Nr= '" + System.Convert.ToString(ro["CustTrans_Nr"]) + "'";
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "Insert " + Svr +"." + Dbs +".dbo.customer_transaction_d_membercard " +
					"(CustTrans_Nr, CustTrans_Struk, CustTrans_Amount, Data_Status) " +
					"SELECT  CustTrans_Nr, CustTrans_Struk, CustTrans_Amount, '00'" +
					"FROM customer_transaction_d_membercard  WHERE CustTrans_Nr= '" + System.Convert.ToString(ro["CustTrans_Nr"]) + "'";
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "update customer_transaction_h_membercard set data_status='99' WHERE CustTrans_Nr= '" + System.Convert.ToString(ro["CustTrans_Nr"]) + "'";
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "update customer_transaction_d_membercard set data_status='99' WHERE CustTrans_Nr= '" + System.Convert.ToString(ro["CustTrans_Nr"]) + "'";
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "update " + Svr +"." + Dbs +".dbo.card set card_point=card_point+ " + System.Convert.ToString(ro["CustTrans_Point"]) + " where card_nr='" + System.Convert.ToString(ro["Card_Nr"]) + "'";
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
			}
		}
	}
	catch (Exception)
	{
		Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) Constants.vbCritical + Constants.vbOKOnly, "Oops..");
		Module1.SaveLog(this.Name + " " + "Naikin_Point " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
	}
}

private void Update_RfidCode()
{
	try
	{
		DataSet RsA = new DataSet();
		RsA = Module1.getSqldb("Select Epc_Code from sales_transaction_details a inner join sales_transactions b on a.transaction_number = b.transaction_number  " +
			" where b.status = '00' and Epc_Code <> ''", Module1.ConnLocal);
		if (RsA.Tables[0].Rows.Count > 0)
		{
			foreach (DataRow ro in RsA.Tables[0].Rows)
			{
				Module1.getSqldb("Update Item_Master_RFID set Flag = 1 where TID = '" + System.Convert.ToString(ro["Epc_Code"]) + "' and [Status] = '1' And Flag = '0'", Module1.ConnServer);
			}
		}
		//RsA = getSqldb("update x set x.flag = y.flag from " & Svr & "." & Dbs & ".dbo.Item_Master_RFID x inner join  (SELECT * From Item_Master_RFID where TID in (select epc_code from sales_transaction_details a inner join " &
		//               "sales_transactions b on a.transaction_number = b.transaction_number  where b.status = '00' " &
		//               "and substring(a.transaction_number,9,8) = '" & Format(GetSrvDate, "ddMMyyyy") & "') and flag = 1) y on x.plu = y.plu and x.epc = y.epc", ConnLocal)
	}
	catch (Exception)
	{
		Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) Constants.vbCritical + Constants.vbOKOnly, "Oops..");
		Module1.SaveLog(this.Name + " " + "Update_Rfid " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
	}
	
	
}
public void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
{
	if (this.Text == "SOD")
	{
		Proses_SOD();
	}
	if (this.Text == "EOD")
	{
		Proses_EOD();
	}
	//Me.Close()
}
public void BackgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
{
	ProgressBar1.Value = e.ProgressPercentage;
}
public void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
{
	ProgressBar1.Visible = false;
	//frmLogin.Show()
	if (Module1.EODFirstForm == true)
	{
		Application.Exit();
	}
	else
	{
		frmFirstForm.Default.Show();
	}
	
	//frmShowStock.Show()
	this.Close();
}
}
}
