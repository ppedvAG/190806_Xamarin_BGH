using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navigation_Demo
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

        private void Seite2Modal_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Seite2());
        }

        private void Seite2NavigationPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Seite2());
        }
    }
}
