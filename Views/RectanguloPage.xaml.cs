using AreaRectanguloApp.ViewModels;

namespace AreaRectanguloApp.Views;

public partial class RectanguloPage : ContentPage
{
    public RectanguloPage(RectanguloViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}