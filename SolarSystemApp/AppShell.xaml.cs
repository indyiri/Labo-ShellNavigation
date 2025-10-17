namespace SolarSystemApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        
		//Deze lijn code registreert de hiërarchie in de shell
		Routing.RegisterRoute(nameof(AstronomicalBodyPage), typeof(AstronomicalBodyPage));
    }
}
