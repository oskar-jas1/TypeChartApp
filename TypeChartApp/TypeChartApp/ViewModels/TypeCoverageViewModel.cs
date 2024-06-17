using System.Collections.ObjectModel;
using TypeChartApp.Models;

namespace TypeChartApp.ViewModels;

public class TypeCoverageViewModel : BaseViewModel
{
    private ObservableCollection<PokemonTypes> _noEffect;
    private ObservableCollection<PokemonTypes> _notEffective;
    private ObservableCollection<PokemonTypes> _standardEffective;
    private ObservableCollection<PokemonTypes> _superEffective;
    private ObservableCollection<PokemonType> _availableTypes;

    private PokemonType _selectedType1;
    private PokemonType _selectedType2;
    private PokemonType _selectedType3;
    private PokemonType _selectedType4;
    public TypeCoverageViewModel()
    {
        NoEffect = [];
        NotEffective = [];
        StandardEffective = [];
        SuperEffective = [];

        AvailableTypes =
        [
            new NoneType(), new NormalType(), new FireType(), new WaterType(), new ElectricType(), new GrassType(),
            new IceType(), new FightingType(), new PoisonType(), new GroundType(), new FlyingType(), new PsychicType(),
            new BugType(), new RockType(), new GhostType(), new DragonType(), new DarkType(), new SteelType(),
            new FairyType()
        ];

        SelectedType1 = AvailableTypes[0];
        SelectedType2 = AvailableTypes[0];
        SelectedType3 = AvailableTypes[0];
        SelectedType4 = AvailableTypes[0];
    }
    public ObservableCollection<PokemonType> AvailableTypes
    {
        get => _availableTypes;
        set
        {
            _availableTypes = value;
            OnPropertyChanged(nameof(AvailableTypes));
        }
    }

    public PokemonType SelectedType1
    {
        get => _selectedType1;
        set
        {
            _selectedType1 = value;
            OnPropertyChanged(nameof(SelectedType1));
            CalculateTypeCoverage();
        }
    }

    public PokemonType SelectedType2
    {
        get => _selectedType2;
        set
        {
            _selectedType2 = value;
            OnPropertyChanged(nameof(SelectedType2));
            CalculateTypeCoverage();
        }
    }

    public PokemonType SelectedType3
    {
        get => _selectedType3;
        set
        {
            _selectedType3 = value;
            OnPropertyChanged(nameof(SelectedType3));
            CalculateTypeCoverage();
        }
    }

    public PokemonType SelectedType4
    {
        get => _selectedType4;
        set
        {
            _selectedType4 = value;
            OnPropertyChanged(nameof(SelectedType4));
            CalculateTypeCoverage();
        }
    }

    private void CalculateTypeCoverage()
    {
        NoEffect.Clear();
        NotEffective.Clear();
        StandardEffective.Clear();
        SuperEffective.Clear();

        if (_selectedType1 == null || _selectedType2 == null || _selectedType3 == null || _selectedType4 == null) return;

        var attackingMultipliers1 = _selectedType1.AttackingMultipliers;
        var attackingMultipliers2 = _selectedType2.AttackingMultipliers;
        var attackingMultipliers3 = _selectedType3.AttackingMultipliers;
        var attackingMultipliers4 = _selectedType4.AttackingMultipliers;

        foreach (var pokemonType in attackingMultipliers1.Keys)
        {
            var multiplier1 = 0f;
            var multiplier2 = 0f;
            var multiplier3 = 0f;
            var multiplier4 = 0f;

            if (_selectedType1.PokemonTypeName != PokemonTypes.None)
                attackingMultipliers1.TryGetValue(pokemonType, out multiplier1);
            
            if (_selectedType2.PokemonTypeName != PokemonTypes.None)
                attackingMultipliers2.TryGetValue(pokemonType, out multiplier2);

            if (_selectedType3.PokemonTypeName != PokemonTypes.None)
                attackingMultipliers3.TryGetValue(pokemonType, out multiplier3);

            if (_selectedType4.PokemonTypeName != PokemonTypes.None)
                attackingMultipliers4.TryGetValue(pokemonType, out multiplier4);

            SortedSet<float> multipliers = [multiplier1, multiplier2, multiplier3, multiplier4];

            var bestMultiplier = multipliers.Max;

            switch (bestMultiplier)
            {
                case 0f:
                {
                    NoEffect.Add(pokemonType);
                    break;
                }
                case 0.5f:
                {
                    NotEffective.Add(pokemonType);
                    break;
                }
                case 1f:
                {
                    StandardEffective.Add(pokemonType);
                    break;
                }
                case 2f:
                {
                    SuperEffective.Add(pokemonType);
                    break;
                }
            }
        }
    }

    public ObservableCollection<PokemonTypes> NoEffect
    {
        get => _noEffect;
        set
        {
            _noEffect = value;
            OnPropertyChanged(nameof(NoEffect));
        }
    }

    public ObservableCollection<PokemonTypes> NotEffective
    {
        get => _notEffective;
        set
        {
            _notEffective = value;
            OnPropertyChanged(nameof(NotEffective));
        }
    }

    public ObservableCollection<PokemonTypes> StandardEffective
    {
        get => _standardEffective;
        set
        {
            _standardEffective = value;
            OnPropertyChanged(nameof(StandardEffective));
        }
    }

    public ObservableCollection<PokemonTypes> SuperEffective
    {
        get => _superEffective;
        set
        {
            _superEffective = value;
            OnPropertyChanged(nameof(SuperEffective));
        }
    }
}