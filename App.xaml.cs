using MauiAppEvento.model;

namespace MauiAppEvento
{
    public partial class App : Application
    {
        public List<Locais> Lista_Locais = new List<Locais>
        {
            new Locais()
            {
                Descricao = "Allianz Parque",
                Vdiaria = 598.0,
            },
            new Locais()
            {
                Descricao = "Espaço Unimed",
                Vdiaria = 420.0,
            },
            new Locais()
            {
                Descricao = "Arena MRV",
                Vdiaria = 300.0,
            },
            new Locais()
            {
                Descricao = "Vila Viva Sorte",
                Vdiaria = 600.0,
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }
        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}