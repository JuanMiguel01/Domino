using System.Collections.Generic;
using System.Linq;
namespace Domino
{

    public class Juego
    {
        public List<JugadorBasico> jugadores;
        public Reglas reglas;
        public Mesa mesa;
        public int cantJugadores { get { return jugadores.Count; } }
        public List<JugadorBasico> ganadores = new List<JugadorBasico>();

        public Juego(List<JugadorBasico> jugadores, Reglas reglas)
        {
            this.jugadores = jugadores;
            this.reglas = reglas;
            Mesa mesa = new Mesa();
            this.mesa = mesa;
            var fichas = CreadorFichas.Crear(reglas.UltimNumero);
            Barajeador.Shuffle(fichas);
            mesa.FichasDisponibles = fichas;
            this.reglas.Repartir(this.jugadores, this.reglas.FichasPorMano, this.mesa);
            OnJugada += (o, a) => { };
        }

        public event JugadaHandler OnJugada;
        public delegate void JugadaHandler(object o, JugadaArgs args);
        public sealed class JugadaArgs : System.EventArgs { }

        public event TerminadoHandler OnTerminado;
        public delegate void TerminadoHandler(object o, TerminadoArgs args);
        public sealed class TerminadoArgs : System.EventArgs { }

        public void Jugar()
        {
            JugadorBasico next;

            while (true)
            {
                if (mesa.Sucesos.Count == 0)
                {
                    next = jugadores[reglas.SiguienteJugador(jugadores, new Ficha(1, 1))];
                }
                else
                {
                    next = jugadores[reglas.SiguienteJugador(jugadores, mesa.Sucesos.Last().ficha)];
                }

                if (next.Lleva(mesa, next.Mano, reglas))
                {
                    next.Jugar(mesa, reglas);
                  
                    mesa.Sucesos.Add( next.Jugadas.Last() );

                    mesa.ActualizarCaras(next.Jugadas.Last().ficha, reglas.validador,mesa.Sucesos.Last().jugoDerecha);

                    next.Mano.EliminaFicha(next.Jugadas.Last().ficha);

                }

                else
                {
                    mesa.Sucesos.Add(new Jugada(next, new Ficha(-1, -1)));

                    
                    System.Console.WriteLine(next.nombre + " se paso ");
                    
                }

                if (reglas.GameOver(mesa, this, next))
                    break;
                OnJugada(this, new JugadaArgs());

            }
            OnTerminado(this, new TerminadoArgs());

            
            

            this.ganadores = Juez.GetGanadores(jugadores, reglas);

        }
    }

}
