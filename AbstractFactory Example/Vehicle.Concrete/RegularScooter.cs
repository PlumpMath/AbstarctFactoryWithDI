using Vehicle.Abstract;

namespace Vehicle.Concrete
{
    /// <summary>
    /// The 'ProductB1' class
    /// </summary>
    class RegularScooter : IScooter
    {
        public string Name()
        {
            return "Regular Scooter- Name";
        }
    }
}