using Microsoft.Maui.Controls;
namespace SolarSystemApp.Pages;

public partial class AstronomicalBodiesPage : ContentPage
{
	public AstronomicalBodiesPage()
	{
		InitializeComponent();
    }

    private void EarthClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"{nameof(AstronomicalBodyPage)}?astro=earth");
    }

    private void MoonClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"{nameof(AstronomicalBodyPage)}?astro=moon");
    }

    private void SunClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"{nameof(AstronomicalBodyPage)}?astro=sun");
    }

    private void CometClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"{nameof(AstronomicalBodyPage)}?astro=comet");
    }
}