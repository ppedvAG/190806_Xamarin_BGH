using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Image_Demo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // Variante 1) Bilder aus dem Web herunterladen
            //var source = (UriImageSource)ImageSource.FromUri(new Uri("http://placekitten.com/100/100"));
            //source.CachingEnabled = true; // default-fall
            //source.CacheValidity = TimeSpan.FromHours(24); // default-fall

            //imageBild.Source = source;

            // Variante 2)
            // imageBild.Source = ImageSource.FromFile("hund.jpg");

            // Variante 3)
            // Ressourcen-ID: Projektname.Ordnername.Dateiname.Extension
            // imageBild.Source = ImageSource.FromResource("Image_Demo.Images.hamster.jpg");
        }
    }
}
