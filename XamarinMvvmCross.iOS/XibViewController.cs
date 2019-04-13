using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.Platforms.Ios.Presenters.Attributes;
using MvvmCross.Platforms.Ios.Views;
using UIKit;
using XamarinMvvmCross.Core.ViewModels;

namespace XamarinMvvmCross.iOS
{
    [MvxRootPresentation]
    public partial class XibViewController : MvxViewController<FirstViewModel>
    {
        public XibViewController() : base("XibViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<XibViewController, FirstViewModel>();
            set.Bind(MyLabel).For(v => v.Text).To(vm => vm.CustomString);
            set.Apply();
        }
    }
}

