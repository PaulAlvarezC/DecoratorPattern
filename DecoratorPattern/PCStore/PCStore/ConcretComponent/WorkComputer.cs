using System;
using PCStore.Component;

namespace PCStore.ConcretComponent
{
    public class WorkComputer : Computer
    {
        private decimal processor = 140;
        private decimal hdd = 70;
        private decimal graphics = 90;
        private decimal ram = 75;

        public override decimal CalculateCost()
        {
            var cost = this.processor + this.hdd + this.graphics + this.ram;

            return cost;
        }

        public override string DetailPc()
        {
            return "\nComputadora Trabajo: \n" +
                "Procesador: $" + processor + " USD \n" +
                "Disco Duro: $" + hdd + " USD \n" +
                "Gráfica   : $" + graphics + " USD \n" +
                "RAM       : $" + ram + " USD \n";
        }
    }
}

