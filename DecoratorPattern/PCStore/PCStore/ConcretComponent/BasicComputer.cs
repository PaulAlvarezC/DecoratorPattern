using System;
using PCStore.Component;

namespace PCStore.ConcretComponent
{
    public class BasicComputer : Computer
    {
        private decimal processor = 120;
        private decimal hdd = 60;
        private decimal graphics = 80;
        private decimal ram = 65;

        public override decimal CalculateCost()
        {
            var cost = this.processor + this.hdd + this.graphics + this.ram;

            return cost;
        }

        public override string DetailPc() {
            return "\nComputadora Básica: \n" +
                "Procesador: $" + processor + " USD \n" +
                "Disco Duro: $" + hdd + " USD \n" +
                "Gráfica   : $" + graphics + " USD \n" +
                "RAM       : $" + ram + " USD \n";
        }
    }
}

