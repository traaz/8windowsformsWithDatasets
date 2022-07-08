namespace Proje4_SineMA_Veritabanı_Uygulaması
{
    partial class ismeGoreArama
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
            this.tblSinemaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbSinemaDataSet = new Proje4_SineMA_Veritabanı_Uygulaması.DbSinemaDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilmAdi = new System.Windows.Forms.TextBox();
            this.tblSinemaTableAdapter = new Proje4_SineMA_Veritabanı_Uygulaması.DbSinemaDataSetTableAdapters.TblSinemaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.txtCikis = new System.Windows.Forms.TextBox();
            this.txtPuan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblSinemaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblSinemaBindingSource
            // 
            this.tblSinemaBindingSource.DataMember = "TblSinema";
            this.tblSinemaBindingSource.DataSource = this.dbSinemaDataSet;
            // 
            // dbSinemaDataSet
            // 
            this.dbSinemaDataSet.DataSetName = "DbSinemaDataSet";
            this.dbSinemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film İsmi";
            // 
            // txtFilmAdi
            // 
            this.txtFilmAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFilmAdi.Location = new System.Drawing.Point(188, 32);
            this.txtFilmAdi.Name = "txtFilmAdi";
            this.txtFilmAdi.Size = new System.Drawing.Size(100, 29);
            this.txtFilmAdi.TabIndex = 2;
            // 
            // tblSinemaTableAdapter
            // 
            this.tblSinemaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(47, 154);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(100, 20);
            this.txtTur.TabIndex = 4;
            // 
            // txtCikis
            // 
            this.txtCikis.Location = new System.Drawing.Point(188, 154);
            this.txtCikis.Name = "txtCikis";
            this.txtCikis.Size = new System.Drawing.Size(100, 20);
            this.txtCikis.TabIndex = 5;
            // 
            // txtPuan
            // 
            this.txtPuan.Location = new System.Drawing.Point(346, 154);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(100, 20);
            this.txtPuan.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tür";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Çıkış Tarihi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Puan";
            // 
            // ismeGoreArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 254);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPuan);
            this.Controls.Add(this.txtCikis);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFilmAdi);
            this.Controls.Add(this.label1);
            this.Name = "ismeGoreArama";
            this.Text = "ismeGoreArama";
            this.Load += new System.EventHandler(this.ismeGoreArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblSinemaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbSinemaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilmAdi;
        private DbSinemaDataSet dbSinemaDataSet;
        private System.Windows.Forms.BindingSource tblSinemaBindingSource;
        private DbSinemaDataSetTableAdapters.TblSinemaTableAdapter tblSinemaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.TextBox txtCikis;
        private System.Windows.Forms.TextBox txtPuan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}