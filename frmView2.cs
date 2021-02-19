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
	public partial class frmView2
	{
		public frmView2()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmView2 defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmView2 Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmView2();
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
		public void frmView2_Load(object sender, EventArgs e)
		{
			if (ComboBox1.Items.Count > 0)
			{
				ComboBox1.Items.Clear();
			}
			ComboBox1.Items.Add("Description");
			ComboBox1.Items.Add("Long_Description");
			ComboBox1.Items.Add("Current_Price");
			ComboBox1.Items.Add("Article");
			ComboBox1.SelectedIndex = 0;
			DataGridView1.DataSource = null;
			txtkode.Clear();
			txtkode.Select();
			txtkode.Focus();
			ViewDG();
		}
		
		public void txtkode_TextChanged(object sender, EventArgs e)
		{
			ViewDG();
		}
		
		public void ViewDG()
		{
			DataGridView1.DataSource = null;
			DataSet ds = new DataSet();
			string order = "";
			if (ComboBox1.SelectedIndex == 0)
			{
				order = " Order By Description";
			}
			else if (ComboBox1.SelectedIndex == 1)
			{
				order = " Order By Long_Description";
			}
			else if (ComboBox1.SelectedIndex == 2)
			{
				order = " Order By Current_Price";
			}
			//If VPing = "ONLINE" Then
			//    ds = getSqldb("select top 200 a.article_code as Article,RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand,ISNULL(last_stok,0) as Stock," &
			//              "isnull(Location_Name,'') as Location from Item_Master a left join Item_Master_RFID b on a.Article_Code = b.Article_Code left join " &
			//              "Location c on b.Location = c.Location  left join [POS_SERVER].dbo.t_stok d on a.PLU = d.plu where " &
			//              "CONVERT(varchar(6),date, 112) = CONVERT(varchar(6),GETDATE(), 112) And (Description " &
			//              "Like '%" & txtkode.Text & "%' or brand like '%" & txtkode.Text & "%' or long_Description like '%" & txtkode.Text & "%')" & order & "", ConnServer)
			//Else
			//    ds = getSqldb("select top 200 a.article_code as Article,RTRIM(a.PLU) as PLU,Long_Description as Description,Current_Price as Price,Brand from Item_Master where Description " &
			//              "Like '%" & txtkode.Text & "%' or brand like '%" & txtkode.Text & "%' or long_Description like '%" & txtkode.Text & "%')" & order & "", ConnLocal)
			//End If
			ds = Module1.getSqldb("select top 200 article_code as Article,RTRIM(PLU) as PLU,Description,Long_Description,Current_Price,DP2 As SBU,Brand from Item_Master where Description like '%" + txtkode.Text + "%' or brand like '%" + txtkode.Text + "%' or long_Description like '%" + txtkode.Text + "%'" + order + "", Module1.ConnLocal);
			if (ds.Tables[0].Rows.Count > 0)
			{
				DataGridView1.DataSource = ds.Tables[0];
				DataGridView1.Columns["Current_Price"].DefaultCellStyle.Format = "N0";
				DataGridView1.Refresh();
			}
		}
		
		public void CmdCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		public void CmdOk_Click(object sender, EventArgs e)
		{
			try
			{
				if (System.Convert.ToInt32(Module1.RegType) == 0)
				{
					if (VB.Strings.Right(frmSalesSelf.Default.txtkode.Text, 1) == "*")
					{
						frmSales.Default.txtkode.Text = frmSalesSelf.Default.txtkode.Text + System.Convert.ToString(DataGridView1[1, DataGridView1.CurrentRow.Index].Value);
					}
					else
					{
						frmSales.Default.txtkode.Text = System.Convert.ToString(DataGridView1[1, DataGridView1.CurrentRow.Index].Value);
					}
				}
				else
				{
					if (Module1.SecLev >= 3)
					{
						if (VB.Strings.Right(frmSalesSelf.Default.txtkode.Text, 1) == "*")
						{
							frmSalesSelf.Default.txtkode.Text = frmSalesSelf.Default.txtkode.Text + System.Convert.ToString(DataGridView1[1, DataGridView1.CurrentRow.Index].Value);
						}
						else
						{
							frmSalesSelf.Default.txtkode.Text = System.Convert.ToString(DataGridView1[1, DataGridView1.CurrentRow.Index].Value);
						}
					}
					else
					{
						if (VB.Strings.Right(frmSalesSelf.Default.txtkode.Text, 1) == "*")
						{
							frmSales.Default.txtkode.Text = frmSalesSelf.Default.txtkode.Text + System.Convert.ToString(DataGridView1[1, DataGridView1.CurrentRow.Index].Value);
						}
						else
						{
							frmSales.Default.txtkode.Text = System.Convert.ToString(DataGridView1[1, DataGridView1.CurrentRow.Index].Value);
						}
					}
				}
				
				
				this.Close();
			}
			catch (Exception)
			{
				
			}
			
		}
		
		public void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (System.Convert.ToInt32(Module1.RegType) == 0)
			{
				if (VB.Strings.Right(frmSalesSelf.Default.txtkode.Text, 1) == "*")
				{
					frmSales.Default.txtkode.Text = frmSalesSelf.Default.txtkode.Text + System.Convert.ToString(DataGridView1[1, DataGridView1.CurrentRow.Index].Value);
				}
				else
				{
					frmSales.Default.txtkode.Text = System.Convert.ToString(DataGridView1[1, DataGridView1.CurrentRow.Index].Value);
				}
			}
			else
			{
				if (Module1.SecLev >= 3)
				{
					if (VB.Strings.Right(frmSalesSelf.Default.txtkode.Text, 1) == "*")
					{
						frmSalesSelf.Default.txtkode.Text = frmSalesSelf.Default.txtkode.Text + System.Convert.ToString(DataGridView1[1, DataGridView1.CurrentRow.Index].Value);
					}
					else
					{
						frmSalesSelf.Default.txtkode.Text = System.Convert.ToString(DataGridView1[1, DataGridView1.CurrentRow.Index].Value);
					}
				}
				else
				{
					if (VB.Strings.Right(frmSalesSelf.Default.txtkode.Text, 1) == "*")
					{
						frmSales.Default.txtkode.Text = frmSalesSelf.Default.txtkode.Text + System.Convert.ToString(DataGridView1[1, DataGridView1.CurrentRow.Index].Value);
					}
					else
					{
						frmSales.Default.txtkode.Text = System.Convert.ToString(DataGridView1[1, DataGridView1.CurrentRow.Index].Value);
					}
				}
			}
			
			this.Close();
		}
		
		public void ComboBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			DataGridView1.DataSource = null;
			DataSet ds = new DataSet();
			string order = "";
			if (ComboBox1.SelectedIndex == 0)
			{
				order = " Order By Description";
			}
			else if (ComboBox1.SelectedIndex == 1)
			{
				order = " Order By Long_Description";
			}
			else if (ComboBox1.SelectedIndex == 2)
			{
				order = " Order By Current_Price";
			}
			//ds = getSqldb("select top 200 article_code as Article,RTRIM(PLU) as PLU,Description,Long_Description,Current_Price,DP2 As SBU,Brand from Item_Master where Description like '%" & txtkode.Text & "%' or brand like '%" & txtkode.Text & "%' or long_Description like '%" & txtkode.Text & "%'" & order & "", ConnLocal)
			ds = Module1.getSqldb("select top 200 article_code as Article,RTRIM(PLU) as PLU,Description,Long_Description,Current_Price,DP2 As SBU,Brand from Item_Master where Description like '%" + txtkode.Text + "%' or brand like '%" + txtkode.Text + "%' or long_Description like '%" + txtkode.Text + "%'" + order + "", Module1.ConnLocal);
			if (ds.Tables[0].Rows.Count > 0)
			{
				DataGridView1.DataSource = ds.Tables[0];
				DataGridView1.Columns["Current_Price"].DefaultCellStyle.Format = "N0";
				DataGridView1.Refresh();
			}
		}
	}
}
