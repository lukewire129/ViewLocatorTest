using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace ViewLocatorTest.Local.ViewModels
{
    public partial class LoginViewModel: ViewModelBase
    {
        [RelayCommand]
        public void Github()
        {
            WeakReferenceMessenger.Default.Send ("Main");
        }
    }
}