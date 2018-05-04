using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDB
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Telephone { get; set; }
        public int CardsId { get; set; }
        public Cards Cards { get; set; }

    }
}
