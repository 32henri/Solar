using TARpe22MauiPlanets.Models;
using TARpe22MauiPlanets.Services;
using Views;

namespace TARpe22MauiPlanets.Views;

public partial class PlanetsPage : ContentPage
{
    private const uint AnimationDuration = 800u;

    public PlanetsPage()
    {
        InitializeComponent();

        ListPopularPlanets.ItemsSource = PlanetsService.GetFeaturedPlanets();
        ListAllPlanets.ItemsSource = PlanetsService.GetAllPlanets();
    }

    async void GridArea_Tapped(System.Object sender, System.EventArgs e)
    {

    }

    private void ApiPic_Clicked(System.Object sender, System.EventArgs e)
    {

    }
    async void ProfilePic_Clicked(System.Object sender, System.EventArgs e)
    {
        // Reveal our menu and move the main content out of the view
        _ = MainContentGrid.TranslateTo(-this.Width * 0.5, this.Height * 0.1, AnimationDuration, Easing.CubicIn);
        await MainContentGrid.ScaleTo(0.8, AnimationDuration);
        _ = MainContentGrid.FadeTo(0.8, AnimationDuration);
    }

    async void Planets_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        await Navigation.PushAsync(new PlanetDetailsPage(e.CurrentSelection.First() as Planet));
    }

    private void ListAllPlanets_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{

	}
}