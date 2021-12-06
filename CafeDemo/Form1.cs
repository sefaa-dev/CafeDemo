using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            tablelayout urunlereGec = new tablelayout();
            urunlereGec.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                 
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            Fis fis = new Fis();
            fis.ShowDialog();
        }
    }
}
