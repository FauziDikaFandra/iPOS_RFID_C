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
		public partial class frmSPG : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSPG));
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			base.Load += new System.EventHandler(frmSPG_Load);
			this.btn24 = new System.Windows.Forms.Button();
			this.btn24.Click += new System.EventHandler(this.btn1_Click);
			this.btn23 = new System.Windows.Forms.Button();
			this.btn23.Click += new System.EventHandler(this.btn1_Click);
			this.btn22 = new System.Windows.Forms.Button();
			this.btn22.Click += new System.EventHandler(this.btn1_Click);
			this.btn21 = new System.Windows.Forms.Button();
			this.btn21.Click += new System.EventHandler(this.btn1_Click);
			this.btn20 = new System.Windows.Forms.Button();
			this.btn20.Click += new System.EventHandler(this.btn1_Click);
			this.btn19 = new System.Windows.Forms.Button();
			this.btn19.Click += new System.EventHandler(this.btn1_Click);
			this.btn18 = new System.Windows.Forms.Button();
			this.btn18.Click += new System.EventHandler(this.btn1_Click);
			this.btn17 = new System.Windows.Forms.Button();
			this.btn17.Click += new System.EventHandler(this.btn1_Click);
			this.btn16 = new System.Windows.Forms.Button();
			this.btn16.Click += new System.EventHandler(this.btn1_Click);
			this.btn15 = new System.Windows.Forms.Button();
			this.btn15.Click += new System.EventHandler(this.btn1_Click);
			this.btn14 = new System.Windows.Forms.Button();
			this.btn14.Click += new System.EventHandler(this.btn1_Click);
			this.btn13 = new System.Windows.Forms.Button();
			this.btn13.Click += new System.EventHandler(this.btn1_Click);
			this.btn12 = new System.Windows.Forms.Button();
			this.btn12.Click += new System.EventHandler(this.btn1_Click);
			this.btn11 = new System.Windows.Forms.Button();
			this.btn11.Click += new System.EventHandler(this.btn1_Click);
			this.btn10 = new System.Windows.Forms.Button();
			this.btn10.Click += new System.EventHandler(this.btn1_Click);
			this.btn9 = new System.Windows.Forms.Button();
			this.btn9.Click += new System.EventHandler(this.btn1_Click);
			this.btn8 = new System.Windows.Forms.Button();
			this.btn8.Click += new System.EventHandler(this.btn1_Click);
			this.btn7 = new System.Windows.Forms.Button();
			this.btn7.Click += new System.EventHandler(this.btn1_Click);
			this.btn6 = new System.Windows.Forms.Button();
			this.btn6.Click += new System.EventHandler(this.btn1_Click);
			this.btn5 = new System.Windows.Forms.Button();
			this.btn5.Click += new System.EventHandler(this.btn1_Click);
			this.btn4 = new System.Windows.Forms.Button();
			this.btn4.Click += new System.EventHandler(this.btn1_Click);
			this.btn3 = new System.Windows.Forms.Button();
			this.btn3.Click += new System.EventHandler(this.btn1_Click);
			this.btn2 = new System.Windows.Forms.Button();
			this.btn2.Click += new System.EventHandler(this.btn1_Click);
			this.btn1 = new System.Windows.Forms.Button();
			this.btn1.Click += new System.EventHandler(this.btn1_Click);
			this.GroupBox2.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.btn24);
			this.GroupBox2.Controls.Add(this.btn23);
			this.GroupBox2.Controls.Add(this.btn22);
			this.GroupBox2.Controls.Add(this.btn21);
			this.GroupBox2.Controls.Add(this.btn20);
			this.GroupBox2.Controls.Add(this.btn19);
			this.GroupBox2.Controls.Add(this.btn18);
			this.GroupBox2.Controls.Add(this.btn17);
			this.GroupBox2.Controls.Add(this.btn16);
			this.GroupBox2.Controls.Add(this.btn15);
			this.GroupBox2.Controls.Add(this.btn14);
			this.GroupBox2.Controls.Add(this.btn13);
			this.GroupBox2.Controls.Add(this.btn12);
			this.GroupBox2.Controls.Add(this.btn11);
			this.GroupBox2.Controls.Add(this.btn10);
			this.GroupBox2.Controls.Add(this.btn9);
			this.GroupBox2.Controls.Add(this.btn8);
			this.GroupBox2.Controls.Add(this.btn7);
			this.GroupBox2.Controls.Add(this.btn6);
			this.GroupBox2.Controls.Add(this.btn5);
			this.GroupBox2.Controls.Add(this.btn4);
			this.GroupBox2.Controls.Add(this.btn3);
			this.GroupBox2.Controls.Add(this.btn2);
			this.GroupBox2.Controls.Add(this.btn1);
			this.GroupBox2.Font = new System.Drawing.Font("Arial", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GroupBox2.Location = new System.Drawing.Point(12, 6);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(494, 265);
			this.GroupBox2.TabIndex = 3;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "SPG";
			//
			//btn24
			//
			this.btn24.BackColor = System.Drawing.SystemColors.Control;
			this.btn24.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn24.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn24.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn24.Location = new System.Drawing.Point(360, 214);
			this.btn24.Name = "btn24";
			this.btn24.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn24.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn24.Size = new System.Drawing.Size(109, 33);
			this.btn24.TabIndex = 24;
			this.btn24.Tag = "7";
			this.btn24.UseVisualStyleBackColor = false;
			//
			//btn23
			//
			this.btn23.BackColor = System.Drawing.SystemColors.Control;
			this.btn23.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn23.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn23.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn23.Location = new System.Drawing.Point(245, 214);
			this.btn23.Name = "btn23";
			this.btn23.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn23.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn23.Size = new System.Drawing.Size(109, 33);
			this.btn23.TabIndex = 23;
			this.btn23.Tag = "7";
			this.btn23.UseVisualStyleBackColor = false;
			//
			//btn22
			//
			this.btn22.BackColor = System.Drawing.SystemColors.Control;
			this.btn22.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn22.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn22.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn22.Location = new System.Drawing.Point(130, 214);
			this.btn22.Name = "btn22";
			this.btn22.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn22.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn22.Size = new System.Drawing.Size(109, 33);
			this.btn22.TabIndex = 22;
			this.btn22.Tag = "7";
			this.btn22.UseVisualStyleBackColor = false;
			//
			//btn21
			//
			this.btn21.BackColor = System.Drawing.SystemColors.Control;
			this.btn21.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn21.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn21.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn21.Location = new System.Drawing.Point(15, 214);
			this.btn21.Name = "btn21";
			this.btn21.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn21.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn21.Size = new System.Drawing.Size(109, 33);
			this.btn21.TabIndex = 21;
			this.btn21.Tag = "7";
			this.btn21.UseVisualStyleBackColor = false;
			//
			//btn20
			//
			this.btn20.BackColor = System.Drawing.SystemColors.Control;
			this.btn20.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn20.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn20.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn20.Location = new System.Drawing.Point(360, 175);
			this.btn20.Name = "btn20";
			this.btn20.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn20.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn20.Size = new System.Drawing.Size(109, 33);
			this.btn20.TabIndex = 20;
			this.btn20.Tag = "7";
			this.btn20.UseVisualStyleBackColor = false;
			//
			//btn19
			//
			this.btn19.BackColor = System.Drawing.SystemColors.Control;
			this.btn19.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn19.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn19.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn19.Location = new System.Drawing.Point(245, 175);
			this.btn19.Name = "btn19";
			this.btn19.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn19.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn19.Size = new System.Drawing.Size(109, 33);
			this.btn19.TabIndex = 19;
			this.btn19.Tag = "7";
			this.btn19.UseVisualStyleBackColor = false;
			//
			//btn18
			//
			this.btn18.BackColor = System.Drawing.SystemColors.Control;
			this.btn18.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn18.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn18.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn18.Location = new System.Drawing.Point(130, 175);
			this.btn18.Name = "btn18";
			this.btn18.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn18.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn18.Size = new System.Drawing.Size(109, 33);
			this.btn18.TabIndex = 18;
			this.btn18.Tag = "7";
			this.btn18.UseVisualStyleBackColor = false;
			//
			//btn17
			//
			this.btn17.BackColor = System.Drawing.SystemColors.Control;
			this.btn17.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn17.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn17.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn17.Location = new System.Drawing.Point(15, 175);
			this.btn17.Name = "btn17";
			this.btn17.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn17.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn17.Size = new System.Drawing.Size(109, 33);
			this.btn17.TabIndex = 17;
			this.btn17.Tag = "7";
			this.btn17.UseVisualStyleBackColor = false;
			//
			//btn16
			//
			this.btn16.BackColor = System.Drawing.SystemColors.Control;
			this.btn16.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn16.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn16.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn16.Location = new System.Drawing.Point(360, 136);
			this.btn16.Name = "btn16";
			this.btn16.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn16.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn16.Size = new System.Drawing.Size(109, 33);
			this.btn16.TabIndex = 16;
			this.btn16.Tag = "7";
			this.btn16.UseVisualStyleBackColor = false;
			//
			//btn15
			//
			this.btn15.BackColor = System.Drawing.SystemColors.Control;
			this.btn15.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn15.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn15.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn15.Location = new System.Drawing.Point(245, 136);
			this.btn15.Name = "btn15";
			this.btn15.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn15.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn15.Size = new System.Drawing.Size(109, 33);
			this.btn15.TabIndex = 15;
			this.btn15.Tag = "7";
			this.btn15.UseVisualStyleBackColor = false;
			//
			//btn14
			//
			this.btn14.BackColor = System.Drawing.SystemColors.Control;
			this.btn14.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn14.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn14.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn14.Location = new System.Drawing.Point(130, 136);
			this.btn14.Name = "btn14";
			this.btn14.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn14.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn14.Size = new System.Drawing.Size(109, 33);
			this.btn14.TabIndex = 14;
			this.btn14.Tag = "7";
			this.btn14.UseVisualStyleBackColor = false;
			//
			//btn13
			//
			this.btn13.BackColor = System.Drawing.SystemColors.Control;
			this.btn13.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn13.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn13.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn13.Location = new System.Drawing.Point(15, 136);
			this.btn13.Name = "btn13";
			this.btn13.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn13.Size = new System.Drawing.Size(109, 33);
			this.btn13.TabIndex = 13;
			this.btn13.Tag = "7";
			this.btn13.UseVisualStyleBackColor = false;
			//
			//btn12
			//
			this.btn12.BackColor = System.Drawing.SystemColors.Control;
			this.btn12.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn12.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn12.Location = new System.Drawing.Point(360, 97);
			this.btn12.Name = "btn12";
			this.btn12.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn12.Size = new System.Drawing.Size(109, 33);
			this.btn12.TabIndex = 12;
			this.btn12.Tag = "7";
			this.btn12.UseVisualStyleBackColor = false;
			//
			//btn11
			//
			this.btn11.BackColor = System.Drawing.SystemColors.Control;
			this.btn11.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn11.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn11.Location = new System.Drawing.Point(245, 97);
			this.btn11.Name = "btn11";
			this.btn11.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn11.Size = new System.Drawing.Size(109, 33);
			this.btn11.TabIndex = 11;
			this.btn11.Tag = "7";
			this.btn11.UseVisualStyleBackColor = false;
			//
			//btn10
			//
			this.btn10.BackColor = System.Drawing.SystemColors.Control;
			this.btn10.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn10.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn10.Location = new System.Drawing.Point(130, 97);
			this.btn10.Name = "btn10";
			this.btn10.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn10.Size = new System.Drawing.Size(109, 33);
			this.btn10.TabIndex = 10;
			this.btn10.Tag = "7";
			this.btn10.UseVisualStyleBackColor = false;
			//
			//btn9
			//
			this.btn9.BackColor = System.Drawing.SystemColors.Control;
			this.btn9.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn9.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn9.Location = new System.Drawing.Point(15, 97);
			this.btn9.Name = "btn9";
			this.btn9.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn9.Size = new System.Drawing.Size(109, 33);
			this.btn9.TabIndex = 9;
			this.btn9.Tag = "7";
			this.btn9.UseVisualStyleBackColor = false;
			//
			//btn8
			//
			this.btn8.BackColor = System.Drawing.SystemColors.Control;
			this.btn8.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn8.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn8.Location = new System.Drawing.Point(360, 58);
			this.btn8.Name = "btn8";
			this.btn8.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn8.Size = new System.Drawing.Size(109, 33);
			this.btn8.TabIndex = 8;
			this.btn8.Tag = "7";
			this.btn8.UseVisualStyleBackColor = false;
			//
			//btn7
			//
			this.btn7.BackColor = System.Drawing.SystemColors.Control;
			this.btn7.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn7.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn7.Location = new System.Drawing.Point(245, 58);
			this.btn7.Name = "btn7";
			this.btn7.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn7.Size = new System.Drawing.Size(109, 33);
			this.btn7.TabIndex = 7;
			this.btn7.Tag = "7";
			this.btn7.UseVisualStyleBackColor = false;
			//
			//btn6
			//
			this.btn6.BackColor = System.Drawing.SystemColors.Control;
			this.btn6.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn6.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn6.Location = new System.Drawing.Point(130, 58);
			this.btn6.Name = "btn6";
			this.btn6.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn6.Size = new System.Drawing.Size(109, 33);
			this.btn6.TabIndex = 6;
			this.btn6.Tag = "7";
			this.btn6.UseVisualStyleBackColor = false;
			//
			//btn5
			//
			this.btn5.BackColor = System.Drawing.SystemColors.Control;
			this.btn5.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn5.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn5.Location = new System.Drawing.Point(15, 58);
			this.btn5.Name = "btn5";
			this.btn5.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn5.Size = new System.Drawing.Size(109, 33);
			this.btn5.TabIndex = 5;
			this.btn5.Tag = "7";
			this.btn5.UseVisualStyleBackColor = false;
			//
			//btn4
			//
			this.btn4.BackColor = System.Drawing.SystemColors.Control;
			this.btn4.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn4.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn4.Location = new System.Drawing.Point(360, 19);
			this.btn4.Name = "btn4";
			this.btn4.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn4.Size = new System.Drawing.Size(109, 33);
			this.btn4.TabIndex = 4;
			this.btn4.Tag = "7";
			this.btn4.UseVisualStyleBackColor = false;
			//
			//btn3
			//
			this.btn3.BackColor = System.Drawing.SystemColors.Control;
			this.btn3.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn3.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn3.Location = new System.Drawing.Point(245, 19);
			this.btn3.Name = "btn3";
			this.btn3.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn3.Size = new System.Drawing.Size(109, 33);
			this.btn3.TabIndex = 3;
			this.btn3.Tag = "7";
			this.btn3.UseVisualStyleBackColor = false;
			//
			//btn2
			//
			this.btn2.BackColor = System.Drawing.SystemColors.Control;
			this.btn2.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn2.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn2.Location = new System.Drawing.Point(130, 19);
			this.btn2.Name = "btn2";
			this.btn2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn2.Size = new System.Drawing.Size(109, 33);
			this.btn2.TabIndex = 2;
			this.btn2.Tag = "7";
			this.btn2.UseVisualStyleBackColor = false;
			//
			//btn1
			//
			this.btn1.BackColor = System.Drawing.SystemColors.Control;
			this.btn1.Cursor = System.Windows.Forms.Cursors.Default;
			this.btn1.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.btn1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btn1.Location = new System.Drawing.Point(15, 19);
			this.btn1.Name = "btn1";
			this.btn1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this.btn1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn1.Size = new System.Drawing.Size(109, 33);
			this.btn1.TabIndex = 1;
			this.btn1.Tag = "7";
			this.btn1.UseVisualStyleBackColor = false;
			//
			//frmSPG
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (15.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLight;
			this.ClientSize = new System.Drawing.Size(518, 283);
			this.Controls.Add(this.GroupBox2);
			this.Font = new System.Drawing.Font("Arial Narrow", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(534, 322);
			this.MinimizeBox = false;
			this.MinimumSize = new System.Drawing.Size(534, 322);
			this.Name = "frmSPG";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SPG";
			this.GroupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		
		internal GroupBox GroupBox2;
		public Button btn20;
		public Button btn19;
		public Button btn18;
		public Button btn17;
		public Button btn16;
		public Button btn15;
		public Button btn14;
		public Button btn13;
		public Button btn12;
		public Button btn11;
		public Button btn10;
		public Button btn9;
		public Button btn8;
		public Button btn7;
		public Button btn6;
		public Button btn5;
		public Button btn4;
		public Button btn3;
		public Button btn2;
		public Button btn1;
		public Button btn24;
		public Button btn23;
		public Button btn22;
		public Button btn21;
	}
	
}
