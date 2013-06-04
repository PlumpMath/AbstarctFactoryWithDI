using Factory.Abstract;
using Vehicle.Abstract;

namespace Factory.Concrete
{
    /// <summary>
    /// The 'ConcreteFactory2' class.
    /// </summary>
    public class HeroFactory : IVehicleFactory
    {
        public IBike Bike { get; set; }

        public IScooter Scooter{ get; set; }
    }
}