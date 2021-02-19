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
	public partial class frmMemberTrans
	{
		public frmMemberTrans()
		{
			InitializeComponent();
			
			//Added to support default instance behavour in C#
			if (defaultInstance == null)
				defaultInstance = this;
		}
		
#region Default Instance
		
		private static frmMemberTrans defaultInstance;
		
		/// <summary>
		/// Added by the VB.Net to C# Converter to support default instance behavour in C#
		/// </summary>
		public static frmMemberTrans Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new frmMemberTrans();
					defaultInstance.FormClosed += new System.Windows.Forms.FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
			set
			{
				defaultInstance = value;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		DataSet dsMember = new DataSet();
		DataSet dsDetail = new DataSet();
		public void frmMemberTrans_Load(object sender, EventArgs e)
		{
			txtMember.Focus();
		}
		
		public void txtMember_TextChanged(object sender, EventArgs e)
		{
			dsMember.Clear();
			dgDetail.DataSource = null;
			dsMember = Module1.getSqldb("select DISTINCT top 50  b.Transaction_Number as Transactions,Phone,Member_Name as  Name,Transaction_Date as Date,b.Net_Price as Total  from " +
				"[POS_SERVER_HISTORY].dbo.Sales_Transaction_Details a inner join [POS_SERVER_HISTORY].dbo.Sales_Transactions b on a.Transaction_Number = b.Transaction_Number   " +
				"inner join Members c on b.Card_Number = c.Member_Code where b.Status = '00' and c.member_code <> 'LM-00000000' and (c.Phone like '" + txtMember.Text + "%' or c.Member_Name like '" + txtMember.Text + "%') order by b.Transaction_Date desc ", Module1.ConnServer);
			
			if (dsMember.Tables[0].Rows.Count > 0)
			{
				dgTransactions.DataSource = dsMember.Tables[0];
				dgTransactions.Columns["Total"].DefaultCellStyle.Format = "N0";
				dgTransactions.Refresh();
			}
			
		}
		
		public void dgTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				dsDetail.Clear();
				dsDetail = Module1.getSqldb("select top 50 seq as No,a.PLU,item_description as Description,b.brand as Brand,qty as Qty,price as Price,amount as Amount,discount_amount as Disc,net_price as Total from " +
					"[POS_SERVER_HISTORY].dbo.Sales_Transaction_Details a inner join item_master b on " +
					"a.plu = b.plu where transaction_number = '" + System.Convert.ToString(dgTransactions[0, e.RowIndex].Value) + "'", Module1.ConnServer);
				if (dsDetail.Tables[0].Rows.Count > 0)
				{
					dgDetail.DataSource = dsDetail.Tables[0];
					dgDetail.Columns["No"].DefaultCellStyle.Format = "N0";
					dgDetail.Columns["Qty"].DefaultCellStyle.Format = "N0";
					dgDetail.Columns["Price"].DefaultCellStyle.Format = "N0";
					dgDetail.Columns["Amount"].DefaultCellStyle.Format = "N0";
					dgDetail.Columns["Disc"].DefaultCellStyle.Format = "N0";
					dgDetail.Columns["Total"].DefaultCellStyle.Format = "N0";
					dgDetail.Refresh();
				}
			}
			catch (Exception)
			{
				
			}
		}
	}
}
