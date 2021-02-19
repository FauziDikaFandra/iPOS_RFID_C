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
	public partial class Temp
	{
		public Temp()
		{
			InitializeComponent();
		}
		public void Temp_Load(object sender, EventArgs e)
		{
			this.Close();
			frmSales.Default.Close();
		}
	}
}
