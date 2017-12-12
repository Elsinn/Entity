using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFreamWorkKarsilastirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Normal sql baglantısı Sqlconnection
        private void btnSqlCon_Click(object sender, EventArgs e)
        {
            DateTime baslangıc = DateTime.Now;// Kaç milisaniyede sonuç alıdğımızı göremk için başlangıç ve bitiş tanımlayıp aradaki farkı alıcaz.

            SqlConnection cnn = new SqlConnection("Server=DESKTOP-6A2T3LT;Database=Northwind;User Id=sa; Password = 1;");
            SqlCommand cmd = new SqlCommand("Select  FirstName,LastName from Employees", cnn);

            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    lstConnected.Items.Add(dr.GetString(0)+" "+dr.GetString(1));
                }
            }
            DateTime bitis = DateTime.Now;//bitis süresini aldık
            TimeSpan fark = bitis - baslangıc;//timespan milisaniye tarzında almamızı saglıyor

            label4.Text = fark.Milliseconds.ToString();
        }


        //----------------------------------------------------------------------------




        //sqladapter ile gerektiginde acılıp kapanan sql baglantısı
        private void btnDataAdap_Click(object sender, EventArgs e)
        {
            DateTime baslan = DateTime.Now;

            SqlDataAdapter dap = new SqlDataAdapter("Select * from Employees", "Server=DESKTOP-6A2T3LT;Database=Northwind;User Id=sa; Password = 1;");
            DataTable dt = new DataTable();
            dap.Fill(dt);
            lstDisconnected.DataSource = dt;
            lstDisconnected.DisplayMember = "FirstName";
            lstDisconnected.ValueMember = "EmployeeID";
 
            DateTime bitis = DateTime.Now;
            TimeSpan fark = bitis - baslan;
            label5.Text = fark.Milliseconds.ToString();
        }




        //----------------------------------------------------------------------------


        //entity freamwork baglantısı
        private void button3_Click(object sender, EventArgs e)
        {
            DateTime baslan = DateTime.Now;

            NorthwindEntities DB = new NorthwindEntities();
            lstEF.DataSource = DB.Employees.ToList();
            lstEF.DisplayMember = "FirstName";
            lstEF.ValueMember = "EmployeeID";

            DateTime bitis = DateTime.Now;
            TimeSpan fark = bitis - baslan;
            label6.Text = fark.Milliseconds.ToString();
        }
    }
}



