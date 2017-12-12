using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFreamwork1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void sil() {

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();        
        }
        public void Getir()
        {
            listBox1.DataSource = db.Kisilers.ToList();
            listBox1.DisplayMember = "KisiAdi";

        }
        TelRehberiEntities db = new TelRehberiEntities();
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
                MessageBox.Show("Lütfen boş yerleri doldurunuz.");
            //1.yöntem
            Kisiler kisi = new Kisiler();
            kisi.KisiAdi = textBox1.Text;
            kisi.KisiSoyadi = textBox2.Text;
            kisi.TelNo = Convert.ToInt32(textBox3.Text);
            db.Kisilers.Add(kisi);
            db.SaveChanges();
            Getir();
            sil();


            /*2.yöntem
             
                 Kisiler k = new Kisiler
            {
                KisiAdi = textBox1.Text,
                KisiSoyadi = textBox2.Text,
                TelNo = Convert.ToInt32(textBox3.Text)
            };
            db.Kisilers.Add(k);
            db.SaveChanges();
             */


            /*3.yöntem
                    db.Kisilers.Add(new Kisiler { KisiAdi = textBox1.Text, KisiSoyadi = textBox2.Text, TelNo = Convert.ToInt32(textBox3.Text) });
            db.SaveChanges();
            Getir();

             */



        }
        Kisiler secili;
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
                MessageBox.Show("Lütfen boş yerleri doldurunuz.");


           /* var guncellenecek = (from i in db.Kisilers where i.KisiID == secili.KisiID select i).FirstOrDefault();*///cast etmeden kullanılan hali

            secili = (Kisiler)listBox1.SelectedItem;
            secili.KisiAdi = textBox1.Text;
            secili.KisiSoyadi = textBox2.Text;
            secili.TelNo = Convert.ToInt32( textBox3.Text);
            db.SaveChanges();
            Getir();
            sil();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Getir();
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count>0)
            {
                secili = (Kisiler)listBox1.SelectedItem;
                db.Kisilers.Remove(secili);
                db.SaveChanges();
                Getir();
                sil();
            }
           
        }

        private void listBox1_DoubleClick_1(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                secili = (Kisiler)listBox1.SelectedItem;
            textBox1.Text = secili.KisiAdi;
            textBox2.Text = secili.KisiSoyadi;
            textBox3.Text = secili.TelNo.ToString();
        }
    }
    }
}
