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
		public partial class frmMain : System.Windows.Forms.Form
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
			base.Activated += new System.EventHandler(frmMain_Activated);
			base.Load += new System.EventHandler(frmMain_Load);
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
			this.DataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseUp);
			this.txtinfo = new System.Windows.Forms.TextBox();
			this.txtinfo.Enter += new System.EventHandler(this.txtinfo_Enter);
			this.Label1 = new System.Windows.Forms.Label();
			this.Label1.Click += new System.EventHandler(this.Label1_Click);
			this.Label7 = new System.Windows.Forms.Label();
			this.Frame2 = new System.Windows.Forms.Panel();
			this._cmdMenu_8 = new System.Windows.Forms.Button();
			this._cmdMenu_8.Click += new System.EventHandler(this._cmdMenu_0_Click);
			this._cmdMenu_9 = new System.Windows.Forms.Button();
			this._cmdMenu_9.Click += new System.EventHandler(this._cmdMenu_0_Click);
			this._cmdMenu_3 = new System.Windows.Forms.Button();
			this._cmdMenu_3.Click += new System.EventHandler(this._cmdMenu_0_Click);
			this._cmdMenu_7 = new System.Windows.Forms.Button();
			this._cmdMenu_7.Click += new System.EventHandler(this._cmdMenu_0_Click);
			this._cmdMenu_6 = new System.Windows.Forms.Button();
			this._cmdMenu_6.Click += new System.EventHandler(this._cmdMenu_0_Click);
			this._cmdMenu_5 = new System.Windows.Forms.Button();
			this._cmdMenu_5.Click += new System.EventHandler(this._cmdMenu_0_Click);
			this._cmdMenu_4 = new System.Windows.Forms.Button();
			this._cmdMenu_4.Click += new System.EventHandler(this._cmdMenu_0_Click);
			this._cmdMenu_2 = new System.Windows.Forms.Button();
			this._cmdMenu_2.Click += new System.EventHandler(this._cmdMenu_0_Click);
			this._cmdMenu_1 = new System.Windows.Forms.Button();
			this._cmdMenu_1.Click += new System.EventHandler(this._cmdMenu_0_Click);
			this._cmdMenu_0 = new System.Windows.Forms.Button();
			this._cmdMenu_0.Click += new System.EventHandler(this._cmdMenu_0_Click);
			this.Label8 = new System.Windows.Forms.Label();
			this.Frame3 = new System.Windows.Forms.Panel();
			this.lblline = new System.Windows.Forms.Label();
			this.lbljam = new System.Windows.Forms.Label();
			this.lbltgl = new System.Windows.Forms.Label();
			this.lblkasir = new System.Windows.Forms.Label();
			this.lblreg = new System.Windows.Forms.Label();
			this.lblbranch = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ContextMenuStrip1.Click += new System.EventHandler(this.ContextMenuStrip1_Click);
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.lblMember = new System.Windows.Forms.Label();
			this.lblMember.Click += new System.EventHandler(this.Label3_Click);
			this.lblMember.MouseHover += new System.EventHandler(this.lblMember_MouseHover);
			this.lblMember.MouseLeave += new System.EventHandler(this.lblMember_MouseLeave);
			this.lblMemberTran = new System.Windows.Forms.Label();
			this.lblMemberTran.Click += new System.EventHandler(this.Label4_Click);
			this.lblMemberTran.MouseHover += new System.EventHandler(this.lblMemberTran_MouseHover);
			this.lblMemberTran.MouseLeave += new System.EventHandler(this.lblMemberTran_MouseLeave);
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			this.Frame2.SuspendLayout();
			this.Frame3.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//Timer1
			//
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2;
			this.DataGridView1.Location = new System.Drawing.Point(454, 25);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView1.Size = new System.Drawing.Size(226, 373);
			this.DataGridView1.TabIndex = 4;
			//
			//txtinfo
			//
			this.txtinfo.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtinfo.Location = new System.Drawing.Point(7, 25);
			this.txtinfo.Multiline = true;
			this.txtinfo.Name = "txtinfo";
			this.txtinfo.Size = new System.Drawing.Size(436, 107);
			this.txtinfo.TabIndex = 0;
			//
			//Label1
			//
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.Font = new System.Drawing.Font("Arial", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.Label1.Location = new System.Drawing.Point(327, 6);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(121, 16);
			this.Label1.TabIndex = 27;
			this.Label1.Text = "INFO PROMO";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//Label7
			//
			this.Label7.BackColor = System.Drawing.Color.Transparent;
			this.Label7.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label7.Font = new System.Drawing.Font("Arial", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label7.ForeColor = System.Drawing.Color.White;
			this.Label7.Location = new System.Drawing.Point(302, 135);
			this.Label7.Name = "Label7";
			this.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label7.Size = new System.Drawing.Size(146, 16);
			this.Label7.TabIndex = 28;
			this.Label7.Text = "PROGRAM MENU";
			this.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//Frame2
			//
			this.Frame2.BackColor = System.Drawing.Color.White;
			this.Frame2.Controls.Add(this._cmdMenu_8);
			this.Frame2.Controls.Add(this._cmdMenu_9);
			this.Frame2.Controls.Add(this._cmdMenu_3);
			this.Frame2.Controls.Add(this._cmdMenu_7);
			this.Frame2.Controls.Add(this._cmdMenu_6);
			this.Frame2.Controls.Add(this._cmdMenu_5);
			this.Frame2.Controls.Add(this._cmdMenu_4);
			this.Frame2.Controls.Add(this._cmdMenu_2);
			this.Frame2.Controls.Add(this._cmdMenu_1);
			this.Frame2.Controls.Add(this._cmdMenu_0);
			this.Frame2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Frame2.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(7, 154);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(436, 146);
			this.Frame2.TabIndex = 29;
			//
			//_cmdMenu_8
			//
			this._cmdMenu_8.BackColor = System.Drawing.SystemColors.Control;
			this._cmdMenu_8.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdMenu_8.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdMenu_8.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdMenu_8.Image = (System.Drawing.Image) (resources.GetObject("_cmdMenu_8.Image"));
			this._cmdMenu_8.Location = new System.Drawing.Point(346, 4);
			this._cmdMenu_8.Name = "_cmdMenu_8";
			this._cmdMenu_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdMenu_8.Size = new System.Drawing.Size(84, 67);
			this._cmdMenu_8.TabIndex = 4;
			this._cmdMenu_8.Tag = "8";
			this._cmdMenu_8.Text = "CANCEL";
			this._cmdMenu_8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdMenu_8.UseVisualStyleBackColor = false;
			//
			//_cmdMenu_9
			//
			this._cmdMenu_9.BackColor = System.Drawing.SystemColors.Control;
			this._cmdMenu_9.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdMenu_9.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdMenu_9.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdMenu_9.Image = (System.Drawing.Image) (resources.GetObject("_cmdMenu_9.Image"));
			this._cmdMenu_9.Location = new System.Drawing.Point(346, 74);
			this._cmdMenu_9.Name = "_cmdMenu_9";
			this._cmdMenu_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdMenu_9.Size = new System.Drawing.Size(84, 67);
			this._cmdMenu_9.TabIndex = 9;
			this._cmdMenu_9.Tag = "9";
			this._cmdMenu_9.Text = "EXIT";
			this._cmdMenu_9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdMenu_9.UseVisualStyleBackColor = false;
			//
			//_cmdMenu_3
			//
			this._cmdMenu_3.BackColor = System.Drawing.SystemColors.Control;
			this._cmdMenu_3.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdMenu_3.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdMenu_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdMenu_3.Image = (System.Drawing.Image) (resources.GetObject("_cmdMenu_3.Image"));
			this._cmdMenu_3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdMenu_3.Location = new System.Drawing.Point(261, 74);
			this._cmdMenu_3.Name = "_cmdMenu_3";
			this._cmdMenu_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdMenu_3.Size = new System.Drawing.Size(84, 67);
			this._cmdMenu_3.TabIndex = 8;
			this._cmdMenu_3.Tag = "3";
			this._cmdMenu_3.Text = "OPEN DRAWER";
			this._cmdMenu_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdMenu_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._cmdMenu_3.UseVisualStyleBackColor = false;
			//
			//_cmdMenu_7
			//
			this._cmdMenu_7.BackColor = System.Drawing.SystemColors.Control;
			this._cmdMenu_7.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdMenu_7.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdMenu_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdMenu_7.Image = (System.Drawing.Image) (resources.GetObject("_cmdMenu_7.Image"));
			this._cmdMenu_7.Location = new System.Drawing.Point(261, 4);
			this._cmdMenu_7.Name = "_cmdMenu_7";
			this._cmdMenu_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdMenu_7.Size = new System.Drawing.Size(84, 67);
			this._cmdMenu_7.TabIndex = 3;
			this._cmdMenu_7.Tag = "7";
			this._cmdMenu_7.Text = "RELEASE";
			this._cmdMenu_7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdMenu_7.UseVisualStyleBackColor = false;
			//
			//_cmdMenu_6
			//
			this._cmdMenu_6.BackColor = System.Drawing.SystemColors.Control;
			this._cmdMenu_6.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdMenu_6.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdMenu_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdMenu_6.Image = (System.Drawing.Image) (resources.GetObject("_cmdMenu_6.Image"));
			this._cmdMenu_6.Location = new System.Drawing.Point(176, 4);
			this._cmdMenu_6.Name = "_cmdMenu_6";
			this._cmdMenu_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdMenu_6.Size = new System.Drawing.Size(84, 67);
			this._cmdMenu_6.TabIndex = 2;
			this._cmdMenu_6.Tag = "6";
			this._cmdMenu_6.Text = "REPRINT";
			this._cmdMenu_6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdMenu_6.UseVisualStyleBackColor = false;
			//
			//_cmdMenu_5
			//
			this._cmdMenu_5.BackColor = System.Drawing.SystemColors.Control;
			this._cmdMenu_5.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdMenu_5.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdMenu_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdMenu_5.Image = (System.Drawing.Image) (resources.GetObject("_cmdMenu_5.Image"));
			this._cmdMenu_5.Location = new System.Drawing.Point(91, 4);
			this._cmdMenu_5.Name = "_cmdMenu_5";
			this._cmdMenu_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdMenu_5.Size = new System.Drawing.Size(84, 67);
			this._cmdMenu_5.TabIndex = 1;
			this._cmdMenu_5.Tag = "5";
			this._cmdMenu_5.Text = "REFUND";
			this._cmdMenu_5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdMenu_5.UseVisualStyleBackColor = false;
			//
			//_cmdMenu_4
			//
			this._cmdMenu_4.BackColor = System.Drawing.SystemColors.Control;
			this._cmdMenu_4.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdMenu_4.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdMenu_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdMenu_4.Image = (System.Drawing.Image) (resources.GetObject("_cmdMenu_4.Image"));
			this._cmdMenu_4.Location = new System.Drawing.Point(6, 4);
			this._cmdMenu_4.Name = "_cmdMenu_4";
			this._cmdMenu_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdMenu_4.Size = new System.Drawing.Size(84, 67);
			this._cmdMenu_4.TabIndex = 0;
			this._cmdMenu_4.Tag = "4";
			this._cmdMenu_4.Text = "SALES";
			this._cmdMenu_4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdMenu_4.UseVisualStyleBackColor = false;
			//
			//_cmdMenu_2
			//
			this._cmdMenu_2.BackColor = System.Drawing.SystemColors.Control;
			this._cmdMenu_2.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdMenu_2.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdMenu_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdMenu_2.Image = (System.Drawing.Image) (resources.GetObject("_cmdMenu_2.Image"));
			this._cmdMenu_2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdMenu_2.Location = new System.Drawing.Point(176, 74);
			this._cmdMenu_2.Name = "_cmdMenu_2";
			this._cmdMenu_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdMenu_2.Size = new System.Drawing.Size(84, 67);
			this._cmdMenu_2.TabIndex = 7;
			this._cmdMenu_2.Tag = "2";
			this._cmdMenu_2.Text = "CLOSE REGISTER";
			this._cmdMenu_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdMenu_2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._cmdMenu_2.UseVisualStyleBackColor = false;
			//
			//_cmdMenu_1
			//
			this._cmdMenu_1.BackColor = System.Drawing.SystemColors.Control;
			this._cmdMenu_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdMenu_1.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdMenu_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdMenu_1.Image = (System.Drawing.Image) (resources.GetObject("_cmdMenu_1.Image"));
			this._cmdMenu_1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdMenu_1.Location = new System.Drawing.Point(91, 74);
			this._cmdMenu_1.Name = "_cmdMenu_1";
			this._cmdMenu_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdMenu_1.Size = new System.Drawing.Size(84, 67);
			this._cmdMenu_1.TabIndex = 6;
			this._cmdMenu_1.Tag = "1";
			this._cmdMenu_1.Text = "CLOSE SHIFT";
			this._cmdMenu_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdMenu_1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._cmdMenu_1.UseVisualStyleBackColor = false;
			//
			//_cmdMenu_0
			//
			this._cmdMenu_0.BackColor = System.Drawing.SystemColors.Control;
			this._cmdMenu_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdMenu_0.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdMenu_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdMenu_0.Image = (System.Drawing.Image) (resources.GetObject("_cmdMenu_0.Image"));
			this._cmdMenu_0.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdMenu_0.Location = new System.Drawing.Point(6, 74);
			this._cmdMenu_0.Name = "_cmdMenu_0";
			this._cmdMenu_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdMenu_0.Size = new System.Drawing.Size(84, 67);
			this._cmdMenu_0.TabIndex = 5;
			this._cmdMenu_0.Tag = "0";
			this._cmdMenu_0.Text = "CASH OPEN";
			this._cmdMenu_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdMenu_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._cmdMenu_0.UseVisualStyleBackColor = false;
			//
			//Label8
			//
			this.Label8.BackColor = System.Drawing.Color.Transparent;
			this.Label8.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label8.Font = new System.Drawing.Font("Arial", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label8.ForeColor = System.Drawing.Color.White;
			this.Label8.Location = new System.Drawing.Point(302, 313);
			this.Label8.Name = "Label8";
			this.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label8.Size = new System.Drawing.Size(146, 16);
			this.Label8.TabIndex = 22;
			this.Label8.Text = "INFO REGISTER";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//Frame3
			//
			this.Frame3.BackColor = System.Drawing.Color.Black;
			this.Frame3.Controls.Add(this.lblline);
			this.Frame3.Controls.Add(this.lbljam);
			this.Frame3.Controls.Add(this.lbltgl);
			this.Frame3.Controls.Add(this.lblkasir);
			this.Frame3.Controls.Add(this.lblreg);
			this.Frame3.Controls.Add(this.lblbranch);
			this.Frame3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Frame3.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame3.Location = new System.Drawing.Point(7, 332);
			this.Frame3.Name = "Frame3";
			this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame3.Size = new System.Drawing.Size(436, 66);
			this.Frame3.TabIndex = 30;
			//
			//lblline
			//
			this.lblline.BackColor = System.Drawing.Color.Transparent;
			this.lblline.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblline.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblline.ForeColor = System.Drawing.Color.Yellow;
			this.lblline.Location = new System.Drawing.Point(224, 45);
			this.lblline.Name = "lblline";
			this.lblline.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblline.Size = new System.Drawing.Size(206, 21);
			this.lblline.TabIndex = 22;
			this.lblline.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//lbljam
			//
			this.lbljam.BackColor = System.Drawing.Color.Transparent;
			this.lbljam.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbljam.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lbljam.ForeColor = System.Drawing.Color.Yellow;
			this.lbljam.Location = new System.Drawing.Point(224, 25);
			this.lbljam.Name = "lbljam";
			this.lbljam.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbljam.Size = new System.Drawing.Size(206, 21);
			this.lbljam.TabIndex = 17;
			this.lbljam.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//lbltgl
			//
			this.lbltgl.BackColor = System.Drawing.Color.Transparent;
			this.lbltgl.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbltgl.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lbltgl.ForeColor = System.Drawing.Color.Yellow;
			this.lbltgl.Location = new System.Drawing.Point(224, 5);
			this.lbltgl.Name = "lbltgl";
			this.lbltgl.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbltgl.Size = new System.Drawing.Size(206, 21);
			this.lbltgl.TabIndex = 16;
			this.lbltgl.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//lblkasir
			//
			this.lblkasir.BackColor = System.Drawing.Color.Transparent;
			this.lblkasir.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblkasir.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblkasir.ForeColor = System.Drawing.Color.Yellow;
			this.lblkasir.Location = new System.Drawing.Point(10, 45);
			this.lblkasir.Name = "lblkasir";
			this.lblkasir.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblkasir.Size = new System.Drawing.Size(206, 21);
			this.lblkasir.TabIndex = 15;
			//
			//lblreg
			//
			this.lblreg.BackColor = System.Drawing.Color.Transparent;
			this.lblreg.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblreg.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblreg.ForeColor = System.Drawing.Color.Yellow;
			this.lblreg.Location = new System.Drawing.Point(10, 25);
			this.lblreg.Name = "lblreg";
			this.lblreg.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblreg.Size = new System.Drawing.Size(206, 21);
			this.lblreg.TabIndex = 14;
			//
			//lblbranch
			//
			this.lblbranch.BackColor = System.Drawing.Color.Transparent;
			this.lblbranch.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblbranch.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblbranch.ForeColor = System.Drawing.Color.Yellow;
			this.lblbranch.Location = new System.Drawing.Point(10, 5);
			this.lblbranch.Name = "lblbranch";
			this.lblbranch.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblbranch.Size = new System.Drawing.Size(206, 21);
			this.lblbranch.TabIndex = 13;
			//
			//label2
			//
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.Font = new System.Drawing.Font("Arial", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.White;
			this.Label2.Location = new System.Drawing.Point(559, 6);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(121, 16);
			this.Label2.TabIndex = 31;
			this.Label2.Text = "TRANSAKSI PENDING";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//ContextMenuStrip1
			//
			this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ToolStripMenuItem1});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.Size = new System.Drawing.Size(181, 48);
			//
			//ToolStripMenuItem1
			//
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
			this.ToolStripMenuItem1.Text = "Delete Row";
			//
			//lblMember
			//
			this.lblMember.BackColor = System.Drawing.Color.Transparent;
			this.lblMember.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblMember.Font = new System.Drawing.Font("Arial", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblMember.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.lblMember.Location = new System.Drawing.Point(4, 135);
			this.lblMember.Name = "lblMember";
			this.lblMember.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblMember.Size = new System.Drawing.Size(121, 16);
			this.lblMember.TabIndex = 33;
			this.lblMember.Text = "MEMBERSHIP";
			//
			//lblMemberTran
			//
			this.lblMemberTran.BackColor = System.Drawing.Color.Transparent;
			this.lblMemberTran.Cursor = System.Windows.Forms.Cursors.Hand;
			this.lblMemberTran.Font = new System.Drawing.Font("Arial", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblMemberTran.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.lblMemberTran.Location = new System.Drawing.Point(4, 313);
			this.lblMemberTran.Name = "lblMemberTran";
			this.lblMemberTran.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblMemberTran.Size = new System.Drawing.Size(121, 16);
			this.lblMemberTran.TabIndex = 34;
			this.lblMemberTran.Text = "MEMBER TRANS";
			//
			//frmMain
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (14.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)), System.Convert.ToInt32(System.Convert.ToByte(64)));
			this.ClientSize = new System.Drawing.Size(688, 407);
			this.ControlBox = false;
			this.Controls.Add(this.lblMemberTran);
			this.Controls.Add(this.lblMember);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Frame3);
			this.Controls.Add(this.Label8);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Label7);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.txtinfo);
			this.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximumSize = new System.Drawing.Size(704, 446);
			this.MinimumSize = new System.Drawing.Size(704, 446);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "POINT OF SALES";
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			this.Frame2.ResumeLayout(false);
			this.Frame3.ResumeLayout(false);
			this.ContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.Timer Timer1;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.TextBox txtinfo;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label Label7;
		public System.Windows.Forms.Panel Frame2;
		public Microsoft.VisualBasic.Compatibility.VB6.ButtonArray cmdMenu;
		public System.Windows.Forms.Button _cmdMenu_8;
		public System.Windows.Forms.Button _cmdMenu_9;
		public System.Windows.Forms.Button _cmdMenu_3;
		public System.Windows.Forms.Button _cmdMenu_7;
		public System.Windows.Forms.Button _cmdMenu_6;
		public System.Windows.Forms.Button _cmdMenu_5;
		public System.Windows.Forms.Button _cmdMenu_4;
		public System.Windows.Forms.Button _cmdMenu_2;
		public System.Windows.Forms.Button _cmdMenu_1;
		public System.Windows.Forms.Button _cmdMenu_0;
		public System.Windows.Forms.Label Label8;
		public System.Windows.Forms.Panel Frame3;
		public System.Windows.Forms.Label lblline;
		public System.Windows.Forms.Label lbljam;
		public System.Windows.Forms.Label lbltgl;
		public System.Windows.Forms.Label lblkasir;
		public System.Windows.Forms.Label lblreg;
		public System.Windows.Forms.Label lblbranch;
		public System.Windows.Forms.Label Label2;
		internal ContextMenuStrip ContextMenuStrip1;
		internal ToolStripMenuItem ToolStripMenuItem1;
		public Label lblMember;
		public Label lblMemberTran;
	}
	
}
