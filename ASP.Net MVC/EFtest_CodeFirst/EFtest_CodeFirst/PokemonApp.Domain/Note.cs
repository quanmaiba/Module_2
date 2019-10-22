namespace PokemonApp.Domain
{
    public class Note
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Pokemon Pokemon { get; set; }
        public int PokemonId { get; set; }
    }
}
