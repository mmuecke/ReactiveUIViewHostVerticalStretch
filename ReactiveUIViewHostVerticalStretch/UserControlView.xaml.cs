using ReactiveUI;
using System.Reactive.Disposables;

namespace ReactiveUIViewHostVerticalStretch
{
    /// <summary>
    /// Interaktionslogik für UserControlView.xaml
    /// </summary>
    public partial class UserControlView : ReactiveUserControl<UserControlViewModel>
    {
        public UserControlView()
        {
            InitializeComponent();

            this.WhenActivated(disposableRegistration =>
            {
                this.OneWayBind(ViewModel,
                   viewModel => viewModel.Items,
                   view => view.InnerItems.ItemsSource)
                   .DisposeWith(disposableRegistration);
            });
        }
    }
}