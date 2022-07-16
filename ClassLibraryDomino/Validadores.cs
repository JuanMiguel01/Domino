namespace Domino
{

    public class Validador_Usual : IValidador
    {
        public int ParametroValidacion { get; set; }
        public bool EsValida(int cara, int caraFicha)
        {
            return (caraFicha == cara);

        }
    }

    public class Validador_Paridad : IValidador
    {
        public int ParametroValidacion { get; set; }
        public bool EsValida(int cara, int caraFicha)
        {

            return (cara % ParametroValidacion == caraFicha % ParametroValidacion);
        }
    }

    public class Validador_Mult : IValidador
    {
        public int ParametroValidacion { get; set; }
        public bool EsValida(int cara, int caraFicha)
        {

            return (cara + caraFicha) %  ParametroValidacion  == 0;
        }
    }
}