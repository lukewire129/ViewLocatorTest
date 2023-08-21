using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;

namespace ViewLocatorTest.Local.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
	{
        private readonly ViewModelBase[] Pages =
        {
            new LoginViewModel(),
            new MainViewModel(),
        };

        [ObservableProperty]
        private ViewModelBase _currentPage;


        public MainWindowViewModel()
        {
            WeakReferenceMessenger.Default.Register<string> (this, (s,e) =>
            {
                if(e == "Login")
                {
                    CurrentPage = Pages[0];
                    return;
                }
                CurrentPage = Pages[1];
            });

            _currentPage = Pages[0];
        }
    }
}