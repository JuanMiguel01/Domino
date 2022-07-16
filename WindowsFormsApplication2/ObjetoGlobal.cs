using System.Collections.Generic;
using System.Collections;
using System;
using Domino;
namespace WindowsFormsApplication2
{

    public class ObjetoGlobal
    {

        public int cantidadJugadores = 0;
        public int FichasPorMano = 0;
        public int UltimNumero = 0;

        public string CalcularPuntos = "";
        public string CalcularScore = "";
        public string CondicionFinalizacion = "";
        public string Repartidor = "";
        public string SiguienteJugador = "";
      
        public string Validador = "";
        public int Equipo = 0;
        public int ParametroValidacion = 0;

        public Dictionary<string, Tuple<string, int>> jugadores = new Dictionary<string, Tuple<string, int>>();

    }
}