using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http;
using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using PingYourPackage.Domain.Concrete;
using System.Data.Entity;
using PingYourPackage.Domain.Abstract;

namespace PingYourPackage.API.Config
{
    public class AutofacWebAPI
    {
        public static void Initialize(HttpConfiguration config)
        {
            Initialize(config,
            RegisterServices(new ContainerBuilder()));
        }
        public static void Initialize(
        HttpConfiguration config, IContainer container)
        {
            config.DependencyResolver =
            new AutofacWebApiDependencyResolver(container);
        }
        private static IContainer RegisterServices(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(
            Assembly.GetExecutingAssembly())
            .PropertiesAutowired();

            //EF DbContext
            builder.RegisterType<EFDbContext>()
             .As<DbContext>().InstancePerApiRequest();

            //Repositories
            // Register repositories by using Autofac's OpenGenerics feature
            // More info: http://code.google.com/p/autofac/wiki/OpenGenerics
            builder.RegisterGeneric(typeof(EntityRepository<>))
            .As(typeof(IEntityRepository<>))
            .InstancePerApiRequest();


            //Services
            return builder.Build();
        }
    }
}
