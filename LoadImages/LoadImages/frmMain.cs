using LoadImages.Model;
using LoadImages.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadImages
{
    public partial class frmMain : Form
    {
  
        public frmMain()
        {
            InitializeComponent();
            ImageUserControl.frmMain = this;


            String[] frame_files = Directory.GetFiles("E:\\Images", "*.jpg", SearchOption.AllDirectories);
            String[] shot_files = Directory.GetFiles("E:\\Images2", "*.jpg", SearchOption.AllDirectories);
           
            String VIDEO_NAME = "VIDEO001.flv";
            
            int x = 0;
            int y = 0;
            for (int i=0; i<frame_files.Length - 200; i++)
            {
                Console.WriteLine(frame_files[i]);

               
                ImageFrame imageFrame = new ImageFrame(new Thumbnail(frame_files[i]), VIDEO_NAME, i);
                ImageUserControl img = new ImageUserControl(imageFrame,x,y,50);

                x = x + 50;
                tabVideoFrames.Controls.Add(img); 
                if (x > tabVideoFrames.Width * 2 + 50)
                {
                    x = 0;
                    y = y + 50;
                }                
            }

            VIDEO_NAME = "VIDEO_OOOOOO_002.flv";
            for (int i = 0; i < shot_files.Length - 200; i++)
            {
                Console.WriteLine(shot_files[i]);


                ImageFrame imageFrame = new ImageFrame(new Thumbnail(shot_files[i]), VIDEO_NAME, i);
                ImageUserControl img = new ImageUserControl(imageFrame, x, y, 52);

                x = x + 52;
                tabVideoFrames.Controls.Add(img);
                if (x > tabVideoFrames.Width * 2 + 50)
                {
                    x = 0;
                    y = y + 52;
                }
            }
        }
      
        private void frmMain_SizeChanged(object sender, EventArgs e)
        {
            tabControlVideoFrames.Width = (this.Width / 3 ) + 10;
            tabControlShotFrames.Width = (this.Width / 3) + 10;
           
        }

    }
}
