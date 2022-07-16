using System.Collections.Generic;
using System.Linq;
namespace Domino
{

    public class Repartidor_Usual : IRepartidor
    {
        public void Repartir(List<JugadorBasico> listaJugadores, int cantFichasMano, Mesa mesa)
        {
            foreach (var jugador in listaJugadores)
            {
                int count = 0;
                List<Ficha> data = new List<Ficha>();

                while (count < cantFichasMano)
                {
                    var ficha = mesa.FichasDisponibles.First();
                    data.Add(ficha);
                    mesa.FichasDisponibles.Remove(ficha);
                    count++;
                }
                Mano mano = new Mano(data);
                jugador.Mano = mano;
            }
        }
    }

    public class Repartidor_5Dobles : IRepartidor
    {
        public void Repartir(List<JugadorBasico> listaJugadores, int cantFichasMano, Mesa mesa)
        {
            foreach (var jugador in listaJugadores)
            {
                int count = 0;
                List<Ficha> data = new List<Ficha>();

                while (count < cantFichasMano)
                {
                    var ficha = mesa.FichasDisponibles.First();
                    data.Add(ficha);
                    mesa.FichasDisponibles.Remove(ficha);
                    count++;
                }

                Mano mano = new Mano(data);

                List<Ficha> aux = mano.Data;
                
                if (mano.cantDobles >= 5)
                {
                    foreach (var item in mano.Data.ToList())
                    {
                        if (item.IsDouble())
                        {
                            mano.EliminaFicha(item);
                            mano.AgregarFicha(mesa.FichasDisponibles.First());

                            mesa.FichasDisponibles.Remove(mano.Data.Last());
                            mesa.FichasDisponibles.Add(item);
                        }

                    }
                }

                jugador.Mano = mano;
            }
        }
    }
    public class Repartidor_SinDobles : IRepartidor
    {
        public void Repartir(List<JugadorBasico> listaJugadores, int cantFichasMano, Mesa mesa)
        {
            foreach (var jugador in listaJugadores)
            {
                int count = 0;
                List<Ficha> data = new List<Ficha>();

                while (count < cantFichasMano)
                {
                    var ficha = mesa.FichasDisponibles.First();

                    if (!ficha.IsDouble())
                    {
                        data.Add(ficha);
                        mesa.FichasDisponibles.Remove(ficha);
                        count++;
                    }

                    mesa.FichasDisponibles.Remove(ficha);
                }

                Mano mano = new Mano(data);
                jugador.Mano = mano;

            }
        }
    }
}