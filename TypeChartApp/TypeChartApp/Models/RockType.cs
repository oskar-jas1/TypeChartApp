namespace TypeChartApp.Models;

public class RockType : PokemonType
{
    public override PokemonTypes PokemonTypeName => PokemonTypes.Rock;

    public override Dictionary<PokemonTypes, float> AttackingMultipliers { get; } =
        new()
        {
            { PokemonTypes.Normal, 1f },
            { PokemonTypes.Fire, 2f },
            { PokemonTypes.Water, 1f },
            { PokemonTypes.Electric, 1f },
            { PokemonTypes.Grass, 1f },
            { PokemonTypes.Ice, 2f },
            { PokemonTypes.Fighting, 0.5f },
            { PokemonTypes.Poison, 1f },
            { PokemonTypes.Ground, 0.5f },
            { PokemonTypes.Flying, 2f },
            { PokemonTypes.Psychic, 1f },
            { PokemonTypes.Bug, 2f },
            { PokemonTypes.Rock, 1f },
            { PokemonTypes.Ghost, 1f },
            { PokemonTypes.Dragon, 1f },
            { PokemonTypes.Dark, 1f },
            { PokemonTypes.Steel, 0.5f },
            { PokemonTypes.Fairy, 1f }
        };

    public override Dictionary<PokemonTypes, float> DefensiveMultipliers { get; } =
        new()
        {
            { PokemonTypes.Normal, 0.5f },
            { PokemonTypes.Fire, 0.5f },
            { PokemonTypes.Water, 2f },
            { PokemonTypes.Electric, 1f },
            { PokemonTypes.Grass, 2f },
            { PokemonTypes.Ice, 1f },
            { PokemonTypes.Fighting, 2f },
            { PokemonTypes.Poison, 0.5f },
            { PokemonTypes.Ground, 2f },
            { PokemonTypes.Flying, 0.5f },
            { PokemonTypes.Psychic, 1f },
            { PokemonTypes.Bug, 1f },
            { PokemonTypes.Rock, 1f },
            { PokemonTypes.Ghost, 1f },
            { PokemonTypes.Dragon, 1f },
            { PokemonTypes.Dark, 1f },
            { PokemonTypes.Steel, 2f },
            { PokemonTypes.Fairy, 1f }
        };
}