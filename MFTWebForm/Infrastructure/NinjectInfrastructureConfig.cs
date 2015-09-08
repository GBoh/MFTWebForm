using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFTWebForm.Infrastructure {
    public class NinjectInfrastructureConfig {
        public static void RegisterServices(IKernel kernel) {
            kernel.Bind<IRepository>().To<Repository>();
        }
    }
}