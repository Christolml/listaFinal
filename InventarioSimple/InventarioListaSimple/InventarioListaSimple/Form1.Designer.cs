namespace InventarioListaSimple
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grbConsulta = new System.Windows.Forms.GroupBox();
            this.txtCodigoConsulta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txtReporte = new System.Windows.Forms.TextBox();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReporteVolteado = new System.Windows.Forms.Button();
            this.btnAgregarOrdenado = new System.Windows.Forms.Button();
            this.btnAgregarInicio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.btnInsertarPos = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPosiciónConsulta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminarPos = new System.Windows.Forms.Button();
            this.btnBuscarPos = new System.Windows.Forms.Button();
            this.grbConsulta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbConsulta
            // 
            this.grbConsulta.Controls.Add(this.txtCodigoConsulta);
            this.grbConsulta.Controls.Add(this.label1);
            this.grbConsulta.Controls.Add(this.btnEliminar);
            this.grbConsulta.Controls.Add(this.btnBuscar);
            this.grbConsulta.Location = new System.Drawing.Point(612, 442);
            this.grbConsulta.Name = "grbConsulta";
            this.grbConsulta.Size = new System.Drawing.Size(386, 200);
            this.grbConsulta.TabIndex = 32;
            this.grbConsulta.TabStop = false;
            this.grbConsulta.Text = "Buscar/Eliminar";
            // 
            // txtCodigoConsulta
            // 
            this.txtCodigoConsulta.Location = new System.Drawing.Point(24, 83);
            this.txtCodigoConsulta.Name = "txtCodigoConsulta";
            this.txtCodigoConsulta.Size = new System.Drawing.Size(164, 38);
            this.txtCodigoConsulta.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(240, 140);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(136, 45);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(24, 140);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 45);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(617, 314);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(107, 38);
            this.txtCod.TabIndex = 31;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(465, 307);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(136, 45);
            this.btnInsertar.TabIndex = 30;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txtReporte
            // 
            this.txtReporte.Location = new System.Drawing.Point(852, 15);
            this.txtReporte.Multiline = true;
            this.txtReporte.Name = "txtReporte";
            this.txtReporte.Size = new System.Drawing.Size(340, 392);
            this.txtReporte.TabIndex = 29;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(18, 493);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(136, 45);
            this.btnReporte.TabIndex = 27;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click_1);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(14, 289);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(136, 45);
            this.btnAgregar.TabIndex = 26;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(146, 220);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(192, 38);
            this.txtPrecio.TabIndex = 25;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(36, 226);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(104, 32);
            this.lblPrecio.TabIndex = 24;
            this.lblPrecio.Text = "Precio:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(171, 164);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(192, 38);
            this.txtCantidad.TabIndex = 23;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(27, 170);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(138, 32);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(156, 101);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 38);
            this.txtNombre.TabIndex = 21;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 107);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(123, 32);
            this.lblNombre.TabIndex = 20;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(147, 42);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(192, 38);
            this.txtCodigo.TabIndex = 19;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(27, 48);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(114, 32);
            this.lblCodigo.TabIndex = 18;
            this.lblCodigo.Text = "Código:";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1076, 606);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 45);
            this.btnSalir.TabIndex = 19;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(459, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 64);
            this.label2.TabIndex = 33;
            this.label2.Text = "Desde qué código \r\nva insertar?";
            // 
            // btnReporteVolteado
            // 
            this.btnReporteVolteado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteVolteado.Location = new System.Drawing.Point(18, 544);
            this.btnReporteVolteado.Name = "btnReporteVolteado";
            this.btnReporteVolteado.Size = new System.Drawing.Size(136, 70);
            this.btnReporteVolteado.TabIndex = 34;
            this.btnReporteVolteado.Text = "Reporte\r\nvolteado\r\n";
            this.btnReporteVolteado.UseVisualStyleBackColor = true;
            this.btnReporteVolteado.Click += new System.EventHandler(this.btnReporteVolteado_Click);
            // 
            // btnAgregarOrdenado
            // 
            this.btnAgregarOrdenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarOrdenado.Location = new System.Drawing.Point(18, 413);
            this.btnAgregarOrdenado.Name = "btnAgregarOrdenado";
            this.btnAgregarOrdenado.Size = new System.Drawing.Size(132, 74);
            this.btnAgregarOrdenado.TabIndex = 35;
            this.btnAgregarOrdenado.Text = "Agregar\r\nOrdenado";
            this.btnAgregarOrdenado.UseVisualStyleBackColor = true;
            this.btnAgregarOrdenado.Click += new System.EventHandler(this.btnAgregarOrdenado_Click);
            // 
            // btnAgregarInicio
            // 
            this.btnAgregarInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarInicio.Location = new System.Drawing.Point(14, 340);
            this.btnAgregarInicio.Name = "btnAgregarInicio";
            this.btnAgregarInicio.Size = new System.Drawing.Size(136, 67);
            this.btnAgregarInicio.TabIndex = 36;
            this.btnAgregarInicio.Text = "Agregar\r\nen inicio\r\n";
            this.btnAgregarInicio.UseVisualStyleBackColor = true;
            this.btnAgregarInicio.Click += new System.EventHandler(this.btnAgregarInicio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 32);
            this.label3.TabIndex = 39;
            this.label3.Text = "Posición:";
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(612, 107);
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(107, 38);
            this.txtPos.TabIndex = 38;
            // 
            // btnInsertarPos
            // 
            this.btnInsertarPos.Location = new System.Drawing.Point(465, 146);
            this.btnInsertarPos.Name = "btnInsertarPos";
            this.btnInsertarPos.Size = new System.Drawing.Size(136, 45);
            this.btnInsertarPos.TabIndex = 37;
            this.btnInsertarPos.Text = "Insertar";
            this.btnInsertarPos.UseVisualStyleBackColor = true;
            this.btnInsertarPos.Click += new System.EventHandler(this.btnInsertarPos_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPosiciónConsulta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnEliminarPos);
            this.groupBox1.Controls.Add(this.btnBuscarPos);
            this.groupBox1.Location = new System.Drawing.Point(179, 447);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(386, 200);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar/Eliminar";
            // 
            // txtPosiciónConsulta
            // 
            this.txtPosiciónConsulta.Location = new System.Drawing.Point(24, 83);
            this.txtPosiciónConsulta.Name = "txtPosiciónConsulta";
            this.txtPosiciónConsulta.Size = new System.Drawing.Size(164, 38);
            this.txtPosiciónConsulta.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Posición:";
            // 
            // btnEliminarPos
            // 
            this.btnEliminarPos.Location = new System.Drawing.Point(240, 140);
            this.btnEliminarPos.Name = "btnEliminarPos";
            this.btnEliminarPos.Size = new System.Drawing.Size(136, 45);
            this.btnEliminarPos.TabIndex = 8;
            this.btnEliminarPos.Text = "Eliminar";
            this.btnEliminarPos.UseVisualStyleBackColor = true;
            this.btnEliminarPos.Click += new System.EventHandler(this.btnEliminarPos_Click);
            // 
            // btnBuscarPos
            // 
            this.btnBuscarPos.Location = new System.Drawing.Point(24, 140);
            this.btnBuscarPos.Name = "btnBuscarPos";
            this.btnBuscarPos.Size = new System.Drawing.Size(136, 45);
            this.btnBuscarPos.TabIndex = 9;
            this.btnBuscarPos.Text = "Buscar";
            this.btnBuscarPos.UseVisualStyleBackColor = true;
            this.btnBuscarPos.Click += new System.EventHandler(this.btnBuscarPos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1224, 663);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.btnInsertarPos);
            this.Controls.Add(this.btnAgregarInicio);
            this.Controls.Add(this.btnAgregarOrdenado);
            this.Controls.Add(this.btnReporteVolteado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbConsulta);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txtReporte);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblCodigo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Inventario";
            this.grbConsulta.ResumeLayout(false);
            this.grbConsulta.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbConsulta;
        private System.Windows.Forms.TextBox txtCodigoConsulta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txtReporte;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReporteVolteado;
        private System.Windows.Forms.Button btnAgregarOrdenado;
        private System.Windows.Forms.Button btnAgregarInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Button btnInsertarPos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPosiciónConsulta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminarPos;
        private System.Windows.Forms.Button btnBuscarPos;
    }
}

