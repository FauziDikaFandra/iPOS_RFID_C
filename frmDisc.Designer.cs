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
	partial class frmDisc : System.Windows.Forms.Form
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
			base.Activated += new System.EventHandler(frmDisc_Activated);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisc));
			this.cmdCancel = new System.Windows.Forms.Button();
			this.cmdCancel.Click += new System.EventHandler(this.Cmdcancel_Click);
			this.cmdOk = new System.Windows.Forms.Button();
			this.cmdOk.Click += new System.EventHandler(this.Cmdok_Click);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
			this.cmdCancel.Location = new System.Drawing.Point(96, 98);
			this.cmdCancel.Name = "cmdCancel";
			this.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdCancel.Size = new System.Drawing.Size(76, 66);
			this.cmdCancel.TabIndex = 11;
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
			this.cmdOk.Location = new System.Drawing.Point(96, 32);
			this.cmdOk.Name = "cmdOk";
			this.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdOk.Size = new System.Drawing.Size(76, 66);
			this.cmdOk.TabIndex = 10;
			this.cmdOk.Text = "OK";
			this.cmdOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdOk.UseVisualStyleBackColor = false;
			//
			//List1
			//
			this.List1.BackColor = System.Drawing.SystemColors.Window;
			this.List1.Cursor = System.Windows.Forms.Cursors.Default;
			this.List1.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.List1.ForeColor = System.Drawing.SystemColors.WindowText;
			this.List1.ItemHeight = 18;
			this.List1.Location = new System.Drawing.Point(-2, 32);
			this.List1.Name = "List1";
			this.List1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.List1.Size = new System.Drawing.Size(106, 130);
			this.List1.TabIndex = 7;
			//
			//lblmsg
			//
			this.lblmsg.BackColor = System.Drawing.Color.DimGray;
			this.lblmsg.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblmsg.Font = new System.Drawing.Font("Arial", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblmsg.ForeColor = System.Drawing.Color.Yellow;
			this.lblmsg.Location = new System.Drawing.Point(-7, 1);
			this.lblmsg.Name = "lblmsg";
			this.lblmsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblmsg.Size = new System.Drawing.Size(186, 31);
			this.lblmsg.TabIndex = 6;
			this.lblmsg.Text = "DISCOUNT";
			this.lblmsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			//
			//frmDisc
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (14.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(172, 164);
			this.ControlBox = false;
			this.Controls.Add(this.cmdCancel);
			this.Controls.Add(this.cmdOk);
			this.Controls.Add(this.List1);
			this.Controls.Add(this.lblmsg);
			this.Font = new System.Drawing.Font("Arial", (float) (8.0F));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.KeyPreview = true;
			this.MaximumSize = new System.Drawing.Size(188, 288);
			this.Name = "frmDisc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmDisc";
			this.ResumeLayout(false);
			
		}
		public System.Windows.Forms.Button cmdCancel;
		public System.Windows.Forms.Button cmdOk;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.ListBox List1;
		public System.Windows.Forms.Label lblmsg;
	}
	
}
