﻿namespace SIS_ADMINISTRACION_DE_EMPRESA_JUEGO
{
    partial class FormAGREGARUSUARIO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAGREGARUSUARIO));
            this.grpDATOS = new System.Windows.Forms.GroupBox();
            this.picIMAGEN = new System.Windows.Forms.PictureBox();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnAGREGARUSUARIO = new System.Windows.Forms.Button();
            this.cmbPAIS = new System.Windows.Forms.ComboBox();
            this.cmbESTADO = new System.Windows.Forms.ComboBox();
            this.cmbCIUDAD = new System.Windows.Forms.ComboBox();
            this.lblPAIS = new System.Windows.Forms.Label();
            this.lblESTADO = new System.Windows.Forms.Label();
            this.lblCIUDAD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpPERSONAL = new System.Windows.Forms.GroupBox();
            this.grpPERFIL = new System.Windows.Forms.GroupBox();
            this.txtNOMBREPERFIL = new System.Windows.Forms.TextBox();
            this.txtCORREO = new System.Windows.Forms.TextBox();
            this.txtDESCPRIPCION = new System.Windows.Forms.TextBox();
            this.txtAPELLIDOPATERNO = new System.Windows.Forms.TextBox();
            this.txtAPELLIDOMATERNO = new System.Windows.Forms.TextBox();
            this.dtpNACIMIENTO = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txtNOMBRE = new System.Windows.Forms.TextBox();
            this.grpDATOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIMAGEN)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpPERSONAL.SuspendLayout();
            this.grpPERFIL.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDATOS
            // 
            this.grpDATOS.Controls.Add(this.grpPERFIL);
            this.grpDATOS.Controls.Add(this.grpPERSONAL);
            this.grpDATOS.Controls.Add(this.groupBox1);
            this.grpDATOS.Controls.Add(this.btnAGREGARUSUARIO);
            this.grpDATOS.Location = new System.Drawing.Point(47, 27);
            this.grpDATOS.Name = "grpDATOS";
            this.grpDATOS.Size = new System.Drawing.Size(378, 454);
            this.grpDATOS.TabIndex = 0;
            this.grpDATOS.TabStop = false;
            this.grpDATOS.Text = "DATOS:";
            // 
            // picIMAGEN
            // 
            this.picIMAGEN.Image = ((System.Drawing.Image)(resources.GetObject("picIMAGEN.Image")));
            this.picIMAGEN.Location = new System.Drawing.Point(431, 3);
            this.picIMAGEN.Name = "picIMAGEN";
            this.picIMAGEN.Size = new System.Drawing.Size(300, 326);
            this.picIMAGEN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picIMAGEN.TabIndex = 1;
            this.picIMAGEN.TabStop = false;
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Location = new System.Drawing.Point(518, 335);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(124, 23);
            this.btnBUSCAR.TabIndex = 2;
            this.btnBUSCAR.Text = "&BUSCAR IMAGEN";
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Location = new System.Drawing.Point(655, 439);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(76, 42);
            this.btnSALIR.TabIndex = 3;
            this.btnSALIR.Text = "&SALIR";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // btnAGREGARUSUARIO
            // 
            this.btnAGREGARUSUARIO.Location = new System.Drawing.Point(298, 412);
            this.btnAGREGARUSUARIO.Name = "btnAGREGARUSUARIO";
            this.btnAGREGARUSUARIO.Size = new System.Drawing.Size(74, 36);
            this.btnAGREGARUSUARIO.TabIndex = 4;
            this.btnAGREGARUSUARIO.Text = "&AGREGAR USUARIO";
            this.btnAGREGARUSUARIO.UseVisualStyleBackColor = true;
            this.btnAGREGARUSUARIO.Click += new System.EventHandler(this.btnAGREGARUSUARIO_Click);
            // 
            // cmbPAIS
            // 
            this.cmbPAIS.FormattingEnabled = true;
            this.cmbPAIS.Location = new System.Drawing.Point(72, 19);
            this.cmbPAIS.Name = "cmbPAIS";
            this.cmbPAIS.Size = new System.Drawing.Size(223, 21);
            this.cmbPAIS.TabIndex = 5;
            this.cmbPAIS.SelectedIndexChanged += new System.EventHandler(this.cmbPAIS_SelectedIndexChanged);
            // 
            // cmbESTADO
            // 
            this.cmbESTADO.FormattingEnabled = true;
            this.cmbESTADO.Location = new System.Drawing.Point(72, 52);
            this.cmbESTADO.Name = "cmbESTADO";
            this.cmbESTADO.Size = new System.Drawing.Size(223, 21);
            this.cmbESTADO.TabIndex = 6;
            this.cmbESTADO.SelectedIndexChanged += new System.EventHandler(this.cmbESTADO_SelectedIndexChanged);
            // 
            // cmbCIUDAD
            // 
            this.cmbCIUDAD.FormattingEnabled = true;
            this.cmbCIUDAD.Location = new System.Drawing.Point(72, 84);
            this.cmbCIUDAD.Name = "cmbCIUDAD";
            this.cmbCIUDAD.Size = new System.Drawing.Size(223, 21);
            this.cmbCIUDAD.TabIndex = 7;
            // 
            // lblPAIS
            // 
            this.lblPAIS.AutoSize = true;
            this.lblPAIS.Location = new System.Drawing.Point(28, 22);
            this.lblPAIS.Name = "lblPAIS";
            this.lblPAIS.Size = new System.Drawing.Size(34, 13);
            this.lblPAIS.TabIndex = 8;
            this.lblPAIS.Text = "PAIS:";
            // 
            // lblESTADO
            // 
            this.lblESTADO.AutoSize = true;
            this.lblESTADO.Location = new System.Drawing.Point(12, 52);
            this.lblESTADO.Name = "lblESTADO";
            this.lblESTADO.Size = new System.Drawing.Size(54, 13);
            this.lblESTADO.TabIndex = 9;
            this.lblESTADO.Text = "ESTADO:";
            // 
            // lblCIUDAD
            // 
            this.lblCIUDAD.AutoSize = true;
            this.lblCIUDAD.Location = new System.Drawing.Point(15, 84);
            this.lblCIUDAD.Name = "lblCIUDAD";
            this.lblCIUDAD.Size = new System.Drawing.Size(51, 13);
            this.lblCIUDAD.TabIndex = 10;
            this.lblCIUDAD.Text = "CIUDAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "NOMBRE PERFIL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "APELLIDO PATERNO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "APELLIDO MATERNO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "FECHA NACIMIENTO:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "DESCRIPCION:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "CORREO ELECTRONICO:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblPAIS);
            this.groupBox1.Controls.Add(this.cmbPAIS);
            this.groupBox1.Controls.Add(this.cmbESTADO);
            this.groupBox1.Controls.Add(this.cmbCIUDAD);
            this.groupBox1.Controls.Add(this.lblESTADO);
            this.groupBox1.Controls.Add(this.lblCIUDAD);
            this.groupBox1.Location = new System.Drawing.Point(16, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 116);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UBICACION";
            // 
            // grpPERSONAL
            // 
            this.grpPERSONAL.Controls.Add(this.txtNOMBRE);
            this.grpPERSONAL.Controls.Add(this.label7);
            this.grpPERSONAL.Controls.Add(this.dtpNACIMIENTO);
            this.grpPERSONAL.Controls.Add(this.txtAPELLIDOMATERNO);
            this.grpPERSONAL.Controls.Add(this.txtAPELLIDOPATERNO);
            this.grpPERSONAL.Controls.Add(this.label2);
            this.grpPERSONAL.Controls.Add(this.label3);
            this.grpPERSONAL.Controls.Add(this.label4);
            this.grpPERSONAL.Location = new System.Drawing.Point(16, 134);
            this.grpPERSONAL.Name = "grpPERSONAL";
            this.grpPERSONAL.Size = new System.Drawing.Size(343, 150);
            this.grpPERSONAL.TabIndex = 4;
            this.grpPERSONAL.TabStop = false;
            this.grpPERSONAL.Text = "PERSONAL";
            // 
            // grpPERFIL
            // 
            this.grpPERFIL.Controls.Add(this.txtDESCPRIPCION);
            this.grpPERFIL.Controls.Add(this.txtCORREO);
            this.grpPERFIL.Controls.Add(this.txtNOMBREPERFIL);
            this.grpPERFIL.Controls.Add(this.label1);
            this.grpPERFIL.Controls.Add(this.label5);
            this.grpPERFIL.Controls.Add(this.label6);
            this.grpPERFIL.Location = new System.Drawing.Point(16, 19);
            this.grpPERFIL.Name = "grpPERFIL";
            this.grpPERFIL.Size = new System.Drawing.Size(343, 109);
            this.grpPERFIL.TabIndex = 4;
            this.grpPERFIL.TabStop = false;
            this.grpPERFIL.Text = "PERFIL";
            // 
            // txtNOMBREPERFIL
            // 
            this.txtNOMBREPERFIL.Location = new System.Drawing.Point(162, 17);
            this.txtNOMBREPERFIL.Name = "txtNOMBREPERFIL";
            this.txtNOMBREPERFIL.Size = new System.Drawing.Size(175, 20);
            this.txtNOMBREPERFIL.TabIndex = 17;
            // 
            // txtCORREO
            // 
            this.txtCORREO.Location = new System.Drawing.Point(162, 52);
            this.txtCORREO.Name = "txtCORREO";
            this.txtCORREO.Size = new System.Drawing.Size(175, 20);
            this.txtCORREO.TabIndex = 18;
            // 
            // txtDESCPRIPCION
            // 
            this.txtDESCPRIPCION.Location = new System.Drawing.Point(162, 78);
            this.txtDESCPRIPCION.Name = "txtDESCPRIPCION";
            this.txtDESCPRIPCION.Size = new System.Drawing.Size(175, 20);
            this.txtDESCPRIPCION.TabIndex = 19;
            // 
            // txtAPELLIDOPATERNO
            // 
            this.txtAPELLIDOPATERNO.Location = new System.Drawing.Point(140, 13);
            this.txtAPELLIDOPATERNO.Name = "txtAPELLIDOPATERNO";
            this.txtAPELLIDOPATERNO.Size = new System.Drawing.Size(175, 20);
            this.txtAPELLIDOPATERNO.TabIndex = 20;
            // 
            // txtAPELLIDOMATERNO
            // 
            this.txtAPELLIDOMATERNO.Location = new System.Drawing.Point(140, 49);
            this.txtAPELLIDOMATERNO.Name = "txtAPELLIDOMATERNO";
            this.txtAPELLIDOMATERNO.Size = new System.Drawing.Size(175, 20);
            this.txtAPELLIDOMATERNO.TabIndex = 21;
            // 
            // dtpNACIMIENTO
            // 
            this.dtpNACIMIENTO.Location = new System.Drawing.Point(137, 116);
            this.dtpNACIMIENTO.Name = "dtpNACIMIENTO";
            this.dtpNACIMIENTO.Size = new System.Drawing.Size(200, 20);
            this.dtpNACIMIENTO.TabIndex = 23;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "NOMBRE:";
            // 
            // txtNOMBRE
            // 
            this.txtNOMBRE.Location = new System.Drawing.Point(140, 84);
            this.txtNOMBRE.Name = "txtNOMBRE";
            this.txtNOMBRE.Size = new System.Drawing.Size(175, 20);
            this.txtNOMBRE.TabIndex = 22;
            // 
            // FormAGREGARUSUARIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 486);
            this.ControlBox = false;
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnBUSCAR);
            this.Controls.Add(this.picIMAGEN);
            this.Controls.Add(this.grpDATOS);
            this.Name = "FormAGREGARUSUARIO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGREGAR USUARIO";
            this.Load += new System.EventHandler(this.FormAGREGARUSUARIO_Load);
            this.grpDATOS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIMAGEN)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpPERSONAL.ResumeLayout(false);
            this.grpPERSONAL.PerformLayout();
            this.grpPERFIL.ResumeLayout(false);
            this.grpPERFIL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDATOS;
        private System.Windows.Forms.PictureBox picIMAGEN;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.GroupBox grpPERFIL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpPERSONAL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPAIS;
        private System.Windows.Forms.ComboBox cmbPAIS;
        private System.Windows.Forms.ComboBox cmbESTADO;
        private System.Windows.Forms.ComboBox cmbCIUDAD;
        private System.Windows.Forms.Label lblESTADO;
        private System.Windows.Forms.Label lblCIUDAD;
        private System.Windows.Forms.Button btnAGREGARUSUARIO;
        private System.Windows.Forms.TextBox txtDESCPRIPCION;
        private System.Windows.Forms.TextBox txtCORREO;
        private System.Windows.Forms.TextBox txtNOMBREPERFIL;
        private System.Windows.Forms.TextBox txtAPELLIDOMATERNO;
        private System.Windows.Forms.TextBox txtAPELLIDOPATERNO;
        private System.Windows.Forms.DateTimePicker dtpNACIMIENTO;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox txtNOMBRE;
        private System.Windows.Forms.Label label7;
    }
}