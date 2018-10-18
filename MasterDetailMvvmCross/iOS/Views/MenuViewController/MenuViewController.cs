﻿using System;
using MasterDetailMvvmCross.ViewModels;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using UIKit;

namespace MasterDetailMvvmCross.iOS.Views.MenuViewController
{
    // [MvxModalPresentation(WrapInNavigationController = true, ModalPresentationStyle = UIModalPresentationStyle.BlurOverFullScreen)]
    [MvxChildPresentation]
    public partial class MenuViewController : MvxViewController<MenuViewModel>
    {
        public MenuViewController() : base("MenuViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

