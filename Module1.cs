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

using System.Data.SqlClient;
using System.Xml;
using static System.Math;
using System.Text;
using System.IO;
using System.Net;
using System.Web.Script.Serialization;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using iPOS;

namespace iPOS
{
	sealed class Module1
	{
		public static SqlConnection m_con;
		public static string VSvr;
		public static string ConnServer;
		public static string ConnLocal;
		public static string VBranch_ID;
		public static string VReg_ID;
		public static string VReg_OL;
		public static string CDCom;
		public static string CDSet;
		public static string PPort;
		public static string Log_P;
		public static string TipKom;
		public static string VPing;
		public static string VHargaPoint;
		public static string StrSQL;
		public static string VKasir_ID;
		public static string VKasir_Nm;
		public static string VSuper_Nm;
		public static string Star_Nm;
		public static string Star_Id;
		public static string Star_Freq;
		public static string Star_Omz;
		public static string VGaris;
		public static string Star_No;
		public static string Star_Phone;
		public static string Star_Ext1;
		public static string Star_Email;
		public static string Exp_Point;
		public static string Expired_Date;
		public static string VNomor;
		public static string VKary;
		public static string RFIDType;
		public static string IPReader;
		public static string PortReader;
		public static string no_kartuECR;
		public static string PowerIndex;
		public static string CD_Type;
		public static string spg_btn;
		public static string[] KeyStroke = new string[122];
		public static bool VAda_Promo;
		public static bool VOK;
		public static bool VCopen;
		public static bool VIsSSC;
		public static bool VIsKKG;
		public static bool VTanya;
		public static bool LoadClose;
		public static bool FingerOK;
		public static bool GotoPayment;
		public static bool EODFirstForm;
		public static int VShift;
		public static int Star_Pt;
		public static int VDiscBySTAR;
		public static int isECR;
		public static int ECRComm;
		public static int RegType;
		public static int BagRFID;
		public static byte VBonus_Point;
		public static byte Star_updsts;
		public static string[] Tulis = new string[51];
		[DllImport("inpout32.dll",EntryPoint="Inp32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		public static extern int Inp(int PortAddress);
		//[DllImport("inpout32.dll",EntryPoint="Out32", ExactSpelling=true, CharSet=CharSet.Ansi, SetLastError=true)]
		//public static extern int) Out(int PortAddress, int Value);
		public static string conID = "192.168.1.116:9090";
		public static frmSalesSelf example = new frmSalesSelf();
		public static bool RFIDOKE;
		public static bool OneReadAll;
		public static bool NewMember;
		public static decimal vdiscrp1RFID;
		public static decimal vdiscrp2RFID;
		public static decimal vtotalRFID;
		public static decimal vgtotalRFID;
		public static int vqtyRFID;
		public static int lblqtyRFID;
		public static int lblgrand_totalRFID;
		public static int Antenna_No;
		public static int SecLev;
		public static string vno_transRFID;
		public static string txtcust_idRFID;
		public static string txtcard_noRFID;
		public static bool RFIDStatus;
		
		private const string INSTANCE_ID = "YOUR_INSTANCE_ID_HERE";
		private const string CLIENT_ID = "YOUR_CLIENT_ID_HERE";
		private const string CLIENT_SECRET = "YOUR_CLIENT_SECRET_HERE";
		private const string API_URL = "http://api.whatsmate.net/v3/whatsapp/single/text/message/" + INSTANCE_ID;
		
		public static void Main()
		{
			string RegSetting = "";
			
			RegSetting = System.Threading.Thread.CurrentThread.CurrentCulture.ToString();
			if (RegSetting != "en-US")
			{
				Interaction.MsgBox("Anda menggunakan Regional Setting " + RegSetting + "Anda harus mengganti Regional Setting menjadi English(United States)", (Microsoft.VisualBasic.MsgBoxStyle) 64, "Oops..");
				System.Diagnostics.Process.Start("intl.cpl");
				ProjectData.EndApp();
			}
			
			
			ConnServer = "Data Source=" + ReadIni("Server", "ServerName") + ";" +
				"Initial Catalog=" + ReadIni("Server", "DatabaseName") + ";" +
				"User ID=" + ReadIni("Server", "LoginId") + ";" +
				"Password=" + decrypt(ReadIni("Server", "Password")) + ";";
			
			ConnLocal = "Data Source=" + ReadIni("Local", "ServerName") + ";" +
				"Initial Catalog=" + ReadIni("Local", "DatabaseName") + ";" +
				"User ID=" + ReadIni("Local", "LoginId") + ";" +
				"Password=" + decrypt(ReadIni("Local", "Password")) + ";";
			
			VBranch_ID = ReadIni("RegisterInfo", "BranchID");
			VReg_ID = ReadIni("RegisterInfo", "RegID");
			VReg_OL = ReadIni("RegisterInfo", "RegOnline");
			VSvr = ReadIni("Server", "ServerName");
			
			CD_Type = ReadIni("Device", "CD_Type");
			CDCom = ReadIni("Device", "CD_Com");
			CDSet = ReadIni("Device", "CD_Set");
			PPort = ReadIni("Printer", "PrinterPort");
			Log_P = ReadIni("Device", "Log_Path");
			TipKom = ReadIni("Device", "Touch");
			IPReader = ReadIni("RFID", "IPReader");
			PortReader = ReadIni("RFID", "PortReader");
			Antenna_No = System.Convert.ToInt32(ReadIni("RFID", "Antenna_No"));
			RFIDType = ReadIni("RFID", "ReaderTipe");
			isECR = System.Convert.ToInt32(ReadIni("RFID", "ECRisAktiv"));
			ECRComm = System.Convert.ToInt32(ReadIni("RFID", "ECRComm"));
			PowerIndex = ReadIni("RFID", "PowerIndex");
			RegType = System.Convert.ToInt32(ReadIni("Device", "RegType"));
			//If RFIDType = "zebra" Then
			//    frmSales.CheckConZebra()
			//End If
			VPing = System.Convert.ToString(string.IsNullOrEmpty(VSvr) ? "OFFLINE" : "ONLINE");
			if (!string.IsNullOrEmpty(VBranch_ID)&& !string.IsNullOrEmpty(VReg_ID))
			{
				frmSplash.Default.Show();
			}
			else
			{
				Interaction.MsgBox("File konfigurasi belum lengkap", (int) Constants.vbCritical + Constants.vbOKOnly, "Oops..");
			}
		}
		public static bool Linked()
		{
			bool returnValue = false;
			try
			{
				if ((new Microsoft.VisualBasic.Devices.Computer()).Network.Ping(VSvr))
				{
					returnValue = true;
					VPing = "ONLINE";
				}
				else
				{
					returnValue = false;
					VPing = "OFFLINE";
				}
				if (RFIDType == "zebra")
				{
				}
				else
				{
					//frmSales.CheckCon()
				}
				
			}
			catch (Exception)
			{
				returnValue = false;
				VPing = "OFFLINE";
			}
			
			return returnValue;
		}
		
		public static DataSet getSqldb(string scmd, string Srv)
		{
			m_con = new SqlConnection(Srv);
			SqlDataAdapter da = new SqlDataAdapter();
			DataSet ds = new DataSet();
			SqlCommand cmd = new SqlCommand();
			
			cmd = m_con.CreateCommand();
			cmd.CommandText = scmd;
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
				da.Fill(ds);
			}
			catch (Exception ex)
			{
				//GoTo 1
				MessageBox.Show(ex.Message);
			}
			
			m_con.Close();
			return ds;
		}
		
		public static string ReadIni(string xTipe, string xName)
		{
			int res;
			StringBuilder sb = default(StringBuilder);
			sb = new StringBuilder(500);
			res = System.Convert.ToInt32(GetPrivateProfileString(xTipe, xName, "", sb, sb.Capacity, Application.StartupPath + "\\Config.ini"));
			//res = GetPrivateProfileString(xTipe, xName, "", sb, sb.Capacity, "C:\Program Files\Berca\Config.ini")
			return sb.ToString();
		}

		//[DllImport("kernel32", EntryPoint="GetPrivateProfileStringW")]

		[DllImport("kernel32.dll", EntryPoint = "GetPrivateProfileString")]
		//private static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);
		public static extern int GetPrivateProfileString(string SectionName, string KeyName, string Default, StringBuilder Return_StringBuilder_Name, int Size, string FileName);
		public static string decrypt(string unpass)
		{
			int x = 0;
			string awal = "";
			string kembali = "";
			x = 1;
			awal = "";
			while (x <= unpass.Trim().Length)
			{
				kembali = unpass.Substring(x - 1, 3);
				x = x + 3;
				awal = awal + System.Convert.ToString(Strings.Chr(System.Convert.ToInt32((Conversion.Val(kembali) + 11) / 3 - 5)));
			}
			return awal;
		}
		
		public static void SaveLog(string Param)
		{
			string line = "";
			string path = (new Microsoft.VisualBasic.Devices.ServerComputer()).FileSystem.SpecialDirectories.MyDocuments + "\\LOG_" + Strings.Format(DateTime.Now, "ddMMyyyy") +".txt";
			if (File.Exists(path))
			{
				using (StreamReader sr = new StreamReader(path))
				{
					line = sr.ReadToEnd();
				}
				
			}
			File.Delete(path);
			System.IO.StreamWriter sw = new System.IO.StreamWriter(path);
			sw.Write(line);
			sw.Write(Constants.vbNewLine);
			sw.Write(Param);
			sw.Close();
			sw.Dispose();
		}
		
		public static bool Super(string lvl)
		{
			VOK = false;
			VSuper_Nm = "";
			frmValid.Default.VLevelApp.Text = lvl;
			frmValid.Default.ShowDialog();
			return VOK;
		}
		
		public static string UbahChar(string Kata)
		{
			return Kata.Replace("'", "''");
		}
		
		public static DateTime GetSrvDate()
		{
			DateTime returnValue = default(DateTime);
			try
			{
				DataSet RsTglVsvr = new DataSet();
				if (VPing == "ONLINE")
				{
					RsTglVsvr = getSqldb("select getdate() as srvdt", ConnServer);
				}
				else
				{
					RsTglVsvr = getSqldb("select getdate() as srvdt", ConnLocal);
				}
				
				returnValue = System.Convert.ToDateTime(RsTglVsvr.Tables[0].Rows[0]["srvdt"]);
				RsTglVsvr.Clear();
				RsTglVsvr = null;
			}
			catch (Exception)
			{
				returnValue = DateTime.Now;
			}
			return returnValue;
		}
		
		
		
		public static bool sendMessage(string number, string message)
		{
			bool returnValue = false;
			bool success = true;
			WebClient webClient = new WebClient();
			
			try
			{
				Payload payloadObj = new Payload(number, message);
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				string postData = serializer.Serialize(payloadObj);
				
				webClient.Headers["content-type"] = "application/json";
				webClient.Headers["X-WM-CLIENT-ID"] = CLIENT_ID;
				webClient.Headers["X-WM-CLIENT-SECRET"] = CLIENT_SECRET;
				
				webClient.Encoding = Encoding.UTF8;
				string response = webClient.UploadString(API_URL, postData);
				Console.WriteLine(response);
			}
			catch (WebException webEx)
			{
				HttpWebResponse res = (HttpWebResponse) webEx.Response;
				Stream stream = res.GetResponseStream();
				StreamReader reader = new StreamReader(stream);
				string body = reader.ReadToEnd();
				
				Console.WriteLine((int) res.StatusCode);
				Console.WriteLine(body);
				success = false;
			}

			return true;
		}
		
		
		private class Payload
		{
			public string number;
			public string message;
			
			public Payload(string num, string msg)
			{
				number = num;
				message = msg;
			}
		}
	}
	
}
