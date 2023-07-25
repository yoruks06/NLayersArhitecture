using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;
using System.Data.SqlClient;

namespace NLayerArchitecture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource= PerList;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = textBox1.Text;
            ent.Soyad=textBox2.Text;
            ent.Sehir = textBox3.Text;
            ent.Maas = short.Parse(textBox4.Text);
            ent.Gorev= textBox5.Text;
            LogicPersonel.LLPersonelEkle(ent);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(textBox1.Text);
            LogicPersonel.LLPersonelSil(ent.Id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(textBox1.Text);
            ent.Ad=textBox1.Text;
            ent.Soyad= textBox2.Text;   
            ent.Sehir= textBox3.Text;   
            ent.Gorev= textBox4.Text;   
            ent.Maas= short.Parse(textBox5.Text);   
            LogicPersonel.LLPersonelEkle(ent);
        }
    }
}
