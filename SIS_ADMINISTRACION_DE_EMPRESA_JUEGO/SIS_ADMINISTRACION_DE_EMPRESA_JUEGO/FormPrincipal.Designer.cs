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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAGREGARUSUARIO = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            this.grpUSUARIO = new System.Windows.Forms.GroupBox();
            this.lblMOSTARCONTRA = new System.Windows.Forms.Label();
            this.lblMostarUsuario = new System.Windows.Forms.Label();
            this.lblus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grpVentas = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvJuegos = new System.Windows.Forms.DataGridView();
            this.juego = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnAGREGARALALISTA = new System.Windows.Forms.Button();
            this.lblContador = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button9 = new System.Windows.Forms.Button();
            this.grpUSUARIO.SuspendLayout();
            this.grpVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(681, 569);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 34);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAGREGARUSUARIO
            // 
            this.btnAGREGARUSUARIO.Location = new System.Drawing.Point(681, 520);
            this.btnAGREGARUSUARIO.Name = "btnAGREGARUSUARIO";
            this.btnAGREGARUSUARIO.Size = new System.Drawing.Size(95, 43);
            this.btnAGREGARUSUARIO.TabIndex = 1;
            this.btnAGREGARUSUARIO.Text = "ADMINISTRAR USUARIOS";
            this.btnAGREGARUSUARIO.UseVisualStyleBackColor = true;
            this.btnAGREGARUSUARIO.Click += new System.EventHandler(this.btnAGREGARUSUARIO_Click);
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
            this.grpUSUARIO.Location = new System.Drawing.Point(445, 12);
            this.grpUSUARIO.Name = "grpUSUARIO";
            this.grpUSUARIO.Size = new System.Drawing.Size(150, 61);
            this.grpUSUARIO.TabIndex = 5;
            this.grpUSUARIO.TabStop = false;
            this.grpUSUARIO.Text = "Usuario";
            // 
            // lblMOSTARCONTRA
            // 
            this.lblMOSTARCONTRA.AutoSize = true;
            this.lblMOSTARCONTRA.Location = new System.Drawing.Point(96, 40);
            this.lblMOSTARCONTRA.Name = "lblMOSTARCONTRA";
            this.lblMOSTARCONTRA.Size = new System.Drawing.Size(35, 13);
            this.lblMOSTARCONTRA.TabIndex = 6;
            this.lblMOSTARCONTRA.Text = "label2";
            this.lblMOSTARCONTRA.Visible = false;
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
            // lblus
            // 
            this.lblus.AutoSize = true;
            this.lblus.Location = new System.Drawing.Point(32, 32);
            this.lblus.Name = "lblus";
            this.lblus.Size = new System.Drawing.Size(46, 13);
            this.lblus.TabIndex = 6;
            this.lblus.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Juego:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "TOTAL:";
            // 
            // grpVentas
            // 
            this.grpVentas.Controls.Add(this.comboBox3);
            this.grpVentas.Controls.Add(this.label6);
            this.grpVentas.Controls.Add(this.label4);
            this.grpVentas.Controls.Add(this.label1);
            this.grpVentas.Controls.Add(this.lblContador);
            this.grpVentas.Controls.Add(this.groupBox1);
            this.grpVentas.Controls.Add(this.comboBox1);
            this.grpVentas.Controls.Add(this.dgvJuegos);
            this.grpVentas.Controls.Add(this.button2);
            this.grpVentas.Controls.Add(this.button1);
            this.grpVentas.Controls.Add(this.label7);
            this.grpVentas.Controls.Add(this.label5);
            this.grpVentas.Controls.Add(this.label3);
            this.grpVentas.Controls.Add(this.lblus);
            this.grpVentas.Location = new System.Drawing.Point(21, 178);
            this.grpVentas.Name = "grpVentas";
            this.grpVentas.Size = new System.Drawing.Size(630, 403);
            this.grpVentas.TabIndex = 10;
            this.grpVentas.TabStop = false;
            this.grpVentas.Text = "VENTAS:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(481, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "IVA:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(420, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "SUB TOTAL:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(446, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "DECLINAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(547, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "COMPRAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dgvJuegos
            // 
            this.dgvJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJuegos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.juego,
            this.precio});
            this.dgvJuegos.Location = new System.Drawing.Point(25, 76);
            this.dgvJuegos.Name = "dgvJuegos";
            this.dgvJuegos.Size = new System.Drawing.Size(244, 294);
            this.dgvJuegos.TabIndex = 16;
            // 
            // juego
            // 
            this.juego.HeaderText = "juego";
            this.juego.Name = "juego";
            // 
            // precio
            // 
            this.precio.HeaderText = "precio";
            this.precio.Name = "precio";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(91, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAGREGARALALISTA);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(298, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 110);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JUEGOS";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(80, 19);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 19;
            // 
            // btnAGREGARALALISTA
            // 
            this.btnAGREGARALALISTA.Location = new System.Drawing.Point(82, 57);
            this.btnAGREGARALALISTA.Name = "btnAGREGARALALISTA";
            this.btnAGREGARALALISTA.Size = new System.Drawing.Size(82, 47);
            this.btnAGREGARALALISTA.TabIndex = 19;
            this.btnAGREGARALALISTA.Text = "AGREGAR AL CARRITO";
            this.btnAGREGARALALISTA.UseVisualStyleBackColor = true;
            // 
            // lblContador
            // 
            this.lblContador.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContador.Location = new System.Drawing.Point(527, 258);
            this.lblContador.Name = "lblContador";
            this.lblContador.Size = new System.Drawing.Size(95, 23);
            this.lblContador.TabIndex = 20;
            this.lblContador.Text = "0";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(527, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "0";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(527, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(681, 471);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 43);
            this.button3.TabIndex = 11;
            this.button3.Text = "ADMINISTRAR JUEGOS";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(681, 419);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 43);
            this.button4.TabIndex = 12;
            this.button4.Text = "ADMINISTRAR UBICACIONES";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(681, 370);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 43);
            this.button5.TabIndex = 13;
            this.button5.Text = "ADMINISTRAR IDIOMAS";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(322, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "METODO DE PAGO:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(469, 152);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(141, 21);
            this.comboBox3.TabIndex = 24;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(681, 314);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 49);
            this.button6.TabIndex = 14;
            this.button6.Text = "ADMINISTRAR METODOS DE PAGO";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(681, 259);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(95, 49);
            this.button7.TabIndex = 15;
            this.button7.Text = "ADMINISTRAR SISTEMA OPERATIVO";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(681, 201);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 49);
            this.button8.TabIndex = 16;
            this.button8.Text = "ADMINISTRAR GENEROS DE JUEGO";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(402, 151);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(681, 146);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 49);
            this.button9.TabIndex = 18;
            this.button9.Text = "REPORTE DE VENTAS";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 606);
            this.ControlBox = false;
            this.Controls.Add(this.button9);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.grpVentas);
            this.Controls.Add(this.grpUSUARIO);
            this.Controls.Add(this.btnAGREGARUSUARIO);
            this.Controls.Add(this.btnSalir);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRINCIPAL";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.grpUSUARIO.ResumeLayout(false);
            this.grpUSUARIO.PerformLayout();
            this.grpVentas.ResumeLayout(false);
            this.grpVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAGREGARUSUARIO;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContra;
        private System.Windows.Forms.GroupBox grpUSUARIO;
        private System.Windows.Forms.Label lblMOSTARCONTRA;
        private System.Windows.Forms.Label lblMostarUsuario;
        private System.Windows.Forms.Label lblus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpVentas;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblContador;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAGREGARALALISTA;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn juego;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button9;
        public System.Windows.Forms.DataGridView dgvJuegos;
    }
}