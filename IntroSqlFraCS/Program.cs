/*
 - ADO.NET 
 - Dapper
 - SqlConnection
 - CRUD-operasjonene mot en enkelt tabell
 - Pakke inn som en egen Repository-klasse
 - (vise generelt repository fra Moodle)
 - Joins og egne databasemodeller 

    Pause til: 10:38

 */

using System.Data.SqlClient;
using Dapper;
using IntroSqlFraCS.DatabaseModel;

const string sql = "SELECT Id, FirstName, BirthYear, PlaceId FROM Person WHERE Id = @Id";
const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Intro2023;Integrated Security=True";

var connection = new SqlConnection(connectionString);
var people = connection.Query<Person>(sql, new { Id = 6 });
foreach (var person in people)
{
    Console.WriteLine(person);
}

