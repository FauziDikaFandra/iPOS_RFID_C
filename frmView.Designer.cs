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
	partial class frmView : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmView_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmView));
			this.cmdangka = new System.Windows.Forms.Button();
			this.cmdangka.Click += new System.EventHandler(this.cmdangka_Click);
			this.CmdCancel = new System.Windows.Forms.Button();
			this.CmdCancel.Click += new System.EventHandler(this.Cmdcancel_Click);
			this.CmdOk = new System.Windows.Forms.Button();
			this.CmdOk.Click += new System.EventHandler(this.Cmdok_Click);
			this.txtkode = new System.Windows.Forms.TextBox();
			this.txtkode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtkode_KeyDown);
			this.Label2 = new System.Windows.Forms.Label();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
			this.DataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGridView1_KeyDown);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			this.SuspendLayout();
			//
			//cmdangka
			//
			this.cmdangka.BackColor = System.Drawing.SystemColors.Control;
			this.cmdangka.Cursor = System.Windows.Forms.Cursors.Default;
			this.cmdangka.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.cmdangka.ForeColor = System.Drawing.SystemColors.ControlText;
			this.cmdangka.Image = (System.Drawing.Image) (resources.GetObject("cmdangka.Image"));
			this.cmdangka.Location = new System.Drawing.Point(202, 2);
			this.cmdangka.Name = "cmdangka";
			this.cmdangka.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cmdangka.Size = new System.Drawing.Size(76, 48);
			this.cmdangka.TabIndex = 4;
			this.cmdangka.Text = "&NUM";
			this.cmdangka.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.cmdangka.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.cmdangka.UseVisualStyleBackColor = false;
			//
			//CmdCancel
			//
			this.CmdCancel.BackColor = System.Drawing.SystemColors.Control;
			this.CmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
			this.CmdCancel.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.CmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdCancel.Image = (System.Drawing.Image) (resources.GetObject("CmdCancel.Image"));
			this.CmdCancel.Location = new System.Drawing.Point(362, 2);
			this.CmdCancel.Name = "CmdCancel";
			this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CmdCancel.Size = new System.Drawing.Size(76, 48);
			this.CmdCancel.TabIndex = 6;
			this.CmdCancel.Text = "CANCEL";
			this.CmdCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CmdCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.CmdCancel.UseVisualStyleBackColor = false;
			//
			//CmdOk
			//
			this.CmdOk.BackColor = System.Drawing.SystemColors.Control;
			this.CmdOk.Cursor = System.Windows.Forms.Cursors.Default;
			this.CmdOk.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.CmdOk.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdOk.Image = (System.Drawing.Image) (resources.GetObject("CmdOk.Image"));
			this.CmdOk.Location = new System.Drawing.Point(282, 2);
			this.CmdOk.Name = "CmdOk";
			this.CmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CmdOk.Size = new System.Drawing.Size(76, 48);
			this.CmdOk.TabIndex = 5;
			this.CmdOk.Text = "OK";
			this.CmdOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.CmdOk.UseVisualStyleBackColor = false;
			//
			//txtkode
			//
			this.txtkode.BackColor = System.Drawing.SystemColors.Control;
			this.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtkode.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtkode.Location = new System.Drawing.Point(56, 13);
			this.txtkode.Name = "txtkode";
			this.txtkode.Size = new System.Drawing.Size(140, 26);
			this.txtkode.TabIndex = 27;
			//
			//label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(10, 16);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(34, 16);
			this.Label2.TabIndex = 26;
			this.Label2.Text = "PLU";
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(13, 55);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView1.Size = new System.Drawing.Size(424, 312);
			this.DataGridView1.TabIndex = 28;
			//
			//frmView
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (14.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(449, 378);
			this.ControlBox = false;
			this.Controls.Add(this.DataGridView1);
			this.Controls.Add(this.txtkode);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.cmdangka);
			this.Controls.Add(this.CmdCancel);
			this.Controls.Add(this.CmdOk);
			this.Font = new System.Drawing.Font("Arial", (float) (8.0F));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximumSize = new System.Drawing.Size(465, 417);
			this.MinimumSize = new System.Drawing.Size(465, 417);
			this.Name = "frmView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VIEW ARTICLE";
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		public System.Windows.Forms.Button cmdangka;
		public System.Windows.Forms.Button CmdCancel;
		public System.Windows.Forms.Button CmdOk;
		internal System.Windows.Forms.TextBox txtkode;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.DataGridView DataGridView1;
		public System.Windows.Forms.ToolTip ToolTip1;
	}
	
}
