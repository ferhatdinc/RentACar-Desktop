using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarajRestfulApp.Models
{
    public class Customer
    {
        public string CustomerUserName { get; set; }
        public string CustomerPassword { get; set; }
        public DateTime CustomerBirthDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
    }
}
