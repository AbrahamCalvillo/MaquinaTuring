
namespace MT
{
    partial class frmMaquinaTuring
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAlfabeto = new System.Windows.Forms.TextBox();
            this.btnGuardarAlfabeto = new System.Windows.Forms.Button();
            this.grpAlfabeto = new System.Windows.Forms.GroupBox();
            this.lblInfoAlfabeto = new System.Windows.Forms.Label();
            this.grpEstados = new System.Windows.Forms.GroupBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnTransiciones = new System.Windows.Forms.Button();
            this.btnEliminarEstado = new System.Windows.Forms.Button();
            this.lstEstados = new System.Windows.Forms.ListBox();
            this.btnAgregarEstado = new System.Windows.Forms.Button();
            this.grpCadena = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudPosicionInicio = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardarCadena = new System.Windows.Forms.Button();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.dgMovimiento = new System.Windows.Forms.DataGridView();
            this.btnEjecutarMaquina = new System.Windows.Forms.Button();
            this.btnModificarCadena = new System.Windows.Forms.Button();
            this.btnEliminarMaquina = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.grpAlfabeto.SuspendLayout();
            this.grpEstados.SuspendLayout();
            this.grpCadena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosicionInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAlfabeto
            // 
            this.txtAlfabeto.Location = new System.Drawing.Point(17, 21);
            this.txtAlfabeto.Name = "txtAlfabeto";
            this.txtAlfabeto.Size = new System.Drawing.Size(131, 20);
            this.txtAlfabeto.TabIndex = 0;
            this.txtAlfabeto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAlfabeto_KeyPress);
            // 
            // btnGuardarAlfabeto
            // 
            this.btnGuardarAlfabeto.Location = new System.Drawing.Point(172, 18);
            this.btnGuardarAlfabeto.Name = "btnGuardarAlfabeto";
            this.btnGuardarAlfabeto.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAlfabeto.TabIndex = 2;
            this.btnGuardarAlfabeto.Text = "Guardar";
            this.btnGuardarAlfabeto.UseVisualStyleBackColor = true;
            this.btnGuardarAlfabeto.Click += new System.EventHandler(this.btnGuardarAlfabeto_Click);
            // 
            // grpAlfabeto
            // 
            this.grpAlfabeto.Controls.Add(this.label3);
            this.grpAlfabeto.Controls.Add(this.lblInfoAlfabeto);
            this.grpAlfabeto.Controls.Add(this.btnGuardarAlfabeto);
            this.grpAlfabeto.Controls.Add(this.txtAlfabeto);
            this.grpAlfabeto.Location = new System.Drawing.Point(23, 12);
            this.grpAlfabeto.Name = "grpAlfabeto";
            this.grpAlfabeto.Size = new System.Drawing.Size(266, 88);
            this.grpAlfabeto.TabIndex = 3;
            this.grpAlfabeto.TabStop = false;
            this.grpAlfabeto.Text = "Alfabeto";
            // 
            // lblInfoAlfabeto
            // 
            this.lblInfoAlfabeto.AutoSize = true;
            this.lblInfoAlfabeto.ForeColor = System.Drawing.Color.Red;
            this.lblInfoAlfabeto.Location = new System.Drawing.Point(17, 45);
            this.lblInfoAlfabeto.Name = "lblInfoAlfabeto";
            this.lblInfoAlfabeto.Size = new System.Drawing.Size(0, 13);
            this.lblInfoAlfabeto.TabIndex = 3;
            this.lblInfoAlfabeto.Visible = false;
            // 
            // grpEstados
            // 
            this.grpEstados.Controls.Add(this.txtEstado);
            this.grpEstados.Controls.Add(this.btnTransiciones);
            this.grpEstados.Controls.Add(this.btnEliminarEstado);
            this.grpEstados.Controls.Add(this.lstEstados);
            this.grpEstados.Controls.Add(this.btnAgregarEstado);
            this.grpEstados.Location = new System.Drawing.Point(23, 115);
            this.grpEstados.Name = "grpEstados";
            this.grpEstados.Size = new System.Drawing.Size(265, 306);
            this.grpEstados.TabIndex = 4;
            this.grpEstados.TabStop = false;
            this.grpEstados.Text = "Lista de estados";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(17, 241);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(67, 20);
            this.txtEstado.TabIndex = 4;
            // 
            // btnTransiciones
            // 
            this.btnTransiciones.Location = new System.Drawing.Point(16, 272);
            this.btnTransiciones.Name = "btnTransiciones";
            this.btnTransiciones.Size = new System.Drawing.Size(236, 23);
            this.btnTransiciones.TabIndex = 3;
            this.btnTransiciones.Text = "Ver Transiciones";
            this.btnTransiciones.UseVisualStyleBackColor = true;
            this.btnTransiciones.Click += new System.EventHandler(this.btnTransiciones_Click);
            // 
            // btnEliminarEstado
            // 
            this.btnEliminarEstado.Location = new System.Drawing.Point(171, 241);
            this.btnEliminarEstado.Name = "btnEliminarEstado";
            this.btnEliminarEstado.Size = new System.Drawing.Size(80, 23);
            this.btnEliminarEstado.TabIndex = 2;
            this.btnEliminarEstado.Text = "Eliminar";
            this.btnEliminarEstado.UseVisualStyleBackColor = true;
            this.btnEliminarEstado.Click += new System.EventHandler(this.btnEliminarEstado_Click);
            // 
            // lstEstados
            // 
            this.lstEstados.FormattingEnabled = true;
            this.lstEstados.Location = new System.Drawing.Point(16, 19);
            this.lstEstados.Name = "lstEstados";
            this.lstEstados.Size = new System.Drawing.Size(235, 212);
            this.lstEstados.TabIndex = 0;
            // 
            // btnAgregarEstado
            // 
            this.btnAgregarEstado.Location = new System.Drawing.Point(90, 241);
            this.btnAgregarEstado.Name = "btnAgregarEstado";
            this.btnAgregarEstado.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEstado.TabIndex = 1;
            this.btnAgregarEstado.Text = "Agregar";
            this.btnAgregarEstado.UseVisualStyleBackColor = true;
            this.btnAgregarEstado.Click += new System.EventHandler(this.btnAgregarEstado_Click);
            // 
            // grpCadena
            // 
            this.grpCadena.Controls.Add(this.label2);
            this.grpCadena.Controls.Add(this.nudPosicionInicio);
            this.grpCadena.Controls.Add(this.label1);
            this.grpCadena.Controls.Add(this.btnGuardarCadena);
            this.grpCadena.Controls.Add(this.txtCadena);
            this.grpCadena.Location = new System.Drawing.Point(22, 427);
            this.grpCadena.Name = "grpCadena";
            this.grpCadena.Size = new System.Drawing.Size(266, 120);
            this.grpCadena.TabIndex = 5;
            this.grpCadena.TabStop = false;
            this.grpCadena.Text = "Configuracion de Inicio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Posicion Inicio";
            // 
            // nudPosicionInicio
            // 
            this.nudPosicionInicio.Location = new System.Drawing.Point(97, 72);
            this.nudPosicionInicio.Name = "nudPosicionInicio";
            this.nudPosicionInicio.Size = new System.Drawing.Size(54, 20);
            this.nudPosicionInicio.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadena";
            // 
            // btnGuardarCadena
            // 
            this.btnGuardarCadena.Location = new System.Drawing.Point(172, 69);
            this.btnGuardarCadena.Name = "btnGuardarCadena";
            this.btnGuardarCadena.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCadena.TabIndex = 2;
            this.btnGuardarCadena.Text = "Guardar";
            this.btnGuardarCadena.UseVisualStyleBackColor = true;
            this.btnGuardarCadena.Click += new System.EventHandler(this.btnGuardarCadena_Click);
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(97, 35);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(150, 20);
            this.txtCadena.TabIndex = 0;
            this.txtCadena.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCadena_KeyPress);
            // 
            // dgMovimiento
            // 
            this.dgMovimiento.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMovimiento.Location = new System.Drawing.Point(320, 64);
            this.dgMovimiento.Name = "dgMovimiento";
            this.dgMovimiento.Size = new System.Drawing.Size(457, 482);
            this.dgMovimiento.TabIndex = 6;
            // 
            // btnEjecutarMaquina
            // 
            this.btnEjecutarMaquina.Location = new System.Drawing.Point(320, 25);
            this.btnEjecutarMaquina.Name = "btnEjecutarMaquina";
            this.btnEjecutarMaquina.Size = new System.Drawing.Size(126, 24);
            this.btnEjecutarMaquina.TabIndex = 7;
            this.btnEjecutarMaquina.Text = "Ejecutar";
            this.btnEjecutarMaquina.UseVisualStyleBackColor = true;
            this.btnEjecutarMaquina.Click += new System.EventHandler(this.btnEjecutarMaquina_Click);
            // 
            // btnModificarCadena
            // 
            this.btnModificarCadena.Location = new System.Drawing.Point(489, 25);
            this.btnModificarCadena.Name = "btnModificarCadena";
            this.btnModificarCadena.Size = new System.Drawing.Size(126, 24);
            this.btnModificarCadena.TabIndex = 8;
            this.btnModificarCadena.Text = "Modificar Cadena";
            this.btnModificarCadena.UseVisualStyleBackColor = true;
            this.btnModificarCadena.Click += new System.EventHandler(this.btnModificarCadena_Click);
            // 
            // btnEliminarMaquina
            // 
            this.btnEliminarMaquina.Location = new System.Drawing.Point(651, 25);
            this.btnEliminarMaquina.Name = "btnEliminarMaquina";
            this.btnEliminarMaquina.Size = new System.Drawing.Size(126, 24);
            this.btnEliminarMaquina.TabIndex = 9;
            this.btnEliminarMaquina.Text = "Eliminar Maquina";
            this.btnEliminarMaquina.UseVisualStyleBackColor = true;
            this.btnEliminarMaquina.Click += new System.EventHandler(this.btnEliminarMaquina_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ß= Espacio en blanco (alt + 225), * = Marca";
            // 
            // frmMaquinaTuring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 577);
            this.Controls.Add(this.btnEliminarMaquina);
            this.Controls.Add(this.btnModificarCadena);
            this.Controls.Add(this.btnEjecutarMaquina);
            this.Controls.Add(this.dgMovimiento);
            this.Controls.Add(this.grpCadena);
            this.Controls.Add(this.grpEstados);
            this.Controls.Add(this.grpAlfabeto);
            this.Name = "frmMaquinaTuring";
            this.Text = "Maquina de Turing";
            this.Load += new System.EventHandler(this.frmMaquinaTuring_Load);
            this.grpAlfabeto.ResumeLayout(false);
            this.grpAlfabeto.PerformLayout();
            this.grpEstados.ResumeLayout(false);
            this.grpEstados.PerformLayout();
            this.grpCadena.ResumeLayout(false);
            this.grpCadena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPosicionInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMovimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlfabeto;
        private System.Windows.Forms.Button btnGuardarAlfabeto;
        private System.Windows.Forms.GroupBox grpAlfabeto;
        private System.Windows.Forms.GroupBox grpEstados;
        private System.Windows.Forms.Button btnEliminarEstado;
        private System.Windows.Forms.Button btnAgregarEstado;
        private System.Windows.Forms.ListBox lstEstados;
        private System.Windows.Forms.Button btnTransiciones;
        private System.Windows.Forms.GroupBox grpCadena;
        private System.Windows.Forms.Button btnGuardarCadena;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.DataGridView dgMovimiento;
        private System.Windows.Forms.Button btnEjecutarMaquina;
        private System.Windows.Forms.Button btnModificarCadena;
        private System.Windows.Forms.Button btnEliminarMaquina;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblInfoAlfabeto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudPosicionInicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}

