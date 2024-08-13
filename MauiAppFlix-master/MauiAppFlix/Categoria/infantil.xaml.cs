namespace MauiAppFlix.Categoria;

public partial class infantil : ContentPage
{
	public infantil()
	{
		InitializeComponent();
	}

    private void btno_bom_dinossauro_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.infantil.o_bom_dinossauro());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btno_espanta_tubaroes_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.infantil.o_espanta_tubaroes());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }


    private void btnmarley_e_eu_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.infantil.marley_e_eu());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void btno_menino_do_pijama_listrado_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PushAsync(new Filmes.infantil.o_menino_do_pijama_listrado());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}