namespace TypeChartApp.Models;

public abstract class PokemonType
{
    public abstract PokemonTypes PokemonTypeName { get; }

    public abstract Dictionary<PokemonTypes, float> AttackingMultipliers { get; }
    public abstract Dictionary<PokemonTypes, float> DefensiveMultipliers { get; }
}