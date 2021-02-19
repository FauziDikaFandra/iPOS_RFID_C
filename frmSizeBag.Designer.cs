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
	partial class frmSizeBag : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSizeBag));
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.RfidScan2 = new System.Windows.Forms.Button();
			this.RfidScan2.Click += new System.EventHandler(this.RfidScan2_Click);
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Controls.Add(this.RfidScan2);
			this.GroupBox1.Font = new System.Drawing.Font("Arial", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GroupBox1.Location = new System.Drawing.Point(12, 8);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(365, 98);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Click Here";
			//
			//Button2
			//
			this.Button2.BackColor = System.Drawing.SystemColors.Control;
			this.Button2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Button2.Font = new System.Drawing.Font("Arial", (float) (36.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Button2.ForeColor = System.Drawing.Color.Black;
			this.Button2.Location = new System.Drawing.Point(249, 19);
			this.Button2.Name = "Button2";
			this.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Button2.Size = new System.Drawing.Size(95, 62);
			this.Button2.TabIndex = 75;
			this.Button2.Text = "L";
			this.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Button2.UseVisualStyleBackColor = false;
			//
			//Button1
			//
			this.Button1.BackColor = System.Drawing.SystemColors.Control;
			this.Button1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Button1.Font = new System.Drawing.Font("Arial", (float) (36.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Button1.ForeColor = System.Drawing.Color.Black;
			this.Button1.Location = new System.Drawing.Point(133, 19);
			this.Button1.Name = "Button1";
			this.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Button1.Size = new System.Drawing.Size(95, 62);
			this.Button1.TabIndex = 74;
			this.Button1.Text = "M";
			this.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Button1.UseVisualStyleBackColor = false;
			//
			//RfidScan2
			//
			this.RfidScan2.BackColor = System.Drawing.SystemColors.Control;
			this.RfidScan2.Cursor = System.Windows.Forms.Cursors.Default;
			this.RfidScan2.Font = new System.Drawing.Font("Arial", (float) (36.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.RfidScan2.ForeColor = System.Drawing.Color.Black;
			this.RfidScan2.Location = new System.Drawing.Point(19, 19);
			this.RfidScan2.Name = "RfidScan2";
			this.RfidScan2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RfidScan2.Size = new System.Drawing.Size(95, 62);
			this.RfidScan2.TabIndex = 73;
			this.RfidScan2.Text = "S";
			this.RfidScan2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.RfidScan2.UseVisualStyleBackColor = false;
			//
			//frmSizeBag
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (14.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(390, 113);
			this.Controls.Add(this.GroupBox1);
			this.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(406, 152);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(406, 152);
			this.Name = "frmSizeBag";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bag Size";
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		internal GroupBox GroupBox1;
		public Button RfidScan2;
		public Button Button2;
		public Button Button1;
	}
	
}
