namespace App_Hotel_New
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pc02DataSet = new App_Hotel_New.pc02DataSet();
            this.roomtypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.room_typeTableAdapter = new App_Hotel_New.pc02DataSetTableAdapters.room_typeTableAdapter();
            this.pc02DataSet2 = new App_Hotel_New.pc02DataSet2();
            this.guestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestsTableAdapter = new App_Hotel_New.pc02DataSet2TableAdapters.GuestsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pc02DataSet3 = new App_Hotel_New.pc02DataSet3();
            this.guestsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.guestsTableAdapter1 = new App_Hotel_New.pc02DataSet3TableAdapters.GuestsTableAdapter();
            this.pc02DataSet4 = new App_Hotel_New.pc02DataSet4();
            this.guestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guestTableAdapter = new App_Hotel_New.pc02DataSet4TableAdapters.GuestTableAdapter();
            this.pc02DataSet5 = new App_Hotel_New.pc02DataSet5();
            this.dataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableAdapter = new App_Hotel_New.pc02DataSet5TableAdapters.DataTableAdapter();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc02DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc02DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc02DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc02DataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc02DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Location = new System.Drawing.Point(12, 199);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 390);
            this.panel1.TabIndex = 1;
            // 
            // pc02DataSet
            // 
            this.pc02DataSet.DataSetName = "pc02DataSet";
            this.pc02DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomtypeBindingSource
            // 
            this.roomtypeBindingSource.DataMember = "room_type";
            this.roomtypeBindingSource.DataSource = this.pc02DataSet;
            // 
            // room_typeTableAdapter
            // 
            this.room_typeTableAdapter.ClearBeforeFill = true;
            // 
            // pc02DataSet2
            // 
            this.pc02DataSet2.DataSetName = "pc02DataSet2";
            this.pc02DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestsBindingSource
            // 
            this.guestsBindingSource.DataMember = "Guests";
            this.guestsBindingSource.DataSource = this.pc02DataSet2;
            // 
            // guestsTableAdapter
            // 
            this.guestsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pc02DataSet3
            // 
            this.pc02DataSet3.DataSetName = "pc02DataSet3";
            this.pc02DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestsBindingSource1
            // 
            this.guestsBindingSource1.DataMember = "Guests";
            this.guestsBindingSource1.DataSource = this.pc02DataSet3;
            // 
            // guestsTableAdapter1
            // 
            this.guestsTableAdapter1.ClearBeforeFill = true;
            // 
            // pc02DataSet4
            // 
            this.pc02DataSet4.DataSetName = "pc02DataSet4";
            this.pc02DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guestBindingSource
            // 
            this.guestBindingSource.DataMember = "Guest";
            this.guestBindingSource.DataSource = this.pc02DataSet4;
            // 
            // guestTableAdapter
            // 
            this.guestTableAdapter.ClearBeforeFill = true;
            // 
            // pc02DataSet5
            // 
            this.pc02DataSet5.DataSetName = "pc02DataSet5";
            this.pc02DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataBindingSource
            // 
            this.dataBindingSource.DataMember = "Data";
            this.dataBindingSource.DataSource = this.pc02DataSet5;
            // 
            // dataTableAdapter
            // 
            this.dataTableAdapter.ClearBeforeFill = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Guests";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1144, 390);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 708);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pc02DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomtypeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc02DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc02DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc02DataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guestBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc02DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private pc02DataSet pc02DataSet;
        private System.Windows.Forms.BindingSource roomtypeBindingSource;
        private pc02DataSetTableAdapters.room_typeTableAdapter room_typeTableAdapter;
        private pc02DataSet2 pc02DataSet2;
        private System.Windows.Forms.BindingSource guestsBindingSource;
        private pc02DataSet2TableAdapters.GuestsTableAdapter guestsTableAdapter;
        private System.Windows.Forms.Button button1;
        private pc02DataSet3 pc02DataSet3;
        private System.Windows.Forms.BindingSource guestsBindingSource1;
        private pc02DataSet3TableAdapters.GuestsTableAdapter guestsTableAdapter1;
        private pc02DataSet4 pc02DataSet4;
        private System.Windows.Forms.BindingSource guestBindingSource;
        private pc02DataSet4TableAdapters.GuestTableAdapter guestTableAdapter;
        private pc02DataSet5 pc02DataSet5;
        private System.Windows.Forms.BindingSource dataBindingSource;
        private pc02DataSet5TableAdapters.DataTableAdapter dataTableAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}