using IntroSqlFraCS.DatabaseModel;
using System.Data.SqlClient;
using Dapper;

namespace IntroSqlFraCS
{
    internal class DbDemo
    {
        public static async Task Main()
        {
            const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Intro2023;Integrated Security=True";

            var personRepository = new PersonRepository(connectionString);
            var people = await personRepository.ReadAllWithPlace();
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }

            //var rowsAffected = await personRepository.Create(new Person {Id = 9, BirthYear = 1900, FirstName = "Ole"});
            //Console.WriteLine(rowsAffected);

            //people = await personRepository.ReadAll();
            //foreach (var person in people)
            //{
            //    Console.WriteLine(person);
            //}
        }
    }
}
