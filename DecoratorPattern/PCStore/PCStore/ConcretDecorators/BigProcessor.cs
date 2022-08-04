using PCStore.Component;
using PCStore.Decorator;

namespace PCStore.ConcretDecorators
{
    public class BigProcessor : ComponentDecorator
    {
        private decimal price = 400;

        private Computer currentComputer;

        public BigProcessor(Computer computer)
        {
            this.currentComputer = computer;
        }

        public override decimal CalculateCost()
        {
            return this.currentComputer.CalculateCost() + price;
        }

        public override string ShowDescriptions()
        {
            return this.currentComputer.ShowDescriptions() + "\nNuevo Procesador: $" + price + " USD";
        }
    }
}

