namespace WindowsFormsApplication2
{
    partial class frmSelectOptions
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
            this.lblMensaje = new System.Windows.Forms.Label();
            this.grbCondicionFinalizacion = new System.Windows.Forms.GroupBox();
            this.rbnFinalizadorBalanceado = new System.Windows.Forms.RadioButton();
            this.rbnFinalizadorDobleBlanco = new System.Windows.Forms.RadioButton();
            this.rbnFinalizacionUsual = new System.Windows.Forms.RadioButton();
            this.grbRepartidor = new System.Windows.Forms.GroupBox();
            this.rbnRepartidorSinDobles = new System.Windows.Forms.RadioButton();
            this.rbnRepartidor5Dobles = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.grbSiguienteJugador = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.rbnSiguienteJugadorUsual = new System.Windows.Forms.RadioButton();
            this.grbCalculadorPuntos = new System.Windows.Forms.GroupBox();
            this.rbnCalculadorPuntosPorPases = new System.Windows.Forms.RadioButton();
            this.rbnCalcularPuntosX2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.grbValidador = new System.Windows.Forms.GroupBox();
            this.rbnValidadorMultiplicarPor5 = new System.Windows.Forms.RadioButton();
            this.rbnValidadorParidad = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.grbCalcularScore = new System.Windows.Forms.GroupBox();
            this.rbnCalcularScoreDiferenciaModular = new System.Windows.Forms.RadioButton();
            this.rbnCalcularScoreMultiplicar = new System.Windows.Forms.RadioButton();
            this.rbnCalcularScore = new System.Windows.Forms.RadioButton();
            this.txtMultiplicapor = new System.Windows.Forms.TextBox();
            this.lbltextoMultipli = new System.Windows.Forms.Label();
            this.lblProblema = new System.Windows.Forms.Label();
            this.grbCondicionFinalizacion.SuspendLayout();
            this.grbRepartidor.SuspendLayout();
            this.grbSiguienteJugador.SuspendLayout();
            this.grbCalculadorPuntos.SuspendLayout();
            this.grbValidador.SuspendLayout();
            this.grbCalcularScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(202, 33);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(90, 13);
            this.lblMensaje.TabIndex = 0;
            this.lblMensaje.Text = "Escoge las reglas";
            // 
            // grbCondicionFinalizacion
            // 
            this.grbCondicionFinalizacion.Controls.Add(this.rbnFinalizadorBalanceado);
            this.grbCondicionFinalizacion.Controls.Add(this.rbnFinalizadorDobleBlanco);
            this.grbCondicionFinalizacion.Controls.Add(this.rbnFinalizacionUsual);
            this.grbCondicionFinalizacion.Location = new System.Drawing.Point(29, 91);
            this.grbCondicionFinalizacion.Name = "grbCondicionFinalizacion";
            this.grbCondicionFinalizacion.Size = new System.Drawing.Size(200, 100);
            this.grbCondicionFinalizacion.TabIndex = 1;
            this.grbCondicionFinalizacion.TabStop = false;
            this.grbCondicionFinalizacion.Text = "Condicion de finalizacion";
            // 
            // rbnFinalizadorBalanceado
            // 
            this.rbnFinalizadorBalanceado.AutoSize = true;
            this.rbnFinalizadorBalanceado.Location = new System.Drawing.Point(3, 62);
            this.rbnFinalizadorBalanceado.Name = "rbnFinalizadorBalanceado";
            this.rbnFinalizadorBalanceado.Size = new System.Drawing.Size(82, 17);
            this.rbnFinalizadorBalanceado.TabIndex = 2;
            this.rbnFinalizadorBalanceado.TabStop = true;
            this.rbnFinalizadorBalanceado.Text = "Balanceado";
            this.rbnFinalizadorBalanceado.UseVisualStyleBackColor = true;
            // 
            // rbnFinalizadorDobleBlanco
            // 
            this.rbnFinalizadorDobleBlanco.AutoSize = true;
            this.rbnFinalizadorDobleBlanco.Location = new System.Drawing.Point(3, 39);
            this.rbnFinalizadorDobleBlanco.Name = "rbnFinalizadorDobleBlanco";
            this.rbnFinalizadorDobleBlanco.Size = new System.Drawing.Size(92, 17);
            this.rbnFinalizadorDobleBlanco.TabIndex = 3;
            this.rbnFinalizadorDobleBlanco.TabStop = true;
            this.rbnFinalizadorDobleBlanco.Text = "Doble_Blanco";
            this.rbnFinalizadorDobleBlanco.UseVisualStyleBackColor = true;
            // 
            // rbnFinalizacionUsual
            // 
            this.rbnFinalizacionUsual.AutoSize = true;
            this.rbnFinalizacionUsual.Checked = true;
            this.rbnFinalizacionUsual.Location = new System.Drawing.Point(3, 16);
            this.rbnFinalizacionUsual.Name = "rbnFinalizacionUsual";
            this.rbnFinalizacionUsual.Size = new System.Drawing.Size(52, 17);
            this.rbnFinalizacionUsual.TabIndex = 0;
            this.rbnFinalizacionUsual.TabStop = true;
            this.rbnFinalizacionUsual.Text = "Usual";
            this.rbnFinalizacionUsual.UseVisualStyleBackColor = true;
            // 
            // grbRepartidor
            // 
            this.grbRepartidor.Controls.Add(this.rbnRepartidorSinDobles);
            this.grbRepartidor.Controls.Add(this.rbnRepartidor5Dobles);
            this.grbRepartidor.Controls.Add(this.radioButton1);
            this.grbRepartidor.Location = new System.Drawing.Point(261, 217);
            this.grbRepartidor.Name = "grbRepartidor";
            this.grbRepartidor.Size = new System.Drawing.Size(200, 100);
            this.grbRepartidor.TabIndex = 2;
            this.grbRepartidor.TabStop = false;
            this.grbRepartidor.Text = "Repartidor";
            // 
            // rbnRepartidorSinDobles
            // 
            this.rbnRepartidorSinDobles.AutoSize = true;
            this.rbnRepartidorSinDobles.Location = new System.Drawing.Point(0, 62);
            this.rbnRepartidorSinDobles.Name = "rbnRepartidorSinDobles";
            this.rbnRepartidorSinDobles.Size = new System.Drawing.Size(73, 17);
            this.rbnRepartidorSinDobles.TabIndex = 6;
            this.rbnRepartidorSinDobles.TabStop = true;
            this.rbnRepartidorSinDobles.Text = "SinDobles";
            this.rbnRepartidorSinDobles.UseVisualStyleBackColor = true;
            // 
            // rbnRepartidor5Dobles
            // 
            this.rbnRepartidor5Dobles.AutoSize = true;
            this.rbnRepartidor5Dobles.Location = new System.Drawing.Point(0, 39);
            this.rbnRepartidor5Dobles.Name = "rbnRepartidor5Dobles";
            this.rbnRepartidor5Dobles.Size = new System.Drawing.Size(64, 17);
            this.rbnRepartidor5Dobles.TabIndex = 7;
            this.rbnRepartidor5Dobles.TabStop = true;
            this.rbnRepartidor5Dobles.Text = "5Dobles";
            this.rbnRepartidor5Dobles.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Usual";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // grbSiguienteJugador
            // 
            this.grbSiguienteJugador.Controls.Add(this.radioButton5);
            this.grbSiguienteJugador.Controls.Add(this.rbnSiguienteJugadorUsual);
            this.grbSiguienteJugador.Location = new System.Drawing.Point(32, 217);
            this.grbSiguienteJugador.Name = "grbSiguienteJugador";
            this.grbSiguienteJugador.Size = new System.Drawing.Size(200, 100);
            this.grbSiguienteJugador.TabIndex = 2;
            this.grbSiguienteJugador.TabStop = false;
            this.grbSiguienteJugador.Text = "Siguiente Jugador";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(3, 40);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(89, 17);
            this.radioButton5.TabIndex = 1;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "InvierteOrden";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // rbnSiguienteJugadorUsual
            // 
            this.rbnSiguienteJugadorUsual.AutoSize = true;
            this.rbnSiguienteJugadorUsual.Checked = true;
            this.rbnSiguienteJugadorUsual.Location = new System.Drawing.Point(3, 16);
            this.rbnSiguienteJugadorUsual.Name = "rbnSiguienteJugadorUsual";
            this.rbnSiguienteJugadorUsual.Size = new System.Drawing.Size(52, 17);
            this.rbnSiguienteJugadorUsual.TabIndex = 0;
            this.rbnSiguienteJugadorUsual.TabStop = true;
            this.rbnSiguienteJugadorUsual.Text = "Usual";
            this.rbnSiguienteJugadorUsual.UseVisualStyleBackColor = true;
            // 
            // grbCalculadorPuntos
            // 
            this.grbCalculadorPuntos.Controls.Add(this.rbnCalculadorPuntosPorPases);
            this.grbCalculadorPuntos.Controls.Add(this.rbnCalcularPuntosX2);
            this.grbCalculadorPuntos.Controls.Add(this.radioButton3);
            this.grbCalculadorPuntos.Location = new System.Drawing.Point(494, 91);
            this.grbCalculadorPuntos.Name = "grbCalculadorPuntos";
            this.grbCalculadorPuntos.Size = new System.Drawing.Size(200, 100);
            this.grbCalculadorPuntos.TabIndex = 2;
            this.grbCalculadorPuntos.TabStop = false;
            this.grbCalculadorPuntos.Text = "Calculador de Puntuación";
            // 
            // rbnCalculadorPuntosPorPases
            // 
            this.rbnCalculadorPuntosPorPases.AutoSize = true;
            this.rbnCalculadorPuntosPorPases.Location = new System.Drawing.Point(6, 62);
            this.rbnCalculadorPuntosPorPases.Name = "rbnCalculadorPuntosPorPases";
            this.rbnCalculadorPuntosPorPases.Size = new System.Drawing.Size(54, 17);
            this.rbnCalculadorPuntosPorPases.TabIndex = 1;
            this.rbnCalculadorPuntosPorPases.TabStop = true;
            this.rbnCalculadorPuntosPorPases.Text = "Pases";
            this.rbnCalculadorPuntosPorPases.UseVisualStyleBackColor = true;
            // 
            // rbnCalcularPuntosX2
            // 
            this.rbnCalcularPuntosX2.AutoSize = true;
            this.rbnCalcularPuntosX2.Location = new System.Drawing.Point(6, 39);
            this.rbnCalcularPuntosX2.Name = "rbnCalcularPuntosX2";
            this.rbnCalcularPuntosX2.Size = new System.Drawing.Size(38, 17);
            this.rbnCalcularPuntosX2.TabIndex = 2;
            this.rbnCalcularPuntosX2.TabStop = true;
            this.rbnCalcularPuntosX2.Text = "X2";
            this.rbnCalcularPuntosX2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 16);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(52, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Usual";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // grbValidador
            // 
            this.grbValidador.Controls.Add(this.rbnValidadorMultiplicarPor5);
            this.grbValidador.Controls.Add(this.rbnValidadorParidad);
            this.grbValidador.Controls.Add(this.radioButton4);
            this.grbValidador.Location = new System.Drawing.Point(261, 91);
            this.grbValidador.Name = "grbValidador";
            this.grbValidador.Size = new System.Drawing.Size(200, 100);
            this.grbValidador.TabIndex = 2;
            this.grbValidador.TabStop = false;
            this.grbValidador.Text = "Validador de Jugada";
           
            
            // 
            // rbnValidadorMultiplicarPor5
            // 
            this.rbnValidadorMultiplicarPor5.AutoSize = true;
            this.rbnValidadorMultiplicarPor5.Location = new System.Drawing.Point(3, 62);
            this.rbnValidadorMultiplicarPor5.Name = "rbnValidadorMultiplicarPor5";
            this.rbnValidadorMultiplicarPor5.Size = new System.Drawing.Size(45, 17);
            this.rbnValidadorMultiplicarPor5.TabIndex = 6;
            this.rbnValidadorMultiplicarPor5.TabStop = true;
            this.rbnValidadorMultiplicarPor5.Text = "Mult";
            this.rbnValidadorMultiplicarPor5.UseVisualStyleBackColor = true;
            this.rbnValidadorMultiplicarPor5.CheckedChanged += new System.EventHandler(this.rbnValidadorMultiplicarPor5_CheckedChanged);
            // 
            // rbnValidadorParidad
            // 
            this.rbnValidadorParidad.AutoSize = true;
            this.rbnValidadorParidad.Location = new System.Drawing.Point(3, 39);
            this.rbnValidadorParidad.Name = "rbnValidadorParidad";
            this.rbnValidadorParidad.Size = new System.Drawing.Size(61, 17);
            this.rbnValidadorParidad.TabIndex = 5;
            this.rbnValidadorParidad.TabStop = true;
            this.rbnValidadorParidad.Text = "Paridad";
            this.rbnValidadorParidad.UseVisualStyleBackColor = true;
            this.rbnValidadorParidad.CheckedChanged += new System.EventHandler(this.rbnValidadorParidad_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Checked = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 16);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(52, 17);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Usual";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(644, 419);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(75, 23);
            this.btnSiguiente.TabIndex = 3;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(12, 419);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 4;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // grbCalcularScore
            // 
            this.grbCalcularScore.BackColor = System.Drawing.SystemColors.Control;
            this.grbCalcularScore.Controls.Add(this.rbnCalcularScoreDiferenciaModular);
            this.grbCalcularScore.Controls.Add(this.rbnCalcularScoreMultiplicar);
            this.grbCalcularScore.Controls.Add(this.rbnCalcularScore);
            this.grbCalcularScore.Location = new System.Drawing.Point(494, 217);
            this.grbCalcularScore.Name = "grbCalcularScore";
            this.grbCalcularScore.Size = new System.Drawing.Size(200, 100);
            this.grbCalcularScore.TabIndex = 2;
            this.grbCalcularScore.TabStop = false;
            this.grbCalcularScore.Text = "Calcular Score";
            // 
            // rbnCalcularScoreDiferenciaModular
            // 
            this.rbnCalcularScoreDiferenciaModular.AutoSize = true;
            this.rbnCalcularScoreDiferenciaModular.Location = new System.Drawing.Point(0, 62);
            this.rbnCalcularScoreDiferenciaModular.Name = "rbnCalcularScoreDiferenciaModular";
            this.rbnCalcularScoreDiferenciaModular.Size = new System.Drawing.Size(111, 17);
            this.rbnCalcularScoreDiferenciaModular.TabIndex = 8;
            this.rbnCalcularScoreDiferenciaModular.TabStop = true;
            this.rbnCalcularScoreDiferenciaModular.Text = "DiferenciaModular";
            this.rbnCalcularScoreDiferenciaModular.UseVisualStyleBackColor = true;
            // 
            // rbnCalcularScoreMultiplicar
            // 
            this.rbnCalcularScoreMultiplicar.AutoSize = true;
            this.rbnCalcularScoreMultiplicar.Location = new System.Drawing.Point(0, 39);
            this.rbnCalcularScoreMultiplicar.Name = "rbnCalcularScoreMultiplicar";
            this.rbnCalcularScoreMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.rbnCalcularScoreMultiplicar.TabIndex = 9;
            this.rbnCalcularScoreMultiplicar.TabStop = true;
            this.rbnCalcularScoreMultiplicar.Text = "Multiplicar";
            this.rbnCalcularScoreMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rbnCalcularScore
            // 
            this.rbnCalcularScore.AutoSize = true;
            this.rbnCalcularScore.Checked = true;
            this.rbnCalcularScore.Location = new System.Drawing.Point(3, 16);
            this.rbnCalcularScore.Name = "rbnCalcularScore";
            this.rbnCalcularScore.Size = new System.Drawing.Size(52, 17);
            this.rbnCalcularScore.TabIndex = 0;
            this.rbnCalcularScore.TabStop = true;
            this.rbnCalcularScore.Text = "Usual";
            this.rbnCalcularScore.UseVisualStyleBackColor = true;
            // 
            // txtMultiplicapor
            // 
            this.txtMultiplicapor.Enabled = false;
            this.txtMultiplicapor.Location = new System.Drawing.Point(361, 65);
            this.txtMultiplicapor.Name = "txtMultiplicapor";
            this.txtMultiplicapor.Size = new System.Drawing.Size(100, 20);
            this.txtMultiplicapor.TabIndex = 7;
            this.txtMultiplicapor.TextChanged += new System.EventHandler(this.txtMultiplicapor_TextChanged);
            // 
            // lbltextoMultipli
            // 
            this.lbltextoMultipli.AutoSize = true;
            this.lbltextoMultipli.Location = new System.Drawing.Point(278, 68);
            this.lbltextoMultipli.Name = "lbltextoMultipli";
            this.lbltextoMultipli.Size = new System.Drawing.Size(0, 13);
            this.lbltextoMultipli.TabIndex = 8;
            // 
            // lblProblema
            // 
            this.lblProblema.AutoSize = true;
            this.lblProblema.Location = new System.Drawing.Point(570, 352);
            this.lblProblema.Name = "lblProblema";
            this.lblProblema.Size = new System.Drawing.Size(0, 13);
            this.lblProblema.TabIndex = 9;
            // 
            // frmSelectOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 455);
            this.Controls.Add(this.lblProblema);
            this.Controls.Add(this.lbltextoMultipli);
            this.Controls.Add(this.txtMultiplicapor);
            this.Controls.Add(this.grbCalcularScore);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.grbSiguienteJugador);
            this.Controls.Add(this.grbCalculadorPuntos);
            this.Controls.Add(this.grbValidador);
            this.Controls.Add(this.grbRepartidor);
            this.Controls.Add(this.grbCondicionFinalizacion);
            this.Controls.Add(this.lblMensaje);
            this.Name = "frmSelectOptions";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSelectOptions_FormClosing);
            this.grbCondicionFinalizacion.ResumeLayout(false);
            this.grbCondicionFinalizacion.PerformLayout();
            this.grbRepartidor.ResumeLayout(false);
            this.grbRepartidor.PerformLayout();
            this.grbSiguienteJugador.ResumeLayout(false);
            this.grbSiguienteJugador.PerformLayout();
            this.grbCalculadorPuntos.ResumeLayout(false);
            this.grbCalculadorPuntos.PerformLayout();
            this.grbValidador.ResumeLayout(false);
            this.grbValidador.PerformLayout();
            this.grbCalcularScore.ResumeLayout(false);
            this.grbCalcularScore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.GroupBox grbCondicionFinalizacion;
        private System.Windows.Forms.RadioButton rbnFinalizacionUsual;
        private System.Windows.Forms.GroupBox grbRepartidor;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox grbSiguienteJugador;
        private System.Windows.Forms.RadioButton rbnSiguienteJugadorUsual;
        private System.Windows.Forms.GroupBox grbCalculadorPuntos;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox grbValidador;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton rbnCalculadorPuntosPorPases;
        private System.Windows.Forms.RadioButton rbnCalcularPuntosX2;
        private System.Windows.Forms.GroupBox grbCalcularScore;
        private System.Windows.Forms.RadioButton rbnCalcularScore;
        private System.Windows.Forms.RadioButton rbnValidadorParidad;
        private System.Windows.Forms.RadioButton rbnCalcularScoreMultiplicar;
        private System.Windows.Forms.RadioButton rbnRepartidorSinDobles;
        private System.Windows.Forms.RadioButton rbnRepartidor5Dobles;
        private System.Windows.Forms.RadioButton rbnCalcularScoreDiferenciaModular;
        private System.Windows.Forms.RadioButton rbnValidadorMultiplicarPor5;
        private System.Windows.Forms.RadioButton rbnFinalizadorBalanceado;
        private System.Windows.Forms.RadioButton rbnFinalizadorDobleBlanco;
        private System.Windows.Forms.TextBox txtMultiplicapor;
        private System.Windows.Forms.Label lbltextoMultipli;
        private System.Windows.Forms.Label lblProblema;
    }
}