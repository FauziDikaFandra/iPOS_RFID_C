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

using iPOS;

namespace iPOS
{
	sealed class Point
	{
		public static object MySTAR(string no_kartu)
		{
			DataSet RsMySTAR = new DataSet();
			
			Module1.StrSQL = "select * from Members where Member_Code = '" + no_kartu + "' and Status='A'";
			
			if (Module1.VPing == "ONLINE")
			{
				RsMySTAR = Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
			}
			else
			{
				RsMySTAR = Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
			}
			
			if (RsMySTAR.Tables[0].Rows.Count > 0)
			{
				Module1.Star_Pt = 0;
				Module1.Star_Nm = RsMySTAR.Tables[0].Rows[0]["Member_Name"].ToString();
				if (RsMySTAR.Tables[0].Rows[0]["Member_Code"].ToString() == "LM-00000000")
				{
					Module1.Star_Id = "10000000";
				}
				else
				{
					Module1.Star_Id = Strings.Replace(RsMySTAR.Tables[0].Rows[0]["Member_Code"].ToString(), "LM-", "");
				}
				
				Module1.Star_Freq = "0";
				Module1.Star_Ext1 = "0";
				Module1.Star_Omz = "0";
				Module1.Star_Phone = RsMySTAR.Tables[0].Rows[0]["Phone"].ToString();
				Module1.Star_Email = RsMySTAR.Tables[0].Rows[0]["Email"].ToString();
				Module1.Star_updsts = (byte) 0;
				Module1.Exp_Point = "0";
				Module1.Expired_Date = "0";
			}
			else
			{
				Module1.Star_Pt = 0;
				Module1.Star_Nm = "ONE TIME CUSTOMER";
				Module1.Star_Id = "10000000";
				Module1.Star_Freq = "";
				Module1.Star_Omz = "";
				Module1.Star_Phone = "";
				Module1.Star_Email = "";
				Module1.Star_updsts = (byte) 9;
				Module1.Exp_Point = "";
				Module1.Expired_Date = "";
				Interaction.MsgBox("No Kartu tidak terdaftar / expired" + Constants.vbNewLine + "Mohon hubungi information counter", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
			}
			return no_kartu;
		}
		
		public static short Get_Point(string NoTrans)
		{
			//	DataSet RsPoint = new DataSet();
			//	DataSet RsPointBank = new DataSet();
			//	DataSet RsKartuKredit = new DataSet();
			//	int Npoin = 0;
			//	int Belanja = 0;
			//	int NVoc = 0;
			//	byte Hari = 0;
			//	byte Kali_Point = 0;

			//	Hari = (DateAndTime.Weekday(Module1.GetSrvDate()) == 1) ? 7 : (DateAndTime.Weekday(Module1.GetSrvDate()) - 1);



			//	RsPoint = Module1.getSqldb("SELECT isnull(Amount,0) as amount, substring(active_day," + System.Convert.ToString(Hari) + ",1) as act_day FROM Cust_Option WHERE (Card_Type = 'CM') ", Module1.ConnLocal);
			//	if (RsPoint.Tables[0].Rows.Count > 0)
			//	{
			//		Npoin = System.Convert.ToInt32((RsPoint.Tables[0].Rows[0]["act_day"] == "1") ? (RsPoint.Tables[0].Rows[0]["Amount"]) : 0);
			//	}
			//	else
			//	{
			//		Npoin = 0;
			//	}
			//	RsPoint.Clear();

			//	RsPoint = Module1.getSqldb("select card_number, net_price, Point_Of_Card_Program from sales_transactions where transaction_number = '" + NoTrans + "'", Module1.ConnLocal);
			//	Belanja = System.Convert.ToInt32(RsPoint.Tables[0].Rows[0]["Net_Price"]);
			//	Kali_Point = System.Convert.ToByte(RsPoint.Tables[0].Rows[0]["Point_Of_Card_Program"]);
			//	if (Strings.Left(System.Convert.ToString(RsPoint.Tables[0].Rows[0]["card_number"]), 5) == "CM999")
			//	{
			//		Npoin = 0;
			//	}
			//	RsPoint.Clear();

			//	RsPoint = Module1.getSqldb("select isnull(SUM(net_price),0) as rvoc from sales_transaction_details sd inner join item_master im on sd.PLU=im.PLU " + "where Burui ='NMD92ZZZ9' and Transaction_Number ='" + NoTrans + "'", Module1.ConnLocal);
			//	NVoc = System.Convert.ToInt32(RsPoint.Tables[0].Rows[0]["RVoc"]);
			//	RsPoint.Clear();
			//	RsPoint = null;

			//	if (Npoin > 0)
			//	{
			//		return (short) (roundDown((double) (Belanja - NVoc) / Npoin) * Kali_Point);
			//	}
			//	else
			//	{
			//		return (short) 0;
			//	}

			return 0;
		}
		
