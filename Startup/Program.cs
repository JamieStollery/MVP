using Autofac;
using Domain;
using System;
using System.Windows.Forms;

namespace Startup
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (var scope = IoC.Container.BeginLifetimeScope())
            {
                var presenter = scope.Resolve<IPresenter>();
                presenter.View = scope.Resolve<IView>();
                Application.Run((Form)presenter.View);
            }

        }
    }
}
