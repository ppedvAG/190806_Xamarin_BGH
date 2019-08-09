using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatenSpeichernUndLaden
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SQLitePage : ContentPage
    {
        public SQLitePage()
        {
            InitializeComponent();

            string fullpath = Path.Combine(FileSystem.AppDataDirectory, "demo.sqlite");
            con = new SQLiteConnection(fullpath);
            // Wenn die Datei bereits existiert, wird sie geöffnet. Ansonsten wird sie neu erstellt

            // Beim ersten Start:
            con.CreateTable<Person>(); // Praktisch: Wenn die Tabelle bereits existiert, passiert nichts
        }

        private SQLiteConnection con;

        private void ButtonEinfügen_Clicked(object sender, EventArgs e)
        {
            Person p1 = new Person();
            p1.Name = entryName.Text;
            p1.Kontostand = Convert.ToDecimal(entryKontostand.Text);

            con.Insert(p1);
        }

        private void ListViewPersonen_Refreshing(object sender, EventArgs e)
        {
            listViewPersonen.ItemsSource = con.Table<Person>().ToList();
            listViewPersonen.EndRefresh();
        }
    }
}