using System;
using System.Windows.Forms;

namespace MT
{
    public enum Operaciones { Leer, Escribir }
    public enum Movimientos { Nada, Izquierda, Derecha }
    public partial class frmTransiciones : Form
    {
        //ToDo: Realizar la programacion para la captura, edicion y eliminacion de las transiciones.
        //      Utilizar los enum de arriba para llenar los ComboBox de Operacion y movimiento
        //      Los ComboBox de simbolos deben incluir el alfabeto y los simbolos reservados de espacio en blanco y marca
        //      Para controlar la validacion de que la combinacion de estado actual(q) y simbolo leido debe ser unica utilizar metodo equals de la clase transicion
        public Maquina maquina;
        public frmTransiciones(Maquina m)
        {
            this.maquina = m;
            InitializeComponent();
        }
       
        private void frmTransiciones_Load(object sender, EventArgs e)
        {
        }
    }
}
