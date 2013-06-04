using Vehicle.Abstract;

namespace Vehicle.Concrete
{
    /// <summary>
    /// The 'ProductA2' class
    /// </summary>
    class SportsBike : IBike
    {
        public string Name()
        {
            return "Sports Bike- Name";
        }
    }
}