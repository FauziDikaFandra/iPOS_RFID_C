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
	partial class RFID_Checking : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RFID_Checking));
			this.Label7 = new System.Windows.Forms.Label();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).BeginInit();
			this.SuspendLayout();
			//
			//Label7
			//
			this.Label7.BackColor = System.Drawing.Color.Transparent;
			this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label7.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label7.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(60)), System.Convert.ToInt32(System.Convert.ToByte(60)), System.Convert.ToInt32(System.Convert.ToByte(60)));
			this.Label7.Location = new System.Drawing.Point(156, 137);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label7.Size = new System.Drawing.Size(142, 21);
			this.Label7.TabIndex = 71;
			this.Label7.Text = "RFID Checking . . .";
			this.Label7.Visible = false;
			//
			//PictureBox1
			//
			this.PictureBox1.Image = (System.Drawing.Image) (resources.GetObject("PictureBox1.Image"));
			this.PictureBox1.Location = new System.Drawing.Point(169, 12);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(114, 114);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.PictureBox1.TabIndex = 70;
			this.PictureBox1.TabStop = false;
			//
			//RFID_Checking
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (7.0F), (float) (14.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(470, 166);
			this.ControlBox = false;
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.PictureBox1);
			this.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximumSize = new System.Drawing.Size(486, 182);
			this.MinimumSize = new System.Drawing.Size(486, 182);
			this.Name = "RFID_Checking";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		public Label Label7;
		internal PictureBox PictureBox1;
	}
	
}
