using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Excel;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Excel1 = Microsoft.Office.Interop.Excel;
using DemoCustomActionPaneAndRibbon.Utilities;
using DemoCustomActionPaneAndRibbon.Models;


namespace DemoCustomActionPaneAndRibbon
{
    public partial class Sheet1
    {
        private void Sheet1_Startup(object sender, System.EventArgs e)
        {
            Init_Customers();
        }

        private void Init_Customers()
        {
       
            try
            {

                BONorthwindFacade context = new BONorthwindFacade();
                List<Customer> Customers = context.GetCustomers();
                Excel1.Worksheet ws = Globals.ThisWorkbook.Worksheets["Customers"];
               
               //  ws.Name = "Schedules";
                Excel1.Range range = ws.Range["A1"];
                range.Value2 = "Customer_ID";
                range.Offset[0, 1].Value2 = "Company Name";
                range.Offset[0, 2].Value2 = "Address";
                range.Offset[0, 3].Value2 = "City";
                range.Offset[0, 4].Value2 = "Country";

                int rowIndex = 1;
                int colIndex = 0;

                foreach (Customer c in Customers)
                {
                    range.Offset[rowIndex, colIndex].Value2 = c.CustomerID;
                    range.Offset[rowIndex, colIndex + 1].Value2 = c.CompanyName;
                    range.Offset[rowIndex, colIndex + 2].Value2 = c.Address;
                    range.Offset[rowIndex, colIndex + 3].Value2 = c.City;
                    range.Offset[rowIndex, colIndex + 4].Value2 = c.Country;

                    rowIndex++;


                }

                range = ws.Range["A1:E1"];
                range.Font.Bold = true;
                range = ws.Range["A1:E1"];
                range.EntireColumn.AutoFit();
            }
            catch (Exception ex)
            {
                string message = "Error occured while populating the schedules and error is " + ex.ToString();
                Logger.Log.Error(message);
          
                throw ex;
            }

        
        }

        private void Sheet1_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(Sheet1_Startup);
            this.Shutdown += new System.EventHandler(Sheet1_Shutdown);
        }

        #endregion

    }
}
