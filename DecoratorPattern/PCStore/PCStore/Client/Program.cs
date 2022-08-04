using PCStore.Component;
using PCStore.ConcretComponent;
using PCStore.ConcretDecorators;

namespace PCStore.Client
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Computer gammerPC = new BasicComputer();
            gammerPC = new Keyboard(gammerPC);
            gammerPC = new Mouse(gammerPC);
            gammerPC = new FastSSD(gammerPC);
            gammerPC = new Monitor4K(gammerPC);
            gammerPC = new FastGraphic(gammerPC);

            var cost = gammerPC.CalculateCost();
            var details = gammerPC.ShowDescriptions();

            Console.WriteLine(string.Format("Detalles: \n {0}", details));
            Console.WriteLine(string.Format("El Coste del PC es de $ {0} USD.", cost));
        }
    }
}

