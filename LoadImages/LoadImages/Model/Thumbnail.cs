using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LoadImages.Model
{
    public class Thumbnail
    {
        private Image  image;
        private String imageLocation;


        public Thumbnail(Image image)
        {
            SetImage(image);
        }

        public Thumbnail(String imageLocation)
        {
            SetImage(imageLocation);
        }

        public void SetImage(Image image)
        {
            this.image = image;
            this.imageLocation = null;
        }

        public Image GetImage()
        {
            if (this.image != null)
                return this.image;
            return null;
        }

        public void SetImage(String imageLocation)
        {
            this.imageLocation = imageLocation;
            try
            {
                this.image = Image.FromFile(this.imageLocation);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

    }
}
