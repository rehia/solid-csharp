namespace SOLID.LSP
{
    public class ElectricDuckImplementation : ElectricDuck
    {
        private bool hasMoved;
        private bool isTurnedOn;

        public void TurnOn()
        {
            this.isTurnedOn = true;
        }

        public bool HasMoved()
        {
            return this.hasMoved;
        }

        public void Swim()
        {
            if (!this.isTurnedOn)
            {
                throw new CannotSwimException("Electric Duck should be turned on first");
            }

            this.hasMoved = true;
        }
    }
}