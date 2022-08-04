using PCStore.Component;
using PCStore.Decorator;

namespace PCStore.ConcretDecorators
{
    public class Monitor4K : ComponentDecorator
    {
        private decimal price = 210;

        private Computer currentComputer;

        public Monitor4K(Computer computer)
        {
            this.currentComputer = computer;
        }

        public override decimal CalculateCost()
        {
            return this.currentComputer.CalculateCost() + price;
        }

        public override string ShowDescriptions()
        {
            return this.currentComputer.ShowDescriptions() + "\nNuevo Monitor 4K: $" + price + " USD";
        }
    }
}

