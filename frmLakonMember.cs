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
using System.Text.RegularExpressions;
using iPOS;

namespace iPOS
{
	public partial class MemberRegistration
	{
		public MemberRegistration()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static MemberRegistration defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static MemberRegistration Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new MemberRegistration();
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
		public void LakonMember_Load(object sender, EventArgs e)
		{
			ArrayList c = new ArrayList();
			c.Add(new CCombo("M", "MALE"));
			c.Add(new CCombo("F", "FEMALE"));
			ComboBox1.DataSource = c;
			ComboBox1.DisplayMember = "Number_Name";
			ComboBox1.ValueMember = "ID";
			txtcust_name.Clear();
			txtEmail.Clear();
			txtPhone.Clear();
			txtcard_no.Text = Cek_No();
			txtcust_name.Select();
			txtcust_name.SelectionStart = 0;
			txtcust_name.Focus();
		}
		
		
		
		private string Cek_No()
		{
			string returnValue = "";
			DataSet RsCari = new DataSet();
			
			RsCari = Module1.getSqldb("SELECT  max (CAST(RIGHT(Member_Code, 5) AS int)) AS nomor " +
				"FROM Members where SUBSTRING(Member_Code,4,3)='" + Microsoft.VisualBasic.Strings.Right(Module1.VBranch_ID, 3) + "' ", Module1.ConnServer);
			
			if (Information.IsDBNull(RsCari.Tables[0].Rows[0]["nomor"]))
			{
				returnValue = "LM-" + Microsoft.VisualBasic.Strings.Right(Module1.VBranch_ID, 3) + "00001";
			}
			else
			{
				returnValue = "LM-" + Microsoft.VisualBasic.Strings.Right(Module1.VBranch_ID, 3) + Microsoft.VisualBasic.Strings.Right("0000" + System.Convert.ToString(System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["nomor"]) + 1), 5);
			}
			RsCari.Clear();
			RsCari = null;
			return returnValue;
		}
		
		
		public void CmdCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void txtEmail_Validating(object sender, CancelEventArgs e)
		{
			string temp = "";
			temp = txtEmail.Text;
			//Dim conditon As Boolean
			//emailaddresscheck(temp)
			if (emailaddresscheck(temp) == false)
			{
				MessageBox.Show("Please enter your email address correctly", "Incorrect Email Entry");
				txtEmail.Text = "";
				txtEmail.BackColor = Color.Blue;
			}
			else
			{
				txtEmail.BackColor = Color.White;
			}
		}
		
		private bool emailaddresscheck(string emailaddress)
		{
			string pattern = "^[a-zA-Z][\\w\\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\\w\\.-]*[a-zA-Z0-9]\\.[a-zA-Z][a-zA-Z\\.]*[a-zA-Z]$";
			Match emailAddressMatch = Regex.Match(emailaddress, pattern);
			if (emailAddressMatch.Success)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		
		public void txtEmail_TextChanged(object sender, EventArgs e)
		{
			txtEmail.BackColor = Color.White;
			string temp = "";
			temp = txtEmail.Text;
			bool conditon = false;
			emailaddresscheck(temp);
			if (emailaddresscheck(System.Convert.ToString(conditon)) == true)
			{
				MessageBox.Show("Please enter your email address correctly", "Incorrect Email Entry");
				txtEmail.Text = "";
				txtEmail.BackColor = Color.Yellow;
			}
			else
			{
				txtEmail.BackColor = Color.White;
			}
		}
		
		public void CmdOk_Click(object sender, EventArgs e)
		{
			var textBoxes = this.Controls.OfType<TextBox>();
			foreach (var t in textBoxes)
			{
				if (string.IsNullOrEmpty(t.Text))
				{
					MessageBox.Show("Complete Entry!");
					break;
				}
			}
			DataSet RsCari = new DataSet();
			string NoMem = "";
			NoMem = Cek_No();
			RsCari = Module1.getSqldb("select * from members where phone = '" + txtPhone.Text + "' and STATUS ='A'", Module1.ConnServer);
			if (RsCari.Tables[0].Rows.Count == 0)
			{
				Module1.getSqldb("insert into members values ('" + NoMem + "','" + txtcust_name.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + System.Convert.ToString(ComboBox1.SelectedValue) + "',0,'A',getdate(),getdate())", Module1.ConnLocal);
				if (Module1.VPing == "ONLINE")
				{
					Module1.getSqldb("insert into members values ('" + NoMem + "','" + txtcust_name.Text + "','" + txtPhone.Text + "','" + txtEmail.Text + "','" + System.Convert.ToString(ComboBox1.SelectedValue) + "',0,'A',getdate(),getdate())", Module1.ConnServer);
				}
				MessageBox.Show("Successfull!!!");
			}
			else
			{
				MessageBox.Show("Member sudah terdaftar dengan Nama : '" + RsCari.Tables[0].Rows[0]["Member_Name"] + "'");
				return;
			}
			
			if (Module1.NewMember == true)
			{
				frmSalesSelf.Default.txtcard_no.Text = txtcard_no.Text;
				frmSalesSelf.Default.txtcust_name.Text = txtcust_name.Text;
				frmSalesSelf.Default.txtcust_id.Text = txtcard_no.Text.Replace("LM-", "");
				frmSales.Default.txtcard_no.Text = txtcard_no.Text;
				frmSales.Default.txtcust_name.Text = txtcust_name.Text;
				frmSales.Default.txtcust_id.Text = txtcard_no.Text.Replace("LM-", "");
				Module1.Star_No = txtcard_no.Text;
				Module1.Star_Nm = txtcust_name.Text;
				Module1.Star_Phone = txtPhone.Text;
			}
			txtcust_name.Clear();
			txtEmail.Clear();
			txtPhone.Clear();
			txtcard_no.Text = Cek_No();
			txtcust_name.Select();
			txtcust_name.SelectionStart = 0;
			txtcust_name.Focus();
			this.Close();
		}
		
		public void txtcust_name_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				txtPhone.Focus();
				txtPhone.SelectionLength = txtPhone.Text.Length;
			}
		}
		
		public void txtPhone_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				txtEmail.Focus();
				txtEmail.SelectionLength = txtEmail.Text.Length;
			}
		}
		
		public void txtEmail_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				CmdOk.Focus();
			}
		}
		
		public void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			CmdOk.Focus();
		}
		
		public void txtPhone_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (Strings.Asc(e.KeyChar) != 8)
			{
				if (Strings.Asc(e.KeyChar) < 48 || Strings.Asc(e.KeyChar) > 57)
				{
					e.Handled = true;
				}
			}
		}
	}
}
