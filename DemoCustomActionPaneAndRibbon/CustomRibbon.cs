//Author:Gokuldas Chandgadkar
//Last Update: 15/12/2013

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using DemoCustomActionPaneAndRibbon.Models;

namespace DemoCustomActionPaneAndRibbon
{
    /// <summary>
    /// Custom Ribbon Implementation.
    /// </summary>
    public partial class CustomRibbon
    {
      
        private void CustomRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        /// <summary>
        /// Handler for Product List
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProduct_Click(object sender, RibbonControlEventArgs e)
        {
            BONorthwindFacade bs = new BONorthwindFacade();
            List<ProductEntity> productList = bs.GetProducts();
            frmProducts form = new frmProducts(productList);
            form.ShowDialog();
        }

        /// <summary>
        /// Handler for Show/Hide Customer Pane.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowHide_Click(object sender, RibbonControlEventArgs e)
        {
            if (toggleActionPane.Checked)
            {
                toggleActionPane.Label = "Hide Customer Pane";
            }
            else
            {
                toggleActionPane.Label = "Show Customer Pane";
            }
            Globals.ThisWorkbook.ShowHide_ActionPane(toggleActionPane.Checked);
           
        }
    }
}
