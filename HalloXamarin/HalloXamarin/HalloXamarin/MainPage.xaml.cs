using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HalloXamarin
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

        private async void ButtonKlickMich_Clicked(object sender, EventArgs e)
        {
            // 1) Klassische "MessageBox" 
            await DisplayAlert("Meine erste Nachricht", "Hallo Welt", "Ok");

            // 2) "Ja/Nein" - Messagebox
            bool result = await DisplayAlert("Wichtige Frage", "Wollen wir Pause machen ?", "Ja", "Verdammt nochmal Ja !!!");
            await DisplayAlert("Antwort", "Deine Antwort war: " + result, "Okay");

            // 3) Aus mehreren Optionen wählen
            string obst = await DisplayActionSheet("Wähle dein Lieblingsobst", null, null, "Apfel", "Birne", "Banane", "Orange");
            await DisplayAlert("Dein Obst", obst, "Mjam....");

            await DisplayAlert("Dein Passwort ist:", entryPasswort.Text, "Total sicher ;) ");
        }
    }
}
