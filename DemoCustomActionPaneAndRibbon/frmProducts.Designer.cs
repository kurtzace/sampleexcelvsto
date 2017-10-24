namespace DemoCustomActionPaneAndRibbon
{
    partial class frmProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProducts = new System.Windows.Forms.Label();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            this.productEntityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCategoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBottom.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEntityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.btnClose);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 263);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(588, 51);
            this.panelBottom.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(482, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.gridProducts);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(588, 263);
            this.panelMain.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblProducts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(588, 45);
            this.panel1.TabIndex = 2;
            // 
            // lblProducts
            // 
            this.lblProducts.AutoSize = true;
            this.lblProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducts.Location = new System.Drawing.Point(13, 13);
            this.lblProducts.Name = "lblProducts";
            this.lblProducts.Size = new System.Drawing.Size(117, 24);
            this.lblProducts.TabIndex = 0;
            this.lblProducts.Text = "Product List :";
            // 
            // gridProducts
            // 
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AutoGenerateColumns = false;
            this.gridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.unitPriceDataGridViewTextBoxColumn,
            this.reorderLevelDataGridViewTextBoxColumn,
            this.productCategoryDataGridViewTextBoxColumn});
            this.gridProducts.DataSource = this.productEntityBindingSource;
            this.gridProducts.Location = new System.Drawing.Point(0, 40);
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.Size = new System.Drawing.Size(588, 217);
            this.gridProducts.TabIndex = 0;
            // 
            // productEntityBindingSource
            // 
            this.productEntityBindingSource.DataSource = typeof(DemoCustomActionPaneAndRibbon.Models.ProductEntity);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Product ID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            this.unitPriceDataGridViewTextBoxColumn.DataPropertyName = "Unit Price";
            this.unitPriceDataGridViewTextBoxColumn.HeaderText = "UnitPrice";
            this.unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "Reorder Level";
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            // 
            // productCategoryDataGridViewTextBoxColumn
            // 
            this.productCategoryDataGridViewTextBoxColumn.DataPropertyName = "ProductCategory";
            this.productCategoryDataGridViewTextBoxColumn.HeaderText = "Product Category";
            this.productCategoryDataGridViewTextBoxColumn.Name = "productCategoryDataGridViewTextBoxColumn";
            this.productCategoryDataGridViewTextBoxColumn.Width = 150;
            // 
            // guiform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 314);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelBottom);
            this.Name = "guiform";
            this.Text = "Product Overview";
            this.panelBottom.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productEntityBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProducts;
        private System.Windows.Forms.DataGridView gridProducts;
        private System.Windows.Forms.BindingSource productEntityBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCategoryDataGridViewTextBoxColumn;
    }
}