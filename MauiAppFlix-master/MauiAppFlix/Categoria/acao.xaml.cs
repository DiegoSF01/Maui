namespace MauiAppFlix;

public partial class acao : ContentPage
{
	public acao()
	{
		InitializeComponent();
	}

    private void btnjurassic_park_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.acao.jurassic_park());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnkarate_kid_Clicked(Object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.acao.karate_kid());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnvelozes_e_furiosos_Clicked(Object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.acao.velozes_e_furiosos());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btnvingadores_ultimato_Clicked(Object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.acao.vingadores_ultimato());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}