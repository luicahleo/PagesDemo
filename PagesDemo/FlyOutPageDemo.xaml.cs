namespace PagesDemo;

public partial class FlyOutPageDemo : FlyoutPage
{
    public FlyOutPageDemo()
    {
        InitializeComponent();
    }

    private async void OnOption1Clicked(object sender, EventArgs e)
    {
        var navigationPage = Detail as NavigationPage;
        await navigationPage.PushAsync(new ContentPage
        {
            Title = "Opción 1",
            Content = new Label
            {
                Text = "Contenido de la Opción 1",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }
        });
        IsPresented = false; // Cierra el menú después de seleccionar
    }

    private async void OnOption2Clicked(object sender, EventArgs e)
    {
        var navigationPage = Detail as NavigationPage;
        await navigationPage.PushAsync(new ContentPage
        {
            Title = "Opción 2",
            Content = new Label
            {
                Text = "Contenido de la Opción 2",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            }
        });
        IsPresented = false;
    }
}