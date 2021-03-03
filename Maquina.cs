using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT
{
    public class Maquina
    {
        public char[] Alfabeto { get; set; }
        public List<Estado> Estados { get; set; }
        public List<Cadena> ConfiguracionCadena { get; set; }
        public List<Transicion> ListaTransiciones { get; set; }
        public char EspacioBlanco { get; set; }
        public string EstadoInicial { get; set; }
        public string EstadoFinal { get; set; }            
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
                Estados.Remove(e);
                msg = "Ok";
            }
            else
            {
                msg = "Error al eliminar el estado";
            }
            return msg;
        }
        public string AgregarTransicion(Estado e, Transicion t) {
            string msg = "";
            if (Estados.Contains(e)&& !ListaTransiciones.Contains(t))
            {
                ListaTransiciones.Add(t);
                msg = "Ok";
            }
            else
            {
                msg = "Error al eliminar el estado";
            }
            return msg;
        }
    }
}
