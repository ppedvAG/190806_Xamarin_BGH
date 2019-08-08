using MVVM_Simpel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Simpel.ViewModels
{
    class MainViewModel : BaseViewModel
    {
        public MainViewModel() // ctor + TAB + TAB
        {
            PersonenLadenCommand = new Command(PersonenLaden);
            service = new PersonenService();
        }

        private readonly PersonenService service; // Geschäftslogik
        private void PersonenLaden(object obj)
        {
            Personenliste = service.PersonenLaden();
        }

        private List<Person> personenliste;
        public List<Person> Personenliste
        {
            get => personenliste;
            set => SetProperty(ref personenliste, value);
        }
        public Command PersonenLadenCommand { get; set; }

    }
}
