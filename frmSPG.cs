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
	public partial class frmSPG
	{
		public frmSPG()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmSPG defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmSPG Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmSPG();
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
		DataSet dsSPG = new DataSet();
		int x = 1;
		public void frmSPG_Load(object sender, EventArgs e)
		{
			dsSPG = Module1.getSqldb("Select User_ID,User_Name from USERS where security_level = 3 and password <> 'xxxx' order by User_Name", Module1.ConnLocal);
			if (dsSPG.Tables[0].Rows.Count > 0)
			{
				x = 1;
				foreach (DataRow ro in dsSPG.Tables[0].Rows)
				{
					((Button) (this.Controls.Find("btn" + System.Convert.ToString(x), true)[0])).Text = System.Convert.ToString(ro["User_Name"]);
					((Button) (this.Controls.Find("btn" + System.Convert.ToString(x), true)[0])).Tag = ro["User_ID"];
					x++;
					if (x > dsSPG.Tables[0].Rows.Count)
					{
						break;
					}
				}
			}
		}
		
		
		
		public void btn1_Click(object sender, EventArgs e)
		{
			Button btn = (Button) sender;
			Module1.spg_btn = System.Convert.ToString(btn.Tag);
			this.Close();
		}
	}
}
