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
	public partial class frmPayment : System.Windows.Forms.Form
	{
		public frmPayment()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmPayment defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmPayment Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmPayment();
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
		string lokasi;
		string VTukar_Point;
		string UniqueCode;
		int TotPay;
		int RoundOfPay;
		DataSet Tdata1 = new DataSet();
		DataSet Tdata2 = new DataSet();
		bool t_load = false;
		int cnt = 0;
		string Response;
		public void cmdvoc_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			frmDisc.Default.lblmsg.Text = "VOUCHER";
			frmDisc.Default.ShowDialog();
			txtno_voc.Focus();
			System.Windows.Forms.SendKeys.Send("{end}");
		}
		public void frmPayment_Activated(System.Object eventSender, System.EventArgs eventArgs)
		{
			//TotPay = vpay.Text
			//lbltotal.Text = CDec(vpay.Text).ToString("N0")
			//lblbayar.Text = CStr(0)
			//lblsisa.Text = CDec(vpay.Text).ToString("N0")
			//'Tambahan Harga Point Variable
			//txtharga_point.Text = VHargaPoint
		}
		public void KeyDownEnterDgv()
		{
			RoundOfPay = 0;
			lbltotal.Text = System.Convert.ToString((TotPay).ToString("N0"));
			lblsisa.Text = System.Convert.ToString((decimal.Parse(vpay.Text)).ToString("N0"));
			if ((string) (DataGridView1[2, DataGridView1.CurrentRow.Index].Value) == "CS")
			{
				_frmpay_0.Visible = true;
				RoundOfPay = System.Convert.ToInt32(double.Parse(vpay.Text) - (Conversion.Int(double.Parse(vpay.Text) / 100)) * 100);
				if (double.Parse(vpay.Text) < 0)
				{
					if (double.Parse(vpay.Text) != Conversion.Int(double.Parse(vpay.Text) / 100) * 100)
					{
						RoundOfPay = System.Convert.ToInt32(double.Parse(vpay.Text) - (Conversion.Int(double.Parse(vpay.Text) / 100) + 1) * 100);
					}
					else
					{
						RoundOfPay = 0;
					}
				}
				//RoundOfPay = 0
				lbltotal.Text = System.Convert.ToString((TotPay - RoundOfPay).ToString("N0"));
				lblsisa.Text = System.Convert.ToString(((decimal) (double.Parse(vpay.Text) - RoundOfPay)).ToString("N0"));
				txtcash.Text = System.Convert.ToString(((decimal) (double.Parse(vpay.Text) - RoundOfPay)).ToString("N0"));
				//txtcash.Text = CDec(vpay.Text).ToString("N0")
				txtcash.Select();
				txtcash.Focus();
				txtcash.SelectionStart = 0;
				txtcash.SelectionLength = txtcash.Text.Length;
			}
			else if (((string) (DataGridView1[2, DataGridView1.CurrentRow.Index].Value) == "CC") || ((string) (DataGridView1[2, DataGridView1.CurrentRow.Index].Value) == "DC"))
			{
				_frmpay_1.Visible = true;
				
				if (txtnama.Enabled == true)
				{
					txtno_kartu.Select();
					txtno_kartu.Focus();
					txtno_kartu.SelectionStart = 0;
					txtno_kartu.SelectionLength = txtno_kartu.Text.Length;
				}
				else
				{
					txtcredit.Select();
					txtcredit.Focus();
					txtcredit.SelectionStart = 0;
					txtcredit.SelectionLength = txtno_kartu.Text.Length;
				}
			}
			else if (((string) (DataGridView1[2, DataGridView1.CurrentRow.Index].Value) == "SV") || ((string) (DataGridView1[2, DataGridView1.CurrentRow.Index].Value) == "OV"))
			{
				_frmpay_2.Visible = true;
				txtno_voc.Select();
				txtno_voc.Focus();
				txtno_voc.SelectionStart = 0;
				txtno_voc.SelectionLength = txtno_voc.Text.Length;
			}
			else if ((string) (DataGridView1[2, DataGridView1.CurrentRow.Index].Value) == "PR")
			{
				tampil_point();
				_frmpay_3.Visible = true;
				txtpoint.Select();
				txtpoint.Focus();
				txtpoint.SelectionStart = 0;
				txtpoint.SelectionLength = txtpoint.Text.Length;
			}
		}
		public void frmPayment_Load(System.Object eventSender, System.EventArgs eventArgs)
		{
			DataGridView2.DataSource = null;
			UniqueCode = "";
			Tdata2.Clear();
			vno_trans.Text = Module1.VNomor;
			t_load = false;
			Tdata1 = Module1.getSqldb("SELECT Payment_Types, Description, Types, Seq From Payment_Types where Seq<30 ORDER BY Seq", Module1.ConnLocal);
			if (Tdata1.Tables[0].Rows.Count > 0)
			{
				DataGridView1.DataSource = Tdata1.Tables[0];
				DataGridView1.Columns[0].Visible = false;
				DataGridView1.Columns[2].Visible = false;
				DataGridView1.Columns[3].Visible = false;
				DataGridView1.Columns[1].HeaderText = "TIPE PEMBAYARAN";
				DataGridView1.Refresh();
			}
			TotPay = System.Convert.ToInt32(vpay.Text);
			lbltotal.Text = System.Convert.ToString((decimal.Parse(vpay.Text)).ToString("N0"));
			lblbayar.Text = System.Convert.ToString(0);
			lblsisa.Text = System.Convert.ToString((decimal.Parse(vpay.Text)).ToString("N0"));
			//Tambahan Harga Point Variable
			txtharga_point.Text = Module1.VHargaPoint;
			Tdata2 = Module1.getSqldb("SELECT aa.Seq, bb.Description, Paid_Amount, Credit_Card_No, Credit_Card_Name " + "FROM Paid aa INNER JOIN Payment_Types bb ON aa.Payment_Types = bb.Payment_Types" + " where transaction_number = '" + vno_trans.Text + "' order by aa.seq", Module1.ConnLocal);
			if (Tdata2.Tables[0].Rows.Count > 0)
			{
				DataGridView2.DataSource = null;
				DataGridView2.DataSource = Tdata2.Tables[0];
				DataGridView2.Columns[0].HeaderText = "No";
				DataGridView2.Columns[0].Width = 30;
				DataGridView2.Columns[1].HeaderText = "Tipe";
				DataGridView2.Columns[1].Width = 150;
				DataGridView2.Columns[2].HeaderText = "Nilai";
				DataGridView2.Columns[2].Width = 90;
				DataGridView2.Columns[3].HeaderText = "No Kartu";
				DataGridView2.Columns[3].Width = 100;
				DataGridView2.Columns[4].HeaderText = "Nama Kartu";
				DataGridView2.Columns[4].Width = 170;
				DataGridView2.Columns["Paid_Amount"].DefaultCellStyle.Format = "N0";
			}
			DataGridView1.Select();
			DataGridView1.Focus();
			DataGridView1.CurrentCell = DataGridView1.Rows[0].Cells[1];
			DataGridView1.Rows[DataGridView1.CurrentRow.Index].Selected = true;
			//DataGridView1_CellClick(Me.DataGridView1, New DataGridViewCellEventArgs(2, 0))
			//DataGridView1.Focus()
			//Cash Di Awal
			_frmpay_0.Visible = true;
			_frmpay_0.Visible = true;
			_frmpay_1.Visible = false;
			_frmpay_2.Visible = false;
			_frmpay_3.Visible = false;
			RoundOfPay = 0;
			t_load = true;
			RoundOfPay = System.Convert.ToInt32(double.Parse(vpay.Text) - (Conversion.Int(double.Parse(vpay.Text) / 100)) * 100);
			if (double.Parse(vpay.Text) < 0)
			{
				if (double.Parse(vpay.Text) != Conversion.Int(double.Parse(vpay.Text) / 100) * 100)
				{
					RoundOfPay = System.Convert.ToInt32(double.Parse(vpay.Text) - (Conversion.Int(double.Parse(vpay.Text) / 100) + 1) * 100);
				}
				else
				{
					RoundOfPay = 0;
				}
			}
			//RoundOfPay = 0
			lbltotal.Text = System.Convert.ToString((TotPay - RoundOfPay).ToString("N0"));
			lblsisa.Text = System.Convert.ToString(((decimal) (double.Parse(vpay.Text) - RoundOfPay)).ToString("N0"));
			//txtcash.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
			
			lokasi = "txtcash";
			txtkembali.Text = "0";
			lbltotal.Text = System.Convert.ToString((TotPay).ToString("N0"));
			lblsisa.Text = System.Convert.ToString((decimal.Parse(vpay.Text)).ToString("N0"));
			Module1.no_kartuECR = "";
			_cmdpay_0.Enabled = true;
			if (TotPay > 0)
			{
				Cek_ECR();
			}
			//txtcash.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
			txtcash.Select();
			txtcash.Focus();
			txtcash.SelectionStart = 0;
			txtcash.SelectionLength = txtcash.Text.Length;
		}
		
		public void Cek_ECR()
		{
			if (Module1.isECR == 1)
			{
				txtno_kartu.Enabled = false;
				txtnama.Enabled = false;
				txtcredit.Enabled = false;
				if (Interaction.MsgBox("Use ECR BCA??", MsgBoxStyle.YesNo, "Information") == MsgBoxResult.No)
				{
					Frame2.Enabled = true;
					_cmdpay_0.Enabled = true;
					Label3.Visible = false;
					txtno_kartu.Enabled = true;
					txtnama.Enabled = true;
					txtcredit.Enabled = true;
					return;
				}
				Label3.Visible = true;
				Frame2.Enabled = false;
				//_cmdpay_0.Enabled = False
				SerialPort1.Encoding = System.Text.Encoding.GetEncoding(28591);
				//Dim input As String = "0150013031" &
				//    ConvertHex(CDec(lbltotal.Text & "00").ToString.PadLeft(12, "0"c)) &
				//    "303030303030303030303030" &
				//    "31363838373030363237323031383932202020" &
				//    "32313130" &
				//    "30303030303030302020202020204E4E4E202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202003"
				//input = "02" & input & LRC(input)
				//input tanpa kartu
				string input = "0150013031" +
					ConvertHex(System.Convert.ToString((decimal.Parse(lbltotal.Text + "00")).ToString().PadLeft(12, '0'))) +
					"303030303030303030303030" +
					"20202020202020202020202020202020202020" +
					"20202020" +
					"30303030303030302020202020204E4E4E202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202020202003";
				input = "02" + input + LRC(input);
				
				List<byte> bytes = new List<byte>();
				string cc;
				for (int i = 0; i <= input.Length - 2; i += 2)
				{
					try
					{
						cc = input.Substring(i, 2);
						bytes.Add(Convert.ToByte(input.Substring(i, 2), 16));
					}
					catch (Exception)
					{
						
					}
				}
				byte[] process_CMD = bytes.ToArray();
				SerialPort1.PortName = "COM" + System.Convert.ToString(Module1.ECRComm);
				try
				{
					SerialPort1.Open();
					SerialPort1.Write(process_CMD, 0, process_CMD.Length);
					SerialPort1.Close();
					
					Timer1.Enabled = true;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					Frame2.Enabled = true;
					_cmdpay_0.Enabled = true;
					Label3.Visible = false;
					txtno_kartu.Enabled = true;
					txtnama.Enabled = true;
					txtcredit.Enabled = true;
				}
				
			}
		}
		
		private string ConvertHex(string data)
		{
			string Hasil = "";
			for (int x = 0; x <= data.Length - 1; x++)
			{
				Hasil = Hasil + "3" + data.Substring(x, 1);
			}
			data = Hasil;
			return data;
		}
		
		private string LRC(string data)
		{
			string binStr = "";
			int[] bin = new int[9];
			int Decimals = 0;
			string Hexadecimal = "";
			for (int x = 0; x <= data.Length - 2; x += 2)
			{
				binStr = System.Convert.ToString(Convert.ToString(Convert.ToInt32(data.Substring(x, 2), 16), 2).PadLeft(8, '0'));
				for (int i = 0; i <= 7; i++)
				{
					bin[i + 1] += System.Convert.ToInt32(binStr.Substring(i, 1));
				}
			}
			Decimals = Convert.ToInt32(bin[1] % 2 + bin[2] % 2 + bin[3] % 2 + bin[4] % 2 + bin[5] % 2 + bin[6] % 2 + bin[7] % 2 + bin[8] % 2);
			Hexadecimal = Convert.ToString(Decimals, 16).ToUpper();
			return Hexadecimal;
		}
		public void DataGridView1_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (t_load == false)
			{
				return;
			}
			lokasi = "";
			lblmsg.Text = DataGridView1[1, e.RowIndex].Value.ToString().Trim();
			_frmpay_0.Visible = false;
			_frmpay_1.Visible = false;
			_frmpay_2.Visible = false;
			_frmpay_3.Visible = false;
			RoundOfPay = 0;
			lbltotal.Text = System.Convert.ToString((TotPay).ToString("N0"));
			lblsisa.Text = System.Convert.ToString((decimal.Parse(vpay.Text)).ToString("N0"));
			txtkembali.Text = "0";
			if ((string) (DataGridView1[2, e.RowIndex].Value) == "CS")
			{
				_frmpay_0.Visible = true;
				RoundOfPay = System.Convert.ToInt32(double.Parse(vpay.Text) - (Conversion.Int(double.Parse(vpay.Text) / 100)) * 100);
				if (double.Parse(vpay.Text) < 0)
				{
					if (double.Parse(vpay.Text) != Conversion.Int(double.Parse(vpay.Text) / 100) * 100)
					{
						RoundOfPay = System.Convert.ToInt32(double.Parse(vpay.Text) - (Conversion.Int(double.Parse(vpay.Text) / 100) + 1) * 100);
					}
					else
					{
						RoundOfPay = 0;
					}
				}
				//RoundOfPay = 0
				lbltotal.Text = System.Convert.ToString((TotPay - RoundOfPay).ToString("N0"));
				lblsisa.Text = System.Convert.ToString(((decimal) (double.Parse(vpay.Text) - RoundOfPay)).ToString("N0"));
				//txtcash.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
				txtcash.Select();
				txtcash.Focus();
				txtcash.SelectionStart = 0;
				txtcash.SelectionLength = txtcash.Text.Length;
			}
			else if (((string) (DataGridView1[2, e.RowIndex].Value) == "CC") || ((string) (DataGridView1[2, e.RowIndex].Value) == "DC"))
			{
				_frmpay_1.Visible = true;
				txtno_kartu.Text = "";
				txtno_kartu.Text = Module1.no_kartuECR;
				if (txtnama.Text.Contains("*"))
				{
				}
				else
				{
					txtnama.Text = "";
				}
				if (txtnama.Enabled == true)
				{
					txtno_kartu.Select();
					txtno_kartu.Focus();
					txtcredit.Text = System.Convert.ToString((decimal.Parse(vpay.Text)).ToString("N0"));
					txtno_kartu.SelectionStart = 0;
					txtno_kartu.SelectionLength = txtno_kartu.Text.Length;
				}
				else
				{
					txtcredit.Text = System.Convert.ToString((decimal.Parse(vpay.Text)).ToString("N0"));
					txtcredit.Select();
					txtcredit.Focus();
					txtcredit.SelectionStart = 0;
					txtcredit.SelectionLength = txtno_kartu.Text.Length;
					btnNum[11].Select();
					btnNum[11].Focus();
				}
			}
			else if (((string) (DataGridView1[2, e.RowIndex].Value) == "SV") || ((string) (DataGridView1[2, e.RowIndex].Value) == "OV"))
			{
				_frmpay_2.Visible = true;
				txtno_voc.Text = "";
				txtvoucher.Text = "";
				txtno_voc.Select();
				txtno_voc.Focus();
				txtno_voc.SelectionStart = 0;
				txtno_voc.SelectionLength = txtno_voc.Text.Length;
			}
			else if ((string) (DataGridView1[2, e.RowIndex].Value) == "PR")
			{
				tampil_point();
				_frmpay_3.Visible = true;
				txtpoint.Select();
				txtpoint.Focus();
				txtpoint.SelectionStart = 0;
				txtpoint.SelectionLength = txtpoint.Text.Length;
			}
		}
		private short Cari_Point(string No_trans)
		{
			short returnValue = 0;
			DataSet RsCari = new DataSet();
			
			RsCari = Module1.getSqldb("select claim_point from cust_point_trans where Trans_nr = '" + No_trans + "'", Module1.ConnLocal);
			returnValue = System.Convert.ToInt16((!Information.IsDBNull(RsCari.Tables[0].Rows[0]["claim_point"])) ? (RsCari.Tables[0].Rows[0]["claim_point"]) : 0);
			RsCari.Clear();
			RsCari = null;
			return returnValue;
		}
		public void DataGridView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					_frmpay_0.Visible = false;
					_frmpay_1.Visible = false;
					_frmpay_2.Visible = false;
					_frmpay_3.Visible = false;
					RoundOfPay = 0;
					lbltotal.Text = System.Convert.ToString((TotPay).ToString("N0"));
					lblsisa.Text = System.Convert.ToString((decimal.Parse(vpay.Text)).ToString("N0"));
					if ((string) (DataGridView1[2, DataGridView1.CurrentRow.Index].Value) == "CS")
					{
						_frmpay_0.Visible = true;
						RoundOfPay = System.Convert.ToInt32(double.Parse(vpay.Text) - (Conversion.Int(double.Parse(vpay.Text) / 100)) * 100);
						if (double.Parse(vpay.Text) < 0)
						{
							if (double.Parse(vpay.Text) != Conversion.Int(double.Parse(vpay.Text) / 100) * 100)
							{
								RoundOfPay = System.Convert.ToInt32(double.Parse(vpay.Text) - (Conversion.Int(double.Parse(vpay.Text) / 100) + 1) * 100);
							}
							else
							{
								RoundOfPay = 0;
							}
						}
						//RoundOfPay = 0
						lbltotal.Text = System.Convert.ToString((TotPay - RoundOfPay).ToString("N0"));
						lblsisa.Text = System.Convert.ToString(((decimal) (double.Parse(vpay.Text) - RoundOfPay)).ToString("N0"));
						txtcash.Text = System.Convert.ToString(((decimal) (double.Parse(vpay.Text) - RoundOfPay)).ToString("N0"));
						txtcash.Select();
						txtcash.Focus();
						txtcash.SelectionStart = 0;
						txtcash.SelectionLength = txtcash.Text.Length;
					}
					else if (((string) (DataGridView1[2, DataGridView1.CurrentRow.Index].Value) == "CC") || ((string) (DataGridView1[2, DataGridView1.CurrentRow.Index].Value) == "DC"))
					{
						_frmpay_1.Visible = true;
						txtno_kartu.Text = "";
						txtno_kartu.Text = Module1.no_kartuECR;
						if (txtnama.Text.Contains("*"))
						{
						}
						else
						{
							txtnama.Text = "";
						}
						if (txtnama.Enabled == true)
						{
							txtno_kartu.Select();
							txtno_kartu.Focus();
							txtcredit.Text = System.Convert.ToString((decimal.Parse(vpay.Text)).ToString("N0"));
							txtno_kartu.SelectionStart = 0;
							txtno_kartu.SelectionLength = txtno_kartu.Text.Length;
						}
						else
						{
							txtcredit.Text = System.Convert.ToString((decimal.Parse(vpay.Text)).ToString("N0"));
							txtcredit.Select();
							txtcredit.Focus();
							txtcredit.SelectionStart = 0;
							txtcredit.SelectionLength = txtno_kartu.Text.Length;
							btnNum[11].Select();
							btnNum[11].Focus();
						}
					}
					else if (((string) (DataGridView1[2, DataGridView1.CurrentRow.Index].Value) == "SV") || ((string) (DataGridView1[2, DataGridView1.CurrentRow.Index].Value) == "OV"))
					{
						_frmpay_2.Visible = true;
						txtno_voc.Text = "";
						txtvoucher.Text = "";
						txtno_voc.Select();
						txtno_voc.Focus();
						txtno_voc.SelectionStart = 0;
						txtno_voc.SelectionLength = txtno_voc.Text.Length;
					}
					else if ((string) (DataGridView1[2, DataGridView1.CurrentRow.Index].Value) == "PR")
					{
						tampil_point();
						_frmpay_3.Visible = true;
						txtpoint.Select();
						txtpoint.Focus();
						txtpoint.SelectionStart = 0;
						txtpoint.SelectionLength = txtpoint.Text.Length;
					}
					e.Handled = true;
					break;
				case (System.Windows.Forms.Keys) 27:
					break;
					//ClosePayment()
			}
		}
		public void ClosePayment()
		{
			DataSet RsHapus = new DataSet();
			DataSet RsAmbil = new DataSet();
			
			Point.MySTAR(txtcard_no.Text);
			tampil_point();
			Module1.getSqldb("delete from Paid where Transaction_Number = '" + vno_trans.Text + "'", Module1.ConnLocal);
			
			//If Linked() Then
			//    getSqldb("delete from Paid where Transaction_Number = '" & vno_trans.Text & "'", ConnServer)
			//End If
			
			//tanpa cek PING
			if (Module1.VPing == "ONLINE")
			{
				Module1.getSqldb("delete from Paid where Transaction_Number = '" + vno_trans.Text + "'", Module1.ConnServer);
			}
			Module1.SaveLog(this.Name + " " + "Close Payment " + vno_trans.Text + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			//RoundOfPay = 0
			txtcash.Clear();
			txtno_kartu.Clear();
			txtnama.Clear();
			txtcredit.Clear();
			txtno_voc.Clear();
			txtvoucher.Clear();
			Module1.VNomor = vno_trans.Text;
			Module1.GotoPayment = false;
			//If RFIDType = "zebra" Then
			//    frmSales.CheckConZebra()
			//End If
			Module1.VDiscBySTAR = 0;
			this.Close();
		}
		public void DataGridView1_SelectionChanged(object sender, System.EventArgs e)
		{
			if (t_load == false)
			{
				return;
			}
			lokasi = "";
			int rowx = 0;
			
			try
			{
				lblmsg.Text = DataGridView1[1, rowx].Value.ToString().Trim();
				rowx = DataGridView1.CurrentRow.Index;
			}
			catch (Exception)
			{
				rowx = 0;
			}
			
			_frmpay_0.Visible = false;
			_frmpay_1.Visible = false;
			_frmpay_2.Visible = false;
			_frmpay_3.Visible = false;
			RoundOfPay = 0;
			lbltotal.Text = System.Convert.ToString((TotPay).ToString("N0"));
			lblsisa.Text = System.Convert.ToString((decimal.Parse(vpay.Text)).ToString("N0"));
			txtkembali.Text = "0";
			if ((string) (DataGridView1[2, rowx].Value) == "CS")
			{
				_frmpay_0.Visible = true;
				RoundOfPay = System.Convert.ToInt32(double.Parse(vpay.Text) - (Conversion.Int(double.Parse(vpay.Text) / 100)) * 100);
				if (double.Parse(vpay.Text) < 0)
				{
					if (double.Parse(vpay.Text) != Conversion.Int(double.Parse(vpay.Text) / 100) * 100)
					{
						RoundOfPay = System.Convert.ToInt32(double.Parse(vpay.Text) - (Conversion.Int(double.Parse(vpay.Text) / 100) + 1) * 100);
					}
					else
					{
						RoundOfPay = 0;
					}
				}
				//RoundOfPay = 0
				lbltotal.Text = System.Convert.ToString((TotPay - RoundOfPay).ToString("N0"));
				lblsisa.Text = System.Convert.ToString(((decimal) (double.Parse(vpay.Text) - RoundOfPay)).ToString("N0"));
				//txtcash.Text = CDec(vpay.Text - RoundOfPay).ToString("N0")
				txtcash.Select();
				txtcash.Focus();
				txtcash.SelectionStart = 0;
				txtcash.SelectionLength = txtcash.Text.Length;
			}
			else if (((string) (DataGridView1[2, rowx].Value) == "CC") || ((string) (DataGridView1[2, rowx].Value) == "DC"))
			{
				_frmpay_1.Visible = true;
				txtno_kartu.Text = "";
				txtno_kartu.Text = Module1.no_kartuECR;
				if (txtnama.Text.Contains("*"))
				{
				}
				else
				{
					txtnama.Text = "";
				}
				if (txtnama.Enabled == true)
				{
					txtno_kartu.Select();
					txtno_kartu.Focus();
					txtcredit.Text = System.Convert.ToString((decimal.Parse(vpay.Text)).ToString("N0"));
					txtno_kartu.SelectionStart = 0;
					txtno_kartu.SelectionLength = txtno_kartu.Text.Length;
				}
				else
				{
					txtcredit.Text = System.Convert.ToString((decimal.Parse(vpay.Text)).ToString("N0"));
					txtcredit.Select();
					txtcredit.Focus();
					txtcredit.SelectionStart = 0;
					txtcredit.SelectionLength = txtno_kartu.Text.Length;
					btnNum[11].Select();
					btnNum[11].Focus();
				}
			}
			else if (((string) (DataGridView1[2, rowx].Value) == "SV") || ((string) (DataGridView1[2, rowx].Value) == "OV"))
			{
				_frmpay_2.Visible = true;
				txtno_voc.Text = "";
				txtvoucher.Text = "";
				txtno_voc.Select();
				txtno_voc.Focus();
				txtno_voc.SelectionStart = 0;
				txtno_voc.SelectionLength = txtno_voc.Text.Length;
			}
			else if ((string) (DataGridView1[2, rowx].Value) == "PR")
			{
				tampil_point();
				_frmpay_3.Visible = true;
				txtpoint.Select();
				txtpoint.Focus();
				txtpoint.SelectionStart = 0;
				txtpoint.SelectionLength = txtpoint.Text.Length;
			}
		}
		public void txtcash_Enter(object sender, System.EventArgs e)
		{
			lokasi = "txtcash";
		}
		public void txtcash_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					if (txtcash.Text == "" || txtcash.Text == "0")
					{
						//KeyDownEnterDgv()
						lokasi = "txtcash";
						lbltotal.Text = System.Convert.ToString((TotPay - RoundOfPay).ToString("N0"));
						lblsisa.Text = System.Convert.ToString(((decimal) (double.Parse(vpay.Text) - RoundOfPay)).ToString("N0"));
						txtcash.Text = System.Convert.ToString(((decimal) (double.Parse(vpay.Text) - RoundOfPay)).ToString("N0"));
						//txtcash.Text = CDec(vpay.Text).ToString("N0")
						txtcash.Select();
						txtcash.Focus();
						txtcash.SelectionStart = 0;
						txtcash.SelectionLength = txtcash.Text.Length;
						return;
					}
					DataGridView1.Focus();
					if (vstatus.Text.Trim() == "SALES" && double.Parse(txtcash.Text) >= 0)
					{
						string temp_card_num = "";
						if (Simpan_Detail(System.Convert.ToDouble(double.Parse(txtkembali.Text) >= 0 ? double.Parse(txtcash.Text) - double.Parse(txtkembali.Text) : System.Convert.ToInt32(txtcash.Text)), "", ref temp_card_num))
						{
							Cek_Lunas();
						}
					}
					else if (vstatus.Text.Trim() == "REFUND" && double.Parse(txtcash.Text) <= 0)
					{
						string temp_card_num2 = "";
						if (Simpan_Detail(System.Convert.ToDouble(double.Parse(txtkembali.Text) <= 0 ? double.Parse(txtcash.Text) - double.Parse(txtkembali.Text) : System.Convert.ToInt32(txtcash.Text)), "", ref temp_card_num2))
						{
							Cek_Lunas();
						}
					}
					break;
				case (System.Windows.Forms.Keys) 27:
					DataGridView1.Focus();
					break;
			}
		}
		public void txtcash_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (Strings.Asc(e.KeyChar) != 8)
			{
				if (Strings.Asc(e.KeyChar) < 48 || Strings.Asc(e.KeyChar) > 57)
				{
					e.Handled = true;
				}
			}
		}
		public void txtcash_TextChanged(object sender, System.EventArgs e)
		{
			if (txtcash.Text != "")
			{
				txtkembali.Text = System.Convert.ToString(Conversion.Val(double.Parse(txtcash.Text) + RoundOfPay) - double.Parse(vpay.Text));
				txtcash.Text = System.Convert.ToString((decimal.Parse(txtcash.Text)).ToString("N0"));
				txtcash.SelectionStart = txtcash.TextLength;
			}
		}
		public void txtcredit_Enter(System.Object eventSender, System.EventArgs eventArgs)
		{
			lokasi = "txtcredit";
		}
		public void txtno_kartu_Enter(System.Object eventSender, System.EventArgs eventArgs)
		{
			lokasi = "txtno_kartu";
		}
		public void txtno_kartu_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			string Kartu = "";
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					if (((string) (DataGridView1[2, DataGridView1.CurrentRow.Index].Value) == "CC") || ((string) (DataGridView1[2, DataGridView1.CurrentRow.Index].Value) == "DC"))
					{
						if (txtno_kartu.Text == "" || txtno_kartu.Text.Substring(2, 1) == "-" || txtno_kartu.Text.Length != 16)
						{
							Interaction.MsgBox("Nomor kartu tidak valid", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
							txtno_kartu.Focus();
							System.Windows.Forms.SendKeys.Send("{home}+{end}");
							return;
						}
						
						Kartu = VB.Strings.Left(txtno_kartu.Text, 79).TrimStart();
						
						//            If Mid(Kartu, 4, 1) = "B" Then
						//                txtno_kartu = LTrim(Mid(Kartu, 5, 16))
						//                txtnama = LTrim(Mid(Kartu, 22, 20))
						//            ElseIf Mid(Kartu, 2, 1) = "B" Then
						//                txtno_kartu = LTrim(Mid(Kartu, 3, 16))
						//            ElseIf Left(Kartu, 1) = ";" Then
						//                txtno_kartu = LTrim(Mid(Kartu, 2, 16))
						//            ElseIf Mid(Kartu, 4, 1) <> "B" Then
						//                txtno_kartu = LTrim(Mid(Kartu, 8, 16))
						//            End If
						//---------------------- normal ----------------
						if (Kartu.Substring(3, 1) != "B")
						{
							if (Kartu.Length == 16)
							{
								txtno_kartu.Text = Kartu;
							}
							else
							{
								if (VB.Strings.Left(Kartu, 1) != "c")
								{
									Module1.SaveLog(Kartu + " - KARTU BARU");
								}
								if (Kartu.Substring(7, 1) == "B")
								{
									txtno_kartu.Text = Kartu.Substring(8, 16).TrimStart();
								}
								else
								{
									txtno_kartu.Text = Kartu.Substring(7, 16).TrimStart();
								}
							}
						}
						else if (Kartu.Substring(3, 1) == "B")
						{
							txtno_kartu.Text = Kartu.Substring(4, 16).TrimStart();
							txtnama.Text = Kartu.Substring(21, 20).TrimStart();
						}
						//---------------POSIFLEX------------------------
						//           If Left(Kartu, 1) = ";" Then
						//                txtno_kartu = LTrim(Mid(Kartu, 2, 16))
						//           ElseIf Mid(Kartu, 2, 1) <> "B" Then
						//                'Call SaveLog(Kartu & " - KARTU BARU")
						//                txtno_kartu = LTrim(Mid(Kartu, 8, 16))
						//           ElseIf Mid(Kartu, 2, 1) = "B" Then
						//                txtno_kartu = LTrim(Mid(Kartu, 3, 16))
						//                txtnama = LTrim(Mid(Kartu, 20, 26))
						//           End If
						
						//       ---------------NEC------------------------
						//           If Mid(Kartu, 2, 1) = "B" Then
						//                'Call SaveLog(Kartu & " - KARTU BARU")
						//                txtno_kartu = LTrim(Mid(Kartu, 3, 16))
						//                txtnama = LTrim(Mid(Kartu, 20, 26))
						//           ElseIf Left(Kartu, 1) = ";" Then
						//                txtno_kartu = LTrim(Mid(Kartu, 2, 16))
						//           ElseIf Mid(Kartu, 2, 1) <> "B" Then
						//                txtno_kartu = LTrim(Mid(Kartu, 8, 16))
						//           End If
						
						if (txtno_kartu.Text.Length != 16)
						{
							Module1.SaveLog(Kartu + " - TIDAK16");
						}
					}
					
					txtcredit.Focus();
					break;
					//System.Windows.Forms.Application.DoEvents()
					//System.Windows.Forms.SendKeys.Send("{home}+{end}")
				case (System.Windows.Forms.Keys) 27:
					DataGridView1.Focus();
					break;
			}
		}
		public void txtcredit_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					if ((vstatus.Text.Trim() == "SALES" && decimal.Parse(txtcredit.Text) <= decimal.Parse(vpay.Text)) || (vstatus.Text.Trim() == "REFUND" && decimal.Parse(txtcredit.Text) >= decimal.Parse(vpay.Text)))
					{
						DataGridView1.Focus();
						string temp_card_num = VB.Strings.Left(txtnama.Text, 50);
						if (Simpan_Detail(double.Parse(txtcredit.Text), VB.Strings.Left(txtno_kartu.Text, 16), ref temp_card_num))
						{
							txtno_kartu.Text = "";
							txtno_kartu.Text = Module1.no_kartuECR;
							txtnama.Text = "";
							txtcredit.Text = "0";
							Cek_Lunas();
						}
					}
					else
					{
						Interaction.MsgBox("Pembayaran dengan kartu kredit/debit tidak boleh " + Constants.vbNewLine + "melebihi sisa yang harus dibayar", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
						txtcredit.Focus();
					}
					break;
			}
		}
		public void txtno_voc_Enter(System.Object eventSender, System.EventArgs eventArgs)
		{
			lokasi = "txtno_voc";
		}
		public void txtno_voc_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			DataSet RsDobel = new DataSet();
			
			DataSet RsZB = new DataSet();
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					//If txtno_voc.Text = "" Then Exit Sub
					if ((string) (DataGridView1[2, DataGridView1.CurrentRow.Index].Value) == "SV")
					{
						
						//If txtno_voc.Text = "50" Then
						//    txtvoucher.Text = "50000"
						//    txtvoucher.Focus()
						//    Exit Sub
						//End If
						
						//If txtno_voc.Text = "75" Then
						//    txtvoucher.Text = "75000"
						//    txtvoucher.Focus()
						//    Exit Sub
						//End If
						
						
						//If Linked() Then
						//    txtvoucher.Text = UCase(CStr(Cek_Voc(txtno_voc.Text)))
						//    If txtvoucher.Text = 0 Then
						//        txtno_voc.Focus()
						//        System.Windows.Forms.Application.DoEvents()
						//        System.Windows.Forms.SendKeys.Send("{home}+{end}")
						//        Exit Sub
						//    Else
						//        txtvoucher.ReadOnly = True
						//        txtvoucher.Focus()
						//    End If
						//Else
						//    txtvoucher.ReadOnly = False
						//    txtvoucher.Focus()
						//End If
						
						//tanpa cek PING
						if (Module1.VPing == "ONLINE")
						{
							txtvoucher.Text = System.Convert.ToString(Cek_Voc2(txtno_voc.Text)).ToUpper();
							if (System.Convert.ToInt32(txtvoucher.Text) == 0)
							{
								txtno_voc.Focus();
								//System.Windows.Forms.Application.DoEvents()
								//System.Windows.Forms.SendKeys.Send("{home}+{end}")
								return;
							}
							else
							{
								txtvoucher.ReadOnly = true;
								txtvoucher.Focus();
								string temp_card_num = "";
								if (Simpan_Detail(double.Parse(txtvoucher.Text), txtno_voc.Text, ref temp_card_num))
								{
									txtno_voc.Text = "";
									txtvoucher.Text = "0";
									Cek_Lunas();
								}
							}
						}
						else
						{
							txtvoucher.ReadOnly = false;
							txtvoucher.Focus();
						}
					}
					else if ((string) (DataGridView1[2, DataGridView1.CurrentRow.Index].Value) == "OV")
					{
						
						
						
						txtvoucher.ReadOnly = false;
						txtvoucher.SelectionStart = 0;
						txtvoucher.SelectionLength = txtcash.Text.Length;
						txtvoucher.Focus();
						//System.Windows.Forms.Application.DoEvents()
						//System.Windows.Forms.SendKeys.Send("{home}+{end}")
					}
					break;
				case (System.Windows.Forms.Keys) 27:
					DataGridView1.Focus();
					break;
			}
		}
		private string Gen_Seq()
		{
			string returnValue = "";
			DataSet RsCari = new DataSet();
			
			RsCari = Module1.getSqldb("select ISNULL(MAX(seq),0) as urut from paid where Transaction_Number = '" + vno_trans.Text + "'", Module1.ConnLocal);
			returnValue = System.Convert.ToString(System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["urut"]) + 1);
			RsCari.Clear();
			RsCari = null;
			return returnValue;
		}
		private int Cek_Voc(string nomor)
		{
			int returnValue = 0;
			DataSet RsCari = new DataSet();
			DataSet RsDobel = new DataSet();
			
			returnValue = 0;
			RsCari = Module1.getSqldb("select v_amt from newvoc where v_no = '" + nomor + "' AND (V_FLAG IS NULL) AND (V_SELL IS NOT NULL)", Module1.ConnServer);
			if (RsCari.Tables[0].Rows.Count > 0)
			{
				returnValue = System.Convert.ToInt32(RsCari.Tables[0].Rows[0]["v_amt"]);
			}
			else
			{
				returnValue = 0;
			}
			if (returnValue == 0)
			{
				Interaction.MsgBox("Nomor Voucher tidak valid", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
				RsCari.Clear();
				RsCari = null;
				txtno_voc.Text = "";
				return returnValue;
			}
			RsCari.Clear();
			RsCari = null;
			
			RsDobel = Module1.getSqldb("select credit_card_no from paid where credit_card_no = '" + nomor + "'", Module1.ConnServer);
			if (RsDobel.Tables[0].Rows.Count > 0)
			{
				Interaction.MsgBox("Nomor Voucher Sudah Pernah Dipakai", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
				returnValue = 0;
				txtno_voc.Text = "";
			}
			RsDobel.Clear();
			RsDobel = null;
			return returnValue;
		}
		
		private int Cek_Voc2(string nomor)
		{
			int returnValue = 0;
			
			DataSet dsUnique = new DataSet();
			DataSet RsDobel = new DataSet();
			returnValue = 0;
			dsUnique = Module1.getSqldb("select * from UniqueCode where UniqueCode = '" + nomor.Trim() + "'  And End_Date >= getdate()", Module1.ConnServer);
			if (dsUnique.Tables[0].Rows.Count > 0)
			{
				if (dsUnique.Tables[0].Rows[0]["Flag"].ToString().Trim() != "0")
				{
					MessageBox.Show("Kode Voucher Sudah Pernah Digunakan !!!");
					returnValue = 0;
					UniqueCode = "";
					txtno_voc.Focus();
					return returnValue;
				}
				UniqueCode = dsUnique.Tables[0].Rows[0]["UniqueCode"].ToString().Trim();
				if (dsUnique.Tables[0].Rows[0]["PromoDisc"].ToString().Trim() != "0")
				{
					txtvoucher.Text = System.Convert.ToString((System.Convert.ToInt32(dsUnique.Tables[0].Rows[0]["PromoDisc"]) / 100) * System.Convert.ToInt32(vpay.Text));
					returnValue = System.Convert.ToInt32((System.Convert.ToInt32(dsUnique.Tables[0].Rows[0]["PromoDisc"]) / 100) * System.Convert.ToInt32(vpay.Text));
				}
				else
				{
					txtvoucher.Text = System.Convert.ToString(dsUnique.Tables[0].Rows[0]["PromoValue"]);
					returnValue = System.Convert.ToInt32(dsUnique.Tables[0].Rows[0]["PromoValue"]);
				}
				txtvoucher.ReadOnly = false;
				txtvoucher.SelectionStart = 0;
				txtvoucher.SelectionLength = txtcash.Text.Length;
				txtvoucher.Focus();
			}
			else
			{
				MessageBox.Show("Kode Voucher Tidak Terdaftar !!!");
				returnValue = 0;
				UniqueCode = "";
				txtno_voc.Focus();
				return returnValue;
			}
			
			RsDobel = Module1.getSqldb("select credit_card_no from paid where credit_card_no = '" + nomor + "'", Module1.ConnServer);
			if (RsDobel.Tables[0].Rows.Count > 0)
			{
				Interaction.MsgBox("Nomor Voucher Sudah Pernah Dipakai", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
				returnValue = 0;
				txtno_voc.Text = "";
			}
			RsDobel.Clear();
			RsDobel = null;
			return returnValue;
		}
		private bool Simpan_Detail(double bayar, string card_no, ref string card_num)
		{
			bool returnValue = false;
			try
			{
				DataSet dsCek = new DataSet();
				returnValue = false;
				
				//Menghindari Bug Duplicate Payment
				dsCek = Module1.getSqldb("select sum(Paid_Amount) as Paid_Amount from paid where transaction_number = '" + vno_trans.Text + "' and payment_types <> '31' having sum(Paid_Amount) is not null", Module1.ConnLocal);
				if (dsCek.Tables[0].Rows.Count > 0)
				{
					if (double.Parse(lbltotal.Text) <= System.Convert.ToDouble(dsCek.Tables[0].Rows[0]["Paid_Amount"]))
					{
						goto _1;
					}
				}
				//selesai
				Module1.getSqldb("INSERT Into Paid(Transaction_Number, Payment_Types, Seq, Currency_ID, Currency_Rate, Credit_Card_No, " + "Credit_Card_Name, Paid_Amount, Shift) VALUES ('" + vno_trans.Text + "','" + System.Convert.ToString(DataGridView1[0, DataGridView1.CurrentRow.Index].Value) + "','" + Gen_Seq() + "','IDR','1','" + card_no + "','" + Module1.UbahChar(card_num) + "'," + System.Convert.ToString(bayar) + ",'" + System.Convert.ToString(Module1.VShift) + "')", Module1.ConnLocal);
				Module1.SaveLog(this.Name + " " + "Simpan_Paid " + vno_trans.Text + " " + System.Convert.ToString(bayar) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
_1:
				Tdata2.Clear();
				Tdata2 = Module1.getSqldb("SELECT aa.Seq, bb.Description, Paid_Amount, Credit_Card_No, Credit_Card_Name " + "FROM Paid aa INNER JOIN Payment_Types bb ON aa.Payment_Types = bb.Payment_Types" + " where transaction_number = '" + vno_trans.Text + "' order by seq", Module1.ConnLocal);
				DataGridView2.DataSource = null;
				DataGridView2.DataSource = Tdata2.Tables[0];
				DataGridView2.Columns[0].HeaderText = "No";
				DataGridView2.Columns[0].Width = 30;
				DataGridView2.Columns[1].HeaderText = "Tipe";
				DataGridView2.Columns[1].Width = 100;
				DataGridView2.Columns[2].HeaderText = "Nilai";
				DataGridView2.Columns[2].Width = 90;
				DataGridView2.Columns[3].HeaderText = "No Kartu";
				DataGridView2.Columns[3].Width = 100;
				DataGridView2.Columns[4].HeaderText = "Nama Kartu";
				DataGridView2.Columns[4].Width = 120;
				DataGridView2.Columns["Paid_Amount"].DefaultCellStyle.Format = "N0";
				//vpay = vpay - (bayar + TotPay)
				if (RoundOfPay != 0 && (bayar + (double.Parse(lblbayar.Text)) + RoundOfPay) < TotPay)
				{
					vpay.Text = System.Convert.ToString(double.Parse(vpay.Text) - (bayar));
					lblbayar.Text = System.Convert.ToString(((decimal) ((double.Parse(lblbayar.Text)) + bayar)).ToString("N0"));
					lblsisa.Text = System.Convert.ToString(((decimal) ((double.Parse(lbltotal.Text)) - double.Parse(lblbayar.Text))).ToString("N0"));
				}
				else
				{
					vpay.Text = System.Convert.ToString(double.Parse(vpay.Text) - (bayar + RoundOfPay));
					lblbayar.Text = System.Convert.ToString(((decimal) ((double.Parse(lbltotal.Text)) - double.Parse(vpay.Text))).ToString("N0"));
					lblsisa.Text = System.Convert.ToString((decimal.Parse(vpay.Text)).ToString("N0"));
				}
				
				return true;
			}
			catch
			{
				Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				Module1.SaveLog(this.Name + " " + "Simpan_Detail " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			
			return returnValue;
		}
		private void Cek_Lunas()
		{
			//On Error Goto ErrH VBConversions Warning: could not be converted to try/catch - logic too complex
			byte q = 0;
			int l;
			DataSet RsCari = new DataSet();
			string strRf = "";
			if (double.Parse(vpay.Text) <= 0 && vstatus.Text.Trim() == "SALES") //jika lunas
			{
				if (RoundOfPay != 0)
				{
					Module1.getSqldb("Insert Into Paid select top 1 '" + vno_trans.Text + "','36',(Select top 1 seq + 1 from paid where transaction_number = '" + vno_trans.Text + "' Order By Seq desc),'IDR','1','','ROUNDING'," + System.Convert.ToString(RoundOfPay) + ",Shift from paid where transaction_number = '" + vno_trans.Text + "'", Module1.ConnLocal);
				}
				
				Paid_To_Sales(vno_trans.Text, System.Convert.ToInt32((double.Parse(lbltotal.Text)) + RoundOfPay), System.Convert.ToInt32(double.Parse(txtkembali.Text) > 0 ? System.Convert.ToInt32(txtkembali.Text) : 0));
				goto lanjut;
			}
			
			if (double.Parse(vpay.Text) >= 0 && vstatus.Text.Trim() == "REFUND") //jika lunas
			{
				if (RoundOfPay != 0)
				{
					Module1.getSqldb("Insert Into Paid select top 1 '" + vno_trans.Text + "','36',(Select top 1 seq + 1 from paid where transaction_number = '" + vno_trans.Text + "' Order By Seq desc),'IDR','1','','ROUNDING'," + System.Convert.ToString(RoundOfPay) + ",Shift from paid where transaction_number = '" + vno_trans.Text + "'", Module1.ConnLocal);
				}
				Paid_To_Sales(vno_trans.Text, int.Parse(lbltotal.Text), System.Convert.ToInt32(double.Parse(txtkembali.Text) < 0 ? System.Convert.ToInt32(txtkembali.Text) : 0));
				goto lanjut;
			}
			DataGridView1.ClearSelection();
			DataGridView1.Select();
			DataGridView1.Focus();
			DataGridView1.CurrentCell = DataGridView1.Rows[0].Cells[1];
			DataGridView1.Rows[DataGridView1.CurrentRow.Index].Selected = true;
			//DataGridView1_CellClick(Me.DataGridView1, New DataGridViewCellEventArgs(1, 0))
			_frmpay_0.Visible = true;
			_frmpay_1.Visible = false;
			_frmpay_2.Visible = false;
			_frmpay_3.Visible = false;
			
			_frmpay_0.Visible = true;
			RoundOfPay = System.Convert.ToInt32(double.Parse(vpay.Text) - (Conversion.Int(double.Parse(vpay.Text) / 100)) * 100);
			if (double.Parse(vpay.Text) < 0)
			{
				if (double.Parse(vpay.Text) != Conversion.Int(double.Parse(vpay.Text) / 100) * 100)
				{
					RoundOfPay = System.Convert.ToInt32(double.Parse(vpay.Text) - (Conversion.Int(double.Parse(vpay.Text) / 100) + 1) * 100);
				}
				else
				{
					RoundOfPay = 0;
				}
			}
			//RoundOfPay = 0
			lbltotal.Text = System.Convert.ToString((TotPay - RoundOfPay).ToString("N0"));
			lblsisa.Text = System.Convert.ToString(((decimal) (double.Parse(vpay.Text) - RoundOfPay)).ToString("N0"));
			txtcash.Text = System.Convert.ToString(((decimal) (double.Parse(vpay.Text) - RoundOfPay)).ToString("N0"));
			//txtcash.Text = CDec(vpay.Text).ToString("N0")
			txtcash.Select();
			txtcash.Focus();
			txtcash.SelectionStart = 0;
			txtcash.SelectionLength = txtcash.Text.Length;
			lokasi = "txtcash";
			//KeyDownEnterDgv()
			return;
lanjut:
			//tambahan update v_flag voucher automatic
			
			if (vstatus.Text.Trim() == "SALES")
			{
				strRf = "update a set a.flag = 1 from  Item_Master_RFID a inner join sales_transaction_details b on a.plu = b.plu and a.TID = b.epc_code " +
					"where b.transaction_number = '" + vno_trans.Text + "' and b.flag_void = 0";
			}
			else
			{
				strRf = "update a set a.flag = 0 from Item_Master_RFID a inner join sales_transaction_details b on a.plu = b.plu and a.TID = b.epc_code " +
					"where b.transaction_number = '" + vno_trans.Text + "' and b.flag_void = 0";
			}
			
			//bali
			//If vstatus.Text.Trim = "SALES" Then
			//    strRf = "update a set a.flag = 1 from [POS_SERVER_HISTORY].dbo.Item_Master_RFID a inner join sales_transaction_details b on a.plu = b.plu and a.TID = b.epc_code " &
			//             "where b.transaction_number = '" & vno_trans.Text & "' and b.flag_void = 0"
			//Else
			//    strRf = "update a set a.flag = 0 from [POS_SERVER_HISTORY].dbo.Item_Master_RFID a inner join sales_transaction_details b on a.plu = b.plu and a.TID = b.epc_code " &
			//             "where b.transaction_number = '" & vno_trans.Text & "' and b.flag_void = 0"
			//End If
			
			Module1.getSqldb(strRf, Module1.ConnLocal);
			
			//If Linked() Then
			//    Call Upload_to_Server(vno_trans.Text)
			//    getSqldb(strRf, ConnServer)
			//    'getSqldb("Update newvoc Set v_flag = 'R',V_REC = CONVERT(VARCHAR(10), GETDATE(), 120)  where V_NO in (Select credit_card_no from paid " &
			//    '         "where payment_types = 8 And transaction_number = '" & vno_trans.Text & "')", ConnServer)
			//End If
			
			//tanpa cek PING
			if (Module1.VPing == "ONLINE")
			{
				Upload_to_Server(vno_trans.Text);
				Module1.getSqldb(strRf, Module1.ConnServer);
				//getSqldb("Update newvoc Set v_flag = 'R',V_REC = CONVERT(VARCHAR(10), GETDATE(), 120)  where V_NO in (Select credit_card_no from paid " &
				//         "where payment_types = 8 And transaction_number = '" & vno_trans.Text & "')", ConnServer)
			}
			_cmdpay_0.Enabled = false;
			Cetak.CetakStruk(vstatus.Text, vno_trans.Text);
			if (Module1.VPing != "ONLINE")
			{
				Cetak.CetakStruk(vstatus.Text, vno_trans.Text);
			}
			Module1.SaveLog(this.Name + " " + "Transaction Success " + vno_trans.Text + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			//Call CetakStruk(vstatus.Text, vno_trans.Text)
			//If txtcard_no.Text.Trim <> "CM000-00000" Then Call Save_Point(vno_trans.Text, txtcard_no.Text)
			Cetak.OpenLaci((byte) 0); // buka drawer tanpa print
			
			if (Module1.VPing == "ONLINE")
			{
				if (!string.IsNullOrEmpty(UniqueCode))
				{
					Module1.getSqldb("Update UniqueCode set flag = 1 where UniqueCode = '" + UniqueCode + "'", Module1.ConnServer);
				}
			}
			
			
			l = 0;
			
			if (l == 0)
			{
				if (vstatus.Text.Trim() == "SALES")
				{
					string temp_No_trans = vno_trans.Text;
					CetakPromo(ref temp_No_trans);
					vno_trans.Text = temp_No_trans;
				}
			}
			
			//If Linked() Then Call CetakStrukPayPoint(txtcard_no.Text, VB.Left(Star_Nm, 22), vno_trans.Text)
			
			//tanpa cek PING
			//If VPing = "ONLINE" Then Call CetakStrukPayPoint(txtcard_no.Text, VB.Left(Star_Nm, 22), vno_trans.Text)
			
			for (q = 0; q <= 4; q++)
			{
				frmSales.Default.cmdsales[q].Enabled = false;
			}
			
			frmSales.Default.cmdsales[8].Enabled = false;
			frmSales.Default.cmdsales[9].Enabled = false;
			frmSales.Default.txtkode.Enabled = false;
			frmSales.Default.RfidScan2.Enabled = false;
			frmSales.Default.CmdNav[0].Enabled = false;
			frmSales.Default.CmdNav[3].Enabled = false;
			frmSales.Default.Label1.Text = "Change : Rp";
			
			if (vstatus.Text.Trim() == "SALES")
			{
				frmSales.Default.lblgrand_total.Text = System.Convert.ToString((System.Convert.ToDecimal(double.Parse(txtkembali.Text) > 0 ? System.Convert.ToInt32(txtkembali.Text) : 0)).ToString("N0"));
			}
			else
			{
				frmSales.Default.lblgrand_total.Text = System.Convert.ToString((System.Convert.ToDecimal(double.Parse(txtkembali.Text) < 0 ? System.Convert.ToInt32(txtkembali.Text) : 0)).ToString("N0"));
			}
			
			frmSales.Default.cmdsales[6].Text = "VALIDATE TOTAL";
			frmSales.Default.cmdsales[6].ImageAlign = ContentAlignment.BottomCenter;
			frmSales.Default.cmdsales[6].TextImageRelation = TextImageRelation.ImageAboveText;
			Cetak.CDisplay("CHANGE :", "Rp. " + frmSales.Default.lblgrand_total.Text);
			vpay.Text = "0";
			Kosong();
			//VNomor = ""
			
			this.Close();
			return;
ErrH:
			Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
			Module1.SaveLog(this.Name + " " + "Cek Lunas " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
		}
		private void CetakPromo(ref string No_trans)
		{
			DataSet RsPromo = new DataSet();
			DataSet RsBayar = new DataSet();
			short JmlKupon = 0;
			int NilaiOK = 0;
			int ByrNonVoc = 0;
			string Msg = "";
			int min_belanja = 0;
			
			Module1.StrSQL = "SELECT promo_hdr.promo_id, promo_name, min_purchase, min_member, disc, tipe, voucher, lipat, ismsg, isprn , " +
				"SUM(Sales_Transaction_Details.Net_Price) As Belanja, islimit, qtylimit, qtyout, isnull(txt1,'') as txt1, " +
				"isnull(txt2,'') as txt2, isnull(txt3,'') as txt3, isnull(txt4,'') as txt4 FROM Promo_Hdr INNER JOIN " +
				"Promo_Dtl ON Promo_Hdr.promo_id = Promo_Dtl.promo_id INNER JOIN Sales_Transaction_Details ON Promo_Dtl.PLU = " +
				"Sales_Transaction_Details.PLU WHERE (Sales_Transaction_Details.Transaction_Number = '" + No_trans + "') " +
				"AND getdate() Between Start_Date And End_Date And aktif=1 GROUP BY promo_hdr.promo_id, promo_name, " +
				"min_purchase, min_member, disc, tipe, voucher, lipat, ismsg, isprn, islimit, qtylimit, qtyout, txt1, " +
				"txt2, txt3, txt4 Having (promo_hdr.tipe > 30) And SUM(Sales_Transaction_Details.Net_Price)>0 order " +
				"by promo_hdr.promo_id";
			
			//If Linked() Then
			//    RsPromo = getSqldb(StrSQL, ConnServer)
			//Else
			//    RsPromo = getSqldb(StrSQL, ConnLocal)
			//End If
			//tanpa cek PING
			if (Module1.VPing == "ONLINE")
			{
				RsPromo = Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
			}
			else
			{
				RsPromo = Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
			}
			
			if (RsPromo.Tables[0].Rows.Count == 0)
			{
				RsPromo.Clear();
				RsPromo = null;
				return;
			}
			
			RsBayar = Module1.getSqldb("SELECT Transaction_Number, SUM(Paid_Amount) AS Bayar From Paid where(Payment_Types Not in " +
				"('8','5')) " + "GROUP BY Transaction_Number " + "HAVING (Transaction_Number = '" + No_trans + "')", Module1.ConnLocal);
			
			if (RsBayar.Tables[0].Rows.Count > 0)
			{
				ByrNonVoc = System.Convert.ToInt32(RsBayar.Tables[0].Rows[0]["bayar"]);
			}
			else
			{
				ByrNonVoc = 0;
			}
			RsBayar.Clear();
			RsBayar = null;
			
			DataSet RsLagi1 = new DataSet();
			DataSet RsBayarAll = new DataSet();
			DataSet RsLagi = new DataSet();
			string[] NilaiTransx = new string[11];
			string[] NilaiInfox = new string[11];
			foreach (DataRow ro in RsPromo.Tables[0].Rows)
			{
				if (VB.Strings.Left(Module1.Star_Id, 6) == "100000" || string.IsNullOrEmpty(Module1.Star_Id))
				{
					min_belanja = System.Convert.ToInt32(ro["min_purchase"]);
				}
				else
				{
					min_belanja = System.Convert.ToInt32(ro["min_member"]);
				}
				
				Msg = "";
				if ((int) (ro["tipe"]) == 31) //GWP
				{
					JmlKupon = (short) 0;
					if ((int) ro["voucher"] == 0 && (int) ro["lipat"] == 0)
					{
						if (ByrNonVoc < System.Convert.ToInt32(ro["Belanja"]))
						{
							NilaiOK = ByrNonVoc;
						}
						else
						{
							NilaiOK = System.Convert.ToInt32(ro["Belanja"]);
						}
						
						if (NilaiOK >= min_belanja)
						{
							JmlKupon = (short) 1;
						}
					}
					else if ((int) ro["voucher"] == 1 && (int) ro["lipat"] == 0)
					{
						if (System.Convert.ToInt32(ro["Belanja"]) >= min_belanja)
						{
							NilaiOK = System.Convert.ToInt32(ro["Belanja"]);
							JmlKupon = (short) 1;
						}
					}
					else if ((int) ro["voucher"] == 0 && (int) ro["lipat"] == 1)
					{
						if (ByrNonVoc < System.Convert.ToInt32(ro["Belanja"]))
						{
							NilaiOK = ByrNonVoc;
						}
						else
						{
							NilaiOK = System.Convert.ToInt32(ro["Belanja"]);
						}
						
						if (NilaiOK >= min_belanja)
						{
							JmlKupon = (short) (Point.roundDown((double) NilaiOK / min_belanja));
						}
					}
					else if ((int) ro["voucher"] == 1 && (int) ro["lipat"] == 1)
					{
						if (System.Convert.ToInt32(ro["Belanja"]) >= min_belanja)
						{
							NilaiOK = System.Convert.ToInt32(ro["Belanja"]);
							JmlKupon = (short) (Point.roundDown((double) NilaiOK / min_belanja));
						}
					}
					
					if (JmlKupon > 0)
					{
						if ((int) ro["islimit"] == 1)
						{
							if (System.Convert.ToDouble(ro["QtyLimit"]) < System.Convert.ToDouble(System.Convert.ToInt32(ro["QtyOut"]) + JmlKupon))
							{
								Interaction.MsgBox("Hadiah " + System.Convert.ToString(ro["promo_name"]) + " sudah habis", MsgBoxStyle.Information, "Oops..");
								goto lanjut;
							}
							
							Module1.StrSQL = "insert into promo_sales(promo_id,transaction_number,nilai,qty_promo,status) values ('" + System.Convert.ToString(ro["promo_id"]) + "', '" + No_trans + "', " + System.Convert.ToString(NilaiOK) + ", " + System.Convert.ToString(JmlKupon) + ", '00')";
							
							Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
							//If Linked() Then
							//    getSqldb(StrSQL, ConnServer)
							//    getSqldb("Update promo_sales set status='99' where promo_id = '" & ro("promo_id").Value & "' and transaction_number='" & No_trans & "'", ConnLocal)
							//End If
							
							//tanpa cek PING
							if (Module1.VPing == "ONLINE")
							{
								Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
								Module1.getSqldb("Update promo_sales set status='99' where promo_id = '" + System.Convert.ToString(ro["promo_id"]) + "' and transaction_number='" + No_trans + "'", Module1.ConnLocal);
							}
							
							Module1.StrSQL = "update promo_hdr set qtyout=qtyout+ " + System.Convert.ToString(JmlKupon) + " where promo_id='" + System.Convert.ToString(ro["promo_id"]) + "'";
							
							Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
							//If Linked() Then getSqldb(StrSQL, ConnServer)
							
							//tanpa cek PING
							if (Module1.VPing == "ONLINE")
							{
								Module1.getSqldb(Module1.StrSQL, Module1.ConnServer);
							}
						}
						
						if ((int) ro["tipe"] == 31) //GWP Normal
						{
							if ((string) ro["txt1"] != "")
							{
								Msg = ro["txt1"] + Constants.vbNewLine;
							}
							if ((string) ro["txt2"] != "")
							{
								Msg = Msg + ro["txt2"] + " = " + System.Convert.ToString(JmlKupon) + " pcs";
							}
							if ((string) ro["txt3"] != "")
							{
								Msg = Msg + (Constants.vbNewLine + ro["txt3"]);
							}
							if ((string) ro["txt4"] != "")
							{
								Msg = Msg + (Constants.vbNewLine + ro["txt4"]);
							}
							Msg = Msg + Constants.vbNewLine + Constants.vbNewLine + "Nilai Transaksi : Rp." + (NilaiOK).ToString("N0");
							Msg = Msg + Constants.vbNewLine + "Struk ini hanya berlaku tgl " + Strings.Format(Module1.GetSrvDate(), "dd MMM yy");
						}
						
						if (VB.Strings.Left(Module1.Star_No, 3) != "LM-")
						{
							Msg = Msg + Constants.vbNewLine + "MyLAKON Card : " + Module1.Star_No;
						}
						if ((int) ro["isprn"] == 1)
						{
							Cetak.CetakStruk_Promo(System.Convert.ToString(ro["promo_id"]), No_trans, Msg);
						}
						if ((int) ro["ismsg"] == 1)
						{
							Interaction.MsgBox(Msg, MsgBoxStyle.Information, "Oops..");
						}
						if ((int) ro["islimit"] == 1)
						{
							Interaction.MsgBox("Sisa Stok Hadiah " + System.Convert.ToString(ro["promo_name"]) + " " + System.Convert.ToString(System.Convert.ToDouble(System.Convert.ToInt32(ro["QtyLimit"]) - System.Convert.ToDouble(ro["QtyOut"])) - 1) + " pcs", MsgBoxStyle.Information, "Oops..");
						}
					}
				}
lanjut:
				1.GetHashCode() ; //VBConversions note: C# requires an executable line here, so a dummy line was added.
			}
			RsPromo.Clear();
			RsPromo = null;
			return;
ErrH:
			Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
			Module1.SaveLog(this.Name + " " + "Cek Lunas " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
		}
		private int Pakai_Voc(string No_trans)
		{
			int returnValue = 0;
			DataSet RsVoc = new DataSet();
			
			RsVoc = Module1.getSqldb("select isnull(sum(Paid_Amount),0) as Nvoc from paid pd inner join Payment_Types pt on pd.Payment_Types = pt.Payment_Types " + "where types in ('SV','OV') and Transaction_Number = '" + No_trans + "'", Module1.ConnLocal);
			returnValue = System.Convert.ToInt32(RsVoc.Tables[0].Rows[0]["NVoc"]);
			RsVoc.Clear();
			RsVoc = null;
			return returnValue;
		}
		private void Paid_To_Sales(string nomor, int total, int kembali)
		{
			DataSet RsHitung = new DataSet();
			try
			{
				RsHitung = Module1.getSqldb("select sum(discount_amount+extradisc_amt) as hemat " + "from sales_transaction_details where transaction_number='" + nomor + "'", Module1.ConnLocal);
				
				Module1.StrSQL = "update sales_transactions set total_paid =" + System.Convert.ToString(total + kembali) + ", change_amount=" + System.Convert.ToString(kembali) + ", total_discount=" + RsHitung.Tables[0].Rows[0]["hemat"] + ", status='00' , net_price=net_amount , transaction_time='" + Strings.Format(Module1.GetSrvDate(), "HH:mm") + "' where transaction_number = '" + nomor + "'";
				
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				RsHitung.Clear();
				RsHitung = null;
			}
			catch
			{
				Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				Module1.SaveLog(this.Name + " " + "Paid_To_Sales " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			
		}
		private void Upload_to_Server(string nomor)
		{
			try
			{
				//On Error Resume Next
				string Dbs = "";
				string Svr = "";
				
				Svr = "[" + Module1.VSvr + "]";
				Dbs = Module1.ReadIni("Server", "DatabaseName");
				
				Module1.StrSQL = "Insert " + Svr +"." + Dbs +".dbo.Sales_Transactions (Transaction_Number, Cashier_ID, Customer_ID, Card_Number, Spending_Program_ID, " +
					"Transaction_Date, Total_Discount, Points_Of_Spending_Program, Point_Of_Item_Program, Point_Of_Card_Program, " +
					"Payment_Program_ID, Branch_ID, Cash_Register_ID, Total_Paid, Net_Price, Tax, Net_Amount, Change_Amount, " +
					"Flag_Arrange, WorkManShip, Flag_Return, Register_Return, Transaction_Date_Return, Transaction_Number_Return, " +
					"Last_Point, Get_Point, Status, Upload_Status, Transaction_Time, Store_Type) " +
					"(SELECT  Transaction_Number, Cashier_ID, Customer_ID, Card_Number, Spending_Program_ID, Transaction_Date, Total_Discount, Points_Of_Spending_Program, " +
					"Point_Of_Item_Program, Point_Of_Card_Program, Payment_Program_ID, Branch_ID, Cash_Register_ID, Total_Paid, Net_Price, Tax, Net_Amount, Change_Amount, " +
					"Flag_Arrange, WorkManShip, Flag_Return, Register_Return, Transaction_Date_Return, Transaction_Number_Return, Last_Point, Get_Point, Status, Upload_Status, " +
					"Transaction_Time , Store_Type " +
					"FROM Sales_Transactions where Transaction_Number='" + nomor + "')";
				
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "Insert " + Svr +"." + Dbs +".dbo.Sales_Transaction_details (Transaction_Number, Seq, PLU, Item_Description, Price, Qty, Amount, " +
					"Discount_Percentage, Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, Points_Received, Flag_Void, " + "Flag_Status, Flag_Paket_Discount,Epc_Code) " +
					"(select Transaction_Number, Seq, PLU, Item_Description, Price, Qty, Amount, " +
					"Discount_Percentage, Discount_Amount, ExtraDisc_Pct, ExtraDisc_Amt, Net_Price, Points_Received, Flag_Void, " +
					"Flag_Status , Flag_Paket_Discount, Epc_Code " +
					"FROM Sales_Transaction_details where Transaction_Number='" + nomor + "')";
				
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.StrSQL = "Insert " + Svr +"." + Dbs +".dbo.paid(Transaction_Number, Payment_Types, Seq, Currency_ID, Currency_Rate, " +
					"Credit_Card_No, Credit_Card_Name, Paid_Amount, Shift) " + "(select Transaction_Number, Payment_Types, Seq, Currency_ID, Currency_Rate, Credit_Card_No, " +
					"Credit_Card_Name , Paid_Amount, Shift " +
					"FROM paid where Transaction_Number='" + nomor + "')";
				
				Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
				
				Module1.getSqldb("Update sales_transactions set upload_status='99' where transaction_number='" + nomor + "'", Module1.ConnLocal);
				Module1.SaveLog(this.Name + " " + "Upload_to_Server " + Module1.VSuper_Nm + " " + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			catch
			{
				Interaction.MsgBox(Information.Err().Description.ToUpper(), (int) MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Oops..");
				Module1.SaveLog(this.Name + " " + "Upload_to_Server " + Information.Err().Description + " " + System.Convert.ToString(Information.Err().Number) + " " + Strings.Format(DateTime.Now, "HH:mm:ss"));
			}
			
		}
		private void tampil_point()
		{
			txtsaldo_point.Text = System.Convert.ToString(Module1.Star_Pt);
			txtpoint.Text = System.Convert.ToString(double.Parse(txtsaldo_point.Text) * double.Parse(txtharga_point.Text));
			txttukar_point.Text = System.Convert.ToString(((decimal) (Point.roundDown(double.Parse(txtpoint.Text) / double.Parse(txtharga_point.Text)))).ToString("N0"));
		}
		public void txtpoint_Enter(System.Object eventSender, System.EventArgs eventArgs)
		{
			lokasi = "txtpoint";
		}
		public void txttukar_point_Enter(System.Object eventSender, System.EventArgs eventArgs)
		{
			lokasi = "txttukar_point";
		}
		public void txttukar_point_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			DataSet RsPr = new DataSet();
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					
					//If Linked() = False Then
					//    MsgBox("Pembayaran dengan point reward harus Online", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..")
					//    Exit Sub
					//End If
					
					//tanpa cek PING
					if (Module1.VPing == "OFFLINE")
					{
						Interaction.MsgBox("Pembayaran dengan point reward harus Online", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
						return;
					}
					
					if (double.Parse(txtsaldo_point.Text) < 20)
					{
						Interaction.MsgBox("Minimal Saldo point harus 20", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
						return;
					}
					
					if (string.Compare(txttukar_point.Text, txtsaldo_point.Text) > 0)
					{
						Interaction.MsgBox("Saldo point tidak mencukupi", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
						return;
					}
					
					if (txtcard_no.Text == "LM-00000000")
					{
						Interaction.MsgBox("Pembayaran dengan point hanya untuk member MSC", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
						return;
					}
					
					Module1.StrSQL = "SELECT * from paid WHERE payment_types='5' and transaction_number='" + vno_trans.Text + "'";
					RsPr = Module1.getSqldb(Module1.StrSQL, Module1.ConnLocal);
					
					if (RsPr.Tables[0].Rows.Count > 0)
					{
						Interaction.MsgBox("Pembayaran dengan point hanya bisa 1 kali/transaksi", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
						RsPr.Clear();
						RsPr = null;
						return;
					}
					RsPr.Clear();
					RsPr = null;
					
					if (double.Parse(txttukar_point.Text) > 0)
					{
						if (string.Compare(txtpoint.Text, vpay.Text) > 0)
						{
							Interaction.MsgBox("Pembayaran dengan point reward tidak boleh " + Constants.vbNewLine + "melebihi sisa yang harus dibayar", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
							txttukar_point.Focus();
							System.Windows.Forms.Application.DoEvents();
							System.Windows.Forms.SendKeys.Send("{home}+{end}");
						}
						else
						{
							DataGridView1.Focus();
							string temp_NoCard = txtcard_no.Text;
							VTukar_Point = Point.Pay_Point(short.Parse(txttukar_point.Text), ref temp_NoCard, vno_trans.Text, System.Convert.ToInt32(txtpoint.Text));
							txtcard_no.Text = temp_NoCard;
							if (VTukar_Point != "GAGAL")
							{
								Simpan_Detail(double.Parse(txtpoint.Text), txtcard_no.Text, ref VTukar_Point);
								tampil_point();
								txttukar_point.Text = "0";
								Cek_Lunas();
							}
							else
							{
								Interaction.MsgBox("Pembayaran dengan point reward GAGAL", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
								return;
							}
						}
					}
					else
					{
						Interaction.MsgBox("Transaksi Refund tidak bisa menggunakan point reward", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
					}
					break;
				case (System.Windows.Forms.Keys) 27:
					DataGridView1.Focus();
					break;
			}
		}
		
		//    Private Sub txttukar_point_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txttukar_point.TextChanged
		//        On Error GoTo x
		//        txtpoint.Text = CDec(txttukar_point.Text * CDbl(txtharga_point.Text)).ToString("N0")
		//        Exit Sub
		//x:
		//        txttukar_point.Text = txtsaldo_point.Text
		//        txtpoint.Text = CDec(txttukar_point.Text * CDbl(txtharga_point.Text)).ToString("N0")
		//    End Sub
		public void txtpoint_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					txttukar_point.Focus();
					break;
				case (System.Windows.Forms.Keys) 27:
					DataGridView1.Focus();
					break;
			}
		}
		public void txtpoint_Leave(System.Object eventSender, System.EventArgs eventArgs)
		{
			txttukar_point.Text = System.Convert.ToString(((decimal) (Point.roundDown(double.Parse(txtpoint.Text) / double.Parse(txtharga_point.Text)))).ToString("N0"));
			txtpoint.Text = System.Convert.ToString(((decimal) (double.Parse(txttukar_point.Text) * double.Parse(txtharga_point.Text))).ToString("N0"));
		}
		public void _cmdpay_0_Click(System.Object sender, System.EventArgs e)
		{
			Button btn = (Button) sender;
			if (btn.Text == "CLOSE")
			{
				ClosePayment();
			}
			else if (btn.Text == "DOWN")
			{
				DataGridView1.ClearSelection();
				if (DataGridView1.CurrentRow.Index == DataGridView1.RowCount)
				{
				}
				else
				{
					DataGridView1.CurrentCell = DataGridView1.Rows[DataGridView1.CurrentRow.Index + 1].Cells[1];
					DataGridView1.Rows[DataGridView1.CurrentRow.Index].Selected = true;
					DataGridView1_CellClick(this.DataGridView1, new DataGridViewCellEventArgs(1, DataGridView1.CurrentRow.Index));
					//DataGridView1.Focus()
				}
			}
			else if (btn.Text == "UP")
			{
				DataGridView1.ClearSelection();
				if (DataGridView1.CurrentRow.Index == 0)
				{
				}
				else
				{
					DataGridView1.CurrentCell = DataGridView1.Rows[DataGridView1.CurrentRow.Index - 1].Cells[1];
					DataGridView1.Rows[DataGridView1.CurrentRow.Index].Selected = true;
					DataGridView1_CellClick(this.DataGridView1, new DataGridViewCellEventArgs(1, DataGridView1.CurrentRow.Index));
					//DataGridView1.Focus()
				}
			}
		}
		public void txtcredit_TextChanged(object sender, System.EventArgs e)
		{
			try
			{
				if (txtcredit.Text != "")
				{
					txtcredit.Text = System.Convert.ToString((decimal.Parse(txtcredit.Text)).ToString("N0"));
					txtcredit.SelectionStart = txtcredit.TextLength;
				}
			}
			catch (Exception)
			{
				
			}
			
		}
		public void btnNum_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			short Index = 1;
			if (DataGridView1.SelectedRows.Count > 0 && string.IsNullOrEmpty(lokasi))
			{
				switch (Index)
				{
					case (short) 11:
						KeyDownEnterDgv();
						return;
				}
			}
			
			
			//On Error Resume Next VBConversions Warning: On Error Resume Next not supported in C#
			System.Windows.Forms.Control box = default(System.Windows.Forms.Control);
			TextBox txt = new TextBox();
			foreach (System.Windows.Forms.Control tempLoopVar_box in this.Controls)
			{
				box = tempLoopVar_box;
				if (box is GroupBox)
				{
					foreach (Control cntrl in box.Controls)
					{
						if (cntrl is TextBox&& cntrl.Name == lokasi)
						{
							txt = (TextBox) cntrl;
							break;
						}
					}
				}
			}
			switch (lokasi)
			{
				case "txtcash":
				case "txtcredit":
				case "txtvoucher":
				case "txttukar_point":
					if (Index < 10)
					{
						if (txt.SelectionLength == txt.Text.Length)
						{
							txt.Text = System.Convert.ToString(btnNum[Index].Text);
						}
						else
						{
							txt.Text = txt.Text + System.Convert.ToString(btnNum[Index].Text);
						}
						txt.SelectionStart = txt.Text.Length;
					}
					switch (Index)
					{
						case (short) 10:
							txt.Select();
							txt.Focus();
							SendKeys.Send("{end}+{backspace}");
							break;
						case (short) 11:
							txt.Select();
							txt.Focus();
							if (lokasi == "txtcredit")
							{
								if ((vstatus.Text.Trim() == "SALES" && decimal.Parse(txtcredit.Text) <= decimal.Parse(vpay.Text)) || (vstatus.Text.Trim() == "REFUND" && decimal.Parse(txtcredit.Text) >= decimal.Parse(vpay.Text)))
								{
									DataGridView1.Focus();
									string temp_card_num = VB.Strings.Left(txtnama.Text, 50);
									if (Simpan_Detail(double.Parse(txtcredit.Text), VB.Strings.Left(txtno_kartu.Text, 16), ref temp_card_num))
									{
										txtno_kartu.Text = "";
										txtno_kartu.Text = Module1.no_kartuECR;
										txtnama.Text = "";
										txtcredit.Text = "0";
										Cek_Lunas();
									}
								}
								else
								{
									Interaction.MsgBox("Pembayaran dengan kartu kredit/debit tidak boleh " + Constants.vbNewLine + "melebihi sisa yang harus dibayar", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
									txtcredit.Focus();
								}
							}
							else
							{
								SendKeys.Send("{enter}");
							}
							break;
						case (short) 12:
							txt.Text = "0";
							break;
					}
					txt.Focus();
					break;
				case "txtno_kartu":
				case "txtno_voc":
					if (txtno_kartu.Text.Length > 10 && txtcredit.Enabled == false)
					{
						if ((vstatus.Text.Trim() == "SALES" && string.Compare(txtcredit.Text, vpay.Text) <= 0) || (vstatus.Text.Trim() == "REFUND" && string.Compare(txtcredit.Text, vpay.Text) >= 0))
						{
							DataGridView1.Focus();
							string temp_card_num2 = VB.Strings.Left(txtnama.Text, 50);
							if (Simpan_Detail(double.Parse(txtcredit.Text), VB.Strings.Left(txtno_kartu.Text, 16), ref temp_card_num2))
							{
								txtno_kartu.Text = "";
								txtno_kartu.Text = Module1.no_kartuECR;
								txtnama.Text = "";
								txtcredit.Text = "0";
								Cek_Lunas();
							}
						}
						else
						{
							Interaction.MsgBox("Pembayaran dengan kartu kredit/debit tidak boleh " + Constants.vbNewLine + "melebihi sisa yang harus dibayar", (int) MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Oops..");
							txtcredit.Focus();
						}
						return;
					}
					if (Index < 10)
					{
						if (txt.SelectionLength == txt.Text.Length)
						{
							txt.Text = System.Convert.ToString(btnNum[Index].Text);
						}
						else
						{
							txt.Text = txt.Text + System.Convert.ToString(btnNum[Index].Text);
						}
						txt.SelectionStart = txt.Text.Length;
					}
					switch (Index)
					{
						case (short) 10:
							txt.Select();
							txt.Focus();
							SendKeys.Send("{end}+{backspace}");
							break;
						case (short) 11:
							txt.Select();
							txt.Focus();
							SendKeys.Send("{enter}");
							break;
						case (short) 12:
							txt.Text = "";
							break;
					}
					txt.Focus();
					break;
				default:
					break;
					
			}
			System.Windows.Forms.SendKeys.Send("{end}");
		}
		public void txtpoint_TextChanged(object sender, System.EventArgs e)
		{
			if (txtpoint.Text != "")
			{
				txtpoint.Text = System.Convert.ToString((decimal.Parse(txtpoint.Text)).ToString("N0"));
				txtpoint.SelectionStart = txtpoint.TextLength;
			}
		}
		public void txtkembali_TextChanged(object sender, System.EventArgs e)
		{
			if (txtcash.Text != "" && txtkembali.Text != "")
			{
				txtkembali.Text = System.Convert.ToString((decimal.Parse(txtkembali.Text)).ToString("N0"));
				txtkembali.SelectionStart = txtkembali.TextLength;
			}
		}
		public void txtno_kartu_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (Strings.Asc(e.KeyChar) != 8)
			{
				if (Strings.Asc(e.KeyChar) < 48 || Strings.Asc(e.KeyChar) > 57)
				{
					e.Handled = true;
				}
			}
		}
		public void txtno_kartu_TextChanged(object sender, EventArgs e)
		{
			if (txtno_kartu.Text.Length > 16)
			{
				txtno_kartu.Text = VB.Strings.Left(txtno_kartu.Text, 16);
			}
		}
		public void txtvoucher_Enter(object sender, EventArgs e)
		{
			lokasi = "txtvoucher";
		}
		public void txtvoucher_TextChanged(object sender, EventArgs e)
		{
			if (txtvoucher.Text != "")
			{
				txtvoucher.Text = System.Convert.ToString((decimal.Parse(txtvoucher.Text)).ToString("N0"));
				txtvoucher.SelectionStart = txtvoucher.TextLength;
			}
		}
		public void Kosong()
		{
			txtcard_no.Clear();
			txtcash.Clear();
			txtcredit.Clear();
			txtharga_point.Clear();
			txtnama.Clear();
			txtno_kartu.Clear();
			txtno_voc.Clear();
			txtpoint.Clear();
			txtsaldo_point.Clear();
			txttukar_point.Clear();
			txtvoucher.Clear();
			Module1.VDiscBySTAR = 0;
			//GotoPayment = False
		}
		
		public void Timer1_Tick(object sender, EventArgs e)
		{
			cnt++;
			if (cnt > 2000)
			{
				Timer1.Stop();
				Label3.Visible = false;
				if (Interaction.MsgBox("Connections Time Out !!! Try Again??", MsgBoxStyle.YesNo, null) == MsgBoxResult.Yes)
				{
					cnt = 11;
					Label3.Visible = true;
					Timer1.Start();
				}
				else
				{
					Timer1.Enabled = false;
					Timer1.Stop();
					Frame2.Enabled = true;
					Label3.Visible = false;
					_cmdpay_0.Enabled = true;
					txtno_kartu.Enabled = true;
					txtnama.Enabled = true;
					txtcredit.Enabled = true;
					return;
				}
			}
			
			if (cnt > 10)
			{
				if (SerialPort1.IsOpen == false)
				{
					SerialPort1.Open();
				}
				string buff = "";
				short i = 0;
				string d = "";
				int count;
				count = SerialPort1.BytesToRead;
				
				Response = "";
				buff = SerialPort1.ReadExisting();
				
				for (i = 1; i <= buff.Length; i++)
				{
					d = Conversion.Hex(Strings.Asc(buff.Substring(i - 1, 1)));
					Response = Response + d;
				}
				
				if (Response == "6")
				{
					Response = "";
				}
				
				if (!string.IsNullOrEmpty(Response))
				{
					SerialPort1.Close();
					string ResponseASCII = "";
					ResponseASCII = HexToString(Response.Substring(8, Response.Length - 12));
					if (ResponseASCII.Substring(47, 2) != "00")
					{
						Timer1.Enabled = false;
						Timer1.Stop();
						MessageBox.Show("Respon Failed From EDC Device !!!");
						Frame2.Enabled = true;
						Label3.Visible = false;
						_cmdpay_0.Enabled = true;
						txtno_kartu.Enabled = true;
						txtnama.Enabled = true;
						txtcredit.Enabled = true;
						return;
					}
					Timer1.Enabled = false;
					Timer1.Stop();
					Module1.no_kartuECR = VB.Strings.Left(ResponseASCII.Substring(24, 19), 16);
					txtno_kartu.Text = Module1.no_kartuECR;
					if (ResponseASCII.Substring(162, 1) == "Y")
					{
						txtnama.Text = "*" + ResponseASCII.Substring(177, 3) + "*";
					}
					
					txtno_kartu.Enabled = false;
					txtnama.Enabled = false;
					Frame2.Enabled = true;
					Label3.Visible = false;
					lokasi = "txtcredit";
					txtcredit.Select();
					txtcredit.Focus();
					txtcredit.Enabled = false;
					btnNum[11].Select();
					btnNum[11].Focus();
					//isECR = 2
				}
			}
			
			
		}
		
		public string HexToString(string hex)
		{
			System.Text.StringBuilder text = new System.Text.StringBuilder(hex.Length / 2);
			for (int i = 0; i <= hex.Length - 2; i += 2)
			{
				text.Append(Strings.Chr(Convert.ToByte(hex.Substring(i, 2), 16)));
			}
			return text.ToString();
		}
		
		public void txtvoucher_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					if (txtvoucher.Text == "" || txtvoucher.Text == "0")
					{
						txtvoucher.Text = System.Convert.ToString(((decimal) (double.Parse(vpay.Text) - RoundOfPay)).ToString("N0"));
						txtvoucher.Select();
						txtvoucher.Focus();
						txtvoucher.SelectionStart = 0;
						txtvoucher.SelectionLength = txtvoucher.Text.Length;
						return;
					}
					if ((vstatus.Text.Trim() == "SALES" && double.Parse(txtvoucher.Text) > 0) || (vstatus.Text.Trim() == "REFUND" && double.Parse(txtvoucher.Text) < 0))
					{
						
						if ((string) (DataGridView1[2, DataGridView1.CurrentRow.Index].Value) == "OV")
						{
							string temp_card_num = "";
							if (Simpan_Detail(double.Parse(txtvoucher.Text), txtno_voc.Text, ref temp_card_num))
							{
								txtno_voc.Text = "";
								txtvoucher.Text = "0";
								Cek_Lunas();
							}
						}
					}
					break;
			}
		}
		
	}
}
