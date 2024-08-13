using MauiAppFlix.Categoria;

namespace MauiAppFlix;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void acao_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new acao());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void animacao_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new animacao());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void aventura_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new aventura());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void comedia_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new comedia());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void documentario_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new documentario());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void drama_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new drama());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void ficcao_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new ficcao());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void guerra_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new guerra());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void infantil_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new infantil());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void nacional_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new nacional());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void romance_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new romance());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }

    private void suspense_Clicked(System.Object sender, System.EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new suspense());
        }
        catch (Exception ex)
        {
            DisplayAlert("OPS!!", ex.Message, "OK");
        }
    }
}