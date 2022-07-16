using System.Collections.Generic;
using System.Linq;
namespace Domino
{
    public class GameOver_Usual : IFinalizador
    {
        public bool GameOver(Mesa mesa, Juego juego, JugadorBasico jugador)
        {

            if (jugador.pegado == true) return true;
            int contadorpases = 0;
            int contadorsucesos = 0;
            Ficha fichaPase = new Ficha(-1, -1);
            var reverse = mesa.Sucesos.ReverseList();

            foreach (var element in reverse)
            {

                if (element.ficha.First == fichaPase.First && element.ficha.Second == fichaPase.Second) { contadorpases++; }
                contadorsucesos++;


                if (contadorsucesos > juego.cantJugadores) return false;
                if (contadorpases == juego.cantJugadores) return true;
            }
            return false;
        }
    }

    public class GameOver_Doble_Blanco : IFinalizador
    {
        public bool GameOver(Mesa mesa, Juego juego, JugadorBasico jugador)
        {
            Ficha dobleBlanco = new Ficha(0, 0);

            if (jugador.Mano.cantFichas == 1 && jugador.Mano.Data.ElementAt(0).Equals(dobleBlanco))
                return true;

            if (jugador.pegado == true) return true;

            int contadorpases = 0;
            int contadorsucesos = 0;
            Ficha fichaPase = new Ficha(-1, -1);
            var reverse = mesa.Sucesos.ReverseList();

            foreach (var element in reverse)
            {

                if (element.ficha.First == fichaPase.First && element.ficha.Second == fichaPase.Second) { contadorpases++; }
                contadorsucesos++;


                if (contadorsucesos > juego.cantJugadores) return false;
                if (contadorpases == juego.cantJugadores) return true;
            }

            return false;
        }
    }

    public class GameOver_Balanceado : IFinalizador
    {
        public bool GameOver(Mesa mesa, Juego juego, JugadorBasico jugador)
        {
            if (jugador.Mano.cantFichas == jugador.cantPases && jugador.cantPases == jugador.Jugadas.Count)
                return true;

            if (jugador.pegado == true) return true;
            int contadorpases = 0;
            int contadorsucesos = 0;
            Ficha fichaPase = new Ficha(-1, -1);
            var reverse = mesa.Sucesos.ReverseList();

            foreach (var element in reverse)
            {

                if (element.ficha.First == fichaPase.First && element.ficha.Second == fichaPase.Second) { contadorpases++; }
                contadorsucesos++;


                if (contadorsucesos > juego.cantJugadores) return false;
                if (contadorpases == juego.cantJugadores) return true;
            }
            return false;
        }
    }

    //hay q ver q pinga hace el reverse ese aki
    static class Auxiliares
    {
        public static IEnumerable<T> ReverseList<T>(this List<T> items)
        {
            for (int i = items.Count - 1; i >= 0; i--)
            {
                yield return items[i];
            }
        }
    }
}







