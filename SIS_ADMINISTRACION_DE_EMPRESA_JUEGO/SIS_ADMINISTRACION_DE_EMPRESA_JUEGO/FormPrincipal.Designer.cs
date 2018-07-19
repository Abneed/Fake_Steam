namespace SIS_ADMINISTRACION_DE_EMPRESA_JUEGO
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
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
            this.cmbMETODODEPAGO = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMostraTotal = new System.Windows.Forms.Label();
            this.lblIVA = new System.Windows.Forms.Label();
            this.lblsubTOTAL = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCANTIDADEXISTENCIA = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMOSTARPRECIO = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAGREGARALALISTA = new System.Windows.Forms.Button();
            this.cmbJuegos = new System.Windows.Forms.ComboBox();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.dgvJuegos = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdministrarJuegos = new System.Windows.Forms.Button();
            this.btnAdministrarUbicaciones = new System.Windows.Forms.Button();
            this.btnAdministrarMetodosDePago = new System.Windows.Forms.Button();
            this.btnAdministrarSistemaOperativo = new System.Windows.Forms.Button();
            this.btnAdministraGenero = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReporteDeVentas = new System.Windows.Forms.Button();
            this.TMRJUEGO = new System.Windows.Forms.Timer(this.components);
            this.tmrTotal = new System.Windows.Forms.Timer(this.components);
            this.grpUSUARIO.SuspendLayout();
            this.grpVentas.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(780, 560);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 34);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAGREGARUSUARIO
            // 
            this.btnAGREGARUSUARIO.Location = new System.Drawing.Point(780, 511);
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
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Juego:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(580, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "TOTAL:";
            // 
            // grpVentas
            // 
            this.grpVentas.Controls.Add(this.cmbMETODODEPAGO);
            this.grpVentas.Controls.Add(this.label6);
            this.grpVentas.Controls.Add(this.lblMostraTotal);
            this.grpVentas.Controls.Add(this.lblIVA);
            this.grpVentas.Controls.Add(this.lblsubTOTAL);
            this.grpVentas.Controls.Add(this.groupBox1);
            this.grpVentas.Controls.Add(this.cmbUsuarios);
            this.grpVentas.Controls.Add(this.dgvJuegos);
            this.grpVentas.Controls.Add(this.button2);
            this.grpVentas.Controls.Add(this.button1);
            this.grpVentas.Controls.Add(this.label7);
            this.grpVentas.Controls.Add(this.label5);
            this.grpVentas.Controls.Add(this.label3);
            this.grpVentas.Controls.Add(this.lblus);
            this.grpVentas.Location = new System.Drawing.Point(21, 178);
            this.grpVentas.Name = "grpVentas";
            this.grpVentas.Size = new System.Drawing.Size(753, 403);
            this.grpVentas.TabIndex = 10;
            this.grpVentas.TabStop = false;
            this.grpVentas.Text = "VENTAS:";
            this.grpVentas.Enter += new System.EventHandler(this.grpVentas_Enter);
            // 
            // cmbMETODODEPAGO
            // 
            this.cmbMETODODEPAGO.FormattingEnabled = true;
            this.cmbMETODODEPAGO.Location = new System.Drawing.Point(594, 165);
            this.cmbMETODODEPAGO.Name = "cmbMETODODEPAGO";
            this.cmbMETODODEPAGO.Size = new System.Drawing.Size(141, 21);
            this.cmbMETODODEPAGO.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(447, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "METODO DE PAGO:";
            // 
            // lblMostraTotal
            // 
            this.lblMostraTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostraTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostraTotal.Location = new System.Drawing.Point(652, 335);
            this.lblMostraTotal.Name = "lblMostraTotal";
            this.lblMostraTotal.Size = new System.Drawing.Size(95, 23);
            this.lblMostraTotal.TabIndex = 22;
            this.lblMostraTotal.Text = "0";
            // 
            // lblIVA
            // 
            this.lblIVA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIVA.Location = new System.Drawing.Point(652, 304);
            this.lblIVA.Name = "lblIVA";
            this.lblIVA.Size = new System.Drawing.Size(96, 23);
            this.lblIVA.TabIndex = 21;
            this.lblIVA.Text = "0";
            // 
            // lblsubTOTAL
            // 
            this.lblsubTOTAL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblsubTOTAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubTOTAL.Location = new System.Drawing.Point(652, 271);
            this.lblsubTOTAL.Name = "lblsubTOTAL";
            this.lblsubTOTAL.Size = new System.Drawing.Size(95, 23);
            this.lblsubTOTAL.TabIndex = 20;
            this.lblsubTOTAL.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCANTIDADEXISTENCIA);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblMOSTARPRECIO);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnAGREGARALALISTA);
            this.groupBox1.Controls.Add(this.cmbJuegos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(423, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 115);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JUEGOS";
            // 
            // lblCANTIDADEXISTENCIA
            // 
            this.lblCANTIDADEXISTENCIA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCANTIDADEXISTENCIA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCANTIDADEXISTENCIA.Location = new System.Drawing.Point(226, 73);
            this.lblCANTIDADEXISTENCIA.Name = "lblCANTIDADEXISTENCIA";
            this.lblCANTIDADEXISTENCIA.Size = new System.Drawing.Size(94, 23);
            this.lblCANTIDADEXISTENCIA.TabIndex = 27;
            this.lblCANTIDADEXISTENCIA.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(85, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 16);
            this.label10.TabIndex = 26;
            this.label10.Text = "APROX EXISTENCIA:";
            // 
            // lblMOSTARPRECIO
            // 
            this.lblMOSTARPRECIO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMOSTARPRECIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMOSTARPRECIO.Location = new System.Drawing.Point(225, 45);
            this.lblMOSTARPRECIO.Name = "lblMOSTARPRECIO";
            this.lblMOSTARPRECIO.Size = new System.Drawing.Size(94, 23);
            this.lblMOSTARPRECIO.TabIndex = 25;
            this.lblMOSTARPRECIO.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(154, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 24);
            this.label8.TabIndex = 20;
            this.label8.Text = "Precio:";
            // 
            // btnAGREGARALALISTA
            // 
            this.btnAGREGARALALISTA.Location = new System.Drawing.Point(1, 58);
            this.btnAGREGARALALISTA.Name = "btnAGREGARALALISTA";
            this.btnAGREGARALALISTA.Size = new System.Drawing.Size(82, 47);
            this.btnAGREGARALALISTA.TabIndex = 19;
            this.btnAGREGARALALISTA.Text = "AGREGAR AL CARRITO";
            this.btnAGREGARALALISTA.UseVisualStyleBackColor = true;
            this.btnAGREGARALALISTA.Click += new System.EventHandler(this.btnAGREGARALALISTA_Click);
            // 
            // cmbJuegos
            // 
            this.cmbJuegos.FormattingEnabled = true;
            this.cmbJuegos.Location = new System.Drawing.Point(80, 19);
            this.cmbJuegos.Name = "cmbJuegos";
            this.cmbJuegos.Size = new System.Drawing.Size(121, 21);
            this.cmbJuegos.TabIndex = 19;
            this.cmbJuegos.SelectedIndexChanged += new System.EventHandler(this.cmbJuegos_SelectedIndexChanged);
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(91, 29);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(121, 21);
            this.cmbUsuarios.TabIndex = 17;
            // 
            // dgvJuegos
            // 
            this.dgvJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJuegos.Location = new System.Drawing.Point(25, 76);
            this.dgvJuegos.Name = "dgvJuegos";
            this.dgvJuegos.Size = new System.Drawing.Size(344, 294);
            this.dgvJuegos.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(672, 374);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "COMPRAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "DECLINAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(545, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "SUB TOTAL:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(606, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "IVA:";
            // 
            // btnAdministrarJuegos
            // 
            this.btnAdministrarJuegos.Location = new System.Drawing.Point(780, 462);
            this.btnAdministrarJuegos.Name = "btnAdministrarJuegos";
            this.btnAdministrarJuegos.Size = new System.Drawing.Size(95, 43);
            this.btnAdministrarJuegos.TabIndex = 11;
            this.btnAdministrarJuegos.Text = "ADMINISTRAR JUEGOS";
            this.btnAdministrarJuegos.UseVisualStyleBackColor = true;
            this.btnAdministrarJuegos.Click += new System.EventHandler(this.btnAdministrarJuegos_Click);
            // 
            // btnAdministrarUbicaciones
            // 
            this.btnAdministrarUbicaciones.Location = new System.Drawing.Point(780, 410);
            this.btnAdministrarUbicaciones.Name = "btnAdministrarUbicaciones";
            this.btnAdministrarUbicaciones.Size = new System.Drawing.Size(95, 43);
            this.btnAdministrarUbicaciones.TabIndex = 12;
            this.btnAdministrarUbicaciones.Text = "ADMINISTRAR UBICACIONES";
            this.btnAdministrarUbicaciones.UseVisualStyleBackColor = true;
            // 
            // btnAdministrarMetodosDePago
            // 
            this.btnAdministrarMetodosDePago.Location = new System.Drawing.Point(780, 355);
            this.btnAdministrarMetodosDePago.Name = "btnAdministrarMetodosDePago";
            this.btnAdministrarMetodosDePago.Size = new System.Drawing.Size(95, 49);
            this.btnAdministrarMetodosDePago.TabIndex = 14;
            this.btnAdministrarMetodosDePago.Text = "ADMINISTRAR METODOS DE PAGO";
            this.btnAdministrarMetodosDePago.UseVisualStyleBackColor = true;
            // 
            // btnAdministrarSistemaOperativo
            // 
            this.btnAdministrarSistemaOperativo.Location = new System.Drawing.Point(780, 293);
            this.btnAdministrarSistemaOperativo.Name = "btnAdministrarSistemaOperativo";
            this.btnAdministrarSistemaOperativo.Size = new System.Drawing.Size(95, 49);
            this.btnAdministrarSistemaOperativo.TabIndex = 15;
            this.btnAdministrarSistemaOperativo.Text = "ADMINISTRAR SISTEMA OPERATIVO";
            this.btnAdministrarSistemaOperativo.UseVisualStyleBackColor = true;
            // 
            // btnAdministraGenero
            // 
            this.btnAdministraGenero.Location = new System.Drawing.Point(780, 235);
            this.btnAdministraGenero.Name = "btnAdministraGenero";
            this.btnAdministraGenero.Size = new System.Drawing.Size(95, 49);
            this.btnAdministraGenero.TabIndex = 16;
            this.btnAdministraGenero.Text = "ADMINISTRAR GENEROS DE JUEGO";
            this.btnAdministraGenero.UseVisualStyleBackColor = true;
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
            // btnReporteDeVentas
            // 
            this.btnReporteDeVentas.Location = new System.Drawing.Point(780, 170);
            this.btnReporteDeVentas.Name = "btnReporteDeVentas";
            this.btnReporteDeVentas.Size = new System.Drawing.Size(95, 49);
            this.btnReporteDeVentas.TabIndex = 18;
            this.btnReporteDeVentas.Text = "REPORTE DE VENTAS";
            this.btnReporteDeVentas.UseVisualStyleBackColor = true;
            this.btnReporteDeVentas.Click += new System.EventHandler(this.btnReporteDeVentas_Click);
            // 
            // TMRJUEGO
            // 
            this.TMRJUEGO.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrTotal
            // 
            this.tmrTotal.Tick += new System.EventHandler(this.tmrTotal_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 606);
            this.ControlBox = false;
            this.Controls.Add(this.btnReporteDeVentas);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdministraGenero);
            this.Controls.Add(this.btnAdministrarSistemaOperativo);
            this.Controls.Add(this.btnAdministrarMetodosDePago);
            this.Controls.Add(this.btnAdministrarUbicaciones);
            this.Controls.Add(this.btnAdministrarJuegos);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).EndInit();
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
        public System.Windows.Forms.Label lblMostraTotal;
        public System.Windows.Forms.Label lblIVA;
        public System.Windows.Forms.Label lblsubTOTAL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAGREGARALALISTA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdministrarJuegos;
        private System.Windows.Forms.Button btnAdministrarUbicaciones;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdministrarMetodosDePago;
        private System.Windows.Forms.Button btnAdministrarSistemaOperativo;
        private System.Windows.Forms.Button btnAdministraGenero;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReporteDeVentas;
        public System.Windows.Forms.DataGridView dgvJuegos;
        public System.Windows.Forms.ComboBox cmbJuegos;
        public System.Windows.Forms.ComboBox cmbUsuarios;
        public System.Windows.Forms.Label lblMOSTARPRECIO;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cmbMETODODEPAGO;
        public System.Windows.Forms.Timer TMRJUEGO;
        public System.Windows.Forms.Label lblCANTIDADEXISTENCIA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer tmrTotal;
    }
}