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
using Microsoft.VisualBasic.PowerPacks;
using iPOS;

namespace iPOS
{
	public partial class frmCard : System.Windows.Forms.Form
	{
		public frmCard()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmCard defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmCard Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmCard();
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
		public void Cmdcancel_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			this.Close();
		}
		public void Cmdok_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (txtcard_no.Text == "")
			{
				isi_data("CM000-00000", "ONE TIME CUSTOMER", System.Convert.ToString(0), "100000", "", "", "", "", "");
				Module1.Star_Id = "100000";
				return;
			}
			
			if (txtcard_opt.Text != "")
			{
				optKeyDown13();
			}
			
			Module1.VBonus_Point = (byte) 1;
			frmSalesSelf.Default.Text = this.Text;
			
			frmSalesSelf.Default.txtcust_id.Text = txtcust_id.Text;
			Module1.Star_No = txtcard_no.Text;
			Module1.Star_Nm = txtcust_name.Text;
			Module1.Star_Phone = txtno_telp.Text;
			
			if (txtcard_no.Text != "CM000-00000")
			{
				Cek_Bonus_Point();
				Cetak.CDisplay(txtcard_no.Text.ToUpper(), VB.Strings.Left(txtcust_name.Text, 20));
			}
			
			this.Close();
			frmMain.Default.Close();
			frmSalesSelf.Default.Show();
		}
		private void isi_data(string no_kartu, string Nama, string Point, string id, string freq, string omz, string telepon, string PointEx, string PeriodEx)
		{
			txtcard_no.Text = no_kartu;
			txtcust_name.Text = Nama;
			txtpoint.Text = Point;
			txtcust_id.Text = id;
			txtfreq.Text = freq;
			if (omz.ToString().Trim() == "")
			{
				txtomz.Text = "";
			}
			else
			{
				txtomz.Text = System.Convert.ToString((decimal.Parse(omz)).ToString("N0"));
			}
			txtno_telp.Text = telepon;
			txtexprPoint.Text = PointEx;
			if (string.Compare(Point, PointEx) <= 0)
			{
				txtexprPoint.Text = System.Convert.ToString(0);
			}
			if (omz.ToString().Trim() == "")
			{
				txtPeriod.Text = "";
			}
			else
			{
				txtPeriod.Text = Strings.Format(DateTime.Parse(PeriodEx), "dd-MMM-yyyy");
			}
		}
		private void Cek_Bonus_Point()
		{
			DataSet RsPoint = new DataSet();
			byte Hari = 0;
			
			//Hari = (DateAndTime.Weekday(Module1.GetSrvDate()) == 1) ? 7 : (DateAndTime.Weekday(Module1.GetSrvDate()) - 1);
			
			//RsPoint = Module1.getSqldb("select isnull(point,0) as point, substring(activeday," + System.Convert.ToString(Hari) + ",1) as act_day " + "from cust_param_bonus where jenis_kartu='CM' and status_active='1' and GETDATE() between Start and Finish and substring(activeday," + System.Convert.ToString(Hari) + ",1)='1'", Module1.ConnLocal);
			//if (RsPoint.Tables[0].Rows.Count > 0)
			//{
			//	Module1.VBonus_Point = (System.Convert.ToInt32(Module1.VBonus_Point) < System.Convert.ToInt32(RsPoint.Tables[0].Rows[0]["Point"]))) ? (RsPoint.Tables[0].Rows[0]["Point"]) : System.Convert.ToInt32(Module1.VBonus_Point);
			//}
		}
		public void cmdok_KeyDown(System.Object eventSender, System.Windows.Forms.KeyEventArgs eventArgs)
		{
			short KeyCode = (short) eventArgs.KeyCode;
			//short Shift = (short) (eventArgs.KeyData / 0x10000);
			if (KeyCode == 27)
			{
				this.Close();
			}
		}
		public void frmCard_Load(System.Object eventSender, System.EventArgs eventArgs)
		{
			isi_data("", "", "", "", "", "", "", "", "");
			Module1.VIsSSC = false;
			Module1.VIsKKG = false;
			txtcard_no.Select();
			txtcard_no.Focus();
		}
		public void Timer1_Tick(System.Object eventSender, System.EventArgs eventArgs)
		{
			lblmsg.ForeColor = System.Drawing.ColorTranslator.FromOle(System.Convert.ToInt32((System.Drawing.ColorTranslator.ToOle(lblmsg.ForeColor) == System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue)) ? (System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow)) : (System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Blue))));
			if (txtcard_no.Text.Length != 11)
			{
				txtcard_no.Text = "";
			}
		}
		public void txtcard_no_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					Shape1.BackColor = System.Drawing.Color.White;
					txtcard_no.Text = txtcard_no.Text.ToUpper();
					if (VB.Strings.Left(txtcard_no.Text, 2) != "CM")
					{
						isi_data("CM000-00000", "ONE TIME CUSTOMER", System.Convert.ToString(0), "100000", "", "", "", "", "");
						Module1.Star_Id = "100000";
						CmdOk.Focus();
						goto _1;
					}
					
					//If Linked() Then
					//    getSqldb("update Card set Card_Status = 'A' where Card_Nr = '" & txtcard_no.Text & "' and Card_Status = 'D'", ConnServer)
					//Else
					//    getSqldb("update Card set Card_Status = 'A' where Card_Nr = '" & txtcard_no.Text & "' and Card_Status = 'D'", ConnLocal)
					//End If
					
					//tanpa cek PING
					if (Module1.VPing == "ONLINE")
					{
						Module1.getSqldb("update Card set Card_Status = 'A' where Card_Nr = '" + txtcard_no.Text + "' and Card_Status = 'D'", Module1.ConnServer);
					}
					else
					{
						Module1.getSqldb("update Card set Card_Status = 'A' where Card_Nr = '" + txtcard_no.Text + "' and Card_Status = 'D'", Module1.ConnLocal);
					}
					Point.MySTAR(txtcard_no.Text);
					if (Module1.Star_Id == "100000")
					{
						isi_data("CM000-00000", "ONE TIME CUSTOMER", System.Convert.ToString(0), "100000", "", "", "", "", "");
						Module1.Star_Id = "100000";
					}
					else
					{
						isi_data(txtcard_no.Text, Module1.Star_Nm, System.Convert.ToString(Module1.Star_Pt), Module1.Star_Id, Module1.Star_Freq, Module1.Star_Omz, "", Module1.Exp_Point, Module1.Expired_Date);
						//If Linked() And Star_updsts = 0 Then
						//tanpa cek PING
						if (Module1.VPing == "ONLINE" && Module1.Star_updsts == 0)
						{
							Cetak.CDisplay(Module1.Star_Phone, VB.Strings.Left(Module1.Star_Email, 20));
							Shape1.BackColor = System.Drawing.Color.Blue;
							Module1.Star_No = txtcard_no.Text;
							
							if (Interaction.MsgBox("Apakah Customer ingin mengupdate data?", (int) MsgBoxStyle.YesNo + MsgBoxStyle.OkOnly, "Oops..") == MsgBoxResult.Yes)
							{
								Cetak.CetakData();
							}
						}
						if (txtcard_no.Text.Substring(0, 5) == "CM999" && Module1.Linked())
						{
							if (!Information.IsNumeric(Module1.Star_Ext1))
							{
							}
							else
							{
								if (double.Parse(Module1.Star_Ext1) != 0)
								{
									MessageBox.Show("Sisa potongan karyawan anda senilai Rp." + Strings.FormatNumber(Module1.Star_Ext1, 0) + " !!!");
								}
							}
						}
					}
					txtcard_opt.Focus();
					break;
				case (System.Windows.Forms.Keys) 27:
					this.Close();
					break;
			}
