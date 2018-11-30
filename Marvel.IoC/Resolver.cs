using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.IoC
{
    public class Resolver
    {
        private static Container Container { get; set; }

        public Resolver()
        {
            Container = new Container();
            RegisterContainers();
            Container.Verify();
        }

        public static Resolver RegistryDependency()
        {
            return new Resolver();
        }

        private void RegisterContainers()
        {
            //Register Domains
            //Container.Register<ITeste, Teste>(Lifestyle.Transient);
        }

        public static T Get<T>() where T : class
        {
            if (Container == null) throw new InvalidOperationException("Cannot resolve dependencies before the container has been initialized.");
            return Container.GetInstance<T>();
        }
    }
}
