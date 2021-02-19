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
	public partial class frmPassword : System.Windows.Forms.Form
	{
		public frmPassword()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmPassword defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmPassword Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmPassword();
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
		string lama;
		public void _btnNum_0_Click(System.Object sender, System.EventArgs e)
		{
			Button btn = (Button) sender;
			
			if (System.Convert.ToInt32(btn.Tag) < 10)
			{
				txtpassword.Text = txtpassword.Text + btn.Text;
			}
			
			switch (System.Convert.ToInt32(btn.Tag))
			{
				case 10:
					System.Windows.Forms.SendKeys.Send("{end}+{backspace}");
					break;
				case 11:
					switch (Label2.Text)
					{
						case "PASSWORD LAMA":
							if (txtpassword.Text == "")
							{
								txtpassword.Focus();
								return;
							}
							Label2.Text = "PASSWORD BARU";
							lama = txtpassword.Text;
							txtpassword.Text = "";
							break;
						case "PASSWORD BARU":
							if (txtpassword.Text == "")
							{
								txtpassword.Focus();
								return;
							}
							cmdLogin_Click();
							Label2.Text = "PASSWORD LAMA";
							break;
					}
					break;
				case 12:
					switch (Label2.Text)
					{
						case "PASSWORD LAMA":
							if (txtpassword.Text != "")
							{
								txtpassword.Text = "";
							}
							break;
						case "PASSWORD BARU":
							if (txtpassword.Text != "")
							{
								txtpassword.Text = "";
							}
							else
							{
								Label2.Text = "PASSWORD LAMA";
								txtpassword.Text = "";
							}
							break;
							
					}
					txtpassword.Focus();
					break;
				case 13:
					txtpassword.Focus();
					this.Close();
					break;
					
			}
		}
		private void cmdLogin_Click()
		{
			DataSet RsUser = new DataSet();
			if (Module1.VPing != "ONLINE")
			{
				Interaction.MsgBox("Perubahan password harus saat online", (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				return;
			}
			else
			{
				RsUser = Module1.getSqldb("select * from users where User_ID='" + Module1.VKasir_ID + "' and branch_id='" + Module1.VBranch_ID + "'", Module1.ConnServer);
				
				if (RsUser.Tables[0].Rows.Count > 0)
				{
					if (Strings.Trim(System.Convert.ToString(RsUser.Tables[0].Rows[0]["Password"])) == lama)
					{
						Module1.getSqldb("update users set password = '" + txtpassword.Text + "' where User_ID='" + Module1.VKasir_ID + "' and branch_id='" + Module1.VBranch_ID + "'", Module1.ConnServer);
						Interaction.MsgBox("Password sudah berubah", (int) MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Oops..");
						this.Close();
					}
					else
					{
						Interaction.MsgBox("Password yang anda masukkan salah", (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
						txtpassword.Focus();
						System.Windows.Forms.SendKeys.Send("{home}+{end}");
					}
				}
			}
		}
		public void txtpassword_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					switch (Label2.Text)
					{
						case "PASSWORD LAMA":
							if (txtpassword.Text == "")
							{
								txtpassword.Focus();
								return;
							}
							Label2.Text = "PASSWORD BARU";
							lama = txtpassword.Text;
							txtpassword.Text = "";
							break;
						case "PASSWORD BARU":
							if (txtpassword.Text == "")
							{
								txtpassword.Focus();
								return;
							}
							cmdLogin_Click();
							Label2.Text = "PASSWORD LAMA";
							break;
					}
					break;
				case (System.Windows.Forms.Keys) 27:
					this.Close();
					break;
			}
		}
		public void frmPassword_Load(object sender, System.EventArgs e)
		{
			txtpassword.Text = "";
			Label2.Text = "PASSWORD LAMA";
			txtpassword.Focus();
		}
	}
}
