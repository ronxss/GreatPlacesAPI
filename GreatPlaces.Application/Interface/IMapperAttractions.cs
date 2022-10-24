using GreatPlaces.Application.Dto;
using GreatPlaces.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatPlaces.Application.Interface
{
    public interface IMapperAttractions
    {
        Attractions MapperDtoToEntity(AttractionsDto attractionsDto);

        IEnumerable<AttractionsDto> MapperListAttractionsDto(IEnumerable<Attractions> attractions);
        AttractionsDto MapperEntityToDto(Attractions attractions);
        IEnumerable<AttractionsDto> MapperListAttractionsDto(IEnumerable<AttractionsDto> attractionsDto);
    }
}
