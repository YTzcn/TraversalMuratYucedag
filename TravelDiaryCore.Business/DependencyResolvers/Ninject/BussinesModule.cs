using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using TravelDiaryCore.Business.Abstract;
using TravelDiaryCore.Business.Concrete;
using TravelDiaryCore.DataAccess.Abstract;
using TravelDiaryCore.DataAccess.Concrete.EntityFramework;

namespace TravelDiaryCore.Business.DependencyResolvers.Ninject
{
    public class BussinesModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IGuideDal>().To<EfGuideDal>().InSingletonScope();
            Bind<IGuideService>().To<GuideManager>().InSingletonScope();

            Bind<IAbout2Dal>().To<EfAbout2Dal>().InSingletonScope();
            Bind<IAbout2Service>().To<About2Manager>().InSingletonScope();

            Bind<IAboutDal>().To<EfAboutDal>().InSingletonScope();
            Bind<IAboutService>().To<AboutManager>().InSingletonScope();

            Bind<IContactDal>().To<EfContactDal>().InSingletonScope();
            Bind<IContactService>().To<ContactManager>().InSingletonScope();

            Bind<IDestinationDal>().To<EfDestinationDal>().InSingletonScope();
            Bind<IDestinationService>().To<DestinationManager>().InSingletonScope();

            Bind<IFeature2Dal>().To<EfFeature2Dal>().InSingletonScope();
            Bind<IFeature2Service>().To<Feature2Manager>().InSingletonScope();

            Bind<IFeatureDal>().To<EfFeatureDal>().InSingletonScope();
            Bind<IFeatureService>().To<FeatureManager>().InSingletonScope();

            Bind<INewstellerDal>().To<EfNewstellerDal>().InSingletonScope();
            Bind<INewstellerService>().To<NewstellerManager>().InSingletonScope();

            Bind<ISubAboutDal>().To<EfSubAboutDal>().InSingletonScope();
            Bind<ISubAboutService>().To<SubAboutManager>().InSingletonScope();

            Bind<ITestimonialDal>().To<EfTestimonialDal>().InSingletonScope();
            Bind<ITestimonialService>().To<TestimonialManager>().InSingletonScope();

            Bind<ICommentDal>().To<EfCommentDal>().InSingletonScope();
            Bind<ICommentService>().To<CommentManager>().InSingletonScope();
        }
    }
}
