using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Null
            //int zahl1 = 5;
            //int? alter = null; // Nullable Value Types

            //alter = zahl1;
            //zahl1 = alter ?? 0; // Null-Coalescing Operator 
            #endregion

            List<Person> personen = new List<Person>
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100},
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=200},
                new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=3000},
                new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=-4100},
                new Person{Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=15555500},
                new Person{Vorname="Albert",Nachname="Tross",Alter=60,Kontostand=12332423},
                new Person{Vorname="Axel",Nachname="Schweiß",Alter=70,Kontostand=-123100},
                new Person{Vorname="Rainer",Nachname="Zufall",Alter=80,Kontostand=1909779800},
                new Person{Vorname="Klara",Nachname="Fall",Alter=90,Kontostand=11212312300},
                new Person{Vorname="Claire",Nachname="Grube",Alter=100,Kontostand=-12312313100},
            };

            #region Varianten ohne LINQ
            //// Fall 1: Array mit allen Vornamen von jeder Person

            //string[] alleVornamen = new string[personen.Count];
            //for (int i = 0; i < alleVornamen.Length; i++)
            //{
            //    alleVornamen[i] = personen[i].Vorname;
            //}

            //// Fall2: Liste mit allen Vornamen bei denen der Kontostand negativ ist

            //List<string> alleVornamenMitSchulden = new List<string>();
            //for (int i = 0; i < alleVornamen.Length; i++)
            //{
            //    if(personen[i].Kontostand < 0)
            //        alleVornamenMitSchulden.Add(personen[i].Vorname);
            //}

            //// Fall3: Liste mit allen Vornamen bei denen der Kontostand negativ ist, sortiert nach Alter

            //List<string> alleVornamenMitSchuldenSortiertNachAlter = new List<string>();
            //for (int i = 0; i < alleVornamen.Length; i++)
            //{
            //    if (personen[i].Kontostand < 0)
            //        alleVornamenMitSchuldenSortiertNachAlter.Add(personen[i].Vorname);
            //}
            //alleVornamenMitSchuldenSortiertNachAlter.Sort();
            #endregion

            // SELECT: Daten verarbeiten und ein Resultat zurückgeben
            string[] alleVornamen = personen.Select(VerarbeitePerson).ToArray();
            string[] alleVornamen2 = personen.Select(x => x.Vorname).ToArray();

            // WHERE: Filtern

            string[] alleVornamenMitNegativemKontostand = personen.Where(x => x.Kontostand < 0)
                                                                  .Select(x => x.Vorname)
                                                                  .ToArray();

            List<Person> allePersonenÜber50 = personen.Where(person => person.Alter > 50)
                                                      .ToList();


            // ORDERBY, ORDERBYDESCENDING


            List<Person> allePersonenÜber50SortiertNachKontostand = personen.Where(person => person.Alter > 50)
                                                                            .OrderByDescending(x => x.Kontostand)
                                                                            .ToList();

            // FIRST, LAST
            Person reichstePerson = personen.OrderByDescending(x => x.Kontostand)
                                            .First();

            // TAKE, SKIP (x elemente auslassen und den rest nehmen)

            Person[] dieReichsten3Personen = personen.OrderByDescending(x => x.Kontostand)
                                                     .Take(3)
                                                     .ToArray();

            // http://linq101.nilzorblog.com/linq101-lambda.php

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        private static bool PersonenFilter(Person x) => x.Kontostand < 0;
        //{
        //    return x.Kontostand < 0;
        //}

        private static string VerarbeitePerson(Person item)
        {
            return item.Vorname;
        }

        private static string VerarbeitePerson2(Person x) => x.Vorname;


        public int Addieren(int z1, int z2)
        {
            return z1 + z2;
        }

        public int Subtrahieren (int z1, int z2) => z1 - z2;
        //{
        //    return z1 - z2;
        //}


    }
}
