using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;

namespace TravelDiaryCore.Business.DependencyResolvers.Ninject
{
    public class InstanceFactory 
    {
        public static T GetInstance<T>(NinjectModule ninjectModule)
        {
            var kernel = new StandardKernel(ninjectModule);
            return kernel.Get<T>();
        }

        // KULLANIM:
        //_productService = InstanceFactory.GetInstance<IProductService>();
    }
}
