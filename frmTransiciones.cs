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
    public partial class frmTransiciones : Form
    {
        public Maquina maquina;
        public frmTransiciones( Maquina m)
        {
            this.maquina = m;
            InitializeComponent();
        }

        private void frmTransiciones_Load(object sender, EventArgs e)
        {
        }
    }
}
