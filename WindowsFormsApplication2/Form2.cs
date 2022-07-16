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
    public partial class frmSelectOptions : Form
    {
        ObjetoGlobal objeto;
        FrmIntroducir introducir;
        public frmSelectOptions(FrmIntroducir introducir, ObjetoGlobal objeto)
        {
            InitializeComponent();
            this.objeto = objeto;
            this.introducir = introducir;
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\3.jpg");

            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }



        private void btnAtras_Click(object sender, EventArgs e)
        {
            introducir.Show();
            Hide();

        }
        public void IniciarReloj(Label label)
        {
            Timer timer1 = new Timer();
            timer1.Interval = 1500;
            timer1.Tick += (s, a) =>
            {
                ((Timer)s).Stop();
                label.Text = "";
            };
            timer1.Start();
        }
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (txtMultiplicapor.Enabled && txtMultiplicapor.Text == "")
            {
                lblProblema.Text = "Faltan Campos por completar";
                IniciarReloj(lblProblema);
                return;
            }
            frmIntroducirJugadores introducirJugadores = new frmIntroducirJugadores(this, introducir, 1, objeto);
            objeto.CalcularPuntos = AsignarPropiedades(grbCalculadorPuntos);
            objeto.CondicionFinalizacion = AsignarPropiedades(grbCondicionFinalizacion);
            objeto.Validador = AsignarPropiedades(grbValidador);
            objeto.Repartidor = AsignarPropiedades(grbRepartidor);
            objeto.SiguienteJugador = AsignarPropiedades(grbSiguienteJugador);

            objeto.CalcularScore = AsignarPropiedades(grbCalcularScore);

            if (txtMultiplicapor.Text != "")
            {
                objeto.ParametroValidacion = int.Parse(txtMultiplicapor.Text);
            }
            else
            {
                objeto.ParametroValidacion = 0;
            }

            introducirJugadores.Show();
            this.Hide();

        }
        public string AsignarPropiedades(GroupBox grb)
        {
            string asignar = "";
            foreach (RadioButton rdo in grb.Controls.OfType<RadioButton>())
            {
                if (rdo.Checked)
                {
                    asignar = rdo.Text;
                }
            }
            return asignar;
        }
        private void frmSelectOptions_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        

        private void rbnValidadorMultiplicarPor5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnValidadorMultiplicarPor5.Checked == true)
            {


                txtMultiplicapor.Enabled = true;
                lbltextoMultipli.Text = "Multiplicar por:";

            }
            if (rbnValidadorMultiplicarPor5.Checked == false)
            {
                txtMultiplicapor.Enabled = false;
                lbltextoMultipli.Text = "";
            }
        }

        private void txtMultiplicapor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string multiplicarpor = txtMultiplicapor.Text;
                var numeromayor = int.Parse(multiplicarpor);

            }
            catch (System.Exception)
            {
                lblProblema.Text = "Esta intoduciendo valores invalidos";
                IniciarReloj(lblProblema);
                txtMultiplicapor.Text = "";
            }
        }

        private void rbnValidadorParidad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnValidadorParidad.Checked == true)
            {


                txtMultiplicapor.Enabled = true;
                lbltextoMultipli.Text = "Mismo resto con:";

            }
            if (rbnValidadorParidad.Checked == false)
            {
                txtMultiplicapor.Enabled = false;
                lbltextoMultipli.Text = "";
            }
        }
    }
}
