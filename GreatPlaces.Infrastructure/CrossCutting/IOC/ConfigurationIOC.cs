using Autofac;
using GreatPlaces.Application;
using GreatPlaces.Application.Interface;
using GreatPlaces.Application.Interface.Mappers;
using GreatPlaces.Domain.Core.Interfaces.Repositories;
using GreatPlaces.Domain.Core.Interfaces.Services;
using GreatPlaces.Domain.Services;
using GreatPlaces.Infrastructure.Data.Repositories;

namespace GreatPlaces.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<ApplicationServiceAttractions>().As<IApplicationServiceAttractions>();
            builder.RegisterType<ServiceAttractions>().As<IServiceAttractions>();
            builder.RegisterType<RepositoryAttractions>().As<IRepositoryAttractions>();
            builder.RegisterType<MapperAttraction>().As<IMapperAttractions>();

            #endregion IOC
        }
    }
}