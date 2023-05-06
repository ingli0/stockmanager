﻿namespace Stock_Management
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.productEditDateLabel = new System.Windows.Forms.Label();
            this.productEditDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productQuantityTextBox = new System.Windows.Forms.TextBox();
            this.productQuantityLabel = new System.Windows.Forms.Label();
            this.productNameTextBox = new System.Windows.Forms.TextBox();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.productCategoryTextBox = new System.Windows.Forms.TextBox();
            this.productCategoryLabel = new System.Windows.Forms.Label();
            this.productPriceTextBox = new System.Windows.Forms.TextBox();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productRealPriceTextBox = new System.Windows.Forms.TextBox();
            this.productRealPriceLabel = new System.Windows.Forms.Label();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
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
            this.productErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.totalProductsLabel = new System.Windows.Forms.Label();
            this.totalQuantityLabel = new System.Windows.Forms.Label();
            this.totalProductsValueLabel = new System.Windows.Forms.Label();
            this.totalQuantityValueLabel = new System.Windows.Forms.Label();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.productCreationDateLabel = new System.Windows.Forms.Label();
            this.productCreationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.productQuantityMinTextBox = new System.Windows.Forms.TextBox();
            this.productQuantityMinLabel = new System.Windows.Forms.Label();
            this.productReleaseDateTextBox = new System.Windows.Forms.TextBox();
            this.productReleaseDateLabel = new System.Windows.Forms.Label();
            this.bestSellersButton = new System.Windows.Forms.Button();
            this.productSalesFrequencyTextBox = new System.Windows.Forms.TextBox();
            this.productSalesFrequencyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // productEditDateLabel
            // 
            this.productEditDateLabel.AutoSize = true;
            this.productEditDateLabel.Location = new System.Drawing.Point(1018, 61);
            this.productEditDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productEditDateLabel.Name = "productEditDateLabel";
            this.productEditDateLabel.Size = new System.Drawing.Size(61, 17);
            this.productEditDateLabel.TabIndex = 35;
            this.productEditDateLabel.Text = "Edit Date";
            // 
            // productEditDateTimePicker
            // 
            this.productEditDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.productEditDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.productEditDateTimePicker.Location = new System.Drawing.Point(1021, 91);
            this.productEditDateTimePicker.Name = "productEditDateTimePicker";
            this.productEditDateTimePicker.Size = new System.Drawing.Size(100, 25);
            this.productEditDateTimePicker.TabIndex = 34;
            this.productEditDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productEditDateTimePicker_KeyDown);
            // 
            // productQuantityTextBox
            // 
            this.productQuantityTextBox.Location = new System.Drawing.Point(406, 91);
            this.productQuantityTextBox.Name = "productQuantityTextBox";
            this.productQuantityTextBox.Size = new System.Drawing.Size(117, 25);
            this.productQuantityTextBox.TabIndex = 33;
            this.productQuantityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productQuantityTextBox_KeyDown);
            this.productQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productQuantityTextBox_KeyPress);
            // 
            // productQuantityLabel
            // 
            this.productQuantityLabel.AutoSize = true;
            this.productQuantityLabel.Location = new System.Drawing.Point(403, 61);
            this.productQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productQuantityLabel.Name = "productQuantityLabel";
            this.productQuantityLabel.Size = new System.Drawing.Size(56, 17);
            this.productQuantityLabel.TabIndex = 32;
            this.productQuantityLabel.Text = "Quantity";
            // 
            // productNameTextBox
            // 
            this.productNameTextBox.Location = new System.Drawing.Point(160, 91);
            this.productNameTextBox.Name = "productNameTextBox";
            this.productNameTextBox.Size = new System.Drawing.Size(117, 25);
            this.productNameTextBox.TabIndex = 30;
            this.productNameTextBox.TextChanged += new System.EventHandler(this.productNameTextBox_TextChanged);
            this.productNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productNameTextBox_KeyDown);
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(157, 61);
            this.productNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(43, 17);
            this.productNameLabel.TabIndex = 27;
            this.productNameLabel.Text = "Name";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(652, 139);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(83, 48);
            this.clearButton.TabIndex = 25;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(410, 139);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 48);
            this.addButton.TabIndex = 24;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(531, 139);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(114, 48);
            this.deleteButton.TabIndex = 23;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // productCategoryTextBox
            // 
            this.productCategoryTextBox.Location = new System.Drawing.Point(283, 91);
            this.productCategoryTextBox.Name = "productCategoryTextBox";
            this.productCategoryTextBox.Size = new System.Drawing.Size(117, 25);
            this.productCategoryTextBox.TabIndex = 37;
            this.productCategoryTextBox.TextChanged += new System.EventHandler(this.productCategoryTextBox_TextChanged);
            this.productCategoryTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productCategoryTextBox_KeyDown);
            // 
            // productCategoryLabel
            // 
            this.productCategoryLabel.AutoSize = true;
            this.productCategoryLabel.Location = new System.Drawing.Point(280, 61);
            this.productCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productCategoryLabel.Name = "productCategoryLabel";
            this.productCategoryLabel.Size = new System.Drawing.Size(61, 17);
            this.productCategoryLabel.TabIndex = 36;
            this.productCategoryLabel.Text = "Category";
            // 
            // productPriceTextBox
            // 
            this.productPriceTextBox.Location = new System.Drawing.Point(775, 91);
            this.productPriceTextBox.Name = "productPriceTextBox";
            this.productPriceTextBox.Size = new System.Drawing.Size(117, 25);
            this.productPriceTextBox.TabIndex = 39;
            this.productPriceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productPriceTextBox_KeyDown);
            this.productPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productPriceTextBox_KeyPress);
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.Location = new System.Drawing.Point(772, 61);
            this.productPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(36, 17);
            this.productPriceLabel.TabIndex = 38;
            this.productPriceLabel.Text = "Price";
            // 
            // productRealPriceTextBox
            // 
            this.productRealPriceTextBox.Location = new System.Drawing.Point(898, 91);
            this.productRealPriceTextBox.Name = "productRealPriceTextBox";
            this.productRealPriceTextBox.Size = new System.Drawing.Size(117, 25);
            this.productRealPriceTextBox.TabIndex = 41;
            this.productRealPriceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productRealPriceTextBox_KeyDown);
            this.productRealPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productRealPriceTextBox_KeyPress);
            // 
            // productRealPriceLabel
            // 
            this.productRealPriceLabel.AutoSize = true;
            this.productRealPriceLabel.Location = new System.Drawing.Point(895, 61);
            this.productRealPriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productRealPriceLabel.Name = "productRealPriceLabel";
            this.productRealPriceLabel.Size = new System.Drawing.Size(65, 17);
            this.productRealPriceLabel.TabIndex = 40;
            this.productRealPriceLabel.Text = "Real Price";
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.productDataGridView.Location = new System.Drawing.Point(37, 218);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(1084, 366);
            this.productDataGridView.TabIndex = 42;
            this.productDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.productDataGridView_CellFormatting);
            this.productDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.productDataGridView_MouseDoubleClick);
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
            // productErrorProvider
            // 
            this.productErrorProvider.ContainerControl = this;
            // 
            // totalProductsLabel
            // 
            this.totalProductsLabel.AutoSize = true;
            this.totalProductsLabel.Location = new System.Drawing.Point(34, 599);
            this.totalProductsLabel.Name = "totalProductsLabel";
            this.totalProductsLabel.Size = new System.Drawing.Size(94, 17);
            this.totalProductsLabel.TabIndex = 43;
            this.totalProductsLabel.Text = "Total Products:";
            // 
            // totalQuantityLabel
            // 
            this.totalQuantityLabel.AutoSize = true;
            this.totalQuantityLabel.Location = new System.Drawing.Point(988, 599);
            this.totalQuantityLabel.Name = "totalQuantityLabel";
            this.totalQuantityLabel.Size = new System.Drawing.Size(91, 17);
            this.totalQuantityLabel.TabIndex = 44;
            this.totalQuantityLabel.Text = "Total Quantity:";
            // 
            // totalProductsValueLabel
            // 
            this.totalProductsValueLabel.AutoSize = true;
            this.totalProductsValueLabel.Location = new System.Drawing.Point(134, 599);
            this.totalProductsValueLabel.Name = "totalProductsValueLabel";
            this.totalProductsValueLabel.Size = new System.Drawing.Size(0, 17);
            this.totalProductsValueLabel.TabIndex = 45;
            // 
            // totalQuantityValueLabel
            // 
            this.totalQuantityValueLabel.AutoSize = true;
            this.totalQuantityValueLabel.Location = new System.Drawing.Point(1088, 599);
            this.totalQuantityValueLabel.Name = "totalQuantityValueLabel";
            this.totalQuantityValueLabel.Size = new System.Drawing.Size(0, 17);
            this.totalQuantityValueLabel.TabIndex = 46;
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Location = new System.Drawing.Point(37, 91);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(117, 25);
            this.productCodeTextBox.TabIndex = 29;
            this.productCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productCodeTextBox_KeyPress);
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(34, 61);
            this.productCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(88, 17);
            this.productCodeLabel.TabIndex = 26;
            this.productCodeLabel.Text = "Product Code";
            // 
            // productCreationDateLabel
            // 
            this.productCreationDateLabel.AutoSize = true;
            this.productCreationDateLabel.Location = new System.Drawing.Point(1018, 126);
            this.productCreationDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productCreationDateLabel.Name = "productCreationDateLabel";
            this.productCreationDateLabel.Size = new System.Drawing.Size(88, 17);
            this.productCreationDateLabel.TabIndex = 48;
            this.productCreationDateLabel.Text = "Creation Date";
            // 
            // productCreationDateTimePicker
            // 
            this.productCreationDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.productCreationDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.productCreationDateTimePicker.Location = new System.Drawing.Point(1021, 149);
            this.productCreationDateTimePicker.Name = "productCreationDateTimePicker";
            this.productCreationDateTimePicker.Size = new System.Drawing.Size(100, 25);
            this.productCreationDateTimePicker.TabIndex = 47;
            // 
            // productQuantityMinTextBox
            // 
            this.productQuantityMinTextBox.Location = new System.Drawing.Point(529, 91);
            this.productQuantityMinTextBox.Name = "productQuantityMinTextBox";
            this.productQuantityMinTextBox.Size = new System.Drawing.Size(117, 25);
            this.productQuantityMinTextBox.TabIndex = 50;
            this.productQuantityMinTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productQuantityMinTextBox_KeyDown);
            this.productQuantityMinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productQuantityMinTextBox_KeyPress);
            // 
            // productQuantityMinLabel
            // 
            this.productQuantityMinLabel.AutoSize = true;
            this.productQuantityMinLabel.Location = new System.Drawing.Point(526, 61);
            this.productQuantityMinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productQuantityMinLabel.Name = "productQuantityMinLabel";
            this.productQuantityMinLabel.Size = new System.Drawing.Size(82, 17);
            this.productQuantityMinLabel.TabIndex = 49;
            this.productQuantityMinLabel.Text = "Quantity Min";
            // 
            // productReleaseDateTextBox
            // 
            this.productReleaseDateTextBox.Location = new System.Drawing.Point(652, 91);
            this.productReleaseDateTextBox.Name = "productReleaseDateTextBox";
            this.productReleaseDateTextBox.Size = new System.Drawing.Size(117, 25);
            this.productReleaseDateTextBox.TabIndex = 52;
            this.productReleaseDateTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productReleaseDateTextBox_KeyDown);
            // 
            // productReleaseDateLabel
            // 
            this.productReleaseDateLabel.AutoSize = true;
            this.productReleaseDateLabel.Location = new System.Drawing.Point(649, 61);
            this.productReleaseDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productReleaseDateLabel.Name = "productReleaseDateLabel";
            this.productReleaseDateLabel.Size = new System.Drawing.Size(84, 17);
            this.productReleaseDateLabel.TabIndex = 51;
            this.productReleaseDateLabel.Text = "Release Date";
            // 
            // bestSellersButton
            // 
            this.bestSellersButton.Location = new System.Drawing.Point(529, 596);
            this.bestSellersButton.Name = "bestSellersButton";
            this.bestSellersButton.Size = new System.Drawing.Size(105, 48);
            this.bestSellersButton.TabIndex = 53;
            this.bestSellersButton.Text = "Best Sellers";
            this.bestSellersButton.UseVisualStyleBackColor = true;
            this.bestSellersButton.Click += new System.EventHandler(this.bestSellersButton_Click);
            // 
            // productSalesFrequencyTextBox
            // 
            this.productSalesFrequencyTextBox.Location = new System.Drawing.Point(898, 149);
            this.productSalesFrequencyTextBox.Name = "productSalesFrequencyTextBox";
            this.productSalesFrequencyTextBox.Size = new System.Drawing.Size(117, 25);
            this.productSalesFrequencyTextBox.TabIndex = 55;
            // 
            // productSalesFrequencyLabel
            // 
            this.productSalesFrequencyLabel.AutoSize = true;
            this.productSalesFrequencyLabel.Location = new System.Drawing.Point(895, 126);
            this.productSalesFrequencyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productSalesFrequencyLabel.Name = "productSalesFrequencyLabel";
            this.productSalesFrequencyLabel.Size = new System.Drawing.Size(101, 17);
            this.productSalesFrequencyLabel.TabIndex = 54;
            this.productSalesFrequencyLabel.Text = "Sales Frequency";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 656);
            this.Controls.Add(this.productSalesFrequencyTextBox);
            this.Controls.Add(this.productSalesFrequencyLabel);
            this.Controls.Add(this.bestSellersButton);
            this.Controls.Add(this.productReleaseDateTextBox);
            this.Controls.Add(this.productReleaseDateLabel);
            this.Controls.Add(this.productQuantityMinTextBox);
            this.Controls.Add(this.productQuantityMinLabel);
            this.Controls.Add(this.productCreationDateLabel);
            this.Controls.Add(this.productCreationDateTimePicker);
            this.Controls.Add(this.totalQuantityValueLabel);
            this.Controls.Add(this.totalProductsValueLabel);
            this.Controls.Add(this.totalQuantityLabel);
            this.Controls.Add(this.totalProductsLabel);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.productRealPriceTextBox);
            this.Controls.Add(this.productRealPriceLabel);
            this.Controls.Add(this.productPriceTextBox);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productCategoryTextBox);
            this.Controls.Add(this.productCategoryLabel);
            this.Controls.Add(this.productEditDateLabel);
            this.Controls.Add(this.productEditDateTimePicker);
            this.Controls.Add(this.productQuantityTextBox);
            this.Controls.Add(this.productQuantityLabel);
            this.Controls.Add(this.productNameTextBox);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productCodeLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Products";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productEditDateLabel;
        private System.Windows.Forms.DateTimePicker productEditDateTimePicker;
        private System.Windows.Forms.TextBox productQuantityTextBox;
        private System.Windows.Forms.Label productQuantityLabel;
        private System.Windows.Forms.TextBox productNameTextBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox productCategoryTextBox;
        private System.Windows.Forms.Label productCategoryLabel;
        private System.Windows.Forms.TextBox productPriceTextBox;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.TextBox productRealPriceTextBox;
        private System.Windows.Forms.Label productRealPriceLabel;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.ErrorProvider productErrorProvider;
        private System.Windows.Forms.Label totalProductsLabel;
        private System.Windows.Forms.Label totalQuantityValueLabel;
        private System.Windows.Forms.Label totalProductsValueLabel;
        private System.Windows.Forms.Label totalQuantityLabel;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.TextBox productQuantityMinTextBox;
        private System.Windows.Forms.Label productQuantityMinLabel;
        private System.Windows.Forms.Label productCreationDateLabel;
        private System.Windows.Forms.DateTimePicker productCreationDateTimePicker;
        private System.Windows.Forms.TextBox productSalesFrequencyTextBox;
        private System.Windows.Forms.Label productSalesFrequencyLabel;
        private System.Windows.Forms.Button bestSellersButton;
        private System.Windows.Forms.TextBox productReleaseDateTextBox;
        private System.Windows.Forms.Label productReleaseDateLabel;
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