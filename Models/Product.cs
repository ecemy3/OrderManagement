using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [StringLength(100)]
        public string ProductName { get; set; }

        public int Stock { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Price { get; set; }


        public virtual ICollection<Order> Orders { get; set; }


        public bool UpdateStock(int quantity)
        {
            if (Stock >= quantity)
            {
                Stock -= quantity;
                return true;
            }
            return false;
        }
    }
}
