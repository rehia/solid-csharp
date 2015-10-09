namespace SOLID.LSP
{
    public class ElectricDuckImplementation : ElectricDuck, Duck
    {
        private bool hasMoved;
        private bool isTurnedOn;

        public Duck TurnOn()
        {
            this.isTurnedOn = true;
            return this;
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