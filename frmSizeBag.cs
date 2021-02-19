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
	
	public partial class frmSizeBag
	{
		public frmSizeBag()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmSizeBag defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmSizeBag Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmSizeBag();
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
		DataSet dsBag = new DataSet();
		string SqlStr = "";
		public void RfidScan2_Click(object sender, EventArgs e)
		{
			dsBag.Clear();
			if (this.Text == "PAPER BAG")
			{
				SqlStr = "Select * from Bag where Bag = 'PAPER BAG' and Size = 'S'";
			}
			else if (this.Text == "PLASTIC")
			{
				SqlStr = "Select * from Bag where Bag = 'PLASTIC' and Size = 'S'";
			}
			else if (this.Text == "TOTE BAG")
			{
				SqlStr = "Select * from Bag where Bag = 'TOTE BAG' and Size = 'S'";
			}
			if (Module1.VPing == "ONLINE")
			{
				dsBag = Module1.getSqldb(SqlStr, Module1.ConnServer);
			}
			else
			{
				dsBag = Module1.getSqldb(SqlStr, Module1.ConnLocal);
			}
			if ((string) this.Tag == "ALL")
			{
				if (dsBag.Tables[0].Rows.Count > 0)
				{
					frmSales.Default.txtkode.Text = Strings.Trim(System.Convert.ToString(dsBag.Tables[0].Rows[0]["PLU"]));
				}
				else
				{
					frmSales.Default.txtkode.Text = "";
				}
				frmSizeBagAll.Default.Close();
			}
			else
			{
				if (dsBag.Tables[0].Rows.Count > 0)
				{
					frmSalesSelf.Default.txtkode.Text = Strings.Trim(System.Convert.ToString(dsBag.Tables[0].Rows[0]["PLU"]));
				}
				else
				{
					frmSalesSelf.Default.txtkode.Text = "";
				}
			}
			
			this.Close();
		}
		
		public void Button1_Click(object sender, EventArgs e)
		{
			dsBag.Clear();
			if (this.Text == "PAPER BAG")
			{
				SqlStr = "Select * from Bag where Bag = 'PAPER BAG' and Size = 'M'";
			}
			else if (this.Text == "PLASTIC")
			{
				SqlStr = "Select * from Bag where Bag = 'PLASTIC' and Size = 'M'";
			}
			else if (this.Text == "TOTE BAG")
			{
				SqlStr = "Select * from Bag where Bag = 'TOTE BAG' and Size = 'M'";
			}
			if (Module1.VPing == "ONLINE")
			{
				dsBag = Module1.getSqldb(SqlStr, Module1.ConnServer);
			}
			else
			{
				dsBag = Module1.getSqldb(SqlStr, Module1.ConnLocal);
			}
			if ((string) this.Tag == "ALL")
			{
				if (dsBag.Tables[0].Rows.Count > 0)
				{
					frmSales.Default.txtkode.Text = Strings.Trim(System.Convert.ToString(dsBag.Tables[0].Rows[0]["PLU"]));
				}
				else
				{
					frmSales.Default.txtkode.Text = "";
				}
				frmSizeBagAll.Default.Close();
			}
			else
			{
				if (dsBag.Tables[0].Rows.Count > 0)
				{
					frmSalesSelf.Default.txtkode.Text = Strings.Trim(System.Convert.ToString(dsBag.Tables[0].Rows[0]["PLU"]));
				}
				else
				{
					frmSalesSelf.Default.txtkode.Text = "";
				}
			}
			this.Close();
		}
		
		public void Button2_Click(object sender, EventArgs e)
		{
			dsBag.Clear();
			if (this.Text == "PAPER BAG")
			{
				SqlStr = "Select * from Bag where Bag = 'PAPER BAG' and Size = 'L'";
			}
			else if (this.Text == "PLASTIC")
			{
				SqlStr = "Select * from Bag where Bag = 'PLASTIC' and Size = 'L'";
			}
			else if (this.Text == "TOTE BAG")
			{
				SqlStr = "Select * from Bag where Bag = 'TOTE BAG' and Size = 'L'";
			}
			if (Module1.VPing == "ONLINE")
			{
				dsBag = Module1.getSqldb(SqlStr, Module1.ConnServer);
			}
			else
			{
				dsBag = Module1.getSqldb(SqlStr, Module1.ConnLocal);
			}
			if ((string) this.Tag == "ALL")
			{
				if (dsBag.Tables[0].Rows.Count > 0)
				{
					frmSales.Default.txtkode.Text = Strings.Trim(System.Convert.ToString(dsBag.Tables[0].Rows[0]["PLU"]));
				}
				else
				{
					frmSales.Default.txtkode.Text = "";
				}
				frmSizeBagAll.Default.Close();
			}
			else
			{
				if (dsBag.Tables[0].Rows.Count > 0)
				{
					frmSalesSelf.Default.txtkode.Text = Strings.Trim(System.Convert.ToString(dsBag.Tables[0].Rows[0]["PLU"]));
				}
				else
				{
					frmSalesSelf.Default.txtkode.Text = "";
				}
			}
			this.Close();
		}
	}
}
