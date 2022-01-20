using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    class Hotell
    {
        public string CliNome { get; set; }
        public string CliEmail { get; set; }
        public int NumeroQuarto { get; set; }



        public override string ToString()
        {
            return CliNome
                +", "
                +CliEmail;
        }
    }
}
