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
	partial class frmPayment : System.Windows.Forms.Form
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
			base.Activated += new System.EventHandler(frmPayment_Activated);
			base.Load += new System.EventHandler(frmPayment_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPayment));
			this.vpay = new System.Windows.Forms.TextBox();
			this.vstatus = new System.Windows.Forms.TextBox();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this._btnNum_12 = new System.Windows.Forms.Button();
			this._btnNum_10 = new System.Windows.Forms.Button();
			this._btnNum_0 = new System.Windows.Forms.Button();
			this._btnNum_1 = new System.Windows.Forms.Button();
			this.cmdvoc = new System.Windows.Forms.Button();
			this.cmdvoc.Click += new System.EventHandler(this.cmdvoc_Click);
			this.Label4 = new System.Windows.Forms.Label();
			this._frmpay_2 = new System.Windows.Forms.GroupBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.Label13 = new System.Windows.Forms.Label();
			this.txtvoucher = new System.Windows.Forms.TextBox();
			this.txtvoucher.Enter += new System.EventHandler(this.txtvoucher_Enter);
			this.txtvoucher.TextChanged += new System.EventHandler(this.txtvoucher_TextChanged);
			this.txtvoucher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtvoucher_KeyDown);
			this.txtno_voc = new System.Windows.Forms.TextBox();
			this.txtno_voc.Enter += new System.EventHandler(this.txtno_voc_Enter);
			this.txtno_voc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtno_voc_KeyDown);
			this.txtnama = new System.Windows.Forms.TextBox();
			this.txtno_kartu = new System.Windows.Forms.TextBox();
			this.txtno_kartu.Enter += new System.EventHandler(this.txtno_kartu_Enter);
			this.txtno_kartu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtno_kartu_KeyDown);
			this.txtno_kartu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtno_kartu_KeyPress);
			this.txtno_kartu.TextChanged += new System.EventHandler(this.txtno_kartu_TextChanged);
			this.txtcredit = new System.Windows.Forms.TextBox();
			this.txtcredit.Enter += new System.EventHandler(this.txtcredit_Enter);
			this.txtcredit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcredit_KeyDown);
			this.txtcredit.TextChanged += new System.EventHandler(this.txtcredit_TextChanged);
			this.txtcash = new System.Windows.Forms.TextBox();
			this.txtcash.Enter += new System.EventHandler(this.txtcash_Enter);
			this.txtcash.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtcash_KeyDown);
			this.txtcash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcash_KeyPress);
			this.txtcash.TextChanged += new System.EventHandler(this.txtcash_TextChanged);
			this.Label1 = new System.Windows.Forms.Label();
			this._btnNum_11 = new System.Windows.Forms.Button();
			this._frmpay_0 = new System.Windows.Forms.GroupBox();
			this.Label12 = new System.Windows.Forms.Label();
			this.Label11 = new System.Windows.Forms.Label();
			this.txtkembali = new System.Windows.Forms.TextBox();
			this.txtkembali.TextChanged += new System.EventHandler(this.txtkembali_TextChanged);
			this._btnNum_2 = new System.Windows.Forms.Button();
			this._frmpay_1 = new System.Windows.Forms.GroupBox();
			this.Label17 = new System.Windows.Forms.Label();
			this.Label16 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.txtsaldo_point = new System.Windows.Forms.TextBox();
			this.txtcard_no = new System.Windows.Forms.TextBox();
			this.txttukar_point = new System.Windows.Forms.TextBox();
			this.txttukar_point.Enter += new System.EventHandler(this.txttukar_point_Enter);
			this.txttukar_point.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txttukar_point_KeyDown);
			this.txtpoint = new System.Windows.Forms.TextBox();
			this.txtpoint.Enter += new System.EventHandler(this.txtpoint_Enter);
			this.txtpoint.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtpoint_KeyDown);
			this.txtpoint.Leave += new System.EventHandler(this.txtpoint_Leave);
			this.txtpoint.TextChanged += new System.EventHandler(this.txtpoint_TextChanged);
			this.lblmsg = new System.Windows.Forms.Label();
			this._btnNum_3 = new System.Windows.Forms.Button();
			this.btnNum = new Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(this.components);
			this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
			this._btnNum_4 = new System.Windows.Forms.Button();
			this._btnNum_5 = new System.Windows.Forms.Button();
			this._btnNum_6 = new System.Windows.Forms.Button();
			this._btnNum_7 = new System.Windows.Forms.Button();
			this._btnNum_8 = new System.Windows.Forms.Button();
			this._btnNum_9 = new System.Windows.Forms.Button();
			this.cmdpay = new Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(this.components);
			this._cmdpay_0 = new System.Windows.Forms.Button();
			this._cmdpay_0.Click += new System.EventHandler(this._cmdpay_0_Click);
			this._cmdpay_2 = new System.Windows.Forms.Button();
			this._cmdpay_2.Click += new System.EventHandler(this._cmdpay_0_Click);
			this._cmdpay_1 = new System.Windows.Forms.Button();
			this._cmdpay_1.Click += new System.EventHandler(this._cmdpay_0_Click);
			this.vno_trans = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.lblsisa = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.lblbayar = new System.Windows.Forms.Label();
			this._frmpay_3 = new System.Windows.Forms.GroupBox();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label9 = new System.Windows.Forms.Label();
			this.Label7 = new System.Windows.Forms.Label();
			this.txtharga_point = new System.Windows.Forms.TextBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.Frame3 = new System.Windows.Forms.Panel();
			this.lbltotal = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Frame2 = new System.Windows.Forms.Panel();
			this.frmpay = new Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(this.components);
			this.Frame1 = new System.Windows.Forms.Panel();
			this.ShapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
			this.Line1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
			this.DataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
			this.DataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
			this.DataGridView2 = new System.Windows.Forms.DataGridView();
			this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			this._frmpay_2.SuspendLayout();
			this._frmpay_0.SuspendLayout();
			this._frmpay_1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.btnNum).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.cmdpay).BeginInit();
			this._frmpay_3.SuspendLayout();
			this.Frame3.SuspendLayout();
			this.Frame2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.frmpay).BeginInit();
			this.Frame1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView2).BeginInit();
			this.SuspendLayout();
			//
			//vpay
			//
			this.vpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vpay.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vpay.Location = new System.Drawing.Point(382, 12);
			this.vpay.Name = "vpay";
			this.vpay.Size = new System.Drawing.Size(108, 26);
			this.vpay.TabIndex = 34;
			this.vpay.Visible = false;
			//
			//vstatus
			//
			this.vstatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vstatus.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vstatus.Location = new System.Drawing.Point(382, 59);
			this.vstatus.Name = "vstatus";
			this.vstatus.Size = new System.Drawing.Size(108, 26);
			this.vstatus.TabIndex = 35;
			this.vstatus.Visible = false;
			//
			//_btnNum_12
			//
			this._btnNum_12.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_12.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_12.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_12.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNum.SetIndex(this._btnNum_12, System.Convert.ToInt16(12));
			this._btnNum_12.Location = new System.Drawing.Point(270, 10);
			this._btnNum_12.Name = "_btnNum_12";
			this._btnNum_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_12.Size = new System.Drawing.Size(65, 65);
			this._btnNum_12.TabIndex = 43;
			this._btnNum_12.TabStop = false;
			this._btnNum_12.Text = "C";
			this._btnNum_12.UseVisualStyleBackColor = false;
			//
			//_btnNum_10
			//
			this._btnNum_10.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_10.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_10.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_10.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNum.SetIndex(this._btnNum_10, System.Convert.ToInt16(10));
			this._btnNum_10.Location = new System.Drawing.Point(205, 10);
			this._btnNum_10.Name = "_btnNum_10";
			this._btnNum_10.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_10.Size = new System.Drawing.Size(65, 65);
			this._btnNum_10.TabIndex = 42;
			this._btnNum_10.TabStop = false;
			this._btnNum_10.Text = "<<";
			this._btnNum_10.UseVisualStyleBackColor = false;
			//
			//_btnNum_0
			//
			this._btnNum_0.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_0.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNum.SetIndex(this._btnNum_0, System.Convert.ToInt16(0));
			this._btnNum_0.Location = new System.Drawing.Point(205, 140);
			this._btnNum_0.Name = "_btnNum_0";
			this._btnNum_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_0.Size = new System.Drawing.Size(130, 65);
			this._btnNum_0.TabIndex = 40;
			this._btnNum_0.TabStop = false;
			this._btnNum_0.Text = "0";
			this._btnNum_0.UseVisualStyleBackColor = false;
			//
			//_btnNum_1
			//
			this._btnNum_1.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_1.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNum.SetIndex(this._btnNum_1, System.Convert.ToInt16(1));
			this._btnNum_1.Location = new System.Drawing.Point(10, 140);
			this._btnNum_1.Name = "_btnNum_1";
			this._btnNum_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_1.Size = new System.Drawing.Size(65, 65);
			this._btnNum_1.TabIndex = 39;
			this._btnNum_1.TabStop = false;
			this._btnNum_1.Text = "1";
			this._btnNum_1.UseVisualStyleBackColor = false;
			//
			//cmdvoc
			//
			this.cmdvoc.BackColor = System.Drawing.SystemColors.Control;
			this.cmdvoc.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdvoc.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.cmdvoc.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdvoc.Image = (System.Drawing.Image) (resources.GetObject("cmdvoc.Image"));
			this.cmdvoc.Location = new System.Drawing.Point(268, 21);
			this.cmdvoc.Name = "cmdvoc";
			this.cmdvoc.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdvoc.Size = new System.Drawing.Size(66, 26);
			this.cmdvoc.TabIndex = 49;
			this.cmdvoc.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdvoc.UseVisualStyleBackColor = false;
			//
			//Label4
			//
			this.Label4.BackColor = System.Drawing.Color.Black;
			this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label4.Font = new System.Drawing.Font("Arial", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.Color.Yellow;
			this.Label4.Location = new System.Drawing.Point(5, 75);
			this.Label4.Name = "Label4";
			this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label4.Size = new System.Drawing.Size(141, 26);
			this.Label4.TabIndex = 14;
			this.Label4.Text = "SISA        : Rp";
			//
			//_frmpay_2
			//
			this._frmpay_2.BackColor = System.Drawing.Color.White;
			this._frmpay_2.Controls.Add(this.Label14);
			this._frmpay_2.Controls.Add(this.Label13);
			this._frmpay_2.Controls.Add(this.txtvoucher);
			this._frmpay_2.Controls.Add(this.txtno_voc);
			this._frmpay_2.Controls.Add(this.cmdvoc);
			this._frmpay_2.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._frmpay_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frmpay.SetIndex(this._frmpay_2, System.Convert.ToInt16(2));
			this._frmpay_2.Location = new System.Drawing.Point(4, 215);
			this._frmpay_2.Name = "_frmpay_2";
			this._frmpay_2.Padding = new System.Windows.Forms.Padding(0);
			this._frmpay_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._frmpay_2.Size = new System.Drawing.Size(351, 96);
			this._frmpay_2.TabIndex = 52;
			this._frmpay_2.TabStop = false;
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label14.Location = new System.Drawing.Point(12, 60);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(44, 15);
			this.Label14.TabIndex = 71;
			this.Label14.Text = "BAYAR";
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label13.Location = new System.Drawing.Point(12, 27);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(83, 15);
			this.Label13.TabIndex = 70;
			this.Label13.Text = "NO VOUCHER";
			//
			//txtvoucher
			//
			this.txtvoucher.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtvoucher.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtvoucher.Location = new System.Drawing.Point(101, 55);
			this.txtvoucher.Name = "txtvoucher";
			this.txtvoucher.Size = new System.Drawing.Size(144, 25);
			this.txtvoucher.TabIndex = 65;
			//
			//txtno_voc
			//
			this.txtno_voc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtno_voc.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtno_voc.Location = new System.Drawing.Point(101, 21);
			this.txtno_voc.MaxLength = 15;
			this.txtno_voc.Name = "txtno_voc";
			this.txtno_voc.Size = new System.Drawing.Size(144, 25);
			this.txtno_voc.TabIndex = 60;
			//
			//txtnama
			//
			this.txtnama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtnama.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtnama.Location = new System.Drawing.Point(93, 55);
			this.txtnama.Name = "txtnama";
			this.txtnama.Size = new System.Drawing.Size(240, 25);
			this.txtnama.TabIndex = 64;
			//
			//txtno_kartu
			//
			this.txtno_kartu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtno_kartu.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtno_kartu.Location = new System.Drawing.Point(93, 24);
			this.txtno_kartu.MaxLength = 16;
			this.txtno_kartu.Name = "txtno_kartu";
			this.txtno_kartu.Size = new System.Drawing.Size(240, 25);
			this.txtno_kartu.TabIndex = 63;
			//
			//txtcredit
			//
			this.txtcredit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtcredit.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtcredit.Location = new System.Drawing.Point(93, 88);
			this.txtcredit.Name = "txtcredit";
			this.txtcredit.Size = new System.Drawing.Size(161, 25);
			this.txtcredit.TabIndex = 62;
			this.txtcredit.Text = "0";
			this.txtcredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			//
			//txtcash
			//
			this.txtcash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtcash.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtcash.Location = new System.Drawing.Point(88, 15);
			this.txtcash.Name = "txtcash";
			this.txtcash.Size = new System.Drawing.Size(161, 25);
			this.txtcash.TabIndex = 61;
			//
			//Label1
			//
			this.Label1.BackColor = System.Drawing.Color.Black;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(5, 65);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(326, 11);
			this.Label1.TabIndex = 20;
			//
			//_btnNum_11
			//
			this._btnNum_11.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_11.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_11.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_11.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNum.SetIndex(this._btnNum_11, System.Convert.ToInt16(11));
			this._btnNum_11.Location = new System.Drawing.Point(205, 75);
			this._btnNum_11.Name = "_btnNum_11";
			this._btnNum_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_11.Size = new System.Drawing.Size(130, 65);
			this._btnNum_11.TabIndex = 41;
			this._btnNum_11.TabStop = false;
			this._btnNum_11.Text = "ENTER";
			this._btnNum_11.UseVisualStyleBackColor = false;
			//
			//_frmpay_0
			//
			this._frmpay_0.BackColor = System.Drawing.Color.White;
			this._frmpay_0.Controls.Add(this.Label12);
			this._frmpay_0.Controls.Add(this.Label11);
			this._frmpay_0.Controls.Add(this.txtkembali);
			this._frmpay_0.Controls.Add(this.txtcash);
			this._frmpay_0.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._frmpay_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frmpay.SetIndex(this._frmpay_0, System.Convert.ToInt16(0));
			this._frmpay_0.Location = new System.Drawing.Point(4, 215);
			this._frmpay_0.Name = "_frmpay_0";
			this._frmpay_0.Padding = new System.Windows.Forms.Padding(0);
			this._frmpay_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._frmpay_0.Size = new System.Drawing.Size(351, 96);
			this._frmpay_0.TabIndex = 49;
			this._frmpay_0.TabStop = false;
			//
			//Label12
			//
			this.Label12.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label12.Location = new System.Drawing.Point(18, 53);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(64, 22);
			this.Label12.TabIndex = 73;
			this.Label12.Text = "KEMBALI";
			//
			//Label11
			//
			this.Label11.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label11.Location = new System.Drawing.Point(18, 19);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(64, 22);
			this.Label11.TabIndex = 72;
			this.Label11.Text = "CASH";
			//
			//txtkembali
			//
			this.txtkembali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtkembali.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtkembali.Location = new System.Drawing.Point(88, 48);
			this.txtkembali.Name = "txtkembali";
			this.txtkembali.Size = new System.Drawing.Size(161, 25);
			this.txtkembali.TabIndex = 69;
			//
			//_btnNum_2
			//
			this._btnNum_2.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_2.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_2.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNum.SetIndex(this._btnNum_2, System.Convert.ToInt16(2));
			this._btnNum_2.Location = new System.Drawing.Point(75, 140);
			this._btnNum_2.Name = "_btnNum_2";
			this._btnNum_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_2.Size = new System.Drawing.Size(65, 65);
			this._btnNum_2.TabIndex = 38;
			this._btnNum_2.TabStop = false;
			this._btnNum_2.Text = "2";
			this._btnNum_2.UseVisualStyleBackColor = false;
			//
			//_frmpay_1
			//
			this._frmpay_1.BackColor = System.Drawing.Color.White;
			this._frmpay_1.Controls.Add(this.Label17);
			this._frmpay_1.Controls.Add(this.txtcredit);
			this._frmpay_1.Controls.Add(this.Label16);
			this._frmpay_1.Controls.Add(this.txtnama);
			this._frmpay_1.Controls.Add(this.Label15);
			this._frmpay_1.Controls.Add(this.txtno_kartu);
			this._frmpay_1.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._frmpay_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frmpay.SetIndex(this._frmpay_1, System.Convert.ToInt16(1));
			this._frmpay_1.Location = new System.Drawing.Point(4, 215);
			this._frmpay_1.Name = "_frmpay_1";
			this._frmpay_1.Padding = new System.Windows.Forms.Padding(0);
			this._frmpay_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._frmpay_1.Size = new System.Drawing.Size(351, 131);
			this._frmpay_1.TabIndex = 51;
			this._frmpay_1.TabStop = false;
			//
			//Label17
			//
			this.Label17.AutoSize = true;
			this.Label17.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label17.Location = new System.Drawing.Point(12, 93);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(44, 15);
			this.Label17.TabIndex = 73;
			this.Label17.Text = "BAYAR";
			//
			//Label16
			//
			this.Label16.AutoSize = true;
			this.Label16.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label16.Location = new System.Drawing.Point(12, 60);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(41, 15);
			this.Label16.TabIndex = 72;
			this.Label16.Text = "NAMA";
			//
			//Label15
			//
			this.Label15.AutoSize = true;
			this.Label15.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label15.Location = new System.Drawing.Point(12, 28);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(66, 15);
			this.Label15.TabIndex = 71;
			this.Label15.Text = "NO KARTU";
			//
			//txtsaldo_point
			//
			this.txtsaldo_point.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.txtsaldo_point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtsaldo_point.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtsaldo_point.Location = new System.Drawing.Point(302, 13);
			this.txtsaldo_point.Name = "txtsaldo_point";
			this.txtsaldo_point.Size = new System.Drawing.Size(39, 22);
			this.txtsaldo_point.TabIndex = 70;
			//
			//txtcard_no
			//
			this.txtcard_no.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.txtcard_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtcard_no.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtcard_no.Location = new System.Drawing.Point(92, 15);
			this.txtcard_no.Name = "txtcard_no";
			this.txtcard_no.Size = new System.Drawing.Size(101, 22);
			this.txtcard_no.TabIndex = 68;
			//
			//txttukar_point
			//
			this.txttukar_point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txttukar_point.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txttukar_point.Location = new System.Drawing.Point(92, 87);
			this.txttukar_point.Name = "txttukar_point";
			this.txttukar_point.Size = new System.Drawing.Size(101, 22);
			this.txttukar_point.TabIndex = 67;
			//
			//txtpoint
			//
			this.txtpoint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtpoint.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtpoint.Location = new System.Drawing.Point(92, 49);
			this.txtpoint.Name = "txtpoint";
			this.txtpoint.Size = new System.Drawing.Size(101, 22);
			this.txtpoint.TabIndex = 66;
			//
			//lblmsg
			//
			this.lblmsg.BackColor = System.Drawing.Color.Red;
			this.lblmsg.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblmsg.Font = new System.Drawing.Font("Arial", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblmsg.ForeColor = System.Drawing.Color.Yellow;
			this.lblmsg.Location = new System.Drawing.Point(25, 50);
			this.lblmsg.Name = "lblmsg";
			this.lblmsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblmsg.Size = new System.Drawing.Size(224, 26);
			this.lblmsg.TabIndex = 50;
			this.lblmsg.Text = "PAYMENT TYPES";
			this.lblmsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			//
			//_btnNum_3
			//
			this._btnNum_3.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_3.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_3.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNum.SetIndex(this._btnNum_3, System.Convert.ToInt16(3));
			this._btnNum_3.Location = new System.Drawing.Point(140, 140);
			this._btnNum_3.Name = "_btnNum_3";
			this._btnNum_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_3.Size = new System.Drawing.Size(65, 65);
			this._btnNum_3.TabIndex = 37;
			this._btnNum_3.TabStop = false;
			this._btnNum_3.Text = "3";
			this._btnNum_3.UseVisualStyleBackColor = false;
			//
			//btnNum
			//
			//
			//_btnNum_4
			//
			this._btnNum_4.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_4.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_4.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_4.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNum.SetIndex(this._btnNum_4, System.Convert.ToInt16(4));
			this._btnNum_4.Location = new System.Drawing.Point(10, 75);
			this._btnNum_4.Name = "_btnNum_4";
			this._btnNum_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_4.Size = new System.Drawing.Size(65, 65);
			this._btnNum_4.TabIndex = 36;
			this._btnNum_4.TabStop = false;
			this._btnNum_4.Text = "4";
			this._btnNum_4.UseVisualStyleBackColor = false;
			//
			//_btnNum_5
			//
			this._btnNum_5.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_5.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_5.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_5.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNum.SetIndex(this._btnNum_5, System.Convert.ToInt16(5));
			this._btnNum_5.Location = new System.Drawing.Point(75, 75);
			this._btnNum_5.Name = "_btnNum_5";
			this._btnNum_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_5.Size = new System.Drawing.Size(65, 65);
			this._btnNum_5.TabIndex = 35;
			this._btnNum_5.TabStop = false;
			this._btnNum_5.Text = "5";
			this._btnNum_5.UseVisualStyleBackColor = false;
			//
			//_btnNum_6
			//
			this._btnNum_6.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_6.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_6.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNum.SetIndex(this._btnNum_6, System.Convert.ToInt16(6));
			this._btnNum_6.Location = new System.Drawing.Point(140, 75);
			this._btnNum_6.Name = "_btnNum_6";
			this._btnNum_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_6.Size = new System.Drawing.Size(65, 65);
			this._btnNum_6.TabIndex = 34;
			this._btnNum_6.TabStop = false;
			this._btnNum_6.Text = "6";
			this._btnNum_6.UseVisualStyleBackColor = false;
			//
			//_btnNum_7
			//
			this._btnNum_7.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_7.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_7.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_7.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNum.SetIndex(this._btnNum_7, System.Convert.ToInt16(7));
			this._btnNum_7.Location = new System.Drawing.Point(10, 10);
			this._btnNum_7.Name = "_btnNum_7";
			this._btnNum_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_7.Size = new System.Drawing.Size(65, 65);
			this._btnNum_7.TabIndex = 33;
			this._btnNum_7.TabStop = false;
			this._btnNum_7.Text = "7";
			this._btnNum_7.UseVisualStyleBackColor = false;
			//
			//_btnNum_8
			//
			this._btnNum_8.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_8.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_8.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_8.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNum.SetIndex(this._btnNum_8, System.Convert.ToInt16(8));
			this._btnNum_8.Location = new System.Drawing.Point(75, 10);
			this._btnNum_8.Name = "_btnNum_8";
			this._btnNum_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_8.Size = new System.Drawing.Size(65, 65);
			this._btnNum_8.TabIndex = 32;
			this._btnNum_8.TabStop = false;
			this._btnNum_8.Text = "8";
			this._btnNum_8.UseVisualStyleBackColor = false;
			//
			//_btnNum_9
			//
			this._btnNum_9.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_9.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_9.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_9.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnNum.SetIndex(this._btnNum_9, System.Convert.ToInt16(9));
			this._btnNum_9.Location = new System.Drawing.Point(140, 10);
			this._btnNum_9.Name = "_btnNum_9";
			this._btnNum_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_9.Size = new System.Drawing.Size(65, 65);
			this._btnNum_9.TabIndex = 31;
			this._btnNum_9.TabStop = false;
			this._btnNum_9.Text = "9";
			this._btnNum_9.UseVisualStyleBackColor = false;
			//
			//_cmdpay_0
			//
			this._cmdpay_0.BackColor = System.Drawing.SystemColors.Control;
			this._cmdpay_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdpay_0.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdpay_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdpay_0.Image = (System.Drawing.Image) (resources.GetObject("_cmdpay_0.Image"));
			this.cmdpay.SetIndex(this._cmdpay_0, System.Convert.ToInt16(0));
			this._cmdpay_0.Location = new System.Drawing.Point(5, 139);
			this._cmdpay_0.Name = "_cmdpay_0";
			this._cmdpay_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdpay_0.Size = new System.Drawing.Size(76, 56);
			this._cmdpay_0.TabIndex = 46;
			this._cmdpay_0.TabStop = false;
			this._cmdpay_0.Text = "CLOSE";
			this._cmdpay_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdpay_0.UseVisualStyleBackColor = false;
			//
			//_cmdpay_2
			//
			this._cmdpay_2.BackColor = System.Drawing.SystemColors.Control;
			this._cmdpay_2.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdpay_2.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdpay_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdpay_2.Image = (System.Drawing.Image) (resources.GetObject("_cmdpay_2.Image"));
			this.cmdpay.SetIndex(this._cmdpay_2, System.Convert.ToInt16(2));
			this._cmdpay_2.Location = new System.Drawing.Point(5, 74);
			this._cmdpay_2.Name = "_cmdpay_2";
			this._cmdpay_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdpay_2.Size = new System.Drawing.Size(76, 56);
			this._cmdpay_2.TabIndex = 47;
			this._cmdpay_2.TabStop = false;
			this._cmdpay_2.Text = "DOWN";
			this._cmdpay_2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdpay_2.UseVisualStyleBackColor = false;
			//
			//_cmdpay_1
			//
			this._cmdpay_1.BackColor = System.Drawing.SystemColors.Control;
			this._cmdpay_1.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdpay_1.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdpay_1.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdpay_1.Image = (System.Drawing.Image) (resources.GetObject("_cmdpay_1.Image"));
			this.cmdpay.SetIndex(this._cmdpay_1, System.Convert.ToInt16(1));
			this._cmdpay_1.Location = new System.Drawing.Point(5, 9);
			this._cmdpay_1.Name = "_cmdpay_1";
			this._cmdpay_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdpay_1.Size = new System.Drawing.Size(76, 56);
			this._cmdpay_1.TabIndex = 45;
			this._cmdpay_1.TabStop = false;
			this._cmdpay_1.Text = "UP";
			this._cmdpay_1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdpay_1.UseVisualStyleBackColor = false;
			//
			//vno_trans
			//
			this.vno_trans.BackColor = System.Drawing.SystemColors.Control;
			this.vno_trans.Cursor = System.Windows.Forms.Cursors.Default;
			this.vno_trans.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vno_trans.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vno_trans.Location = new System.Drawing.Point(94, 445);
			this.vno_trans.Name = "vno_trans";
			this.vno_trans.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vno_trans.Size = new System.Drawing.Size(126, 21);
			this.vno_trans.TabIndex = 53;
			this.vno_trans.Visible = false;
			//
			//Label6
			//
			this.Label6.BackColor = System.Drawing.Color.Red;
			this.Label6.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label6.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label6.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label6.Location = new System.Drawing.Point(321, 132);
			this.Label6.Name = "Label6";
			this.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label6.Size = new System.Drawing.Size(31, 76);
			this.Label6.TabIndex = 59;
			//
			//label2
			//
			this.Label2.BackColor = System.Drawing.SystemColors.Control;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label2.Location = new System.Drawing.Point(179, 470);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(41, 21);
			this.Label2.TabIndex = 55;
			this.Label2.Visible = false;
			//
			//lblsisa
			//
			this.lblsisa.BackColor = System.Drawing.Color.Black;
			this.lblsisa.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblsisa.Font = new System.Drawing.Font("Arial", (float) (18.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblsisa.ForeColor = System.Drawing.Color.Yellow;
			this.lblsisa.Location = new System.Drawing.Point(146, 75);
			this.lblsisa.Name = "lblsisa";
			this.lblsisa.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblsisa.Size = new System.Drawing.Size(186, 26);
			this.lblsisa.TabIndex = 15;
			this.lblsisa.Text = "999,999,999";
			this.lblsisa.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//Label3
			//
			this.Label3.BackColor = System.Drawing.Color.Black;
			this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label3.Font = new System.Drawing.Font("Arial", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.Color.Yellow;
			this.Label3.Location = new System.Drawing.Point(5, 40);
			this.Label3.Name = "Label3";
			this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label3.Size = new System.Drawing.Size(141, 26);
			this.Label3.TabIndex = 16;
			this.Label3.Text = "BAYAR    : Rp";
			//
			//lblbayar
			//
			this.lblbayar.BackColor = System.Drawing.Color.Black;
			this.lblbayar.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblbayar.Font = new System.Drawing.Font("Arial", (float) (18.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblbayar.ForeColor = System.Drawing.Color.Yellow;
			this.lblbayar.Location = new System.Drawing.Point(146, 40);
			this.lblbayar.Name = "lblbayar";
			this.lblbayar.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblbayar.Size = new System.Drawing.Size(186, 26);
			this.lblbayar.TabIndex = 17;
			this.lblbayar.Text = "999,999,999";
			this.lblbayar.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//_frmpay_3
			//
			this._frmpay_3.BackColor = System.Drawing.Color.White;
			this._frmpay_3.Controls.Add(this.txtsaldo_point);
			this._frmpay_3.Controls.Add(this.Label10);
			this._frmpay_3.Controls.Add(this.txttukar_point);
			this._frmpay_3.Controls.Add(this.Label9);
			this._frmpay_3.Controls.Add(this.txtpoint);
			this._frmpay_3.Controls.Add(this.Label7);
			this._frmpay_3.Controls.Add(this.txtcard_no);
			this._frmpay_3.Controls.Add(this.txtharga_point);
			this._frmpay_3.Controls.Add(this.Label8);
			this._frmpay_3.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._frmpay_3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.frmpay.SetIndex(this._frmpay_3, System.Convert.ToInt16(3));
			this._frmpay_3.Location = new System.Drawing.Point(4, 215);
			this._frmpay_3.Name = "_frmpay_3";
			this._frmpay_3.Padding = new System.Windows.Forms.Padding(0);
			this._frmpay_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._frmpay_3.Size = new System.Drawing.Size(351, 141);
			this._frmpay_3.TabIndex = 56;
			this._frmpay_3.TabStop = false;
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label10.Location = new System.Drawing.Point(199, 18);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(85, 15);
			this.Label10.TabIndex = 72;
			this.Label10.Text = "SALDO POINT";
			//
			//Label9
			//
			this.Label9.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label9.Location = new System.Drawing.Point(6, 82);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(92, 36);
			this.Label9.TabIndex = 71;
			this.Label9.Text = "POINT DITUKARKAN";
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label7.Location = new System.Drawing.Point(6, 20);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(66, 15);
			this.Label7.TabIndex = 69;
			this.Label7.Text = "NO KARTU";
			//
			//txtharga_point
			//
			this.txtharga_point.AcceptsReturn = true;
			this.txtharga_point.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.txtharga_point.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtharga_point.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtharga_point.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtharga_point.ForeColor = System.Drawing.SystemColors.WindowText;
			this.txtharga_point.Location = new System.Drawing.Point(285, 46);
			this.txtharga_point.MaxLength = 0;
			this.txtharga_point.Name = "txtharga_point";
			this.txtharga_point.ReadOnly = true;
			this.txtharga_point.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.txtharga_point.Size = new System.Drawing.Size(56, 22);
			this.txtharga_point.TabIndex = 28;
			this.txtharga_point.TabStop = false;
			this.txtharga_point.Text = "1000";
			this.txtharga_point.Visible = false;
			//
			//Label8
			//
			this.Label8.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label8.Location = new System.Drawing.Point(6, 43);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(92, 36);
			this.Label8.TabIndex = 70;
			this.Label8.Text = "RUPIAH DITUKARKAN";
			//
			//Frame3
			//
			this.Frame3.BackColor = System.Drawing.Color.White;
			this.Frame3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Frame3.Controls.Add(this._cmdpay_2);
			this.Frame3.Controls.Add(this._cmdpay_0);
			this.Frame3.Controls.Add(this._cmdpay_1);
			this.Frame3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Frame3.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame3.Location = new System.Drawing.Point(272, 5);
			this.Frame3.Name = "Frame3";
			this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame3.Size = new System.Drawing.Size(88, 208);
			this.Frame3.TabIndex = 58;
			//
			//lbltotal
			//
			this.lbltotal.BackColor = System.Drawing.Color.Black;
			this.lbltotal.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbltotal.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lbltotal.ForeColor = System.Drawing.Color.Yellow;
			this.lbltotal.Location = new System.Drawing.Point(146, 5);
			this.lbltotal.Name = "lbltotal";
			this.lbltotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbltotal.Size = new System.Drawing.Size(186, 36);
			this.lbltotal.TabIndex = 19;
			this.lbltotal.Text = "999,999,999";
			this.lbltotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//Label5
			//
			this.Label5.BackColor = System.Drawing.Color.Black;
			this.Label5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label5.Font = new System.Drawing.Font("Arial", (float) (18.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.ForeColor = System.Drawing.Color.Yellow;
			this.Label5.Location = new System.Drawing.Point(0, 5);
			this.Label5.Name = "Label5";
			this.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label5.Size = new System.Drawing.Size(141, 36);
			this.Label5.TabIndex = 18;
			this.Label5.Text = "TOTAL : Rp";
			//
			//Frame2
			//
			this.Frame2.BackColor = System.Drawing.Color.White;
			this.Frame2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
			this.Frame2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Frame2.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame2.Location = new System.Drawing.Point(366, 138);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(346, 216);
			this.Frame2.TabIndex = 57;
			//
			//Frame1
			//
			this.Frame1.BackColor = System.Drawing.Color.Black;
			this.Frame1.Controls.Add(this.lbltotal);
			this.Frame1.Controls.Add(this.Label5);
			this.Frame1.Controls.Add(this.lblbayar);
			this.Frame1.Controls.Add(this.Label3);
			this.Frame1.Controls.Add(this.lblsisa);
			this.Frame1.Controls.Add(this.Label4);
			this.Frame1.Controls.Add(this.Label1);
			this.Frame1.Controls.Add(this.ShapeContainer1);
			this.Frame1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Frame1.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(367, 5);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(336, 106);
			this.Frame1.TabIndex = 54;
			//
			//ShapeContainer1
			//
			this.ShapeContainer1.Location = new System.Drawing.Point(0, 0);
			this.ShapeContainer1.Margin = new System.Windows.Forms.Padding(0);
			this.ShapeContainer1.Name = "ShapeContainer1";
			this.ShapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {this.Line1});
			this.ShapeContainer1.Size = new System.Drawing.Size(336, 106);
			this.ShapeContainer1.TabIndex = 21;
			this.ShapeContainer1.TabStop = false;
			//
			//Line1
			//
			this.Line1.BorderColor = System.Drawing.Color.Red;
			this.Line1.BorderWidth = 4;
			this.Line1.Name = "Line1";
			this.Line1.X1 = 160;
			this.Line1.X2 = 325;
			this.Line1.Y1 = 70;
			this.Line1.Y2 = 70;
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(4, 5);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView1.Size = new System.Drawing.Size(264, 208);
			this.DataGridView1.TabIndex = 60;
			//
			//DataGridView2
			//
			this.DataGridView2.AllowUserToAddRows = false;
			this.DataGridView2.AllowUserToDeleteRows = false;
			this.DataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
			this.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView2.Location = new System.Drawing.Point(4, 362);
			this.DataGridView2.Name = "DataGridView2";
			this.DataGridView2.ReadOnly = true;
			this.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView2.Size = new System.Drawing.Size(706, 136);
			this.DataGridView2.TabIndex = 61;
			//
			//Timer1
			//
			//
			//frmPayment
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (14.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(715, 509);
			this.ControlBox = false;
			this.Controls.Add(this.DataGridView2);
			this.Controls.Add(this._frmpay_3);
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this._frmpay_0);
			this.Controls.Add(this._frmpay_2);
			this.Controls.Add(this._frmpay_1);
			this.Controls.Add(this.lblmsg);
			this.Controls.Add(this.vno_trans);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Frame3);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.vstatus);
			this.Controls.Add(this.vpay);
			this.Controls.Add(this.Label6);
			this.Font = new System.Drawing.Font("Arial", (float) (8.0F));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.KeyPreview = true;
			this.MaximumSize = new System.Drawing.Size(731, 548);
			this.MinimumSize = new System.Drawing.Size(731, 548);
			this.Name = "frmPayment";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PAYMENT";
			this._frmpay_2.ResumeLayout(false);
			this._frmpay_2.PerformLayout();
			this._frmpay_0.ResumeLayout(false);
			this._frmpay_0.PerformLayout();
			this._frmpay_1.ResumeLayout(false);
			this._frmpay_1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.btnNum).EndInit();
			((System.ComponentModel.ISupportInitialize) this.cmdpay).EndInit();
			this._frmpay_3.ResumeLayout(false);
			this._frmpay_3.PerformLayout();
			this.Frame3.ResumeLayout(false);
			this.Frame2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.frmpay).EndInit();
			this.Frame1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			((System.ComponentModel.ISupportInitialize) this.DataGridView2).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		internal System.Windows.Forms.TextBox vpay;
		internal System.Windows.Forms.TextBox vstatus;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.Button _btnNum_12;
		public Microsoft.VisualBasic.Compatibility.VB6.ButtonArray btnNum;
		public System.Windows.Forms.Button _btnNum_10;
		public System.Windows.Forms.Button _btnNum_0;
		public System.Windows.Forms.Button _btnNum_1;
		public System.Windows.Forms.Button cmdvoc;
		public System.Windows.Forms.Label Label4;
		public System.Windows.Forms.GroupBox _frmpay_2;
		public Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray frmpay;
		public System.Windows.Forms.Label Label1;
		public System.Windows.Forms.Button _btnNum_11;
		public System.Windows.Forms.GroupBox _frmpay_0;
		public System.Windows.Forms.Button _btnNum_2;
		public System.Windows.Forms.GroupBox _frmpay_1;
		public System.Windows.Forms.Label lblmsg;
		public System.Windows.Forms.Button _btnNum_3;
		public System.Windows.Forms.Button _btnNum_4;
		public System.Windows.Forms.Button _btnNum_5;
		public System.Windows.Forms.Button _btnNum_6;
		public System.Windows.Forms.Button _btnNum_7;
		public System.Windows.Forms.Button _btnNum_8;
		public System.Windows.Forms.Button _btnNum_9;
		public Microsoft.VisualBasic.Compatibility.VB6.ButtonArray cmdpay;
		public System.Windows.Forms.Button _cmdpay_0;
		public System.Windows.Forms.Button _cmdpay_2;
		public System.Windows.Forms.Button _cmdpay_1;
		public System.Windows.Forms.Label vno_trans;
		public System.Windows.Forms.Label Label6;
		public System.Windows.Forms.Label Label2;
		public System.Windows.Forms.Label lblsisa;
		public System.Windows.Forms.Label Label3;
		public System.Windows.Forms.Label lblbayar;
		public System.Windows.Forms.GroupBox _frmpay_3;
		public System.Windows.Forms.TextBox txtharga_point;
		public System.Windows.Forms.Panel Frame3;
		public System.Windows.Forms.Label lbltotal;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Panel Frame2;
		public System.Windows.Forms.Panel Frame1;
		public Microsoft.VisualBasic.PowerPacks.ShapeContainer ShapeContainer1;
		public Microsoft.VisualBasic.PowerPacks.LineShape Line1;
		internal System.Windows.Forms.TextBox txtno_voc;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.TextBox txtcash;
		internal System.Windows.Forms.TextBox txtcredit;
		internal System.Windows.Forms.TextBox txtno_kartu;
		internal System.Windows.Forms.TextBox txtnama;
		internal System.Windows.Forms.TextBox txtvoucher;
		internal System.Windows.Forms.TextBox txtpoint;
		internal System.Windows.Forms.TextBox txttukar_point;
		internal System.Windows.Forms.TextBox txtcard_no;
		internal System.Windows.Forms.TextBox txtkembali;
		internal System.Windows.Forms.TextBox txtsaldo_point;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.Label Label16;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.DataGridView DataGridView2;
		internal System.IO.Ports.SerialPort SerialPort1;
		internal Timer Timer1;
	}
	
}
