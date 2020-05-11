using MvvmTutorial.ViewModels;
using System.Windows;

namespace MvvmTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MyViewModel _viewModel;
        public MainWindow() { }
        public MainWindow(MyViewModel vm)
        {
            InitializeComponent();
            _viewModel = vm;
            DataContext = _viewModel;
        }
    }
}
