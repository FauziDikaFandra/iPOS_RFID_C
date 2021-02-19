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
		public partial class frmLogin : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
			this.Frame2 = new System.Windows.Forms.GroupBox();
			base.Load += new System.EventHandler(frmLogin_Load);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmLogin_FormClosed);
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
			this.txtuserNet = new System.Windows.Forms.TextBox();
			this.txtuserNet.Enter += new System.EventHandler(this.txtuserNet_Enter);
			this.txtuserNet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtuserNet_KeyDown);
			this.Label2 = new System.Windows.Forms.Label();
			this.txtregidNet = new System.Windows.Forms.TextBox();
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblonline = new System.Windows.Forms.Label();
			this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.Line1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.txtpasswordNet = new System.Windows.Forms.TextBox();
			this.txtpasswordNet.Enter += new System.EventHandler(this.txtpasswordNet_Enter);
			this.txtpasswordNet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpasswordNet_KeyDown);
			this.lbltoko = new System.Windows.Forms.Label();
			this.Frame2.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.SuspendLayout();
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
			this.Frame2.Location = new System.Drawing.Point(0, 128);
			this.Frame2.Name = "Frame2";
			this.Frame2.Padding = new System.Windows.Forms.Padding(0);
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(278, 285);
			this.Frame2.TabIndex = 22;
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
			this._btnNum_0.TabIndex = 1;
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
			//txtuserNet
			//
			this.txtuserNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtuserNet.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtuserNet.Location = new System.Drawing.Point(114, 59);
			this.txtuserNet.Name = "txtuserNet";
			this.txtuserNet.Size = new System.Drawing.Size(152, 26);
			this.txtuserNet.TabIndex = 25;
			//
			//label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(13, 63);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(60, 16);
			this.Label2.TabIndex = 24;
			this.Label2.Text = "USER ID";
			//
			//txtregidNet
			//
			this.txtregidNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtregidNet.Enabled = false;
			this.txtregidNet.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtregidNet.Location = new System.Drawing.Point(114, 15);
			this.txtregidNet.Name = "txtregidNet";
			this.txtregidNet.Size = new System.Drawing.Size(36, 26);
			this.txtregidNet.TabIndex = 23;
			//
			//Frame1
			//
			this.Frame1.BackColor = System.Drawing.Color.White;
			this.Frame1.Controls.Add(this.txtuserNet);
			this.Frame1.Controls.Add(this.Label2);
			this.Frame1.Controls.Add(this.txtregidNet);
			this.Frame1.Controls.Add(this.Label1);
			this.Frame1.Controls.Add(this.lblonline);
			this.Frame1.Controls.Add(this.ShapeContainer1);
			this.Frame1.Controls.Add(this.txtpasswordNet);
			this.Frame1.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(-3, 33);
			this.Frame1.Name = "Frame1";
			this.Frame1.Padding = new System.Windows.Forms.Padding(0);
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(281, 96);
			this.Frame1.TabIndex = 20;
			this.Frame1.TabStop = false;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(13, 20);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(90, 16);
			this.Label1.TabIndex = 22;
			this.Label1.Text = "REGISTER ID";
			//
			//lblonline
			//
			this.lblonline.BackColor = System.Drawing.Color.Black;
			this.lblonline.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblonline.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblonline.ForeColor = System.Drawing.Color.Red;
			this.lblonline.Location = new System.Drawing.Point(165, 15);
			this.lblonline.Name = "lblonline";
			this.lblonline.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblonline.Size = new System.Drawing.Size(101, 26);
			this.lblonline.TabIndex = 20;
			this.lblonline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//ShapeContainer1
			//
			this.ShapeContainer1.Location = new System.Drawing.Point(0, 13);
			this.ShapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.ShapeContainer1.Name = "ShapeContainer1";
			this.ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {this.Line1});
			this.ShapeContainer1.Size = new System.Drawing.Size(281, 83);
			this.ShapeContainer1.TabIndex = 21;
			this.ShapeContainer1.TabStop = false;
			//
			//Line1
			//
			this.Line1.BorderColor = System.Drawing.SystemColors.WindowText;
			this.Line1.Name = "Line1";
			this.Line1.X1 = 0;
			this.Line1.X2 = 280;
			this.Line1.Y1 = 37;
			this.Line1.Y2 = 37;
			//
			//txtpasswordNet
			//
			this.txtpasswordNet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtpasswordNet.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtpasswordNet.Location = new System.Drawing.Point(114, 59);
			this.txtpasswordNet.Name = "txtpasswordNet";
			this.txtpasswordNet.Size = new System.Drawing.Size(152, 26);
			this.txtpasswordNet.TabIndex = 26;
			this.txtpasswordNet.UseSystemPasswordChar = true;
			//
			//lbltoko
			//
			this.lbltoko.BackColor = System.Drawing.Color.Gray;
			this.lbltoko.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbltoko.Font = new System.Drawing.Font("Arial", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lbltoko.ForeColor = System.Drawing.Color.Yellow;
			this.lbltoko.Location = new System.Drawing.Point(-8, 1);
			this.lbltoko.Name = "lbltoko";
			this.lbltoko.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbltoko.Size = new System.Drawing.Size(296, 31);
			this.lbltoko.TabIndex = 21;
			this.lbltoko.Text = "LAKON";
			this.lbltoko.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//frmLogin
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (13.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(281, 409);
			this.ControlBox = false;
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.lbltoko);
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.KeyPreview = true;
			this.MaximumSize = new System.Drawing.Size(297, 448);
			this.MinimumSize = new System.Drawing.Size(297, 448);
			this.Name = "frmLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LOGIN";
			this.Frame2.ResumeLayout(false);
			this.Frame1.ResumeLayout(false);
			this.Frame1.PerformLayout();
			this.ResumeLayout(false);
			
		}
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
		public Microsoft.VisualBasic.Compatibility.VB6.ButtonArray btnNum;
		internal System.Windows.Forms.TextBox txtuserNet;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtregidNet;
		public System.Windows.Forms.GroupBox Frame1;
		internal System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label lblonline;
		public Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
		public Microsoft.VisualBasic.PowerPacks.LineShape Line1;
		internal System.Windows.Forms.TextBox txtpasswordNet;
		public System.Windows.Forms.Label lbltoko;
	}
	
}
