using _2._Sales_Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._Sales_Database.Models
{
    internal class Sale
    {
        public int SaleId { get; set; }
        public DateTime Date { get; set; }
        public string ProductId { get; set; }
        public int CustomerId { get; set; }
        public int StoreId { get; set; }
    }
}	
