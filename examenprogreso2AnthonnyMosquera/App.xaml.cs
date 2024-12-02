namespace examenprogreso2AnthonnyMosquera
{
    public partial class App : Application
    {

        public static BaseDeDatos Database { get; private set; }

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "notas.db3");
            Database = new BaseDeDatos(dbPath);
        }
      
    }
}
