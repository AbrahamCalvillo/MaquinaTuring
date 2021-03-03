using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MT
{
    public partial class frmMaquinaTuring : Form
    {

        Maquina maquina;

        public frmMaquinaTuring()
        {
            maquina = new Maquina();
            maquina.EstadoInicial = "q0";
            maquina.EstadoFinal = "qf";
            maquina.AgregarEstado(new Estado() { Etiqueta = "q0" });
            maquina.AgregarEstado(new Estado() { Etiqueta = "qf" });
            InitializeComponent();
        }
        private void frmMaquinaTuring_Load(object sender, EventArgs e)
        {

        }
        private void btnGuardarAlfabeto_Click(object sender, EventArgs e)
        {
            //Metodo que guarda el alfabeto capturado
            maquina.Alfabeto = txtAlfabeto.Text.Trim().ToCharArray();

        }

        private void btnEjecutarMaquina_Click(object sender, EventArgs e)
        {
            //ToDo: Metodo que ejecuta la maquina

        }

        private void btnTransiciones_Click(object sender, EventArgs e)
        {
            //Metodo que abre el form de transiciones
            frmTransiciones frmTransiciones = new frmTransiciones(m: maquina);
            frmTransiciones.Show();
        }

        private void btnAgregarEstado_Click(object sender, EventArgs e)
        {
            //Metodo que agrega el estado indicado en la caja de texto: txtEstado
            string msg = maquina.AgregarEstado(new Estado() { Etiqueta = txtEstado.Text.Trim() });
            if (!msg.Equals("Ok"))
            {
                MessageBox.Show("Info", msg);
            }
            MostrarListaEstados();
        }

        void MostrarListaEstados()
        {
            //Metodo que lista los estados de la MT en lstEstados
            lstEstados.Items.Clear();
            maquina.Estados.ForEach((e) => lstEstados.Items.Add(e));
        }

        private void btnEliminarEstado_Click(object sender, EventArgs e)
        {
            //Metodo que elimina el estado indicado en la caja de texto: txtEstado
            string msg = maquina.EliminarEstado(new Estado() { Etiqueta = txtEstado.Text.Trim() });
            if (!msg.Equals("Ok"))
            {
                MessageBox.Show("Info", msg);
                MostrarListaEstados();
            }
        }

        private void txtAlfabeto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Control de la caja de texto del alfabeto, si se ingresa un simbolo repetido o reservado se cancela la captura
            lblInfoAlfabeto.Visible = true;
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == maquina.EspacioBlanco)
            {
                e.Handled = true;
                lblInfoAlfabeto.Text = $"Simbolo no valido: {maquina.EspacioBlanco}";
            }
            else if (e.KeyChar == maquina.Marca)
            {
                e.Handled = true;
                lblInfoAlfabeto.Text = $"Simbolo no valido: {maquina.Marca}";
            }
            else if (txtAlfabeto.Text.Trim().ToCharArray().Contains(e.KeyChar))
            {
                e.Handled = true;
                lblInfoAlfabeto.Text = "Simbolo ya ingresado";
            }
            else
            {
                lblInfoAlfabeto.Visible = false;
            }

        }

        private void btnModificarCadena_Click(object sender, EventArgs e)
        {
            //Metodo que elimina la cadena
            maquina.Cadena = txtCadena.Text.Trim();

        }

        private void btnEliminarMaquina_Click(object sender, EventArgs e)
        {
            //Metodo que elimina la configuracion actual de la MT
            maquina = new Maquina();
        }
        void ControlDeAccesoCompontentes(int indicacion) {
        //Metodo que controla la accesibilidad de los componentes en pantalla
        //ToDo: Completar la funcionalidad
            switch(indicacion)
            {
                case 0:
                    grpCadena.Enabled = false;
                    grpEstados.Enabled = false;
                    break;
                case 1: break;
                case 2: break;
                case 3: break;
                case 4: break;
               default: break;
            }
           
        }

        void ActualizarMovimientos() {
            //Metodo que muestra en dgMovimientos las operaciones realizadas por la maquina 

            if (dgMovimiento.Columns.Count == 0) {
                dgMovimiento.Columns.Add("No", "No.");
                for (int i = 0; i < maquina.Cadena.Length; i++)
                {
                    dgMovimiento.Columns.Add($"{i}", $"{i}");
                }
                dgMovimiento.Columns.Add("q", "q");
                dgMovimiento.Columns.Add("SL", "SL");
                dgMovimiento.Columns.Add("NS", "NS");
                dgMovimiento.Columns.Add("p", "p");
                dgMovimiento.Columns.Add("Mov", "Mov");
            }
            dgMovimiento.Rows.Clear();
            foreach (Movimiento mov in maquina.Movimientos)
            {
                DataGridViewRow dr = new DataGridViewRow();
                dr.Cells.Add(dataGridViewCell: new DataGridViewTextBoxCell() { Value = mov.paso});
                char[] cadena = mov.cadena.ToCharArray();

                for (int i = 0; i < cadena.Length; i++)
                {
                    DataGridViewCell cell = new DataGridViewTextBoxCell();
                    cell.Value = cadena[i];
                    cell.Style.BackColor = i == mov.PosicionCabezal ? Color.Red : Color.White;
                    dr.Cells.Add(dataGridViewCell: cell);
                }
                dr.Cells.Add(dataGridViewCell: new DataGridViewTextBoxCell() { Value = mov.transicion.q });
                dr.Cells.Add(dataGridViewCell: new DataGridViewTextBoxCell() { Value = mov.transicion.ValorBuscado });
                dr.Cells.Add(dataGridViewCell: new DataGridViewTextBoxCell() { Value = mov.transicion.ValorNuevo });
                dr.Cells.Add(dataGridViewCell: new DataGridViewTextBoxCell() { Value = mov.transicion.p });
                dr.Cells.Add(dataGridViewCell: new DataGridViewTextBoxCell() { Value = mov.transicion.Movimiento.ToString()});
                dgMovimiento.Rows.Add(dr);
            }        
        }
     
    }
}
