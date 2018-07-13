namespace SIS_ADMINISTRACION_DE_EMPRESA_JUEGO
{
    partial class frmPrincipal
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAGREGARUSUARIO = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.grpUSUARIO = new System.Windows.Forms.GroupBox();
            this.lblMostarUsuario = new System.Windows.Forms.Label();
            this.lblMOSTARCONTRA = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpUSUARIO.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(471, 361);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAGREGARUSUARIO
            // 
            this.btnAGREGARUSUARIO.Location = new System.Drawing.Point(471, 303);
            this.btnAGREGARUSUARIO.Name = "btnAGREGARUSUARIO";
            this.btnAGREGARUSUARIO.Size = new System.Drawing.Size(75, 42);
            this.btnAGREGARUSUARIO.TabIndex = 1;
            this.btnAGREGARUSUARIO.Text = "AGREGARUSUARIO";
            this.btnAGREGARUSUARIO.UseVisualStyleBackColor = true;
            this.btnAGREGARUSUARIO.Click += new System.EventHandler(this.btnAGREGARUSUARIO_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(339, 242);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(31, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(59, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "USUARIO:";
            // 
            // lblContra
            // 
            this.lblContra.AutoSize = true;
            this.lblContra.Location = new System.Drawing.Point(6, 40);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(84, 13);
            this.lblContra.TabIndex = 4;
            this.lblContra.Text = "CONTRASEÑA:";
            // 
            // grpUSUARIO
            // 
            this.grpUSUARIO.Controls.Add(this.lblMOSTARCONTRA);
            this.grpUSUARIO.Controls.Add(this.lblMostarUsuario);
            this.grpUSUARIO.Controls.Add(this.lblUsuario);
            this.grpUSUARIO.Controls.Add(this.lblContra);
            this.grpUSUARIO.Location = new System.Drawing.Point(368, 12);
            this.grpUSUARIO.Name = "grpUSUARIO";
            this.grpUSUARIO.Size = new System.Drawing.Size(178, 61);
            this.grpUSUARIO.TabIndex = 5;
            this.grpUSUARIO.TabStop = false;
            this.grpUSUARIO.Text = "Usuario";
            // 
            // lblMostarUsuario
            // 
            this.lblMostarUsuario.AutoSize = true;
            this.lblMostarUsuario.Location = new System.Drawing.Point(97, 15);
            this.lblMostarUsuario.Name = "lblMostarUsuario";
            this.lblMostarUsuario.Size = new System.Drawing.Size(26, 13);
            this.lblMostarUsuario.TabIndex = 5;
            this.lblMostarUsuario.Text = "LBL";
            // 
            // lblMOSTARCONTRA
            // 
            this.lblMOSTARCONTRA.AutoSize = true;
            this.lblMOSTARCONTRA.Location = new System.Drawing.Point(96, 40);
            this.lblMOSTARCONTRA.Name = "lblMOSTARCONTRA";
            this.lblMOSTARCONTRA.Size = new System.Drawing.Size(35, 13);
            this.lblMOSTARCONTRA.TabIndex = 6;
            this.lblMOSTARCONTRA.Text = "label2";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 396);
            this.ControlBox = false;
            this.Controls.Add(this.grpUSUARIO);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAGREGARUSUARIO);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINCIPAL";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpUSUARIO.ResumeLayout(false);
            this.grpUSUARIO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAGREGARUSUARIO;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.GroupBox grpUSUARIO;
        private System.Windows.Forms.Label lblMOSTARCONTRA;
        private System.Windows.Forms.Label lblMostarUsuario;
    }
}