﻿using System;
using System.Collections.Generic;

namespace PokemonApp.Domain
{
    public class Battle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        //public List<Pokemon> Pokemons { get; set; }
        public List<PokemonBattle> PokemonBattles { get; set; }
    }
}
