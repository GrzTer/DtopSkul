using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_egzyminacyjne_2___Ja
{
    public class City
    {
        public string Name { get; set; }
        public int Offset { get; set; }

        public override string ToString()
        {
            return $"{Name} (UTC{(Offset >= 0 ? "+" : "")})";
        }
    }
}
