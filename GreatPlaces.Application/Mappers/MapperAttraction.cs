using GreatPlaces.Application.Dto;
using GreatPlaces.Domain.Core.Interfaces;
using GreatPlaces.Domain.Entities;

namespace GreatPlaces.Application.Interface.Mappers
{
    public class MapperAttraction : IMapperAttractions
    {
        public Attractions MapperDtoToEntity(AttractionsDto attractionsDto)
        {
            var attraction = new Attractions() {

                Id = attractionsDto.Id,
                Name = attractionsDto.Name,
                City = attractionsDto.City,
                Description = attractionsDto.Description,
                Localization = attractionsDto.Localization,
                State = attractionsDto.State
            };

            return attraction;
        }

        public AttractionsDto MapperEntityToDto(Attractions attractions)
        {
            var attractionsDto = new AttractionsDto()
            {
                Id = attractions.Id,
                Name = attractions.Name,
                City = attractions.City,
                Description = attractions.Description,
                Localization = attractions.Localization,
                State = attractions.State
            };
            return attractionsDto;
        }

       IEnumerable<AttractionsDto> IMapperAttractions.MapperListAttractionsDto(IEnumerable<AttractionsDto> attractionsDto)
        {
            var dto = attractionsDto.Select(a => new AttractionsDto
            {
                Id = a.Id,
                Name = a.Name,
                City = a.City,
                Description = a.Description,
                Localization = a.Localization,
                State = a.State
            });
            return dto;
        }

        IEnumerable<AttractionsDto> IMapperAttractions.MapperListAttractionsDto(IEnumerable<Attractions> attractions)
        {
            throw new NotImplementedException();
        }
    }
}