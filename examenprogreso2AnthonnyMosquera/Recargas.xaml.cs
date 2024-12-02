//using static Android.Provider.ContactsContract.CommonDataKinds;
using SQLite;
using static Android.Icu.Text.CaseMap;
using static Android.Provider.ContactsContract.CommonDataKinds;
namespace examenprogreso2AnthonnyMosquera;


public partial class Recargas : ContentPage
{
	public Recargas()
	{
		InitializeComponent();
	}


    public class Recarga
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        //si no están marcadas como opcionales o requeridas no se por que pero no funciona asi que vamos a permitir valores null
        public string? Titulo { get; set; }
        public string? Contenido { get; set; }
        public DateTime FechaHora { get; set; } = DateTime.Now;
    }




    private async void GuardarNota_Clicked(object sender, EventArgs e)
    {
        string Numero = amosqueranumero.Text;
        string contenido = amosquerarecarga.Text;

        if (!string.IsNullOrWhiteSpace(Numero) && !string.IsNullOrWhiteSpace(contenido))
        {
            var nuevaNota = new Recarga
            {
                Titulo = Numero,
                Contenido = contenido,
                FechaHora = DateTime.Now
            };

            await App.Database.GuardarNotaAsync(nuevaNota);

            await DisplayAlert("Nota Guardada", "Tu nota ha sido guardada con éxito.", "OK");
            await Navigation.PopAsync();
        }
        else
        {
            await DisplayAlert("Error", "Por favor, completa todos los campos.", "OK");
        }
    }
}

