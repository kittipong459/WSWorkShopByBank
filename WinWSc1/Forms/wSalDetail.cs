using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Service;
using wModels.Class;
using wModels.Response;

namespace WindowsFormsApp1
{
    public partial class Wform2 : Form
    {
        string tW_ClasName = "wSalDetail";
        public Wform2()
        {
            InitializeComponent();
            W_GETxSalDetail();
            /* Image img = new Bitmap("D:\\Bank\\workshop\\showtogit\\AddWSbyBank\\WinWSc1\\Images\\bin.png");
             Bitmap resizedImage = new Bitmap(img, new Size(50, 50));
             c1PictureBox1.Image = resizedImage;*/
        }

        private void W_GETxSalDetail()
        {
            try
            {
                List<cmlResSalDet> aoResSalDets = new List<cmlResSalDet>();
                aoResSalDets = new cSaldetService().C_GETaGetSaleDet(otdSchSal.Text);
                ogdSalDet.DataSource = "";
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {

            }
        }

        private void ocmSetImg_Click_1(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                ofd.Title = "Select an Image";
                Image uploadedImage;
                // Show the dialog and check if the user selected a file
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    // Get the file path
                    string filePath = ofd.FileName;

                    // Check if file exists
                    if (File.Exists(filePath))
                    {
                        uploadedImage = Image.FromFile(ofd.FileName);
                        // uploadedImage.Save("E:\\ada\\expros\\testImgs\\"+DateTime.Now.ToString("yyyymmddmm")+"tre489464534" +".png");

                        //uploadedImage = Image.FromFile("E:\\ada\\testpros\\testImgs\\2024241724tre489464534.png");
                        c1PictureBox1.Image = uploadedImage;
                        c1PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                        //pictureBox1.Image = new Bitmap(filePath);
                        //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                    else
                    {
                        MessageBox.Show("File not found!");
                    }
                }
            }
            catch (Exception oEx)
            {
                cLog.C_WRTxLog(tW_ClasName, $"{MethodBase.GetCurrentMethod().Name}:" + oEx.Message);
                MessageBox.Show(oEx.Message + " " + oEx.StackTrace.ToString());
            }
            finally
            {

            }
        }

        private void ocmSsh_Click(object sender, EventArgs e)
        {
            W_GETxSalDetail();
        }
    }
}
