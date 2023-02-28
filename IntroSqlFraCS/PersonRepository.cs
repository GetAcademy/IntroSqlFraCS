using System.Data.SqlClient;
using Dapper;
using IntroSqlFraCS.DatabaseModel;

namespace IntroSqlFraCS
{
    internal class PersonRepository
    {
        private SqlConnection _sqlConnection;

        public PersonRepository(string connectionString)
        {
            _sqlConnection = new SqlConnection(connectionString);
        }

        public async Task<IEnumerable<Person>> ReadAll()
        {
            const string sql = "SELECT Id, FirstName, BirthYear, PlaceId FROM Person";
            return await _sqlConnection.QueryAsync<Person>(sql);
        }

        public async Task<Person?> ReadById(int id)
        {
            const string sql = "SELECT Id, FirstName, BirthYear, PlaceId FROM Person WHERE Id = @Id";
            var people = await _sqlConnection.QueryAsync<Person>(sql);
            return people.SingleOrDefault();
        }

        public async Task<int> Create(Person person)
        {
            const string sql = "INSERT INTO Person VALUES (@Id, @FirstName, @BirthYear, @PlaceId)";
            var rowsAffected = await _sqlConnection.ExecuteAsync(sql, person);
            return rowsAffected;
        }

        public async Task<int> Update(Person person)
        {
            const string sql = @"UPDATE Person 
                SET FirstName=@FirstName, 
                    BirthYear=@BirthYear, 
                    PlaceId=@PlaceId) 
                WHERE Id = @Id";
            var rowsAffected = await _sqlConnection.ExecuteAsync(sql, person);
            return rowsAffected;
        }

        public async Task<int> Delete(Person person)
        {
            const string sql = @"DELETE FROM Person WHERE Id = @Id";
            var rowsAffected = await _sqlConnection.ExecuteAsync(sql, person);
            return rowsAffected;
        }

        public async Task<int> Delete(int id)
        {
            const string sql = @"DELETE FROM Person WHERE Id = @Id";
            var rowsAffected = await _sqlConnection.ExecuteAsync(sql, new {Id=id});
            return rowsAffected;
        }
    }
}
