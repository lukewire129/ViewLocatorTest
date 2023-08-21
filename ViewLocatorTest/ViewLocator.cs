using Avalonia.Controls;
using Avalonia.Controls.Templates;
using ViewLocatorTest.Local.ViewModels;
using System;

namespace ViewLocatorTest
{
    public class ViewLocator : IDataTemplate
    {
        public Control Build(object? data)
        {
            if (data is null)
            {
                return new TextBlock { Text = "data was null" };
            }

            var Pathname = data.GetType ().FullName!.Replace ("Local.ViewModels", "UI.Views");
            var name = Pathname.Replace ("ViewModel", "View");
            var type = Type.GetType (name);

            if (type != null)
            {
                return (Control)Activator.CreateInstance (type)!;
            }
            else
            {
                return new TextBlock { Text = "Not Found: " + name };
            }
        }

        public bool Match(object? data)
        {
            return data is ViewModelBase;
        }
    }
}
