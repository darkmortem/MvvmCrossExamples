// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MasterDetailMvvmCross.iOS.Views.RootViewController
{
	[Register ("RootViewController")]
	partial class RootViewController
	{
		[Outlet]
		UIKit.UIButton firstViewButton { get; set; }

		[Outlet]
		UIKit.UIButton menuButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (menuButton != null) {
				menuButton.Dispose ();
				menuButton = null;
			}

			if (firstViewButton != null) {
				firstViewButton.Dispose ();
				firstViewButton = null;
			}
		}
	}
}
