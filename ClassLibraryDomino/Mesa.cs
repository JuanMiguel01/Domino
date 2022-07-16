using System.Collections.Generic;
using System.Linq;
namespace Domino
{

    public class Mesa
    {
        public Mesa()
        {
            this.Sucesos = new List<Jugada>();
            this.carasDisponibles = new int[2];
            this.FichasDisponibles = new List<Ficha>();
        }
        public List<Jugada> Sucesos;
        public int[] carasDisponibles;
        public List<Ficha> FichasDisponibles;
        public Ficha Salida { get { return Sucesos.First().ficha; } }
        public bool Vacia { get { return Sucesos.Count == 0; } }

        public void ActualizarCaras(Ficha ficha, IValidador validador,bool jugoDerecha)
        {
            if (Sucesos.Count == 1)
            {
                carasDisponibles[0] = ficha.First;
                carasDisponibles[1] = ficha.Second;
            }
            else
            {
                if (jugoDerecha)
                {
                     if (validador.EsValida(ficha.First, carasDisponibles[1])) carasDisponibles[1] = ficha.Second;
                    else if (validador.EsValida(ficha.Second, carasDisponibles[1])) carasDisponibles[1] = ficha.First;
                }
                else {
                    if (validador.EsValida(ficha.First, carasDisponibles[0])) carasDisponibles[0] = ficha.Second;
                    else if (validador.EsValida(ficha.Second, carasDisponibles[0])) carasDisponibles[0] = ficha.First;
                }
                
                
            }

        }
    }
}
