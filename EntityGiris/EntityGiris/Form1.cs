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

namespace EntityGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            //Snippet Formata eklemek eklemek için Tools->Code Snippet Manager-> import yolu izlenir
            //ado yazdığımızda snippetlarımız gelir ve taba bastığımızda kod bloğumuz çıkar

            SqlConnection cnn = new SqlConnection("Server=DESKTOP-6A2T3LT;Database=Northwind;User Id=sa; Password =1;");
            SqlCommand cmd = new SqlCommand("Select * from Employees", cnn);

            if (cnn.State == ConnectionState.Closed)
            {
                cnn.Open();
            }
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    
                }
            }
        }
    }
}
