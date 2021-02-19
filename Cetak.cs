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

using Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6;
using System.Runtime.InteropServices;
using System.Drawing.Printing;
using System.IO.Ports;
using iPOS;

namespace iPOS
{
	sealed class Cetak
	{
		static Printer Printer = new Printer();
		public class RawPrinter
		{
			// ----- Define the data type that supplies basic print job information to the spooler.
			[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
				public struct DOCINFO
				{
				[MarshalAs(UnmanagedType.LPWStr)]
					public string pDocName;
				[MarshalAs(UnmanagedType.LPWStr)]
					public string pOutputFile;
				[MarshalAs(UnmanagedType.LPWStr)]
					public string pDataType;
			}
			
			// ----- Define interfaces to the functions supplied in the DLL.
			[DllImport("winspool.drv", EntryPoint = "OpenPrinterW", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
				public static  extern bool OpenPrinter(string printerName, ref IntPtr hPrinter, int printerDefaults);
			
			[DllImport("winspool.drv", EntryPoint = "ClosePrinter", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
				public static  extern bool ClosePrinter(IntPtr hPrinter);
			
			[DllImport("winspool.drv", EntryPoint = "StartDocPrinterW", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
				public static  extern bool StartDocPrinter(IntPtr hPrinter, int level, ref DOCINFO documentInfo);
			
			[DllImport("winspool.drv", EntryPoint = "EndDocPrinter", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
				public static  extern bool EndDocPrinter(IntPtr hPrinter);
			
			[DllImport("winspool.drv", EntryPoint = "StartPagePrinter", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
				public static  extern bool StartPagePrinter(IntPtr hPrinter);
			
			[DllImport("winspool.drv", EntryPoint = "EndPagePrinter", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
				public static  extern bool EndPagePrinter(IntPtr hPrinter);
			
			[DllImport("winspool.drv", EntryPoint = "WritePrinter", SetLastError = true, CharSet = CharSet.Unicode, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
				public static  extern bool WritePrinter(IntPtr hPrinter, IntPtr buffer, int bufferLength, ref int bytesWritten);
			
			public static bool PrintRaw(string printerName, string origString)
			{
				bool returnValue = false;
				// ----- Send a string of  raw data to  the printer.
				IntPtr hPrinter = default(IntPtr);
				DOCINFO spoolData = new DOCINFO();
				IntPtr dataToSend = default(IntPtr);
				int dataSize = 0;
				int bytesWritten = 0;
				
				// ----- The internal format of a .NET String is just
				//       different enough from what the printer expects
				//       that there will be a problem if we send it
				//       directly. Convert it to ANSI format before
				//       sending.
				dataSize = origString.Length;
				dataToSend = Marshal.StringToCoTaskMemAnsi(origString);
				
				// ----- Prepare information for the spooler.
				spoolData.pDocName = "OpenDrawer"; // class='highlight'
				spoolData.pDataType = "RAW";
				
				try
				{
					// ----- Open a channel to  the printer or spooler.
					OpenPrinter(printerName, ref hPrinter, 0);
					
					// ----- Start a new document and Section 1.1.
					StartDocPrinter(hPrinter, 1, ref spoolData);
					StartPagePrinter(hPrinter);
					
					// ----- Send the data to the printer.
					WritePrinter(hPrinter, dataToSend,
						dataSize, ref bytesWritten);
					
					// ----- Close everything that we opened.
					EndPagePrinter(hPrinter);
					EndDocPrinter(hPrinter);
					ClosePrinter(hPrinter);
					returnValue = true;
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error occurred: " + ex.ToString());
					returnValue = false;
				}
				finally
				{
					// ----- Get rid of the special ANSI version.
					Marshal.FreeCoTaskMem(dataToSend);
				}
				return returnValue;
			}
		}
		public static void OpenCashdrawer()
		{
			//Modify DrawerCode to your receipt printer open drawer code
			string DrawerCode = (char) 27 + System.Convert.ToString((char) 112) + System.Convert.ToString((char) 48) + System.Convert.ToString((char) 64) + System.Convert.ToString((char) 64);
			//Modify PrinterName to your receipt printer name
			string PrinterName = "Your receipt printer name";
			
			RawPrinter.PrintRaw(PrinterName, DrawerCode);
		}
		public static void CetakBegin()
		{
			Printer.FontName = "Printer 17cpi";
			Printer.FontSize = 9;
			Printer.Print("POS BEGIN... ");
			Printer.Write("NPWP");
			Printer.CurrentX = 1000;
			Printer.Print(": " + Module1.Tulis[9]);
			Printer.Write("REGISTER");
			Printer.CurrentX = 1000;
			Printer.Print(": " + Module1.VReg_ID);
			Printer.Write("CASHIER");
			Printer.CurrentX = 1000;
			Printer.Print(": " + System.Convert.ToString(Module1.VShift) + " - " + Module1.VKasir_ID + "/" + Module1.VKasir_Nm);
			Printer.Write("TIME");
			Printer.CurrentX = 1000;
			Printer.Print(": " + Strings.Format(DateTime.Now, "dd/MMM/yyyy hh:mm:ss"));
			Printer.EndDoc();
		}
		
		public static void CekMissPaid()
		{
			DataSet RsCek = new DataSet();
			RsCek = Module1.getSqldb("select a.* from sales_transactions a left join paid b on a.transaction_number = b.transaction_number where a.status = '00' and b.Transaction_Number is null", Module1.ConnLocal);
			if (RsCek.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow ro in RsCek.Tables[0].Rows)
				{
					Module1.getSqldb("Insert into paid select '" + System.Convert.ToString(ro["transaction_number"]) + "',4,1,'IDR',1,'530795******1234','','" + System.Convert.ToString(ro["Total_Paid"]) + "',1", Module1.ConnLocal);
					if (Module1.VPing == "ONLINE")
					{
						Module1.getSqldb("Insert into paid select '" + System.Convert.ToString(ro["transaction_number"]) + "',4,1,'IDR',1,'530795******1234','','" + System.Convert.ToString(ro["Total_Paid"]) + "',1", Module1.ConnServer);
					}
				}
			}
		}
		
		public static void XRead()
		{
			DataSet RsBayar = new DataSet();
			DataSet Rs = new DataSet();
			long Jual = 0;
			long diskon = 0;
			long Retur = 0;
			long Batal = 0;
			long Modal = 0;
			long Jumlah = 0;
			
			OpenLaci((byte) 0);
			if (Convert.ToInt32(Module1.ReadIni("Printer", "X_ReadPrint")) == 1)
			{
				Rs = Module1.getSqldb("SELECT isnull(SUM(Net_amount),0) AS Nilai, isnull(SUM(Total_discount),0) AS Potong " +
					"FROM Sales_Transactions WHERE Status = '00' and substring(transaction_number, 9,8)='" + Strings.Format(Module1.GetSrvDate(), "ddMMyyyy") +
					"' and Transaction_Number in (select transaction_number from paid where Paid.Shift = '" + System.Convert.ToString(Module1.VShift) + "') And substring(transaction_number, 5,3) = '" + Module1.VReg_ID + "' ", Module1.ConnLocal);
				Jual = System.Convert.ToInt64(Rs.Tables[0].Rows[0]["nilai"]);
				diskon = System.Convert.ToInt64(Rs.Tables[0].Rows[0]["Potong"]);
				Rs.Clear();
				
				Rs = Module1.getSqldb("SELECT isnull(SUM(Net_amount),0) AS Balik " +
					"FROM Sales_Transactions WHERE Flag_Return  = '1' and substring(transaction_number, 9,8)='" + Strings.Format(Module1.GetSrvDate(), "ddMMyyyy") +
					"' and Transaction_Number in (select transaction_number from paid where Paid.Shift = '" + System.Convert.ToString(Module1.VShift) + "')  And substring(transaction_number, 5,3) = '" + Module1.VReg_ID + "' ", Module1.ConnLocal);
				Retur = System.Convert.ToInt64(Rs.Tables[0].Rows[0]["balik"]);
				Rs.Clear();
				
				Rs = Module1.getSqldb("SELECT isnull(SUM(Net_Price),0) AS Nilai " +
					"FROM Sales_Transaction_Details WHERE substring(transaction_number, 9,8)='" + Strings.Format(Module1.GetSrvDate(), "ddMMyyyy") +
					"' and Transaction_Number in (select transaction_number from paid where Paid.Shift = '" + System.Convert.ToString(Module1.VShift) + "' and flag_void='1')  And substring(transaction_number, 5,3) = '" + Module1.VReg_ID + "'", Module1.ConnLocal);
				Batal = System.Convert.ToInt64(Rs.Tables[0].Rows[0]["nilai"]);
				Rs.Clear();
				
				Rs = Module1.getSqldb("SELECT Modal From Cash WHERE (Branch_ID = '" + Module1.VBranch_ID + "') AND (Datetime = '" + System.Convert.ToString(
					Module1.GetSrvDate().Date) + "') AND (Shift = " + System.Convert.ToString(Module1.VShift) + ") And Cash_Register_ID = '" + Module1.VReg_ID + "'", Module1.ConnLocal);
				if (Rs.Tables[0].Rows.Count > 0)
				{
					Modal = System.Convert.ToInt64(Rs.Tables[0].Rows[0]["Modal"]);
				}
				else
				{
					Modal = 0;
				}
				Rs.Clear();
				Rs = null;
				
				RsBayar = Module1.getSqldb("SELECT Payment_Types.Description, SUM(Paid.Paid_Amount) AS Nilai " +
					"FROM Paid INNER JOIN Payment_Types ON Paid.Payment_Types = Payment_Types.Payment_Types " +
					"WHERE (Paid.Shift = '" + System.Convert.ToString(Module1.VShift) + "') and substring(transaction_number, 9,8)='" + Strings.Format(Module1.GetSrvDate(), "ddMMyyyy") +
					"'  And substring(transaction_number, 5,3) = '" + Module1.VReg_ID + "' GROUP BY Payment_Types.seq, Payment_Types.Description order by Payment_Types.seq", Module1.ConnLocal);
				Printer.FontSize = 8;
				Printer.Write("X-Reading Shift");
				Printer.CurrentX = 1500;
				Printer.Print(": " + System.Convert.ToString(Module1.VShift) + " " + frmMain.Default.lblline.Text);
				Printer.Write("BRANCH");
				Printer.CurrentX = 1500;
				Printer.Print(": " + Module1.Tulis[10]);
				Printer.Write("REGISTER");
				Printer.CurrentX = 1500;
				Printer.Print(": " + Module1.VReg_ID);
				Printer.Write("CASHIER");
				Printer.CurrentX = 1500;
				Printer.Print(": " + Module1.VKasir_ID + "/" + Module1.VKasir_Nm);
				Printer.Write("TIME");
				Printer.CurrentX = 1500;
				Printer.Print(": " + Strings.Format(DateTime.Now, "dd/MMM/yyyy hh:mm:ss"));
				Printer.Print(Module1.VGaris);
				Printer.Write("MODAL");
				Printer.CurrentX = 1800;
				Printer.Write(": Rp. ");
				CetakKanan((Modal).ToString("N0") + "    ");
				
				foreach (DataRow ro in RsBayar.Tables[0].Rows)
				{
					Printer.Write(Strings.Left(ro["Description"] + Strings.Space(20), 20));
					Printer.CurrentX = 1800;
					Printer.Write(": Rp. ");
					CetakKanan((System.Convert.ToDecimal(ro["nilai"])).ToString("N0") + "    ");
					//        Printer.Print Left(RsBayar!Description & Space(20), 20) & "   : Rp. " & Kanan(14, RsBayar!nilai)
					Jumlah = System.Convert.ToInt64(Jumlah + System.Convert.ToInt32(ro["nilai"]));
				}
				
				
				Printer.Print(Module1.VGaris);
				Printer.Write("TOTAL");
				Printer.CurrentX = 1800;
				Printer.Write(": Rp. ");
				CetakKanan((Jumlah).ToString("N0") + "    ");
				Printer.Write("OVER VOUCHER");
				Printer.CurrentX = 1800;
				Printer.Write(": Rp. ");
				CetakKanan((System.Convert.ToDecimal(Jumlah - Jual)).ToString("N0") + "    ");
				Printer.Print(Module1.VGaris);
				Printer.Write("X Reading");
				Printer.CurrentX = 1800;
				Printer.Write(": Rp. ");
				CetakKanan((Jual).ToString("N0") + "    ");
				Printer.Print("");
				Printer.Write("DISCOUNT");
				Printer.CurrentX = 1800;
				Printer.Write(": Rp. ");
				CetakKanan((diskon).ToString("N0") + "    ");
				Printer.Write("RETURN");
				Printer.CurrentX = 1800;
				Printer.Write(": Rp. ");
				CetakKanan((Retur).ToString("N0") + "    ");
				Printer.Write("VOID");
				Printer.CurrentX = 1800;
				Printer.Write(": Rp. ");
				CetakKanan((Batal).ToString("N0") + "    ");
				
				Printer.Print("");
				Printer.Print("");
				Cetak.Printer.Print("");
				Printer.Print("");
				Printer.Print("");
				Cetak.Printer.Print("");
				Printer.EndDoc();
				//update table cash
				RsBayar.Clear();
				RsBayar = null;
			}
			
			
			Module1.getSqldb("update cash_register set shift='2' WHERE Branch_ID = '" + Module1.VBranch_ID +
				"' AND cash_register_id='" + Module1.VReg_ID + "'", Module1.ConnLocal);
			//If Linked() Then getSqldb("update cash_register set shift='2' WHERE Branch_ID = '" & VBranch_ID &
			//                  "' AND cash_register_id='" & VReg_ID & "'", ConnServer)
			//tanpa cek PING
			if (Module1.VPing == "ONLINE")
			{
				Module1.getSqldb("update cash_register set shift='2' WHERE Branch_ID = '" + Module1.VBranch_ID +
					"' AND cash_register_id='" + Module1.VReg_ID + "'", Module1.ConnServer);
			}
			
		}
		private static string CetakKanan(string Tex1)
		{
			//----------------------Normal-------------------------
			Printer.CurrentX = Printer.ScaleWidth - Printer.TextWidth(Tex1) - 90;
			//----------------------POSIFLEX-----------------------
			//Printer.CurrentX = Printer.CurrentX = Printer.ScaleWidth - Printer.TextWidth(Tex1) - 270
			Printer.Print(Tex1);
			return Tex1;
		}
		public static void ZReset()
		{
			DataSet RsBayar = new DataSet();
			DataSet Rs = new DataSet();
			byte x = 0;
			long Jual = 0;
			long diskon = 0;
			long Retur = 0;
			long Batal = 0;
			long Modal = 0;
			long Jumlah = 0;
			
			OpenLaci((byte) 0);
			if (Convert.ToInt32(Module1.ReadIni("Printer", "X_ReadPrint")) == 1)
			{
				Rs = Module1.getSqldb("SELECT isnull(SUM(Net_amount),0) AS Nilai, isnull(SUM(Total_discount),0) AS Potong " +
					"FROM Sales_Transactions WHERE Status = '00' and substring(transaction_number, 9,8)='" +
					Strings.Format(Module1.GetSrvDate(), "ddMMyyyy") + "'  And substring(transaction_number, 5,3) = '" + Module1.VReg_ID + "'", Module1.ConnLocal);
				Jual = System.Convert.ToInt64(Rs.Tables[0].Rows[0]["nilai"]);
				diskon = System.Convert.ToInt64(Rs.Tables[0].Rows[0]["potong"]);
				Rs.Clear();
				
				Rs = Module1.getSqldb("SELECT isnull(SUM(Net_amount),0) AS Balik " +
					"FROM Sales_Transactions WHERE Flag_Return  = '1' and substring(transaction_number, 9,8)='" +
					Strings.Format(Module1.GetSrvDate(), "ddMMyyyy") + "'  And substring(transaction_number, 5,3) = '" + Module1.VReg_ID + "'", Module1.ConnLocal);
				Retur = System.Convert.ToInt64(Rs.Tables[0].Rows[0]["balik"]);
				Rs.Clear();
				
				Rs = Module1.getSqldb("SELECT isnull(SUM(Net_Price),0) AS Nilai " +
					"FROM Sales_Transaction_Details WHERE substring(transaction_number, 9,8)='" +
					Strings.Format(Module1.GetSrvDate(), "ddMMyyyy") + "' and flag_void='1'  And substring(transaction_number, 5,3) = '" + Module1.VReg_ID + "' ", Module1.ConnLocal);
				Batal = System.Convert.ToInt64(Rs.Tables[0].Rows[0]["nilai"]);
				Rs.Clear();
				
				Rs = Module1.getSqldb("SELECT sum(Modal) as modal From Cash WHERE (Branch_ID = '" + Module1.VBranch_ID + "') AND (Datetime = '" + System.Convert.ToString(
					Module1.GetSrvDate().Date) + "')  And Cash_Register_ID = '" + Module1.VReg_ID + "'", Module1.ConnLocal);
				if (Rs.Tables[0].Rows.Count > 0)
				{
					Modal = System.Convert.ToInt64(Rs.Tables[0].Rows[0]["Modal"]);
				}
				else
				{
					Modal = 0;
				}
				Rs.Clear();
				Rs = null;
				
				RsBayar = Module1.getSqldb("SELECT Payment_Types.Description, SUM(Paid.Paid_Amount) AS Nilai " +
					"FROM Paid INNER JOIN Payment_Types ON Paid.Payment_Types = Payment_Types.Payment_Types " +
					"WHERE substring(transaction_number, 9,8)='" + Strings.Format(Module1.GetSrvDate(), "ddMMyyyy") +
					"'  And substring(transaction_number, 5,3) = '" + Module1.VReg_ID + "' GROUP BY Payment_Types.seq, Payment_Types.Description order by Payment_Types.seq", Module1.ConnLocal);
				
				for (x = 1; x <= 1; x++)
				{
					Jumlah = 0;
					Printer.FontSize = 8;
					Printer.Write("Z-Reset Shift");
					Printer.CurrentX = 1500;
					Printer.Print(": " + System.Convert.ToString(Module1.VShift) + " " + frmMain.Default.lblline.Text);
					Printer.Write("BRANCH");
					Printer.CurrentX = 1500;
					Printer.Print(": " + Module1.Tulis[10]);
					Printer.Write("REGISTER");
					Printer.CurrentX = 1500;
					Printer.Print(": " + Module1.VReg_ID);
					Printer.Write("CASHIER");
					Printer.CurrentX = 1500;
					Printer.Print(": " + Module1.VKasir_ID + "/" + Module1.VKasir_Nm);
					Printer.Write("TIME");
					Printer.CurrentX = 1500;
					Printer.Print(": " + Strings.Format(DateTime.Now, "dd/MMM/yyyy hh:mm:ss"));
					Printer.Print(Module1.VGaris);
					Printer.Write("MODAL");
					Printer.CurrentX = 1800;
					Printer.Print(": Rp. ");
					CetakKanan((Modal).ToString("N0") + "    ");
					
					if (RsBayar.Tables[0].Rows.Count > 0)
					{
						foreach (DataRow ro in RsBayar.Tables[0].Rows)
						{
							Printer.Write(Strings.Left(ro["Description"] + Strings.Space(20), 20));
							Printer.CurrentX = 1800;
							Printer.Write(": Rp. ");
							CetakKanan((System.Convert.ToDecimal(ro["nilai"])).ToString("N0") + "    ");
							//        Printer.Print Left(RsBayar!Description & Space(20), 20) & "   : Rp. " & Kanan(14, RsBayar!nilai)
							Jumlah = System.Convert.ToInt64(Jumlah + System.Convert.ToInt32(ro["nilai"]));
						}
					}
					
					
					
					Printer.Print(Module1.VGaris);
					Printer.Write("TOTAL");
					Printer.CurrentX = 1800;
					Printer.Write(": Rp. ");
					CetakKanan((Jumlah).ToString("N0") + "    ");
					Printer.Write("OVER VOUCHER");
					Printer.CurrentX = 1800;
					Printer.Write(": Rp. ");
					CetakKanan((System.Convert.ToDecimal(Jumlah - Jual)).ToString("N0") + "    ");
					Printer.Print(Module1.VGaris);
					Printer.Write("Z Reset");
					Printer.CurrentX = 1800;
					Printer.Write(": Rp. ");
					CetakKanan((Jual).ToString("N0") + "    ");
					Printer.Print("");
					Printer.Write("DISCOUNT");
					Printer.CurrentX = 1800;
					Printer.Write(": Rp. ");
					CetakKanan((diskon).ToString("N0") + "    ");
					Printer.Write("RETURN");
					Printer.CurrentX = 1800;
					Printer.Write(": Rp. ");
					CetakKanan((Retur).ToString("N0") + "    ");
					Printer.Write("VOID");
					Printer.CurrentX = 1800;
					Printer.Write(": Rp. ");
					CetakKanan((Batal).ToString("N0") + "    ");
					
					
					Printer.Print("");
					Printer.Print("");
					Cetak.Printer.Print("");
					Printer.Print("");
					Printer.Print("");
					Cetak.Printer.Print("");
					Printer.EndDoc();
					
				}
				RsBayar.Clear();
				RsBayar = null;
			}
			
			try
			{
				Module1.getSqldb("exec spp_ZresetLocal '" + Module1.VBranch_ID + "', '" + Module1.VReg_ID + "', '" + System.Convert.ToString(Module1.GetSrvDate().Date) + "'", Module1.ConnLocal);
				Module1.getSqldb("exec spp_ZresetServer '" + Module1.VBranch_ID + "', '" + Module1.VReg_ID + "', '" + System.Convert.ToString(Module1.GetSrvDate().Date) + "',''", Module1.ConnLocal);
				Module1.getSqldb("exec spp_DeleteTrans '" + Module1.VReg_ID + "'", Module1.ConnLocal);
				
				//If Linked() Then getSqldb("exec spp_ZresetServer '" & VBranch_ID & "', '" & VReg_ID & "', '" & Now().Date & "',''", ConnServer)
				
				//tanpa cek PING
				if (Module1.VPing == "ONLINE")
				{
					Module1.getSqldb("exec spp_ZresetServer '" + Module1.VBranch_ID + "', '" + Module1.VReg_ID + "', '" + System.Convert.ToString(Module1.GetSrvDate().Date) + "',''", Module1.ConnServer);
				}
			}
			catch (Exception)
			{
				Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) Constants.vbCritical + Constants.vbOKOnly, "Oops..");
				Module1.SaveLog("Zreset " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			
			
		}
		
		public static void ZResetbackdate()
		{
			DataSet RsBayar = new DataSet();
			DataSet Rs = new DataSet();
			byte x = 0;
			long Jual = 0;
			long diskon = 0;
			long Retur = 0;
			long Batal = 0;
			long Modal = 0;
			long Jumlah = 0;
			
			OpenLaci((byte) 0);
			if (Convert.ToInt32(Module1.ReadIni("Printer", "X_ReadPrint")) == 1)
			{
				Rs = Module1.getSqldb("SELECT isnull(SUM(Net_amount),0) AS Nilai, isnull(SUM(Total_discount),0) AS Potong " +
					"FROM Sales_Transactions_backup WHERE Status = '00' and substring(transaction_number, 9,8)='" +
					Strings.Format(Module1.GetSrvDate().AddDays(-1), "ddMMyyyy") + "'  And substring(transaction_number, 5,3) = '" + Module1.VReg_ID + "'", Module1.ConnLocal);
				Jual = System.Convert.ToInt64(Rs.Tables[0].Rows[0]["nilai"]);
				diskon = System.Convert.ToInt64(Rs.Tables[0].Rows[0]["potong"]);
				Rs.Clear();
				
				Rs = Module1.getSqldb("SELECT isnull(SUM(Net_amount),0) AS Balik " +
					"FROM Sales_Transactions_backup WHERE Flag_Return  = '1' and substring(transaction_number, 9,8)='" +
					Strings.Format(Module1.GetSrvDate().AddDays(-1), "ddMMyyyy") + "'  And substring(transaction_number, 5,3) = '" + Module1.VReg_ID + "'", Module1.ConnLocal);
				Retur = System.Convert.ToInt64(Rs.Tables[0].Rows[0]["balik"]);
				Rs.Clear();
				
				Rs = Module1.getSqldb("SELECT isnull(SUM(Net_Price),0) AS Nilai " +
					"FROM Sales_Transaction_Details_backup WHERE substring(transaction_number, 9,8)='" +
					Strings.Format(Module1.GetSrvDate().AddDays(-1), "ddMMyyyy") + "' and flag_void='1'  And substring(transaction_number, 5,3) = '" + Module1.VReg_ID + "' ", Module1.ConnLocal);
				Batal = System.Convert.ToInt64(Rs.Tables[0].Rows[0]["nilai"]);
				Rs.Clear();
				
				Rs = Module1.getSqldb("SELECT sum(Modal) as modal From Cash_backup WHERE (Branch_ID = '" + Module1.VBranch_ID + "') AND (Datetime = '" + System.Convert.ToString(
					Module1.GetSrvDate().Date.AddDays(-1)) + "')  And Cash_Register_ID = '" + Module1.VReg_ID + "'", Module1.ConnLocal);
				if (Rs.Tables[0].Rows.Count > 0)
				{
					Modal = System.Convert.ToInt64(Rs.Tables[0].Rows[0]["Modal"]);
				}
				else
				{
					Modal = 0;
				}
				Rs.Clear();
				Rs = null;
				
				RsBayar = Module1.getSqldb("SELECT Payment_Types.Description, SUM(Paid_backup.Paid_Amount) AS Nilai " +
					"FROM Paid_backup INNER JOIN Payment_Types ON Paid_backup.Payment_Types = Payment_Types.Payment_Types " +
					"WHERE substring(transaction_number, 9,8)='" + Strings.Format(Module1.GetSrvDate().AddDays(-1), "ddMMyyyy") +
					"'  And substring(transaction_number, 5,3) = '" + Module1.VReg_ID + "' GROUP BY Payment_Types.seq, Payment_Types.Description order by Payment_Types.seq", Module1.ConnLocal);
				
				for (x = 1; x <= 1; x++)
				{
					Jumlah = 0;
					Printer.FontSize = 8;
					Printer.Write("Z-Reset Shift");
					Printer.CurrentX = 1500;
					Printer.Print(": " + System.Convert.ToString(Module1.VShift) + " " + frmMain.Default.lblline.Text);
					Printer.Write("BRANCH");
					Printer.CurrentX = 1500;
					Printer.Print(": " + Module1.Tulis[10]);
					Printer.Write("REGISTER");
					Printer.CurrentX = 1500;
					Printer.Print(": " + Module1.VReg_ID);
					Printer.Write("CASHIER");
					Printer.CurrentX = 1500;
					Printer.Print(": " + Module1.VKasir_ID + "/" + Module1.VKasir_Nm);
					Printer.Write("TIME");
					Printer.CurrentX = 1500;
					Printer.Print(": " + Strings.Format(DateTime.Now.AddDays(-1), "dd/MMM/yyyy hh:mm:ss"));
					Printer.Print(Module1.VGaris);
					Printer.Write("MODAL");
					Printer.CurrentX = 1800;
					Printer.Print(": Rp. ");
					CetakKanan((Modal).ToString("N0") + "    ");
					
					if (RsBayar.Tables[0].Rows.Count > 0)
					{
						foreach (DataRow ro in RsBayar.Tables[0].Rows)
						{
							Printer.Write(Strings.Left(ro["Description"] + Strings.Space(20), 20));
							Printer.CurrentX = 1800;
							Printer.Write(": Rp. ");
							CetakKanan((System.Convert.ToDecimal(ro["nilai"])).ToString("N0") + "    ");
							//        Printer.Print Left(RsBayar!Description & Space(20), 20) & "   : Rp. " & Kanan(14, RsBayar!nilai)
							Jumlah = System.Convert.ToInt64(Jumlah + System.Convert.ToInt32(ro["nilai"]));
						}
					}
					
					
					
					Printer.Print(Module1.VGaris);
					Printer.Write("TOTAL");
					Printer.CurrentX = 1800;
					Printer.Write(": Rp. ");
					CetakKanan((Jumlah).ToString("N0") + "    ");
					Printer.Write("OVER VOUCHER");
					Printer.CurrentX = 1800;
					Printer.Write(": Rp. ");
					CetakKanan((System.Convert.ToDecimal(Jumlah - Jual)).ToString("N0") + "    ");
					Printer.Print(Module1.VGaris);
					Printer.Write("Z Reset");
					Printer.CurrentX = 1800;
					Printer.Write(": Rp. ");
					CetakKanan((Jual).ToString("N0") + "    ");
					Printer.Print("");
					Printer.Write("DISCOUNT");
					Printer.CurrentX = 1800;
					Printer.Write(": Rp. ");
					CetakKanan((diskon).ToString("N0") + "    ");
					Printer.Write("RETURN");
					Printer.CurrentX = 1800;
					Printer.Write(": Rp. ");
					CetakKanan((Retur).ToString("N0") + "    ");
					Printer.Write("VOID");
					Printer.CurrentX = 1800;
					Printer.Write(": Rp. ");
					CetakKanan((Batal).ToString("N0") + "    ");
					
					
					Printer.Print("");
					Printer.Print("");
					Cetak.Printer.Print("");
					Printer.Print("");
					Printer.Print("");
					Cetak.Printer.Print("");
					Printer.EndDoc();
					
				}
				RsBayar.Clear();
				RsBayar = null;
			}
			
			
			
		}
		
		public static void CDisplay(string Tex1, string Tex2)
		{
			string[] str = Module1.CDSet.Split(',');
			SerialPort sp = new SerialPort("COM" + Module1.CDCom, System.Convert.ToInt32(str[0]), (str[1] == "o") ? Parity.Odd : Parity.None, int.Parse(str[2]), (str[3] == "1") ? StopBits.One : StopBits.None);
			if (string.IsNullOrEmpty(Module1.CDCom))
			{
				return;
			}
			switch (Module1.CD_Type)
			{
				case "0":
					Tex1 = Strings.Space(System.Convert.ToInt32((double) (20 - Tex1.Length ) / 2)) + Tex1;
					Tex2 = Strings.Space(System.Convert.ToInt32((double) (20 - Tex2.Length ) / 2)) + Tex2;
					sp.Open();
					sp.Write((char) 27 + "[2J"); //bersihkan display
					sp.WriteLine((char) 27 + '[' + System.Convert.ToString(Strings.Chr(0x31 + 0)) + ';' + System.Convert.ToString(Strings.Chr(0x31 + 0)) + 'H' + Tex1);
					sp.WriteLine((char) 27 + '[' + System.Convert.ToString(Strings.Chr(0x31 + 1)) + ';' + System.Convert.ToString(Strings.Chr(0x31 + 0)) + 'H' + Tex2);
					sp.Close();
					sp.Dispose();
					break;
				case "1":
					sp.Open();
					//to clear the display
					sp.Write(Convert.ToString('\f'));
					//first line goes here
					sp.WriteLine((char) 27 + System.Convert.ToString((char) 81) + Tex1 + " " + Tex2);
					//2nd line goes here
					//sp.WriteLine(Chr(27) & Chr(81) & Tex2)
					sp.Close();
					sp.Dispose();
					break;
			}
		}
		
		//Public Sub CDisplay(Tex1 As String, Tex2 As String)
		
		//    ' Send strings to a serial port.
		//    Using com1 As IO.Ports.SerialPort =
		//        My.Computer.Ports.OpenSerialPort("COM2", 9600, Parity.None, 8, StopBits.One)
		//        com1.Write(Convert.ToString(Chr(27)) & "[2J")
		//    End Using
		
		//End Sub
		
		//Public Sub CDisplay(ByRef Tex1 As String, ByRef Tex2 As String)
		//    ''''''untuk .Net
		//    If CDCom = "" Then Exit Sub
		//    'Dim sp As New SerialPort("COM" & CDCom, Str(0), IIf(Str(1) = "o", Parity.Odd, Parity.None), CInt(Str(2)), IIf(Str(3) = "1", StopBits.One, StopBits.None))
		//    Dim sp As New SerialPort("COM" & CDCom, 9600, Parity.None, 8, StopBits.One)
		//    sp.Open()
		//    'to clear the display
		//    sp.Write(Convert.ToString(Chr(12)))
		//    'first line goes here
		//    sp.WriteLine(Chr(27) & Chr(81) & Tex1 & " " & Tex2)
		//    '2nd line goes here
		//    'sp.WriteLine(Chr(27) & Chr(81) & Tex2)
		//    sp.Close()
		//    sp.Dispose()
		//End Sub
		
		
		
		
		
		public static void OpenLaci(byte tipe)
		{
			Open_OPOS_Drawer();
			if (tipe == 1)
			{
				Printer.Write("CASHIER");
				Printer.CurrentX = 1000;
				Printer.Print(": " + System.Convert.ToString(Module1.VShift) + " - " + Module1.VKasir_ID + "/" + Module1.VKasir_Nm);
				Printer.Write("TIME");
				Printer.CurrentX = 1000;
				Printer.Print(": " + Strings.Format(DateTime.Now, "dd/MMM/yyyy hh:mm:ss"));
				Printer.Write("OPEN DRAWER");
				Printer.Print("");
				Printer.Print("");
				Cetak.Printer.Print("");
				Printer.Print("");
				Printer.Print("");
				Cetak.Printer.Print("");
				Printer.EndDoc();
			}
		}
		private static void Open_OPOS_Drawer()
		{
			PrintDocument printDoc = new PrintDocument();
			//Modify DrawerCode to your receipt printer open drawer code
			string DrawerCode = (char) 27 + System.Convert.ToString((char) 112) + System.Convert.ToString((char) 48) + System.Convert.ToString((char) 64) + System.Convert.ToString((char) 64);
			//Modify PrinterName to your receipt printer name
			string PrinterName = printDoc.PrinterSettings.DefaultPageSettings.PrinterSettings.PrinterName.ToString();
			RawPrinter.PrintRaw(PrinterName, DrawerCode);
		}
		public static void CetakData()
		{
			Printer Printer = new Printer();
			Printer.FontName = "Printer 17cpi";
			Printer.FontSize = 9;
			Printer.Print("-------------------------------------------------------------------");
			Printer.Write("Card Number");
			Printer.CurrentX = 1500;
			Printer.Print(": " + Module1.Star_No);
			Printer.Write("Name");
			Printer.CurrentX = 1500;
			Printer.Print(": " + Module1.Star_Nm);
			Printer.Print("-------------------------------------------------------------------");
			Printer.Write("Phone Number");
			Printer.CurrentX = 1500;
			Printer.Print(": " + Module1.Star_Phone.Trim());
			Printer.Write("Email");
			Printer.CurrentX = 1500;
			Printer.Print(": " + Module1.Star_Email.Trim());
			Printer.Print("-------------------------------------------------------------------");
			Printer.Write("New Phone");
			Printer.CurrentX = 1500;
			Printer.Print(": ");
			Printer.Write("New Email");
			Printer.CurrentX = 1500;
			Printer.Print(": ");
			Printer.Print("-------------------------------------------------------------------");
			Printer.EndDoc();
		}
		
		public static void CetakStruk(string Status, string No_trans)
		{
			try
			{
				int vqty = 0;
				int vtotal = 0;
				int Vsave = 0;
				string abc = "";
				DataSet Rst = new DataSet();
				DataSet Rsh = new DataSet();
				byte AdaCash = 0;
				DataSet RsX = new DataSet();
				
				//cek cash terakhir
				RsX = Module1.getSqldb("SELECT TOP (1) Seq From Paid " + "WHERE (Transaction_Number = '" + No_trans + "') AND (Payment_Types = '1') " + "ORDER BY Seq DESC", Module1.ConnLocal);
				
				if (RsX.Tables[0].Rows.Count > 0)
				{
					AdaCash = System.Convert.ToByte(RsX.Tables[0].Rows[0]["Seq"]);
				}
				else
				{
					AdaCash = (byte) 0;
				}
				RsX.Clear();
				RsX = null;
				
				Rsh = Module1.getSqldb("select card_number, transaction_date, transaction_time, change_amount, Point_Of_Card_Program, pd.seq as urut, pd.*, pt.* from sales_transactions st inner join paid pd on " + "st.transaction_number = pd.transaction_number inner join payment_types pt on pd.payment_types " + "= pt.payment_types where st.transaction_number='" + No_trans + "' order by pd.seq", Module1.ConnLocal);
				if (Rsh.Tables[0].Rows.Count == 0)
				{
					MessageBox.Show("This transaction has a problem, please contact IT !!");
					return;
				}
				Printer.FontName = "Printer 17cpi";
				Printer.FontSize = 10;
				
				
				if (double.Parse(Module1.ReadIni("Printer", "Use_Logo")) == 0)
				{
					CetakTengah("LAKON");
				}
				else
				{
					//CetakTengah("DEPARTMENT STORE")
				}
				
				Printer.FontSize = 9;
				CetakTengah(Module1.Tulis[10]);
				Printer.FontName = "Printer 17cpi";
				Printer.FontSize = 9;
				Printer.Print("");
				Printer.Print("No. " + No_trans);
				Printer.Print(Module1.VShift + "-" + Module1.VKasir_ID + "/" + Module1.VKasir_Nm.Trim().Substring(0, 14) + "     " + Strings.Format(Rsh.Tables[0].Rows[0]["Transaction_Date"], "dd/MM/yyyy") + " " + Rsh.Tables[0].Rows[0]["Transaction_Time"]);
				Printer.Print("");
				
				if (Status != "SALES")
				{
					
					switch (Status)
					{
						case "REFUND":
							Printer.FontSize = 9;
							CetakTengah("REFUND TRANSACTION");
							break;
						case "REPRINT":
							Printer.FontSize = 9;
							CetakTengah("R E P R I N T");
							break;
					}
					Printer.Print("");
				}
				
				Rst = Module1.getSqldb("select Seq, sd.PLU, Item_Description, Price, Qty, Discount_Percentage, Discount_Amount, " + "ExtraDisc_Pct, ExtraDisc_Amt, net_price, brand from sales_transaction_details sd inner join item_master im " + "on sd.plu=im.plu where transaction_number='" + No_trans + "' order by seq", Module1.ConnLocal);
				Printer.FontSize = 8;
				if (Rst.Tables[0].Rows.Count > 0)
				{
					foreach (DataRow ro in Rst.Tables[0].Rows)
					{
						Printer.Print((Strings.Trim(System.Convert.ToString(ro["plu"])) + " " + Strings.Trim(System.Convert.ToString(ro["item_description"]))).Substring(0, 42));
						abc = System.Convert.ToString("  " + (System.Convert.ToDecimal(ro["Qty"])).ToString("N0") + "x" + (System.Convert.ToDecimal(ro["price"])).ToString("N0") + " " + System.Convert.ToString(((string) ro["Brand"] == "No Brand") ? " " : (ro["Brand"])));
						abc = abc.Substring(0, 30);
						
						Printer.Write(abc);
						//---------------------Normal----------------
						CetakKanan(System.Convert.ToString((System.Convert.ToDecimal(ro["Net_Price"])).ToString("N0")));
						//---------------------POSIFLEX----------------
						//CetakKonon (Format(Rst!Net_Price, "#,##0"))
						if ((int) ro["Discount_Percentage"] != 0)
						{
							Printer.Print("  Disc. " + (System.Convert.ToDecimal(ro["Discount_Percentage"])).ToString("N0") + "% = " + (System.Convert.ToDecimal(ro["Discount_Amount"])).ToString("N0"));
						}
						
						if ((int) ro["ExtraDisc_pct"] != 0)
						{
							Printer.Print("  Extra " + (System.Convert.ToDecimal(ro["ExtraDisc_pct"])).ToString("N0") + "% = " + (System.Convert.ToDecimal(ro["ExtraDisc_amt"])).ToString("N0"));
						}
						
						vqty = vqty + System.Convert.ToInt32(System.Convert.ToInt32( ro["Qty"]));
						vtotal = vtotal + System.Convert.ToInt32(ro["Net_Price"]);
						Vsave = Vsave + System.Convert.ToInt32(ro["Discount_Amount"]) + System.Convert.ToInt32(ro["ExtraDisc_amt"]);
					}
				}
				Printer.Print("");
				Printer.Write("Total   " + ("   " + System.Convert.ToString(vqty)).Substring(("   " + System.Convert.ToString(vqty)).Length - 4, 4) + " item(s)   ");
				//--------------Normal------------------------
				Printer.CurrentX = 2000;
				Printer.Write("  : Rp. ");
				//--------------POSIFLEX----------------------
				//Printer.CurrentX = 1800: Printer.Print "  : Rp. ";
				CetakKanan(Kanan((byte) 14, vtotal));
				Printer.Print("");
				
				Printer.FontSize = 9;
				if (Rsh.Tables[0].Rows.Count > 0)
				{
					foreach (DataRow ro in Rsh.Tables[0].Rows)
					{
						if (Strings.Trim(System.Convert.ToString(ro["credit_card_no"])) != "")
						{
							Turun();
							//If Len(Trim(ro("credit_card_no"))) = 16 Then
							//    Printer.Print(Left(ro("credit_card_no"), 7) & "XXXXXXXXX")
							//Else
							//    Printer.Print(Left(ro("credit_card_no"), 20))
							//End If
							if (Strings.Trim(System.Convert.ToString(ro["credit_card_no"])).Length >= 14)
							{
								if (Convert.ToInt32(Module1.isECR) == 1)
								{
									Printer.Print(Strings.Left(System.Convert.ToString(ro["credit_card_no"]), 16));
								}
								else
								{
									Printer.Print(Strings.Left(System.Convert.ToString(ro["credit_card_no"]), 4) + "******" + Strings.Mid(System.Convert.ToString(ro["credit_card_no"]), 12, 6));
								}
								
							}
							else
							{
								Printer.Print(Strings.Left(System.Convert.ToString(ro["credit_card_no"]), 20));
							}
							if (Strings.Trim(System.Convert.ToString(ro["credit_card_name"])) != "")
							{
								Printer.Print(Strings.Left(System.Convert.ToString(ro["credit_card_name"]), 40));
							}
						}
						
						abc = Strings.Left(ro["Description"] + Strings.Space(22), 22);
						if (System.Convert.ToInt32(ro["Payment_Types"]) > 30)
						{
							abc = Strings.Left(ro["credit_card_name"] + Strings.Space(24), 24);
						}
						
						Turun();
						if (Strings.Trim(System.Convert.ToString(ro["Description"])) == "CASH")
						{
							Printer.Write("CASH");
							//--------------Normal------------------------
							Printer.CurrentX = 2000;
							Printer.Write("  : Rp. ");
							//--------------POSIFLEX----------------------
							//Printer.CurrentX = 1800: Printer.Print "  : Rp. ";
							if (Convert.ToInt32(ro["urut"]) == AdaCash)
							{
								CetakKanan(System.Convert.ToString((System.Convert.ToDecimal(System.Convert.ToDouble(ro["paid_amount"]) + System.Convert.ToDouble(ro["Change_Amount"]))).ToString("N0")));
							}
							else
							{
								CetakKanan(System.Convert.ToString((System.Convert.ToDecimal(ro["paid_amount"])).ToString("N0")));
							}
						}
						else
						{
							Printer.Write(abc);
							//--------------Normal------------------------
							Printer.CurrentX = 2000;
							Printer.Write("  : Rp. ");
							//--------------POSIFLEX----------------------
							//Printer.CurrentX = 1800: Printer.Print "  : Rp. ";
							CetakKanan(System.Convert.ToString((System.Convert.ToDecimal(ro["paid_amount"])).ToString("N0")));
						}
					}
				}
				
				Turun();
				if (Status == "REFUND")
				{
					if (Convert.ToInt32(Rsh.Tables[0].Rows[0]["Change_Amount"]) < 0)
					{
						Printer.Write("CHANGE");
						Printer.CurrentX = 2000;
						Printer.Print("  : Rp. ");
						CetakKanan(System.Convert.ToString((System.Convert.ToDecimal(Rsh.Tables[0].Rows[0]["Change_Amount"])).ToString("N0")));
					}
				}
				else
				{
					if (Convert.ToInt32(Rsh.Tables[0].Rows[0]["Change_Amount"]) > 0)
					{
						Printer.Write("CHANGE");
						//--------------Normal------------------------
						Printer.CurrentX = 2000;
						Printer.Write("  : Rp. ");
						//--------------POSIFLEX----------------------
						//Printer.CurrentX = 1800: Printer.Print "  : Rp. ";
						CetakKanan(System.Convert.ToString((System.Convert.ToDecimal(Rsh.Tables[0].Rows[0]["Change_Amount"])).ToString("N0")));
					}
				}
				
				Printer.Print("");
				
				if (Vsave > 0)
				{
					Printer.Write("YOU SAVE");
					//--------------Normal------------------------
					Printer.CurrentX = 2000;
					Printer.Write("  : Rp. ");
					//--------------POSIFLEX----------------------
					//Printer.CurrentX = 1800: Printer.Print "  : Rp. ";
					CetakKanan(System.Convert.ToString((Vsave).ToString("N0")));
					Printer.Print("");
				}
				
				if (Strings.Trim(System.Convert.ToString(Rsh.Tables[0].Rows[0]["card_number"])) != "LM-00000000")
				{
					Point.MySTAR(System.Convert.ToString(Rsh.Tables[0].Rows[0]["card_number"]));
					//Card_No_StrukTambahan = Rsh!card_number
					//Printer.Write("No MySTAR Card")
					//Printer.CurrentX = 1500 : Printer.Print(": " & Rsh.Tables(0).Rows(0).Item("card_number"))
					//Turun()
					Printer.Write("Customer Name");
					Printer.CurrentX = 1500;
					Printer.Print(": " + Module1.Star_Nm.Substring(0, 22));
					Printer.Print("");
					Turun();
					//Printer.Write("Issued Point")
					//Printer.CurrentX = 1500 : Printer.Print(": " & Get_Point(No_trans))
					//Turun()
					//If Linked() And Status <> "REPRINT" Then
					//    Printer.Write("Point Balance")
					//    Printer.CurrentX = 1500 : Printer.Print(": " & Star_Pt)
					//End If
					
					//tanpa cek PING
					//If VPing = "ONLINE" And Status <> "REPRINT" Then
					//Printer.Write("Point Balance")
					//Printer.CurrentX = 1500 : Printer.Print(": " & Star_Pt)
					//End If
					//Printer.Print("")
					//CetakTengah ("Tingkatkan belanja & gunakan kartu MSC")
					//CetakTengah ("Untuk memenangkan top spender")
					//Printer.Print ""
				}
				else
				{
					//Card_No_StrukTambahan = "CM000-00000"
					//CetakTengah ("Not Yet A MySTAR Card member?")
					//CetakTengah ("Register Now and get more benefit")
					//Printer.Print ""
				}
				
				Printer.FontSize = 9;
				CetakTengah(Module1.Tulis[11]);
				CetakTengah(Module1.Tulis[12]);
				CetakTengah(Module1.Tulis[13] + ", " + Module1.Tulis[14]);
				CetakTengah("NPWP/PKP No : " + Module1.Tulis[9]);
				CetakTengah("Harga sudah termasuk pajak");
				Printer.Print("");
				CetakTengah(Module1.Tulis[7]);
				//CetakTengah(Tulis(8))
				Printer.Print("");
				CetakTengah(Module1.Tulis[3]);
				CetakTengah(Module1.Tulis[4]);
				CetakTengah(Module1.Tulis[5]);
				Printer.Print("");
				CetakTengah("Facebook / Twitter lakonstore");
				CetakTengah("Customer care : 0878 7612 0185 ");
				
				if (Module1.Tulis[1] != "")
				{
					Printer.Print("");
					CetakTengah(Module1.VGaris);
					CetakTengah(Module1.Tulis[1]);
					CetakTengah(Module1.Tulis[2]);
					CetakTengah(Module1.VGaris);
				}
				
				if (double.Parse(Module1.ReadIni("Printer", "Use_Barcode")) == 2)
				{
					Printer.Print("");
					Printer.FontName = "IDAutomationHC39M";
					//Printer.CurrentX = (Printer.ScaleWidth - Printer.TextWidth(No_trans)) \ 2
					Printer.Print("*" + No_trans + "*");
				}
				Printer.FontName = "Printer 17cpi";
				Printer.EndDoc();
				Rst.Clear();
				Rsh.Clear();
				Module1.SaveLog("Cetak Struk Success!! " + No_trans + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			catch (Exception)
			{
				Module1.SaveLog("Cetak Struk Gagal !! " + No_trans + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			
			
		}
		private static string CetakTengah(string Tex1)
		{
			Printer.CurrentX = System.Convert.ToSingle((Printer.ScaleWidth - Printer.TextWidth(Tex1)) / 2);
			Printer.Print(Tex1);
			return Tex1;
		}
		private static void Turun()
		{
			Printer Printer = new Printer();
			Printer.CurrentY = Printer.CurrentY + 60;
		}
		private static string Kanan(byte geser, int rupiah)
		{
			return Strings.Space(geser - Strings.Len((rupiah).ToString("N0"))) + (rupiah).ToString("N0");
		}
		public static void CetakPesan(string Status, string No_trans)
		{
			Printer Printer = new Printer();
			//Printer.Print Tulis(11) 'nama pt
			Printer.Print(Module1.Tulis[10]);
			Printer.Write("TRANS#");
			Printer.CurrentX = 800;
			Printer.Print(": " + No_trans);
			Printer.Write("CASHIER");
			Printer.CurrentX = 800;
			Printer.Print(": " + System.Convert.ToString(Module1.VShift) + " - " + Module1.VKasir_ID + "/" + Module1.VKasir_Nm);
			Printer.Write("TIME");
			Printer.CurrentX = 800;
			Printer.Print(": " + Strings.Format(DateTime.Now, "dd/MMM/yyyy hh:mm:ss"));
			switch (Status)
			{
				case "HOLD":
					Printer.Print("HOLD TRANSACTION");
					break;
				case "CANCEL":
					Printer.Print("CANCEL TRANSACTION");
					break;
			}
			Printer.Print("");
			Printer.Print("");
			Printer.Print("");
			Printer.Print("");
			Printer.Print("");
			Printer.Print("");
			Printer.EndDoc();
		}
		public static void CetakValid(string No_trans, string brs1, string brs2)
		{
			Printer Printer = new Printer();
			Printer.Write("TRANS#");
			Printer.CurrentX = 800;
			Printer.Print(": " + No_trans);
			Printer.Write("CASHIER");
			Printer.CurrentX = 800;
			Printer.Print(": " + System.Convert.ToString(Module1.VShift) + " - " + Module1.VKasir_ID + "/" + Module1.VKasir_Nm);
			Printer.Write("TIME");
			Printer.CurrentX = 800;
			Printer.Print(": " + Strings.Format(DateTime.Now, "dd/MMM/yyyy hh:mm:ss"));
			Printer.Print(brs1);
			Printer.Print(brs2);
			Printer.Print("");
			Printer.Print("");
			Printer.Print("");
			Printer.Print("");
			Printer.Print("");
			Printer.Print("");
			Printer.EndDoc();
		}
		public static void CetakStrukPayPoint(string Card_Nr, string Card_Name, string No_trans)
		{
			Printer Printer = new Printer();
			DataSet RsX = new DataSet();
			DataSet Rst = new DataSet();
			short AdaPayPoint = 0;
			short SisaPayPoint;
			//cek pembayaran point
			RsX = Module1.getSqldb("SELECT Sum(Paid_Amount) As Amount From Paid " + "WHERE (Transaction_Number = '" + No_trans + "') AND (Payment_Types = '5') " + "", Module1.ConnServer);
			
			if (RsX.Tables[0].Rows.Count > 0)
			{
				if (Information.IsDBNull(RsX.Tables[0].Rows[0]["Amount"]))
				{
					AdaPayPoint = (short) 0;
				}
				else
				{
					AdaPayPoint = System.Convert.ToInt16(Convert.ToInt32(RsX.Tables[0].Rows[0]["Amount"]) / double.Parse(Module1.VHargaPoint));
				}
			}
			else
			{
				AdaPayPoint = (short) 0;
			}
			
			RsX.Clear();
			RsX = null;
			
			if (AdaPayPoint == 0)
			{
				return;
			}
			
			RsX = Module1.getSqldb("select card_point from card where card_nr = '" + Card_Nr + "'", Module1.ConnServer);
			if (RsX.Tables[0].Rows.Count > 0)
			{
				SisaPayPoint = System.Convert.ToInt16(RsX.Tables[0].Rows[0]["card_point"]);
			}
			else
			{
				SisaPayPoint = (short) 0;
			}
			if (double.Parse(Module1.ReadIni("Printer", "Use_Logo")) == 0)
			{
				CetakTengah("STAR DEPARTMENT STORE");
			}
			else
			{
				CetakTengah("DEPARTMENT STORE");
			}
			
			
			Turun();
			
			Printer.FontSize = 9;
			CetakTengah(Module1.Tulis[10]);
			
			//UPGRADE_WARNING: Only TrueType and OpenType fonts are supported in Windows Forms. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="971F4DF4-254E-44F4-861D-3AA0031FE361"'
			Printer.FontName = "Printer 17cpi";
			Printer.FontSize = 9;
			Turun();
			Printer.Print("");
			Printer.Print("POINT REWARD REDEMPTION");
			Turun();
			Printer.Write("No.");
			Printer.CurrentX = 1500;
			Printer.Print(": " + No_trans);
			Turun();
			Printer.Write("No MySTAR Card");
			Printer.CurrentX = 1500;
			Printer.Print(": " + Card_Nr);
			Turun();
			Printer.Write("Customer Name");
			Printer.CurrentX = 1500;
			Printer.Print(": " + Module1.Star_Nm.Substring(0, 22));
			Turun();
			Printer.Write("Claim Date");
			Printer.CurrentX = 1500;
			Printer.Print(": " + System.Convert.ToString(DateTime.Now));
			Turun();
			Printer.Print("-----------------------------------------------------");
			Turun();
			Printer.Write("Claim Point");
			Printer.CurrentX = 1500;
			Printer.Print(": " + System.Convert.ToString(AdaPayPoint));
			Turun();
			Printer.Write("Point Balance");
			Printer.CurrentX = 1500;
			Printer.Print(": " + System.Convert.ToString(Module1.Star_Pt));
			Printer.Print("");
			Printer.EndDoc();
			Rst.Clear();
		}
		public static void CetakStruk_Promo(string Nama, string No_trans, string Pesan)
		{
			Printer Printer = new Printer();
			if (double.Parse(Module1.ReadIni("Printer", "Use_Barcode")) == 1)
			{
				Printer.Print("");
				Printer.FontName = "IDAutomationHC39M";
				//Printer.CurrentX = (Printer.ScaleWidth - Printer.TextWidth(No_trans)) \ 2
				Printer.FontSize = 11;
				Printer.Print("*" + Nama.Substring(0, 3) + No_trans.Substring(3, 4) + No_trans.Substring(8, 4) + No_trans.Substring(14, 2) + No_trans.Substring(18, 3) + "*");
				Printer.FontSize = 8;
				//UPGRADE_WARNING: Only TrueType and OpenType fonts are supported in Windows Forms. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="971F4DF4-254E-44F4-861D-3AA0031FE361"'
				Printer.FontName = "Printer 17cpi";
				Printer.Print("");
			}
			else
			{
				Printer.Print(Module1.VGaris);
				Printer.Write("TRANS#");
				Printer.CurrentX = 800;
				Printer.Print(": " + No_trans);
				Printer.Write("CASHIER");
				Printer.CurrentX = 800;
				Printer.Print(": " + System.Convert.ToString(Module1.VShift) + " - " + Module1.VKasir_ID + "/" + Module1.VKasir_Nm);
				Printer.Write("TIME");
				Printer.CurrentX = 800;
				Printer.Print(": " + Strings.Format(DateTime.Now, "dd/MMM/yyyy hh:mm:ss"));
				Printer.Print(Module1.VGaris);
			}
			//Printer.Print "No MySTAR Card";
			//Printer.CurrentX = 1500: Printer.Print ": " & Card_No_StrukTambahan
			Printer.Print(Pesan);
			Printer.Print(Module1.VGaris);
			Printer.Print("");
			Printer.Print("");
			Printer.Print("");
			Printer.Print("");
			Printer.Print("");
			Printer.Print("");
			Printer.EndDoc();
		}
		
	}
	
}
