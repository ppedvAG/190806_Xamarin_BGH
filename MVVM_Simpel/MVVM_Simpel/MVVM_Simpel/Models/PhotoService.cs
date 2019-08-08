using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;

namespace MVVM_Simpel.Models
{
    class PhotoService
    {
        public List<PhotoItem> GetPhotos()
        {
            // 1) Daten herunterladen
            byte[] json;
            using(HttpClient client = new HttpClient())
            {
                json = client.GetByteArrayAsync("https://jsonplaceholder.typicode.com/photos").Result;
            }
            // Funktioniert mit allen Datentypen, die IDisposable implementieren
            // Beim verlassen des using-Blocks wird die Methode "Dispose()" aufgerufen

            // 2) Deserialisieren

            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<PhotoItem>));
            var result = (List<PhotoItem>)serializer.ReadObject(new MemoryStream(json));
            return result;
        }
    }
}
