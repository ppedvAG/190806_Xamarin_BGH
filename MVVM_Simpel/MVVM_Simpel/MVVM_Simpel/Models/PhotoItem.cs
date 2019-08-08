using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace MVVM_Simpel.Models
{
    [DataContract]
    class PhotoItem
    {
        [DataMember]
        public int albumId { get; set; }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public string url { get; set; }
        [DataMember]
        public string thumbnailUrl { get; set; }
    }
}
