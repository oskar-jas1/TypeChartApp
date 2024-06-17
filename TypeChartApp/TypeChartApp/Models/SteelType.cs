namespace TypeChartApp.Models;

public class SteelType : PokemonType
{
    public override PokemonTypes PokemonTypeName => PokemonTypes.Steel;

    public override Dictionary<PokemonTypes, float> AttackingMultipliers { get; } =
        new()
        {
            { PokemonTypes.Normal, 1f },
            { PokemonTypes.Fire, 0.5f },
            { PokemonTypes.Water, 0.5f },
            { PokemonTypes.Electric, 0.5f },
            { PokemonTypes.Grass, 1f },
            { PokemonTypes.Ice, 2f },
            { PokemonTypes.Fighting, 1f },
            { PokemonTypes.Poison, 1f },
            { PokemonTypes.Ground, 1f },
            { PokemonTypes.Flying, 1f },
            { PokemonTypes.Psychic, 1f },
            { PokemonTypes.Bug, 1f },
            { PokemonTypes.Rock, 2f },
            { PokemonTypes.Ghost, 1f },
            { PokemonTypes.Dragon, 1f },
            { PokemonTypes.Dark, 1f },
            { PokemonTypes.Steel, 0.5f },
            { PokemonTypes.Fairy, 2f }
        };

    public override Dictionary<PokemonTypes, float> DefensiveMultipliers { get; } =
        new()
        {
            { PokemonTypes.Normal, 0.5f },
            { PokemonTypes.Fire, 2f },
            { PokemonTypes.Water, 1f },
            { PokemonTypes.Electric, 1f },
            { PokemonTypes.Grass, 0.5f },
            { PokemonTypes.Ice, 0.5f },
            { PokemonTypes.Fighting, 2f },
            { PokemonTypes.Poison, 0f },
            { PokemonTypes.Ground, 2f },
            { PokemonTypes.Flying, 0.5f },
            { PokemonTypes.Psychic, 0.5f },
            { PokemonTypes.Bug, 0.5f },
            { PokemonTypes.Rock, 0.5f },
            { PokemonTypes.Ghost, 1f },
            { PokemonTypes.Dragon, 0.5f },
            { PokemonTypes.Dark, 1f },
            { PokemonTypes.Steel, 0.5f },
            { PokemonTypes.Fairy, 0.5f }
        };
}