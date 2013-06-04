using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Factory.Abstract;
using Util;

namespace Client
{
    public class ClientExample
    {
        public ClientExample()
        {
            Bootstrapper.Initialize();
            Factory = Bootstrapper.Resolver.Resolve<IVehicleFactory>();
        }

        public IVehicleFactory Factory { get; set; }  

        public void Test()
        {
            Console.WriteLine(Factory.Bike.Name());
            Console.WriteLine(Factory.Scooter.Name());
        }
    }
}
