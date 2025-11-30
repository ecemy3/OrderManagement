using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using OrderManagement.Fromss;
using OrderManagement.Models;

namespace OrderManagement
{
    public partial class Form1 : Form
    {
        private AppDbContext context = new AppDbContext(); 

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMusteriOlustur_Click_1(object sender, EventArgs e)
        {
            Random random = new Random();

            context.Customers.RemoveRange(context.Customers);
            context.SaveChanges();

            int customerCount = random.Next(5, 11); 
            List<Customer> customers = new List<Customer>();

           
            for (int i = 0; i < 2; i++)
            {
                customers.Add(new Customer
                {
                    CustomerName = $"Premium Müşteri {i + 1}",
                    Budget = random.Next(500, 3001),
                    CustomerType = "Premium",
                    TotalSpent = 0
                });
            }

            for (int i = 2; i < customerCount; i++)
            {
                string type = (random.Next(0, 2) == 0) ? "Standard" : "Premium";
                customers.Add(new Customer
                {
                    CustomerName = $"Müşteri {i + 1}",
                    Budget = random.Next(500, 3001),
                    CustomerType = type,
                    TotalSpent = 0
                });
            }

            context.Customers.AddRange(customers);
            context.SaveChanges();

            
            MusteriListele();

        }
        public void MusteriListele()
        {
            var customers = context.Customers
                .OrderByDescending(c => c.CustomerType == "Premium")
                .ThenBy(c => c.CustomerID)
                .ToList();

            dgvMusteriler.DataSource = null; 
            dgvMusteriler.DataSource = customers; 
            dgvMusteriler.Refresh(); 
        }
       
            private void dgvMusteriler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                if (e.RowIndex >= 0) 
                {
                   
                    int customerId = (int)dgvMusteriler.Rows[e.RowIndex].Cells["CustomerID"].Value;
                    Customer selectedCustomer = context.Customers.FirstOrDefault(c => c.CustomerID == customerId);

                    if (selectedCustomer != null)
                    {
                       
                        Shopping shoppingForm = new Shopping(selectedCustomer);
                        shoppingForm.Show();
                    }
                }
            }
        


        private void StokDurumBtn_Click(object sender, EventArgs e)
        {
            StokDurum stokDurum = new StokDurum();
            stokDurum.Show();
        }

        private void AdminSignBtn_Click(object sender, EventArgs e)
        {
           AdminRegister adminRegister = new AdminRegister();
            adminRegister.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
           
        }
    }
    }

