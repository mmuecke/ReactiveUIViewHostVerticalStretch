using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ReactiveUIViewHostVerticalStretch
{
    /// <summary>
    /// Interaktionslogik für ItemView.xaml
    /// </summary>
    public partial class ItemView : ReactiveUserControl<ItemViewModel>
    {
        public ItemView()
        {
            InitializeComponent();

            this.WhenActivated(disposableRegistration =>
            {
                this.OneWayBind(ViewModel,
                   viewModel => viewModel.Text,
                   view => view.Text.Text)
                   .DisposeWith(disposableRegistration);
            });
        }
    }
}