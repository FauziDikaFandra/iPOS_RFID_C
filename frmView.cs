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
	public partial class frmView : System.Windows.Forms.Form
	{
		public frmView()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmView defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmView Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmView();
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
		
		public void cmdangka_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			frmNum.Default.Text = "NUMBER - VIEW";
			frmNum.Default.Label2.Text = "PLU";
			frmNum.Default.ShowDialog();
		}
		
		public void Cmdcancel_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			this.Close();
		}
		
		public void Cmdok_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			if (VB.Strings.Right(frmSalesSelf.Default.txtkode.Text, 1) == "*")
			{
				frmSalesSelf.Default.txtkode.Text = frmSalesSelf.Default.txtkode.Text + System.Convert.ToString(DataGridView1[0, DataGridView1.CurrentRow.Index].Value);
			}
			else
			{
				frmSalesSelf.Default.txtkode.Text = System.Convert.ToString(DataGridView1[0, DataGridView1.CurrentRow.Index].Value);
			}
			this.Close();
		}
		
		public void DataGridView1_CellDoubleClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
		{
			if (VB.Strings.Right(frmSalesSelf.Default.txtkode.Text, 1) == "*")
			{
				frmSalesSelf.Default.txtkode.Text = frmSalesSelf.Default.txtkode.Text + System.Convert.ToString(DataGridView1[0, DataGridView1.CurrentRow.Index].Value);
			}
			else
			{
				frmSalesSelf.Default.txtkode.Text = System.Convert.ToString(DataGridView1[0, DataGridView1.CurrentRow.Index].Value);
			}
			this.Close();
		}
		
		
		public void DataGridView1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					Cmdok_Click(CmdOk, new System.EventArgs());
					break;
				case (System.Windows.Forms.Keys) 27:
					txtkode.Focus();
					break;
			}
		}
		
		public void SubNum()
		{
			if (txtkode.Text == "")
			{
				return;
			}
			DataSet DsCek = new DataSet();
			DsCek = Module1.getSqldb("select top 200 plu As PLU, Description, current_price As Harga from item_master where PLU like '%" + txtkode.Text + "%'" + "and description <> 'TIDAK AKTIF'", Module1.ConnLocal);
			this.Text = "VIEW ARTICLE - ";
			DataGridView1.DataSource = null;
			DataGridView1.DataSource = DsCek.Tables[0];
			DataGridView1.Columns["Harga"].DefaultCellStyle.Format = "N0";
			DataGridView1.Columns[0].Width = 110;
			DataGridView1.Columns[1].Width = 190;
			DataGridView1.Columns[2].Width = 60;
			DataGridView1.Focus();
		}
		
		public void txtkode_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case (System.Windows.Forms.Keys) 13:
					if (txtkode.Text == "")
					{
						return;
					}
					
					DataSet DsCek = new DataSet();
					DsCek = Module1.getSqldb("select top 200 plu As PLU, Description, current_price As Harga from item_master where PLU like '%" + txtkode.Text + "%'" + "and description <> 'TIDAK AKTIF'", Module1.ConnLocal);
					this.Text = "VIEW ARTICLE - ";
					DataGridView1.DataSource = null;
					DataGridView1.DataSource = DsCek.Tables[0];
					DataGridView1.Columns["Harga"].DefaultCellStyle.Format = "N0";
					DataGridView1.Columns[0].Width = 110;
					DataGridView1.Columns[1].Width = 190;
					DataGridView1.Columns[2].Width = 60;
					DataGridView1.Focus();
					break;
				case (System.Windows.Forms.Keys) 27:
					this.Close();
					break;
			}
		}
		
		public void frmView_Load(System.Object sender, System.EventArgs e)
		{
			DataGridView1.DataSource = null;
			txtkode.Clear();
			txtkode.Select();
			txtkode.Focus();
		}
	}
}
