using Microcharts;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Geolocation_Demo
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
        Microcharts.Entry[] entries;

        private async void ButtonLocation_Clicked(object sender, EventArgs e)
        {
            var currentLocation = await Geolocation.GetLocationAsync();

            if (currentLocation == null)
                return;

            labelLocation.Text = $"Latitude: {currentLocation.Latitude}, Longitude: {currentLocation.Longitude}, Altitude: {currentLocation.Altitude}";

            // await currentLocation.OpenMapsAsync();

            entries = new Microcharts.Entry[]
            {
                new Microcharts.Entry(100)
                {
                    Label = "January",
                    ValueLabel = "200",
                    Color = SKColor.Parse("#266489")
                },
                new Microcharts.Entry(50)
                {
                    Label = "February",
                    ValueLabel = "400",
                    Color = SKColor.Parse("#68B9C0")
                },
                new Microcharts.Entry(20)
                {
                    Label = "March",
                    ValueLabel = "-100",
                    Color = SKColor.Parse("#90D585")
                }
            };

            var chart = new LineChart { Entries = entries };
            chartView.Chart = chart;
        }

        private void SliderÄndern_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            List<Microcharts.Entry> entries = new List<Microcharts.Entry>();
            Random r = new Random();
            for (int i = 0; i < 20; i++)
            {
                if (r.Next(0, 3) % 3 == 0)
                    entries.Add(new Microcharts.Entry((float)sliderÄndern1.Value)
                    {
                        Label = "Slider Eins",
                        ValueLabel = "X",
                        Color = SKColor.Parse("#266489")
                    });
                else if (r.Next(0, 3) % 3 == 1)
                    entries.Add(new Microcharts.Entry((float)sliderÄndern2.Value)
                    {
                        Label = "Slider Zwei",
                        ValueLabel = "Y",
                        Color = SKColor.Parse("#68B9C0")
                    });
                else
                    entries.Add(new Microcharts.Entry((float)sliderÄndern3.Value)
                    {
                        Label = "Slider Drei",
                        ValueLabel = "Z",
                        Color = SKColor.Parse("#90D585")
                    });
            }

            var chart = new LineChart { Entries = entries };
            chart.LineMode = LineMode.Straight;
            chart.LineSize = 2;
            chart.PointSize = 10;
            chart.PointMode = PointMode.None;
            chartView.Chart = chart;
        }
    }
}
