using SimpleInjector;
using System;

namespace Marvel.IoC
{
    public partial class Resolver
    {
        private static Container Container { get; set; }

        public Resolver()
        {
            Container = new Container();
            RegistryContainers();
            Container.Verify();
        }

        public static Resolver RegistryDependency()
        {
            return new Resolver();
        }

        private void RegistryContainers()
        {
            ContainerModel();
            ContainerBusiness();
            ContainerServices();
            ContainerDataAccess();
        }

        public static T Get<T>() where T : class
        {
            if (Container == null) throw new InvalidOperationException("Cannot resolve dependencies before the container has been initialized.");
            return Container.GetInstance<T>();
        }
    }
}
