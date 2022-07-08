namespace Proje4_SineMA_Veritabanı_Uygulaması
{
    partial class PuanaGore
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
            this.tblSinemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSinemaDataSet1 = new Proje4_SineMA_Veritabanı_Uygulaması.DbSinemaDataSet1();
            this.tblSinemaTableAdapter = new Proje4_SineMA_Veritabanı_Uygulaması.DbSinemaDataSet1TableAdapters.TblSinemaTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proje4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSinemaDataSet2 = new Proje4_SineMA_Veritabanı_Uygulaması.DbSinemaDataSet2();
            this.proje4TableAdapter = new Proje4_SineMA_Veritabanı_Uygulaması.DbSinemaDataSet2TableAdapters.Proje4TableAdapter();
            this.dbSinemaDataSet7 = new Proje4_SineMA_Veritabanı_Uygulaması.DbSinemaDataSet7();
            this.dbSinemaDataSet7BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSinemaDataSet8 = new Proje4_SineMA_Veritabanı_Uygulaması.DbSinemaDataSet8();
            this.tblSinemaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblSinemaTableAdapter1 = new Proje4_SineMA_Veritabanı_Uygulaması.DbSinemaDataSet8TableAdapters.TblSinemaTableAdapter();
            this.filmAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisTarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet7BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinemaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(113, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Puanı Giriniz";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(228, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(49, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblSinemaBindingSource
            // 
            this.tblSinemaBindingSource.DataMember = "TblSinema";
            this.tblSinemaBindingSource.DataSource = this.dbSinemaDataSet1;
            // 
            // dbSinemaDataSet1
            // 
            this.dbSinemaDataSet1.DataSetName = "DbSinemaDataSet1";
            this.dbSinemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSinemaTableAdapter
            // 
            this.tblSinemaTableAdapter.ClearBeforeFill = true;
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
            this.dataGridView1.DataSource = this.tblSinemaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(91, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 141);
            this.dataGridView1.TabIndex = 4;
            // 
            // proje4BindingSource
            // 
            this.proje4BindingSource.DataMember = "Proje4";
            this.proje4BindingSource.DataSource = this.dbSinemaDataSet2;
            // 
            // dbSinemaDataSet2
            // 
            this.dbSinemaDataSet2.DataSetName = "DbSinemaDataSet2";
            this.dbSinemaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proje4TableAdapter
            // 
            this.proje4TableAdapter.ClearBeforeFill = true;
            // 
            // dbSinemaDataSet7
            // 
            this.dbSinemaDataSet7.DataSetName = "DbSinemaDataSet7";
            this.dbSinemaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbSinemaDataSet7BindingSource
            // 
            this.dbSinemaDataSet7BindingSource.DataSource = this.dbSinemaDataSet7;
            this.dbSinemaDataSet7BindingSource.Position = 0;
            // 
            // dbSinemaDataSet8
            // 
            this.dbSinemaDataSet8.DataSetName = "DbSinemaDataSet8";
            this.dbSinemaDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblSinemaBindingSource1
            // 
            this.tblSinemaBindingSource1.DataMember = "TblSinema";
            this.tblSinemaBindingSource1.DataSource = this.dbSinemaDataSet8;
            // 
            // tblSinemaTableAdapter1
            // 
            this.tblSinemaTableAdapter1.ClearBeforeFill = true;
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
            // PuanaGore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 247);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "PuanaGore";
            this.Text = "PuanaGore";
            this.Load += new System.EventHandler(this.PuanaGore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSinemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proje4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet7BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinemaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private DbSinemaDataSet1 dbSinemaDataSet1;
        private System.Windows.Forms.BindingSource tblSinemaBindingSource;
        private DbSinemaDataSet1TableAdapters.TblSinemaTableAdapter tblSinemaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbSinemaDataSet2 dbSinemaDataSet2;
        private System.Windows.Forms.BindingSource proje4BindingSource;
        private DbSinemaDataSet2TableAdapters.Proje4TableAdapter proje4TableAdapter;
        private DbSinemaDataSet7 dbSinemaDataSet7;
        private System.Windows.Forms.BindingSource dbSinemaDataSet7BindingSource;
        private DbSinemaDataSet8 dbSinemaDataSet8;
        private System.Windows.Forms.BindingSource tblSinemaBindingSource1;
        private DbSinemaDataSet8TableAdapters.TblSinemaTableAdapter tblSinemaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisTarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puanDataGridViewTextBoxColumn;
    }
}