		public static double roundDown(double dblValue)
		{
			try
			{
				int myDec = 0;
				
				myDec = (System.Convert.ToString(dblValue)).IndexOf(".") + 1;
				if (myDec > 0)
				{
					return double.Parse(System.Convert.ToString(dblValue).Substring(0, myDec));
				}
				else
				{
					return dblValue;
				}
			}
			catch
			{
				Interaction.MsgBox(Information.Err().Description, MsgBoxStyle.Information, "Round Down");
			}
			return dblValue;
		}
		
		public static string Pay_Point(short JmlPoint, ref string NoCard, string NoTrx, int rupiah)
		{
			string returnValue = "";
			try
			{
				string urut = "";
				
				urut = Gen_Kode("TW");
				
				//ConnLocal.BeginTrans()
				//ConnServer.BeginTrans()
				
				Module1.getSqldb("insert into Cust_Point_Trans(Transaction_number, trans_nr, card_nr, current_point, Claim_Point, Claim_Rp, Date_Trans, User_ID, " + "Data_Status) values ('" + NoTrx + "', '" + urut + "', '" + NoCard + "', " + System.Convert.ToString(Module1.Star_Pt) + ", " + System.Convert.ToString(JmlPoint) + ", " + System.Convert.ToString(rupiah) + ", getdate(), '" + Module1.VKasir_ID + "', '99') ", Module1.ConnLocal);
				
				Module1.getSqldb("insert into Cust_Point_Trans(Transaction_number, trans_nr, card_nr, current_point, Claim_Point, Claim_Rp, Date_Trans, User_ID, " + "Data_Status) values ('" + NoTrx + "', '" + urut + "', '" + NoCard + "', " + System.Convert.ToString(Module1.Star_Pt) + ", " + System.Convert.ToString(JmlPoint) + ", " + System.Convert.ToString(rupiah) + ", getdate(), '" + Module1.VKasir_ID + "', '99') ", Module1.ConnServer);
				
				Module1.getSqldb("Update card set card_point=card_point - " + System.Convert.ToString(JmlPoint) + "where card_nr = '" + NoCard + "'", Module1.ConnLocal);
				Module1.getSqldb("Update card set card_point=card_point - " + System.Convert.ToString(JmlPoint) + "where card_nr = '" + NoCard + "'", Module1.ConnServer);
				
				Module1.StrSQL = "";
				
				//ConnLocal.CommitTrans()
				//ConnServer.CommitTrans()
				
				returnValue = urut;
				MySTAR(NoCard);
			}
			catch
			{
				//ConnLocal.RollbackTrans()
				//ConnServer.RollbackTrans()
				return "GAGAL";
			}
			return "";
		}
		
