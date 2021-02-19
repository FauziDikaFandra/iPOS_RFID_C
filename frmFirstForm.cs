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
	public partial class frmFirstForm
	{
		public frmFirstForm()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmFirstForm defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmFirstForm Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmFirstForm();
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
		public void Button1_Click(object sender, EventArgs e)
		{
			this.Close();
			frmLogin.Default.Show();
		}
		
		public void Button3_Click(object sender, EventArgs e)
		{
			Module1.EODFirstForm = true;
			frmSOD.Default.Text = "EOD";
			frmSOD.Default.ShowDialog();
		}
		
		public void Button2_Click(object sender, EventArgs e)
		{
			this.Close();
			frmShowStock.Default.Show();
		}
		
		public void FirstForm_Load(object sender, EventArgs e)
		{
			Cetak.CDisplay("  ", "*** LAKON ***");
		}
		
		//Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
		//    sendMessage("081806241210", "tes")
		//End Sub
	}
}
