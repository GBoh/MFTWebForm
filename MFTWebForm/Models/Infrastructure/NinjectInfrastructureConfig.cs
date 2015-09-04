using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFTWebForm.Models.Infrastructure {
    public class NinjectInfrastructureConfig {
        public static void RegisterServices(IKernel kernel) {
            kernel.Bind<IRepository>().To<Repository>();
            //kernel.Bind<ApplicationDbContext>().ToSelf();
        }
    }
}