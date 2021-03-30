using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Arac_Otomasyon.PresantationLayer;
using Arac_Otomasyon.BusinessLogicLayer;
using Arac_Otomasyon.PocosLayer;

namespace Arac_Otomasyon
{
    public partial class Form1 : Form
    {
        aracbll _calısanlar; 
        public Form1()
        {
            InitializeComponent();
            _calısanlar = new aracbll(); 
        }

        private void button1_Click(object sender, EventArgs e)

        {
            arac arac = new arac();

            
            
            arac = _calısanlar.getSorgu(textBox1.Text, textBox2.Text);

            if ((arac.kullaniciadi == null) || (arac.sifre == null))
            {
                MessageBox.Show("Hatalı Giris Yaptınız!!!");

            }
            else
            {
                this.Hide();
                MessageBox.Show("Sisteme Hoşgeldiniz :" + arac.kullaniciadi);
            }


            menu menu = new menu();
            menu.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
