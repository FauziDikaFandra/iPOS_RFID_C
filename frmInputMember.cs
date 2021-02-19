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
	public partial class InputMember
	{
		public InputMember()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static InputMember defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static InputMember Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new InputMember();
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
		public void InputMember_Load(object sender, EventArgs e)
		{
			ArrayList c = new ArrayList();
			c.Add(new CCombo("M", "MALE"));
			c.Add(new CCombo("F", "FEMALE"));
			ComboBox1.DataSource = c;
			ComboBox1.DisplayMember = "Number_Name";
			ComboBox1.ValueMember = "ID";
			txtcard_no.Clear();
			txtcust_name.Clear();
			txtEmail.Clear();
			txtPhone.Clear();
			txtPhone.Select();
			txtPhone.SelectionStart = 0;
			txtPhone.Focus();
			this.TopMost = true;
		}
		
		public void txtPhone_KeyDown(object sender, KeyEventArgs e)
		{
			
			DataSet RsCari = new DataSet();
			if (e.KeyCode == Keys.Enter)
			{
				if (txtPhone.Text == "")
				{
					MessageBox.Show("Member Not Found !!!");
					isi_data("LM-00000000", "ONE TIME CUSTOMER", System.Convert.ToString(0), "10000000", "", "", "0800000000", "", "");
					Module1.Star_Id = "10000000";
					CmdOk.Focus();
					return;
				}
				txtcard_no.Clear();
				txtEmail.Clear();
				txtcust_name.Clear();
				if (Module1.VPing == "ONLINE")
				{
					RsCari = Module1.getSqldb("Select * from members where Phone = '" + txtPhone.Text.ToString().Trim() + "' and STATUS ='A'", Module1.ConnServer);
				}
				else
				{
					RsCari = Module1.getSqldb("Select * from members where Phone = '" + txtPhone.Text.ToString().Trim() + "' and STATUS ='A'", Module1.ConnLocal);
				}
				
				if (RsCari.Tables[0].Rows.Count > 0)
				{
					txtcard_no.Text = System.Convert.ToString(RsCari.Tables[0].Rows[0]["Member_Code"]);
					txtcust_name.Text = System.Convert.ToString(RsCari.Tables[0].Rows[0]["Member_Name"]);
					txtEmail.Text = System.Convert.ToString(RsCari.Tables[0].Rows[0]["Email"]);
					ComboBox1.SelectedValue = RsCari.Tables[0].Rows[0]["Gender"];
					CmdOk.Focus();
				}
				else
				{
					MessageBox.Show("Member Not Found !!!");
					isi_data("LM-00000000", "ONE TIME CUSTOMER", System.Convert.ToString(0), "10000000", "", "", "0800000000", "", "");
					Module1.Star_Id = "10000000";
					CmdOk.Focus();
					return;
				}
			}
			
		}
		
		public void SubView()
		{
			DataSet RsCari = new DataSet();
			
			if (txtPhone.Text == "")
			{
				MessageBox.Show("Member Not Found !!!");
				isi_data("LM-00000000", "ONE TIME CUSTOMER", System.Convert.ToString(0), "10000000", "", "", "0800000000", "", "");
				Module1.Star_Id = "10000000";
				CmdOk.Focus();
				return;
			}
			txtcard_no.Clear();
			txtEmail.Clear();
			txtcust_name.Clear();
			if (Module1.VPing == "ONLINE")
			{
				RsCari = Module1.getSqldb("Select * from members where Phone = '" + txtPhone.Text.ToString().Trim() + "' and STATUS ='A'", Module1.ConnServer);
			}
			else
			{
				RsCari = Module1.getSqldb("Select * from members where Phone = '" + txtPhone.Text.ToString().Trim() + "' and STATUS ='A'", Module1.ConnLocal);
			}
			
			if (RsCari.Tables[0].Rows.Count > 0)
			{
				txtcard_no.Text = System.Convert.ToString(RsCari.Tables[0].Rows[0]["Member_Code"]);
				txtcust_name.Text = System.Convert.ToString(RsCari.Tables[0].Rows[0]["Member_Name"]);
				txtEmail.Text = System.Convert.ToString(RsCari.Tables[0].Rows[0]["Email"]);
				ComboBox1.SelectedValue = RsCari.Tables[0].Rows[0]["Gender"];
				CmdOk.Focus();
			}
			else
			{
				MessageBox.Show("Member Not Found !!!");
				isi_data("LM-00000000", "ONE TIME CUSTOMER", System.Convert.ToString(0), "10000000", "", "", "0800000000", "", "");
				Module1.Star_Id = "10000000";
				CmdOk.Focus();
				return;
			}
			
		}
		
		
		private void isi_data(string no_kartu, string Nama, string Point, string id, string freq, string omz, string telepon, string PointEx, string PeriodEx)
		{
			txtcard_no.Text = no_kartu;
			txtcust_name.Text = Nama;
			frmSalesSelf.Default.txtcust_id.Text = id;
			txtPhone.Text = telepon;
		}
		
		public void CmdOk_Click(object sender, EventArgs e)
		{
			if (txtPhone.Text.ToString().Trim() == "" || txtcard_no.Text.ToString().Trim() == "")
			{
				//MsgBox("Member Not Found !!!")
				isi_data("LM-00000000", "ONE TIME CUSTOMER", System.Convert.ToString(0), "10000000", "", "", "0800000000", "", "");
				Module1.Star_Id = "10000000";
			}
			
			if (System.Convert.ToInt32(Module1.RegType) == 0)
			{
				frmSales.Default.txtcard_no.Text = txtcard_no.Text;
				frmSales.Default.txtcust_name.Text = txtcust_name.Text;
				frmSales.Default.txtcust_id.Text = txtcard_no.Text.Replace("LM-", "");
			}
			else
			{
				if (Module1.SecLev >= 3)
				{
					frmSalesSelf.Default.txtcard_no.Text = txtcard_no.Text;
					frmSalesSelf.Default.txtcust_name.Text = txtcust_name.Text;
					frmSalesSelf.Default.txtcust_id.Text = txtcard_no.Text.Replace("LM-", "");
				}
				else
				{
					frmSales.Default.txtcard_no.Text = txtcard_no.Text;
					frmSales.Default.txtcust_name.Text = txtcust_name.Text;
					frmSales.Default.txtcust_id.Text = txtcard_no.Text.Replace("LM-", "");
				}
			}
			
			
			Module1.Star_No = txtcard_no.Text;
			Module1.Star_Nm = txtcust_name.Text;
			Module1.Star_Phone = txtPhone.Text;
			this.Close();
			
		}
		
		public void CmdCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void Label1_Click(object sender, EventArgs e)
		{
			if (Module1.VPing == "ONLINE")
			{
				Module1.NewMember = true;
				this.TopMost = false;
				this.Close();
				MemberRegistration.Default.ShowDialog();
				MemberRegistration.Default.TopMost = true;
				MemberRegistration.Default.txtcust_name.Select();
				MemberRegistration.Default.txtcust_name.SelectionStart = 0;
				MemberRegistration.Default.txtcust_name.Focus();
			}
			else
			{
				MessageBox.Show("Register Status is Offline!!");
			}
		}
		
		public void CmdNav_Click(object sender, EventArgs e)
		{
			frmNum.Default.Text = "NUMBER - MEMBER";
			frmNum.Default.ShowDialog();
			txtPhone.Focus();
		}
	}
}
