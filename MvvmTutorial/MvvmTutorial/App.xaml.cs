using MvvmTutorial.DependencyInjection;
using MvvmTutorial.Models;
using MvvmTutorial.ViewModels;
using System.Windows;

namespace MvvmTutorial
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var viewModel = DependencyContainer.RegisterSingletonServiceForViewModel<DataManager, MyViewModel>();
            var window = new MainWindow(viewModel);
            var samplesWindow = new WpfSamples.WpfSamplesWindow();
            window.Show();
            samplesWindow.Show();
        }
    }
}
