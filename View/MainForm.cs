using IA_Proyecto_III.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace IA_Proyecto_III.View
{
    public partial class MainForm : Form
    {
        private List<StorageCharacter> storageCharacterList;
        private List<string> charactersList;
        private static int imageSize = 64;

        public MainForm()
        {
            InitializeComponent();
            charactersList = new List<string>();
            charactersList.Add("0");
            charactersList.Add("1");
            charactersList.Add("2");
            charactersList.Add("3");
            charactersList.Add("4");
            charactersList.Add("5");
            charactersList.Add("6");
            charactersList.Add("7");
            charactersList.Add("8");
            charactersList.Add("9");
            charactersList.Add("A");
            charactersList.Add("B");
            charactersList.Add("C");
            charactersList.Add("D");
            charactersList.Add("E");
            charactersList.Add("F");
            charactersList.Add("G");
            charactersList.Add("H");
            charactersList.Add("I");
            charactersList.Add("J");
            charactersList.Add("K");
            charactersList.Add("L");
            charactersList.Add("M");
            charactersList.Add("N");
            charactersList.Add("O");
            charactersList.Add("P");
            charactersList.Add("Q");
            charactersList.Add("R");
            charactersList.Add("S");
            charactersList.Add("T");
            charactersList.Add("U");
            charactersList.Add("V");
            charactersList.Add("W");
            charactersList.Add("X");
            charactersList.Add("Y");
            charactersList.Add("Z");
            GenerateStorageCharacterList();
        }

        /// <summary>
        /// Create a list of default storage images of characters.
        /// </summary>
        private void GenerateStorageCharacterList()
        {
            storageCharacterList = new List<StorageCharacter>();
            DirectoryInfo currentDirectory = new DirectoryInfo(
                Application.StartupPath + "/iaimages/");
            int filesSize = currentDirectory.GetFiles("*.*").Count();
            int index = 0;

            if (filesSize > 0)
            {
                foreach (FileInfo archivo in currentDirectory.GetFiles("*.JPG"))
                {
                    Bitmap bitmap = new Bitmap(archivo.FullName);
                    StorageCharacter newStorageCharacter = new StorageCharacter(
                        ResizeImage(bitmap), 
                        charactersList.ElementAt(index));
                    storageCharacterList.Add(newStorageCharacter);
                    index++;
                }
            }
        }

        /// <summary>
        /// Stores the selected image in the Server side
        /// Calls to convertImageToBlackNWhite method
        /// </summary>
        /// <see>
        /// convertImageToBlackNWhite() method
        /// repartitionImage() method
        /// </see>
        private void openDialog(object sender, EventArgs e)
        {
            Bitmap blackAndWhiteImage = null;
            if (openImageDialog.ShowDialog() == DialogResult.OK)
            {
                lblFileName.Text = openImageDialog.FileName;
                string serverPath = Application.StartupPath + "/original_images/" + 
                    openImageDialog.SafeFileName;

                // Saves the image in the Server side.
                try
                {
                    File.Copy(openImageDialog.FileName, serverPath, true);
                    pbCaptcha.Image = new Bitmap(serverPath);
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
                    blackAndWhiteImage = convertImageToBlackNWhite(serverPath, 
                        openImageDialog.SafeFileName);
                    openImageDialog.FileName = "";
                    toolStatusLabel.Text = "The image has been saved and converted " +
                        "to black and white successfully.";
                }
                catch (Exception ex)
                {
                    Console.Write("Error! " + ex.Message);
                    toolStatusLabel.Text = "Error. Something went wrong converting the image.";
                }

                // Repartition the Black and White image in segments 
                // for each character in the captcha
                try
                {
                    segmentsList.Images.Clear();
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
        /// <see>
        /// getStarterPosition() method
        /// </see>
        private void repartitionImage(Bitmap image)
        {
            int start = 0, columnStart, columnEnd;
            bool black = false;
            Color color;

            // Getting starting horizontal position
            start = getStartPositionColumns(0, image);
            columnStart = start;

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
                    columnEnd = i - 1;
                    int rowStart = getStartPositionRows(image, columnStart, columnEnd);
                    int imageHeight = getEndPositionRows(image, columnStart, columnEnd) - rowStart;

                    // Creates a new segment and add it to the list
                    segmentsList.Images.Add(ResizeImage(image.Clone(
                        new Rectangle(
                            columnStart, 
                            rowStart, 
                            (columnEnd-columnStart), 
                            imageHeight), 
                        image.PixelFormat)));

                    i = getStartPositionColumns(i, image);
                    columnStart = i;

                    if (i == -1) { return; }
                }
            }
        }

        /// <summary>
        /// Gets the starter position of a new segment of a character, 
        /// for the columns.
        /// </summary>
        /// <param name="x">Columns</param>
        /// <param name="image">Image source to get the start position</param>
        /// <returns>Start position or -1 if isn't found</returns>
        private int getStartPositionColumns(int x, Bitmap image)
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

        /// <summary>
        /// Gets the starter position of a new segment of a character, 
        /// for the rows.
        /// </summary>
        /// <param name="image">Image source to get the start position</param>
        /// <param name="columnStart">Segment column start</param>
        /// <param name="columnEnd">Segment column end</param>
        /// <returns>Start position or -1 if isn't found</returns>
        private int getStartPositionRows(Bitmap image, int columnStart, int columnEnd)
        {
            Color color;
            for (int i = 0; i < image.Height; i++)
            {
                for (int j = columnStart; j < columnEnd; j++)
                {
                    color = image.GetPixel(j, i);
                    if (color.R == 0)
                    {
                        return i;
                    }
                }
            }

            return -1;
        }

        /// <summary>
        /// Gets the end position of a new segment of a character, 
        /// for the rows.
        /// </summary>
        /// <param name="image">Image source to get the end position</param>
        /// <param name="columnStart">Segment column start</param>
        /// <param name="columnEnd">Segment column end</param>
        /// <returns>End position or -1 if isn't found</returns>
        private int getEndPositionRows(Bitmap image, int columnStart, int columnEnd)
        {
            Color color;
            for (int i = image.Height-1; i >= 0; i--)
            {
                for (int j = columnStart; j < columnEnd; j++)
                {
                    color = image.GetPixel(j, i);
                    if (color.R == 0)
                    {
                        return i + 1;
                    }
                }
            }

            return -1;
        }

        /// <summary>
        /// Resize the image to the specified width and height.
        /// </summary>
        /// <param name="image">The image to resize.</param>
        /// <returns>The resized image.</returns>
        public static Bitmap ResizeImage(Bitmap image)
        {
            var destRect = new Rectangle(0, 0, imageSize, imageSize);
            var destImage = new Bitmap(imageSize, imageSize);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        /// <summary>
        /// Gets the amounto of matches between the captcha character 
        /// </summary>
        /// <param name="captchaCharacter"></param>
        /// <param name="storageCharacter"></param>
        /// <returns></returns>
        private int inference(Bitmap captchaCharacter, Bitmap storageCharacter)
        {
            int matches = 0;

            for (int rows = 0; rows < imageSize; rows++)
            {
                for (int columns = 0; columns < imageSize; columns++)
                {
                    if (captchaCharacter.GetPixel(columns, rows) == 
                        storageCharacter.GetPixel(columns, rows))
                    {
                        matches++;
                    }
                }
            }

            return matches;
        }

        private void generateInference()
        {
            lbResult.Items.Clear();

            lbResult.Items.Add("Los resultados de la inferencia son los siguientes:");
            StorageCharacter storageCharacter = null;
            float matches = 0, percent = 0;

            for (int i = 0; i < segmentsList.Images.Count; i++)
            {
                lbResult.Items.Add("\n   Posibilidades para el caracter " + i + " del captcha:");

                for (int j = 0; j < storageCharacterList.Count; j++)
                {
                    storageCharacter = storageCharacterList.ElementAt(j);
                    matches = inference(ResizeImage((Bitmap)segmentsList.Images[i]), 
                                        ResizeImage(storageCharacter.getBitmap()));
                    percent = matches * 100 / (imageSize * imageSize);

                    if (matches > 500)
                    {
                        lbResult.Items.Add("\n      Con un %" + percent + " de probabilidades: " + 
                            storageCharacter.getCharacterString());
                    }
                }
            }
        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void segmentsUpDown_ValueChanged(object sender, EventArgs e)
        {
            pbSegments.Image = segmentsList.Images[(int)segmentsUpDown.Value];
        }

        private void bnTrain_Click(object sender, EventArgs e)
        {
            generateInference();
            train();
        }

        private void train()
        {
            int hiddenLayerSize = Int32.Parse(tbcapaoculta.Text);
            double learningRate = double.Parse(tbtasaap.Text);
            double variationRate = double.Parse(tbtasavar.Text);
            int maxPeriods = Int32.Parse(tbmaxepoc.Text);
            double maxError = double.Parse(tbminerr.Text);            
            Bitmap imageoriginal = new Bitmap(segmentsList.Images[(int)segmentsUpDown.Value]);
            Perceptron perceptron = new Perceptron( imageoriginal.Height, 
                                                    hiddenLayerSize,
                                                    imageSize, 
                                                    learningRate, 
                                                    variationRate, 
                                                    maxPeriods, 
                                                    maxError);

            lbResult.Items.Add("");
            lbResult.Items.Add("\n La red neuronal concluyo que la parabra es: " + 
                getbest(storageCharacterList, segmentsList, perceptron));
            
        }
   

        private String getbest(List<StorageCharacter> listaletras, ImageList entrada, Perceptron p)
        {
            String texto = "";
            List<double> salidas = new List<double>();
            for (int x = 0; x < entrada.Images.Count; x++)
            {
                Bitmap entradan = new Bitmap(entrada.Images[x]);
                salidas = new List<double>();
                for (int y = 0; y < listaletras.Count; y++)
                {
                    p.training(entradan, listaletras[y].getBitmap());
                    salidas.Add(p.proba);
                    
                }
                texto += listaletras[validate(salidas)].getCharacterString();
            }
            
            return texto;
        }
        public int validate(List<double> probas)
        {
            int mayor = 0;
            double num = 0;
            for (int x = 0; x < probas.Count; x++)
            {
                if (probas[x] > num)
                {
                    num = probas[x];
                    mayor = x;
                }
            }

            return mayor;
        }
    }
}
