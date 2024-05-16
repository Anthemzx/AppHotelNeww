namespace App_Hotel_New
{
    partial class MRType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MRType));
            this.txtNAME = new System.Windows.Forms.TextBox();
            this.txtPRICE = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCANCEL = new System.Windows.Forms.Button();
            this.btnSAVE = new System.Windows.Forms.Button();
            this.btnDEL = new System.Windows.Forms.Button();
            this.btnUP = new System.Windows.Forms.Button();
            this.btnIN = new System.Windows.Forms.Button();
            this.browseBtn = new System.Windows.Forms.Button();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.txtCAP = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCAP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNAME
            // 
            this.txtNAME.Location = new System.Drawing.Point(121, 18);
            this.txtNAME.Name = "txtNAME";
            this.txtNAME.Size = new System.Drawing.Size(315, 22);
            this.txtNAME.TabIndex = 8;
            this.txtNAME.TextChanged += new System.EventHandler(this.txtNAME_TextChanged);
            // 
            // txtPRICE
            // 
            this.txtPRICE.Location = new System.Drawing.Point(121, 81);
            this.txtPRICE.Name = "txtPRICE";
            this.txtPRICE.Size = new System.Drawing.Size(315, 22);
            this.txtPRICE.TabIndex = 10;
            this.txtPRICE.TextChanged += new System.EventHandler(this.txtPRICE_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Photo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room Price:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Capacity:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 312);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(494, 126);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCANCEL);
            this.groupBox1.Controls.Add(this.btnSAVE);
            this.groupBox1.Controls.Add(this.btnDEL);
            this.groupBox1.Controls.Add(this.btnUP);
            this.groupBox1.Controls.Add(this.btnIN);
            this.groupBox1.Location = new System.Drawing.Point(12, 435);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 48);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnCANCEL
            // 
            this.btnCANCEL.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCANCEL.FlatAppearance.BorderSize = 0;
            this.btnCANCEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCANCEL.Location = new System.Drawing.Point(403, 13);
            this.btnCANCEL.Name = "btnCANCEL";
            this.btnCANCEL.Size = new System.Drawing.Size(85, 29);
            this.btnCANCEL.TabIndex = 0;
            this.btnCANCEL.Text = "Cancel";
            this.btnCANCEL.UseVisualStyleBackColor = false;
            this.btnCANCEL.Click += new System.EventHandler(this.btnCANCEL_Click);
            // 
            // btnSAVE
            // 
            this.btnSAVE.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnSAVE.FlatAppearance.BorderSize = 0;
            this.btnSAVE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSAVE.Location = new System.Drawing.Point(312, 13);
            this.btnSAVE.Name = "btnSAVE";
            this.btnSAVE.Size = new System.Drawing.Size(85, 29);
            this.btnSAVE.TabIndex = 0;
            this.btnSAVE.Text = "Save";
            this.btnSAVE.UseVisualStyleBackColor = false;
            this.btnSAVE.Click += new System.EventHandler(this.btnSAVE_Click);
            // 
            // btnDEL
            // 
            this.btnDEL.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDEL.FlatAppearance.BorderSize = 0;
            this.btnDEL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDEL.Location = new System.Drawing.Point(212, 13);
            this.btnDEL.Name = "btnDEL";
            this.btnDEL.Size = new System.Drawing.Size(85, 29);
            this.btnDEL.TabIndex = 0;
            this.btnDEL.Text = "Delete";
            this.btnDEL.UseVisualStyleBackColor = false;
            this.btnDEL.Click += new System.EventHandler(this.btnDEL_Click);
            // 
            // btnUP
            // 
            this.btnUP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUP.FlatAppearance.BorderSize = 0;
            this.btnUP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUP.Image = global::App_Hotel_New.Properties.Resources.AdvancedProductionTracepointOn;
            this.btnUP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUP.Location = new System.Drawing.Point(109, 13);
            this.btnUP.Name = "btnUP";
            this.btnUP.Size = new System.Drawing.Size(85, 29);
            this.btnUP.TabIndex = 0;
            this.btnUP.Text = "Update";
            this.btnUP.UseVisualStyleBackColor = false;
            this.btnUP.Click += new System.EventHandler(this.btnUP_Click);
            // 
            // btnIN
            // 
            this.btnIN.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnIN.FlatAppearance.BorderSize = 0;
            this.btnIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIN.Image = global::App_Hotel_New.Properties.Resources.Abbreviation;
            this.btnIN.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIN.Location = new System.Drawing.Point(5, 13);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(85, 29);
            this.btnIN.TabIndex = 0;
            this.btnIN.TabStop = false;
            this.btnIN.Text = "Insert";
            this.btnIN.UseVisualStyleBackColor = false;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // browseBtn
            // 
            this.browseBtn.Image = ((System.Drawing.Image)(resources.GetObject("browseBtn.Image")));
            this.browseBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.browseBtn.Location = new System.Drawing.Point(22, 131);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(93, 23);
            this.browseBtn.TabIndex = 12;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // picBox1
            // 
            this.picBox1.InitialImage = null;
            this.picBox1.Location = new System.Drawing.Point(121, 110);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(383, 196);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 11;
            this.picBox1.TabStop = false;
            this.picBox1.Click += new System.EventHandler(this.picBox1_Click);
            // 
            // txtCAP
            // 
            this.txtCAP.Location = new System.Drawing.Point(121, 50);
            this.txtCAP.Name = "txtCAP";
            this.txtCAP.Size = new System.Drawing.Size(315, 22);
            this.txtCAP.TabIndex = 15;
            this.txtCAP.ValueChanged += new System.EventHandler(this.txtCAP_ValueChanged);
            // 
            // MRType
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 495);
            this.Controls.Add(this.txtCAP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.txtNAME);
            this.Controls.Add(this.txtPRICE);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MRType";
            this.Text = "MRType";
            this.Load += new System.EventHandler(this.MRType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.TextBox txtNAME;
        private System.Windows.Forms.TextBox txtPRICE;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIN;
        private System.Windows.Forms.Button btnCANCEL;
        private System.Windows.Forms.Button btnSAVE;
        private System.Windows.Forms.Button btnDEL;
        private System.Windows.Forms.Button btnUP;
        private System.Windows.Forms.NumericUpDown txtCAP;
    }
}