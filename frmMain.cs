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
	public partial class frmMain : System.Windows.Forms.Form
	{
		public frmMain()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmMain defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmMain Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmMain();
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
		private int rowIndex = 0;
		public void _cmdMenu_0_Click(System.Object sender, System.EventArgs e)
		{
			Button btn = (Button) sender;
			DataSet RsCek = new DataSet();
			switch (System.Convert.ToInt32(btn.Tag))
			{
				case 0: //CASH OPEN
					if (_cmdMenu_0.Text == "CASH OPEN")
					{
						frmCashOpen.Default.ShowDialog();
					}
					else
					{
						frmPassword.Default.ShowDialog();
					}
					break;
				case 1: //CLOSE SHIFT
					if (!Module1.Super("2"))
					{
						return;
					}
					Cetak.CekMissPaid();
					Cetak.XRead();
					Module1.SaveLog("Close Shift " + Module1.VSuper_Nm);
					this.Close();
					Module1.LoadClose = true;
					frmLogin.Default.Show();
					break;
				case 2: //CLOSE REGISTER
					if (!Module1.Super("2"))
					{
						return;
					}
					frmSOD.Default.Text = "EOD";
					frmSOD.Default.ShowDialog();
					Cetak.CekMissPaid();
					Cetak.ZReset();
					Module1.SaveLog("Close Register " + Module1.VSuper_Nm);
					_cmdMenu_0_Click(_cmdMenu_9, new System.EventArgs());
					break;
				case 3: //OPEN DRAWER
					if (!Module1.Super("2"))
					{
						return;
					}
					Cetak.OpenLaci((byte) 1);
					Module1.SaveLog("Open Drawer " + Module1.VSuper_Nm);
					break;
				case 4: //SALES
					Module1.VNomor = "";
					Cetak.CDisplay("  SALES", "TRANSACTION ");
					Module1.Star_Id = "10000000";
					Module1.VBonus_Point = (byte) 1;
					if (System.Convert.ToInt32(Module1.RegType) == 0)
					{
						frmSales.Default.Text = "SALES";
						frmSales.Default.txtcard_no.Text = "LM-00000000";
						frmSales.Default.txtcust_name.Text = "ONE TIME CUSTOMER";
						frmSales.Default.txtcust_id.Text = "10000000";
						Module1.Star_No = "LM-00000000";
						Module1.Star_Nm = "ONE TIME CUSTOMER";
						Module1.Star_Phone = "";
						this.Close();
						frmSales.Default.Show();
					}
					else
					{
						if (Module1.SecLev < 3)
						{
							frmSales.Default.Text = "SALES";
							frmSales.Default.txtcard_no.Text = "LM-00000000";
							frmSales.Default.txtcust_name.Text = "ONE TIME CUSTOMER";
							frmSales.Default.txtcust_id.Text = "10000000";
							Module1.Star_No = "LM-00000000";
							Module1.Star_Nm = "ONE TIME CUSTOMER";
							Module1.Star_Phone = "";
							this.Close();
							frmSales.Default.Show();
						}
						else
						{
							frmSalesSelf.Default.Text = "SALES";
							frmSalesSelf.Default.txtcard_no.Text = "LM-00000000";
							frmSalesSelf.Default.txtcust_name.Text = "ONE TIME CUSTOMER";
							frmSalesSelf.Default.txtcust_id.Text = "10000000";
							Module1.Star_No = "LM-00000000";
							Module1.Star_Nm = "ONE TIME CUSTOMER";
							Module1.Star_Phone = "";
							this.Close();
							frmSalesSelf.Default.Show();
						}
					}
					break;
					
					
				case 5: // REFUND
					if (!Module1.Super("1"))
					{
						return;
					}
					Module1.VNomor = "";
					Cetak.CDisplay(" REFUND", "TRANSACTION");
					Module1.SaveLog("Refund Transaction " + Module1.VSuper_Nm);
					//frmCard.Text = "REFUND"
					//frmCard.ShowDialog()
					
					//tanpa pilih member
					Module1.Star_Id = "10000000";
					Module1.VBonus_Point = (byte) 1;
					frmSales.Default.Text = "REFUND";
					frmSales.Default.txtcard_no.Text = "LM-00000000";
					frmSales.Default.txtcust_name.Text = "ONE TIME CUSTOMER";
					frmSales.Default.txtcust_id.Text = "10000000";
					Module1.Star_No = "LM-00000000";
					Module1.Star_Nm = "ONE TIME CUSTOMER";
					Module1.Star_Phone = "";
					this.Close();
					frmSales.Default.Show();
					break;
				case 6: //REPRINT
					if (!Module1.Super("1"))
					{
						return;
					}
					Cetak.CDisplay("REPRINT", "TRANSACTION");
					frmNum.Default.Text = "REPRINT";
					frmNum.Default.Label2.Text = "TRANS";
					frmNum.Default.ShowDialog();
					break;
				case 7: //RELEASE
					Cetak.CDisplay("RELEASE", "TRANSACTION");
					frmNum.Default.Text = "RELEASE";
					frmNum.Default.Label2.Text = "TRANS";
					frmNum.Default.ShowDialog();
					break;
				case 8: //CANCEL
					if (!Module1.Super("2"))
					{
						return;
					}
					Cetak.CDisplay(" CANCEL", "TRANSACTION");
					frmNum.Default.Text = "CANCEL";
					frmNum.Default.Label2.Text = "TRANS";
					frmNum.Default.ShowDialog();
					break;
				case 9: //EXIT
					Cetak.CDisplay("", "");
					//frmSOD.Text = "EOD"
					//frmSOD.ShowDialog()
					//Application.Exit()
					this.Close();
					frmLogin.Default.Show();
					break;
			}
		}
		public void frmMain_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			Module1.Star_Nm = "";
			Module1.Star_Pt = 0;
			Module1.Star_Id = "";
			Module1.Star_Freq = "";
			Module1.Star_Omz = "";
			Timer1_Tick(Timer1, new System.EventArgs());
			
			Button btn = null;
			foreach (Control ctrl in Frame2.Controls)
			{
				if (ctrl is Button)
				{
					btn = (Button) ctrl;
					if (System.Convert.ToInt32(btn.Tag) > 0 && System.Convert.ToInt32(btn.Tag) < 9)
					{
						btn.Enabled = Module1.VCopen;
					}
				}
			}
			
			if (!Module1.VCopen)
			{
				_cmdMenu_0.Text = "CASH OPEN";
				_cmdMenu_0.Focus();
			}
			else
			{
				_cmdMenu_0.Text = "CHANGE PASSWORD";
				_cmdMenu_4.Focus();
			}
			
			lblbranch.Text = Module1.Tulis[10];
			lblreg.Text = "REGISTER # " + Module1.VReg_ID + " - " + System.Convert.ToString(Module1.VShift);
			lblkasir.Text = Module1.VKasir_ID + " - " + Module1.VKasir_Nm;
			if (Module1.VPing == "ONLINE")
			{
				lblline.ForeColor = Color.Yellow;
			}
			else
			{
				lblline.ForeColor = Color.Red;
			}
			lblline.Text = Module1.VPing;
			txtinfo.Text = Module1.Tulis[16];
			
			_cmdMenu_9.Enabled = false;
			_cmdMenu_1.Enabled = false;
			_cmdMenu_2.Enabled = false;
			
			
			DataSet dsCek = new DataSet();
			dsCek = Module1.getSqldb("SELECT cast(right(transaction_number,4)as int) as No, Net_amount as Nilai, transaction_number " + "From Sales_Transactions WHERE (Status = '01') and CONVERT(varchar(10), Transaction_Date, 102) = '" + Strings.Format(Module1.GetSrvDate(), "yyyy.MM.dd") + "' and cash_register_id ='" + Module1.VReg_ID + "'", Module1.ConnLocal);
			
			if (dsCek.Tables[0].Rows.Count == 0)
			{
				_cmdMenu_9.Enabled = true;
				_cmdMenu_1.Enabled = Module1.VCopen;
				_cmdMenu_2.Enabled = Module1.VCopen;
			}
			else
			{
				DataGridView1.DataSource = dsCek.Tables[0];
				DataGridView1.Refresh();
				DataGridView1.Columns["No"].Width = System.Convert.ToInt32("50");
				DataGridView1.Columns["Nilai"].DefaultCellStyle.Format = "N0";
				DataGridView1.Columns["Nilai"].Width = System.Convert.ToInt32("100");
				DataGridView1.Columns["transaction_number"].Visible = false;
				DataGridView1.Font = new Font("MS Sans Serif", 12, FontStyle.Regular);
			}
			
			
		}
		public void CancelReload()
		{
			DataGridView1.DataSource = null;
			DataSet dsCek = new DataSet();
			dsCek = Module1.getSqldb("SELECT cast(right(transaction_number,4)as int) as No, Net_amount as Nilai, transaction_number " + "From Sales_Transactions WHERE (Status = '01') and CONVERT(varchar(10), Transaction_Date, 102) = '" + Strings.Format(Module1.GetSrvDate(), "yyyy.MM.dd") + "' and cash_register_id ='" + Module1.VReg_ID + "'", Module1.ConnLocal);
			
			if (dsCek.Tables[0].Rows.Count == 0)
			{
				_cmdMenu_9.Enabled = true;
				_cmdMenu_1.Enabled = Module1.VCopen;
				_cmdMenu_2.Enabled = Module1.VCopen;
			}
			else
			{
				DataGridView1.DataSource = dsCek.Tables[0];
				DataGridView1.Refresh();
				DataGridView1.Columns["No"].Width = System.Convert.ToInt32("50");
				DataGridView1.Columns["Nilai"].DefaultCellStyle.Format = "N0";
				DataGridView1.Columns["Nilai"].Width = System.Convert.ToInt32("100");
				DataGridView1.Columns["transaction_number"].Visible = false;
				DataGridView1.Font = new Font("MS Sans Serif", 12, FontStyle.Regular);
			}
		}
		public void Timer1_Tick(System.Object eventSender, System.EventArgs eventArgs)
		{
			lbltgl.Text = Strings.Format(DateTime.Now, "dddd, d MMM yyyy");
			lbljam.Text = Strings.Format(DateTime.Now, "hh:mm:ss");
		}
		public void frmMain_Load(System.Object eventSender, System.EventArgs eventArgs)
		{
			this.Text = "POINT OF SALES V." + this.GetType().Assembly.GetName().Version.ToString();
			Cetak.CDisplay("  ", "*** LAKON ***");
		}
		public void Label1_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (Module1.VPing == "ONLINE")
			{
				string Dbs = "";
				string Svr = "";
				
				Dbs = Module1.ReadIni("Server", "DatabaseName");
				Svr = "[" + Module1.VSvr + "]";
				
				if (!Module1.Super("2"))
				{
					return;
				}
				Module1.getSqldb("exec spp_DownLoadOthers '" + Svr + "','" + Dbs + "'", Module1.ConnLocal);
				Module1.getSqldb("exec spp_DownLoadRFID '" + Svr + "','" + Dbs + "'", Module1.ConnLocal);
				Module1.SaveLog("Download Promo " + Module1.VSuper_Nm);
				Interaction.MsgBox("Download Promo Selesai", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
			}
			else
			{
				MessageBox.Show("Register Status is Offline!!");
			}
			
		}
		public void txtinfo_Enter(System.Object eventSender, System.EventArgs eventArgs)
		{
			_cmdMenu_4.Focus();
		}
		
		public void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			DataSet RsCari = new DataSet();
			Module1.VNomor = System.Convert.ToString(DataGridView1[2, e.RowIndex].Value);
			
			RsCari = Module1.getSqldb("select status, flag_return from sales_transactions where transaction_number ='" + Module1.VNomor + "'", Module1.ConnLocal);
			
			if (RsCari.Tables[0].Rows.Count == 0)
			{
				Interaction.MsgBox("Nomor transaksi tidak valid", (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				return;
			}
			if (System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["Status"]) == 01)
			{
				if (System.Convert.ToInt32(Module1.RegType) == 0)
				{
					frmSales.Default.Text = System.Convert.ToString((System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["flag_return"]) == 1) ? "REFUND" : "SALES");
					Cetak.CDisplay(frmSales.Default.Text, "TRANSACTION");
					frmSales.Default.ViewRelease(Module1.VNomor);
					frmSales.Default.Show();
				}
				else
				{
					if (Module1.SecLev < 3)
					{
						frmSales.Default.Text = System.Convert.ToString((System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["flag_return"]) == 1) ? "REFUND" : "SALES");
						Cetak.CDisplay(frmSales.Default.Text, "TRANSACTION");
						frmSales.Default.ViewRelease(Module1.VNomor);
						frmSales.Default.Show();
					}
					else
					{
						frmSalesSelf.Default.Text = System.Convert.ToString((System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["flag_return"]) == 1) ? "REFUND" : "SALES");
						Cetak.CDisplay(frmSalesSelf.Default.Text, "TRANSACTION");
						frmSalesSelf.Default.ViewRelease(Module1.VNomor);
						frmSalesSelf.Default.Show();
					}
				}
				
				
				this.Close();
			}
			
		}
		
		public void DataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{
				//Me.DataGridView1.Rows(e.RowIndex).Selected = True
				this.rowIndex = e.RowIndex;
				//Me.DataGridView1.CurrentCell = Me.DataGridView1.Rows(e.RowIndex).Cells(2)
				this.ContextMenuStrip1.Show(this.DataGridView1, e.Location);
				ContextMenuStrip1.Show(Cursor.Position);
			}
		}
		
		public void ContextMenuStrip1_Click(object sender, EventArgs e)
		{
			if (DataGridView1.RowCount > 0)
			{
				
				Cetak.CDisplay(" CANCEL", "TRANSACTION");
				DataSet RsCari = new DataSet();
				int cnt = 0;
				foreach (DataGridViewRow ro in DataGridView1.SelectedRows)
				{
					cnt++;
				}
				string[] Nomor = new string[cnt];
				cnt = 0;
				foreach (DataGridViewRow ro in DataGridView1.SelectedRows)
				{
					Module1.VNomor = Module1.VBranch_ID + Module1.VReg_ID + "-" + Strings.Format(Module1.GetSrvDate(), "ddMMyyyy") + "-" + Microsoft.VisualBasic.Strings.Right("000" + System.Convert.ToString(DataGridView1[2, ro.Index].Value.ToString().Trim()), 4);
					Nomor[cnt] = Module1.VNomor;
					cnt++;
				}
				if (!Module1.Super("2"))
				{
					return;
				}
				for (int x = 0; x <= Nomor.Count() - 1; x++)
				{
					RsCari.Clear();
					RsCari = Module1.getSqldb("select status, flag_return from sales_transactions where transaction_number ='" + Nomor[x] + "'", Module1.ConnLocal);
					if (System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["Status"]) == 01)
					{
						Module1.getSqldb("Update sales_transactions set net_price=0, net_amount=0, status='02' where transaction_number='" + Nomor[x] + "'", Module1.ConnLocal);
						Module1.getSqldb("Delete from paid where transaction_number='" + Nomor[x] + "'", Module1.ConnLocal);
						Cetak.CetakPesan("CANCEL", Nomor[x]);
						Module1.SaveLog("Cancel Transaction " + Nomor[x] + " " + Module1.VSuper_Nm);
					}
				}
				CancelReload();
			}
		}
		
		public void Label3_Click(object sender, EventArgs e)
		{
			if (Module1.VPing == "ONLINE")
			{
				MemberRegistration.Default.ShowDialog();
			}
			else
			{
				MessageBox.Show("Register Status is Offline!!");
			}
		}
		
		public void Label4_Click(object sender, EventArgs e)
		{
			if (Module1.VPing == "ONLINE")
			{
				frmMemberTrans.Default.ShowDialog();
			}
			else
			{
				MessageBox.Show("Register Status is Offline!!");
			}
		}
		
		public void lblMember_MouseHover(object sender, EventArgs e)
		{
			lblMember.ForeColor = Color.Blue;
		}
		
		public void lblMemberTran_MouseHover(object sender, EventArgs e)
		{
			lblMemberTran.ForeColor = Color.Blue;
		}
		
		public void lblMember_MouseLeave(object sender, EventArgs e)
		{
			lblMember.ForeColor = Color.CornflowerBlue;
		}
		
		public void lblMemberTran_MouseLeave(object sender, EventArgs e)
		{
			lblMemberTran.ForeColor = Color.CornflowerBlue;
		}
		
	}
}
