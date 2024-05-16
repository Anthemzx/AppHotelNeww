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
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.ComponentModel.Design;


namespace App_Hotel_New
{
    public partial class Reaervation : Form
    {
        string conn = "Data Source=LAPTOP-AV3B39KU\\MSSQLSERVER01;Initial Catalog=pc02;Integrated Security=True";
        int mode;
        private DataTable transferredData = new DataTable();

        public Reaervation()
        {
            InitializeComponent();
            SqlConnection cn = new SqlConnection(conn);
            gridLoadType();
            gridLoadRoom();
            foreach (DataGridViewColumn column in GridR.Columns)
            {
                transferredData.Columns.Add(column.Name);
            }
        }

        private void TransferSelectedRow()
        {
            try
            {
                if (GridR.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = GridR.SelectedRows[0];

                    // Create a new row for the transferred data DataTable
                    DataRow newRow = transferredData.NewRow();
                    foreach (DataGridViewCell cell in selectedRow.Cells)
                    {
                        newRow[cell.ColumnIndex] = cell.Value;
                    }
                    transferredData.Rows.Add(newRow);

                    // Update the unconnected DataGridView
                    GridR2.DataSource = transferredData;

                    // Remove the selected row from the connected DataGridView
                    GridR.Rows.Remove(selectedRow);
                }
                else
                {
                    MessageBox.Show("Please select a row to transfer.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        private void TransferSelectedRowRev()
        {
            try
            {
                if (GridR2.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = GridR2.SelectedRows[0];

                    // Remove the selected row from the unconnected DataGridView
                    GridR2.Rows.Remove(selectedRow);

                    if (comType.SelectedItem != null)
                    {
                        // Get the selected DataRowView
                        DataRowView slect = (DataRowView)comType.SelectedItem;

                        // Retrieve the value from the DataRowView
                        string selectedItemText = slect.Row["Name"].ToString(); // Replace "ColumnName" with the actual column name

                        // Check if the selected item matches the desired value

                        gridLoadSpecific(selectedItemText);

                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to transfer.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void gridLoadType()
        {
            // SQL query to select data from your table
            string query = "SELECT * FROM Customers";
            try
            {
                // Create a SqlConnection
                using (SqlConnection cn = new SqlConnection(conn))
                {
                    // Create a SqlDataAdapter to retrieve data
                    SqlDataAdapter adapter = new SqlDataAdapter(query, cn);

                    // Create a DataTable to hold the data
                    DataTable dataTablee = new DataTable();

                    // Fill the DataTable with data from the database
                    adapter.Fill(dataTablee);

                    // Bind the DataTable to the DataGridView
                    Cgrid.DataSource = dataTablee;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}"); Close();
            }

        }

        private void gridLoadRoom()
        {
            string query = "SELECT RoomNumber, RoomFloor, Description FROM Room";

            try
            {
                using (SqlConnection cn = new SqlConnection(conn))
                {
                    SqlDataAdapter tr = new SqlDataAdapter(query, cn);
                    DataTable tl = new DataTable();

                    tr.Fill(tl);

                    GridR.DataSource = tl;
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("An Error has occurred :" + ex);
            }
        }

        private void gridLoadSpecific(string txt)
        {
            try
            {
               // MessageBox.Show(txt);

                if (txt == "Standard SIngle Bed")
                {
                    int id = 1;
                    string query = $"SELECT RoomNumber, RoomFloor, Description FROM Room WHERE RoomTypeID = '{id}'";

                    using (SqlConnection cn = new SqlConnection(conn))
                    {
                        SqlDataAdapter tr = new SqlDataAdapter(query, cn);
                        DataTable tl = new DataTable();

                        tr.Fill(tl);

                        foreach (DataRow row in transferredData.Rows)
                        {
                            DataRow foundRow = tl.AsEnumerable().FirstOrDefault(r => r["RoomNumber"].ToString() == row["RoomNumber"].ToString());
                            if (foundRow != null)
                            {
                                tl.Rows.Remove(foundRow);
                            }
                        }

                        GridR.DataSource = null;
                        GridR.Rows.Clear();
                        GridR.Columns.Clear();

                        // Rebind the DataGridView with the new data
                        GridR.DataSource = tl;

                    }
                }

                else if (txt == "Double Standard Bed")
                {
                    int id = 2;
                    string query = $"SELECT RoomNumber, RoomFloor, Description FROM Room WHERE RoomTypeID = '{id}'";

                    using (SqlConnection cn = new SqlConnection(conn))
                    {
                        SqlDataAdapter tr = new SqlDataAdapter(query, cn);
                        DataTable tl = new DataTable();

                        tr.Fill(tl);

                        foreach (DataRow row in transferredData.Rows)
                        {
                            DataRow foundRow = tl.AsEnumerable().FirstOrDefault(r => r["RoomNumber"].ToString() == row["RoomNumber"].ToString());
                            if (foundRow != null)
                            {
                                tl.Rows.Remove(foundRow);
                            }
                        }

                        GridR.DataSource = null;
                        GridR.Rows.Clear();
                        GridR.Columns.Clear();

                        // Rebind the DataGridView with the new data
                        GridR.DataSource = tl;

                    }
                }

                else 
                {
                    int id = 3;
                    string query = $"SELECT RoomNumber, RoomFloor, Description FROM Room WHERE RoomTypeID = '{id}'";

                    using (SqlConnection cn = new SqlConnection(conn))
                    {
                        SqlDataAdapter tr = new SqlDataAdapter(query, cn);
                        DataTable tl = new DataTable();

                        tr.Fill(tl);


                        foreach (DataRow row in transferredData.Rows)
                        {
                            DataRow foundRow = tl.AsEnumerable().FirstOrDefault(r => r["RoomNumber"].ToString() == row["RoomNumber"].ToString());
                            if (foundRow != null)
                            {
                                tl.Rows.Remove(foundRow);
                            }
                        }

                        GridR.DataSource = null;
                        GridR.Rows.Clear();
                        GridR.Columns.Clear();

                        // Rebind the DataGridView with the new data
                        GridR.DataSource = tl;

                    }
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex);
            }

        }

        private void Reaervation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pc02DataSet1.room_type' table. You can move, or remove it, as needed.
            this.room_typeTableAdapter1.Fill(this.pc02DataSet1.room_type);
           

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if an item is selected
                if (comType.SelectedItem != null)
                {
                    // Get the selected DataRowView
                    DataRowView selectedRow = (DataRowView)comType.SelectedItem;

                    // Retrieve the value from the DataRowView
                    string selectedItemText = selectedRow.Row["Name"].ToString(); // Replace "ColumnName" with the actual column name

                    // Check if the selected item matches the desired value

                        gridLoadSpecific(selectedItemText);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred in comboBox1_SelectedIndexChanged: " + ex.Message);
            }
        }

        private void toBooked_Click(object sender, EventArgs e)
        {
            TransferSelectedRow();
        }

        private void toAvail_Click(object sender, EventArgs e)
        {
            TransferSelectedRowRev();   
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Cgrid.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Cgrid.Visible = false;

        }

        private void CustomerS_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(conn))
            {
                string usrinput = txtCustomerSearch.Text.Trim();
                string query = "SELECT * FROM Customers WHERE Name LIKE @input";

                try
                {
                    cn.Open();

                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@input", "%" + usrinput + "%");

                    SqlDataAdapter tr = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable(); // Create a DataTable to hold the data
                    tr.Fill(dataTable);

                    // Debugging: Check if any rows were returned
                    if (dataTable.Rows.Count == 0)
                    {
                        MessageBox.Show("No matching records found.");
                    }

                    // Clear previous results
                    Cgrid.DataSource = null;
                    Cgrid.Rows.Clear();

                    // Bind the DataTable to the DataGridView
                    Cgrid.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }



    }
}

