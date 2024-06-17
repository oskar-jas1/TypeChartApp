namespace TypeChartApp.Models;

public class DarkType : PokemonType
{
    public override PokemonTypes PokemonTypeName => PokemonTypes.Dark;

    public override Dictionary<PokemonTypes, float> AttackingMultipliers { get; } =
        new()
        {
            { PokemonTypes.Normal, 1f },
            { PokemonTypes.Fire, 1f },
            { PokemonTypes.Water, 1f },
            { PokemonTypes.Electric, 1f },
            { PokemonTypes.Grass, 1f },
            { PokemonTypes.Ice, 1f },
            { PokemonTypes.Fighting, 0.5f },
            { PokemonTypes.Poison, 1f },
            { PokemonTypes.Ground, 1f },
            { PokemonTypes.Flying, 1f },
            { PokemonTypes.Psychic, 2f },
            { PokemonTypes.Bug, 1f },
            { PokemonTypes.Rock, 1f },
            { PokemonTypes.Ghost, 2f },
            { PokemonTypes.Dragon, 1f },
            { PokemonTypes.Dark, 0.5f },
            { PokemonTypes.Steel, 1f },
            { PokemonTypes.Fairy, 0.5f }
        };

    public override Dictionary<PokemonTypes, float> DefensiveMultipliers { get; } =
        new()
        {
            { PokemonTypes.Normal, 1f },
            { PokemonTypes.Fire, 1f },
            { PokemonTypes.Water, 1f },
            { PokemonTypes.Electric, 1f },
            { PokemonTypes.Grass, 1f },
            { PokemonTypes.Ice, 1f },
            { PokemonTypes.Fighting, 2f },
            { PokemonTypes.Poison, 1f },
            { PokemonTypes.Ground, 1f },
            { PokemonTypes.Flying, 1f },
            { PokemonTypes.Psychic, 0f },
            { PokemonTypes.Bug, 2f },
            { PokemonTypes.Rock, 1f },
            { PokemonTypes.Ghost, 0.5f },
            { PokemonTypes.Dragon, 1f },
            { PokemonTypes.Dark, 0.5f },
            { PokemonTypes.Steel, 1f },
            { PokemonTypes.Fairy, 2f }
        };
}