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

using libzkfpcsharp;
using System.Threading;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using iPOS;


namespace iPOS
{
	public partial class frmLogin
	{
		public frmLogin()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmLogin defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmLogin Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmLogin();
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
		byte ulang;
		string posisi;
		IntPtr mDevHandle = IntPtr.Zero;
		IntPtr mDBHandle = IntPtr.Zero;
		byte[][] RegTmps = new byte[2][];
		private int mfpWidth = 0;
		private int mfpHeight = 0;
		byte[] FPBuffer;
		bool bIsTimeToDie = false;
		int cbCapTmp = 2048;
		IntPtr FormHandle = IntPtr.Zero;
		byte[] CapTmp = new byte[2048];
		const int MESSAGE_CAPTURED_OK = 0x0400 + 6;
		[DllImport("user32.dll", EntryPoint = "SendMessageA")]
			public static  extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
		
		
		
		//public void CheckFinger()
		//{
		//	int ret = zkfperrdef.ZKFP_ERR_OK;
		//	if ((zkfp2.Init()) == zkfperrdef.ZKFP_ERR_OK)
		//	{
		//		int nCount = zkfp2.GetDeviceCount();
		//		if (nCount > 0)
		//		{
		//			Module1.FingerOK = true;
		//		}
		//		else
		//		{
		//			Module1.FingerOK = false;
		//			zkfp2.Terminate();
		//		}
		//	}
		//	else
		//	{
		//	}
		//	if (Module1.FingerOK == true)
		//	{
		//		int ret2 = zkfp.ZKFP_ERR_OK;
		//		mDevHandle = zkfp2.OpenDevice(0);
		//		if (IntPtr.Zero == (zkfp2.OpenDevice(0)))
		//		{
		//			return;
		//		}
		//		mDBHandle = zkfp2.DBInit();
		//		if (IntPtr.Zero == (mDBHandle == zkfp2.DBInit()))
		//		{
		//			zkfp2.CloseDevice(mDevHandle);
		//			mDevHandle = IntPtr.Zero;
		//			return;
		//		}
				
		//		for (int i = 0; i <= 3 - 1; i++)
		//		{
		//			RegTmps[i] = new byte[2049];
		//		}
				
		//		byte[] paramValue = new byte[5];
		//		int size = 4;
		//		zkfp2.GetParameters(mDevHandle, 1, paramValue, ref size);
		//		zkfp2.ByteArray2Int(paramValue, ref mfpWidth);
		//		size = 4;
		//		zkfp2.GetParameters(mDevHandle, 2, paramValue, ref size);
		//		zkfp2.ByteArray2Int(paramValue, ref mfpHeight);
		//		FPBuffer = new byte[mfpWidth * mfpHeight+ 1];
		//		Thread captureThread = new Thread(new System.Threading.ThreadStart(DoCapture));
		//		captureThread.IsBackground = true;
		//		captureThread.Start();
		//		bIsTimeToDie = false;
		//	}
		//	else
		//	{
		//	}
		//}
		
		private void DoCapture()
		{
			while (!bIsTimeToDie)
			{
				cbCapTmp = 2048;
				int ret = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, ref cbCapTmp);
				
				if (ret == zkfp.ZKFP_ERR_OK)
				{
					SendMessage(FormHandle, MESSAGE_CAPTURED_OK, IntPtr.Zero, IntPtr.Zero);
				}
				
				Thread.Sleep(200);
			}
		}
		
		protected override void DefWndProc(ref Message m)
		{
			switch (m.Msg)
			{
				case MESSAGE_CAPTURED_OK:
					
					DataSet DsFinger = new DataSet();
					if (Module1.VPing == "ONLINE")
					{
						DsFinger = Module1.getSqldb("select a.*,b.user_Name from users_finger a inner join users b on a.user_id = b.user_id", Module1.ConnServer);
					}
					else
					{
						DsFinger = Module1.getSqldb("select a.*,b.user_Name from users_finger a inner join users b on a.user_id = b.user_id", Module1.ConnLocal);
					}
					
					
					foreach (DataRow dr in DsFinger.Tables[0].Rows)
					{
						int ret = zkfp2.DBMatch(mDBHandle, CapTmp, (byte[]) (dr["RegTmp"]));
						if (0 < ret)
						{
							(new Microsoft.VisualBasic.Devices.Audio()).Play(Application.StartupPath + "/Bleep.wav", AudioPlayMode.Background);
							Module1.VSuper_Nm = dr["user_id"].ToString() + " / " + dr["user_Name"].ToString();
							Module1.VOK = true;
							Module1.SaveLog("Verifikasi Success - Login " + dr["user_id"].ToString() + " / " + dr["user_Name"].ToString());
							CheckLogin("select * from users where User_ID='" + System.Convert.ToString(dr["user_id"]) + "' and branch_id='" + Module1.VBranch_ID + "'", true);
							goto _1;
						}
					}
					Interaction.MsgBox("Match finger fail!!", MsgBoxStyle.Critical, "Attentions");
					return;
				default:
					base.DefWndProc(ref m);
					return;
			}
_1:
			this.Close();
		}
		private void Form_Activate()
		{
			//    txtuser = "1313"
			//    txtpassword = "2011"
			//    Call cmdLogin_Click
		}
		public void frmLogin_Load(System.Object eventSender, System.EventArgs eventArgs)
		{
			//frmSplash.Close()
			lbltoko.Text = Module1.Tulis[10];
			txtregidNet.Text = Module1.VReg_ID;
			lblonline.Text = Module1.VPing;
			txtuserNet.Select();
			txtuserNet.Focus();
			if (Module1.LoadClose == true)
			{
				Isi_Parameter();
				Cek_CashOpen();
			}
			if (Module1.VPing == "ONLINE")
			{
				lblonline.ForeColor = Color.Green;
			}
			else
			{
				lblonline.ForeColor = Color.Red;
			}
			Cetak.CDisplay("  ", "*** LAKON ***");
			FormHandle = this.Handle;
			//CheckFinger();
		}
		
