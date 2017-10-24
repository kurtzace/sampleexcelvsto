using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Tools.Excel;
// Author:Gokuldas Chandgadkar
// Last Update: 15/12/2103

using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace DemoCustomActionPaneAndRibbon
{
    public partial class ThisWorkbook
    {
        private CustomerPane cpane = new CustomerPane();

        internal CustomerPane CustomPane
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    
        private void ThisWorkbook_Startup(object sender, System.EventArgs e)
        {
            //Initialises the custom customer pane.
            this.ActionsPane.Controls.Add(cpane);
        }

        private void ThisWorkbook_Shutdown(object sender, System.EventArgs e)
        {
        }

        /// <summary>
        /// Method:ShowHide_ActionPane
        /// Purpose:Toggles the custom pane.
        /// </summary>
        /// <param name="flag"></param>
        public void ShowHide_ActionPane(bool flag)
        {
            this.Application.DisplayDocumentActionTaskPane = flag;
            cpane.Visible = flag;

        }
        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisWorkbook_Startup);
            this.Shutdown += new System.EventHandler(ThisWorkbook_Shutdown);
        }

        #endregion

    }
}
