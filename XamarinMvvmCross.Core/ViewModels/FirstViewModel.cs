using System;
using MvvmCross.ViewModels;

namespace XamarinMvvmCross.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        public FirstViewModel()
        {
            CustomString = "Dzień dobry!";
        }

        private string _customString;
        public string CustomString
        {
            get => _customString;
            set
            {
                _customString = value;
                RaisePropertyChanged(() => CustomString);
            }
        }
    }
}

