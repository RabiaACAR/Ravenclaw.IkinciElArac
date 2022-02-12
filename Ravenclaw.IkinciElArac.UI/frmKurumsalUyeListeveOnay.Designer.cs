
namespace Ravenclaw.IkinciElArac.UI
{
    partial class frmKurumsalUyeListeveOnay
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.onaylaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbKurumsalOnay = new System.Windows.Forms.GroupBox();
            this.dgvKurumsalUyeListele = new System.Windows.Forms.DataGridView();
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.grbKurumsalOnay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurumsalUyeListele)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.onaylaToolStripMenuItem,
            this.silToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(112, 48);
            // 
            // onaylaToolStripMenuItem
            // 
            this.onaylaToolStripMenuItem.Name = "onaylaToolStripMenuItem";
            this.onaylaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.onaylaToolStripMenuItem.Text = "Onayla";
            this.onaylaToolStripMenuItem.Click += new System.EventHandler(this.onaylaToolStripMenuItem_Click);
            // 
            // grbKurumsalOnay
            // 
            this.grbKurumsalOnay.Controls.Add(this.dgvKurumsalUyeListele);
            this.grbKurumsalOnay.Location = new System.Drawing.Point(12, 24);
            this.grbKurumsalOnay.Name = "grbKurumsalOnay";
            this.grbKurumsalOnay.Size = new System.Drawing.Size(737, 385);
            this.grbKurumsalOnay.TabIndex = 2;
            this.grbKurumsalOnay.TabStop = false;
            this.grbKurumsalOnay.Text = "Kurumsal Müşteri Onaylama Ekranı";
            this.grbKurumsalOnay.Enter += new System.EventHandler(this.grbKurumsalOnay_Enter);
            // 
            // dgvKurumsalUyeListele
            // 
            this.dgvKurumsalUyeListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKurumsalUyeListele.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvKurumsalUyeListele.Location = new System.Drawing.Point(21, 32);
            this.dgvKurumsalUyeListele.Name = "dgvKurumsalUyeListele";
            this.dgvKurumsalUyeListele.Size = new System.Drawing.Size(688, 314);
            this.dgvKurumsalUyeListele.TabIndex = 1;
            this.dgvKurumsalUyeListele.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKurumsalUyeListele_CellContentClick);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // frmKurumsalUyeListeveOnay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbKurumsalOnay);
            this.Name = "frmKurumsalUyeListeveOnay";
            this.Text = "frmKurumsalUyeListeveOnay";
            this.Load += new System.EventHandler(this.frmKurumsalUyeListeveOnay_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.grbKurumsalOnay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKurumsalUyeListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem onaylaToolStripMenuItem;
        private System.Windows.Forms.GroupBox grbKurumsalOnay;
        private System.Windows.Forms.DataGridView dgvKurumsalUyeListele;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
    }
}