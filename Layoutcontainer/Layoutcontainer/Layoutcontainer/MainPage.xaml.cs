using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Layoutcontainer
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

        private void ButtonAddElement_Clicked(object sender, EventArgs e)
        {
            // stackLayoutRoot.Children.Add(new Button { Text = "Automatisch generierter Button" });
        }

        private void ChangeStyle(object sender, EventArgs e)
        {
            // Style neu zuweisen
            // buttonStatic.Style = (Style)gridContainer.Resources["notspecialButtonStyle"];
            // Style aus App.xaml
            // App.Current.Resources["styleAus_App.xaml"]

            // Unterschied zwischen Static und Dynamic-Resource

            // gridContainer.Resources["specialButtonStyle"] = gridContainer.Resources["notspecialButtonStyle"]; // Ressource austauschen
            // StaticResource bekommt den Austausch der Referenz nicht mit, DynamicResource schon (== aber mehr Overhead !)
        }
    }
}
