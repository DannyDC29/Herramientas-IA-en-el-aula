namespace Herramientas_IA_en_el_aula;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}
    private void Page2(object sender, EventArgs e)
    {
        App.flyoutPage.Detail.Navigation.PushAsync(new Page2());
        App.flyoutPage.IsPresented = false;
    }

    private void Page4(object sender, EventArgs e)
    {
        App.flyoutPage.Detail.Navigation.PushAsync(new Page4());
        App.flyoutPage.IsPresented = false;
    }
}