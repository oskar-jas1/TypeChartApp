using System.Collections.ObjectModel;
using TypeChartApp.Models;

namespace TypeChartApp.ViewModels;

public class DefendingTypeViewModel : BaseViewModel
{
    private ObservableCollection<PokemonTypes> _noEffect;
    private ObservableCollection<PokemonTypes> _notEffective;
    private ObservableCollection<PokemonTypes> _standardEffective;
    private ObservableCollection<PokemonTypes> _superEffective;
    private ObservableCollection<PokemonType> _availableTypes;
    private ObservableCollection<PokemonTypes> _veryNotEffective;
    private ObservableCollection<PokemonTypes> _verySuperEffective;

    private PokemonType _selectedType1;
    private PokemonType _selectedType2;

    public DefendingTypeViewModel()
    {
        NoEffect = [];
        VeryNotEffective = [];
        NotEffective = [];
        StandardEffective = [];
        SuperEffective = [];
        VerySuperEffective = [];

        AvailableTypes =
        [
            new NoneType(), new NormalType(), new FireType(), new WaterType(), new ElectricType(), new GrassType(),
            new IceType(), new FightingType(), new PoisonType(), new GroundType(), new FlyingType(), new PsychicType(),
            new BugType(), new RockType(), new GhostType(), new DragonType(), new DarkType(), new SteelType(),
            new FairyType()
        ];

        SelectedType1 = AvailableTypes[0];
        SelectedType2 = AvailableTypes[0];
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
            CalculateDefensiveMultipliers();
        }
    }

    public PokemonType SelectedType2
    {
        get => _selectedType2;
        set
        {
            _selectedType2 = value;
            OnPropertyChanged(nameof(SelectedType2));
            CalculateDefensiveMultipliers();
        }
    }

    private void CalculateDefensiveMultipliers()
    {
        NoEffect.Clear();
        VeryNotEffective.Clear();
        NotEffective.Clear();
        StandardEffective.Clear();
        SuperEffective.Clear();
        VerySuperEffective.Clear();

        if (_selectedType1 == null || _selectedType2 == null) return;

        var defensiveMultipliers1 = _selectedType1.DefensiveMultipliers;
        var defensiveMultipliers2 = _selectedType2.DefensiveMultipliers;

        foreach (var pokemonType in defensiveMultipliers1.Keys)
        {
            defensiveMultipliers1.TryGetValue(pokemonType, out var multiplier1);
            defensiveMultipliers2.TryGetValue(pokemonType, out var multiplier2);

            var multiplier = multiplier1 * multiplier2;

            switch (multiplier)
            {
                case 0f:
                    {
                        NoEffect.Add(pokemonType);
                        break;
                    }
                case 0.25f:
                    {
                        VeryNotEffective.Add(pokemonType);
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
                case 4f:
                    {
                        VerySuperEffective.Add(pokemonType);
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

    public ObservableCollection<PokemonTypes> VeryNotEffective
    {
        get => _veryNotEffective;
        set
        {
            _veryNotEffective = value;
            OnPropertyChanged(nameof(VeryNotEffective));
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

    public ObservableCollection<PokemonTypes> VerySuperEffective
    {
        get => _verySuperEffective;
        set
        {
            _verySuperEffective = value;
            OnPropertyChanged(nameof(VerySuperEffective));
        }
    }
}