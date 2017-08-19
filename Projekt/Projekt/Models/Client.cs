using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        public string Nname { get; set; }
        public string Ename { get; set; }
      
        public string AddDate { get; set; }
        public string Email { get; set; }
        public string ClientStatus { get; set; }
        public int Rabat { get; set; }
    }
}
