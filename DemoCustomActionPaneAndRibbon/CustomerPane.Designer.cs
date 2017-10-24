namespace DemoCustomActionPaneAndRibbon
{
    [System.ComponentModel.ToolboxItemAttribute(false)]
    partial class CustomerPane
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.drpExportFormat = new System.Windows.Forms.ComboBox();
            this.lblExport = new System.Windows.Forms.Label();
            this.drpCustomer = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 172);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnExport);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 51);
            this.panel2.TabIndex = 1;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(229, 15);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(109, 23);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Export Order";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(79, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Order To Workbook";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.drpExportFormat);
            this.groupBox1.Controls.Add(this.lblExport);
            this.groupBox1.Controls.Add(this.drpCustomer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Customer";
            // 
            // drpExportFormat
            // 
            this.drpExportFormat.AutoCompleteCustomSource.AddRange(new string[] {
            "CSV",
            "XML"});
            this.drpExportFormat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.drpExportFormat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.drpExportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.drpExportFormat.FormattingEnabled = true;
            this.drpExportFormat.Location = new System.Drawing.Point(100, 53);
            this.drpExportFormat.Name = "drpExportFormat";
            this.drpExportFormat.Size = new System.Drawing.Size(122, 21);
            this.drpExportFormat.TabIndex = 3;
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Location = new System.Drawing.Point(6, 56);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(78, 13);
            this.lblExport.TabIndex = 2;
            this.lblExport.Text = "Export Format :";
            // 
            // drpCustomer
            // 
            this.drpCustomer.FormattingEnabled = true;
            this.drpCustomer.Location = new System.Drawing.Point(100, 17);
            this.drpCustomer.Name = "drpCustomer";
            this.drpCustomer.Size = new System.Drawing.Size(209, 21);
            this.drpCustomer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name :";
            // 
            // CustomPane
            // 
            this.Controls.Add(this.panel1);
            this.Name = "CustomPane";
            this.Size = new System.Drawing.Size(350, 172);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox drpCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox drpExportFormat;
        private System.Windows.Forms.Label lblExport;
    }
}
