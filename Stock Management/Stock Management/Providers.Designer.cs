namespace Stock_Management
{
    partial class Providers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Providers));
            this.providerDataGridView = new System.Windows.Forms.DataGridView();
            this.dgSno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProviderCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProviderCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProviderEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProviderCellphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProviderWebsite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgProviderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerWebsiteTextBox = new System.Windows.Forms.TextBox();
            this.providerWebsiteLabel = new System.Windows.Forms.Label();
            this.providerEmailTextBox = new System.Windows.Forms.TextBox();
            this.providerEmailLabel = new System.Windows.Forms.Label();
            this.providerDateLabel = new System.Windows.Forms.Label();
            this.providerDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.providerCellphoneTextBox = new System.Windows.Forms.TextBox();
            this.providerCellphoneLabel = new System.Windows.Forms.Label();
            this.providerCompanyNameTextBox = new System.Windows.Forms.TextBox();
            this.providerCodeTextBox = new System.Windows.Forms.TextBox();
            this.providerCompanyNameLabel = new System.Windows.Forms.Label();
            this.productCodeLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.providerErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.totalProvidersLabel = new System.Windows.Forms.Label();
            this.totalProvidersValueLabel = new System.Windows.Forms.Label();
            this.productQuantityTextBox = new System.Windows.Forms.TextBox();
            this.productQuantityLabel = new System.Windows.Forms.Label();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.providerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // providerDataGridView
            // 
            this.providerDataGridView.AllowUserToAddRows = false;
            this.providerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.providerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSno,
            this.dgProviderCode,
            this.dgProviderCompanyName,
            this.dgProviderEmail,
            this.dgProviderCellphone,
            this.dgProviderWebsite,
            this.dgProCode,
            this.dgProQuantity,
            this.dgProviderDate});
            this.providerDataGridView.Location = new System.Drawing.Point(50, 212);
            this.providerDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.providerDataGridView.Name = "providerDataGridView";
            this.providerDataGridView.RowHeadersWidth = 51;
            this.providerDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.providerDataGridView.Size = new System.Drawing.Size(939, 444);
            this.providerDataGridView.TabIndex = 60;
            this.providerDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.providerDataGridView_MouseDoubleClick);
            // 
            // dgSno
            // 
            this.dgSno.HeaderText = "S.No";
            this.dgSno.MinimumWidth = 6;
            this.dgSno.Name = "dgSno";
            this.dgSno.Width = 50;
            // 
            // dgProviderCode
            // 
            this.dgProviderCode.HeaderText = "Provider Code";
            this.dgProviderCode.MinimumWidth = 6;
            this.dgProviderCode.Name = "dgProviderCode";
            this.dgProviderCode.Width = 125;
            // 
            // dgProviderCompanyName
            // 
            this.dgProviderCompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgProviderCompanyName.HeaderText = "Company Name";
            this.dgProviderCompanyName.MinimumWidth = 6;
            this.dgProviderCompanyName.Name = "dgProviderCompanyName";
            // 
            // dgProviderEmail
            // 
            this.dgProviderEmail.HeaderText = "Email";
            this.dgProviderEmail.MinimumWidth = 6;
            this.dgProviderEmail.Name = "dgProviderEmail";
            this.dgProviderEmail.Width = 125;
            // 
            // dgProviderCellphone
            // 
            this.dgProviderCellphone.HeaderText = "Cellphone";
            this.dgProviderCellphone.MinimumWidth = 6;
            this.dgProviderCellphone.Name = "dgProviderCellphone";
            this.dgProviderCellphone.Width = 125;
            // 
            // dgProviderWebsite
            // 
            this.dgProviderWebsite.HeaderText = "Website";
            this.dgProviderWebsite.MinimumWidth = 6;
            this.dgProviderWebsite.Name = "dgProviderWebsite";
            this.dgProviderWebsite.Width = 125;
            // 
            // dgProCode
            // 
            this.dgProCode.HeaderText = "Product Code";
            this.dgProCode.MinimumWidth = 6;
            this.dgProCode.Name = "dgProCode";
            this.dgProCode.Width = 80;
            // 
            // dgProQuantity
            // 
            this.dgProQuantity.HeaderText = "Quantity";
            this.dgProQuantity.MinimumWidth = 6;
            this.dgProQuantity.Name = "dgProQuantity";
            this.dgProQuantity.Width = 80;
            // 
            // dgProviderDate
            // 
            this.dgProviderDate.HeaderText = "Date";
            this.dgProviderDate.MinimumWidth = 6;
            this.dgProviderDate.Name = "dgProviderDate";
            this.dgProviderDate.Width = 80;
            // 
            // providerWebsiteTextBox
            // 
            this.providerWebsiteTextBox.Location = new System.Drawing.Point(530, 84);
            this.providerWebsiteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.providerWebsiteTextBox.Name = "providerWebsiteTextBox";
            this.providerWebsiteTextBox.Size = new System.Drawing.Size(112, 29);
            this.providerWebsiteTextBox.TabIndex = 57;
            this.providerWebsiteTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.providerWebsiteTextBox_KeyDown);
            // 
            // providerWebsiteLabel
            // 
            this.providerWebsiteLabel.AutoSize = true;
            this.providerWebsiteLabel.Location = new System.Drawing.Point(527, 50);
            this.providerWebsiteLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.providerWebsiteLabel.Name = "providerWebsiteLabel";
            this.providerWebsiteLabel.Size = new System.Drawing.Size(70, 23);
            this.providerWebsiteLabel.TabIndex = 56;
            this.providerWebsiteLabel.Text = "Website";
            // 
            // providerEmailTextBox
            // 
            this.providerEmailTextBox.Location = new System.Drawing.Point(290, 84);
            this.providerEmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.providerEmailTextBox.Name = "providerEmailTextBox";
            this.providerEmailTextBox.Size = new System.Drawing.Size(112, 29);
            this.providerEmailTextBox.TabIndex = 55;
            this.providerEmailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.providerEmailTextBox_KeyDown);
            // 
            // providerEmailLabel
            // 
            this.providerEmailLabel.AutoSize = true;
            this.providerEmailLabel.Location = new System.Drawing.Point(287, 50);
            this.providerEmailLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.providerEmailLabel.Name = "providerEmailLabel";
            this.providerEmailLabel.Size = new System.Drawing.Size(51, 23);
            this.providerEmailLabel.TabIndex = 54;
            this.providerEmailLabel.Text = "Email";
            // 
            // providerDateLabel
            // 
            this.providerDateLabel.AutoSize = true;
            this.providerDateLabel.Location = new System.Drawing.Point(883, 54);
            this.providerDateLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.providerDateLabel.Name = "providerDateLabel";
            this.providerDateLabel.Size = new System.Drawing.Size(46, 23);
            this.providerDateLabel.TabIndex = 53;
            this.providerDateLabel.Text = "Date";
            // 
            // providerDateTimePicker
            // 
            this.providerDateTimePicker.CustomFormat = "MM/dd/yyyy";
            this.providerDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.providerDateTimePicker.Location = new System.Drawing.Point(886, 84);
            this.providerDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.providerDateTimePicker.Name = "providerDateTimePicker";
            this.providerDateTimePicker.Size = new System.Drawing.Size(103, 29);
            this.providerDateTimePicker.TabIndex = 52;
            this.providerDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.providerDateTimePicker_KeyDown);
            // 
            // providerCellphoneTextBox
            // 
            this.providerCellphoneTextBox.Location = new System.Drawing.Point(410, 84);
            this.providerCellphoneTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.providerCellphoneTextBox.Name = "providerCellphoneTextBox";
            this.providerCellphoneTextBox.Size = new System.Drawing.Size(112, 29);
            this.providerCellphoneTextBox.TabIndex = 51;
            this.providerCellphoneTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.providerCellphoneTextBox_KeyDown);
            this.providerCellphoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.providerCellphoneTextBox_KeyPress);
            // 
            // providerCellphoneLabel
            // 
            this.providerCellphoneLabel.AutoSize = true;
            this.providerCellphoneLabel.Location = new System.Drawing.Point(407, 50);
            this.providerCellphoneLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.providerCellphoneLabel.Name = "providerCellphoneLabel";
            this.providerCellphoneLabel.Size = new System.Drawing.Size(87, 23);
            this.providerCellphoneLabel.TabIndex = 50;
            this.providerCellphoneLabel.Text = "Cellphone";
            // 
            // providerCompanyNameTextBox
            // 
            this.providerCompanyNameTextBox.Location = new System.Drawing.Point(170, 84);
            this.providerCompanyNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.providerCompanyNameTextBox.Name = "providerCompanyNameTextBox";
            this.providerCompanyNameTextBox.Size = new System.Drawing.Size(112, 29);
            this.providerCompanyNameTextBox.TabIndex = 49;
            this.providerCompanyNameTextBox.TextChanged += new System.EventHandler(this.providerCompanyNameTextBox_TextChanged);
            this.providerCompanyNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.providerCompanyNameTextBox_KeyDown);
            // 
            // providerCodeTextBox
            // 
            this.providerCodeTextBox.Location = new System.Drawing.Point(50, 84);
            this.providerCodeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.providerCodeTextBox.Name = "providerCodeTextBox";
            this.providerCodeTextBox.Size = new System.Drawing.Size(112, 29);
            this.providerCodeTextBox.TabIndex = 48;
            this.providerCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.providerCodeTextBox_KeyPress);
            // 
            // providerCompanyNameLabel
            // 
            this.providerCompanyNameLabel.AutoSize = true;
            this.providerCompanyNameLabel.Location = new System.Drawing.Point(166, 50);
            this.providerCompanyNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.providerCompanyNameLabel.Name = "providerCompanyNameLabel";
            this.providerCompanyNameLabel.Size = new System.Drawing.Size(134, 23);
            this.providerCompanyNameLabel.TabIndex = 47;
            this.providerCompanyNameLabel.Text = "Company Name";
            // 
            // productCodeLabel
            // 
            this.productCodeLabel.AutoSize = true;
            this.productCodeLabel.Location = new System.Drawing.Point(47, 50);
            this.productCodeLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.productCodeLabel.Name = "productCodeLabel";
            this.productCodeLabel.Size = new System.Drawing.Size(118, 23);
            this.productCodeLabel.TabIndex = 46;
            this.productCodeLabel.Text = "Provider Code";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(637, 130);
            this.clearButton.Margin = new System.Windows.Forms.Padding(5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(97, 43);
            this.clearButton.TabIndex = 45;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(354, 130);
            this.addButton.Margin = new System.Windows.Forms.Padding(5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(133, 43);
            this.addButton.TabIndex = 44;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(495, 130);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(5);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(133, 43);
            this.deleteButton.TabIndex = 43;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // providerErrorProvider
            // 
            this.providerErrorProvider.ContainerControl = this;
            // 
            // totalProvidersLabel
            // 
            this.totalProvidersLabel.AutoSize = true;
            this.totalProvidersLabel.Location = new System.Drawing.Point(47, 674);
            this.totalProvidersLabel.Name = "totalProvidersLabel";
            this.totalProvidersLabel.Size = new System.Drawing.Size(125, 23);
            this.totalProvidersLabel.TabIndex = 61;
            this.totalProvidersLabel.Text = "Total Providers:";
            // 
            // totalProvidersValueLabel
            // 
            this.totalProvidersValueLabel.AutoSize = true;
            this.totalProvidersValueLabel.Location = new System.Drawing.Point(151, 674);
            this.totalProvidersValueLabel.Name = "totalProvidersValueLabel";
            this.totalProvidersValueLabel.Size = new System.Drawing.Size(0, 23);
            this.totalProvidersValueLabel.TabIndex = 62;
            // 
            // productQuantityTextBox
            // 
            this.productQuantityTextBox.Location = new System.Drawing.Point(767, 84);
            this.productQuantityTextBox.Name = "productQuantityTextBox";
            this.productQuantityTextBox.Size = new System.Drawing.Size(112, 29);
            this.productQuantityTextBox.TabIndex = 71;
            this.productQuantityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productQuantityTextBox_KeyDown);
            this.productQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productQuantityTextBox_KeyPress);
            // 
            // productQuantityLabel
            // 
            this.productQuantityLabel.AutoSize = true;
            this.productQuantityLabel.Location = new System.Drawing.Point(764, 54);
            this.productQuantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productQuantityLabel.Name = "productQuantityLabel";
            this.productQuantityLabel.Size = new System.Drawing.Size(76, 23);
            this.productQuantityLabel.TabIndex = 70;
            this.productQuantityLabel.Text = "Quantity";
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Location = new System.Drawing.Point(649, 84);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.Size = new System.Drawing.Size(112, 29);
            this.productCodeTextBox.TabIndex = 69;
            this.productCodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productCodeTextBox_KeyDown);
            this.productCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productCodeTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(646, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 23);
            this.label1.TabIndex = 68;
            this.label1.Text = "Product Code";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 672);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 72;
            this.button1.Text = "WEBSITE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Providers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 707);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.productQuantityTextBox);
            this.Controls.Add(this.productQuantityLabel);
            this.Controls.Add(this.productCodeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalProvidersValueLabel);
            this.Controls.Add(this.totalProvidersLabel);
            this.Controls.Add(this.providerDataGridView);
            this.Controls.Add(this.providerWebsiteTextBox);
            this.Controls.Add(this.providerWebsiteLabel);
            this.Controls.Add(this.providerEmailTextBox);
            this.Controls.Add(this.providerEmailLabel);
            this.Controls.Add(this.providerDateLabel);
            this.Controls.Add(this.providerDateTimePicker);
            this.Controls.Add(this.providerCellphoneTextBox);
            this.Controls.Add(this.providerCellphoneLabel);
            this.Controls.Add(this.providerCompanyNameTextBox);
            this.Controls.Add(this.providerCodeTextBox);
            this.Controls.Add(this.providerCompanyNameLabel);
            this.Controls.Add(this.productCodeLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.deleteButton);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Providers";
            this.Text = "Providers";
            this.Load += new System.EventHandler(this.Providers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.providerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView providerDataGridView;
        private System.Windows.Forms.TextBox providerWebsiteTextBox;
        private System.Windows.Forms.Label providerWebsiteLabel;
        private System.Windows.Forms.TextBox providerEmailTextBox;
        private System.Windows.Forms.Label providerEmailLabel;
        private System.Windows.Forms.Label providerDateLabel;
        private System.Windows.Forms.DateTimePicker providerDateTimePicker;
        private System.Windows.Forms.TextBox providerCellphoneTextBox;
        private System.Windows.Forms.Label providerCellphoneLabel;
        private System.Windows.Forms.TextBox providerCompanyNameTextBox;
        private System.Windows.Forms.TextBox providerCodeTextBox;
        private System.Windows.Forms.Label providerCompanyNameLabel;
        private System.Windows.Forms.Label productCodeLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ErrorProvider providerErrorProvider;
        private System.Windows.Forms.Label totalProvidersLabel;
        private System.Windows.Forms.Label totalProvidersValueLabel;
        private System.Windows.Forms.TextBox productQuantityTextBox;
        private System.Windows.Forms.Label productQuantityLabel;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProviderCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProviderCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProviderEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProviderCellphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProviderWebsite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgProviderDate;
        private System.Windows.Forms.Button button1;
    }
}