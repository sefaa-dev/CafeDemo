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
    public partial class tablelayout : Form
    {
        public tablelayout()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tablelayout_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button btn = new Button();
            btn.Name = "a";
            btn.Text = textBox1.Text.ToUpper();
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Size = new Size(100, 50);
            btn.Click += Btn_Click;
            flowLayoutPanel1.Controls.Add(btn);
            
            }

        private void Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başarılı");
            Button b2 = sender as Button;
            b2.BackColor = Color.Yellow;
            
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    }

