namespace TypeChartApp.Models;

public class GrassType : PokemonType
{
    public override PokemonTypes PokemonTypeName => PokemonTypes.Grass;

    public override Dictionary<PokemonTypes, float> AttackingMultipliers { get; } =
        new()
        {
            { PokemonTypes.Normal, 1f },
            { PokemonTypes.Fire, 0.5f },
            { PokemonTypes.Water, 2f },
            { PokemonTypes.Electric, 1f },
            { PokemonTypes.Grass, 0.5f },
            { PokemonTypes.Ice, 1f },
            { PokemonTypes.Fighting, 1f },
            { PokemonTypes.Poison, 0.5f },
            { PokemonTypes.Ground, 2f },
            { PokemonTypes.Flying, 0.5f },
            { PokemonTypes.Psychic, 1f },
            { PokemonTypes.Bug, 0.5f },
            { PokemonTypes.Rock, 2f },
            { PokemonTypes.Ghost, 1f },
            { PokemonTypes.Dragon, 0.5f },
            { PokemonTypes.Dark, 1f },
            { PokemonTypes.Steel, 0.5f },
            { PokemonTypes.Fairy, 1f }
        };

    public override Dictionary<PokemonTypes, float> DefensiveMultipliers { get; } =
        new()
        {
            { PokemonTypes.Normal, 1f },
            { PokemonTypes.Fire, 2f },
            { PokemonTypes.Water, 0.5f },
            { PokemonTypes.Electric, 0.5f },
            { PokemonTypes.Grass, 0.5f },
            { PokemonTypes.Ice, 2f },
            { PokemonTypes.Fighting, 1f },
            { PokemonTypes.Poison, 2f },
            { PokemonTypes.Ground, 0.5f },
            { PokemonTypes.Flying, 2f },
            { PokemonTypes.Psychic, 1f },
            { PokemonTypes.Bug, 2f },
            { PokemonTypes.Rock, 1f },
            { PokemonTypes.Ghost, 1f },
            { PokemonTypes.Dragon, 1f },
            { PokemonTypes.Dark, 1f },
            { PokemonTypes.Steel, 1f },
            { PokemonTypes.Fairy, 1f }
        };
}