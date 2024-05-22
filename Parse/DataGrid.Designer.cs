namespace Parse
{
    partial class DataGrid
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ipAdressBindingSource = new System.Windows.Forms.BindingSource(components);
            idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            regionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            locDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            timezoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ipAdressBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { idDataGridViewTextBoxColumn, ipDataGridViewTextBoxColumn, regionDataGridViewTextBoxColumn, countryDataGridViewTextBoxColumn, locDataGridViewTextBoxColumn, orgDataGridViewTextBoxColumn, timezoneDataGridViewTextBoxColumn, cityDataGridViewTextBoxColumn });
            dataGridView1.DataSource = ipAdressBindingSource;
            dataGridView1.Location = new System.Drawing.Point(-2, -1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(1086, 379);
            dataGridView1.TabIndex = 0;
            // 
            // ipAdressBindingSource
            // 
            ipAdressBindingSource.DataSource = typeof(IpAdress);
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // ipDataGridViewTextBoxColumn
            // 
            ipDataGridViewTextBoxColumn.DataPropertyName = "ip";
            ipDataGridViewTextBoxColumn.HeaderText = "ip";
            ipDataGridViewTextBoxColumn.Name = "ipDataGridViewTextBoxColumn";
            // 
            // regionDataGridViewTextBoxColumn
            // 
            regionDataGridViewTextBoxColumn.DataPropertyName = "region";
            regionDataGridViewTextBoxColumn.HeaderText = "region";
            regionDataGridViewTextBoxColumn.Name = "regionDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            countryDataGridViewTextBoxColumn.DataPropertyName = "country";
            countryDataGridViewTextBoxColumn.HeaderText = "country";
            countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // locDataGridViewTextBoxColumn
            // 
            locDataGridViewTextBoxColumn.DataPropertyName = "loc";
            locDataGridViewTextBoxColumn.HeaderText = "loc";
            locDataGridViewTextBoxColumn.Name = "locDataGridViewTextBoxColumn";
            // 
            // orgDataGridViewTextBoxColumn
            // 
            orgDataGridViewTextBoxColumn.DataPropertyName = "org";
            orgDataGridViewTextBoxColumn.HeaderText = "org";
            orgDataGridViewTextBoxColumn.Name = "orgDataGridViewTextBoxColumn";
            // 
            // timezoneDataGridViewTextBoxColumn
            // 
            timezoneDataGridViewTextBoxColumn.DataPropertyName = "timezone";
            timezoneDataGridViewTextBoxColumn.HeaderText = "timezone";
            timezoneDataGridViewTextBoxColumn.Name = "timezoneDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            cityDataGridViewTextBoxColumn.DataPropertyName = "city";
            cityDataGridViewTextBoxColumn.HeaderText = "city";
            cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // DataGrid
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1076, 450);
            Controls.Add(dataGridView1);
            Name = "DataGrid";
            Text = "DataGrid";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ipAdressBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timezoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ipAdressBindingSource;
    }
}