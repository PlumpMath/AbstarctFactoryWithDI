using Util;

namespace Vehicle.Concrete
{
    public class Install : IWantToRegisterObject
    {
        public void Register()
        {
            Bootstrapper.Installer.Register<RegularBike>();

            Bootstrapper.Installer.Register<Scooty>();
        }
    }
}
