using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IA_Proyecto_III.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Stores the selected image in the Server side
        /// Calls to convertImageToBlackNWhite method
        /// </summary>
        /// <see>
        /// convertImageToBlackNWhite() method
        /// </see>
        private void openDialog(object sender, EventArgs e)
        {
            Bitmap blackAndWhiteImage = null;
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                lblFileName.Text = openImageDialog.FileName;
                string serverPath = Application.StartupPath + "/original_images/" + openImageDialog.SafeFileName;

                // Saves the image in the Server side.
                try
                {
                    File.Copy(openImageDialog.FileName, serverPath, true);
                    toolStatusLabel.Text = "The file: \"" + openImageDialog.SafeFileName +
                        "\" has been saved successfully.";
                }
                catch (Exception ex)
                {
                    Console.Write("Error! " + ex.Message);
                    toolStatusLabel.Text = "Error. Something went wrong saving the image.";
                }

                // Calls the ConvertImageToBlackNWhite method.
                try
                {
                    blackAndWhiteImage = convertImageToBlackNWhite(serverPath, openImageDialog.SafeFileName);
                    openImageDialog.FileName = "";
                    toolStatusLabel.Text = "The image has been saved and converted to black and white successfully.";
                }
                catch (Exception ex)
                {
                    Console.Write("Error! " + ex.Message);
                    toolStatusLabel.Text = "Error. Something went wrong converting the image.";
                }

                try
                {
                    repartitionImage(blackAndWhiteImage);
                    pbSegments.Image = segmentsList.Images[0];
                    segmentsUpDown.Maximum = segmentsList.Images.Count-1;
                    segmentsUpDown.Value = 0;
                    
                }
                catch (Exception ex)
                {
                    Console.Write("Error! " + ex.Message);
                    toolStatusLabel.Text = "Error. Something went wrong partitioning the image.";
                }
            }
        }

        /// <summary>
        /// Converts the original image to blanck and white colors and
        /// stores it in the Server side.
        /// </summary>
        /// <param name="imagePath">original image path</param>
        /// <param name="imageName">original image name</param>
        /// <returns>The black and white image</returns>
        private Bitmap convertImageToBlackNWhite(string imagePath, string imageName)
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
            return image;
        }

        /// <summary>
        /// Repartitions a image in several segments with only 1 character
        /// </summary>
        /// <param name="imagePath">black and white image</param>
        private void repartitionImage(Bitmap image)
        {
            int start = 0, segmentStart, segmentEnd;
            bool black = false;
            Color color;

            // Getting starting horizontal position
            start = getStarterPosition(0, image);
            segmentStart = start;

            if (start == -1) { return; }

            //Getting segments
            for (int i = start; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    color = image.GetPixel(i, j);

                    if (color.R == 0)
                    {
                        black = true;
                    }
                }

                if (black)
                {
                    black = false;
                }
                else
                {
                    segmentEnd = i - 1;

                    // crear segmento y añadirlo
                    segmentsList.Images.Add(image.Clone(new Rectangle(
                        segmentStart,0, (segmentEnd-segmentStart), image.Height), 
                        image.PixelFormat));

                    i = getStarterPosition(i, image);
                    segmentStart = i;

                    if (i == -1) { return; }
                }

            }
        }

        /// <summary>
        /// Gets the starter position of a new segment of a character
        /// </summary>
        /// <param name="x">Columns</param>
        /// <param name="y">Rows</param>
        /// <param name="image">Image source to get the starter position</param>
        /// <returns>Starter position or -1 if isn't found</returns>
        private int getStarterPosition(int x, Bitmap image)
        {
            Color color;
            for (int i = x; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    color = image.GetPixel(i, j);
                    if (color.R == 0)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void segmentsUpDown_ValueChanged(object sender, EventArgs e)
        {
            pbSegments.Image = segmentsList.Images[(int)segmentsUpDown.Value];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            train();
        }
        private void train()
        {
            int hiddenLayerSize = Int32.Parse(tbcapaoculta.Text);
            double learningRate = double.Parse(tbtasaap.Text);
            double variationRate = double.Parse(tbtasavar.Text);
            int maxPeriods = Int32.Parse(tbmaxepoc.Text);
            double maxError = double.Parse(tbminerr.Text);
            Bitmap imaget = new Bitmap("C:/Users/Gabriel/Documents/GitHub/Captcha/iaimages/T.JPG");            
            Bitmap imageoriginal = new Bitmap(segmentsList.Images[(int)segmentsUpDown.Value]);
            Perceptron perceptron = new Perceptron(imageoriginal.Height, hiddenLayerSize, imaget.Height, learningRate, variationRate, maxPeriods, maxError);
            perceptron.training(imageoriginal, imaget);
        }
    }
}
