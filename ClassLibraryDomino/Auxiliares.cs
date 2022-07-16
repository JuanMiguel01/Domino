using System.Collections.Generic;
using System.Linq;
using System;
namespace Domino
{
    public class Juez
    {
        public static List<JugadorBasico> GetGanadores(List<JugadorBasico> jugadores, Reglas reglas)
        {
            List<JugadorBasico> ganadores = new List<JugadorBasico>();
            List<JugadorBasico> result = new List<JugadorBasico>();

            foreach (var item in jugadores)
            {
                if (item.pegado)
                    ganadores.Add(item);
            }

            if (ganadores.Count == 0)
            {
                foreach (var item in jugadores)
                {
                    item.cantPuntos = reglas.CalcularPuntos(item, reglas.calculadorScore);
                    result.Add(item);
                }

                ganadores.Add(result.OrderBy(x => x.cantPuntos).ToList().First());
            }

            foreach (var item in jugadores)
            {
                var ganadorActual = ganadores.First();
                if (item.numEquipo == ganadorActual.numEquipo && !item.Equals(ganadorActual))
                    ganadores.Add(item);
            }

            return ganadores;
        }

    }

    public class CreadorFichas
    {
        public static List<Ficha> Crear(int ultimNumero)
        {
            List<Ficha> fichas = new List<Ficha>();
            for (int j = 0; j <= ultimNumero; j++)
            {
                for (int i = 0; i <= j; i++)
                {

                    fichas.Add(new Ficha(j, i));

                }
            }
            return fichas;
        }
    }
    public class Barajeador
    {
        static Random random = new Random();
        public static void Shuffle(List<Ficha> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Ficha ficha = list[k];
                list[k] = list[n];
                list[n] = ficha;
            }
        }
    }

}
