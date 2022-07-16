using System.Collections.Generic;
namespace Domino
{

    public interface IFinalizador
    {
        bool GameOver(Mesa mesa, Juego juego, JugadorBasico jugador);
    }
    public interface ICalculador
    {
        int CalcularPuntos(JugadorBasico jugador, ICalculadorScore calculadorScore);
    }
    public interface IValidador
    {
        int ParametroValidacion { get; set; }
        bool EsValida(int cara, int caraFicha);
    }
    public interface ISiguienteJugador
    {
        int NextPlayer(List<JugadorBasico> jugadores, Ficha ficha);
    }

    public interface IRepartidor
    {
        void Repartir(List<JugadorBasico> jugadores, int fichaspormano, Mesa mesa);
    }

    public interface ICalculadorScore
    {
        int CalcularScore(Ficha ficha);
    }

    public interface ITorneoFinalizador
    {
        bool TorneoGameOver(Torneo torneo);
    }

}

