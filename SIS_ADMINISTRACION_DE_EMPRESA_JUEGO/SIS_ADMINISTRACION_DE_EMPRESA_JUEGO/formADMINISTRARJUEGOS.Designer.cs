namespace SIS_ADMINISTRACION_DE_EMPRESA_JUEGO
{
    partial class formADMINISTRARJUEGOS
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
            this.grpOpcion = new System.Windows.Forms.GroupBox();
            this.radAgregar = new System.Windows.Forms.RadioButton();
            this.radEliminar = new System.Windows.Forms.RadioButton();
            this.radModificar = new System.Windows.Forms.RadioButton();
            this.grpOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOpcion
            // 
            this.grpOpcion.Controls.Add(this.radModificar);
            this.grpOpcion.Controls.Add(this.radEliminar);
            this.grpOpcion.Controls.Add(this.radAgregar);
            this.grpOpcion.Location = new System.Drawing.Point(12, 12);
            this.grpOpcion.Name = "grpOpcion";
            this.grpOpcion.Size = new System.Drawing.Size(282, 49);
            this.grpOpcion.TabIndex = 0;
            this.grpOpcion.TabStop = false;
            this.grpOpcion.Text = "Seleccionar";
            // 
            // radAgregar
            // 
            this.radAgregar.AutoSize = true;
            this.radAgregar.Checked = true;
            this.radAgregar.Location = new System.Drawing.Point(7, 20);
            this.radAgregar.Name = "radAgregar";
            this.radAgregar.Size = new System.Drawing.Size(62, 17);
            this.radAgregar.TabIndex = 0;
            this.radAgregar.TabStop = true;
            this.radAgregar.Text = "Agregar";
            this.radAgregar.UseVisualStyleBackColor = true;
            this.radAgregar.CheckedChanged += new System.EventHandler(this.radAgregar_CheckedChanged);
            // 
            // radEliminar
            // 
            this.radEliminar.AutoSize = true;
            this.radEliminar.Location = new System.Drawing.Point(98, 20);
            this.radEliminar.Name = "radEliminar";
            this.radEliminar.Size = new System.Drawing.Size(61, 17);
            this.radEliminar.TabIndex = 1;
            this.radEliminar.Text = "Eliminar";
            this.radEliminar.UseVisualStyleBackColor = true;
            this.radEliminar.CheckedChanged += new System.EventHandler(this.radEliminar_CheckedChanged);
            // 
            // radModificar
            // 
            this.radModificar.AutoSize = true;
            this.radModificar.Location = new System.Drawing.Point(189, 20);
            this.radModificar.Name = "radModificar";
            this.radModificar.Size = new System.Drawing.Size(68, 17);
            this.radModificar.TabIndex = 2;
            this.radModificar.Text = "Modificar";
            this.radModificar.UseVisualStyleBackColor = true;
            this.radModificar.CheckedChanged += new System.EventHandler(this.radModificar_CheckedChanged);
            // 
            // formADMINISTRARJUEGOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpOpcion);
            this.Name = "formADMINISTRARJUEGOS";
            this.Text = "ADMINISTRAR JUEGOS";
            this.grpOpcion.ResumeLayout(false);
            this.grpOpcion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOpcion;
        private System.Windows.Forms.RadioButton radModificar;
        private System.Windows.Forms.RadioButton radEliminar;
        private System.Windows.Forms.RadioButton radAgregar;
    }
}