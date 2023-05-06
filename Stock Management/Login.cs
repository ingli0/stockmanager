using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Management
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // .Text = "" and .Clear() do the same
            usernameTextbox.Text = "";
            passwordTextbox.Clear();

            usernameTextbox.Focus();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = Connection.GetConnection();
            SqlDataAdapter sda = new SqlDataAdapter(@"SELECT * FROM [dbo].[Login] Where UserName='" + usernameTextbox.Text + "' and Password='" + passwordTextbox.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                this.Hide();

                if (usernameTextbox.Text == "employee")
                {
                    Eform main2 = new Eform();
                    main2.Show();

                }
                else if (usernameTextbox.Text == "admin")
                {
                    StockMain main = new StockMain(); // pass username value to constructor
                    main.Show();
                    this.Hide();
                }
            }

            else
            {
                MessageBox.Show("Invalid Username & Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearButton_Click(sender, e);
            }
        }

    }
}
