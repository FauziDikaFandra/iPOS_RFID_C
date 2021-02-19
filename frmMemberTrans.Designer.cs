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
	partial class frmMemberTrans : System.Windows.Forms.Form
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
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			base.Load += new System.EventHandler(frmMemberTrans_Load);
			this.dgTransactions = new System.Windows.Forms.DataGridView();
			this.dgTransactions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgTransactions_CellClick);
			this.lblmsg = new System.Windows.Forms.Label();
			this.txtMember = new System.Windows.Forms.TextBox();
			this.txtMember.TextChanged += new System.EventHandler(this.txtMember_TextChanged);
			this.Label4 = new System.Windows.Forms.Label();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.dgDetail = new System.Windows.Forms.DataGridView();
			this.GroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgTransactions).BeginInit();
			this.GroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) this.dgDetail).BeginInit();
			this.SuspendLayout();
			//
			//GroupBox1
			//
			this.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.GroupBox1.Controls.Add(this.dgTransactions);
			this.GroupBox1.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GroupBox1.Location = new System.Drawing.Point(15, 70);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(793, 198);
			this.GroupBox1.TabIndex = 0;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Transactions";
			//
			//dgTransactions
			//
			this.dgTransactions.AllowUserToAddRows = false;
			this.dgTransactions.AllowUserToDeleteRows = false;
			this.dgTransactions.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom 
				| System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.dgTransactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgTransactions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgTransactions.BackgroundColor = System.Drawing.Color.White;
			this.dgTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgTransactions.Location = new System.Drawing.Point(7, 20);
			this.dgTransactions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dgTransactions.Name = "dgTransactions";
			this.dgTransactions.ReadOnly = true;
			this.dgTransactions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgTransactions.Size = new System.Drawing.Size(777, 171);
			this.dgTransactions.TabIndex = 0;
			//
			//lblmsg
			//
			this.lblmsg.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.lblmsg.BackColor = System.Drawing.Color.DimGray;
			this.lblmsg.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblmsg.Font = new System.Drawing.Font("Arial", (float) (14.25F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.lblmsg.ForeColor = System.Drawing.Color.Yellow;
			this.lblmsg.Location = new System.Drawing.Point(-7, 0);
			this.lblmsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblmsg.Name = "lblmsg";
			this.lblmsg.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lblmsg.Size = new System.Drawing.Size(830, 33);
			this.lblmsg.TabIndex = 29;
			this.lblmsg.Text = "MEMBER TRANSACTIONS";
			this.lblmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			//
			//txtMember
			//
			this.txtMember.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.txtMember.Location = new System.Drawing.Point(161, 41);
			this.txtMember.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.txtMember.Name = "txtMember";
			this.txtMember.Size = new System.Drawing.Size(262, 22);
			this.txtMember.TabIndex = 0;
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Label4.Location = new System.Drawing.Point(17, 44);
			this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(97, 16);
			this.Label4.TabIndex = 32;
			this.Label4.Text = "Member Code";
			//
			//GroupBox2
			//
			this.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom 
				| System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.GroupBox2.Controls.Add(this.dgDetail);
			this.GroupBox2.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GroupBox2.Location = new System.Drawing.Point(15, 275);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(793, 229);
			this.GroupBox2.TabIndex = 34;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Details";
			//
			//dgDetail
			//
			this.dgDetail.AllowUserToAddRows = false;
			this.dgDetail.AllowUserToDeleteRows = false;
			this.dgDetail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom 
				| System.Windows.Forms.AnchorStyles.Left 
				| System.Windows.Forms.AnchorStyles.Right;
			this.dgDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dgDetail.BackgroundColor = System.Drawing.Color.White;
			this.dgDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDetail.Location = new System.Drawing.Point(7, 20);
			this.dgDetail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dgDetail.Name = "dgDetail";
			this.dgDetail.ReadOnly = true;
			this.dgDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgDetail.Size = new System.Drawing.Size(777, 197);
			this.dgDetail.TabIndex = 0;
			//
			//frmMemberTrans
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (7.0F), (float) (16.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(823, 512);
			this.Controls.Add(this.GroupBox2);
			this.Controls.Add(this.txtMember);
			this.Controls.Add(this.Label4);
			this.Controls.Add(this.lblmsg);
			this.Controls.Add(this.GroupBox1);
			this.Font = new System.Drawing.Font("Arial", (float) (9.75F), System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Name = "frmMemberTrans";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Member Trans";
			this.GroupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgTransactions).EndInit();
			this.GroupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize) this.dgDetail).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
			
		}
		
		internal GroupBox GroupBox1;
		public Label lblmsg;
		internal TextBox txtMember;
		internal Label Label4;
		internal DataGridView dgTransactions;
		internal GroupBox GroupBox2;
		internal DataGridView dgDetail;
	}
	
}
