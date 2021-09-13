
namespace accounting.view
{
    partial class CustomerList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerktpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customertempatlahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerdobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customeraddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerrtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerrwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerkecamatanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerkelurahanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerkotakabupatenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerprovinsiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customertelpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerhpDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changebyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastchangedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblcustomertm1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new accounting.DataSet1();
            this.tblcustomer_tm1TableAdapter = new accounting.DataSet1TableAdapters.tblcustomer_tm1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomertm1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(277, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 22;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "s/d";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(162, 107);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(109, 24);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 24);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.customerktpDataGridViewTextBoxColumn,
            this.customertempatlahirDataGridViewTextBoxColumn,
            this.customerdobDataGridViewTextBoxColumn,
            this.customeraddressDataGridViewTextBoxColumn,
            this.customerrtDataGridViewTextBoxColumn,
            this.customerrwDataGridViewTextBoxColumn,
            this.customerkecamatanDataGridViewTextBoxColumn,
            this.customerkelurahanDataGridViewTextBoxColumn,
            this.customerkotakabupatenDataGridViewTextBoxColumn,
            this.customerprovinsiDataGridViewTextBoxColumn,
            this.customertelpDataGridViewTextBoxColumn,
            this.customerhpDataGridViewTextBoxColumn,
            this.changebyDataGridViewTextBoxColumn,
            this.lastchangedateDataGridViewTextBoxColumn,
            this.cIFDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblcustomertm1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(10, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(777, 386);
            this.dataGridView1.TabIndex = 18;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "NO";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            this.customeridDataGridViewTextBoxColumn.ReadOnly = true;
            this.customeridDataGridViewTextBoxColumn.Width = 47;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "NAMA";
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            this.customernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customernameDataGridViewTextBoxColumn.Width = 65;
            // 
            // customerktpDataGridViewTextBoxColumn
            // 
            this.customerktpDataGridViewTextBoxColumn.DataPropertyName = "customer_ktp";
            this.customerktpDataGridViewTextBoxColumn.HeaderText = "KTP";
            this.customerktpDataGridViewTextBoxColumn.Name = "customerktpDataGridViewTextBoxColumn";
            this.customerktpDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerktpDataGridViewTextBoxColumn.Width = 53;
            // 
            // customertempatlahirDataGridViewTextBoxColumn
            // 
            this.customertempatlahirDataGridViewTextBoxColumn.DataPropertyName = "customer_tempat_lahir";
            this.customertempatlahirDataGridViewTextBoxColumn.HeaderText = "TMP LAHIR";
            this.customertempatlahirDataGridViewTextBoxColumn.Name = "customertempatlahirDataGridViewTextBoxColumn";
            this.customertempatlahirDataGridViewTextBoxColumn.ReadOnly = true;
            this.customertempatlahirDataGridViewTextBoxColumn.Width = 91;
            // 
            // customerdobDataGridViewTextBoxColumn
            // 
            this.customerdobDataGridViewTextBoxColumn.DataPropertyName = "customer_dob";
            this.customerdobDataGridViewTextBoxColumn.HeaderText = "TGL LAHIR";
            this.customerdobDataGridViewTextBoxColumn.Name = "customerdobDataGridViewTextBoxColumn";
            this.customerdobDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerdobDataGridViewTextBoxColumn.Width = 89;
            // 
            // customeraddressDataGridViewTextBoxColumn
            // 
            this.customeraddressDataGridViewTextBoxColumn.DataPropertyName = "customer_address";
            this.customeraddressDataGridViewTextBoxColumn.HeaderText = "ALAMAT";
            this.customeraddressDataGridViewTextBoxColumn.Name = "customeraddressDataGridViewTextBoxColumn";
            this.customeraddressDataGridViewTextBoxColumn.ReadOnly = true;
            this.customeraddressDataGridViewTextBoxColumn.Width = 79;
            // 
            // customerrtDataGridViewTextBoxColumn
            // 
            this.customerrtDataGridViewTextBoxColumn.DataPropertyName = "customer_rt";
            this.customerrtDataGridViewTextBoxColumn.HeaderText = "RT";
            this.customerrtDataGridViewTextBoxColumn.Name = "customerrtDataGridViewTextBoxColumn";
            this.customerrtDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerrtDataGridViewTextBoxColumn.Width = 46;
            // 
            // customerrwDataGridViewTextBoxColumn
            // 
            this.customerrwDataGridViewTextBoxColumn.DataPropertyName = "customer_rw";
            this.customerrwDataGridViewTextBoxColumn.HeaderText = "RW";
            this.customerrwDataGridViewTextBoxColumn.Name = "customerrwDataGridViewTextBoxColumn";
            this.customerrwDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerrwDataGridViewTextBoxColumn.Width = 49;
            // 
            // customerkecamatanDataGridViewTextBoxColumn
            // 
            this.customerkecamatanDataGridViewTextBoxColumn.DataPropertyName = "customer_kecamatan";
            this.customerkecamatanDataGridViewTextBoxColumn.HeaderText = "KECAMATAN";
            this.customerkecamatanDataGridViewTextBoxColumn.Name = "customerkecamatanDataGridViewTextBoxColumn";
            this.customerkecamatanDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerkecamatanDataGridViewTextBoxColumn.Width = 99;
            // 
            // customerkelurahanDataGridViewTextBoxColumn
            // 
            this.customerkelurahanDataGridViewTextBoxColumn.DataPropertyName = "customer_kelurahan";
            this.customerkelurahanDataGridViewTextBoxColumn.HeaderText = "KELURAHAN";
            this.customerkelurahanDataGridViewTextBoxColumn.Name = "customerkelurahanDataGridViewTextBoxColumn";
            this.customerkelurahanDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerkelurahanDataGridViewTextBoxColumn.Width = 96;
            // 
            // customerkotakabupatenDataGridViewTextBoxColumn
            // 
            this.customerkotakabupatenDataGridViewTextBoxColumn.DataPropertyName = "customer_kotakabupaten";
            this.customerkotakabupatenDataGridViewTextBoxColumn.HeaderText = "KOTA/KAB";
            this.customerkotakabupatenDataGridViewTextBoxColumn.Name = "customerkotakabupatenDataGridViewTextBoxColumn";
            this.customerkotakabupatenDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerkotakabupatenDataGridViewTextBoxColumn.Width = 86;
            // 
            // customerprovinsiDataGridViewTextBoxColumn
            // 
            this.customerprovinsiDataGridViewTextBoxColumn.DataPropertyName = "customer_provinsi";
            this.customerprovinsiDataGridViewTextBoxColumn.HeaderText = "PROVINSI";
            this.customerprovinsiDataGridViewTextBoxColumn.Name = "customerprovinsiDataGridViewTextBoxColumn";
            this.customerprovinsiDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerprovinsiDataGridViewTextBoxColumn.Width = 82;
            // 
            // customertelpDataGridViewTextBoxColumn
            // 
            this.customertelpDataGridViewTextBoxColumn.DataPropertyName = "customer_telp";
            this.customertelpDataGridViewTextBoxColumn.HeaderText = "TELPON";
            this.customertelpDataGridViewTextBoxColumn.Name = "customertelpDataGridViewTextBoxColumn";
            this.customertelpDataGridViewTextBoxColumn.ReadOnly = true;
            this.customertelpDataGridViewTextBoxColumn.Width = 74;
            // 
            // customerhpDataGridViewTextBoxColumn
            // 
            this.customerhpDataGridViewTextBoxColumn.DataPropertyName = "customer_hp";
            this.customerhpDataGridViewTextBoxColumn.HeaderText = "HP";
            this.customerhpDataGridViewTextBoxColumn.Name = "customerhpDataGridViewTextBoxColumn";
            this.customerhpDataGridViewTextBoxColumn.ReadOnly = true;
            this.customerhpDataGridViewTextBoxColumn.Width = 46;
            // 
            // changebyDataGridViewTextBoxColumn
            // 
            this.changebyDataGridViewTextBoxColumn.DataPropertyName = "change_by";
            this.changebyDataGridViewTextBoxColumn.HeaderText = "CHANGE";
            this.changebyDataGridViewTextBoxColumn.Name = "changebyDataGridViewTextBoxColumn";
            this.changebyDataGridViewTextBoxColumn.ReadOnly = true;
            this.changebyDataGridViewTextBoxColumn.Width = 76;
            // 
            // lastchangedateDataGridViewTextBoxColumn
            // 
            this.lastchangedateDataGridViewTextBoxColumn.DataPropertyName = "last_change_date";
            this.lastchangedateDataGridViewTextBoxColumn.HeaderText = "TANGGAL";
            this.lastchangedateDataGridViewTextBoxColumn.Name = "lastchangedateDataGridViewTextBoxColumn";
            this.lastchangedateDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastchangedateDataGridViewTextBoxColumn.Width = 84;
            // 
            // cIFDataGridViewTextBoxColumn
            // 
            this.cIFDataGridViewTextBoxColumn.DataPropertyName = "CIF";
            this.cIFDataGridViewTextBoxColumn.HeaderText = "CIF";
            this.cIFDataGridViewTextBoxColumn.Name = "cIFDataGridViewTextBoxColumn";
            this.cIFDataGridViewTextBoxColumn.ReadOnly = true;
            this.cIFDataGridViewTextBoxColumn.Width = 49;
            // 
            // tblcustomertm1BindingSource
            // 
            this.tblcustomertm1BindingSource.DataMember = "tblcustomer_tm1";
            this.tblcustomertm1BindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblcustomer_tm1TableAdapter
            // 
            this.tblcustomer_tm1TableAdapter.ClearBeforeFill = true;
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CustomerList";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Customer List";
            this.Load += new System.EventHandler(this.CustomerList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblcustomertm1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource tblcustomertm1BindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.tblcustomer_tm1TableAdapter tblcustomer_tm1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerktpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customertempatlahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerdobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customeraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerrtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerrwDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerkecamatanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerkelurahanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerkotakabupatenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerprovinsiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customertelpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerhpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn changebyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastchangedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIFDataGridViewTextBoxColumn;
    }
}