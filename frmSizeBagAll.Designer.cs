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
		public partial class frmSizeBagAll : System.Windows.Forms.Form
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSizeBagAll));
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.Button4 = new System.Windows.Forms.Button();
			this.Button4.Click += new System.EventHandler(this.Button4_Click);
			this.Button3 = new System.Windows.Forms.Button();
			this.Button3.Click += new System.EventHandler(this.Button3_Click);
			this.Button5 = new System.Windows.Forms.Button();
			this.Button5.Click += new System.EventHandler(this.Button5_Click);
			this.GroupBox2.SuspendLayout();
			this.SuspendLayout();
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.Button4);
			this.GroupBox2.Controls.Add(this.Button5);
			this.GroupBox2.Controls.Add(this.Button3);
			this.GroupBox2.Font = new System.Drawing.Font("Arial", (float) (8.25F), (System.Drawing.FontStyle) ((int) (System.Drawing.FontStyle.Bold) | (int) System.Drawing.FontStyle.Italic), System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.GroupBox2.Location = new System.Drawing.Point(12, 9);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(366, 98);
			this.GroupBox2.TabIndex = 2;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Bag";
			//
			//Button4
			//
			this.Button4.BackColor = System.Drawing.SystemColors.Control;
			this.Button4.Cursor = System.Windows.Forms.Cursors.Default;
			this.Button4.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Button4.ForeColor = System.Drawing.SystemColors.ControlText;
			//this.Button4.Image = global::My.resources.Resources.bag_2__dTN_icon;
			this.Button4.Location = new System.Drawing.Point(244, 19);
			this.Button4.Name = "Button4";
			this.Button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Button4.Size = new System.Drawing.Size(109, 67);
			this.Button4.TabIndex = 22;
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
			this.Button3.Location = new System.Drawing.Point(129, 19);
			this.Button3.Name = "Button3";
			this.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Button3.Size = new System.Drawing.Size(109, 67);
			this.Button3.TabIndex = 21;
			this.Button3.Tag = "7";
			this.Button3.Text = "PLASTIC";
			this.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Button3.UseVisualStyleBackColor = false;
			//
			//Button5
			//
			this.Button5.BackColor = System.Drawing.SystemColors.Control;
			this.Button5.Cursor = System.Windows.Forms.Cursors.Default;
			this.Button5.Font = new System.Drawing.Font("Arial", (float) (9.0F), System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, System.Convert.ToByte(0));
			this.Button5.ForeColor = System.Drawing.SystemColors.ControlText;
			//this.Button5.Image = global::My.resources.Resources.bag_xNf_icon;
			this.Button5.Location = new System.Drawing.Point(14, 19);
			this.Button5.Name = "Button5";
			this.Button5.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Button5.Size = new System.Drawing.Size(109, 68);
			this.Button5.TabIndex = 20;
			this.Button5.Tag = "7";
			this.Button5.Text = "PAPER BAG";
			this.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.Button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Button5.UseVisualStyleBackColor = false;
			//
			//frmSizeBagAll
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF((float) (6.0F), (float) (14.0F));
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(390, 119);
			this.Controls.Add(this.GroupBox2);
			this.Font = new System.Drawing.Font("Arial", (float) (8.25F));
			this.Icon = (System.Drawing.Icon) (resources.GetObject("$this.Icon"));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmSizeBagAll";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bag";
			this.GroupBox2.ResumeLayout(false);
			this.ResumeLayout(false);
			
		}
		internal GroupBox GroupBox2;
		public Button Button4;
		public Button Button5;
		public Button Button3;
	}
	
}
