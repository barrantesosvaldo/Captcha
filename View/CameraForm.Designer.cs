namespace IA_Proyecto_III
{
    partial class CameraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CameraForm));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.bnCapture = new System.Windows.Forms.Button();
            this.bnSave = new System.Windows.Forms.Button();
            this.cbDevices = new System.Windows.Forms.ComboBox();
            this.saveCaptureDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(784, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Images capture";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pbImage);
            this.panel1.Controls.Add(this.pbCamera);
            this.panel1.Controls.Add(this.bnCapture);
            this.panel1.Controls.Add(this.bnSave);
            this.panel1.Controls.Add(this.cbDevices);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 526);
            this.panel1.TabIndex = 1;
            // 
            // pbImage
            // 
            this.pbImage.BackColor = System.Drawing.Color.White;
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Dock = System.Windows.Forms.DockStyle.Right;
            this.pbImage.Location = new System.Drawing.Point(395, 28);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(385, 424);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            // 
            // pbCamera
            // 
            this.pbCamera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbCamera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCamera.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbCamera.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbCamera.InitialImage")));
            this.pbCamera.Location = new System.Drawing.Point(0, 28);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(385, 424);
            this.pbCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCamera.TabIndex = 3;
            this.pbCamera.TabStop = false;
            // 
            // bnCapture
            // 
            this.bnCapture.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnCapture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCapture.Location = new System.Drawing.Point(0, 452);
            this.bnCapture.Name = "bnCapture";
            this.bnCapture.Size = new System.Drawing.Size(780, 35);
            this.bnCapture.TabIndex = 2;
            this.bnCapture.Text = "Capture";
            this.bnCapture.UseVisualStyleBackColor = true;
            this.bnCapture.Click += new System.EventHandler(this.bnCapture_Click);
            // 
            // bnSave
            // 
            this.bnSave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnSave.Location = new System.Drawing.Point(0, 487);
            this.bnSave.Name = "bnSave";
            this.bnSave.Size = new System.Drawing.Size(780, 35);
            this.bnSave.TabIndex = 1;
            this.bnSave.Text = "Save capture";
            this.bnSave.UseVisualStyleBackColor = true;
            this.bnSave.Click += new System.EventHandler(this.bnSave_Click);
            // 
            // cbDevices
            // 
            this.cbDevices.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDevices.FormattingEnabled = true;
            this.cbDevices.Location = new System.Drawing.Point(0, 0);
            this.cbDevices.Name = "cbDevices";
            this.cbDevices.Size = new System.Drawing.Size(780, 28);
            this.cbDevices.TabIndex = 0;
            // 
            // saveCaptureDialog
            // 
            this.saveCaptureDialog.Title = "Save capture";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camera";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbDevices;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.Button bnCapture;
        private System.Windows.Forms.Button bnSave;
        private System.Windows.Forms.SaveFileDialog saveCaptureDialog;
    }
}

