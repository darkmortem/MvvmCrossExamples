﻿using System;
using MasterDetailMvvmCross.ViewModels;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using UIKit;

namespace MasterDetailMvvmCross.iOS.Views.FirstViewController
{
    [MvxChildPresentation]
    public partial class FirstViewController : MvxViewController<FirstViewModel>
    {
        public FirstViewController() : base("FirstViewController", null)
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

