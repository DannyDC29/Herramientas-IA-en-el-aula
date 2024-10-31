namespace Herramientas_IA_en_el_aula;

public partial class Page5 : ContentPage
{
	public Page5()
	{
		InitializeComponent();
	}
    private void Page4(object sender, EventArgs e)
    {
        App.flyoutPage.Detail.Navigation.PushAsync(new Page4());
        App.flyoutPage.IsPresented = false;
    }
}