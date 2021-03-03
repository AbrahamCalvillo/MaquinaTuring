using System;

namespace MT
{
    public class Movimiento : IEquatable<Movimiento>
    {
        public int paso { get; set; }
        public string cadena { get; set; }
        public Transicion transicion { get; set; }
        public int PosicionCabezal { get; set; }
        public bool Equals(Movimiento m) => this.paso == m.paso;
    }
}
