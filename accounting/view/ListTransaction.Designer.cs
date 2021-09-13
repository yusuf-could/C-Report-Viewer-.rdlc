
namespace accounting.view
{
    partial class ListTransaction
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.facilitystartdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilityenddateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pawnnoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pawnappraisalvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilityamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productadmincostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acceptableamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listtransactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new accounting.DataSet1();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listtransactionTableAdapter = new accounting.DataSet1TableAdapters.ListtransactionTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listtransactionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.facilitystartdateDataGridViewTextBoxColumn,
            this.facilityenddateDataGridViewTextBoxColumn,
            this.facilityidDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.pawnnoteDataGridViewTextBoxColumn,
            this.pawnappraisalvalueDataGridViewTextBoxColumn,
            this.facilityamountDataGridViewTextBoxColumn,
            this.productadmincostDataGridViewTextBoxColumn,
            this.acceptableamountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listtransactionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(777, 362);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // facilitystartdateDataGridViewTextBoxColumn
            // 
            this.facilitystartdateDataGridViewTextBoxColumn.DataPropertyName = "facility_start_date";
            this.facilitystartdateDataGridViewTextBoxColumn.HeaderText = "TANGGAL";
            this.facilitystartdateDataGridViewTextBoxColumn.Name = "facilitystartdateDataGridViewTextBoxColumn";
            this.facilitystartdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.facilitystartdateDataGridViewTextBoxColumn.Width = 84;
            // 
            // facilityenddateDataGridViewTextBoxColumn
            // 
            this.facilityenddateDataGridViewTextBoxColumn.DataPropertyName = "facility_end_date";
            this.facilityenddateDataGridViewTextBoxColumn.HeaderText = "TEMPO";
            this.facilityenddateDataGridViewTextBoxColumn.Name = "facilityenddateDataGridViewTextBoxColumn";
            this.facilityenddateDataGridViewTextBoxColumn.ReadOnly = true;
            this.facilityenddateDataGridViewTextBoxColumn.Width = 70;
            // 
            // facilityidDataGridViewTextBoxColumn
            // 
            this.facilityidDataGridViewTextBoxColumn.DataPropertyName = "facility_id";
            this.facilityidDataGridViewTextBoxColumn.HeaderText = "FASILITAS";
            this.facilityidDataGridViewTextBoxColumn.Name = "facilityidDataGridViewTextBoxColumn";
            this.facilityidDataGridViewTextBoxColumn.ReadOnly = true;
            this.facilityidDataGridViewTextBoxColumn.Width = 86;
            // 
            // customernameDataGridViewTextBoxColumn
            // 
            this.customernameDataGridViewTextBoxColumn.DataPropertyName = "customer_name";
            this.customernameDataGridViewTextBoxColumn.HeaderText = "NAMA ";
            this.customernameDataGridViewTextBoxColumn.Name = "customernameDataGridViewTextBoxColumn";
            this.customernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.customernameDataGridViewTextBoxColumn.Width = 68;
            // 
            // pawnnoteDataGridViewTextBoxColumn
            // 
            this.pawnnoteDataGridViewTextBoxColumn.DataPropertyName = "pawn_note";
            this.pawnnoteDataGridViewTextBoxColumn.HeaderText = "NAMA BARANG";
            this.pawnnoteDataGridViewTextBoxColumn.Name = "pawnnoteDataGridViewTextBoxColumn";
            this.pawnnoteDataGridViewTextBoxColumn.ReadOnly = true;
            this.pawnnoteDataGridViewTextBoxColumn.Width = 104;
            // 
            // pawnappraisalvalueDataGridViewTextBoxColumn
            // 
            this.pawnappraisalvalueDataGridViewTextBoxColumn.DataPropertyName = "pawn_appraisal_value";
            this.pawnappraisalvalueDataGridViewTextBoxColumn.HeaderText = "TAKSIRAN";
            this.pawnappraisalvalueDataGridViewTextBoxColumn.Name = "pawnappraisalvalueDataGridViewTextBoxColumn";
            this.pawnappraisalvalueDataGridViewTextBoxColumn.ReadOnly = true;
            this.pawnappraisalvalueDataGridViewTextBoxColumn.Width = 85;
            // 
            // facilityamountDataGridViewTextBoxColumn
            // 
            this.facilityamountDataGridViewTextBoxColumn.DataPropertyName = "facility_amount";
            this.facilityamountDataGridViewTextBoxColumn.HeaderText = "PINJAMAN";
            this.facilityamountDataGridViewTextBoxColumn.Name = "facilityamountDataGridViewTextBoxColumn";
            this.facilityamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.facilityamountDataGridViewTextBoxColumn.Width = 88;
            // 
            // productadmincostDataGridViewTextBoxColumn
            // 
            this.productadmincostDataGridViewTextBoxColumn.DataPropertyName = "product_admin_cost";
            this.productadmincostDataGridViewTextBoxColumn.HeaderText = "ADMIN";
            this.productadmincostDataGridViewTextBoxColumn.Name = "productadmincostDataGridViewTextBoxColumn";
            this.productadmincostDataGridViewTextBoxColumn.ReadOnly = true;
            this.productadmincostDataGridViewTextBoxColumn.Width = 67;
            // 
            // acceptableamountDataGridViewTextBoxColumn
            // 
            this.acceptableamountDataGridViewTextBoxColumn.DataPropertyName = "acceptable_amount";
            this.acceptableamountDataGridViewTextBoxColumn.HeaderText = "JUMLAH";
            this.acceptableamountDataGridViewTextBoxColumn.Name = "acceptableamountDataGridViewTextBoxColumn";
            this.acceptableamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.acceptableamountDataGridViewTextBoxColumn.Width = 77;
            // 
            // listtransactionBindingSource
            // 
            this.listtransactionBindingSource.DataMember = "Listtransaction";
            this.listtransactionBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(282, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "s/d";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(166, 106);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(110, 24);
            this.dateTimePicker2.TabIndex = 15;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 24);
            this.dateTimePicker1.TabIndex = 14;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // listtransactionTableAdapter
            // 
            this.listtransactionTableAdapter.ClearBeforeFill = true;
            // 
            // ListTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListTransaction";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "List Transaction";
            this.Load += new System.EventHandler(this.ListTransaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listtransactionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.BindingSource listtransactionBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.ListtransactionTableAdapter listtransactionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilitystartdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilityenddateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilityidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pawnnoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pawnappraisalvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilityamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productadmincostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acceptableamountDataGridViewTextBoxColumn;
    }
}