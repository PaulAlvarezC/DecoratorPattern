using PCStore.Component;
using PCStore.Decorator;

namespace PCStore.ConcretDecorators
{
    public class Mouse : ComponentDecorator
    {
        private decimal price = 69;

        private Computer currentComputer;

        public Mouse(Computer computer)
        {
            this.currentComputer = computer;
        }

        public override decimal CalculateCost()
        {
            return this.currentComputer.CalculateCost() + price;
        }

        public override string ShowDescriptions()
        {
            return this.currentComputer.ShowDescriptions() + "\nNuevo Mouse: $" + price + " USD";
        }
    }
}

