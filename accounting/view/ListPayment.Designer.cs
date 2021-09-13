
namespace accounting.view
{
    partial class ListPayment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new accounting.DataSet1();
            this.paymentReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentReportTableAdapter = new accounting.DataSet1TableAdapters.PaymentReportTableAdapter();
            this.transactiondateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilityidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payeenoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facilitysamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentamountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentReportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(284, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 27;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "s/d";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(165, 103);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(113, 24);
            this.dateTimePicker2.TabIndex = 25;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 24);
            this.dateTimePicker1.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactiondateDataGridViewTextBoxColumn,
            this.facilityidDataGridViewTextBoxColumn,
            this.customernameDataGridViewTextBoxColumn,
            this.payeenoteDataGridViewTextBoxColumn,
            this.facilitysamountDataGridViewTextBoxColumn,
            this.paymentamountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.paymentReportBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(777, 395);
            this.dataGridView1.TabIndex = 23;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentReportBindingSource
            // 
            this.paymentReportBindingSource.DataMember = "PaymentReport";
            this.paymentReportBindingSource.DataSource = this.dataSet1;
            // 
            // paymentReportTableAdapter
            // 
            this.paymentReportTableAdapter.ClearBeforeFill = true;
            // 
            // transactiondateDataGridViewTextBoxColumn
            // 
            this.transactiondateDataGridViewTextBoxColumn.DataPropertyName = "transaction_date";
            this.transactiondateDataGridViewTextBoxColumn.HeaderText = "TANGGAL";
            this.transactiondateDataGridViewTextBoxColumn.Name = "transactiondateDataGridViewTextBoxColumn";
            this.transactiondateDataGridViewTextBoxColumn.ReadOnly = true;
            this.transactiondateDataGridViewTextBoxColumn.Width = 84;
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
            // payeenoteDataGridViewTextBoxColumn
            // 
            this.payeenoteDataGridViewTextBoxColumn.DataPropertyName = "payee_note";
            this.payeenoteDataGridViewTextBoxColumn.HeaderText = "KATERANGAN";
            this.payeenoteDataGridViewTextBoxColumn.Name = "payeenoteDataGridViewTextBoxColumn";
            this.payeenoteDataGridViewTextBoxColumn.ReadOnly = true;
            this.payeenoteDataGridViewTextBoxColumn.Width = 104;
            // 
            // facilitysamountDataGridViewTextBoxColumn
            // 
            this.facilitysamountDataGridViewTextBoxColumn.DataPropertyName = "facilitys_amount";
            this.facilitysamountDataGridViewTextBoxColumn.HeaderText = "PINJAMAN";
            this.facilitysamountDataGridViewTextBoxColumn.Name = "facilitysamountDataGridViewTextBoxColumn";
            this.facilitysamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.facilitysamountDataGridViewTextBoxColumn.Width = 88;
            // 
            // paymentamountDataGridViewTextBoxColumn
            // 
            this.paymentamountDataGridViewTextBoxColumn.DataPropertyName = "payment_amount";
            this.paymentamountDataGridViewTextBoxColumn.HeaderText = "PEMBAYARAN";
            this.paymentamountDataGridViewTextBoxColumn.Name = "paymentamountDataGridViewTextBoxColumn";
            this.paymentamountDataGridViewTextBoxColumn.ReadOnly = true;
            this.paymentamountDataGridViewTextBoxColumn.Width = 105;
            // 
            // ListPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 546);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListPayment";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "List Payment";
            this.Load += new System.EventHandler(this.ListPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentReportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource paymentReportBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.PaymentReportTableAdapter paymentReportTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactiondateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilityidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payeenoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facilitysamountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentamountDataGridViewTextBoxColumn;
    }
}