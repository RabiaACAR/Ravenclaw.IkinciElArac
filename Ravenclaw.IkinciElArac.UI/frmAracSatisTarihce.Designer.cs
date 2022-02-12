
namespace Ravenclaw.IkinciElArac.UI
{
    partial class frmAracSatisTarihce
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
            this.grbAracTarihce = new System.Windows.Forms.GroupBox();
            this.dtvAracSatisTarihce = new System.Windows.Forms.DataGridView();
            this.grbAracTarihce.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtvAracSatisTarihce)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAracTarihce
            // 
            this.grbAracTarihce.Controls.Add(this.dtvAracSatisTarihce);
            this.grbAracTarihce.Location = new System.Drawing.Point(42, 42);
            this.grbAracTarihce.Name = "grbAracTarihce";
            this.grbAracTarihce.Size = new System.Drawing.Size(666, 323);
            this.grbAracTarihce.TabIndex = 0;
            this.grbAracTarihce.TabStop = false;
            this.grbAracTarihce.Text = "Araç Tarihçe Bilgileri";
            // 
            // dtvAracSatisTarihce
            // 
            this.dtvAracSatisTarihce.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtvAracSatisTarihce.Location = new System.Drawing.Point(17, 31);
            this.dtvAracSatisTarihce.Name = "dtvAracSatisTarihce";
            this.dtvAracSatisTarihce.Size = new System.Drawing.Size(615, 264);
            this.dtvAracSatisTarihce.TabIndex = 0;
            // 
            // frmAracSatisTarihce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbAracTarihce);
            this.Name = "frmAracSatisTarihce";
            this.Text = "frmAracSatisTarihce";
            this.grbAracTarihce.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtvAracSatisTarihce)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAracTarihce;
        private System.Windows.Forms.DataGridView dtvAracSatisTarihce;
    }
}