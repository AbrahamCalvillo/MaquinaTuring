using System.Collections.Generic;

namespace MT
{
    public class Maquina
    {
        public Maquina()
        {
            Estados = new List<Estado>();
            Movimientos = new List<Movimiento>();
            ListaTransiciones = new List<Transicion>();
            EspacioBlanco = 'ß';
            Marca = '*';
        }
        public char[] Alfabeto { get; set; }
        public List<Estado> Estados { get; set; }
        public List<Movimiento> Movimientos { get; set; }
        public List<Transicion> ListaTransiciones { get; set; }
        public char EspacioBlanco { get; set; }
        public char Marca { get; set; }
        public int PosicionInicial { get; set; }
        public string EstadoInicial { get; set; }
        public string EstadoFinal { get; set; }
        public string Cadena { get; set; }
        public string AgregarEstado(Estado e)
        {
            string msg = "";
            if (!Estados.Contains(e))
            {
                Estados.Add(e);
                msg = "Ok";
            }
            else
            {
                msg = "Estado existente";
            }
            return msg;
        }
        public string EliminarEstado(Estado e)
        {
            string msg = "";
            if (Estados.Contains(e))
            {
                ListaTransiciones.RemoveAll(t => t.q.Equals(e.Etiqueta) || t.p.Equals(e.Etiqueta));
                Estados.Remove(e);
                msg = "Ok";
            }
            else
            {
                msg = "Error al eliminar el estado";
            }
            return msg;
        }
        public string AgregarTransicion(Transicion t)
        {
            string msg = "";
            if (!ListaTransiciones.Contains(t))
            {
                ListaTransiciones.Add(t);
                msg = "Ok";
            }
            else
            {
                msg = "Error al agregar la transicion";
            }
            return msg;
        }
        public string EditarTransicion(Transicion oldT, Transicion newT)
        {
            string msg = "";
            if (!ListaTransiciones.Contains(oldT))
            {
                ListaTransiciones.Remove(oldT);
                ListaTransiciones.Add(newT);

                msg = "Ok";
            }
            else
            {
                msg = "Error al editar la transicion: No existe la transicion que se intenta editar";
            }
            return msg;
        }
        public string EliminarTransicion(Transicion t)
        {
            string msg = "";
            if (ListaTransiciones.Contains(t))
            {
                ListaTransiciones.Remove(t);
                msg = "Ok";
            }
            else
            {
                msg = "Error al eliminar la transicion";
            }
            return msg;
        }
    }
}
