using OrderManagement.Models;
using System.Windows.Forms;
using System;
using System.Linq;
using OrderManagement.Services;

namespace OrderManagement.Fromss
{
    public partial class Shopping : Form
    {
        private Customer selectedCustomer;
        private AppDbContext context;
        private OrderLogManager logManager;

        public Shopping(Customer customer)
        {
            InitializeComponent();
            selectedCustomer = customer;
            context = new AppDbContext();
            LoadCustomerDetails();
            LoadProducts();
            logManager = new OrderLogManager(new AppDbContext());
        }

        private void LoadCustomerDetails()
        {
            lstCustomerDetails.Items.Clear();
            lstCustomerDetails.Items.Add($"Müşteri Adı: {selectedCustomer.CustomerName}");
            lstCustomerDetails.Items.Add($"Bütçe: {selectedCustomer.Budget} ₺");
            lstCustomerDetails.Items.Add($"Müşteri Türü: {selectedCustomer.CustomerType}");
            lstCustomerDetails.Items.Add($"Toplam Harcama: {selectedCustomer.TotalSpent} ₺");
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = context.Products.ToList();
            dgvProducts.Columns["ProductID"].HeaderText = "ID";
            dgvProducts.Columns["ProductName"].HeaderText = "Ürün Adı";
            dgvProducts.Columns["Price"].HeaderText = "Fiyat";
            dgvProducts.Columns["Stock"].HeaderText = "Stok";
        }

        private void btnShop_Click(object sender, EventArgs e)
        {     
            
            string result;

            if (dgvProducts.CurrentRow != null)
            {
                int productId = (int)dgvProducts.CurrentRow.Cells["ProductID"].Value;
                Product selectedProduct = context.Products.FirstOrDefault(p => p.ProductID == productId);

                if (selectedProduct != null)
                {
                    int quantity = 1; 
                    decimal totalPrice = selectedProduct.Price * quantity;

                    if (selectedCustomer.Budget >= totalPrice && selectedProduct.Stock >= quantity)
                    {
                        Order newOrder = new Order
                        {
                            CustomerID = selectedCustomer.CustomerID,
                            ProductID = selectedProduct.ProductID,
                            Quantity = quantity,
                            TotalPrice = totalPrice,
                            OrderStatus = "Onay Bekliyor",
                            OrderDate = DateTime.Now
                        };

                        context.Orders.Add(newOrder);
                        selectedProduct.Stock -= quantity;
                        selectedCustomer.Budget -= totalPrice;
                        context.SaveChanges();

                        MessageBox.Show("Sipariş başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if(selectedCustomer.Budget < totalPrice)
                        {
                            result = "bütçe yetersiz";
                            logManager.CreateLog(selectedCustomer.CustomerID, "Hata", selectedCustomer.CustomerType, selectedProduct.ProductName ?? "Bilinmiyor", 1, result, null);
                            MessageBox.Show("Yeterli bütçe yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        if(selectedProduct.Stock < quantity)
                        {
                            result = "Ürün stoğu yetersiz";
                            logManager.CreateLog(selectedCustomer.CustomerID, "Hata", selectedCustomer.CustomerType, selectedProduct.ProductName ?? "Bilinmiyor", 1, result, null); // !!!!!!!!!!!!!!!!!!!
                            MessageBox.Show("Yeterli stok yok!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ürün bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
