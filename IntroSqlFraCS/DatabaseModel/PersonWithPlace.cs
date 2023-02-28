using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroSqlFraCS.DatabaseModel
{
    internal class PersonWithPlace
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int? BirthYear { get; set; }
        public string PlaceName { get; set; }
        public string PlaceCountry { get; set; }

        public override string ToString()
        {
            return $@"{Id} {FirstName} {PlaceName}";
        }
    }
}
