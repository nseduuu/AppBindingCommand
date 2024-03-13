namespace AppBindingCommand
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DateTime data = DateTime.Now;
            Preferences.Set("dtAtual", data);
            Preferences.Set("AcaoInicial",$"* App executado às {data}. \n");

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            base.OnStart();
            Preferences.Set("AcaoStart", string.Format("* App iniciado às {0}. \n", DateTime.Now));
        }

        protected override void OnSleep()
        {
            base.OnStart();
            Preferences.Set("AcaoSleep", string.Format("* App em segundo plano às {0}. \n", DateTime.Now));
        }

        protected override void OnResume()
        {
            base.OnStart();
            Preferences.Set("AcaoResume", string.Format("* App reativado às {0}. \n", DateTime.Now));
        }

    }
}
