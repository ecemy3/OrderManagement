using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagement.Models
{
    public class Log
    {
        [Key] 
        public int LogID { get; set; }

        public int? CustomerID { get; set; }

        public int? OrderID { get; set; }

        [Required]
        public DateTime LogDate { get; set; } = DateTime.Now;

        public string LogType { get; set; }
        public string LogDetails { get; set; }

 
        public virtual Customer Customer { get; set; }
        public virtual Order Order { get; set; }
    }
}
