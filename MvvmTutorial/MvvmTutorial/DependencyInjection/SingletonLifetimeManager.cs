using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MvvmTutorial.DependencyInjection
{
    public class SingletonLifetimeManager<T> : LifetimeManager
        where T : class
    {
        private static T _instance;
        public override object GetValue()
        {
            return _instance ?? (_instance = (T)Activator.CreateInstance(typeof(T)));
        }

        public override void RemoveValue()
        {
            _instance = null;
        }

        public override void SetValue(object newValue)
        {
            _instance = (T)newValue;
        }
    }
}
