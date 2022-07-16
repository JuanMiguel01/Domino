using System;
namespace Domino
{

    public class CalcularScore_Usual : ICalculadorScore
    {
        public int CalcularScore(Ficha ficha)
        {
            return ficha.First + ficha.Second;
        }
    }
    public class CalcularScore_Multiplicar : ICalculadorScore
    {
        public int CalcularScore(Ficha ficha)
        {
            return ficha.First * ficha.Second;
        }
    }
    public class CalcularScore_DiferenciaModular : ICalculadorScore
    {
        public int CalcularScore(Ficha ficha)
        {
            return Math.Abs(ficha.First - ficha.Second) / 2;
        }
    }
}

