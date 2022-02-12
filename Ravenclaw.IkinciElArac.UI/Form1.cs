
using Ravenclaw.IkinciElArac.DataAccess;
using Ravenclaw.IkinciElArac.DataAccess.Concrete;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            using (IkinciElAracEntities db = new IkinciElAracEntities())
            {
                dataGridView1.DataSource = db.Kullanicis.ToList();
                
            }
        }
    }
}
