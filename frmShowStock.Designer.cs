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
	partial class frmShowStock : System.Windows.Forms.Form
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
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle DataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowStock));
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			base.Load += new System.EventHandler(Show_Stock_Load);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(frmShowStock_FormClosed);
			this.Label7 = new System.Windows.Forms.Label();
			this.txtItemCode = new System.Windows.Forms.TextBox();
			this.txtItemCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtItemCode_KeyDown);
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.DataGridView1 = new System.Windows.Forms.DataGridView();
			this.GroupBox3 = new System.Windows.Forms.GroupBox();
			this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.whs = new System.Windows.Forms.Label();
			this.floor = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.Stock = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.Label8 = new System.Windows.Forms.Label();
			this.Desc = new System.Windows.Forms.Label();
			this.PLU = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label1 = new System.Windows.Forms.Label();
			this.PictureBox1 = new System.Windows.Forms.PictureBox();
			this.BackgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.BackgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
			this.BackgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
			this.RfidScan2 = new System.Windows.Forms.Button();
			this.RfidScan2.Click += new System.EventHandler(this.RfidScan2_Click);
			this.Button1 = new System.Windows.Forms.Button();
			this.Button1.Click += new System.EventHandler(this.Button1_Click_1);
			this.GroupBox1.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).BeginInit();
			this.GroupBox3.SuspendLayout();
			this.TableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).BeginInit();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.Label7);
			this.GroupBox1.Controls.Add(this.txtItemCode);
			this.GroupBox1.Location = new System.Drawing.Point(12, 4);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(299, 78);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label7.ForeColor = System.Drawing.Color.Yellow;
			this.Label7.Location = new System.Drawing.Point(6, 14);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(86, 19);
			this.Label7.TabIndex = 75;
			this.Label7.Text = "Item Code";
			//
			//txtItemCode
			//
			this.txtItemCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtItemCode.Font = new System.Drawing.Font("Arial", (float) (14.25F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtItemCode.Location = new System.Drawing.Point(9, 35);
			this.txtItemCode.Name = "txtItemCode";
			this.txtItemCode.Size = new System.Drawing.Size(270, 29);
			this.txtItemCode.TabIndex = 0;
			//
			//GroupBox2
			//
			this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom 
				| System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.GroupBox2.Controls.Add(this.DataGridView1);
			this.GroupBox2.Location = new System.Drawing.Point(12, 175);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(898, 494);
			this.GroupBox2.TabIndex = 1;
			this.GroupBox2.TabStop = false;
			//
			//DataGridView1
			//
			this.DataGridView1.AllowUserToAddRows = false;
			this.DataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom 
				| System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			DataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", (float) (8.25F));
			DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			DataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
			DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1;
			this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			DataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", (float) (8.25F));
			DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			DataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2;
			this.DataGridView1.Location = new System.Drawing.Point(8, 13);
			this.DataGridView1.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
			this.DataGridView1.Name = "DataGridView1";
			this.DataGridView1.ReadOnly = true;
			this.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.DataGridView1.Size = new System.Drawing.Size(880, 475);
			this.DataGridView1.TabIndex = 0;
			//
			//GroupBox3
			//
			this.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.GroupBox3.Controls.Add(this.TableLayoutPanel1);
			this.GroupBox3.Controls.Add(this.Desc);
			this.GroupBox3.Controls.Add(this.PLU);
			this.GroupBox3.Controls.Add(this.Label5);
			this.GroupBox3.Controls.Add(this.Label4);
			this.GroupBox3.Controls.Add(this.Label2);
			this.GroupBox3.Controls.Add(this.Label1);
			this.GroupBox3.Location = new System.Drawing.Point(12, 88);
			this.GroupBox3.Name = "GroupBox3";
			this.GroupBox3.Size = new System.Drawing.Size(898, 81);
			this.GroupBox3.TabIndex = 76;
			this.GroupBox3.TabStop = false;
			//
			//TableLayoutPanel1
			//
			this.TableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			this.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.TableLayoutPanel1.ColumnCount = 3;
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float) (33.33333F)));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float) (33.33333F)));
			this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, (float) (33.33333F)));
			this.TableLayoutPanel1.Controls.Add(this.whs, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.floor, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label3, 0, 0);
			this.TableLayoutPanel1.Controls.Add(this.Stock, 0, 1);
			this.TableLayoutPanel1.Controls.Add(this.Label6, 1, 0);
			this.TableLayoutPanel1.Controls.Add(this.Label8, 2, 0);
			this.TableLayoutPanel1.Location = new System.Drawing.Point(635, 19);
			this.TableLayoutPanel1.Name = "TableLayoutPanel1";
			this.TableLayoutPanel1.RowCount = 2;
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, (float) (100.0F)));
			this.TableLayoutPanel1.Size = new System.Drawing.Size(253, 49);
			this.TableLayoutPanel1.TabIndex = 88;
			//
			//whs
			//
			this.whs.AutoSize = true;
			this.whs.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.whs.ForeColor = System.Drawing.SystemColors.Window;
			this.whs.Location = new System.Drawing.Point(29, 27);
			this.whs.Margin = new System.Windows.Forms.Padding(28, 3, 3, 0);
			this.whs.Name = "whs";
			this.whs.Size = new System.Drawing.Size(18, 19);
			this.whs.TabIndex = 88;
			this.whs.Text = "_";
			this.whs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//floor
			//
			this.floor.AutoSize = true;
			this.floor.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.floor.ForeColor = System.Drawing.SystemColors.Window;
			this.floor.Location = new System.Drawing.Point(115, 27);
			this.floor.Margin = new System.Windows.Forms.Padding(30, 3, 3, 0);
			this.floor.Name = "floor";
			this.floor.Size = new System.Drawing.Size(18, 19);
			this.floor.TabIndex = 87;
			this.floor.Text = "_";
			this.floor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label3.ForeColor = System.Drawing.SystemColors.Window;
			this.Label3.Location = new System.Drawing.Point(21, 4);
			this.Label3.Margin = new System.Windows.Forms.Padding(20, 3, 3, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(43, 19);
			this.Label3.TabIndex = 78;
			this.Label3.Text = "Whs";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Stock
			//
			this.Stock.AutoSize = true;
			this.Stock.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Stock.ForeColor = System.Drawing.SystemColors.Window;
			this.Stock.Location = new System.Drawing.Point(203, 27);
			this.Stock.Margin = new System.Windows.Forms.Padding(34, 3, 3, 0);
			this.Stock.Name = "Stock";
			this.Stock.Size = new System.Drawing.Size(18, 19);
			this.Stock.TabIndex = 84;
			this.Stock.Text = "_";
			this.Stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label6.ForeColor = System.Drawing.SystemColors.Window;
			this.Label6.Location = new System.Drawing.Point(101, 4);
			this.Label6.Margin = new System.Windows.Forms.Padding(16, 3, 3, 0);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(49, 19);
			this.Label6.TabIndex = 85;
			this.Label6.Text = "Floor";
			this.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label8.ForeColor = System.Drawing.SystemColors.Window;
			this.Label8.Location = new System.Drawing.Point(189, 4);
			this.Label8.Margin = new System.Windows.Forms.Padding(20, 3, 3, 0);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(42, 19);
			this.Label8.TabIndex = 86;
			this.Label8.Text = "SAP";
			this.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//Desc
			//
			this.Desc.AutoSize = true;
			this.Desc.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Desc.ForeColor = System.Drawing.SystemColors.Window;
			this.Desc.Location = new System.Drawing.Point(223, 44);
			this.Desc.Name = "Desc";
			this.Desc.Size = new System.Drawing.Size(18, 19);
			this.Desc.TabIndex = 83;
			this.Desc.Text = "_";
			//
			//PLU
			//
			this.PLU.AutoSize = true;
			this.PLU.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.PLU.ForeColor = System.Drawing.SystemColors.Window;
			this.PLU.Location = new System.Drawing.Point(223, 19);
			this.PLU.Name = "PLU";
			this.PLU.Size = new System.Drawing.Size(18, 19);
			this.PLU.TabIndex = 82;
			this.PLU.Text = "_";
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label5.ForeColor = System.Drawing.SystemColors.Window;
			this.Label5.Location = new System.Drawing.Point(200, 44);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(15, 19);
			this.Label5.TabIndex = 80;
			this.Label5.Text = ":";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.ForeColor = System.Drawing.SystemColors.Window;
			this.Label4.Location = new System.Drawing.Point(200, 19);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(15, 19);
			this.Label4.TabIndex = 79;
			this.Label4.Text = ":";
			//
			//label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label2.ForeColor = System.Drawing.SystemColors.Window;
			this.Label2.Location = new System.Drawing.Point(15, 44);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(156, 19);
			this.Label2.TabIndex = 77;
			this.Label2.Text = "Description / Brand";
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Arial", (float) (12.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label1.ForeColor = System.Drawing.SystemColors.Window;
			this.Label1.Location = new System.Drawing.Point(15, 19);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(46, 19);
			this.Label1.TabIndex = 76;
			this.Label1.Text = "PLU ";
			//
			//PictureBox1
			//
			this.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
			this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.PictureBox1.Image = (System.Drawing.Image) (resources.GetObject("PictureBox1.Image"));
			this.PictureBox1.Location = new System.Drawing.Point(647, 25);
			this.PictureBox1.Name = "PictureBox1";
			this.PictureBox1.Size = new System.Drawing.Size(264, 53);
			this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.PictureBox1.TabIndex = 77;
			this.PictureBox1.TabStop = false;
			//
			//BackgroundWorker1
			//
			//
			//RfidScan2
			//
			this.RfidScan2.BackColor = System.Drawing.SystemColors.Control;
			this.RfidScan2.Cursor = System.Windows.Forms.Cursors.Default;
			this.RfidScan2.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.RfidScan2.ForeColor = System.Drawing.Color.Red;
			this.RfidScan2.Image = (System.Drawing.Image) (resources.GetObject("RfidScan2.Image"));
			this.RfidScan2.Location = new System.Drawing.Point(327, 10);
			this.RfidScan2.Name = "RfidScan2";
			this.RfidScan2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.RfidScan2.Size = new System.Drawing.Size(95, 72);
			this.RfidScan2.TabIndex = 79;
			this.RfidScan2.Text = "RFID OFF";
			this.RfidScan2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.RfidScan2.UseVisualStyleBackColor = false;
			//
			//Button1
			//
			this.Button1.BackColor = System.Drawing.SystemColors.Control;
			this.Button1.Cursor = System.Windows.Forms.Cursors.Default;
			this.Button1.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Button1.ForeColor = System.Drawing.Color.Black;
			this.Button1.Image = (System.Drawing.Image) (resources.GetObject("Button1.Image"));
			this.Button1.Location = new System.Drawing.Point(428, 10);
			this.Button1.Name = "Button1";
			this.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Button1.Size = new System.Drawing.Size(95, 72);
			this.Button1.TabIndex = 83;
			this.Button1.Text = " EXIT";
			this.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Button1.UseVisualStyleBackColor = false;
			//
			//frmShowStock
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (14.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DimGray;
			this.ClientSize = new System.Drawing.Size(920, 681);
			this.ControlBox = false;
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.RfidScan2);
			this.Controls.Add(this.PictureBox1);
			this.Controls.Add(this.GroupBox3);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.GroupBox1);
			this.Font = new System.Drawing.Font("Arial", (float) (8.25F));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.KeyPreview = true;
			this.Name = "frmShowStock";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = " ";
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.GroupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.DataGridView1).EndInit();
			this.GroupBox3.ResumeLayout(false);
			this.GroupBox3.PerformLayout();
			this.TableLayoutPanel1.ResumeLayout(false);
			this.TableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize) this.PictureBox1).EndInit();
			this.ResumeLayout(false);
			
		}
		
		internal GroupBox GroupBox1;
		internal TextBox txtItemCode;
		internal GroupBox GroupBox2;
		internal DataGridView DataGridView1;
		internal Label Label7;
		internal GroupBox GroupBox3;
		internal Label Desc;
		internal Label PLU;
		internal Label Label5;
		internal Label Label4;
		internal Label Label3;
		internal Label Label2;
		internal Label Label1;
		internal PictureBox PictureBox1;
		internal TableLayoutPanel TableLayoutPanel1;
		internal System.ComponentModel.BackgroundWorker BackgroundWorker1;
		internal Label Stock;
		public Button RfidScan2;
		public Button Button1;
		internal Label whs;
		internal Label floor;
		internal Label Label6;
		internal Label Label8;
	}
	
}
