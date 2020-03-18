using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Disposables;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ReactiveUI;

namespace ReactiveUIViewHostVerticalStretch
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ReactiveWindow<AppViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new AppViewModel();

            this.WhenActivated(disposableRegistration =>
            {
                this.OneWayBind(ViewModel,
                    viewModel => viewModel.UserControlViewModelLong.Items,
                    view => view.List_0.ItemsSource)
                    .DisposeWith(disposableRegistration);

                this.OneWayBind(ViewModel,
                    viewModel => viewModel.UserControlViewModelLong.Items,
                    view => view.List_1.ItemsSource)
                    .DisposeWith(disposableRegistration);

                this.OneWayBind(ViewModel,
                    viewModel => viewModel.UserControlViewModelLong,
                    view => view.UserControl1_0.ItemsSource,
                    prop => new ReactiveObject[] { prop })
                    .DisposeWith(disposableRegistration);

                this.OneWayBind(ViewModel,
                    viewModel => viewModel.UserControlViewModelLong,
                    view => view.UserControl1_1.ItemsSource,
                    prop => new ReactiveObject[] { prop })

                    .DisposeWith(disposableRegistration);
            });
        }
    }
}