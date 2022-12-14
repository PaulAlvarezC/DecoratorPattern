using PCStore.Component;
using PCStore.Decorator;

namespace PCStore.ConcretDecorators
{
    public class FastGraphic : ComponentDecorator
    {
        private decimal price = 2000;

        private Computer currentComputer;

        public FastGraphic(Computer computer)
        {
            this.currentComputer = computer;
        }

        public override decimal CalculateCost()
        {
            return this.currentComputer.CalculateCost() + price;
        }

        public override string ShowDescriptions()
        {
            return this.currentComputer.ShowDescriptions() + "\nNueva Gráfica: $" + price + " USD";
        }
    }
}

