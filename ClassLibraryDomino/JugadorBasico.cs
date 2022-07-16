using System.Collections.Generic;
namespace Domino
{
    public abstract class JugadorBasico
    {
        public Mano Mano;
        string Nombre;
        public string nombre { get { return Nombre; } }
        public List<Jugada> Jugadas;
        public int numEquipo;
        public JugadorBasico(string nombre, int numEquipo)
        {
            this.Nombre = nombre;
            this.numEquipo = numEquipo;
            this.Jugadas = new List<Jugada>();
        }
        public bool pegado { get { return Mano.cantFichas == 0; } }
        public int cantPases { get { return ContadorPases; } }
        public int cantPuntos { get; set; }

        public override string ToString()
        {
            return this.Nombre;
        }

        int ContadorPases = 0;
        public bool Lleva(Mesa mesa, Mano mano, Reglas reglas)
        {
            foreach (var ficha in mano.Data)
            {
                foreach (var cara in ficha.caras)
                {
                    if (reglas.EsValida(mesa.carasDisponibles[0], cara) || reglas.EsValida(mesa.carasDisponibles[1], cara))
                        return true;
                }
            }

            ContadorPases++;
            return false;
        }

        protected List<Ficha>[] GetPosiblesJugadas(JugadorBasico jugador, Mesa mesa, Reglas reglas)
        {
            List<Ficha>[] posiblesJugadas = new List<Ficha>[2];

            posiblesJugadas[0] = PosiblesJugadas(jugador, mesa, reglas, mesa.carasDisponibles[0]);
            posiblesJugadas[1] = PosiblesJugadas(jugador, mesa, reglas, mesa.carasDisponibles[1]);

            if (reglas.EsValida(mesa.carasDisponibles[0], mesa.carasDisponibles[1]))
                posiblesJugadas[1] = PosiblesJugadas(jugador, mesa, reglas, -1);

            return posiblesJugadas;
        }

        private List<Ficha> PosiblesJugadas(JugadorBasico jugador, Mesa mesa, Reglas reglas, int cara)
        {
            List<Ficha> posiblesJugadas = new List<Ficha>();

            if (mesa.Vacia) posiblesJugadas = jugador.Mano.Data;

            else
                foreach (var ficha in jugador.Mano.Data)
                {
                    if (reglas.EsValida(cara, ficha.First) || reglas.EsValida(cara, ficha.Second))
                        posiblesJugadas.Add(ficha);
                }
            return posiblesJugadas;
        }

        public virtual void Jugar(Mesa mesa, Reglas reglas) { }
    }

}


