using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Objects.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntitySorgu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NorthwindEntities db = new NorthwindEntities();
       private void button1_Click(object sender, EventArgs e)
        {
            /*LINQ - LANGUAGE INTEGRATED QUERY
             
             1 - LİNQ TO OBJECT
             2 - LİNQ TO SQL
             3-  LİNQ TO XML
             
              EXTENSİON METOTLA YAZILAN YÖNTEM
              
             */

            /*fiyatı 20 ile 50 araında olan urunleri urun id urun adi fiyati stoktaki miktarı ve kategori adını linq sorgusuyla getirelim*/

            //var result = from p in db.Products where p.UnitPrice > 20 && p.UnitPrice < 50 select new { UrunAdi = p.ProductName, UrunId = p.ProductID, Fiyati = p.UnitPrice, StokMiktari = p.UnitsInStock, KategoriAdi = p.Category.CategoryName };
            //dataGridView1.DataSource = result.ToList();

            //(extension) lamda Expression yöntemi

            dataGridView1.DataSource = db.Products.Where(x => x.UnitPrice > 20 && x.UnitPrice < 50).Select(x => new
            {
                urunıd = x.ProductID,
                urunadi = x.ProductName,
                fiyat = x.UnitPrice,
                stok = x.UnitsInStock,
                kategoriadi = x.Category.CategoryName
            }).ToList();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Company name ierisinde restuarant gecen müşteriler*/

            //1-linq

            //var result = from x in db.Customers where x.CompanyName.Contains("restaurant") select new {sirketıd =x.CustomerID,sirketadi = x.CompanyName,sehir = x.City,iletisim =x.ContactName };
            //dataGridView1.DataSource = result.ToList();

            //2-lamda

            dataGridView1.DataSource = db.Customers.Where(x => x.CompanyName.Contains("restaurant")).Select(x => new {
                sirketıd=x.CustomerID,
                sirketadi=x.CompanyName,
                sehir = x.City,
                iletisim = x.ContactName

            }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //calisanların adi soyadi dogum tarihi ve yasını getren sorgu

            //1-linq

            //var result = from x in db.Employees select new { calisanıd = x.EmployeeID, calisanadi = x.FirstName, calisansoyad = x.LastName, dogumtarihi = x.BirthDate, yas = SqlFunctions.DateDiff("year",x.BirthDate,DateTime.Now) };
            //dataGridView1.DataSource = result.ToList();

            //2-lambda

            dataGridView1.DataSource = db.Employees.Select(x => new {

                calisanıd=x.EmployeeID,
                calisanadi = x.FirstName,
                calisansoyadi = x.LastName,
                dogum = x.BirthDate,
                yas = SqlFunctions.DateDiff("year",x.BirthDate,DateTime.Now)

            }).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
             Kategorisi bevetager olan urun adi : kla,f,yatı 5.00 stoktaki miktarı 500 olan ürünü ekleiniz
             */

            db.Categories.Find(1).Products.Add(new Product
            {
                ProductName = "kola",
                UnitPrice=5,
                UnitsInStock=500
                //CategoryID =1 categorie.find(1) yazmayıp böyle yapabiliriz
                

            });
            db.SaveChanges();
            dataGridView1.DataSource = db.Products.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //var sum = db.Products.Sum(x=> x.CategoryID)

            //kategori adına göre ürün stok sayısını getiren sorgu
            //var result = from p in db.Products
            //             group p by p.Category.CategoryName into g
            //             select new
            //             {
            //                 kategoriadi = g.Key,
            //                 toplamstoksayisi = g.Sum(p => p.UnitsInStock)
            //             };
            //dataGridView1.DataSource = result.ToList();


            //------------------------------------------------------------------------------------------------------------------------


            //kategori adına göre urun sayısını getiren sorgu

            //var result = from p in db.Products
            //             group p by p.Category.CategoryName into g
            //             select new
            //             {
            //                 kategoriadi = g.Key,
            //                 urunsayisi = g.Sum(p => p.CategoryID)
            //             };
            //dataGridView1.DataSource = result.ToList();


            //------------------------------------------------------------------------------------------------------------------------

            //2.yöntem


            //var query = from p in db.Products
            //            group p by p.Category.CategoryName into g
            //            select new
            //            {
            //                kategoriadi = g.Key
            //                urunsayisi = g.Count()
            //            };

            //dataGridView1.DataSource = query.ToList();



            //------------------------------------------------------------------------------------------------------------------------


            //lamda


            dataGridView1.DataSource = db.Products.GroupBy(p => p.Category.CategoryName).Select(g => new
            {
                kategoriadi = g.Key,
                toplamstoksaiyisi = g.Sum(p => p.UnitsInStock)
            }).ToList();
        }
    }
}
