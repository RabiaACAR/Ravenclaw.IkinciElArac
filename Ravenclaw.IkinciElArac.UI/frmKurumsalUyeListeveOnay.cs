
using Ravenclaw.IkinciElArac.DataAccess;
using Ravenclaw.IkinciElArac.DataAccess.Concrete;
using Ravenclaw.IkinciElArac.DataAccess.Mapping;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ravenclaw.IkinciElArac.UI
{
    public partial class frmKurumsalUyeListeveOnay : Form
    {
        public frmKurumsalUyeListeveOnay()
        {
            InitializeComponent();
        }
        EfKurumsalMusteriDal kurumsalMusteriDal = new EfKurumsalMusteriDal();
        IkinciElAracEntities entities = new IkinciElAracEntities();
        EfKullaniciDal efKullanici = new EfKullaniciDal();
        private void onaylaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bu üyeyi onaylamak istediğinize emin misiniz", "Onaylama Ekranı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result==DialogResult.Yes)
            {
                int id = (int)dgvKurumsalUyeListele.CurrentRow.Cells["KullaniciID"].Value;
                Kullanici kullanici = entities.Kullanicis.SingleOrDefault(x => x.KullaniciID == id);
                kullanici.AktifMi = true;
                entities.SaveChanges();
                dgvKurumsalUyeListele.DataSource = kurumsalMusteriDal.KurumsalMusterileriGetir();
                MessageBox.Show("Onaylama İşlemi Başarılı");
            }
            else
            {
                MessageBox.Show("Onaylama işlemi gerçekleştirilmedi.");
            }

        }

        private void dgvKurumsalUyeListele_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void frmKurumsalUyeListeveOnay_Load(object sender, EventArgs e)
        {
            dgvKurumsalUyeListele.DataSource = kurumsalMusteriDal.KurumsalMusterileriGetir();
            
            
            
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bu üyeyi silmek istediğinize emin misiniz", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //if (result == DialogResult.Yes)
            //{
            //    int id = (int)dgvKurumsalUyeListele.CurrentRow.Cells["KullaniciID"].Value;
            //    Kullanici kullanici = entities.Kullanicis.SingleOrDefault(x => x.KullaniciID == id);
            //    efKullanici.SoftDelete(kullanici);
            //    entities.SaveChanges();
            //    dgvKurumsalUyeListele.DataSource = kurumsalMusteriDal.KurumsalMusterileriGetir();
            //    MessageBox.Show("Silme İşlemi Başarılı");
            //}
            //else
            //{
            //    MessageBox.Show("Silme işlemi gerçekleştirilmedi.");
            //}
        }

        private void grbKurumsalOnay_Enter(object sender, EventArgs e)
        {

        }
    }
}
