namespace Domino
{

    public class CalculaPuntos_Usual : ICalculador
    {
        public int CalcularPuntos(JugadorBasico jugador, ICalculadorScore calculadorScore)
        {
            int contadorPuntos = 0;
            foreach (var ficha in jugador.Mano.Data)
            {
                contadorPuntos += calculadorScore.CalcularScore(ficha);
            }
            return contadorPuntos;
        }
    }

    public class CalculaPuntos_X2 : ICalculador
    {
        public int CalcularPuntos(JugadorBasico jugador, ICalculadorScore calculadorScore)
        {
            int contadorPuntos = 0;
            foreach (var ficha in jugador.Mano.Data)
            {
                contadorPuntos += calculadorScore.CalcularScore(ficha);
            }

            if (contadorPuntos < 10) contadorPuntos *= 2;

            return contadorPuntos;
        }
    }

    public class CalculaPuntos_Pases : ICalculador
    {
        public int CalcularPuntos(JugadorBasico jugador, ICalculadorScore calculadorScore)
        {
            int contadorPuntos = 0;
            foreach (var ficha in jugador.Mano.Data)
            {
                contadorPuntos += calculadorScore.CalcularScore(ficha);
            }

            return contadorPuntos / jugador.cantPases;
        }
    }


}
