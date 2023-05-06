namespace Stock_Management
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.loginButton.Location = new System.Drawing.Point(361, 201);
            this.loginButton.Margin = new System.Windows.Forms.Padding(5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(103, 73);
            this.loginButton.TabIndex = 12;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.clearButton.Location = new System.Drawing.Point(181, 201);
            this.clearButton.Margin = new System.Windows.Forms.Padding(5);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(104, 73);
            this.clearButton.TabIndex = 11;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.passwordLabel.Location = new System.Drawing.Point(76, 126);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(71, 17);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password :";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.usernameLabel.Location = new System.Drawing.Point(76, 66);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(74, 17);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username :";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(182, 122);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.PasswordChar = '#';
            this.passwordTextbox.Size = new System.Drawing.Size(282, 25);
            this.passwordTextbox.TabIndex = 8;
            this.passwordTextbox.Text = "admin123";
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(182, 66);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(5);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(282, 25);
            this.usernameTextbox.TabIndex = 7;
            this.usernameTextbox.Text = "admin";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 328);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox usernameTextbox;
    }
}