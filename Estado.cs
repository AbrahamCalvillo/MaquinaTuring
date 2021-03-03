using System;

namespace MT
{
    public class Estado : IEquatable<Estado>
    {
        public string Etiqueta { get; set; }
        public bool Equals(Estado e) => this.Etiqueta == e.Etiqueta;
        public override string ToString()
        {
            return $"Etiqueta: {Etiqueta}";
        }
    }
}
