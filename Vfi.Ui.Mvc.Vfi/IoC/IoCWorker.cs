using System;
using Microsoft.Practices.Unity;

namespace Vfi.Ui.Mvc.Vfi.IoC
{
    public static class IoCWorker
    {
        static IoCWorker()
        {
            _container = new UnityContainer();
        }

        private static IUnityContainer _container;

        /// <summary>
        /// wires up the ioc container
        /// </summary>
        //static IoCWorker()
        //{

        //}
        /// <summary>
        /// Returns an injected implementation for the requested interface
        /// </summary>
        public static T Resolve<T>()
        {
            //_container = new UnityContainer();
            //var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            //section.Configure(_container, "VietFranceContainer");

            _container = IoCComponents.ConfigureUnity(_container);

            return _container.Resolve<T>();
        }

        /// <summary>
        /// Returns an injected implementation for the requested interface
        /// </summary>
        public static object Resolve(Type t)
        {
            //_container = new UnityContainer();
            //var section = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            //section.Configure(_container, "VietFranceContainer");

            _container = IoCComponents.ConfigureUnity(_container);

            return _container.Resolve(t);
        }

    }
}