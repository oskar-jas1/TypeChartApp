namespace TypeChartApp.ViewModels;

public class MainViewModel : BaseViewModel
{
    public AttackingTypeViewModel AttackingTypeViewModel { get; set; } = new();
    public DefendingTypeViewModel DefendingTypeViewModel { get; set; } = new();
    public TypeCoverageViewModel TypeCoverageViewModel { get; set; } = new();
}