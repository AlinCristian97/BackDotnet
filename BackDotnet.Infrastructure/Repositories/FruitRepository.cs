using BackDotnet.Application.Interfaces;
using BackDotnet.Core.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using static Dapper.SqlMapper;

namespace BackDotnet.Infrastructure.Repositories
{
    public class FruitRepository : IFruitRepository
    {
        private readonly IConfiguration _configuration;

        public FruitRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<int> Add(Fruit entity)
        {
            var sql = "INSERT INTO Fruit (Name, Description, HealthScore) VALUES (@Name, @Description, @HealthScore);";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }

        public async Task<int> Delete(int id)
        {
            var sql = "DELETE FROM Fruit WHERE Id = @Id;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, new { Id = id });
                return affectedRows;
            }
        }

        public async Task<Fruit> Get(int id)
        {
            var sql = "SELECT * FROM Fruit WHERE Id = @Id;";
            
            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Fruit>(sql, new { Id = id });
                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Fruit>> GetAll()
        {
            var sql = "SELECT * FROM Fruit;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var result = await connection.QueryAsync<Fruit>(sql);
                return result;
            }
        }

        public async Task<int> Update(Fruit entity)
        {
            var sql = "UPDATE Fruit SET Name = @Name, Description = @Description, HealthScore = @HealthScore WHERE Id = @Id;";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                connection.Open();
                var affectedRows = await connection.ExecuteAsync(sql, entity);
                return affectedRows;
            }
        }
    }
}