		private static string Gen_Kode(string kode)
		{
			string returnValue = "";
			DataSet RsCari = new DataSet();
			string Depan = "";
			
			switch (kode)
			{
				case "TM":
					Depan = "TM" + Module1.VBranch_ID.Substring(Module1.VBranch_ID.Length - 3, 3) + Module1.VReg_ID + Strings.Format(Module1.GetSrvDate(), "YYMMDD");
					
					Module1.StrSQL = "SELECT  max (CAST(RIGHT(custtrans_nr, 4) AS int)) AS nomor " + "FROM Customer_Transaction_H_MemberCard where left(custtrans_nr,14)='" + Depan + "'";
					break;
				case "TW":
					Depan = "TW" + Module1.VBranch_ID.Substring(Module1.VBranch_ID.Length - 3, 3) + Module1.VReg_ID + Strings.Format(Module1.GetSrvDate(), "YYYYMMDD");
					
					Module1.StrSQL = "SELECT  max (CAST(RIGHT(trans_nr, 4) AS int)) AS nomor " + "FROM Cust_Point_Trans where left(trans_nr,16)='" + Depan + "'";
					break;
			}
			
			
			RsCari = Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
			
			if (Information.IsDBNull(RsCari.Tables[0].Rows[0]["nomor"]))
			{
				returnValue = Depan + "0001";
			}
			else
			{
				returnValue = Depan + ("000" + System.Convert.ToString(System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["nomor"]) + 1)).Substring(("000" + System.Convert.ToString(System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["nomor"]) + 1)).Length - 4, 4);
			}
			
			RsCari.Clear();
			RsCari = null;
			return returnValue;
		}
		
		public static void Save_Point(ref string NoTrans, ref string NoCard)
		{
			try
			{
				short zz = 0;
				string urut = "";
				
				zz = Get_Point(NoTrans);
				urut = Gen_Kode("TM");
				//If Linked() Then
				//    getSqldb("update card set card_point=card_point+" & zz & " where card_nr = '" & NoCard & "'", ConnServer)
				//Else
				//    getSqldb("update card set card_point=card_point+" & zz & " where card_nr = '" & NoCard & "'", ConnLocal)
				//End If
				//tanpa cek PING
				if (Module1.VPing == "ONLINE")
				{
					Module1.getSqldb("update card set card_point=card_point+" + System.Convert.ToString(zz) + " where card_nr = '" + NoCard + "'", Module1.ConnServer);
				}
				else
				{
					Module1.getSqldb("update card set card_point=card_point+" + System.Convert.ToString(zz) + " where card_nr = '" + NoCard + "'", Module1.ConnLocal);
				}
				Module1.StrSQL = "insert into Customer_Transaction_H_MemberCard(CustTrans_Nr, CustTrans_Date, Card_Nr, CustTrans_TotAmount," + "CustTrans_Point, User_ID, Trans_Time, Data_Status) " + "(select '" + urut + "', transaction_date, card_number, net_price, " + System.Convert.ToString(zz) + ", cashier_id, transaction_time, '00' " + "from Sales_Transactions where Transaction_Number = '" + NoTrans + "')";
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				if (Module1.Linked())
				{
					Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
					Module1.getSqldb("Update Customer_Transaction_H_MemberCard set data_status='99' where custtrans_nr = '" + urut + "'", Module1.ConnLocal);
				}
				
				Module1.StrSQL = "insert into Customer_Transaction_D_MemberCard(CustTrans_Nr, CustTrans_Struk, CustTrans_Amount, Data_Status)" + "select '" + urut + "', Transaction_Number, net_price, '00'" + "from Sales_Transactions where Transaction_Number = '" + NoTrans + "'";
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				if (Module1.Linked())
				{
					Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
					Module1.getSqldb("Update Customer_Transaction_d_MemberCard set data_status='99' where custtrans_nr = '" + urut + "'", Module1.ConnLocal);
				}
				
				
				Module1.StrSQL = "";
				MySTAR(NoCard);
				Interaction.MsgBox("Point bertambah : " + System.Convert.ToString(zz) + Constants.vbNewLine + "Saldo Akhir Point : " + System.Convert.ToString(Module1.Star_Pt), MsgBoxStyle.Information, "Oops..");
			}
			catch
			{
				Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				Module1.SaveLog("Save_Point " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number));
			}
			
		}
	}
	
}
