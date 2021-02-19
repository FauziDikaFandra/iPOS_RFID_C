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
		public partial class frmPaymentSelf : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmPaymentSelf_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentSelf));
			this.vpay = new System.Windows.Forms.TextBox();
			this.vstatus = new System.Windows.Forms.TextBox();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this._btnNum_13 = new System.Windows.Forms.Button();
			this._btnNum_13.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_12 = new System.Windows.Forms.Button();
			this._btnNum_12.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_0 = new System.Windows.Forms.Button();
			this._btnNum_0.Click += new System.EventHandler(this._btnNum_0_Click);
			this._btnNum_1 = new System.Windows.Forms.Button();
			this._btnNum_1.Click += new System.EventHandler(this._btnNum_0_Click);
			this.txtno_kartu = new System.Windows.Forms.TextBox();
			this.txtno_kartu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtno_kartu_KeyPress);
			this.txtno_kartu.TextChanged += new System.EventHandler(this.txtno_kartu_TextChanged);
			this.txtno_kartu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtno_kartu_KeyDown);
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
			this.Frame3 = new System.Windows.Forms.Panel();
			this.vno_trans = new System.Windows.Forms.Label();
			this.lbltotal = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Frame2 = new System.Windows.Forms.Panel();
			this._cmdpay_0 = new System.Windows.Forms.Button();
			this._cmdpay_0.Click += new System.EventHandler(this._cmdpay_0_Click);
			this.frmpay = new Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray(this.components);
			this.Frame1 = new System.Windows.Forms.Panel();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this._btnNum_11 = new System.Windows.Forms.Button();
			this._btnNum_11.Click += new System.EventHandler(this._btnNum_0_Click);
			this.lblPleaseWait = new System.Windows.Forms.Label();
			this.lblCancel = new System.Windows.Forms.Label();
			this.lblCancel.Click += new System.EventHandler(this.Label4_Click);
			this.lblPayTypes = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.rbAnother = new System.Windows.Forms.RadioButton();
			this.rbAnother.CheckedChanged += new System.EventHandler(this.rbAnother_CheckedChanged);
			this.rbGopay = new System.Windows.Forms.RadioButton();
			this.rbGopay.CheckedChanged += new System.EventHandler(this.rbGopay_CheckedChanged);
			this.rbMaster = new System.Windows.Forms.RadioButton();
			this.rbMaster.CheckedChanged += new System.EventHandler(this.rbMaster_CheckedChanged);
			this.rbVisa = new System.Windows.Forms.RadioButton();
			this.rbVisa.CheckedChanged += new System.EventHandler(this.rbVisa_CheckedChanged);
			this.rbDebitBCA = new System.Windows.Forms.RadioButton();
			this.rbDebitBCA.CheckedChanged += new System.EventHandler(this.rbDebitBCA_CheckedChanged);
			this.rbBcaCard = new System.Windows.Forms.RadioButton();
			this.rbBcaCard.CheckedChanged += new System.EventHandler(this.rbBcaCard_CheckedChanged);
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
			this.SerialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			this.Panel1 = new System.Windows.Forms.Panel();
			this.Frame3.SuspendLayout();
			this.Frame2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.frmpay).BeginInit();
			this.Frame1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.SuspendLayout();
			//
			//vpay
			//
			this.vpay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vpay.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vpay.Location = new System.Drawing.Point(-25, -1);
			this.vpay.Name = "vpay";
			this.vpay.Size = new System.Drawing.Size(108, 26);
			this.vpay.TabIndex = 34;
			this.vpay.Visible = false;
			//
			//vstatus
			//
			this.vstatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.vstatus.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vstatus.Location = new System.Drawing.Point(-25, -5);
			this.vstatus.Name = "vstatus";
			this.vstatus.Size = new System.Drawing.Size(108, 26);
			this.vstatus.TabIndex = 35;
			this.vstatus.Visible = false;
			//
			//_btnNum_13
			//
			this._btnNum_13.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_13.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_13.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_13.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_13.Location = new System.Drawing.Point(264, 4);
			this._btnNum_13.Name = "_btnNum_13";
			this._btnNum_13.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_13.Size = new System.Drawing.Size(65, 65);
			this._btnNum_13.TabIndex = 43;
			this._btnNum_13.TabStop = false;
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
			this._btnNum_12.Location = new System.Drawing.Point(199, 4);
			this._btnNum_12.Name = "_btnNum_12";
			this._btnNum_12.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_12.Size = new System.Drawing.Size(65, 65);
			this._btnNum_12.TabIndex = 42;
			this._btnNum_12.TabStop = false;
			this._btnNum_12.Tag = "12";
			this._btnNum_12.Text = "<<";
			this._btnNum_12.UseVisualStyleBackColor = false;
			//
			//_btnNum_0
			//
			this._btnNum_0.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_0.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_0.Location = new System.Drawing.Point(199, 134);
			this._btnNum_0.Name = "_btnNum_0";
			this._btnNum_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_0.Size = new System.Drawing.Size(130, 65);
			this._btnNum_0.TabIndex = 40;
			this._btnNum_0.TabStop = false;
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
			this._btnNum_1.Location = new System.Drawing.Point(4, 134);
			this._btnNum_1.Name = "_btnNum_1";
			this._btnNum_1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_1.Size = new System.Drawing.Size(65, 65);
			this._btnNum_1.TabIndex = 39;
			this._btnNum_1.TabStop = false;
			this._btnNum_1.Tag = "1";
			this._btnNum_1.Text = "1";
			this._btnNum_1.UseVisualStyleBackColor = false;
			//
			//txtno_kartu
			//
			this.txtno_kartu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtno_kartu.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtno_kartu.Location = new System.Drawing.Point(21, 18);
			this.txtno_kartu.MaxLength = 16;
			this.txtno_kartu.Name = "txtno_kartu";
			this.txtno_kartu.Size = new System.Drawing.Size(198, 25);
			this.txtno_kartu.TabIndex = 63;
			//
			//_btnNum_2
			//
			this._btnNum_2.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_2.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_2.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_2.ForeColor = System.Drawing.SystemColors.ControlText;
			this._btnNum_2.Location = new System.Drawing.Point(69, 134);
			this._btnNum_2.Name = "_btnNum_2";
			this._btnNum_2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_2.Size = new System.Drawing.Size(65, 65);
			this._btnNum_2.TabIndex = 38;
			this._btnNum_2.TabStop = false;
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
			this._btnNum_3.Location = new System.Drawing.Point(134, 134);
			this._btnNum_3.Name = "_btnNum_3";
			this._btnNum_3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_3.Size = new System.Drawing.Size(65, 65);
			this._btnNum_3.TabIndex = 37;
			this._btnNum_3.TabStop = false;
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
			this._btnNum_4.Location = new System.Drawing.Point(4, 69);
			this._btnNum_4.Name = "_btnNum_4";
			this._btnNum_4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_4.Size = new System.Drawing.Size(65, 65);
			this._btnNum_4.TabIndex = 36;
			this._btnNum_4.TabStop = false;
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
			this._btnNum_5.Location = new System.Drawing.Point(69, 69);
			this._btnNum_5.Name = "_btnNum_5";
			this._btnNum_5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_5.Size = new System.Drawing.Size(65, 65);
			this._btnNum_5.TabIndex = 35;
			this._btnNum_5.TabStop = false;
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
			this._btnNum_6.Location = new System.Drawing.Point(134, 69);
			this._btnNum_6.Name = "_btnNum_6";
			this._btnNum_6.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_6.Size = new System.Drawing.Size(65, 65);
			this._btnNum_6.TabIndex = 34;
			this._btnNum_6.TabStop = false;
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
			this._btnNum_7.Location = new System.Drawing.Point(4, 4);
			this._btnNum_7.Name = "_btnNum_7";
			this._btnNum_7.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_7.Size = new System.Drawing.Size(65, 65);
			this._btnNum_7.TabIndex = 33;
			this._btnNum_7.TabStop = false;
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
			this._btnNum_8.Location = new System.Drawing.Point(69, 4);
			this._btnNum_8.Name = "_btnNum_8";
			this._btnNum_8.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_8.Size = new System.Drawing.Size(65, 65);
			this._btnNum_8.TabIndex = 32;
			this._btnNum_8.TabStop = false;
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
			this._btnNum_9.Location = new System.Drawing.Point(134, 4);
			this._btnNum_9.Name = "_btnNum_9";
			this._btnNum_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_9.Size = new System.Drawing.Size(65, 65);
			this._btnNum_9.TabIndex = 31;
			this._btnNum_9.TabStop = false;
			this._btnNum_9.Tag = "9";
			this._btnNum_9.Text = "9";
			this._btnNum_9.UseVisualStyleBackColor = false;
			//
			//Frame3
			//
			this.Frame3.BackColor = System.Drawing.Color.White;
			this.Frame3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Frame3.Controls.Add(this.vpay);
			this.Frame3.Controls.Add(this.vstatus);
			this.Frame3.Controls.Add(this.vno_trans);
			this.Frame3.Cursor = System.Windows.Forms.Cursors.Default;
			this.Frame3.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame3.Location = new System.Drawing.Point(229, 69);
			this.Frame3.Name = "Frame3";
			this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame3.Size = new System.Drawing.Size(84, 64);
			this.Frame3.TabIndex = 58;
			//
			//vno_trans
			//
			this.vno_trans.BackColor = System.Drawing.SystemColors.Control;
			this.vno_trans.Cursor = System.Windows.Forms.Cursors.Default;
			this.vno_trans.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.vno_trans.ForeColor = System.Drawing.SystemColors.ControlText;
			this.vno_trans.Location = new System.Drawing.Point(-43, -5);
			this.vno_trans.Name = "vno_trans";
			this.vno_trans.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.vno_trans.Size = new System.Drawing.Size(126, 21);
			this.vno_trans.TabIndex = 58;
			this.vno_trans.Visible = false;
			//
			//lbltotal
			//
			this.lbltotal.BackColor = System.Drawing.Color.Black;
			this.lbltotal.Cursor = System.Windows.Forms.Cursors.Default;
			this.lbltotal.Font = new System.Drawing.Font("Arial", (float) (21.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lbltotal.ForeColor = System.Drawing.Color.Yellow;
			this.lbltotal.Location = new System.Drawing.Point(153, 13);
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
			this.Label5.Location = new System.Drawing.Point(6, 15);
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
			this.Frame2.Controls.Add(this._btnNum_13);
			this.Frame2.Controls.Add(this._btnNum_12);
			this.Frame2.Controls.Add(this._btnNum_0);
			this.Frame2.Controls.Add(this._btnNum_1);
			this.Frame2.Controls.Add(this._btnNum_2);
			this.Frame2.Controls.Add(this._cmdpay_0);
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
			this.Frame2.Location = new System.Drawing.Point(401, 78);
			this.Frame2.Name = "Frame2";
			this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame2.Size = new System.Drawing.Size(339, 206);
			this.Frame2.TabIndex = 57;
			//
			//_cmdpay_0
			//
			this._cmdpay_0.BackColor = System.Drawing.SystemColors.Control;
			this._cmdpay_0.Cursor = System.Windows.Forms.Cursors.Default;
			this._cmdpay_0.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._cmdpay_0.ForeColor = System.Drawing.SystemColors.ControlText;
			this._cmdpay_0.Image = (System.Drawing.Image) (resources.GetObject("_cmdpay_0.Image"));
			this._cmdpay_0.Location = new System.Drawing.Point(199, 69);
			this._cmdpay_0.Name = "_cmdpay_0";
			this._cmdpay_0.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._cmdpay_0.Size = new System.Drawing.Size(130, 66);
			this._cmdpay_0.TabIndex = 46;
			this._cmdpay_0.TabStop = false;
			this._cmdpay_0.Text = "BACK";
			this._cmdpay_0.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this._cmdpay_0.UseVisualStyleBackColor = false;
			//
			//Frame1
			//
			this.Frame1.BackColor = System.Drawing.Color.Black;
			this.Frame1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Frame1.Controls.Add(this.GroupBox2);
			this.Frame1.Controls.Add(this.lblPayTypes);
			this.Frame1.Controls.Add(this.GroupBox1);
			this.Frame1.Controls.Add(this.Label2);
			this.Frame1.Controls.Add(this.Label1);
			this.Frame1.Controls.Add(this.Frame3);
			this.Frame1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Frame1.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(4, 6);
			this.Frame1.Name = "Frame1";
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(391, 286);
			this.Frame1.TabIndex = 54;
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this._btnNum_11);
			this.GroupBox2.Controls.Add(this.txtno_kartu);
			this.GroupBox2.Controls.Add(this.lblPleaseWait);
			this.GroupBox2.Controls.Add(this.lblCancel);
			this.GroupBox2.Location = new System.Drawing.Point(13, 206);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(357, 72);
			this.GroupBox2.TabIndex = 81;
			this.GroupBox2.TabStop = false;
			//
			//_btnNum_11
			//
			this._btnNum_11.BackColor = System.Drawing.SystemColors.Control;
			this._btnNum_11.Cursor = System.Windows.Forms.Cursors.Default;
			this._btnNum_11.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this._btnNum_11.ForeColor = System.Drawing.SystemColors.ControlText;
			//this._btnNum_11.Image = global::My.resources.Resources.cash;
			this._btnNum_11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this._btnNum_11.Location = new System.Drawing.Point(244, 14);
			this._btnNum_11.Name = "_btnNum_11";
			this._btnNum_11.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this._btnNum_11.Size = new System.Drawing.Size(93, 51);
			this._btnNum_11.TabIndex = 41;
			this._btnNum_11.TabStop = false;
			this._btnNum_11.Tag = "11";
			this._btnNum_11.Text = "PAY";
			this._btnNum_11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this._btnNum_11.UseVisualStyleBackColor = false;
			//
			//lblPleaseWait
			//
			this.lblPleaseWait.AutoSize = true;
			this.lblPleaseWait.Font = new System.Drawing.Font("Arial", (float) (9.75F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblPleaseWait.ForeColor = System.Drawing.Color.Cornsilk;
			this.lblPleaseWait.Location = new System.Drawing.Point(18, 49);
			this.lblPleaseWait.Name = "lblPleaseWait";
			this.lblPleaseWait.Size = new System.Drawing.Size(95, 16);
			this.lblPleaseWait.TabIndex = 77;
			this.lblPleaseWait.Text = "Please Wait ...";
			//
			//lblCancel
			//
			this.lblCancel.AutoSize = true;
			this.lblCancel.Font = new System.Drawing.Font("Arial", (float) (9.75F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblCancel.ForeColor = System.Drawing.Color.Red;
			this.lblCancel.Location = new System.Drawing.Point(174, 49);
			this.lblCancel.Name = "lblCancel";
			this.lblCancel.Size = new System.Drawing.Size(50, 16);
			this.lblCancel.TabIndex = 78;
			this.lblCancel.Text = "Cancel";
			//
			//lblPayTypes
			//
			this.lblPayTypes.BackColor = System.Drawing.Color.Black;
			this.lblPayTypes.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblPayTypes.Font = new System.Drawing.Font("Arial", (float) (15.75F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblPayTypes.ForeColor = System.Drawing.Color.Blue;
			this.lblPayTypes.Location = new System.Drawing.Point(215, 15);
			this.lblPayTypes.Name = "lblPayTypes";
			this.lblPayTypes.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblPayTypes.Size = new System.Drawing.Size(173, 26);
			this.lblPayTypes.TabIndex = 80;
			this.lblPayTypes.Text = "BCA CARD";
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.rbAnother);
			this.GroupBox1.Controls.Add(this.rbGopay);
			this.GroupBox1.Controls.Add(this.rbMaster);
			this.GroupBox1.Controls.Add(this.rbVisa);
			this.GroupBox1.Controls.Add(this.rbDebitBCA);
			this.GroupBox1.Controls.Add(this.rbBcaCard);
			this.GroupBox1.Location = new System.Drawing.Point(13, 41);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(357, 166);
			this.GroupBox1.TabIndex = 79;
			this.GroupBox1.TabStop = false;
			//
			//rbAnother
			//
			this.rbAnother.Appearance = System.Windows.Forms.Appearance.Button;
			//this.rbAnother.BackgroundImage = global::My.resources.Resources.Other;
			this.rbAnother.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rbAnother.Location = new System.Drawing.Point(236, 91);
			this.rbAnother.Name = "rbAnother";
			this.rbAnother.Size = new System.Drawing.Size(101, 59);
			this.rbAnother.TabIndex = 85;
			this.rbAnother.Tag = "10";
			this.rbAnother.UseVisualStyleBackColor = true;
			//
			//rbGopay
			//
			this.rbGopay.Appearance = System.Windows.Forms.Appearance.Button;
			//this.rbGopay.BackgroundImage = global::My.resources.Resources.Gopayok;
			this.rbGopay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rbGopay.Location = new System.Drawing.Point(236, 19);
			this.rbGopay.Name = "rbGopay";
			this.rbGopay.Size = new System.Drawing.Size(101, 59);
			this.rbGopay.TabIndex = 84;
			this.rbGopay.Tag = "6";
			this.rbGopay.UseVisualStyleBackColor = true;
			//
			//rbMaster
			//
			this.rbMaster.Appearance = System.Windows.Forms.Appearance.Button;
			//this.rbMaster.BackgroundImage = global::My.resources.Resources.mastercard_1_82737;
			this.rbMaster.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rbMaster.Location = new System.Drawing.Point(129, 91);
			this.rbMaster.Name = "rbMaster";
			this.rbMaster.Size = new System.Drawing.Size(90, 59);
			this.rbMaster.TabIndex = 83;
			this.rbMaster.Tag = "17";
			this.rbMaster.UseVisualStyleBackColor = true;
			//
			//rbVisa
			//
			this.rbVisa.Appearance = System.Windows.Forms.Appearance.Button;
			//this.rbVisa.BackgroundImage = global::My.resources.Resources._1280px_Visa_svg;
			this.rbVisa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rbVisa.Location = new System.Drawing.Point(21, 91);
			this.rbVisa.Name = "rbVisa";
			this.rbVisa.Size = new System.Drawing.Size(90, 59);
			this.rbVisa.TabIndex = 82;
			this.rbVisa.Tag = "17";
			this.rbVisa.UseVisualStyleBackColor = true;
			//
			//rbDebitBCA
			//
			this.rbDebitBCA.Appearance = System.Windows.Forms.Appearance.Button;
			//this.rbDebitBCA.BackgroundImage = global::My.resources.Resources.debit_bca_green_logo_D8EE725387_seeklogo_com;
			this.rbDebitBCA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rbDebitBCA.Location = new System.Drawing.Point(129, 19);
			this.rbDebitBCA.Name = "rbDebitBCA";
			this.rbDebitBCA.Size = new System.Drawing.Size(90, 59);
			this.rbDebitBCA.TabIndex = 81;
			this.rbDebitBCA.Tag = "4";
			this.rbDebitBCA.UseVisualStyleBackColor = true;
			//
			//rbBcaCard
			//
			this.rbBcaCard.Appearance = System.Windows.Forms.Appearance.Button;
			//this.rbBcaCard.BackgroundImage = global::My.resources.Resources.cara_c;
			this.rbBcaCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.rbBcaCard.Location = new System.Drawing.Point(21, 19);
			this.rbBcaCard.Name = "rbBcaCard";
			this.rbBcaCard.Size = new System.Drawing.Size(90, 59);
			this.rbBcaCard.TabIndex = 80;
			this.rbBcaCard.Tag = "3";
			this.rbBcaCard.UseVisualStyleBackColor = true;
			//
			//label2
			//
			this.Label2.BackColor = System.Drawing.Color.Black;
			this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label2.Font = new System.Drawing.Font("Arial", (float) (18.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.Color.Yellow;
			this.Label2.Location = new System.Drawing.Point(8, 12);
			this.Label2.Name = "Label2";
			this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label2.Size = new System.Drawing.Size(212, 36);
			this.Label2.TabIndex = 76;
			this.Label2.Text = "Process Payment ";
			//
			//Label1
			//
			this.Label1.BackColor = System.Drawing.Color.Black;
			this.Label1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Label1.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Label1.Location = new System.Drawing.Point(8, 51);
			this.Label1.Name = "Label1";
			this.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Label1.Size = new System.Drawing.Size(326, 11);
			this.Label1.TabIndex = 20;
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.ComboBox1.Font = new System.Drawing.Font("Arial", (float) (11.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(90, 256);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(234, 25);
			this.ComboBox1.TabIndex = 75;
			//
			//Timer1
			//
			//
			//Panel1
			//
			this.Panel1.BackColor = System.Drawing.Color.Black;
			this.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Panel1.Controls.Add(this.lbltotal);
			this.Panel1.Controls.Add(this.Label5);
			this.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Panel1.Font = new System.Drawing.Font("Arial", (float) (8.0F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Panel1.Location = new System.Drawing.Point(401, 10);
			this.Panel1.Name = "Panel1";
			this.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Panel1.Size = new System.Drawing.Size(339, 58);
			this.Panel1.TabIndex = 80;
			//
			//frmPaymentSelf
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (14.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(746, 299);
			this.ControlBox = false;
			this.Controls.Add(this.Panel1);
			this.Controls.Add(this.Frame2);
			this.Controls.Add(this.Frame1);
			this.Controls.Add(this.ComboBox1);
			this.Font = new System.Drawing.Font("Arial", (float) (8.0F));
			this.ForeColor = System.Drawing.Color.Yellow;
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.KeyPreview = true;
			this.Name = "frmPaymentSelf";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.TopMost = true;
			this.Frame3.ResumeLayout(false);
			this.Frame3.PerformLayout();
			this.Frame2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.frmpay).EndInit();
			this.Frame1.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		internal System.Windows.Forms.TextBox vpay;
		internal System.Windows.Forms.TextBox vstatus;
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.Button _btnNum_13;
		public System.Windows.Forms.Button _btnNum_12;
		public System.Windows.Forms.Button _btnNum_0;
		public System.Windows.Forms.Button _btnNum_1;
		public Microsoft.VisualBasic.Compatibility.VB6.GroupBoxArray frmpay;
		public System.Windows.Forms.Button _btnNum_11;
		public System.Windows.Forms.Button _btnNum_2;
		public System.Windows.Forms.Button _btnNum_3;
		public System.Windows.Forms.Button _btnNum_4;
		public System.Windows.Forms.Button _btnNum_5;
		public System.Windows.Forms.Button _btnNum_6;
		public System.Windows.Forms.Button _btnNum_7;
		public System.Windows.Forms.Button _btnNum_8;
		public System.Windows.Forms.Button _btnNum_9;
		public System.Windows.Forms.Button _cmdpay_0;
		public System.Windows.Forms.Panel Frame3;
		public System.Windows.Forms.Label lbltotal;
		public System.Windows.Forms.Label Label5;
		public System.Windows.Forms.Panel Frame2;
		public System.Windows.Forms.Panel Frame1;
		internal System.Windows.Forms.TextBox txtno_kartu;
		public Label Label2;
		public Label vno_trans;
		internal ComboBox ComboBox1;
		public Label Label1;
		internal System.IO.Ports.SerialPort SerialPort1;
		internal Timer Timer1;
		internal Label lblPleaseWait;
		internal Label lblCancel;
		internal GroupBox GroupBox1;
		internal RadioButton rbVisa;
		internal RadioButton rbDebitBCA;
		internal RadioButton rbBcaCard;
		internal RadioButton rbMaster;
		internal RadioButton rbGopay;
		internal RadioButton rbAnother;
		public Panel Panel1;
		public Label lblPayTypes;
		internal GroupBox GroupBox2;
	}
	
}
