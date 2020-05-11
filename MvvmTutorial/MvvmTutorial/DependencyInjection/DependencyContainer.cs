using Microsoft.Practices.Unity;
using MvvmTutorial.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmTutorial.DependencyInjection
{
    public static class DependencyContainer
    {
        private static UnityContainer _unityConteiner = new UnityContainer();
        /// <summary>
        /// Creates object of <typeparamref name="TViewModel"/> and passes
        /// <typeparamref name="TService"/> to it's contructor.
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <typeparam name="TViewModel"></typeparam>
        /// <returns></returns>
        public static TViewModel RegisterServiceForViewModel<TService, TViewModel>()
        {
            return _unityConteiner
                .RegisterType<TService>()
                .Resolve<TViewModel>();
        }
        /// <summary>
        /// Creates object of <typeparamref name="TViewModel"/> and passes
        /// <typeparamref name="TService"/> to it's contructor, which is singleton.
        /// </summary>
        /// <typeparam name="TService"></typeparam>
        /// <typeparam name="TViewModel"></typeparam>
        /// <returns></returns>
        public static TViewModel RegisterSingletonServiceForViewModel<TService, TViewModel>()
            where TService : class
            where TViewModel : class
        {
            return _unityConteiner
                .RegisterType<TService>(new SingletonLifetimeManager<TService>())
                .Resolve<TViewModel>();
        }
        public static void Dispose()
        {
            _unityConteiner?.Dispose();
        }
    }
}
