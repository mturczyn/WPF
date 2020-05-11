using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.ObjectBuilder2;
using Microsoft.Practices.Unity;
using MvvmTutorial.DependencyInjection;
using MvvmTutorial.Models;
using MvvmTutorial.ViewModels;

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
            window.Show();
        }
    }
}
