using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;


namespace IA_Proyecto_III
{
    public partial class CameraForm : Form
    {

        public CameraForm()
        {
            InitializeComponent();
            load_Devices();
            start_webcam();
        }
        private FilterInfoCollection devices;
        private VideoCaptureDevice camera;

        private void load_Devices()
        {
            devices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo VideoCaptureDevice in devices)
            {
                cbDevices.Items.Add(VideoCaptureDevice.Name);
            }
            cbDevices.SelectedIndex = 0;
        }

        void new_Camera_Frame(object sender, NewFrameEventArgs e)
        {
            Bitmap bitmap = (Bitmap)e.Frame.Clone();
            pbCamera.Image = bitmap;
        }

        private void start_webcam()
        {
            camera = new VideoCaptureDevice(
                devices[cbDevices.SelectedIndex].MonikerString);
            camera.NewFrame += new NewFrameEventHandler(new_Camera_Frame);
            camera.Start();
        }

        

        private void bnCapture_Click(object sender, EventArgs e)
        {
            
        }

        

        private void bnSave_Click(object sender, EventArgs e)
        {
            saveCaptureDialog.InitialDirectory = "/captures/";
            if (saveCaptureDialog.ShowDialog() == DialogResult.OK)
            {
                pbCamera.Image.Save(saveCaptureDialog.FileName+".jpeg");
            }
        }
    }
}
