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

using VB = Microsoft.VisualBasic;
using iPOS;

namespace iPOS
{
	public partial class frmDisc
	{
		public frmDisc()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmDisc defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmDisc Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmDisc();
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
		private void cmdup_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			List1.SelectedIndex = System.Convert.ToInt32(List1.SelectedIndex > 0 ? List1.SelectedIndex - 1 : 0);
		}
		private void cmddown_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			List1.SelectedIndex = System.Convert.ToInt32(List1.SelectedIndex < List1.Items.Count - 1 ? List1.SelectedIndex + 1 : List1.Items.Count - 1);
		}
		public void Cmdok_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			DataSet RsV = new DataSet();
			string aa = "";
			string bb = "";
			aa = "";
			int cc = 0;
			switch (lblmsg.Text)
			{
				case "DISCOUNT":
					
					if (frmSales.Default.vdisc1.Text == "0")
					{
						frmSales.Default.vdisc1.Text = List1.Text;
					}
					else
					{
						frmSales.Default.vdisc2.Text = List1.Text;
					}
					break;
					
				case "VALIDASI":
					if (List1.Text == "TOTAL")
					{
						Cetak.CetakValid(Module1.VNomor, "Total Rp. " + (decimal.Parse(frmSales.Default.vgtotal.Text)).ToString("N0"), "");
						this.Close();
						return;
					}
					
					
					RsV = Module1.getSqldb("select sd.* from sales_transaction_details sd inner join item_master it " +
						"on sd.plu=it.plu where transaction_number='" + Module1.VNomor + "' and brand='" + Module1.UbahChar(List1.Text) + "'", Module1.ConnLocal);
					if (RsV.Tables[0].Rows.Count > 0)
					{
						foreach (DataRow ro in RsV.Tables[0].Rows)
						{
							aa = aa + Constants.vbNewLine + System.Convert.ToString(ro["plu"]) + " " + System.Convert.ToString(ro["Qty"]) + "X" + (System.Convert.ToDecimal(ro["price"])).ToString("N0");
							if (System.Convert.ToInt32(ro["Discount_Percentage"]) > 0)
							{
								aa = aa + Constants.vbNewLine + "Disc." + System.Convert.ToString(ro["Discount_Percentage"]) + "% = " + (System.Convert.ToDecimal(ro["Discount_Amount"])).ToString("N0");
							}
							if (System.Convert.ToInt32(ro["ExtraDisc_pct"]) > 0)
							{
								aa = aa + Constants.vbNewLine + "Disc." + System.Convert.ToString(ro["ExtraDisc_pct"]) + "% = " + (System.Convert.ToDecimal(ro["ExtraDisc_amt"])).ToString("N0");
							}
							aa = aa + Constants.vbNewLine + System.Convert.ToString(ro["item_description"]) + " Rp. " + (System.Convert.ToDecimal(ro["Net_Price"])).ToString("N0");
							cc = cc + System.Convert.ToInt32(ro["Net_Price"]);
						}
					}
					
					if (RsV.Tables[0].Rows.Count > 0)
					{
						foreach (DataRow ro in RsV.Tables[0].Rows)
						{
							bb = Constants.vbNewLine + System.Convert.ToString(ro["flag_paket_discount"]) + "/" + VB.Strings.Left(Siapa_SPG(ro["flag_paket_discount"]), 10);
							bb = Constants.vbNewLine + "Total " + List1.Text + " Rp. " + (cc).ToString("N0") + bb;
							Cetak.CetakValid(Module1.VNomor, aa, bb);
							Module1.SaveLog("Validasi Kasir : " + Module1.VKasir_ID + "/" + Module1.VKasir_Nm + "SPG : " + System.Convert.ToString(ro["flag_paket_discount"]) + "/" + VB.Strings.Left(Siapa_SPG(ro["flag_paket_discount"]), 10));
							break;
						}
					}
					RsV.Clear();
					RsV = null;
					break;
				case "VOUCHER":
					frmPayment.Default.txtno_voc.Text = List1.Text + "-";
					break;
			}
			
			this.Close();
		}
		private string Siapa_SPG(object kode)
		{
			string returnValue = "";
			DataSet RsCari = new DataSet();
			RsCari = Module1.getSqldb("select spg_id, spg_name from spg where spg_id = '" + Strings.Trim(System.Convert.ToString(kode)) + "'", Module1.ConnLocal);
			returnValue = System.Convert.ToString((RsCari.Tables[0].Rows.Count > 0) ? (RsCari.Tables[0].Rows[0]["spg_name"]) : "");
			RsCari.Clear();
			RsCari = null;
			return returnValue;
		}
		public void Cmdcancel_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			this.Close();
		}
		public void frmDisc_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			DataSet RsCari = new DataSet();
			List1.Items.Clear();
			
			switch (lblmsg.Text)
			{
				case "DISCOUNT":
					RsCari = Module1.getSqldb("select disc_1,disc_2,disc_3,disc_4,disc_5,disc_6,disc_7 from cash_register where branch_id = '" + Module1.VBranch_ID + "' and cash_register_id = '" + Module1.VReg_ID + "'", Module1.ConnLocal);
					
					List1.Items.Add((System.Convert.ToDecimal(RsCari.Tables[0].Rows[0]["disc_1"])).ToString("N0"));
					List1.Items.Add((System.Convert.ToDecimal(RsCari.Tables[0].Rows[0]["disc_2"])).ToString("N0"));
					List1.Items.Add((System.Convert.ToDecimal(RsCari.Tables[0].Rows[0]["disc_3"])).ToString("N0"));
					List1.Items.Add((System.Convert.ToDecimal(RsCari.Tables[0].Rows[0]["disc_4"])).ToString("N0"));
					List1.Items.Add((System.Convert.ToDecimal(RsCari.Tables[0].Rows[0]["disc_5"])).ToString("N0"));
					List1.Items.Add((System.Convert.ToDecimal(RsCari.Tables[0].Rows[0]["disc_6"])).ToString("N0"));
					List1.Items.Add((System.Convert.ToDecimal(RsCari.Tables[0].Rows[0]["disc_7"])).ToString("N0"));
					break;
					
				case "VALIDASI":
					RsCari = Module1.getSqldb("select distinct brand from sales_transaction_details sd inner join item_master it " + "on sd.plu=it.plu where transaction_number='" + Module1.VNomor + "'", Module1.ConnLocal);
					
					List1.Items.Add("TOTAL");
					if (RsCari.Tables[0].Rows.Count > 0)
					{
						foreach (DataRow ro in RsCari.Tables[0].Rows)
						{
							List1.Items.Add(ro["Brand"]);
						}
					}
					break;
				case "VOUCHER":
					List1.Items.Add("AA");
					List1.Items.Add("AF");
					List1.Items.Add("AM");
					List1.Items.Add("AS");
					List1.Items.Add("BG");
					List1.Items.Add("BQ");
					List1.Items.Add("BR");
					List1.Items.Add("BS");
					List1.Items.Add("BW");
					List1.Items.Add("BY");
					List1.Items.Add("CB");
					List1.Items.Add("CJ");
					List1.Items.Add("CK");
					List1.Items.Add("CM");
					List1.Items.Add("CN");
					List1.Items.Add("CY");
					List1.Items.Add("DB");
					List1.Items.Add("DE");
					List1.Items.Add("DH");
					List1.Items.Add("DK");
					List1.Items.Add("DN");
					List1.Items.Add("DP");
					List1.Items.Add("ZA");
					List1.Items.Add("ZB");
					List1.Items.Add("ZR");
					List1.SelectedIndex = 0;
					return;
			}
			
			RsCari.Clear();
			RsCari = null;
			List1.SelectedIndex = 0;
		}
		public void List1_KeyDown(System.Object eventSender, System.Windows.Forms.KeyEventArgs eventArgs)
		{
			short KeyCode = (short) eventArgs.KeyCode;
			//short Shift = (short) (eventArgs.KeyData / 0x10000);
			switch (KeyCode)
			{
				case (short) 13:
					Cmdok_Click(cmdOk, new System.EventArgs());
					break;
				case (short) 27:
					Cmdcancel_Click(cmdCancel, new System.EventArgs());
					break;
			}
		}
		
	}
}
