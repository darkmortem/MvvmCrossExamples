using System;
using MasterDetailMvvmCross.ViewModels;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using UIKit;

namespace MasterDetailMvvmCross.iOS.Views.RootViewController
{
    [MvxRootPresentation(WrapInNavigationController = true)]
    public partial class RootViewController : MvxViewController<RootViewModel> 
    {
        public RootViewController() : base("RootViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();    

            var bindingSet = this.CreateBindingSet<RootViewController, RootViewModel>();          
            bindingSet.Bind(menuButton).To(vm => vm.ShowMenuCommand);
            bindingSet.Bind(firstViewButton).To(vm => vm.ShowFirstViewCommand);
            bindingSet.Apply();

        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

