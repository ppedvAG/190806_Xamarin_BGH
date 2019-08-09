using System;
using System.Collections.Generic;
using System.Text;

using SQLite;

namespace DatenSpeichernUndLaden
{
    [Table("Personentabelle")]
    class Person
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public decimal Kontostand { get; set; }
    }
}
