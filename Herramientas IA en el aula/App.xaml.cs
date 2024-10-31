namespace Herramientas_IA_en_el_aula
{
    public partial class App : Application
    {
        public static FlyoutPage flyoutPage { get; set; }

        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }
    }
}
