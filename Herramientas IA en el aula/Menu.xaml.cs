namespace Herramientas_IA_en_el_aula;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}
    private void Intro(object sender, EventArgs e)
    {
        App.flyoutPage.Detail.Navigation.PushAsync(new Intro());
        App.flyoutPage.IsPresented = false;
    }
}