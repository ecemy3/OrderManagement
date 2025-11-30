using OrderManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderManagement
{
    public partial class StokDurum : Form
    {
        AppDbContext context = new AppDbContext();
        public StokDurum()
        {
            InitializeComponent();
        }

        public void UrunListele()
        {
            var products = context.Products.ToList(); 

            dgvUrunler.DataSource = null;  
            dgvUrunler.DataSource = products;
            dgvUrunler.Refresh(); 
        }

        private void Create_Product_Click(object sender, EventArgs e)
        {
            Random random = new Random();
          
            context.Products.RemoveRange(context.Products);
            context.SaveChanges();

           
            var products = new List<Product>
            {
                new Product { ProductName = "Product1", Stock = 500, Price = 100 },
                new Product { ProductName = "Product2", Stock = 10, Price = 50 },
                new Product { ProductName = "Product3", Stock = 200, Price = 45 },
                new Product { ProductName = "Product4", Stock = 75, Price = 75 },
                new Product { ProductName = "Product5", Stock = 0, Price = 500 }
            };

            context.Products.AddRange(products);
            context.SaveChanges();

           
            UrunListele();
        }
    }
}
