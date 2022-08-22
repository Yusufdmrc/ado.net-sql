namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ad = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.yas = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ekle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.güncelle = new System.Windows.Forms.Button();
            this.listele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ad";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "yas";
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(150, 85);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(100, 20);
            this.ad.TabIndex = 3;
            // 
            // soyad
            // 
            this.soyad.Location = new System.Drawing.Point(150, 130);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(100, 20);
            this.soyad.TabIndex = 4;
            // 
            // yas
            // 
            this.yas.Location = new System.Drawing.Point(150, 176);
            this.yas.Name = "yas";
            this.yas.Size = new System.Drawing.Size(100, 20);
            this.yas.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 255);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(800, 195);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(519, 98);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 23);
            this.ekle.TabIndex = 7;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(519, 144);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 8;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // güncelle
            // 
            this.güncelle.Location = new System.Drawing.Point(519, 193);
            this.güncelle.Name = "güncelle";
            this.güncelle.Size = new System.Drawing.Size(75, 23);
            this.güncelle.TabIndex = 9;
            this.güncelle.Text = "Güncelle";
            this.güncelle.UseVisualStyleBackColor = true;
            this.güncelle.Click += new System.EventHandler(this.güncelle_Click);
            // 
            // listele
            // 
            this.listele.Location = new System.Drawing.Point(519, 54);
            this.listele.Name = "listele";
            this.listele.Size = new System.Drawing.Size(75, 23);
            this.listele.TabIndex = 11;
            this.listele.Text = "Listele";
            this.listele.UseVisualStyleBackColor = true;
            this.listele.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listele);
            this.Controls.Add(this.güncelle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.yas);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.ad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox yas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button güncelle;
        private System.Windows.Forms.Button listele;
    }
}

