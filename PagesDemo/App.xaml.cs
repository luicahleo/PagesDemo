namespace PagesDemo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var navPage = new NavigationPage(new MainPage());

            navPage.BarBackgroundColor = Colors.Chocolate;
            navPage.BarTextColor = Colors.White;

            var window = new Window(new FlyOutPageDemo());
            return window;
        }
    }
}