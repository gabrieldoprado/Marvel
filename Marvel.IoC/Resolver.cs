using SimpleInjector;
using SimpleInjector.Lifestyles;
using System;
using System.Collections.Generic;
using System.Text;

namespace Marvel.IoC
{
    public class Resolver
    {
        private readonly Container Container;

        public Resolver()
        {
            Container = new Container();
            RegisterContainers();
            Container.Verify();
        }

        private void RegisterContainers()
        {
            //Register Domains
            //Container.Register<ITeste, Teste>();
        }

        public T Get<T>() where T : class
        {
            if (Container == null) throw new InvalidOperationException("Cannot resolve dependencies before the container has been initialized.");
            return Container.GetInstance<T>();
        }
    }
}
}