_1:
			if (e.KeyCode == Keys.Enter)
			{
				//Menghilangkan Bunyi Beep
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}
		public void txtcard_opt_Enter(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (txtcard_no.Text == "CM000-00000")
			{
				CmdOk.Focus();
			}
		}
		public void optKeyDown13()
		{
			DataSet RsCari = new DataSet();
			if (VB.Strings.Left(txtcard_opt.Text, 2) == "CM" || txtcard_opt.Text.Length < 3 || txtcard_opt.Text.Length == 13)
			{
				txtcard_opt.Text = "";
			}
			if (txtcard_no.Text == "CM000-00000" || txtcard_opt.Text == "")
			{
				CmdOk.Focus();
				return;
			}
			
			Module1.StrSQL = "select * from card_promotion cp inner join card_promotion_name cn on cp.card_promo_id = cn.card_promo_id " + "where card_nr='" + txtcard_no.Text + "' and card_nr_promo = '" + txtcard_opt.Text + "'";
			
			//If Linked() Then
			//    getSqldb(StrSQL, ConnServer)
			//Else
			//    getSqldb(StrSQL, ConnLocal)
			//End If
			//tanpa cek PING
			if (Module1.VPing == "ONLINE")
			{
				Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
			}
			else
			{
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
			}
			if (RsCari.Tables[0].Rows.Count > 0)
			{
				if ((string) (RsCari.Tables[0].Rows[0]["card_promo_id"]) == "CPN001")
				{
					if (System.Convert.ToInt32(Module1.GetSrvDate()) >= System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["start_promo_date"]) && System.Convert.ToInt32(Module1.GetSrvDate()) <= System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["end_promo_date"]))
					{
						//Promo SSC hanya untuk weekday saja
						//if ((RsCari.Tables[0].Rows[0]["card_promo_id"] == "CPN001" && DateAndTime.Weekday(Module1.GetSrvDate()) == 6) || (RsCari.Tables[0].Rows[0]["card_promo_id"] == "CPN001" && DateAndTime.Weekday(Module1.GetSrvDate()) == 7) || (RsCari.Tables[0].Rows[0]["card_promo_id"] == "CPN001" && DateAndTime.Weekday(Module1.GetSrvDate()) == 1))
						//{
						//	Interaction.MsgBox("Promo hanya berlaku weekday (Senin-Kamis)", (int) MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Oops..");
						//	Module1.VBonus_Point = (byte) 1;
						//}
						//else
						//{
						//	Module1.VBonus_Point = System.Convert.ToByte(RsCari.Tables[0].Rows[0]["point_bonus"]);
						//}
						//Module1.VIsSSC = true;
					}
					else
					{
						Module1.VBonus_Point = (byte) 1;
					}
					Interaction.MsgBox("Bonus Point = " + System.Convert.ToString(Module1.VBonus_Point), (int) MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Oops..");
					Cmdok_Click(CmdOk, new System.EventArgs());
					return;
				}
				else if ((string) (RsCari.Tables[0].Rows[0]["card_promo_id"]) == "CPN002")
				{
					if (System.Convert.ToInt32(Module1.GetSrvDate()) >= System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["start_promo_date"]) && System.Convert.ToInt32(Module1.GetSrvDate()) <= System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["end_promo_date"]))
					{
						Module1.VIsKKG = true;
					}
				}
			}
			else
			{
				if (Interaction.MsgBox("Daftarkan kartu promo baru?", (int) MsgBoxStyle.Question + MsgBoxStyle.OkCancel, "Oops..") == MsgBoxResult.Ok)
				{
					frmCardPromo.Default.ShowDialog();
					if (Vpromo_id.Text != "")
					{
						
						Module1.StrSQL = "select * from card_promotion where card_nr_promo ='" + txtcard_opt.Text + "' and card_promo_id = '" + Vpromo_id.Text + "'";
						
						//If Linked() Then
						//    getSqldb(StrSQL, ConnServer)
						//Else
						//    getSqldb(StrSQL, ConnLocal)
						//End If
						
						//tanpa cek PING
						if (Module1.VPing == "ONLINE")
						{
							Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
						}
						else
						{
							Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
						}
						
						if (RsCari.Tables[0].Rows.Count > 0)
						{
							Interaction.MsgBox("Kartu joint promo sudah pernah ada, harap hubungi information counter", (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
							return;
						}
						Module1.StrSQL = "insert into Card_Promotion (Card_Nr, Card_Nr_Promo, Card_Promo_Id, Card_Expired_date, " + "Card_Activate_Date, Card_Status, User_Id_Activate) values ('" + txtcard_no.Text + "','" + txtcard_opt.Text + "','" + Vpromo_id.Text + "',getdate()+1825, getdate(), 'A', '" + Module1.VKasir_ID + "')";
						
						Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
						//If Linked() Then getSqldb(StrSQL, ConnServer)
						
						//tanpa cek PING
						if (Module1.VPing == "ONLINE")
						{
							Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
						}
					}
				}
				txtcard_opt.Focus();
				System.Windows.Forms.SendKeys.Send("{home}+{end}");
				return;
			}
			CmdOk.Focus();
		}
		public void txtcard_opt_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			try
			{
				DataSet RsDobel = new DataSet();
				switch (e.KeyCode)
				{
					case (System.Windows.Forms.Keys) 13:
						optKeyDown13();
						break;
					case (System.Windows.Forms.Keys) 27:
						this.Close();
						break;
				}
			}
			catch
			{
				if (Information.Err().Number == double.Parse("-2147217873"))
				{
					Interaction.MsgBox("Kartu promo sudah pernah ada, harap hubungi information counter", (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				}
				else
				{
					Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				}
				Module1.SaveLog(this.Name + " " + "Simpan Kartu Promo " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
		}
		public void CmdNav_Click(System.Object sender, System.EventArgs e)
		{
			frmNum.Default.Text = "NUMBER - CARD";
			frmNum.Default.ShowDialog();
			txtcard_opt.Focus();
		}
	}
}
