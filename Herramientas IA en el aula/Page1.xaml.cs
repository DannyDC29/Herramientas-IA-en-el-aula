namespace Herramientas_IA_en_el_aula;

public partial class Page1 : ContentPage
{
	public Page1()
	{
		InitializeComponent();
	}

    private void Page2(object sender, EventArgs e)
    {
        App.flyoutPage.Detail.Navigation.PushAsync(new Page2());
        App.flyoutPage.IsPresented = false;
    }

    private void Intro(object sender, EventArgs e)
    {
        App.flyoutPage.Detail.Navigation.PushAsync(new Intro());
        App.flyoutPage.IsPresented = false;
    }
}