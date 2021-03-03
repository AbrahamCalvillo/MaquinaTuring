using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT
{
    public enum Operaciones{Leer,Escribir}
    public enum Movimientos { Nada, Izquierda, Derecha }


    public class Transicion:IEquatable<Transicion>
    {
        public string q { get; set; }
        public string p { get; set; }
        public char ValorBuscado { get; set; }
        public char ValorNuevo { get; set; }
        public Movimientos Movimiento { get; set; }
        public Operaciones Operacion {get;set;}

        public bool Equals(Transicion t) => this.q ==t.q && this.ValorBuscado == t.ValorBuscado;
    }
}
