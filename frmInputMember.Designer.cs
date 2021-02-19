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
	partial class InputMember : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(InputMember_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InputMember));
			this.Label6 = new System.Windows.Forms.Label();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
			this.Label4 = new System.Windows.Forms.Label();
			this.txtcust_name = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtcard_no = new System.Windows.Forms.TextBox();
			this.Label2 = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.lblmsg = new System.Windows.Forms.Label();
			this.CmdOk = new System.Windows.Forms.Button();
			this.CmdOk.Click += new System.EventHandler(this.CmdOk_Click);
			this.CmdCancel = new System.Windows.Forms.Button();
			this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
			this.Label1 = new System.Windows.Forms.Label();
			this.Label1.Click += new System.EventHandler(this.Label1_Click);
			this.CmdNav = new System.Windows.Forms.Button();
			this.CmdNav.Click += new System.EventHandler(this.CmdNav_Click);
			this.Frame2.SuspendLayout();
			this.SuspendLayout();
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label6.Location = new System.Drawing.Point(14, 137);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(55, 16);
			this.Label6.TabIndex = 34;
			this.Label6.Text = "Gender";
			//
			//txtEmail
			//
			this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtEmail.Enabled = false;
			this.txtEmail.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtEmail.Location = new System.Drawing.Point(144, 102);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(233, 22);
			this.txtEmail.TabIndex = 33;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(14, 106);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(44, 16);
			this.Label5.TabIndex = 32;
			this.Label5.Text = "Email";
			//
			//txtPhone
			//
			this.txtPhone.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtPhone.Location = new System.Drawing.Point(144, 16);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(188, 22);
			this.txtPhone.TabIndex = 31;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(14, 19);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(103, 16);
			this.Label4.TabIndex = 30;
			this.Label4.Text = "Phone Number";
			//
			//txtcust_name
			//
			this.txtcust_name.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtcust_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtcust_name.Enabled = false;
			this.txtcust_name.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtcust_name.Location = new System.Drawing.Point(144, 73);
			this.txtcust_name.Name = "txtcust_name";
			this.txtcust_name.Size = new System.Drawing.Size(233, 22);
			this.txtcust_name.TabIndex = 2;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(14, 77);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(109, 16);
			this.Label3.TabIndex = 28;
			this.Label3.Text = "Customer Name";
			//
			//txtcard_no
			//
			this.txtcard_no.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtcard_no.Enabled = false;
			this.txtcard_no.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtcard_no.Location = new System.Drawing.Point(144, 44);
			this.txtcard_no.Name = "txtcard_no";
			this.txtcard_no.Size = new System.Drawing.Size(113, 22);
			this.txtcard_no.TabIndex = 27;
			//
			//label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(14, 48);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(59, 16);
			this.Label2.TabIndex = 26;
			this.Label2.Text = "Card No";
			//
			//Timer1
			//
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 3000;
			//
			//Frame2
			//
			this.Frame2.BackColor = System.Drawing.Color.White;
			this.Frame2.Controls.Add(this.ComboBox1);
			this.Frame2.Controls.Add(this.Label6);
			this.Frame2.Controls.Add(this.txtEmail);
			this.Frame2.Controls.Add(this.Label5);
			this.Frame2.Controls.Add(this.txtPhone);
			this.Frame2.Controls.Add(this.Label4);
			this.Frame2.Controls.Add(this.txtcust_name);
			this.Frame2.Controls.Add(this.Label3);
			this.Frame2.Controls.Add(this.txtcard_no);
			this.Frame2.Controls.Add(this.Label2);
			this.Frame2.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(5, 35);
			this.Frame2.Name = "Frame2";
			this.Frame2.Padding = new System.Windows.Forms.Padding(0);
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(395, 167);
			this.Frame2.TabIndex = 29;
			this.Frame2.TabStop = false;
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Enabled = false;
			this.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ComboBox1.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(144, 133);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(113, 24);
			this.ComboBox1.TabIndex = 76;
			//
			//lblmsg
			//
			this.lblmsg.BackColor = System.Drawing.Color.DimGray;
			this.lblmsg.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblmsg.Font = new System.Drawing.Font("Arial", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblmsg.ForeColor = System.Drawing.Color.Yellow;
			this.lblmsg.Location = new System.Drawing.Point(-5, 1);
			this.lblmsg.Name = "lblmsg";
			this.lblmsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblmsg.Size = new System.Drawing.Size(416, 31);
			this.lblmsg.TabIndex = 28;
			this.lblmsg.Text = "INPUT PHONE NUMBER";
			this.lblmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//CmdOk
			//
			this.CmdOk.BackColor = System.Drawing.SystemColors.Control;
			this.CmdOk.Cursor = System.Windows.Forms.Cursors.Default;
			this.CmdOk.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.CmdOk.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdOk.Image = (System.Drawing.Image) (resources.GetObject("CmdOk.Image"));
			this.CmdOk.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CmdOk.Location = new System.Drawing.Point(146, 208);
			this.CmdOk.Name = "CmdOk";
			this.CmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CmdOk.Size = new System.Drawing.Size(80, 48);
			this.CmdOk.TabIndex = 26;
			this.CmdOk.Text = "OK";
			this.CmdOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.CmdOk.UseVisualStyleBackColor = false;
			//
			//CmdCancel
			//
			this.CmdCancel.BackColor = System.Drawing.SystemColors.Control;
			this.CmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
			this.CmdCancel.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.CmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdCancel.Image = (System.Drawing.Image) (resources.GetObject("CmdCancel.Image"));
			this.CmdCancel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CmdCancel.Location = new System.Drawing.Point(232, 208);
			this.CmdCancel.Name = "CmdCancel";
			this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CmdCancel.Size = new System.Drawing.Size(80, 48);
			this.CmdCancel.TabIndex = 27;
			this.CmdCancel.Text = "CANCEL";
			this.CmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.CmdCancel.UseVisualStyleBackColor = false;
			//
			//Label1
			//
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.Font = new System.Drawing.Font("Arial", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.Blue;
			this.Label1.Location = new System.Drawing.Point(19, 208);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(86, 16);
			this.Label1.TabIndex = 34;
			this.Label1.Text = "NEW MEMBER";
			//
			//CmdNav
			//
			this.CmdNav.BackColor = System.Drawing.SystemColors.Control;
			this.CmdNav.Cursor = System.Windows.Forms.Cursors.Default;
			this.CmdNav.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.CmdNav.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdNav.Image = (System.Drawing.Image) (resources.GetObject("CmdNav.Image"));
			this.CmdNav.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CmdNav.Location = new System.Drawing.Point(318, 208);
			this.CmdNav.Name = "CmdNav";
			this.CmdNav.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CmdNav.Size = new System.Drawing.Size(76, 48);
			this.CmdNav.TabIndex = 35;
			this.CmdNav.Text = "&NUM";
			this.CmdNav.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CmdNav.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.CmdNav.UseVisualStyleBackColor = false;
			//
			//InputMember
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (14.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(406, 260);
			this.ControlBox = false;
			this.Controls.Add(this.CmdNav);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.lblmsg);
			this.Controls.Add(this.CmdOk);
			this.Controls.Add(this.CmdCancel);
			this.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximumSize = new System.Drawing.Size(422, 299);
			this.MinimumSize = new System.Drawing.Size(422, 299);
			this.Name = "InputMember";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Input Member";
			this.TopMost = true;
			this.Frame2.ResumeLayout(false);
			this.Frame2.PerformLayout();
			this.ResumeLayout(false);
			
		}
		
		internal Label Label6;
		internal TextBox txtEmail;
		internal Label Label5;
		internal TextBox txtPhone;
		internal Label Label4;
		internal TextBox txtcust_name;
		internal Label Label3;
		internal TextBox txtcard_no;
		internal Label Label2;
		public Timer Timer1;
		public ToolTip ToolTip1;
		public GroupBox Frame2;
		internal ComboBox ComboBox1;
		public Label lblmsg;
		public Button CmdOk;
		public Button CmdCancel;
		public Label Label1;
		public Button CmdNav;
	}
	
}
