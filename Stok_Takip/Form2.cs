using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Threading.Tasks;

namespace Stok_Takip
{
    public partial class Form2 : Form
    {

        Form3 Satisİslemleri = new Form3();
        Form4 DukkanIslemleri = new Form4();
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSatisIslemleri_Click(object sender, EventArgs e)
        {
            Satisİslemleri.Show();
            this.Hide();
        }

        private void btnDukkanIslemleri_Click(object sender, EventArgs e)
        {
            DukkanIslemleri.Show();
            this.Hide();
        }

        
    }
}
