using PCStore.Component;
using PCStore.Decorator;

namespace PCStore.ConcretDecorators
{
    public class Keyboard : ComponentDecorator
    {
        private decimal price = 69;

        private Computer currentComputer;

        public Keyboard(Computer computer)
        {
            this.currentComputer = computer;
        }

        public override decimal CalculateCost()
        {
            return this.currentComputer.CalculateCost() + price;
        }

        public override string DetailPc()
        {
            return this.currentComputer.DetailPc() + "\nNuevo Teclado: $" + price + " USD";
        }
    }
}

