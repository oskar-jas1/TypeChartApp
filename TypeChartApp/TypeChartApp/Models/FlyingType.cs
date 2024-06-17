﻿namespace TypeChartApp.Models;

public class FlyingType : PokemonType
{
    public override PokemonTypes PokemonTypeName => PokemonTypes.Flying;

    public override Dictionary<PokemonTypes, float> AttackingMultipliers { get; } =
        new()
        {
            { PokemonTypes.Normal, 1f },
            { PokemonTypes.Fire, 1f },
            { PokemonTypes.Water, 1f },
            { PokemonTypes.Electric, 0.5f },
            { PokemonTypes.Grass, 2f },
            { PokemonTypes.Ice, 1f },
            { PokemonTypes.Fighting, 2f },
            { PokemonTypes.Poison, 1f },
            { PokemonTypes.Ground, 1f },
            { PokemonTypes.Flying, 1f },
            { PokemonTypes.Psychic, 1f },
            { PokemonTypes.Bug, 2f },
            { PokemonTypes.Rock, 0.5f },
            { PokemonTypes.Ghost, 1f },
            { PokemonTypes.Dragon, 1f },
            { PokemonTypes.Dark, 1f },
            { PokemonTypes.Steel, 0.5f },
            { PokemonTypes.Fairy, 1f }
        };

    public override Dictionary<PokemonTypes, float> DefensiveMultipliers { get; } =
        new()
        {
            { PokemonTypes.Normal, 1f },
            { PokemonTypes.Fire, 1f },
            { PokemonTypes.Water, 1f },
            { PokemonTypes.Electric, 2f },
            { PokemonTypes.Grass, 0.5f },
            { PokemonTypes.Ice, 2f },
            { PokemonTypes.Fighting, 0.5f },
            { PokemonTypes.Poison, 1f },
            { PokemonTypes.Ground, 0f },
            { PokemonTypes.Flying, 1f },
            { PokemonTypes.Psychic, 1f },
            { PokemonTypes.Bug, 0.5f },
            { PokemonTypes.Rock, 2f },
            { PokemonTypes.Ghost, 1f },
            { PokemonTypes.Dragon, 1f },
            { PokemonTypes.Dark, 1f },
            { PokemonTypes.Steel, 1f },
            { PokemonTypes.Fairy, 1f }
        };
}