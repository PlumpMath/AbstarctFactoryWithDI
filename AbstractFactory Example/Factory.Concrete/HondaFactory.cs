using Factory.Abstract;
using Vehicle.Abstract;

namespace Factory.Concrete
{
    /// <summary>
    /// The 'ConcreteFactory1' class.
    /// </summary>
    public class HondaFactory : IVehicleFactory
    {
        public IBike Bike { get; set; }

        public IScooter Scooter { get; set; }
    }
}