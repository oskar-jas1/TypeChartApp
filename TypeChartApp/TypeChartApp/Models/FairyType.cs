namespace TypeChartApp.Models;

public class FairyType : PokemonType
{
    public override PokemonTypes PokemonTypeName => PokemonTypes.Fairy;

    public override Dictionary<PokemonTypes, float> AttackingMultipliers { get; } =
        new()
        {
            { PokemonTypes.Normal, 1f },
            { PokemonTypes.Fire, 0.5f },
            { PokemonTypes.Water, 1f },
            { PokemonTypes.Electric, 1f },
            { PokemonTypes.Grass, 1f },
            { PokemonTypes.Ice, 1f },
            { PokemonTypes.Fighting, 2f },
            { PokemonTypes.Poison, 0.5f },
            { PokemonTypes.Ground, 1f },
            { PokemonTypes.Flying, 1f },
            { PokemonTypes.Psychic, 1f },
            { PokemonTypes.Bug, 1f },
            { PokemonTypes.Rock, 1f },
            { PokemonTypes.Ghost, 1f },
            { PokemonTypes.Dragon, 2f },
            { PokemonTypes.Dark, 2f },
            { PokemonTypes.Steel, 0.5f },
            { PokemonTypes.Fairy, 1f }
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
            { PokemonTypes.Fighting, 0.5f },
            { PokemonTypes.Poison, 2f },
            { PokemonTypes.Ground, 1f },
            { PokemonTypes.Flying, 1f },
            { PokemonTypes.Psychic, 1f },
            { PokemonTypes.Bug, 0.5f },
            { PokemonTypes.Rock, 1f },
            { PokemonTypes.Ghost, 1f },
            { PokemonTypes.Dragon, 0f },
            { PokemonTypes.Dark, 0.5f },
            { PokemonTypes.Steel, 2f },
            { PokemonTypes.Fairy, 1f }
        };
}