using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Arac_Otomasyon.BusinessLogicLayer;
using Arac_Otomasyon.dbconn;
using System.Data.SqlClient;

namespace Arac_Otomasyon.PresantationLayer
{
    public partial class menu : Form
    {
        private aracbll _musteriler;

        public menu()
        {
            InitializeComponent();
            _musteriler = new aracbll();
        }

        public void listele()
        {


            baglanti baglan = new baglanti();
            SqlCommand sorgu = new SqlCommand("Select * From Musteri", baglan.baglan);

            DataTable dataTable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            adapter.Fill(dataTable);

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource;


        }


        public void sil()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox12.Clear();

        }






        private void button1_Click(object sender, EventArgs e)
        {
            aracbll musteri = new aracbll();
            _ = _musteriler.kayıt(Convert.ToInt16(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt16(textBox4.Text), Convert.ToInt16(textBox5.Text), Convert.ToInt16(textBox6.Text)
                , Convert.ToInt16(textBox7.Text),  Convert.ToInt16(textBox8.Text), Convert.ToInt16(textBox9.Text), Convert.ToInt16(textBox10.Text), Convert.ToDateTime(textBox12.Text));


            MessageBox.Show("Kayıt Eklenmiştir...");
            listele();
            sil();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox12.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            aracbll musteri = new aracbll();
            _ = _musteriler.gucelleme(Convert.ToInt16(textBox1.Text), textBox2.Text, textBox3.Text, Convert.ToInt16(textBox4.Text), Convert.ToInt16(textBox5.Text), Convert.ToInt16(textBox6.Text)
                , Convert.ToInt16(textBox7.Text), Convert.ToInt16(textBox8.Text), Convert.ToInt16(textBox9.Text), Convert.ToInt16(textBox10.Text), Convert.ToDateTime(textBox12.Text));


            MessageBox.Show("Kayıt Güncellenmiştir...");
            listele();
            sil();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            aracbll musteri = new aracbll();
            _ = _musteriler.silme(Convert.ToInt16(textBox1.Text));


            MessageBox.Show("Kayıt Silinmiştir...");
            listele();
            sil();

        }
    }
}
