namespace examenprogreso2AnthonnyMosquera
{
    public partial class App : Application
    {

        public static List<Recargas.Recarga> Notas { get; internal set; }
        public static BaseDeDatos Database { get; private set; }

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "recargas.db3");
            Database = new BaseDeDatos(dbPath);
        }

        public static object Database { get; internal set; }

        Recargas = new List<Recargas.Recarga>();
      
    }
}
