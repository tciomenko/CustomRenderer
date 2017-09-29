using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using CustomRenderers.Views;

namespace CustomRenderers.ViewModels
{
    public class NavigationViewModel:INotifyPropertyChanged
    {
		public event PropertyChangedEventHandler PropertyChanged;

        public ICommand ExitCommand;

        public NavigationViewModel()
		{
            ExitCommand = new Command(ExitClick);
		}
		private void ExitClick()
		{
			

		}
    }
}
