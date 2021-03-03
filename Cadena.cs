using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT
{
    class Cadena:IEquatable<Cadena>
    {
        public int paso { get; set; }
        public string cadena { get; set; }
        public bool Equals(Cadena c) => this.paso == c.paso;
    }
}
