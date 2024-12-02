namespace examenprogreso2AnthonnyMosquera;

public partial class verRecargas : ContentPage
{
    public verRecargas()
    {
        InitializeComponent();
        CargarRecargas();
    }

 

    public List<Recargas.Recarga> Recargas { get; set; }

    private async Task CargarRecargas()
    {
        Recargas = await App.Database.ObtenerNotasAsync();
        BindingContext = null; // Reinicia el contexto para refrescar la UI
        BindingContext = this;
    }

    private async void ActualizarRecargasClicked(object sender, EventArgs e)
    {
        await CargarRecargas();
    }
}
