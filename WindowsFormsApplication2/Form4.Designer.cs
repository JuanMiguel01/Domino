namespace WindowsFormsApplication2
{
    partial class frmIntroducirJugadores
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtJugador1 = new System.Windows.Forms.TextBox();
            this.grbTiposdeJugadores = new System.Windows.Forms.GroupBox();
            this.rbnJugadorComunista = new System.Windows.Forms.RadioButton();
            this.rbnJugadorBotaGorda = new System.Windows.Forms.RadioButton();
            this.rbnJugadorRandom = new System.Windows.Forms.RadioButton();
            this.rbnJugadorInteligente = new System.Windows.Forms.RadioButton();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnSiguienteJugadoroSiguiente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.lblEquipo = new System.Windows.Forms.Label();
            this.grbTiposdeJugadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // txtJugador1
            // 
            this.txtJugador1.Location = new System.Drawing.Point(141, 99);
            this.txtJugador1.Name = "txtJugador1";
            this.txtJugador1.Size = new System.Drawing.Size(146, 20);
            this.txtJugador1.TabIndex = 2;
            
            // 
            // grbTiposdeJugadores
            // 
            this.grbTiposdeJugadores.Controls.Add(this.rbnJugadorComunista);
            this.grbTiposdeJugadores.Controls.Add(this.rbnJugadorBotaGorda);
            this.grbTiposdeJugadores.Controls.Add(this.rbnJugadorRandom);
            this.grbTiposdeJugadores.Controls.Add(this.rbnJugadorInteligente);
            this.grbTiposdeJugadores.Location = new System.Drawing.Point(24, 138);
            this.grbTiposdeJugadores.Name = "grbTiposdeJugadores";
            this.grbTiposdeJugadores.Size = new System.Drawing.Size(364, 153);
            this.grbTiposdeJugadores.TabIndex = 3;
            this.grbTiposdeJugadores.TabStop = false;
            this.grbTiposdeJugadores.Text = "Elija al tipo de jugador";
            // 
            // rbnJugadorComunista
            // 
            this.rbnJugadorComunista.AutoSize = true;
            this.rbnJugadorComunista.Location = new System.Drawing.Point(207, 52);
            this.rbnJugadorComunista.Name = "rbnJugadorComunista";
            this.rbnJugadorComunista.Size = new System.Drawing.Size(110, 17);
            this.rbnJugadorComunista.TabIndex = 4;
            this.rbnJugadorComunista.Text = "JugadorOrdenado";
            this.rbnJugadorComunista.UseVisualStyleBackColor = true;
            this.rbnJugadorComunista.CheckedChanged += new System.EventHandler(this.rbnJugadorComunista_CheckedChanged);
            // 
            // rbnJugadorBotaGorda
            // 
            this.rbnJugadorBotaGorda.AutoSize = true;
            this.rbnJugadorBotaGorda.Location = new System.Drawing.Point(27, 75);
            this.rbnJugadorBotaGorda.Name = "rbnJugadorBotaGorda";
            this.rbnJugadorBotaGorda.Size = new System.Drawing.Size(114, 17);
            this.rbnJugadorBotaGorda.TabIndex = 3;
            this.rbnJugadorBotaGorda.Text = "JugadorBotaGorda";
            this.rbnJugadorBotaGorda.UseVisualStyleBackColor = true;
            this.rbnJugadorBotaGorda.CheckedChanged += new System.EventHandler(this.rbnJugadorBotaGorda_CheckedChanged);
            // 
            // rbnJugadorRandom
            // 
            this.rbnJugadorRandom.AutoSize = true;
            this.rbnJugadorRandom.BackColor = System.Drawing.SystemColors.Control;
            this.rbnJugadorRandom.Location = new System.Drawing.Point(27, 52);
            this.rbnJugadorRandom.Name = "rbnJugadorRandom";
            this.rbnJugadorRandom.Size = new System.Drawing.Size(103, 17);
            this.rbnJugadorRandom.TabIndex = 2;
            this.rbnJugadorRandom.Text = "JugadorRandom";
            this.rbnJugadorRandom.UseVisualStyleBackColor = false;
            this.rbnJugadorRandom.CheckedChanged += new System.EventHandler(this.rbnJugadorRandom_CheckedChanged);
            // 
            // rbnJugadorInteligente
            // 
            this.rbnJugadorInteligente.AutoSize = true;
            this.rbnJugadorInteligente.Location = new System.Drawing.Point(205, 75);
            this.rbnJugadorInteligente.Name = "rbnJugadorInteligente";
            this.rbnJugadorInteligente.Size = new System.Drawing.Size(112, 17);
            this.rbnJugadorInteligente.TabIndex = 0;
            this.rbnJugadorInteligente.Text = "JugadorInteligente";
            this.rbnJugadorInteligente.UseVisualStyleBackColor = true;
            this.rbnJugadorInteligente.CheckedChanged += new System.EventHandler(this.rbnJugadorInteligente_CheckedChanged);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 331);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(118, 23);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnSiguienteJugadoroSiguiente
            // 
            this.btnSiguienteJugadoroSiguiente.Location = new System.Drawing.Point(332, 331);
            this.btnSiguienteJugadoroSiguiente.Name = "btnSiguienteJugadoroSiguiente";
            this.btnSiguienteJugadoroSiguiente.Size = new System.Drawing.Size(104, 23);
            this.btnSiguienteJugadoroSiguiente.TabIndex = 5;
            this.btnSiguienteJugadoroSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguienteJugadoroSiguiente.Click += new System.EventHandler(this.btnSiguienteJugadoroSiguiente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // txtEquipo
            // 
            this.txtEquipo.Location = new System.Drawing.Point(372, 99);
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(30, 20);
            this.txtEquipo.TabIndex = 7;
            this.txtEquipo.TextChanged += new System.EventHandler(this.txtEquipo_TextChanged);
            // 
            // lblEquipo
            // 
            this.lblEquipo.AutoSize = true;
            this.lblEquipo.Location = new System.Drawing.Point(329, 102);
            this.lblEquipo.Name = "lblEquipo";
            this.lblEquipo.Size = new System.Drawing.Size(40, 13);
            this.lblEquipo.TabIndex = 8;
            this.lblEquipo.Text = "Equipo";
            // 
            // frmIntroducirJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 364);
            this.Controls.Add(this.lblEquipo);
            this.Controls.Add(this.txtEquipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSiguienteJugadoroSiguiente);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.grbTiposdeJugadores);
            this.Controls.Add(this.txtJugador1);
            this.Controls.Add(this.label1);
            this.Name = "frmIntroducirJugadores";
            this.Text = "Domino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIntroducirJugadores_FormClosing);
            this.Load += new System.EventHandler(this.frmIntroducirJugadores_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmIntroducirJugadores_Paint);
            this.grbTiposdeJugadores.ResumeLayout(false);
            this.grbTiposdeJugadores.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtJugador1;
        private System.Windows.Forms.GroupBox grbTiposdeJugadores;
        private System.Windows.Forms.RadioButton rbnJugadorComunista;
        private System.Windows.Forms.RadioButton rbnJugadorBotaGorda;
        private System.Windows.Forms.RadioButton rbnJugadorRandom;
        private System.Windows.Forms.RadioButton rbnJugadorInteligente;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnSiguienteJugadoroSiguiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.Label lblEquipo;
    }
}