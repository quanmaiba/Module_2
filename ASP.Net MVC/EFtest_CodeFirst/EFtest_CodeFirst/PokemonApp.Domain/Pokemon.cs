using System.Collections.Generic;

namespace PokemonApp.Domain
{
    public class Pokemon
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Note> Notes { get; set; }
        public Pokemon()
        {
            Notes = new List<Note>();
        }
        //public int BattleId { get; set; }

        public List<PokemonBattle> PokemonBattles { get; set; }

        public SecretDentity SecretDentity { get; set; }
    }
}
