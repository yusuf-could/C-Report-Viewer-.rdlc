﻿
namespace accounting.view
{
    partial class ListOfItem
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tblpawntmBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new accounting.DataSet1();
            this.tblpawn_tmTableAdapter = new accounting.DataSet1TableAdapters.tblpawn_tmTableAdapter();
            this.last_change_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FASILITAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NASABAH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pawnnoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pawnweightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pawnratevalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pawnappraisalvalueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appraisalbyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpawntmBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(278, 96);
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
            this.label1.Location = new System.Drawing.Point(128, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "s/d";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(162, 98);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(110, 24);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 24);
            this.dateTimePicker1.TabIndex = 19;
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
            this.last_change_date,
            this.FASILITAS,
            this.NASABAH,
            this.pawnnoteDataGridViewTextBoxColumn,
            this.pawnweightDataGridViewTextBoxColumn,
            this.pawnratevalueDataGridViewTextBoxColumn,
            this.pawnappraisalvalueDataGridViewTextBoxColumn,
            this.appraisalbyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblpawntmBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 127);
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
            this.dataGridView1.Size = new System.Drawing.Size(777, 369);
            this.dataGridView1.TabIndex = 18;
            // 
            // tblpawntmBindingSource
            // 
            this.tblpawntmBindingSource.DataMember = "tblpawn_tm";
            this.tblpawntmBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblpawn_tmTableAdapter
            // 
            this.tblpawn_tmTableAdapter.ClearBeforeFill = true;
            // 
            // last_change_date
            // 
            this.last_change_date.DataPropertyName = "last_change_date";
            this.last_change_date.HeaderText = "TANGGAL";
            this.last_change_date.Name = "last_change_date";
            this.last_change_date.ReadOnly = true;
            this.last_change_date.Width = 84;
            // 
            // FASILITAS
            // 
            this.FASILITAS.DataPropertyName = "facility_id";
            this.FASILITAS.HeaderText = "FASILITAS";
            this.FASILITAS.Name = "FASILITAS";
            this.FASILITAS.ReadOnly = true;
            this.FASILITAS.Width = 86;
            // 
            // NASABAH
            // 
            this.NASABAH.DataPropertyName = "customer_name";
            this.NASABAH.HeaderText = "NASABAH";
            this.NASABAH.Name = "NASABAH";
            this.NASABAH.ReadOnly = true;
            this.NASABAH.Width = 84;
            // 
            // pawnnoteDataGridViewTextBoxColumn
            // 
            this.pawnnoteDataGridViewTextBoxColumn.DataPropertyName = "pawn_note";
            this.pawnnoteDataGridViewTextBoxColumn.HeaderText = "BARANG";
            this.pawnnoteDataGridViewTextBoxColumn.Name = "pawnnoteDataGridViewTextBoxColumn";
            this.pawnnoteDataGridViewTextBoxColumn.ReadOnly = true;
            this.pawnnoteDataGridViewTextBoxColumn.Width = 77;
            // 
            // pawnweightDataGridViewTextBoxColumn
            // 
            this.pawnweightDataGridViewTextBoxColumn.DataPropertyName = "pawn_weight";
            this.pawnweightDataGridViewTextBoxColumn.HeaderText = "BERAT";
            this.pawnweightDataGridViewTextBoxColumn.Name = "pawnweightDataGridViewTextBoxColumn";
            this.pawnweightDataGridViewTextBoxColumn.ReadOnly = true;
            this.pawnweightDataGridViewTextBoxColumn.Width = 66;
            // 
            // pawnratevalueDataGridViewTextBoxColumn
            // 
            this.pawnratevalueDataGridViewTextBoxColumn.DataPropertyName = "pawn_rate_value";
            this.pawnratevalueDataGridViewTextBoxColumn.HeaderText = "KADAR";
            this.pawnratevalueDataGridViewTextBoxColumn.Name = "pawnratevalueDataGridViewTextBoxColumn";
            this.pawnratevalueDataGridViewTextBoxColumn.ReadOnly = true;
            this.pawnratevalueDataGridViewTextBoxColumn.Width = 69;
            // 
            // pawnappraisalvalueDataGridViewTextBoxColumn
            // 
            this.pawnappraisalvalueDataGridViewTextBoxColumn.DataPropertyName = "pawn_appraisal_value";
            this.pawnappraisalvalueDataGridViewTextBoxColumn.HeaderText = "TAKSIRAN";
            this.pawnappraisalvalueDataGridViewTextBoxColumn.Name = "pawnappraisalvalueDataGridViewTextBoxColumn";
            this.pawnappraisalvalueDataGridViewTextBoxColumn.ReadOnly = true;
            this.pawnappraisalvalueDataGridViewTextBoxColumn.Width = 85;
            // 
            // appraisalbyDataGridViewTextBoxColumn
            // 
            this.appraisalbyDataGridViewTextBoxColumn.DataPropertyName = "appraisal_by";
            this.appraisalbyDataGridViewTextBoxColumn.HeaderText = "PENAKSIR";
            this.appraisalbyDataGridViewTextBoxColumn.Name = "appraisalbyDataGridViewTextBoxColumn";
            this.appraisalbyDataGridViewTextBoxColumn.ReadOnly = true;
            this.appraisalbyDataGridViewTextBoxColumn.Width = 84;
            // 
            // ListOfItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 535);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListOfItem";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "List Of Item";
            this.Load += new System.EventHandler(this.ListOfItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblpawntmBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn pawnidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastappraisaldateDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblpawntmBindingSource;
        private DataSet1 dataSet1;
        private DataSet1TableAdapters.tblpawn_tmTableAdapter tblpawn_tmTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_change_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn FASILITAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NASABAH;
        private System.Windows.Forms.DataGridViewTextBoxColumn pawnnoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pawnweightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pawnratevalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pawnappraisalvalueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appraisalbyDataGridViewTextBoxColumn;
    }
}