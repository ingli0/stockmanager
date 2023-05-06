﻿namespace Stock_Management
{
    partial class BestSeller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestSeller));
            this.bestSellerProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.dgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProQuantityMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProRealPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProEditDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProCreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProSalesFrequency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.top10ProductsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bestSellerProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bestSellerProductsDataGridView
            // 
            this.bestSellerProductsDataGridView.AllowUserToAddRows = false;
            this.bestSellerProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bestSellerProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSno,
            this.dgProCode,
            this.dgProName,
            this.dgProCategory,
            this.dgProQuantity,
            this.dgProQuantityMin,
            this.dgProReleaseDate,
            this.dgProPrice,
            this.dgProRealPrice,
            this.dgProEditDate,
            this.dgProCreationDate,
            this.dgProSalesFrequency});
            this.bestSellerProductsDataGridView.Location = new System.Drawing.Point(47, 85);
            this.bestSellerProductsDataGridView.Name = "bestSellerProductsDataGridView";
            this.bestSellerProductsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bestSellerProductsDataGridView.Size = new System.Drawing.Size(1084, 265);
            this.bestSellerProductsDataGridView.TabIndex = 43;
            // 
            // dgSno
            // 
            this.dgSno.HeaderText = "S.No";
            this.dgSno.Name = "dgSno";
            this.dgSno.Width = 50;
            // 
            // dgProCode
            // 
            this.dgProCode.HeaderText = "Product Code";
            this.dgProCode.Name = "dgProCode";
            this.dgProCode.Width = 80;
            // 
            // dgProName
            // 
            this.dgProName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgProName.HeaderText = "Name";
            this.dgProName.Name = "dgProName";
            // 
            // dgProCategory
            // 
            this.dgProCategory.HeaderText = "Category";
            this.dgProCategory.Name = "dgProCategory";
            // 
            // dgProQuantity
            // 
            this.dgProQuantity.HeaderText = "Quantity";
            this.dgProQuantity.Name = "dgProQuantity";
            this.dgProQuantity.Width = 70;
            // 
            // dgProQuantityMin
            // 
            this.dgProQuantityMin.HeaderText = "Quantity Min";
            this.dgProQuantityMin.Name = "dgProQuantityMin";
            this.dgProQuantityMin.Width = 70;
            // 
            // dgProReleaseDate
            // 
            this.dgProReleaseDate.HeaderText = "Release Date";
            this.dgProReleaseDate.Name = "dgProReleaseDate";
            this.dgProReleaseDate.Width = 70;
            // 
            // dgProPrice
            // 
            this.dgProPrice.HeaderText = "Price";
            this.dgProPrice.Name = "dgProPrice";
            this.dgProPrice.Width = 70;
            // 
            // dgProRealPrice
            // 
            this.dgProRealPrice.HeaderText = "Real Price";
            this.dgProRealPrice.Name = "dgProRealPrice";
            this.dgProRealPrice.Width = 70;
            // 
            // dgProEditDate
            // 
            this.dgProEditDate.HeaderText = "Edit Date";
            this.dgProEditDate.Name = "dgProEditDate";
            // 
            // dgProCreationDate
            // 
            this.dgProCreationDate.HeaderText = "Creation Date";
            this.dgProCreationDate.Name = "dgProCreationDate";
            // 
            // dgProSalesFrequency
            // 
            this.dgProSalesFrequency.HeaderText = "Sales Frequency";
            this.dgProSalesFrequency.Name = "dgProSalesFrequency";
            // 
            // top10ProductsLabel
            // 
            this.top10ProductsLabel.AutoSize = true;
            this.top10ProductsLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.top10ProductsLabel.Location = new System.Drawing.Point(466, 24);
            this.top10ProductsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.top10ProductsLabel.Name = "top10ProductsLabel";
            this.top10ProductsLabel.Size = new System.Drawing.Size(217, 37);
            this.top10ProductsLabel.TabIndex = 44;
            this.top10ProductsLabel.Text = "Top 10 Products:";
            // 
            // BestSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 383);
            this.Controls.Add(this.top10ProductsLabel);
            this.Controls.Add(this.bestSellerProductsDataGridView);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BestSeller";
            this.Text = "Best Sellers";
            this.Load += new System.EventHandler(this.BestSeller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bestSellerProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView bestSellerProductsDataGridView;
        private System.Windows.Forms.Label top10ProductsLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProQuantityMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProRealPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProEditDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProCreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProSalesFrequency;
    }
}