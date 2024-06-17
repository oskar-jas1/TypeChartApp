using System.Collections.ObjectModel;
using TypeChartApp.Models;

namespace TypeChartApp.ViewModels;

public class AttackingTypeViewModel : BaseViewModel
{
    private ObservableCollection<PokemonTypes> _noEffect;
    private ObservableCollection<PokemonTypes> _notEffective;
    private ObservableCollection<PokemonTypes> _standardEffective;
    private ObservableCollection<PokemonTypes> _superEffective;
    private ObservableCollection<PokemonType> _availableTypes;

    private PokemonType _selectedType;

    public AttackingTypeViewModel()
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

        SelectedType = AvailableTypes[0];
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

    public PokemonType SelectedType
    {
        get => _selectedType;
        set
        {
            _selectedType = value;
            OnPropertyChanged(nameof(SelectedType));

            NoEffect.Clear();
            NotEffective.Clear();
            StandardEffective.Clear();
            SuperEffective.Clear();

            var attackingMultipliers = _selectedType.AttackingMultipliers;

            foreach (var pokemonType in attackingMultipliers.Keys)
            {
                attackingMultipliers.TryGetValue(pokemonType, out var multiplier);

                switch (multiplier)
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