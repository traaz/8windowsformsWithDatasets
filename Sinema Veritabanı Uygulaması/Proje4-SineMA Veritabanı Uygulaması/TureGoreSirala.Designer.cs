namespace Proje4_SineMA_Veritabanı_Uygulaması
{
    partial class TureGoreSirala
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbSinemaDataSet5 = new Proje4_SineMA_Veritabanı_Uygulaması.DbSinemaDataSet5();
            this.tblSinemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblSinemaTableAdapter = new Proje4_SineMA_Veritabanı_Uygulaması.DbSinemaDataSet5TableAdapters.TblSinemaTableAdapter();
            this.dbSinemaDataSet6 = new Proje4_SineMA_Veritabanı_Uygulaması.DbSinemaDataSet6();
            this.tblSinemaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblSinemaTableAdapter1 = new Proje4_SineMA_Veritabanı_Uygulaması.DbSinemaDataSet6TableAdapters.TblSinemaTableAdapter();
            this.dbSinemaDataSet7 = new Proje4_SineMA_Veritabanı_Uygulaması.DbSinemaDataSet7();
            this.tblSinemaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblSinemaTableAdapter2 = new Proje4_SineMA_Veritabanı_Uygulaması.DbSinemaDataSet7TableAdapters.TblSinemaTableAdapter();
            this.filmAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinemaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinemaBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(130, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Türü Giriniz";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(248, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmAdiDataGridViewTextBoxColumn,
            this.filmTuruDataGridViewTextBoxColumn,
            this.cikisTarihDataGridViewTextBoxColumn,
            this.puanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblSinemaBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(96, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // dbSinemaDataSet5
            // 
            this.dbSinemaDataSet5.DataSetName = "DbSinemaDataSet5";
            this.dbSinemaDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSinemaBindingSource
            // 
            this.tblSinemaBindingSource.DataMember = "TblSinema";
            this.tblSinemaBindingSource.DataSource = this.dbSinemaDataSet5;
            // 
            // tblSinemaTableAdapter
            // 
            this.tblSinemaTableAdapter.ClearBeforeFill = true;
            // 
            // dbSinemaDataSet6
            // 
            this.dbSinemaDataSet6.DataSetName = "DbSinemaDataSet6";
            this.dbSinemaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSinemaBindingSource1
            // 
            this.tblSinemaBindingSource1.DataMember = "TblSinema";
            this.tblSinemaBindingSource1.DataSource = this.dbSinemaDataSet6;
            // 
            // tblSinemaTableAdapter1
            // 
            this.tblSinemaTableAdapter1.ClearBeforeFill = true;
            // 
            // dbSinemaDataSet7
            // 
            this.dbSinemaDataSet7.DataSetName = "DbSinemaDataSet7";
            this.dbSinemaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSinemaBindingSource2
            // 
            this.tblSinemaBindingSource2.DataMember = "TblSinema";
            this.tblSinemaBindingSource2.DataSource = this.dbSinemaDataSet7;
            // 
            // tblSinemaTableAdapter2
            // 
            this.tblSinemaTableAdapter2.ClearBeforeFill = true;
            // 
            // filmAdiDataGridViewTextBoxColumn
            // 
            this.filmAdiDataGridViewTextBoxColumn.DataPropertyName = "FilmAdi";
            this.filmAdiDataGridViewTextBoxColumn.HeaderText = "FilmAdi";
            this.filmAdiDataGridViewTextBoxColumn.Name = "filmAdiDataGridViewTextBoxColumn";
            // 
            // filmTuruDataGridViewTextBoxColumn
            // 
            this.filmTuruDataGridViewTextBoxColumn.DataPropertyName = "FilmTuru";
            this.filmTuruDataGridViewTextBoxColumn.HeaderText = "FilmTuru";
            this.filmTuruDataGridViewTextBoxColumn.Name = "filmTuruDataGridViewTextBoxColumn";
            // 
            // cikisTarihDataGridViewTextBoxColumn
            // 
            this.cikisTarihDataGridViewTextBoxColumn.DataPropertyName = "CikisTarih";
            this.cikisTarihDataGridViewTextBoxColumn.HeaderText = "CikisTarih";
            this.cikisTarihDataGridViewTextBoxColumn.Name = "cikisTarihDataGridViewTextBoxColumn";
            // 
            // puanDataGridViewTextBoxColumn
            // 
            this.puanDataGridViewTextBoxColumn.DataPropertyName = "Puan";
            this.puanDataGridViewTextBoxColumn.HeaderText = "Puan";
            this.puanDataGridViewTextBoxColumn.Name = "puanDataGridViewTextBoxColumn";
            // 
            // TureGoreSirala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 344);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "TureGoreSirala";
            this.Text = "TureGoreSirala";
            this.Load += new System.EventHandler(this.TureGoreSirala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinemaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinemaBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbSinemaDataSet5 dbSinemaDataSet5;
        private System.Windows.Forms.BindingSource tblSinemaBindingSource;
        private DbSinemaDataSet5TableAdapters.TblSinemaTableAdapter tblSinemaTableAdapter;
        private DbSinemaDataSet6 dbSinemaDataSet6;
        private System.Windows.Forms.BindingSource tblSinemaBindingSource1;
        private DbSinemaDataSet6TableAdapters.TblSinemaTableAdapter tblSinemaTableAdapter1;
        private DbSinemaDataSet7 dbSinemaDataSet7;
        private System.Windows.Forms.BindingSource tblSinemaBindingSource2;
        private DbSinemaDataSet7TableAdapters.TblSinemaTableAdapter tblSinemaTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puanDataGridViewTextBoxColumn;
    }
}