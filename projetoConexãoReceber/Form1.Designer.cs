namespace projetoConexãoReceber
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
            this.components = new System.ComponentModel.Container();
            this.tempoResposta = new System.Windows.Forms.Timer(this.components);
            this.btnIniciarServidor = new System.Windows.Forms.Button();
            this.lblEstadoServidor = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.receberCliente = new System.Windows.Forms.Timer(this.components);
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.movimentoDosTresPontinhos = new System.Windows.Forms.Timer(this.components);
            this.pctPc1 = new System.Windows.Forms.PictureBox();
            this.pctPc2 = new System.Windows.Forms.PictureBox();
            this.pctPc3 = new System.Windows.Forms.PictureBox();
            this.pctPc4 = new System.Windows.Forms.PictureBox();
            this.btnReiniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctPc1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPc2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPc3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPc4)).BeginInit();
            this.SuspendLayout();
            // 
            // tempoResposta
            // 
            this.tempoResposta.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnIniciarServidor
            // 
            this.btnIniciarServidor.Location = new System.Drawing.Point(324, 535);
            this.btnIniciarServidor.Name = "btnIniciarServidor";
            this.btnIniciarServidor.Size = new System.Drawing.Size(75, 23);
            this.btnIniciarServidor.TabIndex = 0;
            this.btnIniciarServidor.Text = "Iniciar servidor";
            this.btnIniciarServidor.UseVisualStyleBackColor = true;
            this.btnIniciarServidor.Click += new System.EventHandler(this.BtnIniciarServidor_Click);
            // 
            // lblEstadoServidor
            // 
            this.lblEstadoServidor.AutoSize = true;
            this.lblEstadoServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoServidor.Location = new System.Drawing.Point(252, 125);
            this.lblEstadoServidor.Name = "lblEstadoServidor";
            this.lblEstadoServidor.Size = new System.Drawing.Size(243, 31);
            this.lblEstadoServidor.TabIndex = 1;
            this.lblEstadoServidor.Text = "Servidor Desligado";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(506, 535);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 3;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(117, 534);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.BtnVerificar_Click);
            // 
            // receberCliente
            // 
            this.receberCliente.Tick += new System.EventHandler(this.ReceberCliente_Tick);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(160, 218);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "PC 1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(160, 325);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 23);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "PC 2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(506, 218);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 23);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "PC 3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(506, 325);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 23);
            this.btn4.TabIndex = 8;
            this.btn4.Text = "PC 4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Btn4_Click);
            // 
            // movimentoDosTresPontinhos
            // 
            this.movimentoDosTresPontinhos.Interval = 500;
            this.movimentoDosTresPontinhos.Tick += new System.EventHandler(this.MovimentoDosTresPontinhos_Tick);
            // 
            // pctPc1
            // 
            this.pctPc1.Location = new System.Drawing.Point(241, 201);
            this.pctPc1.Name = "pctPc1";
            this.pctPc1.Size = new System.Drawing.Size(84, 60);
            this.pctPc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPc1.TabIndex = 13;
            this.pctPc1.TabStop = false;
            // 
            // pctPc2
            // 
            this.pctPc2.Location = new System.Drawing.Point(241, 309);
            this.pctPc2.Name = "pctPc2";
            this.pctPc2.Size = new System.Drawing.Size(84, 60);
            this.pctPc2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPc2.TabIndex = 14;
            this.pctPc2.TabStop = false;
            // 
            // pctPc3
            // 
            this.pctPc3.Location = new System.Drawing.Point(416, 201);
            this.pctPc3.Name = "pctPc3";
            this.pctPc3.Size = new System.Drawing.Size(84, 60);
            this.pctPc3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPc3.TabIndex = 15;
            this.pctPc3.TabStop = false;
            // 
            // pctPc4
            // 
            this.pctPc4.Location = new System.Drawing.Point(416, 309);
            this.pctPc4.Name = "pctPc4";
            this.pctPc4.Size = new System.Drawing.Size(84, 60);
            this.pctPc4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPc4.TabIndex = 16;
            this.pctPc4.TabStop = false;
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(274, 429);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(186, 67);
            this.btnReiniciar.TabIndex = 17;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Visible = false;
            this.btnReiniciar.Click += new System.EventHandler(this.BtnReiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 618);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.pctPc4);
            this.Controls.Add(this.pctPc3);
            this.Controls.Add(this.pctPc2);
            this.Controls.Add(this.pctPc1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.lblEstadoServidor);
            this.Controls.Add(this.btnIniciarServidor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pctPc1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPc2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPc3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPc4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tempoResposta;
        private System.Windows.Forms.Button btnIniciarServidor;
        private System.Windows.Forms.Label lblEstadoServidor;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Timer receberCliente;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Timer movimentoDosTresPontinhos;
        private System.Windows.Forms.PictureBox pctPc1;
        private System.Windows.Forms.PictureBox pctPc2;
        private System.Windows.Forms.PictureBox pctPc3;
        private System.Windows.Forms.PictureBox pctPc4;
        private System.Windows.Forms.Button btnReiniciar;
    }
}

