namespace Herramientas_IA_en_el_aula
{
    
    public partial class MainPage : FlyoutPage
    {
        public MainPage()
        {
            InitializeComponent();

            Flyout = new Maestro();
            Detail = new NavigationPage(new Menu());

            App.flyoutPage = this;
        }
    }

}

