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
	partial class frmView2 : System.Windows.Forms.Form
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
			base.Load += new System.EventHandler(frmView2_Load);
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmView2));
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
			this.txtkode = new System.Windows.Forms.TextBox();
			this.txtkode.TextChanged += new System.EventHandler(this.txtkode_TextChanged);
			this.Label2 = new System.Windows.Forms.Label();
			this.CmdCancel = new System.Windows.Forms.Button();
			this.CmdCancel.Click += new System.EventHandler(this.CmdCancel_Click);
			this.CmdOk = new System.Windows.Forms.Button();
			this.CmdOk.Click += new System.EventHandler(this.CmdOk_Click);
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.Label1 = new System.Windows.Forms.Label();
			this.ComboBox1 = new System.Windows.Forms.ComboBox();
			this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
			this.lblmsg = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			this.GroupBox1.SuspendLayout();
			this.SuspendLayout();
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.AllowUserToDeleteRows = false;
			this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DataGridView1.Location = new System.Drawing.Point(15, 117);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView1.Size = new System.Drawing.Size(673, 276);
			this.DataGridView1.TabIndex = 34;
			//
			//txtkode
			//
			this.txtkode.BackColor = System.Drawing.SystemColors.Control;
			this.txtkode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtkode.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtkode.Location = new System.Drawing.Point(9, 37);
			this.txtkode.Name = "txtkode";
			this.txtkode.Size = new System.Drawing.Size(253, 22);
			this.txtkode.TabIndex = 33;
			//
			//label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(6, 20);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(88, 16);
			this.Label2.TabIndex = 32;
			this.Label2.Text = "Brand / Desc";
			//
			//CmdCancel
			//
			this.CmdCancel.BackColor = System.Drawing.SystemColors.Control;
			this.CmdCancel.Cursor = System.Windows.Forms.Cursors.Default;
			this.CmdCancel.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.CmdCancel.ForeColor = System.Drawing.SystemColors.ControlText;
			this.CmdCancel.Image = (System.Drawing.Image) (resources.GetObject("CmdCancel.Image"));
			this.CmdCancel.Location = new System.Drawing.Point(573, 19);
			this.CmdCancel.Name = "CmdCancel";
			this.CmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CmdCancel.Size = new System.Drawing.Size(91, 45);
			this.CmdCancel.TabIndex = 31;
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
			this.CmdOk.Location = new System.Drawing.Point(475, 19);
			this.CmdOk.Name = "CmdOk";
			this.CmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.CmdOk.Size = new System.Drawing.Size(91, 45);
			this.CmdOk.TabIndex = 30;
			this.CmdOk.Text = "OK";
			this.CmdOk.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.CmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.CmdOk.UseVisualStyleBackColor = false;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(273, 20);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(54, 16);
			this.Label1.TabIndex = 35;
			this.Label1.Text = "Sort By";
			//
			//ComboBox1
			//
			this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBox1.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.ComboBox1.FormattingEnabled = true;
			this.ComboBox1.Location = new System.Drawing.Point(277, 36);
			this.ComboBox1.Name = "ComboBox1";
			this.ComboBox1.Size = new System.Drawing.Size(192, 24);
			this.ComboBox1.TabIndex = 36;
			//
			//lblmsg
			//
			this.lblmsg.BackColor = System.Drawing.Color.DimGray;
			this.lblmsg.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblmsg.Font = new System.Drawing.Font("Arial", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblmsg.ForeColor = System.Drawing.Color.Yellow;
			this.lblmsg.Location = new System.Drawing.Point(-1, 0);
			this.lblmsg.Name = "lblmsg";
			this.lblmsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblmsg.Size = new System.Drawing.Size(700, 31);
			this.lblmsg.TabIndex = 37;
			this.lblmsg.Text = "VIEW ARTICLE";
			this.lblmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.CmdCancel);
			this.GroupBox1.Controls.Add(this.CmdOk);
			this.GroupBox1.Controls.Add(this.ComboBox1);
			this.GroupBox1.Controls.Add(this.Label2);
			this.GroupBox1.Controls.Add(this.Label1);
			this.GroupBox1.Controls.Add(this.txtkode);
			this.GroupBox1.Location = new System.Drawing.Point(15, 34);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(673, 77);
			this.GroupBox1.TabIndex = 38;
			this.GroupBox1.TabStop = false;
			//
			//frmView2
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (14.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(697, 409);
			this.ControlBox = false;
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.lblmsg);
			this.Controls.Add(this.DataGridView1);
			this.Font = new System.Drawing.Font("Arial", (float) (8.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.KeyPreview = true;
			this.MaximumSize = new System.Drawing.Size(713, 448);
			this.MinimumSize = new System.Drawing.Size(713, 448);
			this.Name = "frmView2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "VIEW ARTIKEL";
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.ResumeLayout(false);
			
		}
		
		internal DataGridView DataGridView1;
		internal TextBox txtkode;
		internal Label Label2;
		public Button CmdCancel;
		public Button CmdOk;
		public ToolTip ToolTip1;
		internal Label Label1;
		internal ComboBox ComboBox1;
		public Label lblmsg;
		internal GroupBox GroupBox1;
	}
	
}
