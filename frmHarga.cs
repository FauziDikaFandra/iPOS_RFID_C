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
	public partial class frmHarga
	{
		public frmHarga()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmHarga defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmHarga Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmHarga();
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
		public void cmdangka_Click(System.Object sender, System.EventArgs e)
		{
			frmNum.Default.Text = "NUMBER - HARGA";
			frmNum.Default.Label2.Text = "HARGA";
			frmNum.Default.ShowDialog();
		}
		public void Cmdcancel_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			this.Close();
		}
		public void Cmdok_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			txtprice.Focus();
			System.Windows.Forms.SendKeys.Send("{enter}");
		}
		public void txtprice_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			double Berapa = 0;
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					if (txtprice.Text == "")
					{
						return;
					}
					Berapa = double.Parse(txtprice.Text);
					if (Microsoft.VisualBasic.Strings.Left(txtprice.Text, 2) == "27" && txtprice.Text.Length == 13)
					{
						Berapa = double.Parse(txtprice.Text.Substring(2, 10));
					}
					if (Berapa > 99999998)
					{
						Interaction.MsgBox("Harga yang anda masukkan salah", (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
						txtprice.Focus();
						System.Windows.Forms.SendKeys.Send("{home}+{end}");
						return;
					}
					
					frmSalesSelf.Default.vharga.Text = System.Convert.ToString(Berapa);
					frmSales.Default.vharga.Text = System.Convert.ToString(Berapa);
					Module1.VOK = true;
					this.Close();
					break;
				case (System.Windows.Forms.Keys) 27:
					this.Close();
					frmSalesSelf.Default.txtkode.Text = "";
					frmSales.Default.txtkode.Text = "";
					frmSalesSelf.Default.txtkode.Focus();
					frmSales.Default.txtkode.Focus();
					break;
			}
			if (e.KeyCode == Keys.Enter)
			{
				//Menghilangkan Bunyi Beep
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}
		public void txtprice_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (Strings.Asc(e.KeyChar) != 8)
			{
				if (Strings.Asc(e.KeyChar) < 48 || Strings.Asc(e.KeyChar) > 57)
				{
					e.Handled = true;
				}
			}
		}
		public void txtprice_TextChanged(System.Object sender, System.EventArgs e)
		{
			if (txtprice.Text != "")
			{
				txtprice.Text = System.Convert.ToString((decimal.Parse(txtprice.Text)).ToString("N0"));
				txtprice.SelectionStart = txtprice.TextLength;
			}
		}
		
		public void frmHarga_Load(object sender, EventArgs e)
		{
			txtprice.Select();
			txtprice.Text = "";
			txtprice.Focus();
		}
		
	}
}
