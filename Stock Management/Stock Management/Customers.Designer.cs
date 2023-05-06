namespace Stock_Management
{
    partial class Customers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers));
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCusCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCusCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCusEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCusCellphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCusAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCusTaxOffice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCusVATNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgCusDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerTaxOfficeTextBox = new System.Windows.Forms.TextBox();
            this.customerTaxOfficeLabel = new System.Windows.Forms.Label();
            this.customerAddressTextBox = new System.Windows.Forms.TextBox();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.customerEmailTextBox = new System.Windows.Forms.TextBox();
            this.customerEmailLabel = new System.Windows.Forms.Label();
            this.customerDateLabel = new System.Windows.Forms.Label();
            this.customerDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.customerCellphoneTextBox = new System.Windows.Forms.TextBox();
            this.customerCellphoneLabel = new System.Windows.Forms.Label();
            this.customerCompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.customerCodeTextBox = new System.Windows.Forms.TextBox();
            this.customerCompanyNameLabel = new System.Windows.Forms.Label();
            this.customerCodeLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.customerVATNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerVATNumberLabel = new System.Windows.Forms.Label();
            this.totalCustomersLabel = new System.Windows.Forms.Label();
            this.customerErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.productQuantityTextBox = new System.Windows.Forms.TextBox();
            this.productQuantityLabel = new System.Windows.Forms.Label();
            this.totalCustomersValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AllowUserToAddRows = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSno,
            this.dgCusCode,
            this.dgCusCompanyName,
            this.dgCusEmail,
            this.dgCusCellphone,
            this.dgCusAddress,
            this.dgCusTaxOffice,
            this.dgCusVATNumber,
            this.dgProCode,
            this.dgProQuantity,
            this.dgCusDate});
            this.customerDataGridView.Location = new System.Drawing.Point(33, 234);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerDataGridView.Size = new System.Drawing.Size(1182, 374);
            this.customerDataGridView.TabIndex = 60;
            this.customerDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.customerDataGridView_MouseDoubleClick);
            // 
            // dgSno
            // 
            this.dgSno.HeaderText = "S.No";
            this.dgSno.Name = "dgSno";
            this.dgSno.Width = 50;
            // 
            // dgCusCode
            // 
            this.dgCusCode.HeaderText = "Customer Code";
            this.dgCusCode.Name = "dgCusCode";
            // 
            // dgCusCompanyName
            // 
            this.dgCusCompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgCusCompanyName.HeaderText = "Company Name";
            this.dgCusCompanyName.Name = "dgCusCompanyName";
            // 
            // dgCusEmail
            // 
            this.dgCusEmail.HeaderText = "Email";
            this.dgCusEmail.Name = "dgCusEmail";
            this.dgCusEmail.Width = 120;
            // 
            // dgCusCellphone
            // 
            this.dgCusCellphone.HeaderText = "Cellphone";
            this.dgCusCellphone.Name = "dgCusCellphone";
            // 
            // dgCusAddress
            // 
            this.dgCusAddress.HeaderText = "Address";
            this.dgCusAddress.Name = "dgCusAddress";
            this.dgCusAddress.Width = 120;
            // 
            // dgCusTaxOffice
            // 
            this.dgCusTaxOffice.HeaderText = "Tax Office";
            this.dgCusTaxOffice.Name = "dgCusTaxOffice";
            // 
            // dgCusVATNumber
            // 
            this.dgCusVATNumber.HeaderText = "VAT Number";
            this.dgCusVATNumber.Name = "dgCusVATNumber";
            this.dgCusVATNumber.Width = 120;
            // 
            // dgProCode
            // 
            this.dgProCode.HeaderText = "Product Code";
            this.dgProCode.Name = "dgProCode";
            this.dgProCode.Width = 80;
            // 
            // dgProQuantity
            // 
            this.dgProQuantity.HeaderText = "Quantity";
            this.dgProQuantity.Name = "dgProQuantity";
            this.dgProQuantity.Width = 70;
            // 
            // dgCusDate
            // 
            this.dgCusDate.HeaderText = "Date";
            this.dgCusDate.Name = "dgCusDate";
            this.dgCusDate.Width = 80;
            // 
            // customerTaxOfficeTextBox
            // 
            this.customerTaxOfficeTextBox.Location = new System.Drawing.Point(640, 106);
            this.customerTaxOfficeTextBox.Name = "customerTaxOfficeTextBox";
            this.customerTaxOfficeTextBox.Size = new System.Drawing.Size(110, 25);
            this.customerTaxOfficeTextBox.TabIndex = 59;
            this.customerTaxOfficeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customerTaxOfficeTextBox_KeyDown);
            // 
            // customerTaxOfficeLabel
            // 
            this.customerTaxOfficeLabel.AutoSize = true;
            this.customerTaxOfficeLabel.Location = new System.Drawing.Point(637, 76);
            this.customerTaxOfficeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerTaxOfficeLabel.Name = "customerTaxOfficeLabel";
            this.customerTaxOfficeLabel.Size = new System.Drawing.Size(65, 17);
            this.customerTaxOfficeLabel.TabIndex = 58;
            this.customerTaxOfficeLabel.Text = "Tax Office";
            // 
            // customerAddressTextBox
            // 
            this.customerAddressTextBox.Location = new System.Drawing.Point(524, 106);
            this.customerAddressTextBox.Name = "customerAddressTextBox";
            this.customerAddressTextBox.Size = new System.Drawing.Size(110, 25);
            this.customerAddressTextBox.TabIndex = 57;
            this.customerAddressTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customerAddressTextBox_KeyDown);
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.Location = new System.Drawing.Point(521, 76);
            this.customerAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(56, 17);
            this.customerAddressLabel.TabIndex = 56;
            this.customerAddressLabel.Text = "Address";
            // 
            // customerEmailTextBox
            // 
            this.customerEmailTextBox.Location = new System.Drawing.Point(277, 106);
            this.customerEmailTextBox.Name = "customerEmailTextBox";
            this.customerEmailTextBox.Size = new System.Drawing.Size(125, 25);
            this.customerEmailTextBox.TabIndex = 55;
            this.customerEmailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customerEmailTextBox_KeyDown);
            // 
            // customerEmailLabel
            // 
            this.customerEmailLabel.AutoSize = true;
            this.customerEmailLabel.Location = new System.Drawing.Point(274, 76);
            this.customerEmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerEmailLabel.Name = "customerEmailLabel";
            this.customerEmailLabel.Size = new System.Drawing.Size(39, 17);
            this.customerEmailLabel.TabIndex = 54;
            this.customerEmailLabel.Text = "Email";
            // 
            // customerDateLabel
            // 
            this.customerDateLabel.AutoSize = true;
            this.customerDateLabel.Location = new System.Drawing.Point(1101, 76);
            this.customerDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerDateLabel.Name = "customerDateLabel";
            this.customerDateLabel.Size = new System.Drawing.Size(35, 17);
            this.customerDateLabel.TabIndex = 53;
            this.customerDateLabel.Text = "Date";
            // 
            // customerDateTimePicker
            // 
            this.customerDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.customerDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.customerDateTimePicker.Location = new System.Drawing.Point(1104, 106);
            this.customerDateTimePicker.Name = "customerDateTimePicker";
            this.customerDateTimePicker.Size = new System.Drawing.Size(111, 25);
            this.customerDateTimePicker.TabIndex = 52;
            this.customerDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customerDateTimePicker_KeyDown);
            // 
            // customerCellphoneTextBox
            // 
            this.customerCellphoneTextBox.Location = new System.Drawing.Point(408, 106);
            this.customerCellphoneTextBox.Name = "customerCellphoneTextBox";
            this.customerCellphoneTextBox.Size = new System.Drawing.Size(110, 25);
            this.customerCellphoneTextBox.TabIndex = 51;
            this.customerCellphoneTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customerCellphoneTextBox_KeyDown);
            this.customerCellphoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customerCellphoneTextBox_KeyPress);
            // 
            // customerCellphoneLabel
            // 
            this.customerCellphoneLabel.AutoSize = true;
            this.customerCellphoneLabel.Location = new System.Drawing.Point(405, 76);
            this.customerCellphoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerCellphoneLabel.Name = "customerCellphoneLabel";
            this.customerCellphoneLabel.Size = new System.Drawing.Size(66, 17);
            this.customerCellphoneLabel.TabIndex = 50;
            this.customerCellphoneLabel.Text = "Cellphone";
            // 
            // customerCompanyNameTextBox
            // 
            this.customerCompanyNameTextBox.Location = new System.Drawing.Point(149, 106);
            this.customerCompanyNameTextBox.Name = "customerCompanyNameTextBox";
            this.customerCompanyNameTextBox.Size = new System.Drawing.Size(122, 25);
            this.customerCompanyNameTextBox.TabIndex = 49;
            this.customerCompanyNameTextBox.TextChanged += new System.EventHandler(this.customerCompanyNameTextBox_TextChanged);
            this.customerCompanyNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customerCompanyNameTextBox_KeyDown);
            // 
            // customerCodeTextBox
            // 
            this.customerCodeTextBox.Location = new System.Drawing.Point(33, 106);
            this.customerCodeTextBox.Name = "customerCodeTextBox";
            this.customerCodeTextBox.Size = new System.Drawing.Size(110, 25);
            this.customerCodeTextBox.TabIndex = 48;
            this.customerCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customerCodeTextBox_KeyPress);
            // 
            // customerCompanyNameLabel
            // 
            this.customerCompanyNameLabel.AutoSize = true;
            this.customerCompanyNameLabel.Location = new System.Drawing.Point(146, 76);
            this.customerCompanyNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerCompanyNameLabel.Name = "customerCompanyNameLabel";
            this.customerCompanyNameLabel.Size = new System.Drawing.Size(102, 17);
            this.customerCompanyNameLabel.TabIndex = 47;
            this.customerCompanyNameLabel.Text = "Company Name";
            // 
            // customerCodeLabel
            // 
            this.customerCodeLabel.AutoSize = true;
            this.customerCodeLabel.Location = new System.Drawing.Point(30, 76);
            this.customerCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerCodeLabel.Name = "customerCodeLabel";
            this.customerCodeLabel.Size = new System.Drawing.Size(99, 17);
            this.customerCodeLabel.TabIndex = 46;
            this.customerCodeLabel.Text = "Customer Code";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(648, 150);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(83, 48);
            this.clearButton.TabIndex = 45;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(406, 150);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(114, 48);
            this.addButton.TabIndex = 44;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(527, 150);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(114, 48);
            this.deleteButton.TabIndex = 43;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Location = new System.Drawing.Point(872, 106);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(110, 25);
            this.productCodeTextBox.TabIndex = 62;
            this.productCodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productCodeTextBox_KeyDown);
            this.productCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productCodeTextBox_KeyPress);
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(869, 76);
            this.productCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(88, 17);
            this.productCodeLabel.TabIndex = 61;
            this.productCodeLabel.Text = "Product Code";
            // 
            // customerVATNumberTextBox
            // 
            this.customerVATNumberTextBox.Location = new System.Drawing.Point(756, 106);
            this.customerVATNumberTextBox.Name = "customerVATNumberTextBox";
            this.customerVATNumberTextBox.Size = new System.Drawing.Size(110, 25);
            this.customerVATNumberTextBox.TabIndex = 64;
            this.customerVATNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.customerVATNumberTextBox_KeyDown);
            this.customerVATNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.customerVATNumberTextBox_KeyPress);
            // 
            // customerVATNumberLabel
            // 
            this.customerVATNumberLabel.AutoSize = true;
            this.customerVATNumberLabel.Location = new System.Drawing.Point(753, 76);
            this.customerVATNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerVATNumberLabel.Name = "customerVATNumberLabel";
            this.customerVATNumberLabel.Size = new System.Drawing.Size(81, 17);
            this.customerVATNumberLabel.TabIndex = 63;
            this.customerVATNumberLabel.Text = "VAT Number";
            // 
            // totalCustomersLabel
            // 
            this.totalCustomersLabel.AutoSize = true;
            this.totalCustomersLabel.Location = new System.Drawing.Point(31, 622);
            this.totalCustomersLabel.Name = "totalCustomersLabel";
            this.totalCustomersLabel.Size = new System.Drawing.Size(105, 17);
            this.totalCustomersLabel.TabIndex = 65;
            this.totalCustomersLabel.Text = "Total Customers:";
            // 
            // customerErrorProvider
            // 
            this.customerErrorProvider.ContainerControl = this;
            // 
            // productQuantityTextBox
            // 
            this.productQuantityTextBox.Location = new System.Drawing.Point(988, 106);
            this.productQuantityTextBox.Name = "productQuantityTextBox";
            this.productQuantityTextBox.Size = new System.Drawing.Size(110, 25);
            this.productQuantityTextBox.TabIndex = 67;
            this.productQuantityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productQuantityTextBox_KeyDown);
            this.productQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productQuantityTextBox_KeyPress);
            // 
            // productQuantityLabel
            // 
            this.productQuantityLabel.AutoSize = true;
            this.productQuantityLabel.Location = new System.Drawing.Point(985, 76);
            this.productQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productQuantityLabel.Name = "productQuantityLabel";
            this.productQuantityLabel.Size = new System.Drawing.Size(56, 17);
            this.productQuantityLabel.TabIndex = 66;
            this.productQuantityLabel.Text = "Quantity";
            // 
            // totalCustomersValueLabel
            // 
            this.totalCustomersValueLabel.AutoSize = true;
            this.totalCustomersValueLabel.Location = new System.Drawing.Point(142, 622);
            this.totalCustomersValueLabel.Name = "totalCustomersValueLabel";
            this.totalCustomersValueLabel.Size = new System.Drawing.Size(0, 17);
            this.totalCustomersValueLabel.TabIndex = 68;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 654);
            this.Controls.Add(this.totalCustomersValueLabel);
            this.Controls.Add(this.productQuantityTextBox);
            this.Controls.Add(this.productQuantityLabel);
            this.Controls.Add(this.totalCustomersLabel);
            this.Controls.Add(this.customerVATNumberTextBox);
            this.Controls.Add(this.customerVATNumberLabel);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(this.productCodeLabel);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(this.customerTaxOfficeTextBox);
            this.Controls.Add(this.customerTaxOfficeLabel);
            this.Controls.Add(this.customerAddressTextBox);
            this.Controls.Add(this.customerAddressLabel);
            this.Controls.Add(this.customerEmailTextBox);
            this.Controls.Add(this.customerEmailLabel);
            this.Controls.Add(this.customerDateLabel);
            this.Controls.Add(this.customerDateTimePicker);
            this.Controls.Add(this.customerCellphoneTextBox);
            this.Controls.Add(this.customerCellphoneLabel);
            this.Controls.Add(this.customerCompanyNameTextBox);
            this.Controls.Add(this.customerCodeTextBox);
            this.Controls.Add(this.customerCompanyNameLabel);
            this.Controls.Add(this.customerCodeLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Customers";
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.Customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.TextBox customerTaxOfficeTextBox;
        private System.Windows.Forms.Label customerTaxOfficeLabel;
        private System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.Label customerAddressLabel;
        private System.Windows.Forms.TextBox customerEmailTextBox;
        private System.Windows.Forms.Label customerEmailLabel;
        private System.Windows.Forms.Label customerDateLabel;
        private System.Windows.Forms.DateTimePicker customerDateTimePicker;
        private System.Windows.Forms.TextBox customerCellphoneTextBox;
        private System.Windows.Forms.Label customerCellphoneLabel;
        private System.Windows.Forms.TextBox customerCompanyNameTextBox;
        private System.Windows.Forms.TextBox customerCodeTextBox;
        private System.Windows.Forms.Label customerCompanyNameLabel;
        private System.Windows.Forms.Label customerCodeLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.TextBox customerVATNumberTextBox;
        private System.Windows.Forms.Label customerVATNumberLabel;
        private System.Windows.Forms.Label totalCustomersLabel;
        private System.Windows.Forms.ErrorProvider customerErrorProvider;
        private System.Windows.Forms.TextBox productQuantityTextBox;
        private System.Windows.Forms.Label productQuantityLabel;
        private System.Windows.Forms.Label totalCustomersValueLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCusCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCusCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCusEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCusCellphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCusAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCusTaxOffice;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCusVATNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgCusDate;
    }
}