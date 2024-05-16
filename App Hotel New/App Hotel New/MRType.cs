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
using System.Threading;
using System.Data.Common;
using System.Xml.Linq;
using System.Runtime.ExceptionServices;
using System.IO;

namespace App_Hotel_New
{
    public partial class MRType : Form
    {
        bool MAIN = true;
        bool INmode;
        bool UPmode;
        bool DELmode;
        bool SAVEmode;
        bool CANCELmode;

        string imagePath = @"C:\Users\Fabian\OneDrive\Pictures\";
        // Connection string to your database
        string conn = "Data Source=LAPTOP-AV3B39KU\\MSSQLSERVER01;Initial Catalog=pc02;Integrated Security=True";
        
        public MRType()
        {
            InitializeComponent();
            SqlConnection cn = new SqlConnection(conn);
            gridLoad();
            StateChecker();

        }

        private void StateChecker()
        {
            if (INmode == true)
            {
                InsertMode();
            }
            else if (UPmode == true)
            {
                UpdateMode();
            }
            else if (MAIN == true)
            {
                btnSAVE.Enabled = false;
                btnCANCEL.Enabled = false;
                txtCAP.Enabled = false;
                txtNAME.Enabled = false;
                txtPRICE.Enabled = false;
                browseBtn.Enabled = false;

                //
                btnUP.Enabled = true;
                btnIN.Enabled = true;
                btnDEL.Enabled = true;

                picBox1.Image = null;
                txtCAP.Value = txtCAP.Minimum;
            }
            else if (DELmode == true)
            {
                DeleteMode();
            }
        }

       private void InsertMode()
        {
            btnCANCEL.Enabled = true;
            btnSAVE.Enabled = true;
            txtNAME.Enabled = true;
            txtCAP.Enabled = true;
            txtPRICE.Enabled = true;
            browseBtn.Enabled = true;

            //
            txtNAME.Clear();    
            // txtCAP.Clear(); <-- FIXME
            txtPRICE.Clear();
        }

        private void UpdateMode()
        {
            txtNAME.Enabled = true;
            txtCAP.Enabled = true;
            txtPRICE.Enabled = true;
            browseBtn.Enabled = true;

            //
            btnIN.Enabled = false;
            btnUP.Enabled = false;
            btnDEL.Enabled = false;

            //
            btnSAVE.Enabled = true;
            btnCANCEL.Enabled = true;
        }

        private void DeleteMode()
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conn))
                {
                    // Check if any row is selected
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Are you sure to delete this item?", "DeleteItem", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                        {
                            // Loop through all selected rows and delete them
                            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                            {
                                // Get the ID from the current row
                                int rowselect = (int)row.Cells["ID"].Value;

                                string query = "DELETE FROM room_type WHERE ID = @id";

                                SqlCommand cmd = new SqlCommand(query, cn);

                                cmd.Parameters.AddWithValue("@id", rowselect);

                                cn.Open(); // Open connection before executing the command
                                int rows = cmd.ExecuteNonQuery();
                                cn.Close();

                                if (rows > 0)
                                {
                                    MessageBox.Show("Record successfully deleted");
                                }
                            }

                            // Refresh the DataGridView after deletion
                            gridLoad();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No rows selected to delete.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An exception has occurred: " + ex.Message);
            }


            finally
            {
                DELmode = false;
                StateChecker();
            }

        }
        


        private void gridLoad()
        {
            // SQL query to select data from your table
            string query = "SELECT * FROM room_type";
            try
            {
                // Create a SqlConnection
                using (SqlConnection cn = new SqlConnection(conn))
                {
                    // Create a SqlDataAdapter to retrieve data
                    SqlDataAdapter adapter = new SqlDataAdapter(query, cn);

                    // Create a DataTable to hold the data
                    DataTable dataTable = new DataTable();

                    // Fill the DataTable with data from the database
                    adapter.Fill(dataTable);

                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show($"An error occurred: {ex.Message}"); Close();
            }
            
        }


        private void browseBtn_Click(object sender, EventArgs e)
        {
            // Get all image files from the folder
            string[] imageFiles = Directory.GetFiles(imagePath, "*.jpeg");

            // Check if there are any image files in the folder
            if (imageFiles.Length > 0)
            {
                // Generate a random index to select a random image file
                Random random = new Random();
                int randomIndex = random.Next(0, imageFiles.Length);

                // Load the selected random image into the PictureBox
                picBox1.Image = new System.Drawing.Bitmap(imageFiles[randomIndex]);
            }
            else
            {
                MessageBox.Show("No images found in the folder.");
            }
        }

        private void MRType_Load(object sender, EventArgs e)
        {
            
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            INmode = true;
            StateChecker();
        }

        private void btnSAVE_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(conn))
                {
                    if (INmode == true)
                    {
                        // Check for image presence
                        if (picBox1.Image == null)
                        {
                            MessageBox.Show("Error: Please insert an image as well");
                            return;
                        }

                        string name = txtNAME.Text;
                        int cap = int.Parse(txtCAP.Text);
                        int price = int.Parse(txtPRICE.Text);
                        byte[] imageData;
                        using (MemoryStream ms = new MemoryStream())
                        {
                            picBox1.Image.Save(ms, picBox1.Image.RawFormat);
                            imageData = ms.ToArray();
                        }

                        string query = "INSERT INTO room_type (Name, Capacity, RoomPrice, Photo) VALUES (@Name, @Capacity, @RoomPrice, @ImageData)";
                        SqlCommand cmd = new SqlCommand(query, cn);
                        cmd.Parameters.AddWithValue("@Name", name);
                        cmd.Parameters.AddWithValue("@Capacity", cap);
                        cmd.Parameters.AddWithValue("@RoomPrice", price);
                        cmd.Parameters.AddWithValue("@ImageData", imageData);

                        cn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        cn.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data inserted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to insert data!");
                        }
                    }
                    else if (UPmode == true && dataGridView1.SelectedRows.Count > 0)
                    {
                        // Your update logic goes here
                    }
                    else
                    {
                        MessageBox.Show("No mode selected for saving data.");
                    }

                    gridLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                UPmode = false;
                picBox1.Image = null;
                txtCAP.Value = txtCAP.Minimum;
                StateChecker();
            }
        }


        private void txtNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUP_Click(object sender, EventArgs e)
        {
            INmode = false;
            UPmode = true;
            StateChecker();
        }

        private void btnCANCEL_Click(object sender, EventArgs e)
        {
            MAIN =true;
            UPmode=false;
            INmode = false;
            StateChecker();
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            MAIN = false;
            UPmode=false;
            INmode = false;
            DELmode = true;
            StateChecker();
        }

        private void txtPRICE_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void picBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtCAP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
