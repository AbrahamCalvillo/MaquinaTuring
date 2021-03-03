using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT
{
    public class Estado:IEquatable<Estado>
    {
        public string Etiqueta { get; set; }
        public bool Equals(Estado e) => this.Etiqueta == e.Etiqueta;
    }
}
