using Ravenclaw.IkinciElArac.DataAccess;
using Ravenclaw.IkinciElArac.DataAccess.Concrete;
using Ravenclaw.IkinciElArac.DataAccess.Mapping;
using Ravenclaw.IkinciElArac.DataAccess.VM;
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
    public partial class frmSatilanAracListele : Form
    {
        public frmSatilanAracListele()
        {
            InitializeComponent();
        }

        public object secilenArac { get; set; }
        EfModelDal efModelDal = new EfModelDal();
        EfMarkaDal markaDal = new EfMarkaDal();
        EfAracStatuDal statuDal = new EfAracStatuDal();
        IkinciElAracEntities entities = new IkinciElAracEntities();
        EfAracDal dal = new EfAracDal();
        private void frmSatilanAracListele_Load(object sender, EventArgs e)
        {
            cmbMarkalarıGetir();
            cmbStatuleriGetir();
            
            dgvAracListesi.DataSource= dal.satisdakiAraclariGetir();
            
        }

        private void cmbMarkalarıGetir()
        {
            foreach (var item in markaDal.Select())
            {
                cmbAracMarka.Items.Add(item.MarkaAdi);
            }
         
            
        }

        private void cmbStatuleriGetir()
        {
            foreach (var item in statuDal.Select())
            {
                cmbStatu.Items.Add(item.StatuDurumu);
            }
        }
       
        
    

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            frmSatisAracDetay detay = new frmSatisAracDetay(secilenArac);
            detay.Show();
        }


        private void dgvAracListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            dgvAracListesi.Tag = row.Cells["AracID"].Value;
          
        }

        private void cmbAracMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
