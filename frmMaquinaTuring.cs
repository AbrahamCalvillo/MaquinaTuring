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
            ControlDeAccesoCompontentes(0);
            dgMovimiento.ReadOnly = true;
            dgMovimiento.AllowUserToAddRows = false;
            dgMovimiento.AllowUserToDeleteRows = false;
            dgMovimiento.RowHeadersVisible = false;
            dgMovimiento.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnGuardarAlfabeto_Click(object sender, EventArgs e)
        {
            //Metodo que guarda el alfabeto capturado
            maquina.Alfabeto = txtAlfabeto.Text.Trim().ToCharArray();
            ControlDeAccesoCompontentes(1);
            MostrarListaEstados();
        }

        private void btnEjecutarMaquina_Click(object sender, EventArgs e)
        {
            //ToDo: Metodo que ejecuta la maquina
            ControlDeAccesoCompontentes(3);
            int c = maquina.PosicionInicial;
            string estado = maquina.EstadoInicial;
            char simboloLeido = ' ';
            string cadena = maquina.Cadena;
            int paso = 1;
            bool continua = true;
            string msg = "";
            try
            {
                do
                {
                    if (c == -1)
                    {
                        continua = false;
                        msg = "La maquina presenta un problema de parada anormal";
                    }
                    else if (estado.Equals(maquina.EstadoFinal))
                    {
                        Movimiento mov = new Movimiento() { Paso = paso, Cadena = cadena, PosicionCabezal = c };
                        maquina.Movimientos.Add(mov);
                        continua = false;
                        msg = "La maquina llego a un estado de aceptacion";
                    }
                    else
                    {
                        Movimiento mov = new Movimiento() { Paso = paso, Cadena = cadena, PosicionCabezal = c };

                        simboloLeido = cadena.ToCharArray()[c];

                        var transicionesDisponibles = maquina.ListaTransiciones.FindAll(t => t.q.Equals(estado) && simboloLeido.Equals(simboloLeido));
                        if (transicionesDisponibles.Count == 0)
                        {
                            //Si el estado actual no tiene transiciones para el simbolo leido tendra un problema.
                            continua = false;
                            msg = "La maquina no encontro una transicion para el estado actual y el simbolo leido";
                        }
                        else
                        {
                            mov.Transicion = transicionesDisponibles.Find(t => t.q.Equals(estado) && t.ValorBuscado.Equals(simboloLeido));
                            estado = mov.Transicion.p;
                            var array = mov.Cadena.ToCharArray();
                            switch (mov.Transicion.Operacion)
                            {
                                case Operaciones.Escribir:
                                    array[c] = mov.Transicion.ValorNuevo;
                                    break;
                                case Operaciones.Borrar:
                                    array[c] = maquina.EspacioBlanco;
                                    break;
                            }
                            Console.WriteLine(new string(array));
                            cadena = new string(array);
                            c += mov.Transicion.Movimiento == Movimientos.Derecha ? 1 : mov.Transicion.Movimiento == Movimientos.Izquierda ? -1 : 0;
                            maquina.Movimientos.Add(mov);
                            paso++;
                        }
                    }
                } while (continua);
            }
            catch (IndexOutOfRangeException)
            {
                msg = "La maquina presenta un problema de parada para esta cadena";
            }
            MessageBox.Show(msg, "info");
            ActualizarMovimientos();
            ControlDeAccesoCompontentes(2);
        }

        private void btnTransiciones_Click(object sender, EventArgs e)
        {
            //Metodo que abre el form de transiciones
            frmTransiciones frmTransiciones = new frmTransiciones(m: maquina);

            frmTransiciones.ShowDialog();
            maquina = frmTransiciones.maquina;
            frmTransiciones.Dispose();
        }

        private void btnAgregarEstado_Click(object sender, EventArgs e)
        {
            //Metodo que agrega el estado indicado en la caja de texto: txtEstado
            string msg = maquina.AgregarEstado(new Estado() { Etiqueta = txtEstado.Text.Trim() });
            if (!msg.Equals("Ok"))
            {
                MessageBox.Show(msg, "Info");
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
                MessageBox.Show(msg,"Info");
               
            }
            MostrarListaEstados();
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
            dgMovimiento.Columns.Clear();
            maquina.Movimientos.Clear();
            grpCadena.Enabled = true;
            ControlDeAccesoCompontentes(1);
        }

        private void btnEliminarMaquina_Click(object sender, EventArgs e)
        {
            //Metodo que elimina la configuracion actual de la MT
            maquina = new Maquina();
            dgMovimiento.Columns.Clear();
            ControlDeAccesoCompontentes(0);
        }
        void ControlDeAccesoCompontentes(int indicacion)
        {
            //Metodo que controla la accesibilidad de los componentes en pantalla
            switch (indicacion)
            {
                case 0:
                    //Antes de capturar el alfabeto
                    grpAlfabeto.Enabled = true;
                    grpCadena.Enabled = false;
                    grpEstados.Enabled = false;
                    btnEjecutarMaquina.Enabled = false;
                    btnModificarCadena.Enabled = false;
                    txtCadena.Text = "";
                    nudPosicionInicio.Value = 0;
                    break;
                case 1:
                    //Despues de capturar el alfabeto
                    grpCadena.Enabled = true;
                    grpEstados.Enabled = true;
                    grpAlfabeto.Enabled = false;
                    btnEjecutarMaquina.Enabled = false;
                    btnModificarCadena.Enabled = false;
                    break;
                case 2:
                    //Despues capturar la cadena
                    grpCadena.Enabled = false;
                    grpEstados.Enabled = true;
                    grpAlfabeto.Enabled = false;
                    btnEjecutarMaquina.Enabled = true;
                    btnModificarCadena.Enabled = true;
                    break;
                case 3:
                    //Al ejecutar la MT
                    grpCadena.Enabled = false;
                    grpEstados.Enabled = false;
                    grpAlfabeto.Enabled = false;
                    btnEjecutarMaquina.Enabled = false;
                    btnModificarCadena.Enabled = false;
                    break;
                default:
                    grpCadena.Enabled = true;
                    grpEstados.Enabled = true;
                    btnEjecutarMaquina.Enabled = true;
                    btnModificarCadena.Enabled = true;
                    break;
            }

        }

        void ActualizarMovimientos()
        {
            //Metodo que muestra en dgMovimientos las operaciones realizadas por la maquina 

            if (dgMovimiento.Columns.Count == 0)
            {
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
                dr.Cells.Add(dataGridViewCell: new DataGridViewTextBoxCell() { Value = mov.Paso });
                char[] cadena = mov.Cadena.ToCharArray();
                for (int i = 0; i < cadena.Length; i++)
                {
                    DataGridViewCellStyle style = new DataGridViewCellStyle();
                    style.BackColor = i == mov.PosicionCabezal ? Color.Red : Color.White;
                    dr.Cells.Add(dataGridViewCell: new DataGridViewTextBoxCell() { Value = cadena[i], Style = style });
                }
                if (mov.Transicion is null)
                {
                    dr.Cells.Add(dataGridViewCell: new DataGridViewTextBoxCell() { Value = "qf" });
                    dgMovimiento.Rows.Add(dr);
                }
                else
                {
                    dr.Cells.Add(dataGridViewCell: new DataGridViewTextBoxCell() { Value = mov.Transicion.q });
                    dr.Cells.Add(dataGridViewCell: new DataGridViewTextBoxCell() { Value = mov.Transicion.ValorBuscado });
                    dr.Cells.Add(dataGridViewCell: new DataGridViewTextBoxCell() { Value = mov.Transicion.ValorNuevo });
                    dr.Cells.Add(dataGridViewCell: new DataGridViewTextBoxCell() { Value = mov.Transicion.p });
                    dr.Cells.Add(dataGridViewCell: new DataGridViewTextBoxCell() { Value = mov.Transicion.Movimiento.ToString() });
                    dgMovimiento.Rows.Add(dr);
                }

            }
        }

        private void btnGuardarCadena_Click(object sender, EventArgs e)
        {
            maquina.Cadena = txtCadena.Text.Trim();
            maquina.PosicionInicial = int.Parse(nudPosicionInicio.Value.ToString());
            ControlDeAccesoCompontentes(2);
        }

        private void txtCadena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Space)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == maquina.EspacioBlanco)
            {
                e.Handled = false;
            }
            else if (e.KeyChar == maquina.Marca)
            {
                e.Handled = false;
            }
            else if (maquina.Alfabeto.Contains(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