		public void CheckLogin(string str, bool Log)
		{
			DataSet RsUser = new DataSet();
			Module1.StrSQL = str;
			
			//lemot pas ping
			//If Linked Then
			//    RsUser = getSqldb(StrSQL, ConnServer)
			//Else
			//    RsUser = getSqldb(StrSQL, ConnLocal)
			//End If
			
			if (Module1.VPing == "ONLINE")
			{
				for (int x = 0; x <= 1; x++)
				{
					RsUser = Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
				}
			}
			else
			{
				RsUser = Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
			}
			
			if (RsUser.Tables[0].Rows.Count > 0)
			{
				//Cek E-Commerce User
				if (Strings.Trim(System.Convert.ToString(RsUser.Tables[0].Rows[0]["User_ID"])) == "5000")
				{
					Module1.VReg_ID = Module1.VReg_OL;
					Isi_Parameter();
					Cek_CashOpen();
				}
				else
				{
					Module1.VReg_ID = Module1.ReadIni("RegisterInfo", "RegID");
				}
				
				if (Log == true)
				{
					Module1.VKasir_ID = Strings.Trim(System.Convert.ToString(RsUser.Tables[0].Rows[0]["User_ID"]));
					Module1.VKasir_Nm = Strings.Trim(System.Convert.ToString(RsUser.Tables[0].Rows[0]["user_Name"]));
					Module1.SecLev = System.Convert.ToInt32(RsUser.Tables[0].Rows[0]["Security_Level"]);
					//Pindah ke Form Splash
					//If Linked() Then Call Cek_SOD("server")
					//Call Cek_SOD("local")
					//Call Cek_Card()
					//Call Cek_CashOpen()
					//Call Cek_AdaPromo()
					//Call Isi_key()
					//---------------------
					if (Convert.ToInt32(Module1.RegType) == 0)
					{
						Cetak.CetakBegin();
					}
					else
					{
						if (Module1.SecLev >= 3)
						{
							if (Module1.VCopen == false)
							{
								MessageBox.Show("Masukan Modal Terlebih Dahulu !!");
								txtuserNet.Visible = true;
								Label2.Text = "USER ID";
								txtpasswordNet.Visible = false;
								txtuserNet.Focus();
								this.WindowState = FormWindowState.Minimized;
								frmCashOpen.Default.ShowDialog();
								//SendKeys.Send("{home}+{end}")
								//Exit Sub
							}
						}
					}
					
					
					this.Close();
					
					
					Module1.getSqldb("update cash_register set active_status=1 where Branch_ID = '" +
						Module1.VBranch_ID + "' AND cash_register_id='" + Module1.VReg_ID + "'", Module1.ConnLocal);
					//If Linked() Then
					//    getSqldb("update cash_register set active_status=1 where Branch_ID = '" &
					//            VBranch_ID & "' AND cash_register_id='" & VReg_ID & "'", ConnServer)
					//End If
					
					//tanpa cek PING
					if (Module1.VPing == "ONLINE")
					{
						Module1.getSqldb("update cash_register set active_status=1 where Branch_ID = '" +
							Module1.VBranch_ID + "' AND cash_register_id='" + Module1.VReg_ID + "'", Module1.ConnServer);
					}
					Module1.SaveLog("Login Success" + " " + Module1.VKasir_ID + " / " + Module1.VKasir_Nm);
					
					if (System.Convert.ToInt32(Module1.RegType) == 0)
					{
						frmMain.Default.Show();
					}
					else
					{
						if (Module1.SecLev < 3)
						{
							frmMain.Default.Show();
						}
						else
						{
							Cetak.CDisplay("  SALES", "TRANSACTION ");
							Module1.Star_Id = "10000000";
							Module1.VBonus_Point = (byte) 1;
							frmSalesSelf.Default.Text = "SALES";
							frmSalesSelf.Default.txtcard_no.Text = "LM-00000000";
							frmSalesSelf.Default.txtcust_name.Text = "ONE TIME CUSTOMER";
							frmSalesSelf.Default.txtcust_id.Text = "10000000";
							Module1.Star_No = "LM-00000000";
							Module1.Star_Nm = "ONE TIME CUSTOMER";
							Module1.Star_Phone = "";
							Module1.VNomor = "";
							frmSalesSelf.Default.Show();
						}
					}
				}
				else
				{
					if (Strings.Trim(System.Convert.ToString(RsUser.Tables[0].Rows[0]["Password"])) == txtpasswordNet.Text)
					{
						Module1.VKasir_ID = Strings.Trim(System.Convert.ToString(RsUser.Tables[0].Rows[0]["User_ID"]));
						Module1.VKasir_Nm = Strings.Trim(System.Convert.ToString(RsUser.Tables[0].Rows[0]["user_Name"]));
						Module1.SecLev = System.Convert.ToInt32(RsUser.Tables[0].Rows[0]["Security_Level"]);
						//Pindah ke Form Splash
						//If Linked() Then Call Cek_SOD("server")
						//Call Cek_SOD("local")
						//Call Cek_Card()
						//Call Cek_CashOpen()
						//Call Cek_AdaPromo()
						//Call Isi_key()
						//---------------------
						if (System.Convert.ToInt32(Module1.RegType) == 0)
						{
						}
						else
						{
							if (Module1.SecLev >= 3)
							{
								if (Module1.VCopen == false)
								{
									MessageBox.Show("Masukan Modal Terlebih Dahulu !!");
									txtuserNet.Visible = true;
									Label2.Text = "USER ID";
									txtpasswordNet.Visible = false;
									txtuserNet.Focus();
									//SendKeys.Send("{home}+{end}")
									this.WindowState = FormWindowState.Minimized;
									frmCashOpen.Default.ShowDialog();
									//Exit Sub
								}
							}
						}
						
						Cetak.CetakBegin();
						this.Close();
						
						
						Module1.getSqldb("update cash_register set active_status=1 where Branch_ID = '" +
							Module1.VBranch_ID + "' AND cash_register_id='" + Module1.VReg_ID + "'", Module1.ConnLocal);
						//If Linked() Then
						//    getSqldb("update cash_register set active_status=1 where Branch_ID = '" &
						//            VBranch_ID & "' AND cash_register_id='" & VReg_ID & "'", ConnServer)
						//End If
						
						//tanpa cek PING
						if (Module1.VPing == "ONLINE")
						{
							Module1.getSqldb("update cash_register set active_status=1 where Branch_ID = '" +
								Module1.VBranch_ID + "' AND cash_register_id='" + Module1.VReg_ID + "'", Module1.ConnServer);
						}
						Module1.SaveLog("Login Success" + " " + Module1.VKasir_ID + " / " + Module1.VKasir_Nm);
						
						if (System.Convert.ToInt32(Module1.RegType) == 0)
						{
							frmMain.Default.Show();
						}
						else
						{
							if (Module1.SecLev < 3)
							{
								frmMain.Default.Show();
							}
							else
							{
								Cetak.CDisplay("  SALES", "TRANSACTION ");
								Module1.Star_Id = "10000000";
								Module1.VBonus_Point = (byte) 1;
								frmSalesSelf.Default.Text = "SALES";
								frmSalesSelf.Default.txtcard_no.Text = "LM-00000000";
								frmSalesSelf.Default.txtcust_name.Text = "ONE TIME CUSTOMER";
								frmSalesSelf.Default.txtcust_id.Text = "10000000";
								Module1.Star_No = "LM-00000000";
								Module1.Star_Nm = "ONE TIME CUSTOMER";
								Module1.Star_Phone = "";
								Module1.VNomor = "";
								frmSalesSelf.Default.Show();
							}
						}
						
					}
					else
					{
						Interaction.MsgBox("Password yang anda masukkan salah", (int) Constants.vbCritical + Constants.vbOKOnly, "Oops..");
						ulang++;
						if (ulang > 2)
						{
							this.Close();
							if (Module1.VPing == "ONLINE")
							{
								frmFirstForm.Default.Show();
							}
							else
							{
								Application.Exit();
							}
						}
						txtpasswordNet.Visible = true;
						txtuserNet.Visible = false;
						txtpasswordNet.Focus();
						SendKeys.Send("{home}+{end}");
					}
				}
				
			}
			else
			{
				Label2.Text = "USER ID";
				txtuserNet.Visible = true;
				txtpasswordNet.Visible = false;
				Interaction.MsgBox("Username tidak terdaftar", (int) Constants.vbCritical + Constants.vbOKOnly, "Oops..");
				txtuserNet.Focus();
				SendKeys.Send("{home}+{end}");
			}
		}
		private void cmdLogin_Click()
		{
			CheckLogin("select * from users where User_ID='" + txtuserNet.Text + "' and branch_id='" + Module1.VBranch_ID + "'", false);
		}
		public void txtpasswordNet_Enter(System.Object eventSender, System.EventArgs eventArgs)
		{
			posisi = "txtpasswordNet";
		}
		public void txtuserNet_Enter(System.Object eventSender, System.EventArgs eventArgs)
		{
			posisi = "txtuserNet";
		}
		public void txtuserNet_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					txtuserNet.Visible = false;
					txtpasswordNet.Visible = true;
					txtpasswordNet.Text = "";
					//penambahan
					Label2.Text = "PASSWORD";
					txtpasswordNet.Focus();
					break;
				case (System.Windows.Forms.Keys) 27:
					ProjectData.EndApp();
					break;
			}
			if (e.KeyCode == Keys.Enter)
			{
				//Menghilangkan Bunyi Beep
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
			
		}
		public void txtpasswordNet_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					cmdLogin_Click();
					break;
				case (System.Windows.Forms.Keys) 27:
					txtuserNet.Visible = true;
					txtpasswordNet.Visible = false;
					txtuserNet.Focus();
					txtpasswordNet.Text = "";
					break;
			}
			if (e.KeyCode == Keys.Enter)
			{
				//Menghilangkan Bunyi Beep
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}
		public void _btnNum_0_Click(System.Object sender, System.EventArgs e)
		{
			
			Button btn = (Button) sender;
			switch (posisi)
			{
				case "txtuserNet":
					if (System.Convert.ToInt32(btn.Tag) < 10)
					{
						txtuserNet.Text = txtuserNet.Text + btn.Text;
					}
					txtuserNet.SelectionStart = txtuserNet.Text.Length;
					switch (System.Convert.ToInt32(btn.Tag))
					{
						case 10:
							txtuserNet.Focus();
							SendKeys.Send("{end}+{backspace}");
							break;
						case 11:
							txtuserNet.Focus();
							SendKeys.Send("{enter}");
							break;
						case 12:
							txtuserNet.Text = "";
							break;
						case 13:
							this.Close();
							if (Module1.VPing == "ONLINE")
							{
								//frmSOD.Text = "EOD"
								//frmSOD.ShowDialog()
								frmFirstForm.Default.Show();
							}
							else
							{
								Application.Exit();
							}
							break;
					}
					break;
					
				case "txtpasswordNet":
					if (System.Convert.ToInt32(btn.Tag) < 10)
					{
						txtpasswordNet.Text = txtpasswordNet.Text + btn.Text;
					}
					txtpasswordNet.SelectionStart = txtpasswordNet.Text.Length;
					switch (System.Convert.ToInt32(btn.Tag))
					{
						case 10:
							txtpasswordNet.Focus();
							System.Windows.Forms.SendKeys.Send("{end}+{backspace}");
							break;
						case 11:
							cmdLogin_Click();
							break;
						case 12:
							if (txtpasswordNet.Text == "")
							{
								Label2.Text = "USER ID";
								txtuserNet.Visible = true;
								txtpasswordNet.Visible = false;
								txtuserNet.Focus();
							}
							txtpasswordNet.Text = "";
							break;
						case 13:
							this.Close();
							if (Module1.VPing == "ONLINE")
							{
								//frmSOD.Text = "EOD"
								//frmSOD.ShowDialog()
								frmFirstForm.Default.Show();
							}
							else
							{
								Application.Exit();
							}
							break;
							
					}
					break;
					
			}
		}
		
		private void Cek_CashOpen()
		{
			DataSet RsCash = new DataSet();
			
			Module1.StrSQL = "select modal from cash where branch_id = '" + Module1.VBranch_ID + "' and Cash_Register_ID='" +
				Module1.VReg_ID + " ' and shift='" + System.Convert.ToString(Module1.VShift) + "' and datetime='" + System.Convert.ToString(Module1.GetSrvDate().Date) + "'";
			
			if (Module1.Linked())
			{
				RsCash = Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
			}
			else
			{
				RsCash = Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
			}
			
			Module1.VCopen = (RsCash.Tables[0].Rows.Count == 0) ? false : true;
		}
		
		
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
				
				
				if (Module1.Linked())
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
							"where branch_id = '" + Module1.VBranch_ID + "' and Cash_Register_ID='" + Module1.VReg_ID + " ')", Module1.ConnServer);
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
		
		public void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
		{
			zkfp2.CloseDevice(mDevHandle);
			zkfp2.Terminate();
		}
		
	}
}
