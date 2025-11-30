using OrderManagement.Models;
using OrderManagement.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace OrderManagement
{
    public partial class AdminSign : Form
    {
        private AppDbContext context;
        private OrderLogManager logManager;
        private static SemaphoreSlim adminLock = new SemaphoreSlim(1, 1);
        private System.Windows.Forms.Timer logRefreshTimer;

        public AdminSign()
        {
            InitializeComponent();
            logManager = new OrderLogManager(new AppDbContext());
            context = new AppDbContext();
          
            logRefreshTimer = new System.Windows.Forms.Timer();
            logRefreshTimer.Interval = 1000; 
            logRefreshTimer.Tick += LogRefreshTimer_Tick;
            logRefreshTimer.Start();
            LoadPendingOrders();
            LoadLogs(); 
            this.FormClosing += AdminSign_FormClosing;
        }
        private void LogRefreshTimer_Tick(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(LoadLogs));
            }
            else
            {
                LoadLogs();
            }
        }
        private void AdminSign_Load(object sender, EventArgs e)
        {
           
            dgvStock.AutoGenerateColumns = true;
            UrunListele();
            LoadPendingOrders();
            StartPriorityUpdateTimer();
            numStockUpdate.Maximum = int.MaxValue; 

        }

        private void AdminSign_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            StopPriorityUpdateTimer();
        }
        private void LoadLogs()
        {
            try
            {
                var logs = context.Logs.ToList(); 
                dgvLogs.DataSource = logs;  
                FormatLogsGrid(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void FormatLogsGrid()
        {
            dgvLogs.Columns["LogID"].HeaderText = "Log ID";
            dgvLogs.Columns["CustomerID"].HeaderText = "Müşteri ID";
            dgvLogs.Columns["OrderID"].HeaderText = "Sipariş ID";
            dgvLogs.Columns["LogDate"].HeaderText = "Tarih";
            dgvLogs.Columns["LogType"].HeaderText = "Log Türü";
            dgvLogs.Columns["LogDetails"].HeaderText = "Log Detayları";
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.RowsAdded += dgvLogs_RowsAdded;
        }

        private void dgvLogs_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            try
            {
                
                for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
                {
                    var logType = dgvLogs.Rows[i].Cells["LogType"].Value?.ToString();

                    if (logType == "Bilgilendirme")
                    {
                        dgvLogs.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                    }
                    else if (logType == "Hata")
                    {
                        dgvLogs.Rows[i].DefaultCellStyle.BackColor = Color.LightCoral;
                    }
                }

               
                dgvLogs.FirstDisplayedScrollingRowIndex = dgvLogs.Rows.Count - 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }


        private void LoadPendingOrders()
        {
            try
            {
                var pendingOrders = context.Orders.Where(o => o.OrderStatus == "Onay Bekliyor").ToList();

                foreach (var order in pendingOrders)
                {
                    var customer = context.Customers.FirstOrDefault(c => c.CustomerID == order.CustomerID);
                    if (customer != null)
                    {
                        order.PriortyScore = CalculatePriorityScore(customer, order);
                    }
                }

                context.SaveChanges();

                dgvPendingOrders.DataSource = pendingOrders
                    .OrderByDescending(o => o.PriortyScore)
                    .ToList();

                FormatPendingOrdersGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private double CalculatePriorityScore(Customer customer, Order order)
        {
            const int PremiumBaseScore = 25;
            const int NormalBaseScore = 10;
            const double WaitTimeWeight = 0.5;

            var waitTime = (DateTime.Now - order.OrderDate).TotalSeconds;

            int baseScore = customer.CustomerType == "Premium" ? PremiumBaseScore : NormalBaseScore;
            return baseScore + (waitTime * WaitTimeWeight);
        }

        private void FormatPendingOrdersGrid()
        {
            dgvPendingOrders.Columns["OrderID"].HeaderText = "Sipariş ID";
            dgvPendingOrders.Columns["CustomerID"].HeaderText = "Müşteri ID";
            dgvPendingOrders.Columns["ProductID"].HeaderText = "Ürün ID";
            dgvPendingOrders.Columns["Quantity"].HeaderText = "Adet";
            dgvPendingOrders.Columns["TotalPrice"].HeaderText = "Toplam Fiyat";
            dgvPendingOrders.Columns["OrderStatus"].HeaderText = "Durum";
            dgvPendingOrders.Columns["OrderDate"].HeaderText = "Sipariş Tarihi";
            dgvPendingOrders.Columns["PriortyScore"].HeaderText = "Öncelik Skoru";
        }

        private async void AddProductBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ProductNameTxt.Text) || numStock.Value < 0 || string.IsNullOrWhiteSpace(Pricetxt.Text))
            {
                MessageBox.Show("Lütfen tüm bilgileri doğru giriniz.");
                return;
            }

            await adminLock.WaitAsync();
            try
            {
                var product = new Product
                {
                    ProductName = ProductNameTxt.Text,
                    Stock = (int)numStock.Value,
                    Price = decimal.Parse(Pricetxt.Text)
                };

                context.Products.Add(product);
                context.SaveChanges();

                LoadProducts();
                MessageBox.Show("Ürün başarıyla eklendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                adminLock.Release();
            }
        }

        private void LoadProducts()
        {
            try
            {
                var products = context.Products.ToList();
                dgvStock.DataSource = null;
                dgvStock.DataSource = products;

                ChartiDoldur(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        public void UrunListele()
        {
            try
            {
                dgvStock.AutoGenerateColumns = true;

                
                var products = context.Products.ToList();

               
                dgvStock.DataSource = null;
                dgvStock.DataSource = products;
                dgvStock.Refresh();

               
                ChartiDoldur(products);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void ChartiDoldur(List<Product> products)
        {
            try
            {
                
                chartStock.Series.Clear();

                
                Series stockSeries = new Series("Stock");
                stockSeries.ChartType = SeriesChartType.Column;
                chartStock.Series.Add(stockSeries);

                
                foreach (var product in products)
                {
                    stockSeries.Points.AddXY(product.ProductName, product.Stock);
                }

                
                chartStock.ChartAreas[0].AxisX.Title = "Ürünler";
                chartStock.ChartAreas[0].AxisY.Title = "Stok Miktarı";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chart Hatası: " + ex.Message);
            }
        }

        private async void UpdateStockBtn_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count > 0)
            {
                await adminLock.WaitAsync(); 
                try
                {
                
                    int productId = (int)dgvStock.SelectedRows[0].Cells["ProductID"].Value;

                   
                    var product = context.Products.FirstOrDefault(p => p.ProductID == productId);

                    if (product != null)
                    {
                     
                        product.Stock = (int)numStockUpdate.Value;
                        context.SaveChanges(); 

                        LoadProducts();

                        MessageBox.Show("Stok başarıyla güncellendi.");
                    }
                    else
                    {
                        MessageBox.Show("Ürün bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    adminLock.Release(); 
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçin.");
            }
        }


        private async void DeleteProductBtn_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count > 0)
            {
                await adminLock.WaitAsync();
                try
                {
                    int productId = (int)dgvStock.SelectedRows[0].Cells["ProductID"].Value;
                    var product = context.Products.FirstOrDefault(p => p.ProductID == productId);

                    if (product != null)
                    {
                        context.Products.Remove(product);
                        context.SaveChanges();
                        LoadProducts();
                        MessageBox.Show("Ürün başarıyla silindi.");
                    }
                    else
                    {
                        MessageBox.Show("Ürün bulunamadı.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
                finally
                {
                    adminLock.Release();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir ürün seçin.");
            }
        }

        private System.Threading.Timer priorityUpdateTimer;

        private void StartPriorityUpdateTimer()
        {
            
            priorityUpdateTimer = new System.Threading.Timer(UpdatePriorityScores, null, 0, 2000);
        }

        private void UpdatePriorityScores(object state)
        {
            try
            {
               
                var pendingOrders = context.Orders.Where(o => o.OrderStatus == "Onay Bekliyor").ToList();

                foreach (var order in pendingOrders)
                {
                    var customer = context.Customers.FirstOrDefault(c => c.CustomerID == order.CustomerID);
                    if (customer == null) continue;

                    double baseScore = customer.CustomerType == "Premium" ? 25 : 10;
                    TimeSpan waitTime = DateTime.Now - order.OrderDate;
                    double waitTimeScore = waitTime.TotalSeconds * 0.5;

                    order.PriortyScore = baseScore + waitTimeScore;
                }

              
                context.SaveChanges();
            }
            catch (Exception ex)
            {
               
                Console.WriteLine("Hata: " + ex.Message);
            }
        }

        private void StopPriorityUpdateTimer()
        {
            priorityUpdateTimer?.Dispose();
        }

        private async void ApproveOrderBtn_Click(object sender, EventArgs e)
        {
            StopPriorityUpdateTimer();

            await adminLock.WaitAsync();
            try
            {
                var pendingOrders = context.Orders.Where(o => o.OrderStatus == "Onay Bekliyor").ToList();

                if (!pendingOrders.Any())
                {
                    MessageBox.Show("Onaylanacak sipariş bulunamadı.");
                    return;
                }
                var sortedOrders = pendingOrders.OrderByDescending(o => o.PriortyScore).ToList();

                foreach (var order in sortedOrders) 
                {
                    logManager.CreateLog(order.CustomerID, "Bilgilendirme", "N/A", order.ProductID.ToString(), order.Quantity, "Sipariş onaylanıyor", order.OrderID);

                    await Task.Delay(2000);
                    logManager.ProcessOrder(order);
                    order.OrderStatus = "Onaylandı";

                    var customerType = context.Customers.FirstOrDefault(c => c.CustomerID == order.CustomerID)?.CustomerType ?? "Bilinmiyor";
                    logManager.CreateLog(order.CustomerID, "Bilgilendirme", customerType, order.ProductID.ToString(), order.Quantity, "Sipariş onaylandı", order.OrderID);
                }

                context.SaveChanges();
                LoadPendingOrders();

                MessageBox.Show("Tüm siparişler başarıyla onaylandı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                adminLock.Release();
                StartPriorityUpdateTimer();
            }
        }

        private void numStockUpdate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
