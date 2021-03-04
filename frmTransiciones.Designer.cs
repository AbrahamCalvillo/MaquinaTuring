
namespace MT
{
    partial class frmTransiciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgTransiciones = new System.Windows.Forms.DataGridView();
            this.grpTransiciones = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSimboloNuevo = new System.Windows.Forms.ComboBox();
            this.btnEditarTransicion = new System.Windows.Forms.Button();
            this.btnEliminarTransicion = new System.Windows.Forms.Button();
            this.btnAgregarTransicion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMovimiento = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSimboloLeido = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstadoSiguiente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgTransiciones)).BeginInit();
            this.grpTransiciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgTransiciones
            // 
            this.dgTransiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTransiciones.Location = new System.Drawing.Point(201, 20);
            this.dgTransiciones.Name = "dgTransiciones";
            this.dgTransiciones.Size = new System.Drawing.Size(587, 417);
            this.dgTransiciones.TabIndex = 0;
            this.dgTransiciones.SelectionChanged += new System.EventHandler(this.dgTransiciones_SelectionChanged);
            // 
            // grpTransiciones
            // 
            this.grpTransiciones.Controls.Add(this.label6);
            this.grpTransiciones.Controls.Add(this.cmbSimboloNuevo);
            this.grpTransiciones.Controls.Add(this.btnEditarTransicion);
            this.grpTransiciones.Controls.Add(this.btnEliminarTransicion);
            this.grpTransiciones.Controls.Add(this.btnAgregarTransicion);
            this.grpTransiciones.Controls.Add(this.label5);
            this.grpTransiciones.Controls.Add(this.cmbMovimiento);
            this.grpTransiciones.Controls.Add(this.label4);
            this.grpTransiciones.Controls.Add(this.cmbOperacion);
            this.grpTransiciones.Controls.Add(this.label3);
            this.grpTransiciones.Controls.Add(this.cmbSimboloLeido);
            this.grpTransiciones.Controls.Add(this.label2);
            this.grpTransiciones.Controls.Add(this.cmbEstadoSiguiente);
            this.grpTransiciones.Controls.Add(this.label1);
            this.grpTransiciones.Controls.Add(this.cmbEstado);
            this.grpTransiciones.Location = new System.Drawing.Point(13, 12);
            this.grpTransiciones.Name = "grpTransiciones";
            this.grpTransiciones.Size = new System.Drawing.Size(164, 426);
            this.grpTransiciones.TabIndex = 1;
            this.grpTransiciones.TabStop = false;
            this.grpTransiciones.Text = "Transiciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Simbolo nuevo";
            // 
            // cmbSimboloNuevo
            // 
            this.cmbSimboloNuevo.FormattingEnabled = true;
            this.cmbSimboloNuevo.Location = new System.Drawing.Point(21, 180);
            this.cmbSimboloNuevo.Name = "cmbSimboloNuevo";
            this.cmbSimboloNuevo.Size = new System.Drawing.Size(121, 21);
            this.cmbSimboloNuevo.TabIndex = 13;
            // 
            // btnEditarTransicion
            // 
            this.btnEditarTransicion.Location = new System.Drawing.Point(21, 352);
            this.btnEditarTransicion.Name = "btnEditarTransicion";
            this.btnEditarTransicion.Size = new System.Drawing.Size(121, 23);
            this.btnEditarTransicion.TabIndex = 12;
            this.btnEditarTransicion.Text = "Editar";
            this.btnEditarTransicion.UseVisualStyleBackColor = true;
            this.btnEditarTransicion.Click += new System.EventHandler(this.btnEditarTransicion_Click);
            // 
            // btnEliminarTransicion
            // 
            this.btnEliminarTransicion.Location = new System.Drawing.Point(21, 383);
            this.btnEliminarTransicion.Name = "btnEliminarTransicion";
            this.btnEliminarTransicion.Size = new System.Drawing.Size(121, 23);
            this.btnEliminarTransicion.TabIndex = 11;
            this.btnEliminarTransicion.Text = "Eliminar";
            this.btnEliminarTransicion.UseVisualStyleBackColor = true;
            this.btnEliminarTransicion.Click += new System.EventHandler(this.btnEliminarTransicion_Click);
            // 
            // btnAgregarTransicion
            // 
            this.btnAgregarTransicion.Location = new System.Drawing.Point(21, 321);
            this.btnAgregarTransicion.Name = "btnAgregarTransicion";
            this.btnAgregarTransicion.Size = new System.Drawing.Size(121, 23);
            this.btnAgregarTransicion.TabIndex = 10;
            this.btnAgregarTransicion.Text = "Agregar";
            this.btnAgregarTransicion.UseVisualStyleBackColor = true;
            this.btnAgregarTransicion.Click += new System.EventHandler(this.btnAgregarTransicion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Movimiento";
            // 
            // cmbMovimiento
            // 
            this.cmbMovimiento.FormattingEnabled = true;
            this.cmbMovimiento.Location = new System.Drawing.Point(21, 223);
            this.cmbMovimiento.Name = "cmbMovimiento";
            this.cmbMovimiento.Size = new System.Drawing.Size(121, 21);
            this.cmbMovimiento.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Operacion";
            // 
            // cmbOperacion
            // 
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(21, 137);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(121, 21);
            this.cmbOperacion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Simbolo leido";
            // 
            // cmbSimboloLeido
            // 
            this.cmbSimboloLeido.FormattingEnabled = true;
            this.cmbSimboloLeido.Location = new System.Drawing.Point(21, 88);
            this.cmbSimboloLeido.Name = "cmbSimboloLeido";
            this.cmbSimboloLeido.Size = new System.Drawing.Size(121, 21);
            this.cmbSimboloLeido.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado Siguiente";
            // 
            // cmbEstadoSiguiente
            // 
            this.cmbEstadoSiguiente.FormattingEnabled = true;
            this.cmbEstadoSiguiente.Location = new System.Drawing.Point(21, 266);
            this.cmbEstadoSiguiente.Name = "cmbEstadoSiguiente";
            this.cmbEstadoSiguiente.Size = new System.Drawing.Size(121, 21);
            this.cmbEstadoSiguiente.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estado ";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(21, 45);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(121, 21);
            this.cmbEstado.TabIndex = 0;
            // 
            // frmTransiciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpTransiciones);
            this.Controls.Add(this.dgTransiciones);
            this.Name = "frmTransiciones";
            this.Text = "Transiciones";
            this.Load += new System.EventHandler(this.frmTransiciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTransiciones)).EndInit();
            this.grpTransiciones.ResumeLayout(false);
            this.grpTransiciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgTransiciones;
        private System.Windows.Forms.GroupBox grpTransiciones;
        private System.Windows.Forms.Button btnEditarTransicion;
        private System.Windows.Forms.Button btnEliminarTransicion;
        private System.Windows.Forms.Button btnAgregarTransicion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMovimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSimboloLeido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEstadoSiguiente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbSimboloNuevo;
    }
}