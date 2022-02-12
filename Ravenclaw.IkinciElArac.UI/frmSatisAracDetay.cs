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
    public partial class frmSatisAracDetay : Form
    {
        public frmSatisAracDetay()
        {
            InitializeComponent();
        }
        public object _arac { get; set; }
        public frmSatisAracDetay(object arac):this()
        {
            
            _arac = arac;
           
        }
        public object Form1denGelen { get; set; }
        private void btnTarihce_Click(object sender, EventArgs e)
        {
            frmAracSatisTarihce tarihce = new frmAracSatisTarihce();
            tarihce.Show();
        }

        private void frmSatisAracDetay_Load(object sender, EventArgs e)
        {
            txtAdSoyad.Text = _arac.ToString();
        }
    }
}
