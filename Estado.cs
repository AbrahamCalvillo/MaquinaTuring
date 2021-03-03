using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT
{
    public class Estado:IEquatable<Estado>
    {
        public int numero { get; set; }
        public List<Transicion> Transiciones { get; set; }
        public bool Equals(Estado e) => this.numero == e.numero;
    }
}
