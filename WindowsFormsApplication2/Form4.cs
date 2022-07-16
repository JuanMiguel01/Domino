using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domino;
using System.Reflection;

namespace WindowsFormsApplication2
{
    public partial class frmIntroducirJugadores : Form
    {
        FrmIntroducir introducir;
        int jugadorDondeVa;
        frmSelectOptions options;
        ObjetoGlobal objeto;
        public frmIntroducirJugadores(frmSelectOptions options, FrmIntroducir introducir, int jugadorDondeVa, ObjetoGlobal objeto)
        {
            InitializeComponent();
            this.objeto = objeto;
            this.introducir = introducir;
            this.jugadorDondeVa = jugadorDondeVa;
            this.options = options;
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\3.jpg");

            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void rbnJugadorRandom_CheckedChanged(object sender, EventArgs e)
        {
            CompletarTxtJ(rbnJugadorRandom);
        }



        private void frmIntroducirJugadores_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }



        private void rbnJugadorBotaGorda_CheckedChanged(object sender, EventArgs e)
        {
            CompletarTxtJ(rbnJugadorBotaGorda);
        }

        private void rbnJugadorComunista_CheckedChanged(object sender, EventArgs e)
        {
            CompletarTxtJ(rbnJugadorComunista);
        }



        private void CompletarTxtJ(RadioButton button)
        {
            if (button.Checked == true)
            {
                txtJugador1.Text = button.Text + " " + Convert.ToString(jugadorDondeVa);
            }
        }

        private void rbnJugadorInteligente_CheckedChanged(object sender, EventArgs e)
        {
            CompletarTxtJ(rbnJugadorInteligente);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            objeto.jugadores = new Dictionary<string, Tuple<string, int>>();
            options.Show();
            Hide();

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
        public static object ConvertirStringATipo(string tipo, string arg1, int arg2)
        {
            var type = typeof(JugadorBasico).Assembly.GetType(tipo, true);

            if (type != null)
            {

                var types = new Type[] { typeof(string), typeof(int) };

                var ctor = type.GetConstructor(types);
                if (ctor != null)
                {

                    var param = new object[] { arg1, arg2 };
                    return ctor.Invoke(param);
                }
            }
            return null;
        }
        public static object ConvertirStringATipo(string tipo, int arg1, int arg2)
        {
            var type = typeof(JugadorBasico).Assembly.GetType("Domino." + tipo, true);

            if (type != null)
            {
                var types = new Type[] { typeof(int), typeof(int) };
                var ctor = type.GetConstructor(types);
                if (ctor != null)
                {
                    Console.WriteLine("tiene constructor");
                    var param = new object[] { arg1, arg2 };
                    return ctor.Invoke(param);
                }
            }
            return null;
        }
        public static object ConvertirStringATipo(string tipo)
        {
            var type = typeof(JugadorBasico).Assembly.GetType("Domino." + tipo, true);
            if (type != null)
            {
                var o = Activator.CreateInstance(type);
                return o;
            }
            return null;
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


        private void btnSiguienteJugadoroSiguiente_Click(object sender, EventArgs e)
        {
            if (txtEquipo.Text == "")
            {
                label2.Text = "Elija un equipo";
                IniciarReloj(label2);
                return;
            }
            if (txtJugador1.Text == "")
            {
                label2.Text = "Elija un tipo de jugador";
                IniciarReloj(label2);
                return;
            }
            if (introducir.CantidadDeJugadores <= jugadorDondeVa)
            {
                foreach (var jugador in objeto.jugadores)
                {
                    if (jugador.Key == txtJugador1.Text)
                    {
                        label2.Text = "Ya tiene un jugador con ese nombre ";
                        IniciarReloj(label2);
                        return;
                    }
                }
                objeto.jugadores.Add(txtJugador1.Text, Tuple.Create(AsignarPropiedades(grbTiposdeJugadores), int.Parse(txtEquipo.Text)));

                int cantJugadores = objeto.cantidadJugadores;

                int FichasPorMano = objeto.FichasPorMano;

                int UltimNumero = objeto.UltimNumero;

                //seleccion de jugadores

                List<JugadorBasico> jugadores = new List<JugadorBasico>();

                foreach (var element in objeto.jugadores)
                {

                    JugadorBasico jugador = (JugadorBasico)ConvertirStringATipo("Domino." + element.Value.Item1, element.Key, element.Value.Item2);


                    jugadores.Add(jugador);
                }


                //reglas de seleccionar x botones

                var finalizador = (IFinalizador)ConvertirStringATipo("GameOver_" + objeto.CondicionFinalizacion);

                var validador = (IValidador)ConvertirStringATipo("Validador_" + objeto.Validador);
                validador.ParametroValidacion = objeto.ParametroValidacion;

                var siguienteJugador = (ISiguienteJugador)ConvertirStringATipo("SiguienteJugador_" + objeto.SiguienteJugador, 0, cantJugadores);

                var calculador = (ICalculador)ConvertirStringATipo("CalculaPuntos_" + objeto.CalcularPuntos);

                var repartidor = (IRepartidor)ConvertirStringATipo("Repartidor_" + objeto.Repartidor); ;

                var calculadorScore = (ICalculadorScore)ConvertirStringATipo("CalcularScore_" + objeto.CalcularScore);


                var reglas = new Reglas(finalizador, validador, siguienteJugador, calculador, repartidor, calculadorScore, FichasPorMano, UltimNumero);

                frmJuego pantallaJuego = new frmJuego(objeto, jugadores, reglas);
                pantallaJuego.Show();
                this.Hide();
            }
            else
            {
                objeto.jugadores.Add(txtJugador1.Text, Tuple.Create(AsignarPropiedades(grbTiposdeJugadores), int.Parse(txtEquipo.Text)));

                frmIntroducirJugadores nueva = new frmIntroducirJugadores(options, introducir, jugadorDondeVa + 1, objeto);
                nueva.Show();
                this.Hide();
            }

        }



        private void frmIntroducirJugadores_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fuente = new Font("Times New Roman", 15);
            g.DrawString("Personaliza a tus jugadores", fuente, Brushes.Black, 115, 76);
        }

        private void frmIntroducirJugadores_Load(object sender, EventArgs e)
        {
            label1.Text = "Jugador " + jugadorDondeVa;
            if (jugadorDondeVa >= introducir.CantidadDeJugadores) btnSiguienteJugadoroSiguiente.Text = "Iniciar prtida";
            else { btnSiguienteJugadoroSiguiente.Text = "Siguiente Jugador"; }
            txtEquipo.Text = "1";
            rbnJugadorBotaGorda.Checked = true;
        }

        private void txtEquipo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string Equipo = txtEquipo.Text;
                var numeromayor = int.Parse(Equipo);

            }
            catch (System.Exception)
            {
                label2.Text = "Esta intoduciendo valores invalidos";
                IniciarReloj(label2);
                txtEquipo.Text = "";
            }
        }
    }
}
