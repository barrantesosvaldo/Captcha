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
            this.tbminerr = new System.Windows.Forms.TextBox();
            this.tbmaxepoc = new System.Windows.Forms.TextBox();
            this.tbtasavar = new System.Windows.Forms.TextBox();
            this.tbtasaap = new System.Windows.Forms.TextBox();
            this.tbcapaoculta = new System.Windows.Forms.TextBox();
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
            this.bnTrain = new System.Windows.Forms.Button();
            this.pbCaptcha = new System.Windows.Forms.PictureBox();
            this.lbResult = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSegments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.segmentsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openDialog);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
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
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 218);
            this.panel1.TabIndex = 5;
            // 
            // tbminerr
            // 
            this.tbminerr.Location = new System.Drawing.Point(110, 180);
            this.tbminerr.Margin = new System.Windows.Forms.Padding(2);
            this.tbminerr.Name = "tbminerr";
            this.tbminerr.Size = new System.Drawing.Size(76, 20);
            this.tbminerr.TabIndex = 18;
            this.tbminerr.Text = "0.1";
            // 
            // tbmaxepoc
            // 
            this.tbmaxepoc.Location = new System.Drawing.Point(110, 149);
            this.tbmaxepoc.Margin = new System.Windows.Forms.Padding(2);
            this.tbmaxepoc.Name = "tbmaxepoc";
            this.tbmaxepoc.Size = new System.Drawing.Size(76, 20);
            this.tbmaxepoc.TabIndex = 17;
            this.tbmaxepoc.Text = "3";
            // 
            // tbtasavar
            // 
            this.tbtasavar.Location = new System.Drawing.Point(110, 119);
            this.tbtasavar.Margin = new System.Windows.Forms.Padding(2);
            this.tbtasavar.Name = "tbtasavar";
            this.tbtasavar.Size = new System.Drawing.Size(76, 20);
            this.tbtasavar.TabIndex = 16;
            this.tbtasavar.Text = "0.3";
            // 
            // tbtasaap
            // 
            this.tbtasaap.Location = new System.Drawing.Point(110, 89);
            this.tbtasaap.Margin = new System.Windows.Forms.Padding(2);
            this.tbtasaap.Name = "tbtasaap";
            this.tbtasaap.Size = new System.Drawing.Size(76, 20);
            this.tbtasaap.TabIndex = 15;
            this.tbtasaap.Text = "0.99";
            // 
            // tbcapaoculta
            // 
            this.tbcapaoculta.Location = new System.Drawing.Point(110, 63);
            this.tbcapaoculta.Margin = new System.Windows.Forms.Padding(2);
            this.tbcapaoculta.Name = "tbcapaoculta";
            this.tbcapaoculta.Size = new System.Drawing.Size(76, 20);
            this.tbcapaoculta.TabIndex = 14;
            this.tbcapaoculta.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Error minimo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Iteraciones";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tasa Variacion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tasa Aprendizaje ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Capa Oculta";
            // 
            // lblFileName
            // 
            this.lblFileName.BackColor = System.Drawing.Color.White;
            this.lblFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(124, 15);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(620, 25);
            this.lblFileName.TabIndex = 8;
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bnLoadImage
            // 
            this.bnLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnLoadImage.Location = new System.Drawing.Point(13, 15);
            this.bnLoadImage.Name = "bnLoadImage";
            this.bnLoadImage.Size = new System.Drawing.Size(105, 25);
            this.bnLoadImage.TabIndex = 6;
            this.bnLoadImage.Text = "Load image";
            this.bnLoadImage.UseVisualStyleBackColor = true;
            this.bnLoadImage.Click += new System.EventHandler(this.openDialog);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Import image";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 538);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStatusLabel
            // 
            this.toolStatusLabel.Name = "toolStatusLabel";
            this.toolStatusLabel.Size = new System.Drawing.Size(42, 17);
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
            this.pbSegments.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pbSegments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSegments.Location = new System.Drawing.Point(186, 282);
            this.pbSegments.Name = "pbSegments";
            this.pbSegments.Size = new System.Drawing.Size(165, 136);
            this.pbSegments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSegments.TabIndex = 8;
            this.pbSegments.TabStop = false;
            // 
            // segmentsUpDown
            // 
            this.segmentsUpDown.Location = new System.Drawing.Point(189, 424);
            this.segmentsUpDown.Name = "segmentsUpDown";
            this.segmentsUpDown.Size = new System.Drawing.Size(162, 20);
            this.segmentsUpDown.TabIndex = 9;
            this.segmentsUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.segmentsUpDown.ValueChanged += new System.EventHandler(this.segmentsUpDown_ValueChanged);
            // 
            // bnTrain
            // 
            this.bnTrain.Location = new System.Drawing.Point(189, 449);
            this.bnTrain.Margin = new System.Windows.Forms.Padding(2);
            this.bnTrain.Name = "bnTrain";
            this.bnTrain.Size = new System.Drawing.Size(162, 27);
            this.bnTrain.TabIndex = 9;
            this.bnTrain.Text = "Entrenar";
            this.bnTrain.UseVisualStyleBackColor = true;
            this.bnTrain.Click += new System.EventHandler(this.bnTrain_Click);
            // 
            // pbCaptcha
            // 
            this.pbCaptcha.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pbCaptcha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCaptcha.Location = new System.Drawing.Point(15, 282);
            this.pbCaptcha.Name = "pbCaptcha";
            this.pbCaptcha.Size = new System.Drawing.Size(165, 136);
            this.pbCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCaptcha.TabIndex = 11;
            this.pbCaptcha.TabStop = false;
            // 
            // lbResult
            // 
            this.lbResult.FormattingEnabled = true;
            this.lbResult.Items.AddRange(new object[] {
            "Resultados"});
            this.lbResult.Location = new System.Drawing.Point(357, 282);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(415, 134);
            this.lbResult.TabIndex = 12;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 560);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.pbCaptcha);
            this.Controls.Add(this.bnTrain);
            this.Controls.Add(this.segmentsUpDown);
            this.Controls.Add(this.pbSegments);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(800, 599);
            this.MinimumSize = new System.Drawing.Size(800, 599);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbCaptcha)).EndInit();
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
        private System.Windows.Forms.Button bnTrain;
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
        private System.Windows.Forms.PictureBox pbCaptcha;
        private System.Windows.Forms.ListBox lbResult;
    }
}