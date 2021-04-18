using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Vehicle
{
    class Car : IVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Aqui é o carro.");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Aqui é a moto");
        }
    }
}
