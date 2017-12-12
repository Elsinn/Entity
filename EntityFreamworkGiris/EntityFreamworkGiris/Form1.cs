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

namespace EntityFreamworkGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //entityle ile kendi sqlimde olan northwind dbsindeki employees tablosunu cektim sadece ordaki veriyi cekmek istediğim için.

        NorthwindEntities db = new NorthwindEntities();
        private void button1_Click(object sender, EventArgs e)
        {

            //SqlDataAdapter dap = new SqlDataAdapter("Select * from Employees", "Server=DESKTOP-6A2T3LT;Database=Northwind;User Id=sa; Password =1;");
            //DataTable dt = new DataTable();
            //dap.Fill(dt);
            //dataGridView1.DataSource = dt;

            dataGridView1.DataSource = db.Employees.ToList();
            
        
        }
    }
}
