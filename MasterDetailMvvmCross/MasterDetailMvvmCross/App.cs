using MasterDetailMvvmCross.ViewModels;
using MvvmCross.Platform.IoC;

namespace MasterDetailMvvmCross
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<RootViewModel>();
        }
    }
}
