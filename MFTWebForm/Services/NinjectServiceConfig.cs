using MFTWebForm.Infrastructure;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFTWebForm.Services {
    public class NinjectServiceConfig {
        public static void RegisterServices(IKernel kernel) {

            NinjectInfrastructureConfig.RegisterServices(kernel);
            kernel.Bind<StudentService>().ToSelf();
        }
    }
}