using Autofac;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsAppLibrarySample.Data;
using WindowsAppLibrarySample.Services;

namespace WindowsAppLibrarySample.Infrastructure.ServiceRegistration
{
    public static class ServiceRegistration
    {
        public static IContainer RegisterServices()
        {
            var builder = new ContainerBuilder();

            // Register the DbContext with the container
            builder.RegisterType<LibraryContext>().As<DbContext>().InstancePerLifetimeScope();

            // Register services
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<Library>().AsSelf();
            builder.RegisterType<MainForm>().AsSelf();

            return builder.Build();
        }
    }
}
