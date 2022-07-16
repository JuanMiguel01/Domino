namespace Domino
{
    public class Ficha
    {
        public int First { get { return caras[0]; } }
        public int Second { get { return caras[1]; } }
        public int[] caras;

        public Ficha(int first, int second)
        {
            caras = new int[2];
            caras[0] = first;
            caras[1] = second;
        }

        public override string ToString()
        {
            return string.Format("[{0,2}|{1,2}]", First, Second);
        }

        public string ToBackwardsString()
        {
            return string.Format("[{0,2}|{1,2}]", Second, First);
        }

        public bool IsDouble()
        {
            return First.Equals(Second);
        }

    }
}
