namespace Herramientas_IA_en_el_aula;

public partial class Page4 : ContentPage
{
	public Page4()
	{
		InitializeComponent();
	}

    private void Page3(object sender, EventArgs e)
    {
        App.flyoutPage.Detail.Navigation.PushAsync(new Page3());
        App.flyoutPage.IsPresented = false;
    }

    private void Page5(object sender, EventArgs e)
    {
        App.flyoutPage.Detail.Navigation.PushAsync(new Page5());
        App.flyoutPage.IsPresented = false;
    }
}