using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Util
{
    public class Bootstrapper
    {
        public static void Initialize()
        {
            
        }

        public static DependencyResolver Resolver { get; set; }

        public static DependencyInstaller Installer { get; set; }
    }
}
