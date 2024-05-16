using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Hotel_New
{
    public partial class Form1 : Form
    {

        string conn = "Data Source=LAPTOP-AV3B39KU\\MSSQLSERVER01;Initial Catalog=pc02;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // Create a linear gradient brush
            LinearGradientBrush brush = new LinearGradientBrush(
                ClientRectangle,
                Color.FromArgb(222, 221, 50), // Start color
                Color.FromArgb(255, 128, 0), // End color
                LinearGradientMode.Vertical); // Gradient mode (Vertical in this case)

            // Fill the form's background with the gradient brush
            e.Graphics.FillRectangle(brush, ClientRectangle);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtUsr.Text.Trim();
            string pwd = txtPwd.Text.Trim();

            SqlConnection cn = new SqlConnection(conn);
            cn.Open();

            string qry = $"SELECT COUNT(1) FROM log_validate WHERE username= '{name}' AND password= '{pwd}'";

            SqlCommand cmd = new SqlCommand(qry, cn);

            object validate = cmd.ExecuteScalar();


            try
            {
                if (validate != null)
                {

                    if (name == "Admin" && pwd == "test")
                    {
                        MessageBox.Show($"Login Successful! Welcome {name}");
                        AdminForm f = new AdminForm();
                        f.Show();
                        this.Hide();
                    }
                    else if (name == "Master" && pwd == "test")
                    {
                        MessageBox.Show($"Login Successful! Welcome {name}");
                        MasterForm f = new MasterForm();
                        f.Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again.");
                    }

                }
            }


            catch(Exception ex) {

                MessageBox.Show($"Login Failed: {ex.Message}");

            }

            




        }
    }
}
