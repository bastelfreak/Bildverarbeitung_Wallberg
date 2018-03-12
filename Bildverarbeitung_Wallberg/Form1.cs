﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bildverarbeitung_Wallberg
{
    public partial class Form1 : Form
    {
        Bitmap map;
        string pictureName = "\\Lenna.bmp";

        public Form1()
        {
            InitializeComponent();

            map = Load_Image(DefaultVariables.GetProjectPath() + "\\Picture\\" + pictureName);

            this.pbMain.Size = new System.Drawing.Size(map.Size.Width, map.Size.Height);
            this.pbMain.Image = map;
            this.pbMain.Refresh();
        }

        private Bitmap Load_Image(string imgPath)
        {
            return new Bitmap(imgPath);
        }

        private void btnGrey_Click(object sender, EventArgs e)
        {
            this.pbMain.Image = Bildverarbeitung.ImageToGrey(map);
            this.Refresh();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            map = Load_Image(DefaultVariables.GetProjectPath() + "\\Picture\\" + pictureName);

            this.pbMain.Image = map;
            this.Refresh();
        }

        private void btnHistogram_Click(object sender, EventArgs e)
        {
            this.pbMain.Image = Bildverarbeitung.LoadHistogramInImage(map);
            this.Refresh();
        }
    }
}
