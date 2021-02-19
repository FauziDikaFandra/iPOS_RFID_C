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
		public partial class frmSplash : System.Windows.Forms.Form
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
			this.components = new System.ComponentModel.Container();
			this.Load += new System.EventHandler(Form1_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
			this.Shape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.lblversi = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.Image1 = new System.Windows.Forms.PictureBox();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
			this.BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
			this.BackgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize) this.Image1).BeginInit();
			this.SuspendLayout();
			//
			//Shape1
			//
			this.Shape1.BackColor = System.Drawing.SystemColors.Window;
			this.Shape1.BorderColor = System.Drawing.Color.Gray;
			this.Shape1.BorderWidth = 3;
			this.Shape1.CornerRadius = 30;
			this.Shape1.FillColor = System.Drawing.Color.Black;
			this.Shape1.Location = new System.Drawing.Point(7, 6);
			this.Shape1.Name = "Shape1";
			this.Shape1.Size = new System.Drawing.Size(451, 247);
			//
			//ShapeContainer1
			//
			this.ShapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.ShapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.ShapeContainer1.Name = "ShapeContainer1";
			this.ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {this.Shape1});
			this.ShapeContainer1.Size = new System.Drawing.Size(465, 260);
			this.ShapeContainer1.TabIndex = 0;
			this.ShapeContainer1.TabStop = false;
			//
			//lblversi
			//
			this.lblversi.BackColor = System.Drawing.Color.Transparent;
			this.lblversi.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblversi.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblversi.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(60)), System.Convert.ToInt32(System.Convert.ToByte(60)), System.Convert.ToInt32(System.Convert.ToByte(60)));
			this.lblversi.Location = new System.Drawing.Point(338, 222);
			this.lblversi.Name = "lblversi";
			this.lblversi.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblversi.Size = new System.Drawing.Size(100, 21);
			this.lblversi.TabIndex = 4;
			this.lblversi.Text = "Version 1.0.0";
			this.lblversi.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//Label1
			//
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.Font = new System.Drawing.Font("Arial", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(60)), System.Convert.ToInt32(System.Convert.ToByte(60)), System.Convert.ToInt32(System.Convert.ToByte(60)));
			this.Label1.Location = new System.Drawing.Point(212, 197);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(226, 26);
			this.Label1.TabIndex = 3;
			this.Label1.Text = "POINT OF SALES";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//Image1
			//
			this.Image1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Image1.Image = (System.Drawing.Image) (resources.GetObject("Image1.Image"));
			this.Image1.Location = new System.Drawing.Point(22, 17);
			this.Image1.Name = "Image1";
			this.Image1.Size = new System.Drawing.Size(421, 196);
			this.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Image1.TabIndex = 5;
			this.Image1.TabStop = false;
			//
			//BackgroundWorker1
			//
			//
			//ProgressBar1
			//
			this.ProgressBar1.ForeColor = System.Drawing.Color.Red;
			this.ProgressBar1.Location = new System.Drawing.Point(34, 224);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(298, 14);
			this.ProgressBar1.TabIndex = 6;
			this.ProgressBar1.Visible = false;
			//
			//label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(33, 204);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(46, 15);
			this.Label2.TabIndex = 7;
			this.Label2.Text = "Label2";
			//
			//Label3
			//
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label3.Font = new System.Drawing.Font("Arial", (float) (14.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(60)), System.Convert.ToInt32(System.Convert.ToByte(60)), System.Convert.ToInt32(System.Convert.ToByte(60)));
			this.Label3.Location = new System.Drawing.Point(18, 141);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(157, 26);
			this.Label3.TabIndex = 8;
			this.Label3.Text = "RFID Checkout";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			//frmSplash
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(465, 260);
			this.ControlBox = false;
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.ProgressBar1);
			this.Controls.Add(this.lblversi);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Image1);
			this.Controls.Add(this.ShapeContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximumSize = new System.Drawing.Size(465, 260);
			this.MinimumSize = new System.Drawing.Size(465, 260);
			this.Name = "frmSplash";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize) this.Image1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		public Microsoft.VisualBasic.PowerPacks.RectangleShape Shape1;
		internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
		public System.Windows.Forms.Label lblversi;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.PictureBox Image1;
		public System.Windows.Forms.ToolTip ToolTip1;
		internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
		internal ProgressBar ProgressBar1;
		internal Label Label2;
		public Label Label3;
	}
	
}
