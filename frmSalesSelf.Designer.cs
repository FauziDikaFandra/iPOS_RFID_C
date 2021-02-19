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
		public partial class frmSalesSelf : System.Windows.Forms.Form
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
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmSales_FormClosed);
			base.Load += new System.EventHandler(frmSalesSelf_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesSelf));
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.txtkode = new System.Windows.Forms.TextBox();
			this.txtkode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtkode_KeyDown);
			this.txtkode.TextChanged += new System.EventHandler(this.txtkode_TextChanged);
			this.Label1 = new System.Windows.Forms.Label();
			this.lblgrand_total = new System.Windows.Forms.Label();
			this._cmdsales_0 = new System.Windows.Forms.Button();
			this._cmdsales_0.Click += new System.EventHandler(this._cmdsales_0_Click);
			this.Frame2 = new System.Windows.Forms.Panel();
			this.Button6 = new System.Windows.Forms.Button();
			this.Button6.Click += new System.EventHandler(this.Button6_Click);
			this._CmdNav_2 = new System.Windows.Forms.Button();
			this._CmdNav_2.Click += new System.EventHandler(this._CmdNav_2_Click);
			this._cmdsales_7 = new System.Windows.Forms.Button();
			this._CmdNav_1 = new System.Windows.Forms.Button();
			this._CmdNav_1.Click += new System.EventHandler(this._CmdNav_1_Click);
			this.RfidScan2 = new System.Windows.Forms.Button();
			this.RfidScan2.Click += new System.EventHandler(this.RfidScan2_Click);
			this.txtcard_no = new System.Windows.Forms.Label();
			this._cmdsales_9 = new System.Windows.Forms.Button();
			this._cmdsales_9.Click += new System.EventHandler(this._cmdsales_9_Click);
			this.CmdNav = new Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(this.components);
			this.lblqty = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.vpromo = new System.Windows.Forms.Label();
			this.lblno = new System.Windows.Forms.Label();
			this.vgtotal = new System.Windows.Forms.Label();
			this.vtotal = new System.Windows.Forms.Label();
			this.vdiscrp2 = new System.Windows.Forms.Label();
			this.vdiscrp1 = new System.Windows.Forms.Label();
			this.vqty = new System.Windows.Forms.Label();
			this.vflag = new System.Windows.Forms.Label();
			this.vno_trans = new System.Windows.Forms.Label();
			this.vno_trans.TextChanged += new System.EventHandler(this.vno_trans_TextChanged);
			this.vharga = new System.Windows.Forms.Label();
			this.vdesc = new System.Windows.Forms.Label();
			this.vspg = new System.Windows.Forms.Label();
			this.vplu = new System.Windows.Forms.Label();
			this.cmdsales = new Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(this.components);
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.DataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_CellMouseUp);
			this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
			this.txtcust_id = new System.Windows.Forms.TextBox();
			this.vrfid = new System.Windows.Forms.Label();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
			this.BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
			this._btnNum_10 = new System.Windows.Forms.Button();
			this._btnNum_10.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_13 = new System.Windows.Forms.Button();
			this._btnNum_13.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_12 = new System.Windows.Forms.Button();
			this._btnNum_12.Click += new System.EventHandler(this._btnNum_0_Click);
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
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Button5 = new System.Windows.Forms.Button();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.Button3 = new System.Windows.Forms.Button();
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Button2 = new System.Windows.Forms.Button();
			this.Button2.Click += new System.EventHandler(this.Button2_Click_1);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click);
			this.Frame1 = new System.Windows.Forms.Panel();
			this.txtcust_name = new System.Windows.Forms.Label();
			this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.ContextMenuStrip1.Click += new System.EventHandler(this.ContextMenuStrip1_Click);
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.Frame2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.CmdNav).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cmdsales).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			this.Panel1.SuspendLayout();
			this.Frame1.SuspendLayout();
			this.ContextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			//
			//txtkode
			//
			this.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtkode.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtkode.Location = new System.Drawing.Point(112, 10);
			this.txtkode.Margin = new System.Windows.Forms.Padding(1);
			this.txtkode.MaxLength = 16;
			this.txtkode.Name = "txtkode";
			this.txtkode.Size = new System.Drawing.Size(269, 41);
			this.txtkode.TabIndex = 69;
			//
			//Label1
			//
			this.Label1.BackColor = System.Drawing.Color.Black;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.Font = new System.Drawing.Font("Arial", (float) (20.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.Color.Yellow;
			this.Label1.Location = new System.Drawing.Point(3, 114);
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
			this.lblgrand_total.Location = new System.Drawing.Point(130, 109);
			this.lblgrand_total.Name = "lblgrand_total";
			this.lblgrand_total.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblgrand_total.Size = new System.Drawing.Size(246, 41);
			this.lblgrand_total.TabIndex = 34;
			this.lblgrand_total.Text = "0";
			this.lblgrand_total.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//_cmdsales_0
			//
			this._cmdsales_0.BackColor = System.Drawing.SystemColors.Control;
			this._cmdsales_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdsales_0.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdsales_0.ForeColor = System.Drawing.Color.Black;
			this._cmdsales_0.Image = (System.Drawing.Image) (resources.GetObject("_cmdsales_0.Image"));
			this.cmdsales.SetIndex(this._cmdsales_0, System.Convert.ToInt16(0));
			this._cmdsales_0.Location = new System.Drawing.Point(400, 3);
			this._cmdsales_0.Name = "_cmdsales_0";
			this._cmdsales_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdsales_0.Size = new System.Drawing.Size(114, 62);
			this._cmdsales_0.TabIndex = 2;
			this._cmdsales_0.Text = "PAYMENT";
			this._cmdsales_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdsales_0.UseVisualStyleBackColor = false;
			//
			//Frame2
			//
			this.Frame2.BackColor = System.Drawing.Color.Transparent;
			this.Frame2.Controls.Add(this.Button6);
			this.Frame2.Controls.Add(this._CmdNav_2);
			this.Frame2.Controls.Add(this._cmdsales_7);
			this.Frame2.Controls.Add(this._CmdNav_1);
			this.Frame2.Controls.Add(this.RfidScan2);
			this.Frame2.Controls.Add(this.txtcard_no);
			this.Frame2.Controls.Add(this._cmdsales_0);
			this.Frame2.Controls.Add(this._cmdsales_9);
			this.Frame2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Frame2.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(4, 3);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(517, 68);
			this.Frame2.TabIndex = 43;
			//
			//Button6
			//
			this.Button6.BackColor = System.Drawing.SystemColors.Control;
			this.Button6.Cursor = System.Windows.Forms.Cursors.Default;
			this.Button6.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Button6.ForeColor = System.Drawing.Color.Black;
			this.Button6.Image = (System.Drawing.Image) (resources.GetObject("Button6.Image"));
			this.Button6.Location = new System.Drawing.Point(168, 3);
			this.Button6.Name = "Button6";
			this.Button6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Button6.Size = new System.Drawing.Size(114, 62);
			this.Button6.TabIndex = 74;
			this.Button6.Text = "MEMBER";
			this.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Button6.UseVisualStyleBackColor = false;
			//
			//_CmdNav_2
			//
			this._CmdNav_2.BackColor = System.Drawing.SystemColors.Control;
			this._CmdNav_2.Cursor = System.Windows.Forms.Cursors.Default;
			this._CmdNav_2.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._CmdNav_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._CmdNav_2.Image = (System.Drawing.Image) (resources.GetObject("_CmdNav_2.Image"));
			this._CmdNav_2.Location = new System.Drawing.Point(3, 34);
			this._CmdNav_2.Name = "_CmdNav_2";
			this._CmdNav_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._CmdNav_2.Size = new System.Drawing.Size(48, 30);
			this._CmdNav_2.TabIndex = 73;
			this._CmdNav_2.TabStop = false;
			this._CmdNav_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._CmdNav_2.UseVisualStyleBackColor = false;
			//
			//_cmdsales_7
			//
			this._cmdsales_7.BackColor = System.Drawing.SystemColors.Control;
			this._cmdsales_7.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdsales_7.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdsales_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdsales_7.Image = (System.Drawing.Image) (resources.GetObject("_cmdsales_7.Image"));
			this.cmdsales.SetIndex(this._cmdsales_7, System.Convert.ToInt16(7));
			this._cmdsales_7.Location = new System.Drawing.Point(533, 2);
			this._cmdsales_7.Name = "_cmdsales_7";
			this._cmdsales_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdsales_7.Size = new System.Drawing.Size(70, 62);
			this._cmdsales_7.TabIndex = 9;
			this._cmdsales_7.Text = "CLOSE";
			this._cmdsales_7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdsales_7.UseVisualStyleBackColor = false;
			//
			//_CmdNav_1
			//
			this._CmdNav_1.BackColor = System.Drawing.SystemColors.Control;
			this._CmdNav_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._CmdNav_1.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._CmdNav_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._CmdNav_1.Image = (System.Drawing.Image) (resources.GetObject("_CmdNav_1.Image"));
			this._CmdNav_1.Location = new System.Drawing.Point(3, 3);
			this._CmdNav_1.Name = "_CmdNav_1";
			this._CmdNav_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._CmdNav_1.Size = new System.Drawing.Size(48, 30);
			this._CmdNav_1.TabIndex = 72;
			this._CmdNav_1.TabStop = false;
			this._CmdNav_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._CmdNav_1.UseVisualStyleBackColor = false;
			//
			//RfidScan2
			//
			this.RfidScan2.BackColor = System.Drawing.SystemColors.Control;
			this.RfidScan2.Cursor = System.Windows.Forms.Cursors.Default;
			this.RfidScan2.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.RfidScan2.ForeColor = System.Drawing.Color.Red;
			this.RfidScan2.Image = (System.Drawing.Image) (resources.GetObject("RfidScan2.Image"));
			this.RfidScan2.Location = new System.Drawing.Point(52, 3);
			this.RfidScan2.Name = "RfidScan2";
			this.RfidScan2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RfidScan2.Size = new System.Drawing.Size(114, 62);
			this.RfidScan2.TabIndex = 72;
			this.RfidScan2.Text = "RFID OFF";
			this.RfidScan2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.RfidScan2.UseVisualStyleBackColor = false;
			//
			//txtcard_no
			//
			this.txtcard_no.BackColor = System.Drawing.Color.Transparent;
			this.txtcard_no.Cursor = System.Windows.Forms.Cursors.Default;
			this.txtcard_no.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtcard_no.ForeColor = System.Drawing.Color.Yellow;
			this.txtcard_no.Location = new System.Drawing.Point(533, 30);
			this.txtcard_no.Name = "txtcard_no";
			this.txtcard_no.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtcard_no.Size = new System.Drawing.Size(95, 21);
			this.txtcard_no.TabIndex = 68;
			this.txtcard_no.Text = "No Member";
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
			this._cmdsales_9.Location = new System.Drawing.Point(284, 3);
			this._cmdsales_9.Name = "_cmdsales_9";
			this._cmdsales_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdsales_9.Size = new System.Drawing.Size(114, 62);
			this._cmdsales_9.TabIndex = 63;
			this._cmdsales_9.Text = "PROMO CHECKING";
			this._cmdsales_9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdsales_9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this._cmdsales_9.UseVisualStyleBackColor = false;
			//
			//lblqty
			//
			this.lblqty.BackColor = System.Drawing.Color.Transparent;
			this.lblqty.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblqty.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblqty.ForeColor = System.Drawing.Color.Yellow;
			this.lblqty.Location = new System.Drawing.Point(300, 85);
			this.lblqty.Name = "lblqty";
			this.lblqty.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblqty.Size = new System.Drawing.Size(73, 21);
			this.lblqty.TabIndex = 66;
			this.lblqty.Text = "pcs";
			this.lblqty.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//label2
			//
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.Black;
			this.Label2.Location = new System.Drawing.Point(4, 83);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(86, 16);
			this.Label2.TabIndex = 67;
			this.Label2.Text = "QTY :";
			this.Label2.Visible = false;
			//
			//vpromo
			//
			this.vpromo.BackColor = System.Drawing.SystemColors.Control;
			this.vpromo.Cursor = System.Windows.Forms.Cursors.Default;
			this.vpromo.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vpromo.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vpromo.Location = new System.Drawing.Point(317, 277);
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
			this.lblno.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblno.ForeColor = System.Drawing.Color.Yellow;
			this.lblno.Location = new System.Drawing.Point(6, 6);
			this.lblno.Name = "lblno";
			this.lblno.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblno.Size = new System.Drawing.Size(131, 21);
			this.lblno.TabIndex = 64;
			this.lblno.Text = "Trans : xxx";
			//
			//vgtotal
			//
			this.vgtotal.BackColor = System.Drawing.SystemColors.Control;
			this.vgtotal.Cursor = System.Windows.Forms.Cursors.Default;
			this.vgtotal.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vgtotal.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vgtotal.Location = new System.Drawing.Point(320, 277);
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
			this.vdesc.Location = new System.Drawing.Point(185, 252);
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
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.BackgroundColor = System.Drawing.Color.White;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", (float) (8.0F));
			DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2;
			this.DataGridView1.Location = new System.Drawing.Point(9, 73);
			this.DataGridView1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.RowHeadersVisible = false;
			this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView1.Size = new System.Drawing.Size(512, 422);
			this.DataGridView1.TabIndex = 68;
			//
			//txtcust_id
			//
			this.txtcust_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtcust_id.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtcust_id.Location = new System.Drawing.Point(783, 54);
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
			this.vrfid.Location = new System.Drawing.Point(277, 245);
			this.vrfid.Name = "vrfid";
			this.vrfid.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vrfid.Size = new System.Drawing.Size(96, 21);
			this.vrfid.TabIndex = 70;
			this.vrfid.Text = "plu";
			//
			//Timer1
			//
			//
			//BackgroundWorker1
			//
			//
			//_btnNum_10
			//
			this._btnNum_10.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_10.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_10.Font = new System.Drawing.Font("Arial", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_10.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_10.Location = new System.Drawing.Point(246, 256);
			this._btnNum_10.Name = "_btnNum_10";
			this._btnNum_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_10.Size = new System.Drawing.Size(135, 68);
			this._btnNum_10.TabIndex = 15;
			this._btnNum_10.Tag = "14";
			this._btnNum_10.Text = "CLOSE";
			this._btnNum_10.UseVisualStyleBackColor = false;
			//
			//_btnNum_13
			//
			this._btnNum_13.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_13.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_13.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_13.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_13.Location = new System.Drawing.Point(313, 189);
			this._btnNum_13.Name = "_btnNum_13";
			this._btnNum_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_13.Size = new System.Drawing.Size(68, 68);
			this._btnNum_13.TabIndex = 12;
			this._btnNum_13.Tag = "13";
			this._btnNum_13.Text = "C";
			this._btnNum_13.UseVisualStyleBackColor = false;
			//
			//_btnNum_12
			//
			this._btnNum_12.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_12.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_12.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_12.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_12.Location = new System.Drawing.Point(313, 122);
			this._btnNum_12.Name = "_btnNum_12";
			this._btnNum_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_12.Size = new System.Drawing.Size(68, 68);
			this._btnNum_12.TabIndex = 11;
			this._btnNum_12.Tag = "12";
			this._btnNum_12.Text = "<<";
			this._btnNum_12.UseVisualStyleBackColor = false;
			//
			//_btnNum_11
			//
			this._btnNum_11.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_11.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_11.Font = new System.Drawing.Font("Arial", (float) (15.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_11.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_11.Location = new System.Drawing.Point(112, 256);
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
			this._btnNum_0.Location = new System.Drawing.Point(313, 55);
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
			this._btnNum_1.Location = new System.Drawing.Point(112, 189);
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
			this._btnNum_2.Location = new System.Drawing.Point(179, 189);
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
			this._btnNum_3.Location = new System.Drawing.Point(246, 189);
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
			this._btnNum_4.Location = new System.Drawing.Point(112, 122);
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
			this._btnNum_5.Location = new System.Drawing.Point(179, 122);
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
			this._btnNum_6.Location = new System.Drawing.Point(246, 122);
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
			this._btnNum_7.Location = new System.Drawing.Point(112, 55);
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
			this._btnNum_8.Location = new System.Drawing.Point(179, 55);
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
			this._btnNum_9.Location = new System.Drawing.Point(246, 55);
			this._btnNum_9.Name = "_btnNum_9";
			this._btnNum_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_9.Size = new System.Drawing.Size(68, 68);
			this._btnNum_9.TabIndex = 10;
			this._btnNum_9.Tag = "9";
			this._btnNum_9.Text = "9";
			this._btnNum_9.UseVisualStyleBackColor = false;
			//
			//Panel1
			//
			this.Panel1.BackColor = System.Drawing.Color.Transparent;
			this.Panel1.Controls.Add(this.Button5);
			this.Panel1.Controls.Add(this.Button4);
			this.Panel1.Controls.Add(this.txtkode);
			this.Panel1.Controls.Add(this.Button3);
			this.Panel1.Controls.Add(this.Button2);
			this.Panel1.Controls.Add(this.Button1);
			this.Panel1.Controls.Add(this._btnNum_10);
			this.Panel1.Controls.Add(this._btnNum_7);
			this.Panel1.Controls.Add(this._btnNum_9);
			this.Panel1.Controls.Add(this._btnNum_13);
			this.Panel1.Controls.Add(this._btnNum_8);
			this.Panel1.Controls.Add(this._btnNum_12);
			this.Panel1.Controls.Add(this._btnNum_6);
			this.Panel1.Controls.Add(this._btnNum_11);
			this.Panel1.Controls.Add(this._btnNum_5);
			this.Panel1.Controls.Add(this._btnNum_0);
			this.Panel1.Controls.Add(this._btnNum_4);
			this.Panel1.Controls.Add(this._btnNum_1);
			this.Panel1.Controls.Add(this._btnNum_3);
			this.Panel1.Controls.Add(this._btnNum_2);
			this.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Panel1.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Panel1.Location = new System.Drawing.Point(527, 171);
			this.Panel1.Name = "Panel1";
			this.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Panel1.Size = new System.Drawing.Size(385, 327);
			this.Panel1.TabIndex = 74;
			//
			//Button5
			//
			this.Button5.BackColor = System.Drawing.Color.DarkGray;
			this.Button5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Button5.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Button5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Button5.Location = new System.Drawing.Point(2, 256);
			this.Button5.Name = "Button5";
			this.Button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Button5.Size = new System.Drawing.Size(109, 68);
			this.Button5.TabIndex = 20;
			this.Button5.Tag = "7";
			this.Button5.UseVisualStyleBackColor = false;
			//
			//Button4
			//
			this.Button4.BackColor = System.Drawing.SystemColors.Control;
			this.Button4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Button4.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Button4.ForeColor = System.Drawing.SystemColors.ControlText;
			//this.Button4.Image = global::My.resources.Resources.bag_2__dTN_icon;
			this.Button4.Location = new System.Drawing.Point(2, 190);
			this.Button4.Name = "Button4";
			this.Button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Button4.Size = new System.Drawing.Size(109, 67);
			this.Button4.TabIndex = 19;
			this.Button4.Tag = "7";
			this.Button4.Text = "TOTE BAG";
			this.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Button4.UseVisualStyleBackColor = false;
			//
			//Button3
			//
			this.Button3.BackColor = System.Drawing.SystemColors.Control;
			this.Button3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Button3.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Button3.ForeColor = System.Drawing.SystemColors.ControlText;
			//this.Button3.Image = global::My.resources.Resources.plastic_bag_QJ2_icon;
			this.Button3.Location = new System.Drawing.Point(2, 123);
			this.Button3.Name = "Button3";
			this.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Button3.Size = new System.Drawing.Size(109, 67);
			this.Button3.TabIndex = 18;
			this.Button3.Tag = "7";
			this.Button3.Text = "PLASTIC";
			this.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Button3.UseVisualStyleBackColor = false;
			//
			//Button2
			//
			this.Button2.BackColor = System.Drawing.SystemColors.Control;
			this.Button2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Button2.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Button2.ForeColor = System.Drawing.SystemColors.ControlText;
			//this.Button2.Image = global::My.resources.Resources.bag_xNf_icon;
			this.Button2.Location = new System.Drawing.Point(2, 55);
			this.Button2.Name = "Button2";
			this.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Button2.Size = new System.Drawing.Size(109, 68);
			this.Button2.TabIndex = 17;
			this.Button2.Tag = "7";
			this.Button2.Text = "PAPER BAG";
			this.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Button2.UseVisualStyleBackColor = false;
			//
			//Button1
			//
			this.Button1.BackColor = System.Drawing.SystemColors.Control;
			this.Button1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Button1.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Button1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Button1.Location = new System.Drawing.Point(2, 2);
			this.Button1.Name = "Button1";
			this.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Button1.Size = new System.Drawing.Size(109, 53);
			this.Button1.TabIndex = 16;
			this.Button1.Tag = "7";
			this.Button1.Text = "PLU/EAN";
			this.Button1.UseVisualStyleBackColor = false;
			//
			//Frame1
			//
			this.Frame1.BackColor = System.Drawing.Color.Black;
			this.Frame1.Controls.Add(this.txtcust_name);
			this.Frame1.Controls.Add(this.lblqty);
			this.Frame1.Controls.Add(this.lblno);
			this.Frame1.Controls.Add(this.lblgrand_total);
			this.Frame1.Controls.Add(this.Label1);
			this.Frame1.Controls.Add(this.Label2);
			this.Frame1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Frame1.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(527, 6);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(385, 160);
			this.Frame1.TabIndex = 62;
			//
			//txtcust_name
			//
			this.txtcust_name.BackColor = System.Drawing.Color.Transparent;
			this.txtcust_name.Cursor = System.Windows.Forms.Cursors.Default;
			this.txtcust_name.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtcust_name.ForeColor = System.Drawing.Color.Yellow;
			this.txtcust_name.Location = new System.Drawing.Point(178, 6);
			this.txtcust_name.Name = "txtcust_name";
			this.txtcust_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtcust_name.Size = new System.Drawing.Size(195, 21);
			this.txtcust_name.TabIndex = 68;
			this.txtcust_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			//
			//ContextMenuStrip1
			//
			this.ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.ToolStripMenuItem1});
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			this.ContextMenuStrip1.Size = new System.Drawing.Size(134, 26);
			//
			//ToolStripMenuItem1
			//
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
			this.ToolStripMenuItem1.Text = "Delete Row";
			//
			//frmSalesSelf
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (14.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGray;
			this.ClientSize = new System.Drawing.Size(916, 522);
			this.ControlBox = false;
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.txtcust_id);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.vpromo);
			this.Controls.Add(this.vgtotal);
			this.Controls.Add(this.vtotal);
			this.Controls.Add(this.vdiscrp2);
			this.Controls.Add(this.vdiscrp1);
			this.Controls.Add(this.vqty);
			this.Controls.Add(this.vflag);
			this.Controls.Add(this.vno_trans);
			this.Controls.Add(this.vharga);
			this.Controls.Add(this.vdesc);
			this.Controls.Add(this.vspg);
			this.Controls.Add(this.vplu);
			this.Controls.Add(this.vrfid);
			this.Font = new System.Drawing.Font("Arial", (float) (8.0F));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MinimumSize = new System.Drawing.Size(894, 561);
			this.Name = "frmSalesSelf";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SALES";
			this.TopMost = true;
			this.Frame2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.CmdNav).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cmdsales).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.Frame1.ResumeLayout(false);
			this.ContextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		public Microsoft.VisualBasic.Compatibility.VB6.ButtonArray cmdsales;
		public System.Windows.Forms.ToolTip ToolTip1;
		public Microsoft.VisualBasic.Compatibility.VB6.ButtonArray CmdNav;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Label lblgrand_total;
		public System.Windows.Forms.Button _cmdsales_0;
		public System.Windows.Forms.Panel Frame2;
		public System.Windows.Forms.Button _cmdsales_7;
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
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.TextBox txtcust_id;
		internal TextBox txtkode;
		public Label vrfid;
		internal Timer Timer1;
		public Button RfidScan2;
		internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
		public Button _CmdNav_2;
		public Button _CmdNav_1;
		public Button _btnNum_10;
		public Button _btnNum_13;
		public Button _btnNum_12;
		public Button _btnNum_11;
		public Button _btnNum_0;
		public Button _btnNum_1;
		public Button _btnNum_2;
		public Button _btnNum_3;
		public Button _btnNum_4;
		public Button _btnNum_5;
		public Button _btnNum_6;
		public Button _btnNum_7;
		public Button _btnNum_8;
		public Button _btnNum_9;
		public Panel Panel1;
		public Button Button5;
		public Button Button4;
		public Button Button3;
		public Button Button2;
		public Button Button1;
		public Panel Frame1;
		public Button Button6;
		public Label txtcard_no;
		public Label txtcust_name;
		internal ContextMenuStrip ContextMenuStrip1;
		internal ToolStripMenuItem ToolStripMenuItem1;
	}
	
}
