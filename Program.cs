using Autofac;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsAppLibrarySample.Data;
using WindowsAppLibrarySample.Infrastructure;
using WindowsAppLibrarySample.Infrastructure.ServiceRegistration;
using WindowsAppLibrarySample.Services;

namespace WindowsAppLibrarySample
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //
            //var builder = new ContainerBuilder();

            //// Register the DbContext with the container
            //builder.RegisterType<LibraryContext>().As<DbContext>().InstancePerLifetimeScope();

            //// Register types
            //builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            //builder.RegisterType<BookService>().AsSelf();
            //builder.RegisterType<Form1>().AsSelf();
            //// Now build the container
            //var container = builder.Build();

            // Get the container with registered services
            var container = ServiceRegistration.RegisterServices();

            // Resolve the main form and run it
            Application.Run(container.Resolve<MainForm>());

            //Application.Run(new Form1());
        }
    }
}
