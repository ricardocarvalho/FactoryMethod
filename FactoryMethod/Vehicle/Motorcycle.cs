using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicle
{
    class Motorcycle : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Aqui é a moto");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Peguei seu pedido!");
        }
    }
}
