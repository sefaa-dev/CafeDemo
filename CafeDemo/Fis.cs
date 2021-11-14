using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeDemo
{
    public partial class Fis : Form
    {
        public Fis()
        {
            InitializeComponent();
        }
        PrintDialog PRD = new PrintDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument Fis = new PrintDocument();
            DialogResult yazdirmaIslemi;
            yazdirmaIslemi = PRD.ShowDialog();
            Fis.PrintPage += Fis_PrintPage;
            if (yazdirmaIslemi == DialogResult.OK)
            {
                Fis.Print();
            }

        }

        private void Fis_PrintPage(object sender, PrintPageEventArgs e)
        {


            string NeYazicam = textBox1.Text;
            Font font = new Font("Arial", 12);
            SolidBrush Firça = new SolidBrush(Color.Black);
            e.Graphics.DrawString(NeYazicam, font, Firça, 150, 250);
            e.Graphics.DrawString("SİPARİŞ FORMU", font, Firça, 350, 180);
            e.Graphics.DrawString("Wissen Lokanta, Hoşgeldiniz :))", font, Firça, 550, 50);
            e.Graphics.DrawString($"Tarih = {DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss")}", font, Firça, 50, 50);
          



           
        }

        private void Fis_Load(object sender, EventArgs e)
        {
            
        }
    }
}
