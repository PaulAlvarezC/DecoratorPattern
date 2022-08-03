using System;
using PCStore.Component;

namespace PCStore.ConcretComponent
{
    public class GamerComputer : Computer
    {
        private decimal processor = 300;
        private decimal hdd = 250;
        private decimal graphics = 1000;
        private decimal ram = 130;

        public override decimal CalculateCost()
        {
            var cost = this.processor + this.hdd + this.graphics + this.ram;

            return cost;
        }

        public override string DetailPc()
        {
            return "\nComputadora Gamer: \n" +
                "Procesador: $" + processor + " USD \n" +
                "Disco Duro: $" + hdd + " USD \n" +
                "Gráfica   : $" + graphics + " USD \n" +
                "RAM       : $" + ram + " USD \n";
        }
    }
}

