using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoadImages.Model;

namespace LoadImages.View
{
    public partial class ImageUserControl : UserControl
    {
        /* Property PictureBox */
        private ImageFrame imageFrame;
        private int x;
        private int y;

        private int size;

        public static frmMain frmMain;
        public ImageUserControl(ImageFrame imageFrame = null, int x = 0, int y = 0, int size =0)
        {
            InitializeComponent();


            this.imageFrame = imageFrame;


            this.Location = new Point(x, y);
            this.pictureBox.Image = imageFrame.Thumbnail.GetImage();
            this.Size = new Size(size, size);

            this.pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox.Click += new EventHandler(Picture_Click);
            this.pictureBox.Paint += new PaintEventHandler(Picture_Paint);
        }


        public PictureBox getPictureBox()
        {
            return this.pictureBox;
        }
        protected void Active()
        {
            this.pictureBox.Tag = Color.Red;
            this.pictureBox.Refresh();
        }

        protected void Deactive()
        {
            this.pictureBox.Tag = null;
            this.pictureBox.Refresh();
        }
        private void Picture_Paint(object sender, PaintEventArgs e)
        {
            PictureBox pic = sender as PictureBox;
            if (pic.Tag != null)
                ControlPaint.DrawBorder(e.Graphics, pic.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }
        protected void Picture_Click(object sender, EventArgs e)
        {
            
            foreach (Control control in frmMain.tabControlVideoFrames.TabPages[0].Controls)
            {
                ImageUserControl ctr = control as ImageUserControl;
                ctr.Deactive();
            }

            Active();
            MessageBox.Show(imageFrame.IndexFrame + " " + imageFrame.VideoName);
        }
    }
}
