using GreatPlaces.Domain.Core.Interfaces.Repositories;
using GreatPlaces.Domain.Core.Interfaces.Services;
using GreatPlaces.Domain.Entities;

namespace GreatPlaces.Domain.Services
{
    public class ServiceAttractions : ServiceBase<Attractions>, IServiceAttractions
    {
        private readonly IRepositoryAttractions _repositoryAttractions;

        public ServiceAttractions(IRepositoryAttractions repositoryAttractions) : base(repositoryAttractions)
        {
            _repositoryAttractions = repositoryAttractions;
        }
    }
}