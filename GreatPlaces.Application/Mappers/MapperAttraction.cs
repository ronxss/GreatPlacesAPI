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
                Cidade = attractionsDto.Cidade,
                Descricao = attractionsDto.Descricao,
                Localizacao = attractionsDto.Localizacao,
                Estado = attractionsDto.Estado
            };

            return attraction;
        }

        public AttractionsDto MapperEntityToDto(Attractions attractions)
        {
            var attractionsDto = new AttractionsDto()
            {
                Id = attractions.Id,
                Name = attractions.Name,
                Cidade = attractions.Cidade,
                Descricao = attractions.Descricao,
                Localizacao = attractions.Localizacao,
                Estado = attractions.Estado
            };
            return attractionsDto;
        }

       IEnumerable<AttractionsDto> IMapperAttractions.MapperListAttractionsDto(IEnumerable<AttractionsDto> attractionsDto)
        {
            var dto = attractionsDto.Select(a => new AttractionsDto
            {
                Id = a.Id,
                Name = a.Name,
                Cidade = a.Cidade,
                Descricao = a.Descricao,
                Localizacao = a.Localizacao,
                Estado = a.Estado
            });
            return dto;
        }

        IEnumerable<AttractionsDto> IMapperAttractions.MapperListAttractionsDto(IEnumerable<Attractions> attractions)
        {
            throw new NotImplementedException();
        }
    }
}