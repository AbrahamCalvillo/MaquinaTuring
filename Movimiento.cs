using System;

namespace MT
{
    public class Movimiento : IEquatable<Movimiento>
    {
        public int Paso { get; set; }
        public string Cadena { get; set; }
        public Transicion Transicion { get; set; }
        public int PosicionCabezal { get; set; }
        public bool Equals(Movimiento m) => this.Paso == m.Paso;
    }
}
