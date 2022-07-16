using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Domino;
namespace WindowsFormsApplication2
{
    public partial class frmJuego : Form
    {
        long locker = 0;
        Juego juego;
        public frmJuego(ObjetoGlobal objeto, List<JugadorBasico> jugadores, Reglas reglas)
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\img\1.jpg");

            this.BackgroundImage = img;
            this.BackgroundImageLayout = ImageLayout.Stretch;


            var juego = new Juego(jugadores, reglas);


            juego.OnJugada += (o, a) =>
            {
                Interlocked.Increment(ref locker);
                SpinWait.SpinUntil(() => Interlocked.Read(ref locker) == 0);
            };
            juego.OnTerminado += (o, a) =>
            {

                btnSigJugada.Enabled = false;


                this.Execute(Close, 1000);

            };
            this.juego = juego;
            (new Task(() => { juego.Jugar(); })).Start();

        }

        private void frmJuego_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInicio inicio = new FrmInicio();
            this.Hide();
            inicio.Show();
        }

        private int x = 600;
        private int y = 400;
        private int izX = 495;
        private int izY = 400;

        private int countYDerecha = 4;
        private int countYIzquierda = 4;
        bool flagDerecha = true;
        bool flagIzquierda = true;

        private void button1_Click(object sender, EventArgs e)
        {
            Interlocked.Decrement(ref locker);

            Graphics g = Graphics.FromHwnd(this.Handle);

            Font fuente = new Font("Times New Roman", 15);

            FichaImagen derecha = new FichaImagen(x, y, juego.mesa.Salida);
            FichaImagen izquierda = new FichaImagen(izX, izY, juego.mesa.Salida);

            Console.WriteLine(150 + countYDerecha * 30 + "   " + (150 + countYIzquierda * 30));

            Jugada ultJugada = juego.mesa.Sucesos.Last();
            if (ultJugada.jugoDerecha)
            {
                if (150 + countYDerecha * 30 > 550)
                {

                    x = 600;
                    y = 400;
                    izX = 495;
                    izY = 400;
                    Invalidate(); izquierda.x = izX; izquierda.y = izY; derecha.x = x; derecha.y = y;
                    countYDerecha = 5;
                    countYIzquierda = 4;
                    flagDerecha = true;
                    flagIzquierda = true;
                }

                if (derecha.x > 1000) { flagDerecha = false; countYDerecha++; }
                if (derecha.x < 100) { flagDerecha = true; countYDerecha++; }
            }
            else
            {
                if ((150 + countYIzquierda * 30) < 50)
                {
                    x = 600;
                    y = 400;
                    izX = 495;
                    izY = 400;
                    Invalidate(); izquierda.x = izX; izquierda.y = izY; derecha.x = x; derecha.y = y;
                    countYDerecha = 5;
                    countYIzquierda = 4;
                    flagDerecha = true;
                    flagIzquierda = true;
                }
                if (izquierda.x > 1000) { flagIzquierda = true; countYIzquierda--; }
                if (izquierda.x < 100) { flagIzquierda = false; countYIzquierda--; }
            }

            if (ultJugada.ficha.First == -1)
            {
                FichaImagen img = new FichaImagen(derecha.x, 150 + countYDerecha * 30, ultJugada.ficha);
                img.Informacion(ultJugada, juego.mesa, g);
            }
            if (ultJugada.ficha.First != -1)
            {
                if (ultJugada.jugoDerecha && flagDerecha == true)
                {
                    x += 105;

                    if (juego.reglas.EsValida(ultJugada.ficha.Second, juego.mesa.carasDisponibles[1]))
                    {
                        FichaImagen img = new FichaImagen(derecha.x, 150 + countYDerecha * 30, ultJugada.ficha);

                        img.DibujarHorizontal(g);
                        img.Informacion(ultJugada, juego.mesa, g);
                        derecha = img;
                    }

                    else
                    {
                        FichaImagen img = new FichaImagen(derecha.x, 150 + countYDerecha * 30, new Ficha(ultJugada.ficha.Second, ultJugada.ficha.First));

                        img.DibujarHorizontal(g);
                        img.Informacion(ultJugada, juego.mesa, g);
                        derecha = img;
                    }




                }
                else if (ultJugada.jugoDerecha && flagDerecha == false)
                {
                    x -= 105;

                    if (juego.reglas.EsValida(ultJugada.ficha.First, juego.mesa.carasDisponibles[1]))
                    {
                        FichaImagen img = new FichaImagen(derecha.x, 150 + countYDerecha * 30, ultJugada.ficha);

                        img.DibujarHorizontal(g);
                        img.Informacion(ultJugada, juego.mesa, g);
                        derecha = img;
                    }

                    else
                    {
                        FichaImagen img = new FichaImagen(derecha.x, 150 + countYDerecha * 30, new Ficha(ultJugada.ficha.Second, ultJugada.ficha.First));

                        img.DibujarHorizontal(g);
                        img.Informacion(ultJugada, juego.mesa, g);
                        derecha = img;
                    }

                }
                else if (!ultJugada.jugoDerecha && flagIzquierda == false)
                {

                    izX += 105;

                    if (juego.reglas.EsValida(ultJugada.ficha.Second, juego.mesa.carasDisponibles[0]))
                    {
                        FichaImagen img = new FichaImagen(izquierda.x, 150 + countYIzquierda * 30, ultJugada.ficha);

                        img.DibujarHorizontal(g);
                        img.Informacion(ultJugada, juego.mesa, g);
                        derecha = img;
                    }

                    else
                    {
                        FichaImagen img = new FichaImagen(izquierda.x, 150 + countYIzquierda * 30, new Ficha(ultJugada.ficha.Second, ultJugada.ficha.First));

                        img.DibujarHorizontal(g);
                        img.Informacion(ultJugada, juego.mesa, g);
                        derecha = img;
                    }
                }
                else if (!ultJugada.jugoDerecha && flagIzquierda == true)
                {

                    izX -= 105;

                    if (juego.reglas.EsValida(ultJugada.ficha.First, juego.mesa.carasDisponibles[0]))
                    {
                        FichaImagen img = new FichaImagen(izquierda.x, 150 + countYIzquierda * 30, ultJugada.ficha);

                        img.DibujarHorizontal(g);
                        img.Informacion(ultJugada, juego.mesa, g);
                        derecha = img;
                    }

                    else
                    {
                        FichaImagen img = new FichaImagen(izquierda.x, 150 + countYIzquierda * 30, new Ficha(ultJugada.ficha.Second, ultJugada.ficha.First));

                        img.DibujarHorizontal(g);
                        img.Informacion(ultJugada, juego.mesa, g);
                        derecha = img;
                    }
                }

            }

            if (juego.mesa.Sucesos.Last() == null)
            {
                return;
            }

            if (juego.mesa.Sucesos.Last().ficha.First == -1)
            {
                return;
            }



            g.Dispose();

        }

        private void frmJuego_Paint(object sender, PaintEventArgs e)
        {
        }
        public async Task Execute(Action action, int timeout)
        {
            await Task.Delay(timeout);
            action();
        }
    }

    public class FichaImagen
    {
        public int x { get; set; }
        public int y { get; set; }
        public Ficha ficha;
        public FichaImagen(int x, int y, Ficha ficha)
        {
            this.x = x;
            this.y = y;
            this.ficha = ficha;

        }



        public void Informacion(Jugada jugada, Mesa mesa, Graphics g)
        {
            if (mesa.Sucesos.Count > 1 && jugada.ficha.First == -1)
            {
                g.FillRectangle(Brushes.Cyan, new Rectangle(0, 0, 400, 60));
                g.DrawRectangle(Pens.Cyan, new Rectangle(0, 0, 400, 60));
                Font fuente = new Font("Time new Roman", 15);
                g.DrawString(jugada.jugador + " se pasó ", fuente, Brushes.Black, 60, 30);
            }
            if (mesa.Sucesos.Count > 1 && jugada.ficha.First != -1)
            {
                g.FillRectangle(Brushes.Aquamarine, new Rectangle(0, 0, 400, 60));
                g.DrawRectangle(Pens.Aquamarine, new Rectangle(0, 0, 400, 60));
                Font fuente = new Font("Time new Roman", 15);
                g.DrawString(jugada.jugador + " jugó el " + jugada.ficha, fuente, Brushes.Black, 60, 30);
            }
        }
        public void DibujarHorizontal(Graphics g)
        {
            Font fuente = new Font("Time new Roman", 15);

            g.FillRectangle(Brushes.Honeydew, new Rectangle(x, y, 50, 25));
            g.DrawRectangle(Pens.Black, new Rectangle(x, y, 50, 25));

            g.FillRectangle(Brushes.Honeydew, new Rectangle(x + 50, y, 50, 25));
            g.DrawRectangle(Pens.Black, new Rectangle(x + 50, y, 50, 25));

            g.DrawString(ficha.First.ToString(), fuente, Brushes.Black, x + 15, y);
            g.DrawString(ficha.Second.ToString(), fuente, Brushes.Black, x + 65, y);

        }
    }
}
