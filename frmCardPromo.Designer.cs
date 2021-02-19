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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public 
	partial class frmCardPromo : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)  {
			try
			{
				if (disposing && components != null)  {
						components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()  {
			this.components = new System.ComponentModel.Container();
			base.Load += new System.EventHandler(frmCardPromo_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCardPromo));
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdCancel.Click += new System.EventHandler(this.Cmdcancel_Click);
			this.cmdOk = new System.Windows.Forms.Button();
			this.cmdOk.Click += new System.EventHandler(this.Cmdok_Click);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.cmddown = new System.Windows.Forms.Button();
			this.cmddown.Click += new System.EventHandler(this.cmddown_Click);
			this.cmdup = new System.Windows.Forms.Button();
			this.cmdup.Click += new System.EventHandler(this.cmdup_Click);
			this.List1 = new System.Windows.Forms.ListBox();
			this.List1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.List1_KeyDown);
			this.lblmsg = new System.Windows.Forms.Label();
			this.SuspendLayout();
			//
			//cmdCancel
			//
			this.cmdCancel.BackColor = System.Drawing.SystemColors.Control;
			this.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdCancel.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.cmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdCancel.Image = (System.Drawing.Image) (resources.GetObject("cmdCancel.Image"));
			this.cmdCancel.Location = new System.Drawing.Point(221, 111);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdCancel.Size = new System.Drawing.Size(76, 56);
			this.cmdCancel.TabIndex = 8;
			this.cmdCancel.Text = "CANCEL";
			this.cmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdCancel.UseVisualStyleBackColor = false;
			//
			//cmdOk
			//
			this.cmdOk.BackColor = System.Drawing.SystemColors.Control;
			this.cmdOk.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdOk.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.cmdOk.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdOk.Image = (System.Drawing.Image) (resources.GetObject("cmdOk.Image"));
			this.cmdOk.Location = new System.Drawing.Point(146, 111);
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdOk.Size = new System.Drawing.Size(76, 56);
			this.cmdOk.TabIndex = 7;
			this.cmdOk.Text = "OK";
			this.cmdOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdOk.UseVisualStyleBackColor = false;
			//
			//cmddown
			//
			this.cmddown.BackColor = System.Drawing.SystemColors.Control;
			this.cmddown.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmddown.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.cmddown.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmddown.Image = (System.Drawing.Image) (resources.GetObject("cmddown.Image"));
			this.cmddown.Location = new System.Drawing.Point(71, 111);
			this.cmddown.Name = "cmddown";
			this.cmddown.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmddown.Size = new System.Drawing.Size(76, 56);
			this.cmddown.TabIndex = 11;
			this.cmddown.Text = "DOWN";
			this.cmddown.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmddown.UseVisualStyleBackColor = false;
			//
			//cmdup
			//
			this.cmdup.BackColor = System.Drawing.SystemColors.Control;
			this.cmdup.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdup.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.cmdup.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdup.Image = (System.Drawing.Image) (resources.GetObject("cmdup.Image"));
			this.cmdup.Location = new System.Drawing.Point(-4, 111);
			this.cmdup.Name = "cmdup";
			this.cmdup.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdup.Size = new System.Drawing.Size(76, 56);
			this.cmdup.TabIndex = 10;
			this.cmdup.Text = "UP";
			this.cmdup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdup.UseVisualStyleBackColor = false;
			//
			//List1
			//
			this.List1.BackColor = System.Drawing.SystemColors.Window;
			this.List1.Cursor = System.Windows.Forms.Cursors.Default;
			this.List1.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.List1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.List1.ItemHeight = 16;
			this.List1.Location = new System.Drawing.Point(-4, 26);
			this.List1.Name = "List1";
			this.List1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.List1.Size = new System.Drawing.Size(301, 84);
			this.List1.TabIndex = 6;
			//
			//lblmsg
			//
			this.lblmsg.BackColor = System.Drawing.Color.DimGray;
			this.lblmsg.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblmsg.Font = new System.Drawing.Font("Arial", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblmsg.ForeColor = System.Drawing.Color.Yellow;
			this.lblmsg.Location = new System.Drawing.Point(-4, 2);
			this.lblmsg.Name = "lblmsg";
			this.lblmsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblmsg.Size = new System.Drawing.Size(301, 31);
			this.lblmsg.TabIndex = 9;
			this.lblmsg.Text = "KARTU PROMOSI";
			this.lblmsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			//
			//frmCardPromo
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (14.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 161);
			this.ControlBox = false;
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdOk);
			this.Controls.Add(this.cmddown);
			this.Controls.Add(this.cmdup);
			this.Controls.Add(this.List1);
			this.Controls.Add(this.lblmsg);
			this.Font = new System.Drawing.Font("Arial", (float) (8.0F));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximumSize = new System.Drawing.Size(308, 200);
			this.MinimumSize = new System.Drawing.Size(308, 200);
			this.Name = "frmCardPromo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CARD PROMO";
			this.ResumeLayout(false);
			
		}
		public System.Windows.Forms.Button cmdCancel;
		public System.Windows.Forms.Button cmdOk;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.Button cmddown;
		public System.Windows.Forms.Button cmdup;
		public System.Windows.Forms.ListBox List1;
		public System.Windows.Forms.Label lblmsg;
	}
	
}
