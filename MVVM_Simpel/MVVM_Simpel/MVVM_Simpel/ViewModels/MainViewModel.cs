using MVVM_Simpel.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace MVVM_Simpel.ViewModels
{
    class MainViewModel
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

        public List<Person> Personenliste { get; set; }
        public Command PersonenLadenCommand { get; set; }

    }
}
