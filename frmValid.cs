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
using iPOS;

namespace iPOS
{
	public partial class frmValid : System.Windows.Forms.Form
	{
		public frmValid()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmValid defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmValid Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmValid();
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
		public void _btnNum_0_Click(System.Object sender, System.EventArgs e)
		{
			Button btn = (Button) sender;
			switch (posisi)
			{
				case "txtuser":
					txtuser.Focus();
					if (System.Convert.ToInt32(btn.Tag) < 10)
					{
						txtuser.Text = txtuser.Text + btn.Text;
					}
					txtuser.SelectionStart = txtuser.Text.Length;
					switch (System.Convert.ToInt32(btn.Tag))
					{
						case 10:
							System.Windows.Forms.SendKeys.Send("{end}+{backspace}");
							break;
						case 11:
							System.Windows.Forms.SendKeys.Send("{enter}");
							break;
						case 12:
							txtuser.Text = "";
							break;
						case 13:
							this.Close();
							break;
					}
					break;
				case "txtpassword":
					txtpassword.Focus();
					if (System.Convert.ToInt32(btn.Tag) < 10)
					{
						txtpassword.Text = txtpassword.Text + btn.Text;
					}
					txtpassword.SelectionStart = txtpassword.Text.Length;
					switch (System.Convert.ToInt32(btn.Tag))
					{
						case 10:
							System.Windows.Forms.SendKeys.Send("{end}+{backspace}");
							break;
						case 11:
							cmdLogin_Click();
							break;
						case 12:
							if (txtuser.Text == "")
							{
								txtuser.Visible = true;
								txtuser.Visible = false;
								txtuser.Focus();
							}
							txtuser.Text = "";
							break;
						case 13:
							this.Close();
							break;
					}
					break;
					
			}
		}
		
		private void cmdLogin_Click()
		{
			DataSet RsUser = new DataSet();
			Module1.StrSQL = "select * from users where User_ID='" + txtuser.Text + "' and branch_id='" + Module1.VBranch_ID + "' and security_level <='" + VLevelApp.Text + "'";
			
			if (Module1.VPing == "ONLINE")
			{
				RsUser = Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
			}
			else
			{
				RsUser = Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
			}
			
			if (RsUser.Tables[0].Rows.Count > 0)
			{
				if (Strings.Trim(RsUser.Tables[0].Rows[0]["Password"].ToString()) == txtpassword.Text)
				{
					Module1.VSuper_Nm = RsUser.Tables[0].Rows[0]["user_id"].ToString() + " / " + RsUser.Tables[0].Rows[0]["user_Name"].ToString();
					Module1.VOK = true;
					Module1.SaveLog("Verifikasi Success -" + VLevelApp.Text + " " + RsUser.Tables[0].Rows[0]["user_id"].ToString() + " / " + RsUser.Tables[0].Rows[0]["user_Name"].ToString());
					this.Close();
				}
				else
				{
					Interaction.MsgBox("Password yang anda masukkan salah", (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
					ulang++;
					if (ulang > 2)
					{
						this.Close();
						ulang = (byte) 0;
						return;
					}
					txtpassword.Focus();
					txtuser.Focus();
					System.Windows.Forms.SendKeys.Send("{home}+{end}");
				}
			}
			else
			{
				Interaction.MsgBox("User tidak ada otorisasi", (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				this.Close();
			}
		}
		
		public void txtpassword_Enter(System.Object eventSender, System.EventArgs eventArgs)
		{
			posisi = "txtpassword";
		}
		
		
		public void txtpassword_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					cmdLogin_Click();
					break;
				case (System.Windows.Forms.Keys) 27:
					this.Close();
					break;
			}
		}
		
		public void txtuser_Enter(System.Object eventSender, System.EventArgs eventArgs)
		{
			posisi = "txtuser";
		}
		
		
		public void txtuser_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					lblUser.Text = "PASSWORD";
					txtpassword.Visible = true;
					txtpassword.Text = "";
					txtpassword.Focus();
					break;
				case (System.Windows.Forms.Keys) 27:
					this.Close();
					break;
			}
		}
		
		public void frmValid_Activated(object sender, System.EventArgs e)
		{
			lblUser.Text = "USER ID";
			txtuser.Select();
			txtuser.Focus();
			txtuser.Text = "";
			txtpassword.Text = "";
			txtpassword.Visible = false;
		}
		
		public void frmValid_Load(object sender, EventArgs e)
		{
			FormHandle = this.Handle;
			//CheckFinger();
			
		}
		
		protected override void DefWndProc(ref Message m)
		{
			switch (m.Msg)
			{
				case MESSAGE_CAPTURED_OK:
					
					DataSet DsFinger = new DataSet();
					if (Module1.VPing == "ONLINE")
					{
						DsFinger = Module1.getSqldb("select a.*,b.user_Name from users_finger a inner join users b on a.user_id = b.user_id and b.security_level <='" + VLevelApp.Text + "'", Module1.ConnServer);
					}
					else
					{
						DsFinger = Module1.getSqldb("select a.*,b.user_Name from users_finger a inner join users b on a.user_id = b.user_id and b.security_level <='" + VLevelApp.Text + "'", Module1.ConnLocal);
					}
					
					
					foreach (DataRow dr in DsFinger.Tables[0].Rows)
					{
						int ret = zkfp2.DBMatch(mDBHandle, CapTmp, (byte[]) (dr["RegTmp"]));
						if (0 < ret)
						{
							(new Microsoft.VisualBasic.Devices.Audio()).Play(Application.StartupPath + "/Bleep.wav", AudioPlayMode.Background);
							Module1.VSuper_Nm = dr["user_id"].ToString() + " / " + dr["user_Name"].ToString();
							Module1.VOK = true;
							Module1.SaveLog("Verifikasi Success -" + VLevelApp.Text + " " + dr["user_id"].ToString() + " / " + dr["user_Name"].ToString());
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
		
		public void frmValid_FormClosed(object sender, FormClosedEventArgs e)
		{
			//zkfp2.CloseDevice(mDevHandle)
			//zkfp2.Terminate()
		}
		
		public void frmValid_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				//Menghilangkan Bunyi ding
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}
	}
}
