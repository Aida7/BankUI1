using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDB
{
    public class Info
    {
        public int Id { get; set; }
        public BankOperations BankOperations { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
    }
}
