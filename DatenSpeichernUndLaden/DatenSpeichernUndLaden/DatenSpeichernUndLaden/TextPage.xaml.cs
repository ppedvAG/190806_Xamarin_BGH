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
    public partial class TextPage : ContentPage
    {
        public TextPage()
        {
            InitializeComponent();
        }

        private void ButtonSpeichern_Clicked(object sender, EventArgs e)
        {
            // Problem: Ort schaut überall anders aus
            // Android: SD-Karte: /storage/emulated/0/Documents
            // Windows(UWP): C:/Users/Michael/AppData/Local
            // usw...

            string fullPath = Path.Combine(FileSystem.AppDataDirectory, "demo.txt");
            File.WriteAllText(fullPath, entryInhalt.Text);
        }

        private void ButtonLaden_Clicked(object sender, EventArgs e)
        {
            string fullPath = Path.Combine(FileSystem.AppDataDirectory, "demo.txt");
            DisplayAlert(fullPath, File.ReadAllText(fullPath), "Ok");
        }
    }
}