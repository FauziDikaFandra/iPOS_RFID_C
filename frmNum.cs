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
	public partial class frmNum : System.Windows.Forms.Form
	{
		public frmNum()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmNum defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmNum Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmNum();
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
			if (this.Text == "NUMBER - VIEW" && System.Convert.ToInt32(btn.Tag) == 10)
			{
				return;
			}
			if (System.Convert.ToInt32(btn.Tag) < 11)
			{
				txtno.Text = txtno.Text + btn.Text;
			}
			txtno.SelectionStart = txtno.Text.Length;
			DataSet RsCari = new DataSet();
			switch (System.Convert.ToInt32(btn.Tag))
			{
				case 11: //Enter
					if (this.Text == "NUMBER - MEMBER")
					{
						InputMember.Default.txtPhone.Text = txtno.Text;
						this.Close();
						InputMember.Default.txtPhone.Focus();
						InputMember.Default.SubView();
						return;
					}
					
					if (this.Text == "NUMBER - VIEW")
					{
						frmView.Default.txtkode.Text = txtno.Text;
						this.Close();
						frmView.Default.txtkode.Focus();
						frmView.Default.SubNum();
						return;
					}
					
					if (this.Text == "NUMBER - HARGA")
					{
						frmHarga.Default.txtprice.Text = txtno.Text;
						this.Close();
						frmHarga.Default.txtprice.Focus();
						//endKeys "{enter}"
						return;
					}
					
					if (this.Text == "NUMBER - ID")
					{
						frmkaryawan.Default.txtid.Text = txtno.Text;
						this.Close();
						frmkaryawan.Default.txtid.Focus();
						//endKeys "{enter}"
						return;
					}
					
					if (this.Text == "NUMBER - SALES")
					{
						frmSales.Default.txtkode.Text = txtno.Text;
						this.Close();
						frmSales.Default.txtkode.Focus();
						if (VB.Strings.Right(frmSales.Default.txtkode.Text, 1) == "*")
						{
							System.Windows.Forms.SendKeys.Send("{end}");
						}
						else
						{
							System.Windows.Forms.SendKeys.Send("{enter}");
						}
						return;
					}
					
					Module1.VNomor = Module1.VBranch_ID + Module1.VReg_ID + "-" + Strings.Format(Module1.GetSrvDate(), "ddMMyyyy") + "-" + VB.Strings.Right("000" + txtno.Text, 4);
					
					RsCari = Module1.getSqldb("select status, flag_return from sales_transactions where transaction_number ='" + Module1.VNomor + "'", Module1.ConnLocal);
					
					if (RsCari.Tables[0].Rows.Count == 0)
					{
						Interaction.MsgBox("Nomor transaksi tidak valid", (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
						goto xx;
					}
					
					switch (this.Text)
					{
						case "REPRINT":
							if (System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["Status"]) == 00)
							{
								Cetak.CetakStruk("REPRINT", Module1.VNomor);
								Module1.SaveLog("Reprint Transaction " + Module1.VNomor + " " + Module1.VSuper_Nm);
								goto xx;
							}
							break;
						case "RELEASE":
							//If RsCari.Tables(0).Rows(0).Item("Status") = "01" Then
							//    frmSalesSelf.Text = IIf(RsCari.Tables(0).Rows(0).Item("flag_return") = "1", "REFUND", "SALES")
							//    Call CDisplay(frmSalesSelf.Text, "TRANSACTION")
							//    Me.Close()
							//    frmSalesSelf.ViewRelease(VNomor)
							//    frmSalesSelf.Show()
							//    frmMain.Close()
							//    GoTo xx
							//End If
							if (System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["Status"]) == 01)
							{
								frmSales.Default.Text = System.Convert.ToString((System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["flag_return"]) == 1) ? "REFUND" : "SALES");
								Cetak.CDisplay(frmSales.Default.Text, "TRANSACTION");
								this.Close();
								frmSales.Default.ViewRelease(Module1.VNomor);
								frmSales.Default.Show();
								frmMain.Default.Close();
								goto xx;
							}
							break;
						case "CANCEL":
							if (System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["Status"]) == 01)
							{
								Module1.getSqldb("Update sales_transactions set net_price=0, net_amount=0, status='02' where transaction_number='" + Module1.VNomor + "'", Module1.ConnLocal);
								Module1.getSqldb("Delete from paid where transaction_number='" + Module1.VNomor + "'", Module1.ConnLocal);
								Cetak.CetakPesan("CANCEL", Module1.VNomor);
								Module1.SaveLog("Cancel Transaction " + Module1.VNomor + " " + Module1.VSuper_Nm);
								frmMain.Default.CancelReload();
								goto xx;
							}
							break;
					}
					Interaction.MsgBox("Nomor transaksi tidak valid", (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
					
xx:
					RsCari.Clear();
					RsCari = null;
					this.Close();
					Module1.VNomor = "";
					break;
				case 12: //Backspace
					txtno.Focus();
					System.Windows.Forms.SendKeys.Send("{end}+{backspace}");
					break;
				case 13: //Clear
					txtno.Text = "";
					break;
				case 14: //Close
					this.Close();
					break;
			}
		}
		public void frmNum_Load(System.Object sender, System.EventArgs e)
		{
			txtno.Select();
			txtno.Focus();
			txtno.Clear();
			txtpassword.Clear();
			this.TopMost = true;
		}
		public void txtno_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					_btnNum_0_Click(_btnNum_11, new System.EventArgs());
					break;
				case (System.Windows.Forms.Keys) 27:
					this.Close();
					break;
			}
		}
		
	}
}
