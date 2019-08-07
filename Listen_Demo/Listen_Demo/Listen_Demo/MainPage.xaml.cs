using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Listen_Demo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonPersonenLaden_Clicked(object sender, EventArgs e)
        {
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


            listViewPersonen.ItemsSource = personen;

        }

        private void ListViewPersonen_Refreshing(object sender, EventArgs e)
        {
            List<Person> personen = new List<Person>
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100},
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=200},
                new Person{Vorname="Claire",Nachname="Grube",Alter=100,Kontostand=-12312313100},
            };


            listViewPersonen.ItemsSource = personen;
            listViewPersonen.EndRefresh();
        }

        private void MenuItemInfo_Clicked(object sender, EventArgs e)
        {
            Person p = (sender as MenuItem).BindingContext as Person;
            // Person p = ((Person)((MenuItem)sender).BindingContext);
            DisplayAlert("Personeninfos", $"{p.Vorname} {p.Nachname}, Alter:{p.Alter}, Kontostand:{p.Kontostand}€", "OK");
        }

        private void MenuItemLöschen_Clicked(object sender, EventArgs e)
        {
            // Löschen ;)
        }
    }
}
