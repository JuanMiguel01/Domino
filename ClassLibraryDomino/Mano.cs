using System.Collections.Generic;
namespace Domino
{
    public class Mano
    {
        public List<Ficha> Data;
        public int cantFichas { get { return Data.Count; } }
        public int cantDobles
        {
            get
            {
                int count = 0;
                foreach (var element in Data)
                {
                    if (element.IsDouble()) count++;
                }
                return count;
            }
        }

        public void EliminaFicha(Ficha ficha)
        {
            Data.Remove(ficha);
        }

        public void AgregarFicha(Ficha ficha)
        {
            Data.Add(ficha);
        }

        public Mano(List<Ficha> Data)
        {
            this.Data = Data;
        }
    }







}

