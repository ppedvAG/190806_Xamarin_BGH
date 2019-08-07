using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ShellNavigation
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Navigation_Click(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("//Einstellungen");//relativ
            // Shell.Current.GoToAsync("//Hauptseite/Tab2/Seite2");//absolut
        }
    }
}
