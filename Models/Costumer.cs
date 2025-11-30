using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.Models
{

    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [Required]
        [StringLength(100)]
        public string CustomerName { get; set; }

        [Column(TypeName = "decimal")]
        public decimal Budget { get; set; }

        [StringLength(50)]
        public string CustomerType { get; set; }

        [Column(TypeName = "decimal")]
        public decimal TotalSpent { get; set; }

        [NotMapped]
        public DateTime RequestTime { get; set; }

    
        public virtual ICollection<Order> Orders { get; set; }
    }
}
