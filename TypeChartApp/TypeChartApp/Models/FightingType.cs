namespace TypeChartApp.Models;

public class FightingType : PokemonType
{
    public override PokemonTypes PokemonTypeName => PokemonTypes.Fighting;

    public override Dictionary<PokemonTypes, float> AttackingMultipliers { get; } =
        new()
        {
            { PokemonTypes.Normal, 2f },
            { PokemonTypes.Fire, 1f },
            { PokemonTypes.Water, 1f },
            { PokemonTypes.Electric, 1f },
            { PokemonTypes.Grass, 1f },
            { PokemonTypes.Ice, 2f },
            { PokemonTypes.Fighting, 1f },
            { PokemonTypes.Poison, 0.5f },
            { PokemonTypes.Ground, 1f },
            { PokemonTypes.Flying, 0.5f },
            { PokemonTypes.Psychic, 0.5f },
            { PokemonTypes.Bug, 0.5f },
            { PokemonTypes.Rock, 2f },
            { PokemonTypes.Ghost, 0f },
            { PokemonTypes.Dragon, 1f },
            { PokemonTypes.Dark, 2f },
            { PokemonTypes.Steel, 2f },
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
            { PokemonTypes.Fighting, 1f },
            { PokemonTypes.Poison, 1f },
            { PokemonTypes.Ground, 1f },
            { PokemonTypes.Flying, 2f },
            { PokemonTypes.Psychic, 2f },
            { PokemonTypes.Bug, 0.5f },
            { PokemonTypes.Rock, 0.5f },
            { PokemonTypes.Ghost, 1f },
            { PokemonTypes.Dragon, 1f },
            { PokemonTypes.Dark, 0.5f },
            { PokemonTypes.Steel, 1f },
            { PokemonTypes.Fairy, 2f }
        };
}