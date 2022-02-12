
namespace Ravenclaw.IkinciElArac.UI
{
    partial class frmSatilanAracListele
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
            this.grbAracArama = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.grbAracListesi = new System.Windows.Forms.GroupBox();
            this.dgvAracListesi = new System.Windows.Forms.DataGridView();
            this.grbKriterler = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStatu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAracMarka = new System.Windows.Forms.ComboBox();
            this.grbAracArama.SuspendLayout();
            this.grbAracListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAracListesi)).BeginInit();
            this.grbKriterler.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAracArama
            // 
            this.grbAracArama.Controls.Add(this.btnSil);
            this.grbAracArama.Controls.Add(this.btnGuncelle);
            this.grbAracArama.Controls.Add(this.grbAracListesi);
            this.grbAracArama.Controls.Add(this.grbKriterler);
            this.grbAracArama.Location = new System.Drawing.Point(29, 33);
            this.grbAracArama.Name = "grbAracArama";
            this.grbAracArama.Size = new System.Drawing.Size(973, 477);
            this.grbAracArama.TabIndex = 0;
            this.grbAracArama.TabStop = false;
            this.grbAracArama.Text = "Satıştaki Araçları Arama/Lİsteleme";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(755, 437);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(649, 437);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // grbAracListesi
            // 
            this.grbAracListesi.Controls.Add(this.dgvAracListesi);
            this.grbAracListesi.Location = new System.Drawing.Point(24, 102);
            this.grbAracListesi.Name = "grbAracListesi";
            this.grbAracListesi.Size = new System.Drawing.Size(905, 319);
            this.grbAracListesi.TabIndex = 1;
            this.grbAracListesi.TabStop = false;
            this.grbAracListesi.Text = "Arac Listesi";
            // 
            // dgvAracListesi
            // 
            this.dgvAracListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAracListesi.Location = new System.Drawing.Point(22, 28);
            this.dgvAracListesi.Name = "dgvAracListesi";
            this.dgvAracListesi.Size = new System.Drawing.Size(814, 264);
            this.dgvAracListesi.TabIndex = 0;
            this.dgvAracListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAracListesi_CellContentClick);
            // 
            // grbKriterler
            // 
            this.grbKriterler.Controls.Add(this.label3);
            this.grbKriterler.Controls.Add(this.cmbStatu);
            this.grbKriterler.Controls.Add(this.label2);
            this.grbKriterler.Controls.Add(this.cmbModel);
            this.grbKriterler.Controls.Add(this.label1);
            this.grbKriterler.Controls.Add(this.cmbAracMarka);
            this.grbKriterler.Location = new System.Drawing.Point(24, 36);
            this.grbKriterler.Name = "grbKriterler";
            this.grbKriterler.Size = new System.Drawing.Size(905, 60);
            this.grbKriterler.TabIndex = 0;
            this.grbKriterler.TabStop = false;
            this.grbKriterler.Text = "Kriterler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(456, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Statü ";
            // 
            // cmbStatu
            // 
            this.cmbStatu.FormattingEnabled = true;
            this.cmbStatu.Location = new System.Drawing.Point(497, 24);
            this.cmbStatu.Name = "cmbStatu";
            this.cmbStatu.Size = new System.Drawing.Size(121, 21);
            this.cmbStatu.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Model";
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(285, 24);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(121, 21);
            this.cmbModel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Arac Marka ";
            // 
            // cmbAracMarka
            // 
            this.cmbAracMarka.FormattingEnabled = true;
            this.cmbAracMarka.Location = new System.Drawing.Point(90, 24);
            this.cmbAracMarka.Name = "cmbAracMarka";
            this.cmbAracMarka.Size = new System.Drawing.Size(121, 21);
            this.cmbAracMarka.TabIndex = 0;
            this.cmbAracMarka.SelectedIndexChanged += new System.EventHandler(this.cmbAracMarka_SelectedIndexChanged);
            // 
            // frmSatilanAracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1143, 522);
            this.Controls.Add(this.grbAracArama);
            this.Name = "frmSatilanAracListele";
            this.Text = "frmSatilanAracListele";
            this.Load += new System.EventHandler(this.frmSatilanAracListele_Load);
            this.grbAracArama.ResumeLayout(false);
            this.grbAracListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAracListesi)).EndInit();
            this.grbKriterler.ResumeLayout(false);
            this.grbKriterler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAracArama;
        private System.Windows.Forms.GroupBox grbKriterler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStatu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAracMarka;
        private System.Windows.Forms.GroupBox grbAracListesi;
        private System.Windows.Forms.DataGridView dgvAracListesi;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
    }
}