namespace IntroSqlFraCS.DatabaseModel
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int? BirthYear { get; set; }
        public int? PlaceId { get; set; }

        public override string ToString()
        {
            return FirstName + " " + BirthYear;
        }
    }
}
