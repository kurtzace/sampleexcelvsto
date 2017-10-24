// Author:Gokuldas Chandgadkar
// Last Update: 15/12/2013



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;
using Excel1 = Microsoft.Office.Interop.Excel;
using System.IO;
using DemoCustomActionPaneAndRibbon.Models;
using DemoCustomActionPaneAndRibbon.Utilities;
using System.Xml.Linq;

namespace DemoCustomActionPaneAndRibbon
{
    /// <summary>
    /// CustomPane is custom ActionPane.
    /// </summary>
    partial class CustomerPane : UserControl
    {
        BONorthwindFacade _bs = new BONorthwindFacade();
        public CustomerPane()
        {
            InitializeComponent();
            InitDropdowns();
        }

        


        /// <summary>
        /// Method:InitDropDowns
        /// Purpose:Initialises both customer dropdown and Export format dropdwon.
        /// </summary>
        private void InitDropdowns() {

            try
            {


                List<Customer> customerList = _bs.GetCustomers();
                drpCustomer.DataSource = customerList;
                drpCustomer.DisplayMember = "CompanyName";
                drpExportFormat.DataSource = new string[] { "CSV", "XML" };
                drpExportFormat.SelectedIndex = 0;
                //Initialise_Customers(customerList);
            }
            catch (Exception ex)
            {
                string message = "Error occured while populating the schedule dropdown and error is " + ex.ToString();
                Logger.Log.Error(message);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
                Customer cs = drpCustomer.SelectedItem as Customer;
                List<Order> orders = _bs.GetOrders(cs.CustomerID);
                AddOrdersToWorkbook(orders, cs.CustomerID);
        }

        
        /// <summary>
        /// Method:AddOrdersToWorkbook
        /// Purpose:Adds orders for the customer to the workbook
        /// </summary>
        /// <param name="orders"></param>
        /// <param name="customerID"></param>
        private void AddOrdersToWorkbook(List<Order> orders,string customerID) {
            try
            {

                Logger.Log.Information(string.Format("Adding Order of the customer {0} to the workbook", customerID));

                Excel1.Worksheet ws = null;
                foreach(Excel1.Worksheet ws1 in Globals.ThisWorkbook.Worksheets)
                {
                    if(ws1.Name.Equals(customerID,StringComparison.InvariantCultureIgnoreCase))
                    {
                        ws = ws1;
                        break;
                    }
                }
                if (ws == null)
                {
                    ws = Globals.ThisWorkbook.Worksheets.Add();
                    ws.Name = customerID;
                }

                Excel1.Range range =ws.Range["A1"];

                range.Value2 = "Order ID";
                range.Offset[0, 1].Value2 = "Order Date";
                range.Offset[0, 2].Value2 = "Required Date";
                range.Offset[0, 3].Value2 = "Shipping Address";
                range.Offset[0, 4].Value2 = "Shipping City";
                range.Offset[0, 5].Value2 = "Shipping Country";
                range.Offset[0, 6].Value2 = "Shipping PostCode";
                range.Offset[0, 7].Value2 = "Shipped Date";
                range.Offset[0, 8].Value2 = "Order Amount";
                


                int rowIndex = 1;
                int colIndex = 0;

               foreach (Order od in orders)
                {
                    range.Offset[rowIndex, colIndex].Value2 = od.OrderID;
                    range.Offset[rowIndex, colIndex + 1].Value2 = od.OrderDate;
                    range.Offset[rowIndex, colIndex + 1].NumberFormat = @"dd/mm/yyyy;@";
                    range.Offset[rowIndex, colIndex + 2].Value2 = od.RequiredDate;
                    range.Offset[rowIndex, colIndex + 2].NumberFormat = @"dd/mm/yyyy;@";
                 
                   range.Offset[rowIndex, colIndex + 3].Value2 = od.ShipAddress;
                    range.Offset[rowIndex, colIndex + 4].Value2 = od.ShipCity;
                    range.Offset[rowIndex, colIndex + 5].Value2 = od.ShipCountry;
                    range.Offset[rowIndex, colIndex + 6].Value2 = od.ShipPostalCode;
                    range.Offset[rowIndex, colIndex + 7].Value2 = od.ShippedDate;
                    range.Offset[rowIndex, colIndex + 7].NumberFormat = @"dd/mm/yyyy;@";
                 
                    range.Offset[rowIndex, colIndex + 8].Value2 = od.Order_Details.Sum(odet => odet.Quantity * odet.UnitPrice);
                    range.Offset[rowIndex, colIndex + 8].NumberFormat = "$#,##0.00";
                 
                    rowIndex++;
                }
                range =ws.Range["A1:L1"];
                range.Font.Bold=true;
                range = ws.Range["A1:L1"];
                range.EntireColumn.AutoFit();
                Logger.Log.Information(string.Format("Orders for the Customer {0} adding to the workbook completed!", customerID));
                



           }
            catch (Exception ex) { 
            
                string message = "Error occured while populating orders  to the workbook and error is " + ex.ToString();
                Logger.Log.Error(message);
            
            
            }
        
        }


        

        private void btnExport_Click(object sender, EventArgs e)
        {
            btnExport.Enabled = false;
            try
            {
                Logger.Log.Information("Exporting Orders Started!");

                Customer cs = drpCustomer.SelectedItem as Customer;
                List<Order> orders = _bs.GetOrders(cs.CustomerID);
                if (drpExportFormat.SelectedItem.ToString().Equals("CSV"))
                    SaveOrdersAsCSVFile(orders, cs.CustomerID);
                else
                    SaveOrderAsXMLFile(orders, cs.CustomerID);
                Logger.Log.Information("Exporting Orders Completed!");

            }
            catch (Exception ex)
            {

                string message = "Error occured while exporting schedule to file and error is " + ex.ToString();
                Logger.Log.Error(message);

            }

            btnExport.Enabled = true;

     
        }

        /// <summary>
        /// Method:SaveOrderASXMLFile
        /// Purpose:Export orders for the customer in XML Format
        /// </summary>
        /// <param name="orders"></param>
        /// <param name="customerID"></param>
        private void SaveOrderAsXMLFile(List<Order> orders, string customerID)
        {
            try

            { 
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + FILE_PATH + customerID + "_Orders.xml";
            XElement orderXML=
                           new XElement("Orders",
                            from o in orders
                            select 
                              new XElement("Order",
                                new XAttribute("OrderID",o.OrderID),
                                new XElement("OrderDate",o.OrderDate),
                                new XElement("RequiredDate",o.RequiredDate),
                                new XElement("Amount",string.Format("{0:C}",o.Order_Details.Sum(odet=>odet.UnitPrice*odet.Quantity))),
                                new XElement("ShippingDetails",
                                        new XElement("Address",o.ShipAddress),
                                        new XElement("City",o.ShipCity),
                                        new XElement("Country",o.ShipCountry),
                                        new XElement("PostCode",o.ShipPostalCode)
                                    )

                              )
                              );

            orderXML.Save(filePath);
        }catch(Exception ex){

            string message = "Error occured while saving the orders in xml format and error is " + ex.ToString();
            Logger.Log.Error(message);
    
         }
        }

        /// <summary>
        /// Method:SaveOrderAsCSVFile
        /// Purpose:Saves Orders for the customer in CSV format.
        /// </summary>
        /// <param name="orders"></param>
        /// <param name="customerID"></param>
        private void SaveOrdersAsCSVFile(List<Order> orders, string customerID)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + FILE_PATH + customerID + "_Orders.csv";
            using (StreamWriter sw = new StreamWriter(filePath, false))
            {
                string header = "'Order ID','Order Date','Required Date','Order Amount','Shipped Date', 'Address','City','Country','Zip'";
                sw.WriteLine(header);
                orders.ForEach(od=>sw.WriteLine(string.Format("'{0}','{1}','{2}','{3:C}','{4}','{5}','{6}','{7}','{8}'", od.OrderID,od.OrderDate,od.RequiredDate,od.Order_Details.Sum(odet=>odet.Quantity*odet.UnitPrice),od.ShippedDate,od.ShipAddress,od.ShipCity,od.ShipCountry,od.ShipPostalCode)));

            }
        }

        private const string FILE_PATH = @"\NorthWind\Export\";

        internal DemoCustomActionPaneAndRibbon.Models.BONorthwindFacade Facade
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }



       
    }
}
