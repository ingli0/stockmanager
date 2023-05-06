namespace Stock_Management
{
    partial class StockMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.providersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.receiptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditDocsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditDocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.logputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.providersToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.logputToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(737, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // providersToolStripMenuItem
            // 
            this.providersToolStripMenuItem.Name = "providersToolStripMenuItem";
            this.providersToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.providersToolStripMenuItem.Text = "Providers";
            this.providersToolStripMenuItem.Click += new System.EventHandler(this.providersToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receiptsToolStripMenuItem,
            this.invoicesToolStripMenuItem,
            this.creditDocsToolStripMenuItem,
            this.creditDocToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // receiptsToolStripMenuItem
            // 
            this.receiptsToolStripMenuItem.Name = "receiptsToolStripMenuItem";
            this.receiptsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.receiptsToolStripMenuItem.Text = "Receipt";
            // 
            // invoicesToolStripMenuItem
            // 
            this.invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            this.invoicesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.invoicesToolStripMenuItem.Text = "Invoice";
            // 
            // creditDocsToolStripMenuItem
            // 
            this.creditDocsToolStripMenuItem.Name = "creditDocsToolStripMenuItem";
            this.creditDocsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.creditDocsToolStripMenuItem.Text = "Pro Forma";
            // 
            // creditDocToolStripMenuItem
            // 
            this.creditDocToolStripMenuItem.Name = "creditDocToolStripMenuItem";
            this.creditDocToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.creditDocToolStripMenuItem.Text = "Credit Doc";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 566);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip.Size = new System.Drawing.Size(737, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // logputToolStripMenuItem
            // 
            this.logputToolStripMenuItem.Name = "logputToolStripMenuItem";
            this.logputToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logputToolStripMenuItem.Text = "Logout";
            this.logputToolStripMenuItem.Click += new System.EventHandler(this.logputToolStripMenuItem_Click);
            // 
            // StockMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 592);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StockMain";
            this.Text = "Stock App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StockMain_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem providersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiptsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditDocsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditDocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logputToolStripMenuItem;
    }
}



