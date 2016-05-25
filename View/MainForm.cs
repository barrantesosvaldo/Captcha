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

namespace IA_Proyecto_III.View
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void openDialog(object sender, EventArgs e)
        {
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                lblFileName.Text = openImageDialog.FileName;

                try
                {
                    File.Copy(
                    openImageDialog.FileName,
                    Application.StartupPath + "/original_images/" + openImageDialog.SafeFileName,
                    true);
                    toolStatusLabel.Text = "The file: \"" + openImageDialog.SafeFileName +
                        "\" has been saved successfully.";
                }
                catch (Exception ex)
                {
                    Console.Write("Error! " + ex.Message);
                    toolStatusLabel.Text = "Error. Something went wrong saving the image.";
                }

                try
                {
                    convertImageToBlackNWhite(Application.StartupPath + "/original_images/" +
                        openImageDialog.SafeFileName, openImageDialog.SafeFileName);
                    openImageDialog.FileName = "";
                }
                catch (Exception ex)
                {
                    Console.Write("Error! " + ex.Message);
                    toolStatusLabel.Text = "Error. Something went wrong converting the image.";
                }
            }
        }

        private void convertImageToBlackNWhite(string imagePath, string imageName)
        {
            toolStatusLabel.Text = "Converting the image colors to Black and White...";

            Bitmap image = new Bitmap(imagePath);            

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    Color color = image.GetPixel(i, j);
                    var avarage = (color.R + color.B + color.G) / 3;
                    if (avarage > 180)
                    {
                        image.SetPixel(i, j, Color.White);
                    }
                    else
                    {
                        image.SetPixel(i, j, Color.Black);
                    }
                }
            }

            imagePath = Application.StartupPath + "/black_n_white_images/" + imageName;
            if (File.Exists(imageName))
            {
                File.Delete(imageName);
            }

            image.Save(imagePath, System.Drawing.Imaging.ImageFormat.Bmp);

            toolStatusLabel.Text = "The image has been saved and converted to black and white successfully.";
        }

        private void openCameraCapture(object sender, EventArgs e)
        {
            new CameraForm();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
