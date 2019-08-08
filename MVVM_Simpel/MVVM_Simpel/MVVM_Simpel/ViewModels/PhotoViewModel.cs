using MVVM_Simpel.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MVVM_Simpel.ViewModels
{
    class PhotoViewModel : BaseViewModel
    {
        public PhotoViewModel() // ctor + TAB + TAB
        {
            GetPhotoCommand = new Command(PersonenLaden);
            service = new PhotoService();
        }

        private readonly PhotoService service; // Geschäftslogik
        private void PersonenLaden(object obj)
        {
            PhotoListe = service.GetPhotos();
        }

        private List<PhotoItem> photoListe;
        public List<PhotoItem> PhotoListe
        {
            get => photoListe;
            set => SetProperty(ref photoListe, value);
        }
        public Command GetPhotoCommand { get; set; }

    }
}
