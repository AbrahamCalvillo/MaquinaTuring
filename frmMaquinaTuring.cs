using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT
{
    public partial class frmMaquinaTuring : Form
    {

        Maquina maquina;

        public frmMaquinaTuring()
        {
            InitializeComponent();
        }

        private void btnGuardarAlfabeto_Click(object sender, EventArgs e)
        {
            if (maquina == null)
            {
                maquina = new Maquina();
                maquina.Alfabeto = txtAlfabeto.Text.Trim().ToCharArray();
                maquina.EstadoInicial = "q0";
                maquina.EstadoFinal = "qf";
                maquina.AgregarEstado(new Estado() { Etiqueta = "q0" });
                maquina.AgregarEstado(new Estado() { Etiqueta = "qf" });
            }
            else
            {
                maquina.Alfabeto = txtAlfabeto.Text.Trim().ToCharArray();
            }               
        }

        private void btnEjecutarMaquina_Click(object sender, EventArgs e)
        {
            
        }

        private void btnTransiciones_Click(object sender, EventArgs e)
        {
            frmTransiciones frmTransiciones = new frmTransiciones(m:maquina);
            frmTransiciones.Show();
        }

        private void btnAgregarEstado_Click(object sender, EventArgs e)
        {
         string msg =  maquina.AgregarEstado(new Estado() { Etiqueta = txtEstado.Text.Trim() });
            if (!msg.Equals("Ok")) 
            {
                MessageBox.Show("Info",msg);
            }
        }
    }
}
