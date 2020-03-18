// AppViewModel is where we will describe the interaction of our application.
// We can describe the entire application in one class since it's very small now.
// Most ViewModels will derive off ReactiveObject, while most Model classes will
// most derive off INotifyPropertyChanged
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ReactiveUIViewHostVerticalStretch
{
    public class AppViewModel : ReactiveObject
    {
        public UserControlViewModel UserControlViewModelLong { get; }
        public UserControlViewModel UserControlViewModelShort { get; }

        public AppViewModel()
        {
            UserControlViewModelLong = new UserControlViewModel();
            UserControlViewModelShort = new UserControlViewModel(2);
        }
    }
}