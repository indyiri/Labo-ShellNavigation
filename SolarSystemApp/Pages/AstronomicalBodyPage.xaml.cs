using Microsoft.Maui.Controls;
namespace SolarSystemApp.Pages;

[QueryProperty(nameof(AstroName), "astro")]
public partial class AstronomicalBodyPage : ContentPage
{
    /* ToDo: Add code to receive data from the queryparameter
     * don't forget to call UpdateAstroBodyUI with the name that was passed. */

    public AstronomicalBodyPage()
    {
        InitializeComponent();
    }


    private string _astroName = string.Empty;
    public string AstroName
    {
        get => _astroName;
        set
        {
            _astroName = value;
            if (!string.IsNullOrWhiteSpace(_astroName))
                UpdateAstroBodyUI(_astroName.ToLowerInvariant());
        }
    }

    void UpdateAstroBodyUI(string astroName)
    {
        AstronomicalBody body = FindAstroData(astroName);

        Title = body.Name;

        lblIcon.Text = body.EmojiIcon;
        lblName.Text = body.Name;
        lblMass.Text = body.Mass;
        lblCircumference.Text = body.Circumference;
        lblAge.Text = body.Age;
    }

    AstronomicalBody FindAstroData(string astronomicalBodyName)
    {
        return astronomicalBodyName switch
        {
            "comet" => SolarSystemData.HalleysComet,
            "earth" => SolarSystemData.Earth,
            "moon" => SolarSystemData.Moon,
            "sun" => SolarSystemData.Sun,
            _ => throw new ArgumentException()
        };
    }
}