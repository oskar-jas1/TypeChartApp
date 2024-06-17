using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;
using TypeChartApp.Models;

namespace TypeChartApp.Converters;

public class PokemonTypeToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value is not PokemonType pokemonType) return Brushes.White;

        return pokemonType.PokemonTypeName switch
        {
            PokemonTypes.Normal => new SolidColorBrush(Color.FromRgb(170, 170, 153)),
            PokemonTypes.Fire => new SolidColorBrush(Color.FromRgb(255, 68, 34)),
            PokemonTypes.Water => new SolidColorBrush(Color.FromRgb(51, 153, 255)),
            PokemonTypes.Electric => new SolidColorBrush(Color.FromRgb(255, 204, 51)),
            PokemonTypes.Grass => new SolidColorBrush(Color.FromRgb(119, 204, 85)),
            PokemonTypes.Ice => new SolidColorBrush(Color.FromRgb(102, 204, 255)),
            PokemonTypes.Fighting => new SolidColorBrush(Color.FromRgb(185, 84, 67)),
            PokemonTypes.Poison => new SolidColorBrush(Color.FromRgb(170, 85, 153)),
            PokemonTypes.Ground => new SolidColorBrush(Color.FromRgb(221, 187, 85)),
            PokemonTypes.Flying => new SolidColorBrush(Color.FromRgb(136, 153, 255)),
            PokemonTypes.Psychic => new SolidColorBrush(Color.FromRgb(255, 85, 153)),
            PokemonTypes.Bug => new SolidColorBrush(Color.FromRgb(161, 177, 32)),
            PokemonTypes.Rock => new SolidColorBrush(Color.FromRgb(187, 170, 102)),
            PokemonTypes.Ghost => new SolidColorBrush(Color.FromRgb(102, 102, 187)),
            PokemonTypes.Dragon => new SolidColorBrush(Color.FromRgb(119, 102, 238)),
            PokemonTypes.Dark => new SolidColorBrush(Color.FromRgb(119, 85, 68)),
            PokemonTypes.Steel => new SolidColorBrush(Color.FromRgb(170, 170, 187)),
            PokemonTypes.Fairy => new SolidColorBrush(Color.FromRgb(238, 153, 238)),
            _ => Brushes.White
        };
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}