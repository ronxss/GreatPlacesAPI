using GreatPlaces.Domain.Core.Interfaces.Repositories;
using GreatPlaces.Domain.Entities;

namespace GreatPlaces.Infrastructure.Data.Repositories
{
    public class RepositoryAttractions : RepositoryBase<Attractions>, IRepositoryAttractions
    {
        private readonly SqlContext _context;

        public RepositoryAttractions(SqlContext sqlContext) : base(sqlContext)
        {
            _context = sqlContext;
        }
    }
}