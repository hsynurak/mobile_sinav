using SQLite;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace A026.Data.ClientClass
{
    public class Database
    {
        private readonly SQLiteConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteConnection(dbPath);
            _database.CreateTable<ClientClass>();
            _database.CreateTable<SalesClass>();
            _database.CreateTable<Assignment>(); // Add Assignment table
        }

        // Client operations
        public void AddClient(ClientClass client)
        {
            _database.Insert(client);
        }

        public void DeleteClient(ClientClass client)
        {
            _database.Delete(client);
        }

        public ObservableCollection<ClientClass> GetAllClients()
        {
            var clients = _database.Table<ClientClass>().ToList();
            return new ObservableCollection<ClientClass>(clients);
        }

        // Sales operations
        public void AddSale(SalesClass sale)
        {
            _database.Insert(sale);
        }

        public void DeleteSale(SalesClass sale)
        {
            _database.Delete(sale);
        }

        public ObservableCollection<SalesClass> GetAllSales()
        {
            var sales = _database.Table<SalesClass>().ToList();
            return new ObservableCollection<SalesClass>(sales);
        }

        // Assignment operations
        public void AddAssignment(Assignment assignment)
        {
            _database.Insert(assignment);
        }

        public ObservableCollection<Assignment> GetAllAssignments()
        {
            var assignments = _database.Table<Assignment>().ToList();
            return new ObservableCollection<Assignment>(assignments);
        }
    }
}
