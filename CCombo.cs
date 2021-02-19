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
	
	public class CCombo
	{
		private string myID;
		private string myNumber;
		private string myName;
		private string myNumber_Name;
		private string myNumber_NameDate;
		private DateTime mydate;
		
		public string ID
		{
			get
			{
				return myID;
			}
		}
		
		public string Number
		{
			get
			{
				return myNumber;
			}
		}
		
		public string Name
		{
			get
			{
				return myName;
			}
		}
		
		public string Number_Name
		{
			get
			{
				return myNumber_Name;
			}
		}
		
		public string Number_NameDate
		{
			get
			{
				return myNumber_NameDate;
			}
		}
		
		//Public Sub New(ByVal ID As Int16, ByVal Number As String, ByVal Name As String)
		
		//    myID = ID
		//    myNumber = Number
		//    myName = Name
		//    myNumber_Name = Number + "  " + Name
		
		//End Sub
		
		public CCombo(string ID, DateTime dt)
		{
			myID = ID;
			myNumber_Name = ID.ToString() + " " + dt.Day.ToString() + "/" + dt.Month.ToString() + "/" + dt.Year.ToString();
			//myName = Name
			//myNumber_Name = Number + "  " + Name
		}
		
		public CCombo(string ID, DateTime dt, bool angka, bool waktu)
		{
			myID = ID;
			myNumber_NameDate = ID.ToString() + " " + dt.Day.ToString() + "-" + dt.Month.ToString() + "-" + dt.Year.ToString();
		}
		public CCombo(string ID, string name)
		{
			myID = ID;
			//myNumber_Name = name
			//myName = Name
			myNumber_Name = name;
		}
	}
	
}
