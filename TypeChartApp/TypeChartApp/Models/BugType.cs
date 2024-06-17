namespace TypeChartApp.Models;

public class BugType : PokemonType
{
    public override PokemonTypes PokemonTypeName => PokemonTypes.Bug;

    public override Dictionary<PokemonTypes, float> AttackingMultipliers { get; } =
        new()
        {
            { PokemonTypes.Normal, 1f },
            { PokemonTypes.Fire, 0.5f },
            { PokemonTypes.Water, 1f },
            { PokemonTypes.Electric, 1f },
            { PokemonTypes.Grass, 2f },
            { PokemonTypes.Ice, 1f },
            { PokemonTypes.Fighting, 0.5f },
            { PokemonTypes.Poison, 0.5f },
            { PokemonTypes.Ground, 1f },
            { PokemonTypes.Flying, 0.5f },
            { PokemonTypes.Psychic, 2f },
            { PokemonTypes.Bug, 1f },
            { PokemonTypes.Rock, 1f },
            { PokemonTypes.Ghost, 0.5f },
            { PokemonTypes.Dragon, 1f },
            { PokemonTypes.Dark, 2f },
            { PokemonTypes.Steel, 0.5f },
            { PokemonTypes.Fairy, 0.5f }
        };

    public override Dictionary<PokemonTypes, float> DefensiveMultipliers { get; } =
        new()
        {
            { PokemonTypes.Normal, 1f },
            { PokemonTypes.Fire, 2f },
            { PokemonTypes.Water, 1f },
            { PokemonTypes.Electric, 1f },
            { PokemonTypes.Grass, 0.5f },
            { PokemonTypes.Ice, 1f },
            { PokemonTypes.Fighting, 0.5f },
            { PokemonTypes.Poison, 1f },
            { PokemonTypes.Ground, 0.5f },
            { PokemonTypes.Flying, 2f },
            { PokemonTypes.Psychic, 1f },
            { PokemonTypes.Bug, 1f },
            { PokemonTypes.Rock, 2f },
            { PokemonTypes.Ghost, 1f },
            { PokemonTypes.Dragon, 1f },
            { PokemonTypes.Dark, 1f },
            { PokemonTypes.Steel, 1f },
            { PokemonTypes.Fairy, 1f }
        };
}