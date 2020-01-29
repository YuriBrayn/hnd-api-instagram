using System.Collections.Generic;
using hnd.api.instagram.Models;
using MySql.Data.MySqlClient;
using Dapper;
namespace hnd.api.instagram.Repositories
{
    public class TargetRepository : ITargetRepository
    {
        private readonly string _connectionString;
        public TargetRepository(string connectionString)
        {
            _connectionString = connectionString;   
        }
        public IEnumerable<Target> Get()
        {
            using(MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                return connection.Query<Target>("SELECT Codigo, Nome FROM Pessoa ORDER BY Nome ASC");
            }
        }
    }
}