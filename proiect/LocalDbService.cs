using SQLite;

//using SQLite;

namespace proiect
{
    public class LocalDbService
    {
        private const string DB_NAME = "local_db.db3";
        private readonly SQLiteAsyncConnection _connection;

        public LocalDbService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory,DB_NAME));
            _connection.CreateTableAsync<Articol>();
        }



        //ca sa iau toate articolele din db
        public async Task<List<Articol>> GetArticols()
        {
            return await _connection.Table<Articol>().ToListAsync();
        }

        

        // ca sa iau un singur articol dupa id-ul lui
        public async Task<Articol> GetById (int id)
        {
            return await _connection.Table<Articol>().Where(x => x.Id_articol == id).FirstOrDefaultAsync();
        }

        //ca sa adaug un articol
        public async Task Create (Articol articol)
        {
            await _connection.InsertAsync(articol);
        }

        // ca sa modific
        public async Task Update(Articol articol)
        {
            await _connection.UpdateAsync(articol);
        }


        //ca sa sterg

        public async Task Delete(Articol articol)
        {
            await _connection.DeleteAsync(articol);
        }
    }
}
