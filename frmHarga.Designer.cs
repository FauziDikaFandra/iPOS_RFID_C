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
	partial class frmHarga : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmHarga_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHarga));
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.CmdOk = new System.Windows.Forms.Button();
			this.CmdOk.Click += new System.EventHandler(this.Cmdok_Click);
			this.CmdCancel = new System.Windows.Forms.Button();
			this.CmdCancel.Click += new System.EventHandler(this.Cmdcancel_Click);
			this.cmdangka = new System.Windows.Forms.Button();
			this.cmdangka.Click += new System.EventHandler(this.cmdangka_Click);
			this.Frame1 = new System.Windows.Forms.GroupBox();
			this.txtprice = new System.Windows.Forms.TextBox();
			this.txtprice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtprice_KeyDown);
			this.txtprice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprice_KeyPress);
			this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
			this.Frame1.SuspendLayout();
			this.SuspendLayout();
			//
			//CmdOk
			//
			this.CmdOk.BackColor = System.Drawing.SystemColors.Control;
			this.CmdOk.Cursor = System.Windows.Forms.Cursors.Default;
			this.CmdOk.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.CmdOk.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdOk.Image = (System.Drawing.Image) (resources.GetObject("CmdOk.Image"));
			this.CmdOk.Location = new System.Drawing.Point(90, 73);
			this.CmdOk.Name = "CmdOk";
			this.CmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CmdOk.Size = new System.Drawing.Size(76, 48);
			this.CmdOk.TabIndex = 8;
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
			this.CmdCancel.Location = new System.Drawing.Point(170, 73);
			this.CmdCancel.Name = "CmdCancel";
			this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CmdCancel.Size = new System.Drawing.Size(76, 48);
			this.CmdCancel.TabIndex = 7;
			this.CmdCancel.Text = "CANCEL";
			this.CmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.CmdCancel.UseVisualStyleBackColor = false;
			//
			//cmdangka
			//
			this.cmdangka.BackColor = System.Drawing.SystemColors.Control;
			this.cmdangka.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdangka.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.cmdangka.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdangka.Image = (System.Drawing.Image) (resources.GetObject("cmdangka.Image"));
			this.cmdangka.Location = new System.Drawing.Point(10, 73);
			this.cmdangka.Name = "cmdangka";
			this.cmdangka.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdangka.Size = new System.Drawing.Size(76, 48);
			this.cmdangka.TabIndex = 6;
			this.cmdangka.Text = "&NUM";
			this.cmdangka.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdangka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdangka.UseVisualStyleBackColor = false;
			//
			//Frame1
			//
			this.Frame1.BackColor = System.Drawing.SystemColors.Control;
			this.Frame1.Controls.Add(this.txtprice);
			this.Frame1.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Frame1.Location = new System.Drawing.Point(0, 3);
			this.Frame1.Name = "Frame1";
			this.Frame1.Padding = new System.Windows.Forms.Padding(0);
			this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Frame1.Size = new System.Drawing.Size(256, 61);
			this.Frame1.TabIndex = 5;
			this.Frame1.TabStop = false;
			this.Frame1.Text = "SCAN BARCODE HARGA";
			//
			//txtprice
			//
			this.txtprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtprice.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtprice.Location = new System.Drawing.Point(12, 23);
			this.txtprice.Name = "txtprice";
			this.txtprice.Size = new System.Drawing.Size(233, 26);
			this.txtprice.TabIndex = 35;
			//
			//frmHarga
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (14.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 123);
			this.ControlBox = false;
			this.Controls.Add(this.CmdOk);
			this.Controls.Add(this.CmdCancel);
			this.Controls.Add(this.cmdangka);
			this.Controls.Add(this.Frame1);
			this.Font = new System.Drawing.Font("Arial", (float) (8.0F));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.KeyPreview = true;
			this.MaximumSize = new System.Drawing.Size(273, 162);
			this.MinimumSize = new System.Drawing.Size(273, 162);
			this.Name = "frmHarga";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ENTER PRICE";
			this.Frame1.ResumeLayout(false);
			this.Frame1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		public System.Windows.Forms.ToolTip ToolTip1;
		public System.Windows.Forms.Button CmdOk;
		public System.Windows.Forms.Button CmdCancel;
		public System.Windows.Forms.Button cmdangka;
		public System.Windows.Forms.GroupBox Frame1;
		internal System.Windows.Forms.TextBox txtprice;
	}
	
}
