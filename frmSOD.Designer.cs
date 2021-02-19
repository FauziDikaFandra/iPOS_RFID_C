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
	partial class frmSOD : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmSOD_Load);
			base.Activated += new System.EventHandler(frmSOD_Activated);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSOD));
			this._Chk_0 = new System.Windows.Forms.CheckBox();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Label1 = new System.Windows.Forms.Label();
			this._Chk_1 = new System.Windows.Forms.CheckBox();
			this.lblmsg = new System.Windows.Forms.Label();
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this._Chk_2 = new System.Windows.Forms.CheckBox();
			this._Chk_3 = new System.Windows.Forms.CheckBox();
			this._Chk_4 = new System.Windows.Forms.CheckBox();
			this._Chk_5 = new System.Windows.Forms.CheckBox();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this._Chk_10 = new System.Windows.Forms.CheckBox();
			this._Chk_6 = new System.Windows.Forms.CheckBox();
			this._Chk_7 = new System.Windows.Forms.CheckBox();
			this._Chk_8 = new System.Windows.Forms.CheckBox();
			this._Chk_9 = new System.Windows.Forms.CheckBox();
			this.ProgressBar1 = new System.Windows.Forms.ProgressBar();
			this.Chk = new Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray(this.components);
			this.Chk.CheckStateChanged += new System.EventHandler(this.Chk_CheckStateChanged);
			this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
			this.BackgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
			this.BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
			this.Frame2.SuspendLayout();
			this.Frame1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.Chk).BeginInit();
			this.SuspendLayout();
			//
			//_Chk_0
			//
			this._Chk_0.BackColor = System.Drawing.SystemColors.Control;
			this._Chk_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._Chk_0.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._Chk_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Chk.SetIndex(this._Chk_0, System.Convert.ToInt16(0));
			this._Chk_0.Location = new System.Drawing.Point(10, 15);
			this._Chk_0.Name = "_Chk_0";
			this._Chk_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Chk_0.Size = new System.Drawing.Size(121, 26);
			this._Chk_0.TabIndex = 17;
			this._Chk_0.Text = "Item Master";
			this._Chk_0.UseVisualStyleBackColor = false;
			//
			//Label1
			//
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.Font = new System.Drawing.Font("Arial", (float) (13.5F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(5, 80);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(396, 36);
			this.Label1.TabIndex = 19;
			this.Label1.Text = "SINKRONISASI DATA KE SERVER ....";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			//
			//_Chk_1
			//
			this._Chk_1.BackColor = System.Drawing.SystemColors.Control;
			this._Chk_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._Chk_1.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._Chk_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Chk.SetIndex(this._Chk_1, System.Convert.ToInt16(1));
			this._Chk_1.Location = new System.Drawing.Point(9, 45);
			this._Chk_1.Name = "_Chk_1";
			this._Chk_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Chk_1.Size = new System.Drawing.Size(121, 26);
			this._Chk_1.TabIndex = 15;
			this._Chk_1.Text = "Payment Types";
			this._Chk_1.UseVisualStyleBackColor = false;
			//
			//lblmsg
			//
			this.lblmsg.BackColor = System.Drawing.Color.DimGray;
			this.lblmsg.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblmsg.Font = new System.Drawing.Font("Arial", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblmsg.ForeColor = System.Drawing.Color.Yellow;
			this.lblmsg.Location = new System.Drawing.Point(-6, 1);
			this.lblmsg.Name = "lblmsg";
			this.lblmsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblmsg.Size = new System.Drawing.Size(406, 31);
			this.lblmsg.TabIndex = 19;
			this.lblmsg.Text = "DOWNLOAD DATA";
			this.lblmsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			//
			//Frame2
			//
			this.Frame2.BackColor = System.Drawing.SystemColors.Control;
			this.Frame2.Controls.Add(this.Label1);
			this.Frame2.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(-1, 32);
			this.Frame2.Name = "Frame2";
			this.Frame2.Padding = new System.Windows.Forms.Padding(0);
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(396, 163);
			this.Frame2.TabIndex = 21;
			this.Frame2.TabStop = false;
			//
			//_Chk_2
			//
			this._Chk_2.BackColor = System.Drawing.SystemColors.Control;
			this._Chk_2.Cursor = System.Windows.Forms.Cursors.Default;
			this._Chk_2.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._Chk_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Chk.SetIndex(this._Chk_2, System.Convert.ToInt16(2));
			this._Chk_2.Location = new System.Drawing.Point(9, 75);
			this._Chk_2.Name = "_Chk_2";
			this._Chk_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Chk_2.Size = new System.Drawing.Size(121, 26);
			this._Chk_2.TabIndex = 12;
			this._Chk_2.Text = "Bin Card";
			this._Chk_2.UseVisualStyleBackColor = false;
			//
			//_Chk_3
			//
			this._Chk_3.BackColor = System.Drawing.SystemColors.Control;
			this._Chk_3.Cursor = System.Windows.Forms.Cursors.Default;
			this._Chk_3.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._Chk_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Chk.SetIndex(this._Chk_3, System.Convert.ToInt16(3));
			this._Chk_3.Location = new System.Drawing.Point(9, 105);
			this._Chk_3.Name = "_Chk_3";
			this._Chk_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Chk_3.Size = new System.Drawing.Size(121, 26);
			this._Chk_3.TabIndex = 11;
			this._Chk_3.Text = "Users";
			this._Chk_3.UseVisualStyleBackColor = false;
			//
			//_Chk_4
			//
			this._Chk_4.BackColor = System.Drawing.SystemColors.Control;
			this._Chk_4.Cursor = System.Windows.Forms.Cursors.Default;
			this._Chk_4.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._Chk_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Chk.SetIndex(this._Chk_4, System.Convert.ToInt16(4));
			this._Chk_4.Location = new System.Drawing.Point(140, 16);
			this._Chk_4.Name = "_Chk_4";
			this._Chk_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Chk_4.Size = new System.Drawing.Size(121, 26);
			this._Chk_4.TabIndex = 10;
			this._Chk_4.Text = "Attribute";
			this._Chk_4.UseVisualStyleBackColor = false;
			//
			//_Chk_5
			//
			this._Chk_5.BackColor = System.Drawing.SystemColors.Control;
			this._Chk_5.Cursor = System.Windows.Forms.Cursors.Default;
			this._Chk_5.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._Chk_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Chk.SetIndex(this._Chk_5, System.Convert.ToInt16(5));
			this._Chk_5.Location = new System.Drawing.Point(140, 45);
			this._Chk_5.Name = "_Chk_5";
			this._Chk_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Chk_5.Size = new System.Drawing.Size(121, 26);
			this._Chk_5.TabIndex = 9;
			this._Chk_5.Text = "MC";
			this._Chk_5.UseVisualStyleBackColor = false;
			//
			//Frame1
			//
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this._Chk_10);
			this.Frame1.Controls.Add(this._Chk_0);
			this.Frame1.Controls.Add(this._Chk_1);
			this.Frame1.Controls.Add(this._Chk_2);
			this.Frame1.Controls.Add(this._Chk_3);
			this.Frame1.Controls.Add(this._Chk_4);
			this.Frame1.Controls.Add(this._Chk_5);
			this.Frame1.Controls.Add(this._Chk_6);
			this.Frame1.Controls.Add(this._Chk_7);
			this.Frame1.Controls.Add(this._Chk_8);
			this.Frame1.Controls.Add(this._Chk_9);
			this.Frame1.Controls.Add(this.ProgressBar1);
			this.Frame1.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(-1, 32);
			this.Frame1.Name = "Frame1";
			this.Frame1.Padding = new System.Windows.Forms.Padding(0);
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(396, 163);
			this.Frame1.TabIndex = 20;
			this.Frame1.TabStop = false;
			this.Frame1.Visible = false;
			//
			//_Chk_10
			//
			this._Chk_10.BackColor = System.Drawing.SystemColors.Control;
			this._Chk_10.Cursor = System.Windows.Forms.Cursors.Default;
			this._Chk_10.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._Chk_10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Chk.SetIndex(this._Chk_10, System.Convert.ToInt16(10));
			this._Chk_10.Location = new System.Drawing.Point(265, 75);
			this._Chk_10.Name = "_Chk_10";
			this._Chk_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Chk_10.Size = new System.Drawing.Size(121, 26);
			this._Chk_10.TabIndex = 18;
			this._Chk_10.Text = "RFID ";
			this._Chk_10.UseVisualStyleBackColor = false;
			//
			//_Chk_6
			//
			this._Chk_6.BackColor = System.Drawing.SystemColors.Control;
			this._Chk_6.Cursor = System.Windows.Forms.Cursors.Default;
			this._Chk_6.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._Chk_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Chk.SetIndex(this._Chk_6, System.Convert.ToInt16(6));
			this._Chk_6.Location = new System.Drawing.Point(140, 75);
			this._Chk_6.Name = "_Chk_6";
			this._Chk_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Chk_6.Size = new System.Drawing.Size(121, 26);
			this._Chk_6.TabIndex = 8;
			this._Chk_6.Text = "Other User";
			this._Chk_6.UseVisualStyleBackColor = false;
			//
			//_Chk_7
			//
			this._Chk_7.BackColor = System.Drawing.SystemColors.Control;
			this._Chk_7.Cursor = System.Windows.Forms.Cursors.Default;
			this._Chk_7.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._Chk_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Chk.SetIndex(this._Chk_7, System.Convert.ToInt16(7));
			this._Chk_7.Location = new System.Drawing.Point(140, 107);
			this._Chk_7.Name = "_Chk_7";
			this._Chk_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Chk_7.Size = new System.Drawing.Size(121, 26);
			this._Chk_7.TabIndex = 7;
			this._Chk_7.Text = "Cash Register";
			this._Chk_7.UseVisualStyleBackColor = false;
			//
			//_Chk_8
			//
			this._Chk_8.BackColor = System.Drawing.SystemColors.Control;
			this._Chk_8.Cursor = System.Windows.Forms.Cursors.Default;
			this._Chk_8.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._Chk_8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Chk.SetIndex(this._Chk_8, System.Convert.ToInt16(8));
			this._Chk_8.Location = new System.Drawing.Point(265, 16);
			this._Chk_8.Name = "_Chk_8";
			this._Chk_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Chk_8.Size = new System.Drawing.Size(121, 26);
			this._Chk_8.TabIndex = 4;
			this._Chk_8.Text = "Cpoint";
			this._Chk_8.UseVisualStyleBackColor = false;
			//
			//_Chk_9
			//
			this._Chk_9.BackColor = System.Drawing.SystemColors.Control;
			this._Chk_9.Cursor = System.Windows.Forms.Cursors.Default;
			this._Chk_9.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._Chk_9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Chk.SetIndex(this._Chk_9, System.Convert.ToInt16(9));
			this._Chk_9.Location = new System.Drawing.Point(265, 45);
			this._Chk_9.Name = "_Chk_9";
			this._Chk_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._Chk_9.Size = new System.Drawing.Size(121, 26);
			this._Chk_9.TabIndex = 2;
			this._Chk_9.Text = "Others";
			this._Chk_9.UseVisualStyleBackColor = false;
			//
			//ProgressBar1
			//
			this.ProgressBar1.Location = new System.Drawing.Point(10, 137);
			this.ProgressBar1.Name = "ProgressBar1";
			this.ProgressBar1.Size = new System.Drawing.Size(376, 21);
			this.ProgressBar1.TabIndex = 3;
			//
			//Chk
			//
			//
			//BackgroundWorker1
			//
			//
			//frmSOD
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 196);
			this.ControlBox = false;
			this.Controls.Add(this.lblmsg);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.Frame2);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximumSize = new System.Drawing.Size(411, 235);
			this.MinimumSize = new System.Drawing.Size(411, 235);
			this.Name = "frmSOD";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SOD";
			this.Frame2.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.Chk).EndInit();
			this.ResumeLayout(false);
			
		}
		public System.Windows.Forms.CheckBox _Chk_0;
		public Microsoft.VisualBasic.Compatibility.VB6.CheckBoxArray Chk;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.CheckBox _Chk_1;
		public System.Windows.Forms.Label lblmsg;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.CheckBox _Chk_2;
		public System.Windows.Forms.CheckBox _Chk_3;
		public System.Windows.Forms.CheckBox _Chk_4;
		public System.Windows.Forms.CheckBox _Chk_5;
		public System.Windows.Forms.GroupBox Frame1;
		public System.Windows.Forms.CheckBox _Chk_6;
		public System.Windows.Forms.CheckBox _Chk_7;
		public System.Windows.Forms.CheckBox _Chk_8;
		public System.Windows.Forms.CheckBox _Chk_9;
		public System.Windows.Forms.ProgressBar ProgressBar1;
		private System.ComponentModel.BackgroundWorker BackgroundWorker1;
		public CheckBox _Chk_10;
	}
	
}
