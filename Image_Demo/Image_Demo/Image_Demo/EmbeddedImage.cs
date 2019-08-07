using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Image_Demo
{
    class EmbeddedImage : IMarkupExtension
    {
        public string ID { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(ID))
                return null;

            return ImageSource.FromResource(ID);
        }
    }
}
