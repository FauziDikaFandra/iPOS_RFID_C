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
	partial class frmPassword : System.Windows.Forms.Form
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
			this.Load += new System.EventHandler(frmPassword_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPassword));
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Frame1 = new System.Windows.Forms.Panel();
			this.Label2 = new System.Windows.Forms.Label();
			this.txtpassword = new System.Windows.Forms.TextBox();
			this.txtpassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpassword_KeyDown);
			this.btnNum = new Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(this.components);
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this._btnNum_13 = new System.Windows.Forms.Button();
			this._btnNum_13.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_12 = new System.Windows.Forms.Button();
			this._btnNum_12.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_10 = new System.Windows.Forms.Button();
			this._btnNum_10.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_11 = new System.Windows.Forms.Button();
			this._btnNum_11.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_0 = new System.Windows.Forms.Button();
			this._btnNum_0.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_1 = new System.Windows.Forms.Button();
			this._btnNum_1.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_2 = new System.Windows.Forms.Button();
			this._btnNum_2.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_3 = new System.Windows.Forms.Button();
			this._btnNum_3.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_4 = new System.Windows.Forms.Button();
			this._btnNum_4.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_5 = new System.Windows.Forms.Button();
			this._btnNum_5.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_6 = new System.Windows.Forms.Button();
			this._btnNum_6.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_7 = new System.Windows.Forms.Button();
			this._btnNum_7.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_8 = new System.Windows.Forms.Button();
			this._btnNum_8.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_9 = new System.Windows.Forms.Button();
			this._btnNum_9.Click += new System.EventHandler(this._btnNum_0_Click);
			this.Frame1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.btnNum).BeginInit();
			this.Frame2.SuspendLayout();
			this.SuspendLayout();
			//
			//Frame1
			//
			this.Frame1.BackColor = System.Drawing.Color.DimGray;
			this.Frame1.Controls.Add(this.Label2);
			this.Frame1.Controls.Add(this.txtpassword);
			this.Frame1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Frame1.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(1, 0);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(281, 46);
			this.Frame1.TabIndex = 18;
			//
			//label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.Yellow;
			this.Label2.Location = new System.Drawing.Point(15, 16);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(125, 16);
			this.Label2.TabIndex = 27;
			this.Label2.Text = "PASSWORD LAMA";
			//
			//txtpassword
			//
			this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtpassword.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtpassword.Location = new System.Drawing.Point(146, 12);
			this.txtpassword.Name = "txtpassword";
			this.txtpassword.Size = new System.Drawing.Size(124, 26);
			this.txtpassword.TabIndex = 0;
			this.txtpassword.UseSystemPasswordChar = true;
			//
			//Frame2
			//
			this.Frame2.BackColor = System.Drawing.Color.White;
			this.Frame2.Controls.Add(this._btnNum_13);
			this.Frame2.Controls.Add(this._btnNum_12);
			this.Frame2.Controls.Add(this._btnNum_10);
			this.Frame2.Controls.Add(this._btnNum_11);
			this.Frame2.Controls.Add(this._btnNum_0);
			this.Frame2.Controls.Add(this._btnNum_1);
			this.Frame2.Controls.Add(this._btnNum_2);
			this.Frame2.Controls.Add(this._btnNum_3);
			this.Frame2.Controls.Add(this._btnNum_4);
			this.Frame2.Controls.Add(this._btnNum_5);
			this.Frame2.Controls.Add(this._btnNum_6);
			this.Frame2.Controls.Add(this._btnNum_7);
			this.Frame2.Controls.Add(this._btnNum_8);
			this.Frame2.Controls.Add(this._btnNum_9);
			this.Frame2.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(1, 52);
			this.Frame2.Name = "Frame2";
			this.Frame2.Padding = new System.Windows.Forms.Padding(0);
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(278, 285);
			this.Frame2.TabIndex = 23;
			this.Frame2.TabStop = false;
			//
			//_btnNum_13
			//
			this._btnNum_13.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_13.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_13.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_13.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_13.Location = new System.Drawing.Point(208, 210);
			this._btnNum_13.Name = "_btnNum_13";
			this._btnNum_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_13.Size = new System.Drawing.Size(68, 68);
			this._btnNum_13.TabIndex = 13;
			this._btnNum_13.Tag = "13";
			this._btnNum_13.Text = "CLOSE";
			this._btnNum_13.UseVisualStyleBackColor = false;
			//
			//_btnNum_12
			//
			this._btnNum_12.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_12.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_12.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_12.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_12.Location = new System.Drawing.Point(208, 111);
			this._btnNum_12.Name = "_btnNum_12";
			this._btnNum_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_12.Size = new System.Drawing.Size(68, 100);
			this._btnNum_12.TabIndex = 12;
			this._btnNum_12.Tag = "12";
			this._btnNum_12.Text = "C";
			this._btnNum_12.UseVisualStyleBackColor = false;
			//
			//_btnNum_10
			//
			this._btnNum_10.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_10.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_10.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_10.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_10.Location = new System.Drawing.Point(208, 9);
			this._btnNum_10.Name = "_btnNum_10";
			this._btnNum_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_10.Size = new System.Drawing.Size(68, 102);
			this._btnNum_10.TabIndex = 11;
			this._btnNum_10.Tag = "10";
			this._btnNum_10.Text = "<<";
			this._btnNum_10.UseVisualStyleBackColor = false;
			//
			//_btnNum_11
			//
			this._btnNum_11.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_11.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_11.Font = new System.Drawing.Font("Arial", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_11.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_11.Location = new System.Drawing.Point(73, 210);
			this._btnNum_11.Name = "_btnNum_11";
			this._btnNum_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_11.Size = new System.Drawing.Size(135, 68);
			this._btnNum_11.TabIndex = 14;
			this._btnNum_11.Tag = "11";
			this._btnNum_11.Text = "ENTER";
			this._btnNum_11.UseVisualStyleBackColor = false;
			//
			//_btnNum_0
			//
			this._btnNum_0.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_0.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_0.Location = new System.Drawing.Point(6, 210);
			this._btnNum_0.Name = "_btnNum_0";
			this._btnNum_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_0.Size = new System.Drawing.Size(68, 68);
			this._btnNum_0.TabIndex = 5;
			this._btnNum_0.Tag = "0";
			this._btnNum_0.Text = "0";
			this._btnNum_0.UseVisualStyleBackColor = false;
			//
			//_btnNum_1
			//
			this._btnNum_1.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_1.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_1.Location = new System.Drawing.Point(6, 143);
			this._btnNum_1.Name = "_btnNum_1";
			this._btnNum_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_1.Size = new System.Drawing.Size(68, 68);
			this._btnNum_1.TabIndex = 2;
			this._btnNum_1.Tag = "1";
			this._btnNum_1.Text = "1";
			this._btnNum_1.UseVisualStyleBackColor = false;
			//
			//_btnNum_2
			//
			this._btnNum_2.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_2.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_2.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_2.Location = new System.Drawing.Point(73, 143);
			this._btnNum_2.Name = "_btnNum_2";
			this._btnNum_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_2.Size = new System.Drawing.Size(68, 68);
			this._btnNum_2.TabIndex = 3;
			this._btnNum_2.Tag = "2";
			this._btnNum_2.Text = "2";
			this._btnNum_2.UseVisualStyleBackColor = false;
			//
			//_btnNum_3
			//
			this._btnNum_3.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_3.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_3.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_3.Location = new System.Drawing.Point(140, 143);
			this._btnNum_3.Name = "_btnNum_3";
			this._btnNum_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_3.Size = new System.Drawing.Size(68, 68);
			this._btnNum_3.TabIndex = 4;
			this._btnNum_3.Tag = "3";
			this._btnNum_3.Text = "3";
			this._btnNum_3.UseVisualStyleBackColor = false;
			//
			//_btnNum_4
			//
			this._btnNum_4.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_4.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_4.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_4.Location = new System.Drawing.Point(6, 76);
			this._btnNum_4.Name = "_btnNum_4";
			this._btnNum_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_4.Size = new System.Drawing.Size(68, 68);
			this._btnNum_4.TabIndex = 5;
			this._btnNum_4.Tag = "4";
			this._btnNum_4.Text = "4";
			this._btnNum_4.UseVisualStyleBackColor = false;
			//
			//_btnNum_5
			//
			this._btnNum_5.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_5.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_5.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_5.Location = new System.Drawing.Point(73, 76);
			this._btnNum_5.Name = "_btnNum_5";
			this._btnNum_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_5.Size = new System.Drawing.Size(68, 68);
			this._btnNum_5.TabIndex = 6;
			this._btnNum_5.Tag = "5";
			this._btnNum_5.Text = "5";
			this._btnNum_5.UseVisualStyleBackColor = false;
			//
			//_btnNum_6
			//
			this._btnNum_6.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_6.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_6.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_6.Location = new System.Drawing.Point(140, 76);
			this._btnNum_6.Name = "_btnNum_6";
			this._btnNum_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_6.Size = new System.Drawing.Size(68, 68);
			this._btnNum_6.TabIndex = 7;
			this._btnNum_6.Tag = "6";
			this._btnNum_6.Text = "6";
			this._btnNum_6.UseVisualStyleBackColor = false;
			//
			//_btnNum_7
			//
			this._btnNum_7.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_7.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_7.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_7.Location = new System.Drawing.Point(6, 9);
			this._btnNum_7.Name = "_btnNum_7";
			this._btnNum_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_7.Size = new System.Drawing.Size(68, 68);
			this._btnNum_7.TabIndex = 8;
			this._btnNum_7.Tag = "7";
			this._btnNum_7.Text = "7";
			this._btnNum_7.UseVisualStyleBackColor = false;
			//
			//_btnNum_8
			//
			this._btnNum_8.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_8.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_8.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_8.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_8.Location = new System.Drawing.Point(73, 9);
			this._btnNum_8.Name = "_btnNum_8";
			this._btnNum_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_8.Size = new System.Drawing.Size(68, 68);
			this._btnNum_8.TabIndex = 9;
			this._btnNum_8.Tag = "8";
			this._btnNum_8.Text = "8";
			this._btnNum_8.UseVisualStyleBackColor = false;
			//
			//_btnNum_9
			//
			this._btnNum_9.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_9.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_9.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_9.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_9.Location = new System.Drawing.Point(140, 9);
			this._btnNum_9.Name = "_btnNum_9";
			this._btnNum_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_9.Size = new System.Drawing.Size(68, 68);
			this._btnNum_9.TabIndex = 10;
			this._btnNum_9.Tag = "9";
			this._btnNum_9.Text = "9";
			this._btnNum_9.UseVisualStyleBackColor = false;
			//
			//frmPassword
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (14.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(282, 335);
			this.ControlBox = false;
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Frame1);
			this.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.KeyPreview = true;
			this.MaximumSize = new System.Drawing.Size(298, 374);
			this.MinimumSize = new System.Drawing.Size(298, 374);
			this.Name = "frmPassword";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CHANGE PASSWORD";
			this.Frame1.ResumeLayout(false);
			this.Frame1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.btnNum).EndInit();
			this.Frame2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		public Microsoft.VisualBasic.Compatibility.VB6.ButtonArray btnNum;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.Panel Frame1;
		internal System.Windows.Forms.TextBox txtpassword;
		internal System.Windows.Forms.Label Label2;
		public System.Windows.Forms.GroupBox Frame2;
		public System.Windows.Forms.Button _btnNum_13;
		public System.Windows.Forms.Button _btnNum_12;
		public System.Windows.Forms.Button _btnNum_10;
		public System.Windows.Forms.Button _btnNum_11;
		public System.Windows.Forms.Button _btnNum_0;
		public System.Windows.Forms.Button _btnNum_1;
		public System.Windows.Forms.Button _btnNum_2;
		public System.Windows.Forms.Button _btnNum_3;
		public System.Windows.Forms.Button _btnNum_4;
		public System.Windows.Forms.Button _btnNum_5;
		public System.Windows.Forms.Button _btnNum_6;
		public System.Windows.Forms.Button _btnNum_7;
		public System.Windows.Forms.Button _btnNum_8;
		public System.Windows.Forms.Button _btnNum_9;
	}
	
}
