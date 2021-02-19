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
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
		public partial class frmFirstForm : System.Windows.Forms.Form
		{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
			protected override void Dispose(bool disposing)
			{
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
		[System.Diagnostics.DebuggerStepThrough()]
			private void InitializeComponent()
			{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFirstForm));
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			base.Load += new System.EventHandler(FirstForm_Load);
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.Button3 = new System.Windows.Forms.Button();
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//Button1
			//
			this.Button1.BackColor = System.Drawing.SystemColors.Control;
			this.Button1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Button1.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Button1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Button1.Image = (System.Drawing.Image) (resources.GetObject("Button1.Image"));
			this.Button1.Location = new System.Drawing.Point(159, 16);
			this.Button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Button1.Name = "Button1";
			this.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Button1.Size = new System.Drawing.Size(128, 72);
			this.Button1.TabIndex = 79;
			this.Button1.TabStop = false;
			this.Button1.Text = "SALES";
			this.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Button1.UseVisualStyleBackColor = false;
			//
			//GroupBox1
			//
			this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom 
				| System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.GroupBox1.Controls.Add(this.Button3);
			this.GroupBox1.Controls.Add(this.Button2);
			this.GroupBox1.Controls.Add(this.Button1);
			this.GroupBox1.Location = new System.Drawing.Point(8, -2);
			this.GroupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.GroupBox1.Size = new System.Drawing.Size(432, 98);
			this.GroupBox1.TabIndex = 80;
			this.GroupBox1.TabStop = false;
			//
			//Button3
			//
			this.Button3.BackColor = System.Drawing.SystemColors.Control;
			this.Button3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Button3.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Button3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Button3.Image = (System.Drawing.Image) (resources.GetObject("Button3.Image"));
			this.Button3.Location = new System.Drawing.Point(295, 16);
			this.Button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Button3.Name = "Button3";
			this.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Button3.Size = new System.Drawing.Size(128, 72);
			this.Button3.TabIndex = 81;
			this.Button3.TabStop = false;
			this.Button3.Text = "EXIT";
			this.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Button3.UseVisualStyleBackColor = false;
			//
			//Button2
			//
			this.Button2.BackColor = System.Drawing.SystemColors.Control;
			this.Button2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Button2.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Button2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Button2.Image = (System.Drawing.Image) (resources.GetObject("Button2.Image"));
			this.Button2.Location = new System.Drawing.Point(11, 16);
			this.Button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Button2.Name = "Button2";
			this.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Button2.Size = new System.Drawing.Size(140, 72);
			this.Button2.TabIndex = 80;
			this.Button2.TabStop = false;
			this.Button2.Text = "CHECK STOCK";
			this.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Button2.UseVisualStyleBackColor = false;
			//
			//frmFirstForm
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 103);
			this.ControlBox = false;
			this.Controls.Add(this.GroupBox1);
			this.Font = new System.Drawing.Font("Tahoma", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.MaximumSize = new System.Drawing.Size(460, 119);
			this.MinimumSize = new System.Drawing.Size(460, 119);
			this.Name = "frmFirstForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.GroupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		public Button Button1;
		internal GroupBox GroupBox1;
		public Button Button3;
		public Button Button2;
	}
	
}
