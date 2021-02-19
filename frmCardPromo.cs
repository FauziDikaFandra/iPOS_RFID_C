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
	public partial class frmCardPromo : System.Windows.Forms.Form
	{
		public frmCardPromo()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmCardPromo defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmCardPromo Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmCardPromo();
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
		public void cmdup_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			//On Error Resume Next VBConversions Warning: On Error Resume Next not supported in C#
			List1.SelectedIndex = System.Convert.ToInt32(List1.SelectedIndex > 0 ? List1.SelectedIndex - 1 : 0);
		}
		
		public void cmddown_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			List1.SelectedIndex = System.Convert.ToInt32(List1.SelectedIndex < List1.Items.Count - 1 ? List1.SelectedIndex + 1 : List1.Items.Count - 1);
		}
		
		public void Cmdok_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			frmCard.Default.Vpromo_id.Text = VB.Strings.Left(List1.Text, 6);
			this.Close();
		}
		
		public void Cmdcancel_Click(System.Object eventSender, System.EventArgs eventArgs)
		{
			frmCard.Default.Vpromo_id.Text = "";
			this.Close();
		}
		
		public void frmCardPromo_Load(System.Object eventSender, System.EventArgs eventArgs)
		{
			DataSet RsCard = new DataSet();
			
			RsCard = Module1.getSqldb("select card_promo_id + '    ' + card_promo_name + '-' + Card_Promo_Name_Long as id " + "from Card_Promotion_Name where GETDATE() between Start_Promo_Date and End_Promo_Date ", Module1.ConnLocal);
			
			if (RsCard.Tables[0].Rows.Count > 0)
			{
				foreach (DataRow ro in RsCard.Tables[0].Rows)
				{
					List1.Items.Add(ro["id"]);
				}
				List1.SelectedIndex = 0;
			}
		}
		
		public void List1_KeyDown(System.Object eventSender, System.Windows.Forms.KeyEventArgs eventArgs)
		{
			short KeyCode = (short) eventArgs.KeyCode;
			//short Shift = (short) (eventArgs.KeyData / 0x10000);
			switch (KeyCode)
			{
				case (short) 13:
					Cmdok_Click(cmdOk, new System.EventArgs());
					break;
				case (short) 27:
					Cmdcancel_Click(cmdCancel, new System.EventArgs());
					break;
			}
		}
	}
}
