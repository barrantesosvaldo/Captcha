namespace IA_Proyecto_III.View
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.bnLoadImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.segmentsList = new System.Windows.Forms.ImageList(this.components);
            this.pbSegments = new System.Windows.Forms.PictureBox();
            this.segmentsUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.tbcapaoculta = new System.Windows.Forms.TextBox();
            this.tbtasaap = new System.Windows.Forms.TextBox();
            this.tbtasavar = new System.Windows.Forms.TextBox();
            this.tbmaxepoc = new System.Windows.Forms.TextBox();
            this.tbminerr = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSegments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1043, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openDialog);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(164, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openImageDialog
            // 
            this.openImageDialog.Filter = "JPEG Files (*.jpeg)|*.jpeg|JPG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|GIF Fi" +
    "les (*.gif)|*.gif|All files (*.*)|*.*";
            this.openImageDialog.Title = "Open...";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbminerr);
            this.panel1.Controls.Add(this.tbmaxepoc);
            this.panel1.Controls.Add(this.tbtasavar);
            this.panel1.Controls.Add(this.tbtasaap);
            this.panel1.Controls.Add(this.tbcapaoculta);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblFileName);
            this.panel1.Controls.Add(this.bnLoadImage);
            this.panel1.Location = new System.Drawing.Point(16, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 268);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Error minimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Epocas Maximas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tasa Variacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tasa Aprendizaje ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Capa Oculta";
            // 
            // lblFileName
            // 
            this.lblFileName.BackColor = System.Drawing.Color.White;
            this.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(165, 18);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(826, 30);
            this.lblFileName.TabIndex = 8;
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bnLoadImage
            // 
            this.bnLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnLoadImage.Location = new System.Drawing.Point(17, 18);
            this.bnLoadImage.Margin = new System.Windows.Forms.Padding(4);
            this.bnLoadImage.Name = "bnLoadImage";
            this.bnLoadImage.Size = new System.Drawing.Size(140, 31);
            this.bnLoadImage.TabIndex = 6;
            this.bnLoadImage.Text = "Load image";
            this.bnLoadImage.UseVisualStyleBackColor = true;
            this.bnLoadImage.Click += new System.EventHandler(this.openDialog);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Import image";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 656);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1043, 25);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStatusLabel
            // 
            this.toolStatusLabel.Name = "toolStatusLabel";
            this.toolStatusLabel.Size = new System.Drawing.Size(53, 20);
            this.toolStatusLabel.Text = "Ready.";
            // 
            // segmentsList
            // 
            this.segmentsList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.segmentsList.ImageSize = new System.Drawing.Size(200, 200);
            this.segmentsList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pbSegments
            // 
            this.pbSegments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSegments.Location = new System.Drawing.Point(182, 395);
            this.pbSegments.Margin = new System.Windows.Forms.Padding(4);
            this.pbSegments.Name = "pbSegments";
            this.pbSegments.Size = new System.Drawing.Size(266, 246);
            this.pbSegments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSegments.TabIndex = 8;
            this.pbSegments.TabStop = false;
            // 
            // segmentsUpDown
            // 
            this.segmentsUpDown.Location = new System.Drawing.Point(533, 603);
            this.segmentsUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.segmentsUpDown.Name = "segmentsUpDown";
            this.segmentsUpDown.Size = new System.Drawing.Size(160, 22);
            this.segmentsUpDown.TabIndex = 9;
            this.segmentsUpDown.ValueChanged += new System.EventHandler(this.segmentsUpDown_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(814, 592);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 33);
            this.button1.TabIndex = 9;
            this.button1.Text = "Entrenar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbcapaoculta
            // 
            this.tbcapaoculta.Location = new System.Drawing.Point(147, 77);
            this.tbcapaoculta.Name = "tbcapaoculta";
            this.tbcapaoculta.Size = new System.Drawing.Size(100, 22);
            this.tbcapaoculta.TabIndex = 14;
            // 
            // tbtasaap
            // 
            this.tbtasaap.Location = new System.Drawing.Point(147, 110);
            this.tbtasaap.Name = "tbtasaap";
            this.tbtasaap.Size = new System.Drawing.Size(100, 22);
            this.tbtasaap.TabIndex = 15;
            // 
            // tbtasavar
            // 
            this.tbtasavar.Location = new System.Drawing.Point(147, 146);
            this.tbtasavar.Name = "tbtasavar";
            this.tbtasavar.Size = new System.Drawing.Size(100, 22);
            this.tbtasavar.TabIndex = 16;
            // 
            // tbmaxepoc
            // 
            this.tbmaxepoc.Location = new System.Drawing.Point(147, 183);
            this.tbmaxepoc.Name = "tbmaxepoc";
            this.tbmaxepoc.Size = new System.Drawing.Size(100, 22);
            this.tbmaxepoc.TabIndex = 17;
            // 
            // tbminerr
            // 
            this.tbminerr.Location = new System.Drawing.Point(147, 221);
            this.tbminerr.Name = "tbminerr";
            this.tbminerr.Size = new System.Drawing.Size(100, 22);
            this.tbminerr.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.segmentsUpDown);
            this.Controls.Add(this.pbSegments);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1061, 728);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSegments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bnLoadImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStatusLabel;
        private System.Windows.Forms.ImageList segmentsList;
        private System.Windows.Forms.PictureBox pbSegments;
        private System.Windows.Forms.NumericUpDown segmentsUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbminerr;
        private System.Windows.Forms.TextBox tbmaxepoc;
        private System.Windows.Forms.TextBox tbtasavar;
        private System.Windows.Forms.TextBox tbtasaap;
        private System.Windows.Forms.TextBox tbcapaoculta;
    }
}