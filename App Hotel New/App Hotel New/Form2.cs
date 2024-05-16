using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace App_Hotel_New
{
    public partial class Form2 : Form
    {

        string conn = "Data Source=LAPTOP-AV3B39KU\\MSSQLSERVER01;Initial Catalog=pc02;Integrated Security=True;Encrypt=False";
        public Form2()
        {
            InitializeComponent();
            SqlConnection cn = new SqlConnection(conn);

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pc02DataSet5.Data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.pc02DataSet5.Data);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection cn = new SqlConnection(conn))
            {
                string query = "SELECT Months, Guests FROM Datasurge";
                DataTable tb = new DataTable();
                SqlDataAdapter tr = new SqlDataAdapter(query, cn); 

                cn.Open();
                tr.Fill(tb);
                
                chart1.DataSource = tb;
                cn.Close();


                chart1.Series["Guests"].XValueMember = "Months";
                chart1.Series["Guests"].YValueMembers = "Guests";
                chart1.Titles.Add("Monthly Guests Data");


            }
            
        }
    }
}
