using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._Sales_Database.Models
{
    internal class Customer
    {
       public int CustomerId { get; set; }
       public string CreditIdNumber { get; set; }
       public string Name { get; set; }
       public string Email { get; set; }
    }
}
