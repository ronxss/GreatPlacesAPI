using GreatPlaces.Application.Dto;
using GreatPlaces.Application.Interface;
using GreatPlaces.Domain.Core.Interfaces.Services;

namespace GreatPlaces.Application
{
    public class ApplicationServiceAttractions : IApplicationServiceAttractions
    {
        private readonly IServiceAttractions serviceAttractions;
        private readonly IMapperAttractions mapperAttractions;

        public ApplicationServiceAttractions(IServiceAttractions serviceAttractions, IMapperAttractions mapperAttractions)
        {
            this.serviceAttractions = serviceAttractions;
            this.mapperAttractions = mapperAttractions;
        }

        void IApplicationServiceAttractions.Add(AttractionsDto attractionsDto)
        {
            var attractions = mapperAttractions.MapperDtoToEntity(attractionsDto);
            serviceAttractions.Add(attractions);
        }

        IEnumerable<AttractionsDto> IApplicationServiceAttractions.GetAll()
        {
            var attractions = serviceAttractions.GetAll();
            return mapperAttractions.MapperListAttractionsDto(attractions);
        }

        AttractionsDto IApplicationServiceAttractions.GetById(int id)
        {
            var attractions = serviceAttractions.GetById(id);
            return mapperAttractions.MapperEntityToDto(attractions);
        }

        void IApplicationServiceAttractions.Remove(AttractionsDto attractionsDto)
        {
            var attractions = mapperAttractions.MapperDtoToEntity(attractionsDto);
            serviceAttractions.Delete(attractions);
        }

        void IApplicationServiceAttractions.Update(AttractionsDto attractionsDto)
        {
            var attractions = mapperAttractions.MapperDtoToEntity(attractionsDto);
            serviceAttractions.Update(attractions);
        }
    }
}