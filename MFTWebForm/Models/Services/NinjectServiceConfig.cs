using MFTWebForm.Models.Infrastructure;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFTWebForm.Models.Services {
    public class NinjectServiceConfig {
        public static void RegisterServices(IKernel kernel) {

            NinjectInfrastructureConfig.RegisterServices(kernel);
            kernel.Bind<AccountService>().ToSelf();
        }
    }
}