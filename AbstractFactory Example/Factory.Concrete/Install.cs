using System;
using Util;

namespace Factory.Concrete
{
    public class Install : IWantToRegisterObject
    {
        public void Register()
        {
            Bootstrapper.Installer.Register<HeroFactory>();
        }
    }
}
