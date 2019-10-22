using System.Collections.Generic;

namespace PokemonApp.Domain
{
    public class Pokemon
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Note> Notes { get; set; }

        public Pokemon()
        {
            Notes = new List<Note>();
        }

        //public int BattleId { get; set; } n-n 
        public List<PokemonBattle> PokemonBattles { get; set; }

        public SecretIdentity SecretIdentity { get; set; }

    }
}
