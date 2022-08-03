using PCStore.Component;
using PCStore.Decorator;

namespace PCStore.ConcretDecorators
{
    public class FastRam : ComponentDecorator
    {
        private decimal price = 300;

        private Computer currentComputer;

        public FastRam(Computer computer)
        {
            this.currentComputer = computer;
        }

        public override decimal CalculateCost()
        {
            return this.currentComputer.CalculateCost() + price;
        }

        public override string DetailPc()
        {
            return this.currentComputer.DetailPc() + "\nNueva RAM: $" + price + " USD";
        }
    }
}

