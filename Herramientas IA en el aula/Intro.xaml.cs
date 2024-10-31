namespace Herramientas_IA_en_el_aula;

public partial class Intro : ContentPage
{
	public Intro()
	{
		InitializeComponent();
	}
    private void Page1(object sender, EventArgs e)
    {
        App.flyoutPage.Detail.Navigation.PushAsync(new Page1());
        App.flyoutPage.IsPresented = false;
    }

    private void menu(object sender, EventArgs e)
    {
        App.flyoutPage.Detail.Navigation.PushAsync(new Menu());
        App.flyoutPage.IsPresented = false;
    }
}