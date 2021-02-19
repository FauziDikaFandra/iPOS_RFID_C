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
	public partial class frmSizeBagAll
	{
		public frmSizeBagAll()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmSizeBagAll defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmSizeBagAll Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmSizeBagAll();
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
		public void Button5_Click(object sender, EventArgs e)
		{
			DataSet dsBag = new DataSet();
			if (Module1.VPing == "ONLINE")
			{
				dsBag = Module1.getSqldb("Select * from Bag where Bag = 'PAPER BAG' and Size = 'X'", Module1.ConnServer);
			}
			else
			{
				dsBag = Module1.getSqldb("Select * from Bag where Bag = 'PAPER BAG' and Size = 'X'", Module1.ConnLocal);
			}
			
			if (dsBag.Tables[0].Rows.Count > 0)
			{
				frmSales.Default.txtkode.Text = Strings.Trim(System.Convert.ToString(dsBag.Tables[0].Rows[0]["PLU"]));
			}
			else
			{
				frmSales.Default.txtkode.Text = "";
			}
			this.Close();
		}
		
		public void Button3_Click(object sender, EventArgs e)
		{
			//Me.TopMost = False
			//Me.Hide()
			//frmSizeBag.Text = "PLASTIC"
			//frmSizeBag.Tag = "ALL"
			//frmSizeBag.ShowDialog()
			//frmSizeBag.TopMost = True
			DataSet dsBag = new DataSet();
			if (Module1.VPing == "ONLINE")
			{
				dsBag = Module1.getSqldb("Select * from Bag where Bag = 'PLASTIC' and Size = 'M'", Module1.ConnServer);
			}
			else
			{
				dsBag = Module1.getSqldb("Select * from Bag where Bag = 'PLASTIC' and Size = 'M'", Module1.ConnLocal);
			}
			
			if (dsBag.Tables[0].Rows.Count > 0)
			{
				frmSales.Default.txtkode.Text = Strings.Trim(System.Convert.ToString(dsBag.Tables[0].Rows[0]["PLU"]));
			}
			else
			{
				frmSales.Default.txtkode.Text = "";
			}
			this.Close();
		}
		
		public void Button4_Click(object sender, EventArgs e)
		{
			this.TopMost = false;
			this.Hide();
			frmSizeBag.Default.Text = "TOTE BAG";
			frmSizeBag.Default.Tag = "ALL";
			frmSizeBag.Default.ShowDialog();
			frmSizeBag.Default.TopMost = true;
		}
	}
}
