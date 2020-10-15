using Autofac;
using Data;
using Domain;
using GUI;

namespace Startup
{
    public static class IoC
    {
        public static IContainer Container
        { 
            get 
            {
                var builder = new ContainerBuilder();
                builder.RegisterType<View>().As<IView>().SingleInstance();
                builder.RegisterType<Presenter>().As<IPresenter>().SingleInstance();
                builder.RegisterType<Repository>().As<IRepository>().SingleInstance();
                return builder.Build();
            } 
        }
    }
}
