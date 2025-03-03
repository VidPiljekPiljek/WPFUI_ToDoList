using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFUI_ToDoList.Stores;
using WPFUI_ToDoList.ViewModels;

namespace WPFUI_ToDoList.Services
{
    public class NavigationService<TViewModel> where TViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        private readonly Func<TViewModel> _createViewModel;

        public NavigationService(NavigationStore navigationStore, Func<TViewModel> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public void Navigate()
        {
            //_navigationStore.CurrentViewModel = (TViewModel)Activator.CreateInstance(typeof(TViewModel));
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}
