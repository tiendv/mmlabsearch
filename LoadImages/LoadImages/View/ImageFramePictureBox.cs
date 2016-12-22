using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using LoadImages.Model;

namespace LoadImages.View
{
    class ImageFramePictureBox
    {
       private PictureBox picBox;

       /* Property PictureBox */
       private ImageFrame imageFrame;
       private int x;
       private int y;

       private int size;

       public ImageFramePictureBox(ImageFrame imageFrame, int x, int y, int size)
       {
           this.imageFrame = imageFrame;

           picBox = new PictureBox();
           picBox.Location = new Point(x, y);
           picBox.Image = imageFrame.Thumbnail.GetImage() ;
           picBox.Size = new Size(size,size);
               
           picBox.SizeMode = PictureBoxSizeMode.StretchImage;
           picBox.Click += new EventHandler(Picture_Click);
           picBox.Paint += new PaintEventHandler(Picture_Paint);
       }

        
       
       public PictureBox getPictureBox()
       {
           return this.picBox;
       }
        protected void Active()
        {
            picBox.Tag = Color.Red;
            picBox.Refresh();
        }

        protected void Deactive()
        {
            picBox.Tag = null;
            picBox.Refresh();
        }
        private void Picture_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic.Tag != null)
                ControlPaint.DrawBorder(e.Graphics, pic.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }
        protected void Picture_Click(object sender, EventArgs e)
        {
            // Active();
            MessageBox.Show(imageFrame.IndexFrame + " " + imageFrame.VideoName);
        }
    }
}
