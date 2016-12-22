using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadImages.Model
{
    public class ImageFrame
    {
        Thumbnail thumbnail;

        internal Thumbnail Thumbnail
        {
            get { return thumbnail; }
            set { thumbnail = value; }
        }
        String videoName;

        public String VideoName
        {
            get { return videoName; }
            set { videoName = value; }
        }
        int indexFrame;

        public int IndexFrame
        {
            get { return indexFrame; }
            set { indexFrame = value; }
        }

        public ImageFrame(Thumbnail thumbnail, String videoName, int indexFrame)
        {
            this.thumbnail = thumbnail;
            this.videoName = videoName;
            this.indexFrame = indexFrame;
        }


    }
}
