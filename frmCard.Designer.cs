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
	partial class frmCard : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmCard_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCard));
			this.CmdNav = new System.Windows.Forms.Button();
			this.CmdNav.Click += new System.EventHandler(this.CmdNav_Click);
			this.CmdOk = new System.Windows.Forms.Button();
			this.CmdOk.Click += new System.EventHandler(this.Cmdok_Click);
			this.CmdOk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmdok_KeyDown);
			this.CmdCancel = new System.Windows.Forms.Button();
			this.CmdCancel.Click += new System.EventHandler(this.Cmdcancel_Click);
			this.lblmsg = new System.Windows.Forms.Label();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			this.Frame2 = new System.Windows.Forms.GroupBox();
			this.Vpromo_id = new System.Windows.Forms.Label();
			this.txtPeriod = new System.Windows.Forms.TextBox();
			this.txtexprPoint = new System.Windows.Forms.TextBox();
			this.txtcard_opt = new System.Windows.Forms.TextBox();
			this.txtcard_opt.Enter += new System.EventHandler(this.txtcard_opt_Enter);
			this.txtcard_opt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcard_opt_KeyDown);
			this.Label9 = new System.Windows.Forms.Label();
			this.txtno_telp = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.txtpoint = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtomz = new System.Windows.Forms.TextBox();
			this.Label6 = new System.Windows.Forms.Label();
			this.txtfreq = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtcust_id = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.txtcust_name = new System.Windows.Forms.TextBox();
			this.Label3 = new System.Windows.Forms.Label();
			this.txtcard_no = new System.Windows.Forms.TextBox();
			this.txtcard_no.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcard_no_KeyDown);
			this.Label2 = new System.Windows.Forms.Label();
			this.Shape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
			this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.Frame2.SuspendLayout();
			this.SuspendLayout();
			//
			//CmdNav
			//
			this.CmdNav.BackColor = System.Drawing.SystemColors.Control;
			this.CmdNav.Cursor = System.Windows.Forms.Cursors.Default;
			this.CmdNav.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.CmdNav.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdNav.Image = (System.Drawing.Image) (resources.GetObject("CmdNav.Image"));
			this.CmdNav.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CmdNav.Location = new System.Drawing.Point(311, 289);
			this.CmdNav.Name = "CmdNav";
			this.CmdNav.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CmdNav.Size = new System.Drawing.Size(76, 48);
			this.CmdNav.TabIndex = 17;
			this.CmdNav.Text = "&NUM";
			this.CmdNav.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CmdNav.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.CmdNav.UseVisualStyleBackColor = false;
			//
			//CmdOk
			//
			this.CmdOk.BackColor = System.Drawing.SystemColors.Control;
			this.CmdOk.Cursor = System.Windows.Forms.Cursors.Default;
			this.CmdOk.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.CmdOk.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdOk.Image = (System.Drawing.Image) (resources.GetObject("CmdOk.Image"));
			this.CmdOk.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CmdOk.Location = new System.Drawing.Point(147, 289);
			this.CmdOk.Name = "CmdOk";
			this.CmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CmdOk.Size = new System.Drawing.Size(76, 48);
			this.CmdOk.TabIndex = 15;
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
			this.CmdCancel.Location = new System.Drawing.Point(229, 289);
			this.CmdCancel.Name = "CmdCancel";
			this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CmdCancel.Size = new System.Drawing.Size(76, 48);
			this.CmdCancel.TabIndex = 16;
			this.CmdCancel.Text = "CANCEL";
			this.CmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.CmdCancel.UseVisualStyleBackColor = false;
			//
			//lblmsg
			//
			this.lblmsg.BackColor = System.Drawing.Color.Red;
			this.lblmsg.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblmsg.Font = new System.Drawing.Font("Arial", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblmsg.ForeColor = System.Drawing.Color.Yellow;
			this.lblmsg.Location = new System.Drawing.Point(-6, 2);
			this.lblmsg.Name = "lblmsg";
			this.lblmsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblmsg.Size = new System.Drawing.Size(416, 31);
			this.lblmsg.TabIndex = 18;
			this.lblmsg.Text = "SCAN BARCODE KARTU";
			this.lblmsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			//
			//Timer1
			//
			this.Timer1.Enabled = true;
			this.Timer1.Interval = 3000;
			//
			//Frame2
			//
			this.Frame2.BackColor = System.Drawing.Color.White;
			this.Frame2.Controls.Add(this.Vpromo_id);
			this.Frame2.Controls.Add(this.txtPeriod);
			this.Frame2.Controls.Add(this.txtexprPoint);
			this.Frame2.Controls.Add(this.txtcard_opt);
			this.Frame2.Controls.Add(this.Label9);
			this.Frame2.Controls.Add(this.txtno_telp);
			this.Frame2.Controls.Add(this.Label8);
			this.Frame2.Controls.Add(this.txtpoint);
			this.Frame2.Controls.Add(this.Label7);
			this.Frame2.Controls.Add(this.txtomz);
			this.Frame2.Controls.Add(this.Label6);
			this.Frame2.Controls.Add(this.txtfreq);
			this.Frame2.Controls.Add(this.Label5);
			this.Frame2.Controls.Add(this.txtcust_id);
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
			this.Frame2.Size = new System.Drawing.Size(395, 248);
			this.Frame2.TabIndex = 20;
			this.Frame2.TabStop = false;
			//
			//Vpromo_id
			//
			this.Vpromo_id.BackColor = System.Drawing.Color.Transparent;
			this.Vpromo_id.Cursor = System.Windows.Forms.Cursors.Default;
			this.Vpromo_id.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Vpromo_id.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Vpromo_id.Location = new System.Drawing.Point(288, 176);
			this.Vpromo_id.Name = "Vpromo_id";
			this.Vpromo_id.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Vpromo_id.Size = new System.Drawing.Size(101, 26);
			this.Vpromo_id.TabIndex = 44;
			this.Vpromo_id.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//txtPeriod
			//
			this.txtPeriod.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtPeriod.Location = new System.Drawing.Point(234, 208);
			this.txtPeriod.Name = "txtPeriod";
			this.txtPeriod.Size = new System.Drawing.Size(155, 25);
			this.txtPeriod.TabIndex = 43;
			//
			//txtexprPoint
			//
			this.txtexprPoint.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtexprPoint.Location = new System.Drawing.Point(144, 208);
			this.txtexprPoint.Name = "txtexprPoint";
			this.txtexprPoint.Size = new System.Drawing.Size(84, 25);
			this.txtexprPoint.TabIndex = 42;
			//
			//txtcard_opt
			//
			this.txtcard_opt.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtcard_opt.Location = new System.Drawing.Point(144, 176);
			this.txtcard_opt.Name = "txtcard_opt";
			this.txtcard_opt.Size = new System.Drawing.Size(127, 25);
			this.txtcard_opt.TabIndex = 41;
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label9.Location = new System.Drawing.Point(207, 148);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(64, 16);
			this.Label9.TabIndex = 40;
			this.Label9.Text = "NO TELP";
			//
			//txtno_telp
			//
			this.txtno_telp.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtno_telp.Location = new System.Drawing.Point(277, 144);
			this.txtno_telp.Name = "txtno_telp";
			this.txtno_telp.Size = new System.Drawing.Size(112, 25);
			this.txtno_telp.TabIndex = 39;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label8.Location = new System.Drawing.Point(14, 212);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(108, 16);
			this.Label8.TabIndex = 38;
			this.Label8.Text = "EXPIRED POINT";
			//
			//txtpoint
			//
			this.txtpoint.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtpoint.Location = new System.Drawing.Point(144, 144);
			this.txtpoint.Name = "txtpoint";
			this.txtpoint.Size = new System.Drawing.Size(60, 25);
			this.txtpoint.TabIndex = 37;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label7.Location = new System.Drawing.Point(14, 180);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(105, 16);
			this.Label7.TabIndex = 36;
			this.Label7.Text = "KARTU PROMO";
			//
			//txtomz
			//
			this.txtomz.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtomz.Location = new System.Drawing.Point(210, 112);
			this.txtomz.Name = "txtomz";
			this.txtomz.Size = new System.Drawing.Size(179, 25);
			this.txtomz.TabIndex = 35;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label6.Location = new System.Drawing.Point(14, 148);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(105, 16);
			this.Label6.TabIndex = 34;
			this.Label6.Text = "JUMLAH POINT";
			//
			//txtfreq
			//
			this.txtfreq.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtfreq.Location = new System.Drawing.Point(144, 112);
			this.txtfreq.Name = "txtfreq";
			this.txtfreq.Size = new System.Drawing.Size(60, 25);
			this.txtfreq.TabIndex = 33;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.Location = new System.Drawing.Point(14, 116);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(109, 16);
			this.Label5.TabIndex = 32;
			this.Label5.Text = "JUMLAH TRANS";
			//
			//txtcust_id
			//
			this.txtcust_id.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtcust_id.Location = new System.Drawing.Point(144, 80);
			this.txtcust_id.Name = "txtcust_id";
			this.txtcust_id.Size = new System.Drawing.Size(245, 25);
			this.txtcust_id.TabIndex = 31;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(14, 84);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(121, 16);
			this.Label4.TabIndex = 30;
			this.Label4.Text = "NO ID CUSTOMER";
			//
			//txtcust_name
			//
			this.txtcust_name.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtcust_name.Location = new System.Drawing.Point(144, 48);
			this.txtcust_name.Name = "txtcust_name";
			this.txtcust_name.Size = new System.Drawing.Size(245, 25);
			this.txtcust_name.TabIndex = 29;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(14, 52);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(123, 16);
			this.Label3.TabIndex = 28;
			this.Label3.Text = "NAMA CUSTOMER";
			//
			//txtcard_no
			//
			this.txtcard_no.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtcard_no.Location = new System.Drawing.Point(144, 16);
			this.txtcard_no.Name = "txtcard_no";
			this.txtcard_no.Size = new System.Drawing.Size(113, 25);
			this.txtcard_no.TabIndex = 27;
			//
			//label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(14, 20);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(124, 16);
			this.Label2.TabIndex = 26;
			this.Label2.Text = "MYSTAR CARD NO";
			//
			//Shape1
			//
			this.Shape1.BackColor = System.Drawing.Color.White;
			this.Shape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
			this.Shape1.BorderColor = System.Drawing.SystemColors.WindowText;
			this.Shape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
			this.Shape1.FillColor = System.Drawing.Color.Black;
			this.Shape1.Location = new System.Drawing.Point(10, 287);
			this.Shape1.Name = "Shape1";
			this.Shape1.Size = new System.Drawing.Size(121, 51);
			//
			//ShapeContainer1
			//
			this.ShapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.ShapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.ShapeContainer1.Name = "ShapeContainer1";
			this.ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {this.Shape1});
			this.ShapeContainer1.Size = new System.Drawing.Size(406, 348);
			this.ShapeContainer1.TabIndex = 21;
			this.ShapeContainer1.TabStop = false;
			//
			//frmCard
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (14.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(406, 348);
			this.ControlBox = false;
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.lblmsg);
			this.Controls.Add(this.CmdNav);
			this.Controls.Add(this.CmdOk);
			this.Controls.Add(this.CmdCancel);
			this.Controls.Add(this.ShapeContainer1);
			this.Font = new System.Drawing.Font("Arial", (float) (8.0F));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximumSize = new System.Drawing.Size(422, 387);
			this.MinimumSize = new System.Drawing.Size(422, 387);
			this.Name = "frmCard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MYSTAR CARD";
			this.Frame2.ResumeLayout(false);
			this.Frame2.PerformLayout();
			this.ResumeLayout(false);
			
		}
		public System.Windows.Forms.Button CmdNav;
		public System.Windows.Forms.Button CmdOk;
		public System.Windows.Forms.Button CmdCancel;
		public System.Windows.Forms.Label lblmsg;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.Timer Timer1;
		public System.Windows.Forms.GroupBox Frame2;
		internal System.Windows.Forms.TextBox txtno_telp;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox txtpoint;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox txtomz;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox txtfreq;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtcust_id;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox txtcust_name;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox txtcard_no;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtPeriod;
		internal System.Windows.Forms.TextBox txtexprPoint;
		internal System.Windows.Forms.TextBox txtcard_opt;
		internal System.Windows.Forms.Label Label9;
		public Microsoft.VisualBasic.PowerPacks.RectangleShape Shape1;
		internal Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
		public System.Windows.Forms.Label Vpromo_id;
	}
	
}
