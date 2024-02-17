using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    internal class PokemonDetailsResult{
        public List<AbilityDetail>? Abilities { get; set; }
        public string? Name { get; set; }
        public int Order { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public List<TypeDetail>? Types { get; set; }
    }

    public class AbilityDetail{
        public Ability? Ability { get; set; }
        public bool IsHidden { get; set; }
        public int Slot { get; set; }
    }

    public class Ability{
        public string? Name { get; set; }
        public string? Url { get; set; }
    }

    public class TypeDetail{
        public Type? Type { get; set; }

        public int Slot { get; set; }

    }

    public class Type{
        public string? Name { get; set; }
        public string? Url { get; set; }
    }
}