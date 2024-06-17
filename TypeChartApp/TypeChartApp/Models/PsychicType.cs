namespace TypeChartApp.Models;

public class PsychicType : PokemonType
{
    public override PokemonTypes PokemonTypeName => PokemonTypes.Psychic;

    public override Dictionary<PokemonTypes, float> AttackingMultipliers { get; } =
        new()
        {
            { PokemonTypes.Normal, 1f },
            { PokemonTypes.Fire, 1f },
            { PokemonTypes.Water, 1f },
            { PokemonTypes.Electric, 1f },
            { PokemonTypes.Grass, 1f },
            { PokemonTypes.Ice, 1f },
            { PokemonTypes.Fighting, 2f },
            { PokemonTypes.Poison, 2f },
            { PokemonTypes.Ground, 1f },
            { PokemonTypes.Flying, 1f },
            { PokemonTypes.Psychic, 0.5f },
            { PokemonTypes.Bug, 1f },
            { PokemonTypes.Rock, 1f },
            { PokemonTypes.Ghost, 1f },
            { PokemonTypes.Dragon, 1f },
            { PokemonTypes.Dark, 0f },
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
            { PokemonTypes.Poison, 1f },
            { PokemonTypes.Ground, 1f },
            { PokemonTypes.Flying, 1f },
            { PokemonTypes.Psychic, 0.5f },
            { PokemonTypes.Bug, 2f },
            { PokemonTypes.Rock, 1f },
            { PokemonTypes.Ghost, 2f },
            { PokemonTypes.Dragon, 1f },
            { PokemonTypes.Dark, 2f },
            { PokemonTypes.Steel, 1f },
            { PokemonTypes.Fairy, 1f }
        };
}