using DemoCustomActionPaneAndRibbon.Models;
using System;
// Author:Gokuldas Chandgadkar
// Last Update:15/12/2013

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DemoCustomActionPaneAndRibbon
{
    public partial class frmProducts : Form
    {
        private List<ProductEntity> _products = null;
        public frmProducts(List<ProductEntity> products)
        {
            InitializeComponent();
            _products = products;
            InitProducts();

        }

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

        /// <summary>
        /// Method:InitProducts
        /// Purpose:Binds products collection to the datagrid.
        /// </summary>
        private void InitProducts()
        {

            gridProducts.DataSource = _products;
            
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
