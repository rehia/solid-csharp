namespace SOLID.LSP
{
    public class Colvert : Duck
    {
        private bool hasMoved;

        public bool HasMoved()
        {
            return this.hasMoved;
        }

        public void Swim()
        {
            this.hasMoved = true;
        }
    }
}