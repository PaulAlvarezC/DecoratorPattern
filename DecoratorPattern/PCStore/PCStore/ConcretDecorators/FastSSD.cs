using PCStore.Component;
using PCStore.Decorator;

namespace PCStore.ConcretDecorators
{
    public class FastSSD : ComponentDecorator
    {
        private decimal price = 230;

        private Computer currentComputer;

        public FastSSD(Computer computer)
        {
            this.currentComputer = computer;
        }

        public override decimal CalculateCost()
        {
            return this.currentComputer.CalculateCost() + price;
        }

        public override string DetailPc()
        {
            return this.currentComputer.DetailPc() + "\nNuevo Disco SSD: $" + price + " USD";
        }
    }
}

