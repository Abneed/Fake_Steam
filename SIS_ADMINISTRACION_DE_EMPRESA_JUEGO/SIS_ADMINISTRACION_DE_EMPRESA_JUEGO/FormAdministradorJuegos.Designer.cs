namespace SIS_ADMINISTRACION_DE_EMPRESA_JUEGO
{
    partial class FormAdministradorJuegos
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
            this.components = new System.ComponentModel.Container();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscarJuego = new System.Windows.Forms.Button();
            this.cmbJuegoSeleccion = new System.Windows.Forms.ComboBox();
            this.btnAccion = new System.Windows.Forms.Button();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDistribuidores = new System.Windows.Forms.ComboBox();
            this.cmbClasificacionJuego = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbDesarrolladorJuego = new System.Windows.Forms.ComboBox();
            this.dtpJuegoLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreJuego = new System.Windows.Forms.TextBox();
            this.grpOpcion = new System.Windows.Forms.GroupBox();
            this.radActualizarJuego = new System.Windows.Forms.RadioButton();
            this.radBorrarJuego = new System.Windows.Forms.RadioButton();
            this.radNuevoJuego = new System.Windows.Forms.RadioButton();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.grpEliminar = new System.Windows.Forms.GroupBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.grpIDJuego = new System.Windows.Forms.GroupBox();
            this.lblMOSTARJUEGO = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.grpDatos.SuspendLayout();
            this.grpOpcion.SuspendLayout();
            this.grpEliminar.SuspendLayout();
            this.grpIDJuego.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(472, 392);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(67, 31);
            this.btnSalir.TabIndex = 36;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBuscarJuego
            // 
            this.btnBuscarJuego.Location = new System.Drawing.Point(28, 57);
            this.btnBuscarJuego.Name = "btnBuscarJuego";
            this.btnBuscarJuego.Size = new System.Drawing.Size(75, 36);
            this.btnBuscarJuego.TabIndex = 35;
            this.btnBuscarJuego.Text = "Buscar";
            this.btnBuscarJuego.UseVisualStyleBackColor = true;
            this.btnBuscarJuego.Click += new System.EventHandler(this.btnBuscarJuego_Click);
            // 
            // cmbJuegoSeleccion
            // 
            this.cmbJuegoSeleccion.FormattingEnabled = true;
            this.cmbJuegoSeleccion.Location = new System.Drawing.Point(9, 18);
            this.cmbJuegoSeleccion.Name = "cmbJuegoSeleccion";
            this.cmbJuegoSeleccion.Size = new System.Drawing.Size(233, 21);
            this.cmbJuegoSeleccion.TabIndex = 34;
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(135, 290);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(73, 37);
            this.btnAccion.TabIndex = 33;
            this.btnAccion.Text = "AGREGAR JUEGO";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtCantidad);
            this.grpDatos.Controls.Add(this.label7);
            this.grpDatos.Controls.Add(this.btnActualizar);
            this.grpDatos.Controls.Add(this.grpIDJuego);
            this.grpDatos.Controls.Add(this.btnLimpiar);
            this.grpDatos.Controls.Add(this.btnAccion);
            this.grpDatos.Controls.Add(this.label6);
            this.grpDatos.Controls.Add(this.txtPrecio);
            this.grpDatos.Controls.Add(this.label5);
            this.grpDatos.Controls.Add(this.cmbDistribuidores);
            this.grpDatos.Controls.Add(this.cmbClasificacionJuego);
            this.grpDatos.Controls.Add(this.label4);
            this.grpDatos.Controls.Add(this.cmbDesarrolladorJuego);
            this.grpDatos.Controls.Add(this.dtpJuegoLanzamiento);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Controls.Add(this.txtNombreJuego);
            this.grpDatos.Location = new System.Drawing.Point(7, 64);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(282, 340);
            this.grpDatos.TabIndex = 32;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            this.grpDatos.Enter += new System.EventHandler(this.grpDatos_Enter);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(213, 290);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(63, 37);
            this.btnLimpiar.TabIndex = 31;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Precio";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(8, 306);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(109, 20);
            this.txtPrecio.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Distribuidor";
            // 
            // cmbDistribuidores
            // 
            this.cmbDistribuidores.FormattingEnabled = true;
            this.cmbDistribuidores.Location = new System.Drawing.Point(30, 250);
            this.cmbDistribuidores.Name = "cmbDistribuidores";
            this.cmbDistribuidores.Size = new System.Drawing.Size(121, 21);
            this.cmbDistribuidores.TabIndex = 10;
            // 
            // cmbClasificacionJuego
            // 
            this.cmbClasificacionJuego.FormattingEnabled = true;
            this.cmbClasificacionJuego.Location = new System.Drawing.Point(6, 185);
            this.cmbClasificacionJuego.Name = "cmbClasificacionJuego";
            this.cmbClasificacionJuego.Size = new System.Drawing.Size(121, 21);
            this.cmbClasificacionJuego.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Clasificacion";
            // 
            // cmbDesarrolladorJuego
            // 
            this.cmbDesarrolladorJuego.FormattingEnabled = true;
            this.cmbDesarrolladorJuego.Location = new System.Drawing.Point(30, 131);
            this.cmbDesarrolladorJuego.Name = "cmbDesarrolladorJuego";
            this.cmbDesarrolladorJuego.Size = new System.Drawing.Size(121, 21);
            this.cmbDesarrolladorJuego.TabIndex = 7;
            // 
            // dtpJuegoLanzamiento
            // 
            this.dtpJuegoLanzamiento.Location = new System.Drawing.Point(42, 82);
            this.dtpJuegoLanzamiento.Name = "dtpJuegoLanzamiento";
            this.dtpJuegoLanzamiento.Size = new System.Drawing.Size(200, 20);
            this.dtpJuegoLanzamiento.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desarrollador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lanzamiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // txtNombreJuego
            // 
            this.txtNombreJuego.Location = new System.Drawing.Point(21, 32);
            this.txtNombreJuego.Name = "txtNombreJuego";
            this.txtNombreJuego.Size = new System.Drawing.Size(235, 20);
            this.txtNombreJuego.TabIndex = 0;
            // 
            // grpOpcion
            // 
            this.grpOpcion.Controls.Add(this.radActualizarJuego);
            this.grpOpcion.Controls.Add(this.radBorrarJuego);
            this.grpOpcion.Controls.Add(this.radNuevoJuego);
            this.grpOpcion.Location = new System.Drawing.Point(7, 10);
            this.grpOpcion.Name = "grpOpcion";
            this.grpOpcion.Size = new System.Drawing.Size(288, 48);
            this.grpOpcion.TabIndex = 31;
            this.grpOpcion.TabStop = false;
            this.grpOpcion.Text = "Opcion";
            // 
            // radActualizarJuego
            // 
            this.radActualizarJuego.AutoSize = true;
            this.radActualizarJuego.Location = new System.Drawing.Point(182, 19);
            this.radActualizarJuego.Name = "radActualizarJuego";
            this.radActualizarJuego.Size = new System.Drawing.Size(100, 17);
            this.radActualizarJuego.TabIndex = 7;
            this.radActualizarJuego.Text = "Actualizar juego";
            this.radActualizarJuego.UseVisualStyleBackColor = true;
            this.radActualizarJuego.CheckedChanged += new System.EventHandler(this.radActualizarJuego_CheckedChanged);
            // 
            // radBorrarJuego
            // 
            this.radBorrarJuego.AutoSize = true;
            this.radBorrarJuego.Location = new System.Drawing.Point(91, 19);
            this.radBorrarJuego.Name = "radBorrarJuego";
            this.radBorrarJuego.Size = new System.Drawing.Size(85, 17);
            this.radBorrarJuego.TabIndex = 6;
            this.radBorrarJuego.Text = "Borrar Juego";
            this.radBorrarJuego.UseVisualStyleBackColor = true;
            this.radBorrarJuego.CheckedChanged += new System.EventHandler(this.radBorrarJuego_CheckedChanged);
            // 
            // radNuevoJuego
            // 
            this.radNuevoJuego.AutoSize = true;
            this.radNuevoJuego.Location = new System.Drawing.Point(6, 19);
            this.radNuevoJuego.Name = "radNuevoJuego";
            this.radNuevoJuego.Size = new System.Drawing.Size(89, 17);
            this.radNuevoJuego.TabIndex = 5;
            this.radNuevoJuego.Text = "Nuevo Juego";
            this.radNuevoJuego.UseVisualStyleBackColor = true;
            this.radNuevoJuego.CheckedChanged += new System.EventHandler(this.radNuevoJuego_CheckedChanged);
            // 
            // Timer1
            // 
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Location = new System.Drawing.Point(134, 55);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(69, 38);
            this.btnELIMINAR.TabIndex = 37;
            this.btnELIMINAR.Text = "ELIMINAR";
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // grpEliminar
            // 
            this.grpEliminar.Controls.Add(this.cmbJuegoSeleccion);
            this.grpEliminar.Controls.Add(this.btnELIMINAR);
            this.grpEliminar.Controls.Add(this.btnBuscarJuego);
            this.grpEliminar.Location = new System.Drawing.Point(295, 97);
            this.grpEliminar.Name = "grpEliminar";
            this.grpEliminar.Size = new System.Drawing.Size(261, 109);
            this.grpEliminar.TabIndex = 38;
            this.grpEliminar.TabStop = false;
            this.grpEliminar.Text = "buscar/eliminar";
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(191, 234);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(85, 46);
            this.btnActualizar.TabIndex = 38;
            this.btnActualizar.Text = "ACTUALIZAR JUEGO";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // grpIDJuego
            // 
            this.grpIDJuego.Controls.Add(this.lblMOSTARJUEGO);
            this.grpIDJuego.Location = new System.Drawing.Point(182, 108);
            this.grpIDJuego.Name = "grpIDJuego";
            this.grpIDJuego.Size = new System.Drawing.Size(89, 45);
            this.grpIDJuego.TabIndex = 39;
            this.grpIDJuego.TabStop = false;
            this.grpIDJuego.Text = "IDJUEGO";
            // 
            // lblMOSTARJUEGO
            // 
            this.lblMOSTARJUEGO.AutoSize = true;
            this.lblMOSTARJUEGO.Location = new System.Drawing.Point(6, 23);
            this.lblMOSTARJUEGO.Name = "lblMOSTARJUEGO";
            this.lblMOSTARJUEGO.Size = new System.Drawing.Size(41, 13);
            this.lblMOSTARJUEGO.TabIndex = 26;
            this.lblMOSTARJUEGO.Text = "label13";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "CANTIDAD:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(168, 185);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 41;
            // 
            // AdministrarJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 435);
            this.Controls.Add(this.grpEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpOpcion);
            this.Name = "AdministrarJuegos";
            this.Text = "AdministrarJuegos";
            this.Load += new System.EventHandler(this.AdministrarJuegos_Load);
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpOpcion.ResumeLayout(false);
            this.grpOpcion.PerformLayout();
            this.grpEliminar.ResumeLayout(false);
            this.grpIDJuego.ResumeLayout(false);
            this.grpIDJuego.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscarJuego;
        private System.Windows.Forms.ComboBox cmbJuegoSeleccion;
        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDistribuidores;
        private System.Windows.Forms.ComboBox cmbClasificacionJuego;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDesarrolladorJuego;
        private System.Windows.Forms.DateTimePicker dtpJuegoLanzamiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreJuego;
        private System.Windows.Forms.GroupBox grpOpcion;
        private System.Windows.Forms.RadioButton radActualizarJuego;
        private System.Windows.Forms.RadioButton radBorrarJuego;
        private System.Windows.Forms.RadioButton radNuevoJuego;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.GroupBox grpEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.GroupBox grpIDJuego;
        private System.Windows.Forms.Label lblMOSTARJUEGO;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label7;
    }
}