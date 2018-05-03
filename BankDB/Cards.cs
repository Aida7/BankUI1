using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDB
{
    public class Cards
    {
        public int Id { get; set; }
        public string NamberCard { get; set; }
        public double Sum { get; set; }
        public int Pin { get; set; }
        public DateTime CardValidity { get; set;}
        public int CVVCode { get; set; }
    }
}
