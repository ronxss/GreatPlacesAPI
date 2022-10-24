namespace GreatPlacesAPI.Models
{
    public class Attractions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Descricao { get; set; }
        public string  Localizacao { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Attractions(int id, string name, string descricao, string localizacao, string cidade, string estado)
        {
            Id = id;
            Name = name;
            Descricao = descricao;
            Localizacao = localizacao;
            Cidade = cidade;
            Estado = estado;
        }
    }
    
}
