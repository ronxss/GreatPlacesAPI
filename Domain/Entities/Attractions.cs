namespace GreatPlaces.Domain.Entities
{
    public class Attractions 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Localization { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Attractions(int id, string name, string descricao, string localizacao, string cidade, string estado)
        {
            Id = id;
            Name = name;
            Description = descricao;
            Localization = localizacao;
            City = cidade;
            State = estado;
        }

        public Attractions()
        {
        }
    }
}