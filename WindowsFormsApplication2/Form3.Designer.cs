namespace WindowsFormsApplication2
{
    partial class FrmIntroducir
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
            this.lblIntroduzca = new System.Windows.Forms.Label();
            this.lblCantidadJugadores = new System.Windows.Forms.Label();
            this.lblCantidadFichas = new System.Windows.Forms.Label();
            this.lblMayorFicha = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblSiguiente = new System.Windows.Forms.Button();
            this.lblAtras = new System.Windows.Forms.Button();
            this.lblProblema = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIntroduzca
            // 
            this.lblIntroduzca.AutoSize = true;
            this.lblIntroduzca.Location = new System.Drawing.Point(196, 53);
            this.lblIntroduzca.Name = "lblIntroduzca";
            this.lblIntroduzca.Size = new System.Drawing.Size(57, 13);
            this.lblIntroduzca.TabIndex = 0;
            this.lblIntroduzca.Text = "Introduzca";
            // 
            // lblCantidadJugadores
            // 
            this.lblCantidadJugadores.AutoSize = true;
            this.lblCantidadJugadores.Location = new System.Drawing.Point(49, 112);
            this.lblCantidadJugadores.Name = "lblCantidadJugadores";
            this.lblCantidadJugadores.Size = new System.Drawing.Size(119, 13);
            this.lblCantidadJugadores.TabIndex = 1;
            this.lblCantidadJugadores.Text = "Cantidad de Jugadores:";
            // 
            // lblCantidadFichas
            // 
            this.lblCantidadFichas.AutoSize = true;
            this.lblCantidadFichas.Location = new System.Drawing.Point(49, 166);
            this.lblCantidadFichas.Name = "lblCantidadFichas";
            this.lblCantidadFichas.Size = new System.Drawing.Size(145, 13);
            this.lblCantidadFichas.TabIndex = 2;
            this.lblCantidadFichas.Text = "Cantidad de fichas por mano:";
            // 
            // lblMayorFicha
            // 
            this.lblMayorFicha.AutoSize = true;
            this.lblMayorFicha.Location = new System.Drawing.Point(49, 214);
            this.lblMayorFicha.Name = "lblMayorFicha";
            this.lblMayorFicha.Size = new System.Drawing.Size(140, 13);
            this.lblMayorFicha.TabIndex = 3;
            this.lblMayorFicha.Text = "Número mayor en una ficha:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(199, 211);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(199, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(199, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblSiguiente
            // 
            this.lblSiguiente.Location = new System.Drawing.Point(513, 295);
            this.lblSiguiente.Name = "lblSiguiente";
            this.lblSiguiente.Size = new System.Drawing.Size(75, 23);
            this.lblSiguiente.TabIndex = 7;
            this.lblSiguiente.Text = "Siguiente";
            this.lblSiguiente.UseVisualStyleBackColor = true;
            this.lblSiguiente.Click += new System.EventHandler(this.lblSiguiente_Click);
            // 
            // lblAtras
            // 
            this.lblAtras.Location = new System.Drawing.Point(12, 295);
            this.lblAtras.Name = "lblAtras";
            this.lblAtras.Size = new System.Drawing.Size(75, 23);
            this.lblAtras.TabIndex = 8;
            this.lblAtras.Text = "Atras";
            this.lblAtras.UseVisualStyleBackColor = true;
            this.lblAtras.Click += new System.EventHandler(this.lblAtras_Click);
            // 
            // lblProblema
            // 
            this.lblProblema.AutoSize = true;
            this.lblProblema.Location = new System.Drawing.Point(357, 170);
            this.lblProblema.Name = "lblProblema";
            this.lblProblema.Size = new System.Drawing.Size(0, 13);
            this.lblProblema.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 10;
            
            // 
            // FrmIntroducir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 330);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblProblema);
            this.Controls.Add(this.lblAtras);
            this.Controls.Add(this.lblSiguiente);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblMayorFicha);
            this.Controls.Add(this.lblCantidadFichas);
            this.Controls.Add(this.lblCantidadJugadores);
            this.Controls.Add(this.lblIntroduzca);
            this.Name = "FrmIntroducir";
            this.Text = "Domino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIntroducir_FormClosing);
            this.Load += new System.EventHandler(this.FrmIntroducir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIntroduzca;
        private System.Windows.Forms.Label lblCantidadJugadores;
        private System.Windows.Forms.Label lblCantidadFichas;
        private System.Windows.Forms.Label lblMayorFicha;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button lblSiguiente;
        private System.Windows.Forms.Button lblAtras;
        private System.Windows.Forms.Label lblProblema;
        private System.Windows.Forms.Label label1;
    }
}