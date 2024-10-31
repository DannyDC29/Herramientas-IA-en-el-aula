namespace Herramientas_IA_en_el_aula;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}
    private void Page1(object sender, EventArgs e)
    {
        App.flyoutPage.Detail.Navigation.PushAsync(new Page1());
        App.flyoutPage.IsPresented = false;
    }

    private void Page3(object sender, EventArgs e)
    {
        App.flyoutPage.Detail.Navigation.PushAsync(new Page3());
        App.flyoutPage.IsPresented = false;
    }
}