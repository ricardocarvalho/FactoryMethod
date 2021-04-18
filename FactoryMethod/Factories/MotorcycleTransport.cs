using FactoryMethod.Vehicle;

namespace FactoryMethod.Factories
{
    class MotorcycleTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Motorcycle();
        }
    }
}
