using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AreaRectanguloApp.ViewModels;

public partial class RectanguloViewModel : ObservableObject
{
    [ObservableProperty]
    private string baseRectangulo = string.Empty;

    [ObservableProperty]
    private string altura = string.Empty;

    [ObservableProperty]
    private string resultado = "Ingrese los datos";

    [RelayCommand]
    private void CalcularArea()
    {
        bool baseValida = double.TryParse(BaseRectangulo, out double baseValor);
        bool alturaValida = double.TryParse(Altura, out double alturaValor);

        if (!baseValida || !alturaValida)
        {
            Resultado = "Ingrese valores numéricos válidos";
            return;
        }

        if (baseValor <= 0 || alturaValor <= 0)
        {
            Resultado = "Los valores deben ser mayores que cero";
            return;
        }

        double area = baseValor * alturaValor;

        Resultado = $"El área es: {area:N2}";
    }

    [RelayCommand]
    private void Limpiar()
    {
        BaseRectangulo = string.Empty;
        Altura = string.Empty;
        Resultado = "Ingrese los datos";
    }
}