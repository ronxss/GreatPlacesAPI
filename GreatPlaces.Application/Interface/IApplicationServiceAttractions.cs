using GreatPlaces.Application.Dto;

namespace GreatPlaces.Application.Interface
{
    public interface IApplicationServiceAttractions
    {
        void Add(AttractionsDto attractionsDto);

        void Update(AttractionsDto attractionsDto);

        void Remove(AttractionsDto attractionsDto);

        IEnumerable<AttractionsDto> GetAll();

        AttractionsDto GetById(int id);
    }
}