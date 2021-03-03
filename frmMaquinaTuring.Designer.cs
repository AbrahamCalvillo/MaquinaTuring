
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTransiciones = new System.Windows.Forms.Button();
            this.btnEliminarEstado = new System.Windows.Forms.Button();
            this.lstEstados = new System.Windows.Forms.ListBox();
            this.btnAgregarEstado = new System.Windows.Forms.Button();
            this.grpCadena = new System.Windows.Forms.GroupBox();
            this.btnGuardarCadena = new System.Windows.Forms.Button();
            this.txtCadena = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEjecutarMaquina = new System.Windows.Forms.Button();
            this.btnModificarCadena = new System.Windows.Forms.Button();
            this.btnEliminarMaquina = new System.Windows.Forms.Button();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grpCadena.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAlfabeto
            // 
            this.txtAlfabeto.Location = new System.Drawing.Point(17, 37);
            this.txtAlfabeto.Name = "txtAlfabeto";
            this.txtAlfabeto.Size = new System.Drawing.Size(131, 20);
            this.txtAlfabeto.TabIndex = 0;
            // 
            // btnGuardarAlfabeto
            // 
            this.btnGuardarAlfabeto.Location = new System.Drawing.Point(172, 34);
            this.btnGuardarAlfabeto.Name = "btnGuardarAlfabeto";
            this.btnGuardarAlfabeto.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarAlfabeto.TabIndex = 2;
            this.btnGuardarAlfabeto.Text = "Guardar";
            this.btnGuardarAlfabeto.UseVisualStyleBackColor = true;
            this.btnGuardarAlfabeto.Click += new System.EventHandler(this.btnGuardarAlfabeto_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardarAlfabeto);
            this.groupBox1.Controls.Add(this.txtAlfabeto);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 88);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alfabeto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEstado);
            this.groupBox2.Controls.Add(this.btnTransiciones);
            this.groupBox2.Controls.Add(this.btnEliminarEstado);
            this.groupBox2.Controls.Add(this.lstEstados);
            this.groupBox2.Controls.Add(this.btnAgregarEstado);
            this.groupBox2.Location = new System.Drawing.Point(23, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 329);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista de estados";
            // 
            // btnTransiciones
            // 
            this.btnTransiciones.Location = new System.Drawing.Point(16, 283);
            this.btnTransiciones.Name = "btnTransiciones";
            this.btnTransiciones.Size = new System.Drawing.Size(236, 23);
            this.btnTransiciones.TabIndex = 3;
            this.btnTransiciones.Text = "Ver Transiciones";
            this.btnTransiciones.UseVisualStyleBackColor = true;
            this.btnTransiciones.Click += new System.EventHandler(this.btnTransiciones_Click);
            // 
            // btnEliminarEstado
            // 
            this.btnEliminarEstado.Location = new System.Drawing.Point(171, 252);
            this.btnEliminarEstado.Name = "btnEliminarEstado";
            this.btnEliminarEstado.Size = new System.Drawing.Size(80, 23);
            this.btnEliminarEstado.TabIndex = 2;
            this.btnEliminarEstado.Text = "Eliminar";
            this.btnEliminarEstado.UseVisualStyleBackColor = true;
            // 
            // lstEstados
            // 
            this.lstEstados.FormattingEnabled = true;
            this.lstEstados.Location = new System.Drawing.Point(16, 30);
            this.lstEstados.Name = "lstEstados";
            this.lstEstados.Size = new System.Drawing.Size(235, 212);
            this.lstEstados.TabIndex = 0;
            // 
            // btnAgregarEstado
            // 
            this.btnAgregarEstado.Location = new System.Drawing.Point(90, 252);
            this.btnAgregarEstado.Name = "btnAgregarEstado";
            this.btnAgregarEstado.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEstado.TabIndex = 1;
            this.btnAgregarEstado.Text = "Agregar";
            this.btnAgregarEstado.UseVisualStyleBackColor = true;
            this.btnAgregarEstado.Click += new System.EventHandler(this.btnAgregarEstado_Click);
            // 
            // grpCadena
            // 
            this.grpCadena.Controls.Add(this.btnGuardarCadena);
            this.grpCadena.Controls.Add(this.txtCadena);
            this.grpCadena.Location = new System.Drawing.Point(22, 459);
            this.grpCadena.Name = "grpCadena";
            this.grpCadena.Size = new System.Drawing.Size(266, 88);
            this.grpCadena.TabIndex = 5;
            this.grpCadena.TabStop = false;
            this.grpCadena.Text = "Cadena";
            // 
            // btnGuardarCadena
            // 
            this.btnGuardarCadena.Location = new System.Drawing.Point(172, 34);
            this.btnGuardarCadena.Name = "btnGuardarCadena";
            this.btnGuardarCadena.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCadena.TabIndex = 2;
            this.btnGuardarCadena.Text = "Guardar";
            this.btnGuardarCadena.UseVisualStyleBackColor = true;
            // 
            // txtCadena
            // 
            this.txtCadena.Location = new System.Drawing.Point(17, 37);
            this.txtCadena.Name = "txtCadena";
            this.txtCadena.Size = new System.Drawing.Size(131, 20);
            this.txtCadena.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(457, 482);
            this.dataGridView1.TabIndex = 6;
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
            // 
            // btnEliminarMaquina
            // 
            this.btnEliminarMaquina.Location = new System.Drawing.Point(651, 25);
            this.btnEliminarMaquina.Name = "btnEliminarMaquina";
            this.btnEliminarMaquina.Size = new System.Drawing.Size(126, 24);
            this.btnEliminarMaquina.TabIndex = 9;
            this.btnEliminarMaquina.Text = "Eliminar Maquina";
            this.btnEliminarMaquina.UseVisualStyleBackColor = true;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(17, 252);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(67, 20);
            this.txtEstado.TabIndex = 4;
            // 
            // frmMaquinaTuring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 577);
            this.Controls.Add(this.btnEliminarMaquina);
            this.Controls.Add(this.btnModificarCadena);
            this.Controls.Add(this.btnEjecutarMaquina);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grpCadena);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMaquinaTuring";
            this.Text = "Maquina de Turing";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpCadena.ResumeLayout(false);
            this.grpCadena.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtAlfabeto;
        private System.Windows.Forms.Button btnGuardarAlfabeto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminarEstado;
        private System.Windows.Forms.Button btnAgregarEstado;
        private System.Windows.Forms.ListBox lstEstados;
        private System.Windows.Forms.Button btnTransiciones;
        private System.Windows.Forms.GroupBox grpCadena;
        private System.Windows.Forms.Button btnGuardarCadena;
        private System.Windows.Forms.TextBox txtCadena;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEjecutarMaquina;
        private System.Windows.Forms.Button btnModificarCadena;
        private System.Windows.Forms.Button btnEliminarMaquina;
        private System.Windows.Forms.TextBox txtEstado;
    }
}

