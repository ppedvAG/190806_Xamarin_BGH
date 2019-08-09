using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DatenSpeichernUndLaden
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            entryUsername.Text = Preferences.Get("Username", "--- Kein Username gespeichert ---");
            switchNotifications.IsToggled = Preferences.Get("Notifications", false);
            sliderWert.Value = Preferences.Get("Wert", 0.0);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Preferences.Set("Username", entryUsername.Text);
            Preferences.Set("Notifications", switchNotifications.IsToggled);
            Preferences.Set("Wert", sliderWert.Value);
        }
    }
}