using OrderManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OrderManagement.Services
{
    public class OrderLogManager
    {
        private readonly AppDbContext context;

        public OrderLogManager(AppDbContext dbContext)
        {
            context = dbContext;
        }
        public void CreateLog(int? customerId, string logType, string customerType, string productName, int quantity, string details, int? orderId)
        {
            try
            {
                var log = new Log
                {
                    CustomerID = customerId,
                    OrderID = orderId, 
                    LogDate = DateTime.Now,
                    LogType = logType,
                    LogDetails = $"Müşteri Türü: {customerType}, Ürün: {productName}, Adet: {quantity}, Detay: {details}"
                };

                context.Logs.Add(log);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Log oluşturulurken hata: " + ex.Message);
            }
        }

      
        public void ProcessOrder(Order order)
        {
            string result;

            try
            {
                var customer = context.Customers.FirstOrDefault(c => c.CustomerID == order.CustomerID);
                if (customer == null) return;

                
                var product = context.Products.FirstOrDefault(p => p.ProductID == order.ProductID);
                if (product == null || product.Stock < order.Quantity)
                {
                    result = "Ürün stoğu yetersiz";
                    CreateLog(order.CustomerID, "Hata", customer.CustomerType, product?.ProductName ?? "Bilinmiyor", order.Quantity, result, order.OrderID);
                    return;
                }

               
                lock (context) 
                {
                    product.Stock -= order.Quantity;
                    order.OrderStatus = "Onaylandı";
                    context.SaveChanges();
                }

                result = "Satın alma başarılı";
            }
            catch (Exception ex)
            {
                result = "Veritabanı Hatası: " + ex.Message;
            }

           
            var customerType = context.Customers.FirstOrDefault(c => c.CustomerID == order.CustomerID)?.CustomerType ?? "Bilinmiyor";
            CreateLog(order.CustomerID, result == "Satın alma başarılı" ? "Bilgilendirme" : "Hata", customerType, order.ProductID.ToString(), order.Quantity, result, order.OrderID);
        }
    }
}
