using Vehicle.Abstract;

namespace Vehicle.Concrete
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    public class Scooty : IScooter
    {
        public string Name()
        {
            return "Scooty- Name";
        }
    }
}