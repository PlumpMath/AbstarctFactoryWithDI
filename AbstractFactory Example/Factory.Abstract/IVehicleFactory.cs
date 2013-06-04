using Vehicle.Abstract;

namespace Factory.Abstract
{
    public interface IVehicleFactory
    {
        IBike Bike { get; set; }
        IScooter Scooter { get; set; }
    }
}
