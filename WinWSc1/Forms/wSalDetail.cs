using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class wSalDetail : Form
    {
        public wSalDetail()
        {
            InitializeComponent();
            Image img = new Bitmap("D:\\Bank\\workshop\\showtogit\\AddWSbyBank\\WinWSc1\\Images\\bin.png");
            Bitmap resizedImage = new Bitmap(img, new Size(50, 50));

            c1PictureBox1.Image = resizedImage;
        }
    }
}
