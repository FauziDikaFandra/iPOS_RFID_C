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
		public partial class frmSales : System.Windows.Forms.Form
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
			base.Activated += new System.EventHandler(frmSales_Activated);
			base.Load += new System.EventHandler(frmSales_Load);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmSales_FormClosed);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSales));
			this._cmdsales_3 = new System.Windows.Forms.Button();
			this._cmdsales_1 = new System.Windows.Forms.Button();
			this._cmdsales_2 = new System.Windows.Forms.Button();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Frame1 = new System.Windows.Forms.Panel();
			this.lblkode = new System.Windows.Forms.Label();
			this._CmdNav_0 = new System.Windows.Forms.Button();
			this.txtkode = new System.Windows.Forms.TextBox();
			this.txtkode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtkode_KeyDown);
			this._CmdNav_3 = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblgrand_total = new System.Windows.Forms.Label();
			this._cmdsales_0 = new System.Windows.Forms.Button();
			this.Frame3 = new System.Windows.Forms.GroupBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.txtcust_name = new System.Windows.Forms.TextBox();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtcard_no = new System.Windows.Forms.TextBox();
			this._cmdsales_8 = new System.Windows.Forms.Button();
			this.Frame2 = new System.Windows.Forms.Panel();
			this._CmdNav_2 = new System.Windows.Forms.Button();
			this._CmdNav_1 = new System.Windows.Forms.Button();
			this._cmdsales_7 = new System.Windows.Forms.Button();
			this._cmdsales_6 = new System.Windows.Forms.Button();
			this._cmdsales_5 = new System.Windows.Forms.Button();
			this._cmdsales_4 = new System.Windows.Forms.Button();
			this.CmdNav = new Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(this.components);
			this.CmdNav.Click += new System.EventHandler(this.CmdNav_Click);
			this._cmdsales_9 = new System.Windows.Forms.Button();
			this.lblqty = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.vpromo = new System.Windows.Forms.Label();
			this.lblno = new System.Windows.Forms.Label();
			this.vgtotal = new System.Windows.Forms.Label();
			this.vtotal = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.vdiscrp2 = new System.Windows.Forms.Label();
			this.vdiscrp1 = new System.Windows.Forms.Label();
			this.vdisc2 = new System.Windows.Forms.Label();
			this.vqty = new System.Windows.Forms.Label();
			this.vdisc1 = new System.Windows.Forms.Label();
			this.vflag = new System.Windows.Forms.Label();
			this.vno_trans = new System.Windows.Forms.Label();
			this.vno_trans.TextChanged += new System.EventHandler(this.vno_trans_TextChanged);
			this.vharga = new System.Windows.Forms.Label();
			this.vdesc = new System.Windows.Forms.Label();
			this.vspg = new System.Windows.Forms.Label();
			this.vplu = new System.Windows.Forms.Label();
			this.cmdsales = new Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(this.components);
			this.cmdsales.Click += new System.EventHandler(this.cmdsales_Click);
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
			this.txtcust_id = new System.Windows.Forms.TextBox();
			this.vrfid = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			this.RfidScan1 = new System.Windows.Forms.Button();
			this.RfidScan1.Click += new System.EventHandler(this.Button2_Click);
			this.RfidScan2 = new System.Windows.Forms.Button();
			this.RfidScan2.Click += new System.EventHandler(this.RfidScan2_Click);
			this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
			this.BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
			this.Frame1.SuspendLayout();
			this.Frame3.SuspendLayout();
			this.Frame2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.CmdNav).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cmdsales).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			this.SuspendLayout();
			//
			//_cmdsales_3
			//
			this._cmdsales_3.BackColor = System.Drawing.SystemColors.Control;
			this._cmdsales_3.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdsales_3.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdsales_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdsales_3.Image = (System.Drawing.Image) (resources.GetObject("_cmdsales_3.Image"));
			this.cmdsales.SetIndex(this._cmdsales_3, System.Convert.ToInt16(3));
			this._cmdsales_3.Location = new System.Drawing.Point(221, 2);
			this._cmdsales_3.Name = "_cmdsales_3";
			this._cmdsales_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdsales_3.Size = new System.Drawing.Size(70, 62);
			this._cmdsales_3.TabIndex = 5;
			this._cmdsales_3.Text = "LINE VOID";
			this._cmdsales_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdsales_3.UseVisualStyleBackColor = false;
			//
			//_cmdsales_1
			//
			this._cmdsales_1.BackColor = System.Drawing.SystemColors.Control;
			this._cmdsales_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdsales_1.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdsales_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdsales_1.Image = (System.Drawing.Image) (resources.GetObject("_cmdsales_1.Image"));
			this.cmdsales.SetIndex(this._cmdsales_1, System.Convert.ToInt16(1));
			this._cmdsales_1.Location = new System.Drawing.Point(75, 2);
			this._cmdsales_1.Name = "_cmdsales_1";
			this._cmdsales_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdsales_1.Size = new System.Drawing.Size(70, 62);
			this._cmdsales_1.TabIndex = 3;
			this._cmdsales_1.Text = "HOLD";
			this._cmdsales_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdsales_1.UseVisualStyleBackColor = false;
			//
			//_cmdsales_2
			//
			this._cmdsales_2.BackColor = System.Drawing.SystemColors.Control;
			this._cmdsales_2.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdsales_2.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdsales_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdsales_2.Image = (System.Drawing.Image) (resources.GetObject("_cmdsales_2.Image"));
			this.cmdsales.SetIndex(this._cmdsales_2, System.Convert.ToInt16(2));
			this._cmdsales_2.Location = new System.Drawing.Point(148, 2);
			this._cmdsales_2.Name = "_cmdsales_2";
			this._cmdsales_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdsales_2.Size = new System.Drawing.Size(70, 62);
			this._cmdsales_2.TabIndex = 4;
			this._cmdsales_2.Text = "DISCOUNT";
			this._cmdsales_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdsales_2.UseVisualStyleBackColor = false;
			//
			//Frame1
			//
			this.Frame1.BackColor = System.Drawing.Color.Black;
			this.Frame1.Controls.Add(this.lblkode);
			this.Frame1.Controls.Add(this._CmdNav_0);
			this.Frame1.Controls.Add(this.txtkode);
			this.Frame1.Controls.Add(this._CmdNav_3);
			this.Frame1.Controls.Add(this.Label1);
			this.Frame1.Controls.Add(this.lblgrand_total);
			this.Frame1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Frame1.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(4, 392);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(731, 45);
			this.Frame1.TabIndex = 62;
			//
			//lblkode
			//
			this.lblkode.AutoSize = true;
			this.lblkode.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblkode.ForeColor = System.Drawing.Color.Yellow;
			this.lblkode.Location = new System.Drawing.Point(6, 15);
			this.lblkode.Name = "lblkode";
			this.lblkode.Size = new System.Drawing.Size(34, 16);
			this.lblkode.TabIndex = 70;
			this.lblkode.Text = "PLU";
			//
			//_CmdNav_0
			//
			this._CmdNav_0.BackColor = System.Drawing.SystemColors.Control;
			this._CmdNav_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._CmdNav_0.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._CmdNav_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._CmdNav_0.Image = (System.Drawing.Image) (resources.GetObject("_CmdNav_0.Image"));
			this._CmdNav_0.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CmdNav.SetIndex(this._CmdNav_0, System.Convert.ToInt16(0));
			this._CmdNav_0.Location = new System.Drawing.Point(225, 0);
			this._CmdNav_0.Name = "_CmdNav_0";
			this._CmdNav_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._CmdNav_0.Size = new System.Drawing.Size(66, 43);
			this._CmdNav_0.TabIndex = 45;
			this._CmdNav_0.Text = "ENTER";
			this._CmdNav_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._CmdNav_0.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._CmdNav_0.UseVisualStyleBackColor = false;
			//
			//txtkode
			//
			this.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtkode.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtkode.Location = new System.Drawing.Point(61, 11);
			this.txtkode.Name = "txtkode";
			this.txtkode.Size = new System.Drawing.Size(154, 25);
			this.txtkode.TabIndex = 69;
			//
			//_CmdNav_3
			//
			this._CmdNav_3.BackColor = System.Drawing.SystemColors.Control;
			this._CmdNav_3.Cursor = System.Windows.Forms.Cursors.Default;
			this._CmdNav_3.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._CmdNav_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this._CmdNav_3.Image = (System.Drawing.Image) (resources.GetObject("_CmdNav_3.Image"));
			this._CmdNav_3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CmdNav.SetIndex(this._CmdNav_3, System.Convert.ToInt16(3));
			this._CmdNav_3.Location = new System.Drawing.Point(295, 0);
			this._CmdNav_3.Name = "_CmdNav_3";
			this._CmdNav_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._CmdNav_3.Size = new System.Drawing.Size(66, 43);
			this._CmdNav_3.TabIndex = 40;
			this._CmdNav_3.Text = "&NUM";
			this._CmdNav_3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._CmdNav_3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._CmdNav_3.UseVisualStyleBackColor = false;
			//
			//Label1
			//
			this.Label1.BackColor = System.Drawing.Color.Black;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.Font = new System.Drawing.Font("Arial", (float) (20.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.Yellow;
			this.Label1.Location = new System.Drawing.Point(365, 7);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(161, 36);
			this.Label1.TabIndex = 35;
			this.Label1.Text = "TOTAL : Rp";
			//
			//lblgrand_total
			//
			this.lblgrand_total.BackColor = System.Drawing.Color.Black;
			this.lblgrand_total.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblgrand_total.Font = new System.Drawing.Font("Arial", (float) (24.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblgrand_total.ForeColor = System.Drawing.Color.Yellow;
			this.lblgrand_total.Location = new System.Drawing.Point(470, 2);
			this.lblgrand_total.Name = "lblgrand_total";
			this.lblgrand_total.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblgrand_total.Size = new System.Drawing.Size(258, 41);
			this.lblgrand_total.TabIndex = 34;
			this.lblgrand_total.Text = "0";
			this.lblgrand_total.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//_cmdsales_0
			//
			this._cmdsales_0.BackColor = System.Drawing.SystemColors.Control;
			this._cmdsales_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdsales_0.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdsales_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdsales_0.Image = (System.Drawing.Image) (resources.GetObject("_cmdsales_0.Image"));
			this.cmdsales.SetIndex(this._cmdsales_0, System.Convert.ToInt16(0));
			this._cmdsales_0.Location = new System.Drawing.Point(3, 2);
			this._cmdsales_0.Name = "_cmdsales_0";
			this._cmdsales_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdsales_0.Size = new System.Drawing.Size(70, 62);
			this._cmdsales_0.TabIndex = 2;
			this._cmdsales_0.Text = "PAYMENT";
			this._cmdsales_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdsales_0.UseVisualStyleBackColor = false;
			//
			//Frame3
			//
			this.Frame3.BackColor = System.Drawing.Color.White;
			this.Frame3.Controls.Add(this.Label8);
			this.Frame3.Controls.Add(this.txtcust_name);
			this.Frame3.Controls.Add(this.Label7);
			this.Frame3.Controls.Add(this.txtcard_no);
			this.Frame3.Controls.Add(this._cmdsales_8);
			this.Frame3.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame3.Location = new System.Drawing.Point(4, 2);
			this.Frame3.Name = "Frame3";
			this.Frame3.Padding = new System.Windows.Forms.Padding(0);
			this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame3.Size = new System.Drawing.Size(406, 86);
			this.Frame3.TabIndex = 44;
			this.Frame3.TabStop = false;
			this.Frame3.Text = "CUSTOMER ";
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.BackColor = System.Drawing.Color.White;
			this.Label8.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label8.ForeColor = System.Drawing.Color.Black;
			this.Label8.Location = new System.Drawing.Point(8, 56);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(47, 15);
			this.Label8.TabIndex = 36;
			this.Label8.Text = "NAMA  ";
			//
			//txtcust_name
			//
			this.txtcust_name.Enabled = false;
			this.txtcust_name.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtcust_name.Location = new System.Drawing.Point(88, 52);
			this.txtcust_name.Name = "txtcust_name";
			this.txtcust_name.Size = new System.Drawing.Size(230, 22);
			this.txtcust_name.TabIndex = 35;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.BackColor = System.Drawing.Color.White;
			this.Label7.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label7.ForeColor = System.Drawing.Color.Black;
			this.Label7.Location = new System.Drawing.Point(8, 24);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(65, 15);
			this.Label7.TabIndex = 34;
			this.Label7.Text = "CARD NO  ";
			//
			//txtcard_no
			//
			this.txtcard_no.Enabled = false;
			this.txtcard_no.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtcard_no.Location = new System.Drawing.Point(88, 21);
			this.txtcard_no.Name = "txtcard_no";
			this.txtcard_no.Size = new System.Drawing.Size(108, 22);
			this.txtcard_no.TabIndex = 33;
			//
			//_cmdsales_8
			//
			this._cmdsales_8.BackColor = System.Drawing.SystemColors.Control;
			this._cmdsales_8.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdsales_8.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdsales_8.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdsales_8.Image = (System.Drawing.Image) (resources.GetObject("_cmdsales_8.Image"));
			this._cmdsales_8.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdsales.SetIndex(this._cmdsales_8, System.Convert.ToInt16(8));
			this._cmdsales_8.Location = new System.Drawing.Point(328, 21);
			this._cmdsales_8.Name = "_cmdsales_8";
			this._cmdsales_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdsales_8.Size = new System.Drawing.Size(68, 56);
			this._cmdsales_8.TabIndex = 32;
			this._cmdsales_8.Text = "MEMBER CARD";
			this._cmdsales_8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdsales_8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._cmdsales_8.UseVisualStyleBackColor = false;
			//
			//Frame2
			//
			this.Frame2.BackColor = System.Drawing.Color.White;
			this.Frame2.Controls.Add(this._CmdNav_2);
			this.Frame2.Controls.Add(this._CmdNav_1);
			this.Frame2.Controls.Add(this._cmdsales_7);
			this.Frame2.Controls.Add(this._cmdsales_6);
			this.Frame2.Controls.Add(this._cmdsales_5);
			this.Frame2.Controls.Add(this._cmdsales_4);
			this.Frame2.Controls.Add(this._cmdsales_3);
			this.Frame2.Controls.Add(this._cmdsales_2);
			this.Frame2.Controls.Add(this._cmdsales_1);
			this.Frame2.Controls.Add(this._cmdsales_0);
			this.Frame2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Frame2.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(4, 442);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(728, 66);
			this.Frame2.TabIndex = 43;
			//
			//_CmdNav_2
			//
			this._CmdNav_2.BackColor = System.Drawing.SystemColors.Control;
			this._CmdNav_2.Cursor = System.Windows.Forms.Cursors.Default;
			this._CmdNav_2.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._CmdNav_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._CmdNav_2.Image = (System.Drawing.Image) (resources.GetObject("_CmdNav_2.Image"));
			this.CmdNav.SetIndex(this._CmdNav_2, System.Convert.ToInt16(2));
			this._CmdNav_2.Location = new System.Drawing.Point(583, 2);
			this._CmdNav_2.Name = "_CmdNav_2";
			this._CmdNav_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._CmdNav_2.Size = new System.Drawing.Size(70, 62);
			this._CmdNav_2.TabIndex = 44;
			this._CmdNav_2.TabStop = false;
			this._CmdNav_2.Text = "DOWN";
			this._CmdNav_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._CmdNav_2.UseVisualStyleBackColor = false;
			//
			//_CmdNav_1
			//
			this._CmdNav_1.BackColor = System.Drawing.SystemColors.Control;
			this._CmdNav_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._CmdNav_1.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._CmdNav_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._CmdNav_1.Image = (System.Drawing.Image) (resources.GetObject("_CmdNav_1.Image"));
			this.CmdNav.SetIndex(this._CmdNav_1, System.Convert.ToInt16(1));
			this._CmdNav_1.Location = new System.Drawing.Point(511, 2);
			this._CmdNav_1.Name = "_CmdNav_1";
			this._CmdNav_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._CmdNav_1.Size = new System.Drawing.Size(70, 62);
			this._CmdNav_1.TabIndex = 43;
			this._CmdNav_1.TabStop = false;
			this._CmdNav_1.Text = "UP";
			this._CmdNav_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._CmdNav_1.UseVisualStyleBackColor = false;
			//
			//_cmdsales_7
			//
			this._cmdsales_7.BackColor = System.Drawing.SystemColors.Control;
			this._cmdsales_7.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdsales_7.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdsales_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdsales_7.Image = (System.Drawing.Image) (resources.GetObject("_cmdsales_7.Image"));
			this.cmdsales.SetIndex(this._cmdsales_7, System.Convert.ToInt16(7));
			this._cmdsales_7.Location = new System.Drawing.Point(655, 2);
			this._cmdsales_7.Name = "_cmdsales_7";
			this._cmdsales_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdsales_7.Size = new System.Drawing.Size(70, 62);
			this._cmdsales_7.TabIndex = 9;
			this._cmdsales_7.Text = "CLOSE";
			this._cmdsales_7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdsales_7.UseVisualStyleBackColor = false;
			//
			//_cmdsales_6
			//
			this._cmdsales_6.BackColor = System.Drawing.SystemColors.Control;
			this._cmdsales_6.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdsales_6.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdsales_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdsales_6.Image = (System.Drawing.Image) (resources.GetObject("_cmdsales_6.Image"));
			this._cmdsales_6.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdsales.SetIndex(this._cmdsales_6, System.Convert.ToInt16(6));
			this._cmdsales_6.Location = new System.Drawing.Point(439, 2);
			this._cmdsales_6.Name = "_cmdsales_6";
			this._cmdsales_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdsales_6.Size = new System.Drawing.Size(70, 62);
			this._cmdsales_6.TabIndex = 8;
			this._cmdsales_6.Text = "SHOPPING BAG";
			this._cmdsales_6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdsales_6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._cmdsales_6.UseVisualStyleBackColor = false;
			//
			//_cmdsales_5
			//
			this._cmdsales_5.BackColor = System.Drawing.SystemColors.Control;
			this._cmdsales_5.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdsales_5.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Bold);
			this._cmdsales_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdsales_5.Image = (System.Drawing.Image) (resources.GetObject("_cmdsales_5.Image"));
			this._cmdsales_5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdsales.SetIndex(this._cmdsales_5, System.Convert.ToInt16(5));
			this._cmdsales_5.Location = new System.Drawing.Point(367, 2);
			this._cmdsales_5.Name = "_cmdsales_5";
			this._cmdsales_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdsales_5.Size = new System.Drawing.Size(70, 62);
			this._cmdsales_5.TabIndex = 7;
			this._cmdsales_5.Text = "VALIDATE ARTICLE";
			this._cmdsales_5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdsales_5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._cmdsales_5.UseVisualStyleBackColor = false;
			//
			//_cmdsales_4
			//
			this._cmdsales_4.BackColor = System.Drawing.SystemColors.Control;
			this._cmdsales_4.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdsales_4.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdsales_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdsales_4.Image = (System.Drawing.Image) (resources.GetObject("_cmdsales_4.Image"));
			this.cmdsales.SetIndex(this._cmdsales_4, System.Convert.ToInt16(4));
			this._cmdsales_4.Location = new System.Drawing.Point(294, 2);
			this._cmdsales_4.Name = "_cmdsales_4";
			this._cmdsales_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdsales_4.Size = new System.Drawing.Size(70, 62);
			this._cmdsales_4.TabIndex = 6;
			this._cmdsales_4.Text = "VIEW";
			this._cmdsales_4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdsales_4.UseVisualStyleBackColor = false;
			//
			//CmdNav
			//
			//
			//_cmdsales_9
			//
			this._cmdsales_9.BackColor = System.Drawing.SystemColors.Control;
			this._cmdsales_9.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdsales_9.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdsales_9.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdsales_9.Image = (System.Drawing.Image) (resources.GetObject("_cmdsales_9.Image"));
			this._cmdsales_9.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdsales.SetIndex(this._cmdsales_9, System.Convert.ToInt16(9));
			this._cmdsales_9.Location = new System.Drawing.Point(427, 23);
			this._cmdsales_9.Name = "_cmdsales_9";
			this._cmdsales_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdsales_9.Size = new System.Drawing.Size(68, 56);
			this._cmdsales_9.TabIndex = 63;
			this._cmdsales_9.Text = "CEK PROMO";
			this._cmdsales_9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdsales_9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._cmdsales_9.UseVisualStyleBackColor = false;
			//
			//lblqty
			//
			this.lblqty.BackColor = System.Drawing.Color.Transparent;
			this.lblqty.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblqty.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblqty.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblqty.Location = new System.Drawing.Point(671, 63);
			this.lblqty.Name = "lblqty";
			this.lblqty.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblqty.Size = new System.Drawing.Size(36, 21);
			this.lblqty.TabIndex = 66;
			this.lblqty.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//label2
			//
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(591, 63);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(86, 16);
			this.Label2.TabIndex = 67;
			this.Label2.Text = "Total QTY :";
			//
			//vpromo
			//
			this.vpromo.BackColor = System.Drawing.SystemColors.Control;
			this.vpromo.Cursor = System.Windows.Forms.Cursors.Default;
			this.vpromo.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vpromo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vpromo.Location = new System.Drawing.Point(354, 277);
			this.vpromo.Name = "vpromo";
			this.vpromo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vpromo.Size = new System.Drawing.Size(46, 21);
			this.vpromo.TabIndex = 65;
			this.vpromo.Text = "promo";
			//
			//lblno
			//
			this.lblno.BackColor = System.Drawing.Color.Transparent;
			this.lblno.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblno.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblno.ForeColor = System.Drawing.SystemColors.ControlText;
			this.lblno.Location = new System.Drawing.Point(592, 2);
			this.lblno.Name = "lblno";
			this.lblno.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblno.Size = new System.Drawing.Size(131, 21);
			this.lblno.TabIndex = 64;
			//
			//vgtotal
			//
			this.vgtotal.BackColor = System.Drawing.SystemColors.Control;
			this.vgtotal.Cursor = System.Windows.Forms.Cursors.Default;
			this.vgtotal.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vgtotal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vgtotal.Location = new System.Drawing.Point(424, 277);
			this.vgtotal.Name = "vgtotal";
			this.vgtotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vgtotal.Size = new System.Drawing.Size(46, 21);
			this.vgtotal.TabIndex = 61;
			this.vgtotal.Text = "gtotal";
			//
			//vtotal
			//
			this.vtotal.BackColor = System.Drawing.SystemColors.Control;
			this.vtotal.Cursor = System.Windows.Forms.Cursors.Default;
			this.vtotal.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vtotal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vtotal.Location = new System.Drawing.Point(254, 277);
			this.vtotal.Name = "vtotal";
			this.vtotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vtotal.Size = new System.Drawing.Size(46, 21);
			this.vtotal.TabIndex = 60;
			this.vtotal.Text = "total";
			//
			//Label6
			//
			this.Label6.BackColor = System.Drawing.Color.Transparent;
			this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label6.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(706, 43);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(21, 16);
			this.Label6.TabIndex = 59;
			this.Label6.Text = "%";
			//
			//Label5
			//
			this.Label5.BackColor = System.Drawing.Color.Transparent;
			this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label5.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label5.Location = new System.Drawing.Point(706, 23);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(21, 16);
			this.Label5.TabIndex = 58;
			this.Label5.Text = "%";
			//
			//Label4
			//
			this.Label4.BackColor = System.Drawing.Color.Transparent;
			this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label4.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label4.Location = new System.Drawing.Point(591, 43);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(86, 16);
			this.Label4.TabIndex = 57;
			this.Label4.Text = "Extra Disc :";
			//
			//Label3
			//
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label3.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label3.Location = new System.Drawing.Point(591, 23);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(86, 16);
			this.Label3.TabIndex = 56;
			this.Label3.Text = "Discount :";
			//
			//vdiscrp2
			//
			this.vdiscrp2.BackColor = System.Drawing.SystemColors.Control;
			this.vdiscrp2.Cursor = System.Windows.Forms.Cursors.Default;
			this.vdiscrp2.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vdiscrp2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vdiscrp2.Location = new System.Drawing.Point(204, 277);
			this.vdiscrp2.Name = "vdiscrp2";
			this.vdiscrp2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vdiscrp2.Size = new System.Drawing.Size(46, 21);
			this.vdiscrp2.TabIndex = 55;
			this.vdiscrp2.Text = "Disc2Rp";
			//
			//vdiscrp1
			//
			this.vdiscrp1.BackColor = System.Drawing.SystemColors.Control;
			this.vdiscrp1.Cursor = System.Windows.Forms.Cursors.Default;
			this.vdiscrp1.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vdiscrp1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vdiscrp1.Location = new System.Drawing.Point(154, 277);
			this.vdiscrp1.Name = "vdiscrp1";
			this.vdiscrp1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vdiscrp1.Size = new System.Drawing.Size(46, 21);
			this.vdiscrp1.TabIndex = 54;
			this.vdiscrp1.Text = "Disc1Rp";
			//
			//vdisc2
			//
			this.vdisc2.BackColor = System.Drawing.Color.Transparent;
			this.vdisc2.Cursor = System.Windows.Forms.Cursors.Default;
			this.vdisc2.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vdisc2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vdisc2.Location = new System.Drawing.Point(671, 43);
			this.vdisc2.Name = "vdisc2";
			this.vdisc2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vdisc2.Size = new System.Drawing.Size(36, 21);
			this.vdisc2.TabIndex = 53;
			this.vdisc2.Text = "0";
			this.vdisc2.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//vqty
			//
			this.vqty.BackColor = System.Drawing.SystemColors.Control;
			this.vqty.Cursor = System.Windows.Forms.Cursors.Default;
			this.vqty.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vqty.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vqty.Location = new System.Drawing.Point(9, 277);
			this.vqty.Name = "vqty";
			this.vqty.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vqty.Size = new System.Drawing.Size(46, 21);
			this.vqty.TabIndex = 52;
			this.vqty.Text = "qty";
			//
			//vdisc1
			//
			this.vdisc1.BackColor = System.Drawing.Color.Transparent;
			this.vdisc1.Cursor = System.Windows.Forms.Cursors.Default;
			this.vdisc1.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vdisc1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vdisc1.Location = new System.Drawing.Point(671, 23);
			this.vdisc1.Name = "vdisc1";
			this.vdisc1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vdisc1.Size = new System.Drawing.Size(36, 21);
			this.vdisc1.TabIndex = 51;
			this.vdisc1.Text = "0";
			this.vdisc1.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//vflag
			//
			this.vflag.BackColor = System.Drawing.SystemColors.Control;
			this.vflag.Cursor = System.Windows.Forms.Cursors.Default;
			this.vflag.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vflag.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vflag.Location = new System.Drawing.Point(304, 277);
			this.vflag.Name = "vflag";
			this.vflag.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vflag.Size = new System.Drawing.Size(46, 21);
			this.vflag.TabIndex = 50;
			this.vflag.Text = "flag";
			//
			//vno_trans
			//
			this.vno_trans.BackColor = System.Drawing.SystemColors.Control;
			this.vno_trans.Cursor = System.Windows.Forms.Cursors.Default;
			this.vno_trans.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vno_trans.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vno_trans.Location = new System.Drawing.Point(9, 252);
			this.vno_trans.Name = "vno_trans";
			this.vno_trans.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vno_trans.Size = new System.Drawing.Size(126, 21);
			this.vno_trans.TabIndex = 49;
			//
			//vharga
			//
			this.vharga.BackColor = System.Drawing.SystemColors.Control;
			this.vharga.Cursor = System.Windows.Forms.Cursors.Default;
			this.vharga.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vharga.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vharga.Location = new System.Drawing.Point(59, 277);
			this.vharga.Name = "vharga";
			this.vharga.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vharga.Size = new System.Drawing.Size(91, 21);
			this.vharga.TabIndex = 48;
			this.vharga.Text = "harga";
			//
			//vdesc
			//
			this.vdesc.BackColor = System.Drawing.SystemColors.Control;
			this.vdesc.Cursor = System.Windows.Forms.Cursors.Default;
			this.vdesc.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vdesc.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vdesc.Location = new System.Drawing.Point(289, 252);
			this.vdesc.Name = "vdesc";
			this.vdesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vdesc.Size = new System.Drawing.Size(181, 21);
			this.vdesc.TabIndex = 47;
			this.vdesc.Text = "desc";
			//
			//vspg
			//
			this.vspg.BackColor = System.Drawing.SystemColors.Control;
			this.vspg.Cursor = System.Windows.Forms.Cursors.Default;
			this.vspg.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vspg.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vspg.Location = new System.Drawing.Point(139, 252);
			this.vspg.Name = "vspg";
			this.vspg.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vspg.Size = new System.Drawing.Size(46, 21);
			this.vspg.TabIndex = 46;
			this.vspg.Text = "spg";
			//
			//vplu
			//
			this.vplu.BackColor = System.Drawing.SystemColors.Control;
			this.vplu.Cursor = System.Windows.Forms.Cursors.Default;
			this.vplu.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vplu.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vplu.Location = new System.Drawing.Point(189, 252);
			this.vplu.Name = "vplu";
			this.vplu.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vplu.Size = new System.Drawing.Size(96, 21);
			this.vplu.TabIndex = 45;
			this.vplu.Text = "plu";
			//
			//cmdsales
			//
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(4, 94);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView1.Size = new System.Drawing.Size(731, 292);
			this.DataGridView1.TabIndex = 68;
			//
			//txtcust_id
			//
			this.txtcust_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtcust_id.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtcust_id.Location = new System.Drawing.Point(756, 54);
			this.txtcust_id.Name = "txtcust_id";
			this.txtcust_id.Size = new System.Drawing.Size(48, 26);
			this.txtcust_id.TabIndex = 39;
			//
			//vrfid
			//
			this.vrfid.BackColor = System.Drawing.SystemColors.Control;
			this.vrfid.Cursor = System.Windows.Forms.Cursors.Default;
			this.vrfid.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vrfid.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vrfid.Location = new System.Drawing.Point(314, 245);
			this.vrfid.Name = "vrfid";
			this.vrfid.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vrfid.Size = new System.Drawing.Size(96, 21);
			this.vrfid.TabIndex = 70;
			this.vrfid.Text = "plu";
			//
			//Timer1
			//
			//
			//RfidScan1
			//
			this.RfidScan1.BackColor = System.Drawing.SystemColors.Control;
			this.RfidScan1.Cursor = System.Windows.Forms.Cursors.Default;
			this.RfidScan1.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.RfidScan1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.RfidScan1.Image = (System.Drawing.Image) (resources.GetObject("RfidScan1.Image"));
			this.RfidScan1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.RfidScan1.Location = new System.Drawing.Point(508, 23);
			this.RfidScan1.Name = "RfidScan1";
			this.RfidScan1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RfidScan1.Size = new System.Drawing.Size(68, 56);
			this.RfidScan1.TabIndex = 71;
			this.RfidScan1.Text = "READ RFID";
			this.RfidScan1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.RfidScan1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.RfidScan1.UseVisualStyleBackColor = false;
			//
			//RfidScan2
			//
			this.RfidScan2.BackColor = System.Drawing.SystemColors.Control;
			this.RfidScan2.Cursor = System.Windows.Forms.Cursors.Default;
			this.RfidScan2.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.RfidScan2.ForeColor = System.Drawing.Color.Red;
			this.RfidScan2.Image = (System.Drawing.Image) (resources.GetObject("RfidScan2.Image"));
			this.RfidScan2.Location = new System.Drawing.Point(508, 23);
			this.RfidScan2.Name = "RfidScan2";
			this.RfidScan2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RfidScan2.Size = new System.Drawing.Size(68, 56);
			this.RfidScan2.TabIndex = 72;
			this.RfidScan2.Text = "RFID OFF";
			this.RfidScan2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.RfidScan2.UseVisualStyleBackColor = false;
			//
			//BackgroundWorker1
			//
			//
			//frmSales
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (14.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(737, 509);
			this.ControlBox = false;
			this.Controls.Add(this.RfidScan2);
			this.Controls.Add(this.RfidScan1);
			this.Controls.Add(this.txtcust_id);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.Frame3);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this._cmdsales_9);
			this.Controls.Add(this.lblqty);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.vpromo);
			this.Controls.Add(this.lblno);
			this.Controls.Add(this.vgtotal);
			this.Controls.Add(this.vtotal);
			this.Controls.Add(this.Label6);
			this.Controls.Add(this.Label5);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.vdiscrp2);
			this.Controls.Add(this.vdiscrp1);
			this.Controls.Add(this.vdisc2);
			this.Controls.Add(this.vqty);
			this.Controls.Add(this.vdisc1);
			this.Controls.Add(this.vflag);
			this.Controls.Add(this.vno_trans);
			this.Controls.Add(this.vharga);
			this.Controls.Add(this.vdesc);
			this.Controls.Add(this.vspg);
			this.Controls.Add(this.vplu);
			this.Controls.Add(this.vrfid);
			this.Font = new System.Drawing.Font("Arial", (float) (8.0F));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximumSize = new System.Drawing.Size(753, 548);
			this.MinimumSize = new System.Drawing.Size(741, 548);
			this.Name = "frmSales";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SALES";
			this.Frame1.ResumeLayout(false);
			this.Frame1.PerformLayout();
			this.Frame3.ResumeLayout(false);
			this.Frame3.PerformLayout();
			this.Frame2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.CmdNav).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cmdsales).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		public System.Windows.Forms.Button _cmdsales_3;
		public Microsoft.VisualBasic.Compatibility.VB6.ButtonArray cmdsales;
		public System.Windows.Forms.Button _cmdsales_1;
		public System.Windows.Forms.Button _cmdsales_2;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.Panel Frame1;
		public System.Windows.Forms.Button _CmdNav_0;
		public Microsoft.VisualBasic.Compatibility.VB6.ButtonArray CmdNav;
		public System.Windows.Forms.Button _CmdNav_3;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label lblgrand_total;
		public System.Windows.Forms.Button _cmdsales_0;
		public System.Windows.Forms.GroupBox Frame3;
		public System.Windows.Forms.Button _cmdsales_8;
		public System.Windows.Forms.Panel Frame2;
		public System.Windows.Forms.Button _CmdNav_2;
		public System.Windows.Forms.Button _CmdNav_1;
		public System.Windows.Forms.Button _cmdsales_7;
		public System.Windows.Forms.Button _cmdsales_6;
		public System.Windows.Forms.Button _cmdsales_5;
		public System.Windows.Forms.Button _cmdsales_4;
		public System.Windows.Forms.Button _cmdsales_9;
		public System.Windows.Forms.Label lblqty;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label vpromo;
		public System.Windows.Forms.Label lblno;
		public System.Windows.Forms.Label vgtotal;
		public System.Windows.Forms.Label vtotal;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label vdiscrp2;
		public System.Windows.Forms.Label vdiscrp1;
		public System.Windows.Forms.Label vdisc2;
		public System.Windows.Forms.Label vqty;
		public System.Windows.Forms.Label vdisc1;
		public System.Windows.Forms.Label vflag;
		public System.Windows.Forms.Label vno_trans;
		public System.Windows.Forms.Label vharga;
		public System.Windows.Forms.Label vdesc;
		public System.Windows.Forms.Label vspg;
		public System.Windows.Forms.Label vplu;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox txtcust_name;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox txtcard_no;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.TextBox txtcust_id;
		internal Label lblkode;
		internal TextBox txtkode;
		public Label vrfid;
		internal Timer Timer1;
		public Button RfidScan1;
		public Button RfidScan2;
		internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
	}
	
}
