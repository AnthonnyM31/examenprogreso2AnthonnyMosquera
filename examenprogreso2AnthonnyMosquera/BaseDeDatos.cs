using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
//using static Android.Provider.ContactsContract.CommonDataKinds;
using static examenprogreso2AnthonnyMosquera.Recargas;
namespace examenprogreso2AnthonnyMosquera;


public class BaseDeDatos
{
    private readonly SQLiteAsyncConnection _database;

    public BaseDeDatos(string dbPath)
    {
        _database = new SQLiteAsyncConnection(dbPath);
        _database.CreateTableAsync<Recarga>().Wait();
    }

    public Task<List<Recarga>> ObtenerNotasAsync()
    {
        return _database.Table<Recarga>().ToListAsync();
    }

    public Task<int> GuardarNotaAsync(Recarga nota)
    {
        return nota.Id != 0 ? _database.UpdateAsync(nota) : _database.InsertAsync(nota);
    }

    public Task<int> EliminarNotaAsync(Recarga nota)
    {
        return _database.DeleteAsync(nota);
    }


    //cambiar los nombres "nota" por "recarga"
}