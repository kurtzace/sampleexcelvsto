namespace DemoCustomActionPaneAndRibbon
{
    partial class CustomRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public CustomRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.grpOptions = this.Factory.CreateRibbonGroup();
            this.btnProduct = this.Factory.CreateRibbonButton();
            this.toggleActionPane = this.Factory.CreateRibbonToggleButton();
            this.tab1.SuspendLayout();
            this.grpOptions.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.grpOptions);
            this.tab1.Label = "NorthWind";
            this.tab1.Name = "tab1";
            // 
            // grpOptions
            // 
            this.grpOptions.Items.Add(this.btnProduct);
            this.grpOptions.Items.Add(this.toggleActionPane);
            this.grpOptions.Label = "Options";
            this.grpOptions.Name = "grpOptions";
            // 
            // btnProduct
            // 
            this.btnProduct.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnProduct.Label = "Product List";
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.OfficeImageId = "ServerProperties";
            this.btnProduct.ShowImage = true;
            this.btnProduct.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnProduct_Click);
            // 
            // toggleActionPane
            // 
            this.toggleActionPane.Checked = true;
            this.toggleActionPane.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.toggleActionPane.Label = "Hide Customer Pane";
            this.toggleActionPane.Name = "toggleActionPane";
            this.toggleActionPane.OfficeImageId = "AdpDiagramHideTable";
            this.toggleActionPane.ShowImage = true;
            this.toggleActionPane.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnShowHide_Click);
            // 
            // CustomRibbon
            // 
            this.Name = "CustomRibbon";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.CustomRibbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.grpOptions.ResumeLayout(false);
            this.grpOptions.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup grpOptions;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnProduct;
        internal Microsoft.Office.Tools.Ribbon.RibbonToggleButton toggleActionPane;
    }

    partial class ThisRibbonCollection
    {
        internal CustomRibbon CustomRibbon
        {
            get { return this.GetRibbon<CustomRibbon>(); }
        }
    }
}
