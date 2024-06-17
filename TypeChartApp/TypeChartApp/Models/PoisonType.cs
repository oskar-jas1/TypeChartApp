namespace TypeChartApp.Models;

public class PoisonType : PokemonType
{
    public override PokemonTypes PokemonTypeName => PokemonTypes.Poison;

    public override Dictionary<PokemonTypes, float> AttackingMultipliers { get; } =
        new()
        {
            { PokemonTypes.Normal, 1f },
            { PokemonTypes.Fire, 1f },
            { PokemonTypes.Water, 1f },
            { PokemonTypes.Electric, 1f },
            { PokemonTypes.Grass, 2f },
            { PokemonTypes.Ice, 1f },
            { PokemonTypes.Fighting, 1f },
            { PokemonTypes.Poison, 0.5f },
            { PokemonTypes.Ground, 0.5f },
            { PokemonTypes.Flying, 1f },
            { PokemonTypes.Psychic, 1f },
            { PokemonTypes.Bug, 1f },
            { PokemonTypes.Rock, 0.5f },
            { PokemonTypes.Ghost, 0.5f },
            { PokemonTypes.Dragon, 1f },
            { PokemonTypes.Dark, 1f },
            { PokemonTypes.Steel, 0f },
            { PokemonTypes.Fairy, 2f }
        };

    public override Dictionary<PokemonTypes, float> DefensiveMultipliers { get; } =
        new()
        {
            { PokemonTypes.Normal, 1f },
            { PokemonTypes.Fire, 1f },
            { PokemonTypes.Water, 1f },
            { PokemonTypes.Electric, 1f },
            { PokemonTypes.Grass, 0.5f },
            { PokemonTypes.Ice, 1f },
            { PokemonTypes.Fighting, 0.5f },
            { PokemonTypes.Poison, 0.5f },
            { PokemonTypes.Ground, 2f },
            { PokemonTypes.Flying, 1f },
            { PokemonTypes.Psychic, 2f },
            { PokemonTypes.Bug, 0.5f },
            { PokemonTypes.Rock, 1f },
            { PokemonTypes.Ghost, 1f },
            { PokemonTypes.Dragon, 1f },
            { PokemonTypes.Dark, 1f },
            { PokemonTypes.Steel, 1f },
            { PokemonTypes.Fairy, 0.5f }
        };
}