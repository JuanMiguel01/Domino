using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication2
{

    public partial class FrmIntroducir : Form
    {
        FrmInicio inicio;
        ObjetoGlobal objeto;
        public FrmIntroducir(FrmInicio inicio, ObjetoGlobal objeto)
        {
            InitializeComponent();
            this.objeto = objeto;
            this.inicio = inicio;
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\3.jpg");

            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }




        private void FrmIntroducir_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void lblAtras_Click(object sender, EventArgs e)
        {

            inicio.Show();
            Hide();


        }

        private void lblSiguiente_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                lblProblema.Text = "Faltan campos por completar";
                IniciarReloj(lblProblema);
                return;
            }

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                lblProblema.Text = "Faltan campos por completar";
                IniciarReloj(lblProblema);
                return;
            }
            int numeroMayorEnFicha = Convert.ToInt32(textBox1.Text);
            int cantidadDeJugadores = Convert.ToInt32(textBox3.Text);
            int cantidadFichasMano = Convert.ToInt32(textBox2.Text);
            if (numeroMayorEnFicha >= 1000)
            {
                lblProblema.Text = "El numero mayor debe ser menor que 1000";
                IniciarReloj(lblProblema);
                return;
            }
            int cantFichas = (numeroMayorEnFicha + 1) * (numeroMayorEnFicha + 2) / 2;
            if (cantFichas < cantidadFichasMano * cantidadDeJugadores)
            {
                lblProblema.Text = "Debe cambiar los parámetros tiene " + cantFichas;
                label1.Text = " fichas disponibles y necesita mas de " + cantidadDeJugadores * cantidadFichasMano;
                IniciarReloj(lblProblema);
                IniciarReloj(label1);
                return;
            }
            if ((cantFichas - numeroMayorEnFicha + 1) < cantidadDeJugadores * cantidadFichasMano)
            {
                lblProblema.Text = "Debe cambiar los parámetros tiene " + (cantFichas - 13);
                label1.Text = " fichas disponiblesy necesita mas de " + cantidadDeJugadores * cantidadFichasMano;
                IniciarReloj(lblProblema);
                IniciarReloj(label1);
                return;
            }
            objeto.cantidadJugadores = cantidadDeJugadores;
            objeto.FichasPorMano = cantidadFichasMano;
            objeto.UltimNumero = numeroMayorEnFicha;
            frmSelectOptions options = new frmSelectOptions(this, objeto);
            options.Show();
            this.Hide();
        }
        private int numero;
        public int CantidadDeJugadores
        {
            get
            {
                return numero;
            }
            set
            {

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {


                string cantJugadores = textBox3.Text;

                numero = int.Parse(cantJugadores);


            }
            catch (System.Exception)
            {
                lblProblema.Text = "Esta intoduciendo valores invalidos";
                IniciarReloj(lblProblema);
                textBox3.Text = "";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string cantFichasPorMano = textBox2.Text;
                var numerofichas = int.Parse(cantFichasPorMano);

            }
            catch (System.Exception)
            {
                lblProblema.Text = "Esta intoduciendo valores invalidos";
                IniciarReloj(lblProblema);
                textBox2.Text = "";
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string NumeroMayor = textBox1.Text;
                var numeromayor = int.Parse(NumeroMayor);

            }
            catch (System.Exception)
            {
                lblProblema.Text = "Esta intoduciendo valores invalidos";
                IniciarReloj(lblProblema);
                textBox1.Text = "";
            }
        }
        public void IniciarReloj(Label label)
        {
            Timer timer1 = new Timer();
            timer1.Interval = 2500;
            timer1.Tick += (s, a) =>
            {
                ((Timer)s).Stop();
                label.Text = "";
            };
            timer1.Start();
        }
        private void FrmIntroducir_Load(object sender, EventArgs e)
        {
            textBox3.Text = "2";
            textBox1.Text = "10";
            textBox2.Text = "10";
        }


    }
}
