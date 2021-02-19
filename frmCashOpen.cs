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
	public partial class frmCashOpen : System.Windows.Forms.Form
	{
		public frmCashOpen()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmCashOpen defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmCashOpen Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmCashOpen();
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
		
		public void _btnNum_0_Click(System.Object sender, System.EventArgs e)
		{
			
			Button btn = (Button) sender;
			
			if (System.Convert.ToInt32(btn.Tag) < 10)
			{
				txtangka.Text = txtangka.Text + btn.Text;
			}
			
			switch (System.Convert.ToInt32(btn.Tag))
			{
				case 10:
					txtangka.Focus();
					System.Windows.Forms.SendKeys.Send("{end}+{backspace}");
					break;
				case 11:
					if (txtangka.Text == "")
					{
						return;
					}
					Module1.getSqldb("insert into cash(Branch_ID, Datetime, Cash_Register_ID, Shift, User_ID, Modal, Cash, " + "Voucher , Other_Voucher, Credit_Card, Debet_Card, Credit_Sales, Entertainment, " + "Deposit , Other_Income, Netto, Discount, Tax, [Returns], No_Sale, Cancel) values " + "('" + Module1.VBranch_ID + "',  convert(varchar(10),getdate(),20), '" + Module1.VReg_ID + "', '" + System.Convert.ToString(Module1.VShift) + "', '" + Module1.VKasir_ID + "', " + System.Convert.ToString(txtangka.Text) + ", 0, " + "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) ", Module1.ConnLocal);
					//If Linked() Then
					//    getSqldb("insert into cash(Branch_ID, Datetime, Cash_Register_ID, Shift, User_ID, Modal, Cash, " & "Voucher , Other_Voucher, Credit_Card, Debet_Card, Credit_Sales, Entertainment, " & "Deposit , Other_Income, Netto, Discount, Tax, [Returns], No_Sale, Cancel) values " & "('" & VBranch_ID & "',  convert(varchar(10),getdate(),20), '" & VReg_ID & "', '" & VShift & "', '" & VKasir_ID & "', " & CDec(txtangka.Text) & ", 0, " & "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) ", ConnServer)
					//End If
					//tanpa cek PING
					if (Module1.VPing == "ONLINE")
					{
						Module1.getSqldb("insert into cash(Branch_ID, Datetime, Cash_Register_ID, Shift, User_ID, Modal, Cash, " + "Voucher , Other_Voucher, Credit_Card, Debet_Card, Credit_Sales, Entertainment, " + "Deposit , Other_Income, Netto, Discount, Tax, [Returns], No_Sale, Cancel) values " + "('" + Module1.VBranch_ID + "',  convert(varchar(10),getdate(),20), '" + Module1.VReg_ID + "', '" + System.Convert.ToString(Module1.VShift) + "', '" + Module1.VKasir_ID + "', " + System.Convert.ToString(txtangka.Text) + ", 0, " + "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) ", Module1.ConnServer);
					}
					
					Module1.VCopen = true;
					Cetak.OpenLaci((byte) 0);
					this.Close();
					break;
				case 12:
					txtangka.Text = "";
					break;
				case 13:
					this.Close();
					break;
			}
			
		}
		
		public void txtangka_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					if (txtangka.Text == "")
					{
						return;
					}
					Module1.getSqldb("insert into cash(Branch_ID, Datetime, Cash_Register_ID, Shift, User_ID, Modal, Cash, " + "Voucher , Other_Voucher, Credit_Card, Debet_Card, Credit_Sales, Entertainment, " + "Deposit , Other_Income, Netto, Discount, Tax, [Returns], No_Sale, Cancel) values " + "('" + Module1.VBranch_ID + "',  convert(varchar(10),getdate(),20), '" + Module1.VReg_ID + "', '" + System.Convert.ToString(Module1.VShift) + "', '" + Module1.VKasir_ID + "', " + System.Convert.ToString(txtangka.Text) + ", 0, " + "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) ", Module1.ConnLocal);
					//If Linked() Then
					//    getSqldb("insert into cash(Branch_ID, Datetime, Cash_Register_ID, Shift, User_ID, Modal, Cash, " & "Voucher , Other_Voucher, Credit_Card, Debet_Card, Credit_Sales, Entertainment, " & "Deposit , Other_Income, Netto, Discount, Tax, [Returns], No_Sale, Cancel) values " & "('" & VBranch_ID & "',  convert(varchar(10),getdate(),20), '" & VReg_ID & "', '" & VShift & "', '" & VKasir_ID & "', " & CDec(txtangka.Text) & ", 0, " & "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) ", ConnServer)
					//End If
					//tanpa cek PING
					if (Module1.VPing == "ONLINE")
					{
						Module1.getSqldb("insert into cash(Branch_ID, Datetime, Cash_Register_ID, Shift, User_ID, Modal, Cash, " + "Voucher , Other_Voucher, Credit_Card, Debet_Card, Credit_Sales, Entertainment, " + "Deposit , Other_Income, Netto, Discount, Tax, [Returns], No_Sale, Cancel) values " + "('" + Module1.VBranch_ID + "',  convert(varchar(10),getdate(),20), '" + Module1.VReg_ID + "', '" + System.Convert.ToString(Module1.VShift) + "', '" + Module1.VKasir_ID + "', " + System.Convert.ToString(txtangka.Text) + ", 0, " + "0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0) ", Module1.ConnServer);
					}
					
					Module1.VCopen = true;
					Cetak.OpenLaci((byte) 0);
					this.Close();
					break;
				case (System.Windows.Forms.Keys) 27:
					this.Close();
					break;
			}
		}
		
		public void frmCashOpen_Load(System.Object sender, System.EventArgs e)
		{
			txtangka.Select();
			txtangka.Focus();
		}
		
		public void txtangka_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
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
