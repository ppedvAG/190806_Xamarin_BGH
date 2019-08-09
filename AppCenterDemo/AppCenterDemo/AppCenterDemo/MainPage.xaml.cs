using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppCenterDemo
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

        private void DivideByZero_Clicked(object sender, EventArgs e)
        {
            try
            {
                throw new DivideByZeroException();
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
                // normales error-handling
            }
        }

        private void StackOverflow_Clicked(object sender, EventArgs e)
        {
            try
            {
                throw new StackOverflowException();
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
                // normales error-handling
            }
        }

        private void Crash_Clicked(object sender, EventArgs e)
        {
            IchMacheEtwasDummes();
        }
        private void IchMacheEtwasDummes()
        {
            EsGibtEinenCrash();
        }
        private void EsGibtEinenCrash()
        {
            Crashes.GenerateTestCrash();
        }
    }
}
