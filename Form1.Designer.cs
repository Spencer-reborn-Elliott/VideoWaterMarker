namespace VideoWaterMarker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ExportBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EnableTextOverlayChk = new System.Windows.Forms.CheckBox();
            this.EnableWatermarkChkBx = new System.Windows.Forms.CheckBox();
            this.WatermarkOptions = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.logoxaxis = new System.Windows.Forms.NumericUpDown();
            this.logoyaxis = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.WatermarkXsize = new System.Windows.Forms.NumericUpDown();
            this.WatermarkYsize = new System.Windows.Forms.NumericUpDown();
            this.SelectWaterMarkBtn = new System.Windows.Forms.Button();
            this.EnableResize = new System.Windows.Forms.CheckBox();
            this.ResizeOptions = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Xaxis = new System.Windows.Forms.NumericUpDown();
            this.Yaxis = new System.Windows.Forms.NumericUpDown();
            this.FormatChooser = new System.Windows.Forms.ComboBox();
            this.ChooseVidBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.VideoFileChooser = new System.Windows.Forms.OpenFileDialog();
            this.ThumbNailPicture = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.WatermarkFileChooser = new System.Windows.Forms.OpenFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.TextOverlayOptions = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.TransparencySlider = new System.Windows.Forms.TrackBar();
            this.label17 = new System.Windows.Forms.Label();
            this.textfont = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textxaxis = new System.Windows.Forms.NumericUpDown();
            this.textColour = new System.Windows.Forms.ComboBox();
            this.textyaxis = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.fontSize = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.OverlayText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.WatermarkOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoxaxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoyaxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatermarkXsize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatermarkYsize)).BeginInit();
            this.ResizeOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Xaxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yaxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbNailPicture)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.TextOverlayOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransparencySlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textxaxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textyaxis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportBtn
            // 
            this.ExportBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExportBtn.Location = new System.Drawing.Point(993, 534);
            this.ExportBtn.Name = "ExportBtn";
            this.ExportBtn.Size = new System.Drawing.Size(75, 23);
            this.ExportBtn.TabIndex = 0;
            this.ExportBtn.Text = "Export";
            this.ExportBtn.UseVisualStyleBackColor = true;
            this.ExportBtn.Click += new System.EventHandler(this.ExportBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.EnableTextOverlayChk);
            this.groupBox1.Controls.Add(this.EnableWatermarkChkBx);
            this.groupBox1.Controls.Add(this.WatermarkOptions);
            this.groupBox1.Controls.Add(this.EnableResize);
            this.groupBox1.Controls.Add(this.ResizeOptions);
            this.groupBox1.Controls.Add(this.FormatChooser);
            this.groupBox1.Controls.Add(this.ChooseVidBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 392);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // EnableTextOverlayChk
            // 
            this.EnableTextOverlayChk.AutoSize = true;
            this.EnableTextOverlayChk.Location = new System.Drawing.Point(3, 359);
            this.EnableTextOverlayChk.Name = "EnableTextOverlayChk";
            this.EnableTextOverlayChk.Size = new System.Drawing.Size(128, 17);
            this.EnableTextOverlayChk.TabIndex = 13;
            this.EnableTextOverlayChk.Text = "Enable Text Overlay?";
            this.EnableTextOverlayChk.UseVisualStyleBackColor = true;
            this.EnableTextOverlayChk.CheckedChanged += new System.EventHandler(this.EnableTextOverlayChk_CheckedChanged);
            // 
            // EnableWatermarkChkBx
            // 
            this.EnableWatermarkChkBx.AutoSize = true;
            this.EnableWatermarkChkBx.Enabled = false;
            this.EnableWatermarkChkBx.Location = new System.Drawing.Point(6, 89);
            this.EnableWatermarkChkBx.Name = "EnableWatermarkChkBx";
            this.EnableWatermarkChkBx.Size = new System.Drawing.Size(159, 17);
            this.EnableWatermarkChkBx.TabIndex = 12;
            this.EnableWatermarkChkBx.Text = "Enable Watermark Options?";
            this.EnableWatermarkChkBx.UseVisualStyleBackColor = true;
            this.EnableWatermarkChkBx.CheckedChanged += new System.EventHandler(this.EnableWatermarkChkBx_CheckedChanged);
            // 
            // WatermarkOptions
            // 
            this.WatermarkOptions.Controls.Add(this.label8);
            this.WatermarkOptions.Controls.Add(this.label9);
            this.WatermarkOptions.Controls.Add(this.label10);
            this.WatermarkOptions.Controls.Add(this.logoxaxis);
            this.WatermarkOptions.Controls.Add(this.logoyaxis);
            this.WatermarkOptions.Controls.Add(this.label5);
            this.WatermarkOptions.Controls.Add(this.label6);
            this.WatermarkOptions.Controls.Add(this.label7);
            this.WatermarkOptions.Controls.Add(this.WatermarkXsize);
            this.WatermarkOptions.Controls.Add(this.WatermarkYsize);
            this.WatermarkOptions.Controls.Add(this.SelectWaterMarkBtn);
            this.WatermarkOptions.Enabled = false;
            this.WatermarkOptions.Location = new System.Drawing.Point(4, 108);
            this.WatermarkOptions.Name = "WatermarkOptions";
            this.WatermarkOptions.Size = new System.Drawing.Size(189, 147);
            this.WatermarkOptions.TabIndex = 11;
            this.WatermarkOptions.TabStop = false;
            this.WatermarkOptions.Text = "Watermark Options";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(95, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Y-Axis Position";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "X-Axis Position";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(77, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "X";
            // 
            // logoxaxis
            // 
            this.logoxaxis.Enabled = false;
            this.logoxaxis.Location = new System.Drawing.Point(6, 119);
            this.logoxaxis.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.logoxaxis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.logoxaxis.Name = "logoxaxis";
            this.logoxaxis.Size = new System.Drawing.Size(65, 20);
            this.logoxaxis.TabIndex = 16;
            this.logoxaxis.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.logoxaxis.ValueChanged += new System.EventHandler(this.logoxaxis_ValueChanged);
            // 
            // logoyaxis
            // 
            this.logoyaxis.Enabled = false;
            this.logoyaxis.Location = new System.Drawing.Point(98, 119);
            this.logoyaxis.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.logoyaxis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.logoyaxis.Name = "logoyaxis";
            this.logoyaxis.Size = new System.Drawing.Size(65, 20);
            this.logoyaxis.TabIndex = 17;
            this.logoyaxis.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.logoyaxis.ValueChanged += new System.EventHandler(this.logoyaxis_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Height Size";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Width Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "X";
            // 
            // WatermarkXsize
            // 
            this.WatermarkXsize.Enabled = false;
            this.WatermarkXsize.Location = new System.Drawing.Point(6, 71);
            this.WatermarkXsize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WatermarkXsize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WatermarkXsize.Name = "WatermarkXsize";
            this.WatermarkXsize.Size = new System.Drawing.Size(65, 20);
            this.WatermarkXsize.TabIndex = 11;
            this.WatermarkXsize.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.WatermarkXsize.ValueChanged += new System.EventHandler(this.WatermarkXsize_ValueChanged);
            // 
            // WatermarkYsize
            // 
            this.WatermarkYsize.Enabled = false;
            this.WatermarkYsize.Location = new System.Drawing.Point(98, 71);
            this.WatermarkYsize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.WatermarkYsize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WatermarkYsize.Name = "WatermarkYsize";
            this.WatermarkYsize.Size = new System.Drawing.Size(65, 20);
            this.WatermarkYsize.TabIndex = 12;
            this.WatermarkYsize.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.WatermarkYsize.ValueChanged += new System.EventHandler(this.WatermarkYsize_ValueChanged);
            // 
            // SelectWaterMarkBtn
            // 
            this.SelectWaterMarkBtn.Location = new System.Drawing.Point(6, 19);
            this.SelectWaterMarkBtn.Name = "SelectWaterMarkBtn";
            this.SelectWaterMarkBtn.Size = new System.Drawing.Size(100, 33);
            this.SelectWaterMarkBtn.TabIndex = 10;
            this.SelectWaterMarkBtn.Text = "Select Watermark";
            this.SelectWaterMarkBtn.UseVisualStyleBackColor = true;
            this.SelectWaterMarkBtn.Click += new System.EventHandler(this.SelectWaterMarkBtn_Click);
            // 
            // EnableResize
            // 
            this.EnableResize.AutoSize = true;
            this.EnableResize.Location = new System.Drawing.Point(4, 260);
            this.EnableResize.Name = "EnableResize";
            this.EnableResize.Size = new System.Drawing.Size(99, 17);
            this.EnableResize.TabIndex = 9;
            this.EnableResize.Text = "Resize Output?";
            this.EnableResize.UseVisualStyleBackColor = true;
            this.EnableResize.CheckedChanged += new System.EventHandler(this.EnableResize_CheckedChanged);
            // 
            // ResizeOptions
            // 
            this.ResizeOptions.Controls.Add(this.label4);
            this.ResizeOptions.Controls.Add(this.label3);
            this.ResizeOptions.Controls.Add(this.label2);
            this.ResizeOptions.Controls.Add(this.Xaxis);
            this.ResizeOptions.Controls.Add(this.Yaxis);
            this.ResizeOptions.Enabled = false;
            this.ResizeOptions.Location = new System.Drawing.Point(3, 278);
            this.ResizeOptions.Name = "ResizeOptions";
            this.ResizeOptions.Size = new System.Drawing.Size(189, 75);
            this.ResizeOptions.TabIndex = 8;
            this.ResizeOptions.TabStop = false;
            this.ResizeOptions.Text = "Resize Options";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y-Axis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "X-Axis";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "X";
            // 
            // Xaxis
            // 
            this.Xaxis.Location = new System.Drawing.Point(6, 43);
            this.Xaxis.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Xaxis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Xaxis.Name = "Xaxis";
            this.Xaxis.Size = new System.Drawing.Size(65, 20);
            this.Xaxis.TabIndex = 6;
            this.Xaxis.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // Yaxis
            // 
            this.Yaxis.Location = new System.Drawing.Point(98, 43);
            this.Yaxis.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Yaxis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Yaxis.Name = "Yaxis";
            this.Yaxis.Size = new System.Drawing.Size(65, 20);
            this.Yaxis.TabIndex = 7;
            this.Yaxis.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // FormatChooser
            // 
            this.FormatChooser.FormattingEnabled = true;
            this.FormatChooser.Items.AddRange(new object[] {
            ".avi format",
            ".mp4 format",
            ".m4v format",
            ".gif format",
            ".mov format",
            ".wmv format",
            ".swf format",
            ".ogg format",
            ".mpeg format"});
            this.FormatChooser.Location = new System.Drawing.Point(6, 58);
            this.FormatChooser.Name = "FormatChooser";
            this.FormatChooser.Size = new System.Drawing.Size(131, 21);
            this.FormatChooser.TabIndex = 5;
            this.FormatChooser.Text = "Choose Output Format";
            // 
            // ChooseVidBtn
            // 
            this.ChooseVidBtn.Location = new System.Drawing.Point(6, 20);
            this.ChooseVidBtn.Name = "ChooseVidBtn";
            this.ChooseVidBtn.Size = new System.Drawing.Size(99, 33);
            this.ChooseVidBtn.TabIndex = 3;
            this.ChooseVidBtn.Text = "Select Video File";
            this.ChooseVidBtn.UseVisualStyleBackColor = true;
            this.ChooseVidBtn.Click += new System.EventHandler(this.ChooseVidBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(675, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "This application will allow you to choose a video and add a watermark image to it" +
    ", you can resize the video and change the output format, too.";
            // 
            // ThumbNailPicture
            // 
            this.ThumbNailPicture.Location = new System.Drawing.Point(6, 19);
            this.ThumbNailPicture.Name = "ThumbNailPicture";
            this.ThumbNailPicture.Size = new System.Drawing.Size(835, 367);
            this.ThumbNailPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ThumbNailPicture.TabIndex = 4;
            this.ThumbNailPicture.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ThumbNailPicture);
            this.groupBox2.Location = new System.Drawing.Point(221, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 392);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Preview";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(621, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "The processed output file will save to the same location as the video file chosen" +
    " (it will save a copy, the original will be unaffected).";
            // 
            // TextOverlayOptions
            // 
            this.TextOverlayOptions.Controls.Add(this.label18);
            this.TextOverlayOptions.Controls.Add(this.TransparencySlider);
            this.TextOverlayOptions.Controls.Add(this.label17);
            this.TextOverlayOptions.Controls.Add(this.textfont);
            this.TextOverlayOptions.Controls.Add(this.label15);
            this.TextOverlayOptions.Controls.Add(this.label16);
            this.TextOverlayOptions.Controls.Add(this.label14);
            this.TextOverlayOptions.Controls.Add(this.textxaxis);
            this.TextOverlayOptions.Controls.Add(this.textColour);
            this.TextOverlayOptions.Controls.Add(this.textyaxis);
            this.TextOverlayOptions.Controls.Add(this.label13);
            this.TextOverlayOptions.Controls.Add(this.fontSize);
            this.TextOverlayOptions.Controls.Add(this.label12);
            this.TextOverlayOptions.Controls.Add(this.OverlayText);
            this.TextOverlayOptions.Enabled = false;
            this.TextOverlayOptions.Location = new System.Drawing.Point(12, 436);
            this.TextOverlayOptions.Name = "TextOverlayOptions";
            this.TextOverlayOptions.Size = new System.Drawing.Size(1056, 92);
            this.TextOverlayOptions.TabIndex = 7;
            this.TextOverlayOptions.TabStop = false;
            this.TextOverlayOptions.Text = "Text Over-lay Options";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(720, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "Transparency:";
            // 
            // TransparencySlider
            // 
            this.TransparencySlider.Enabled = false;
            this.TransparencySlider.Location = new System.Drawing.Point(801, 11);
            this.TransparencySlider.Maximum = 255;
            this.TransparencySlider.Name = "TransparencySlider";
            this.TransparencySlider.Size = new System.Drawing.Size(249, 45);
            this.TransparencySlider.TabIndex = 27;
            this.TransparencySlider.TickFrequency = 10;
            this.TransparencySlider.Value = 255;
            this.TransparencySlider.Scroll += new System.EventHandler(this.TransparencySlider_Scroll);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(359, 69);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(31, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Font:";
            // 
            // textfont
            // 
            this.textfont.Enabled = false;
            this.textfont.FormattingEnabled = true;
            this.textfont.Location = new System.Drawing.Point(396, 60);
            this.textfont.Name = "textfont";
            this.textfont.Size = new System.Drawing.Size(217, 21);
            this.textfont.TabIndex = 25;
            this.textfont.SelectedIndexChanged += new System.EventHandler(this.textfont_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(780, 69);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 24;
            this.label15.Text = "Y-Axis Position:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(624, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "X-Axis Position:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(126, 67);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "Font Color:";
            // 
            // textxaxis
            // 
            this.textxaxis.Enabled = false;
            this.textxaxis.Location = new System.Drawing.Point(704, 62);
            this.textxaxis.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.textxaxis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textxaxis.Name = "textxaxis";
            this.textxaxis.Size = new System.Drawing.Size(65, 20);
            this.textxaxis.TabIndex = 21;
            this.textxaxis.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.textxaxis.ValueChanged += new System.EventHandler(this.textxaxis_ValueChanged);
            // 
            // textColour
            // 
            this.textColour.Enabled = false;
            this.textColour.FormattingEnabled = true;
            this.textColour.Location = new System.Drawing.Point(186, 60);
            this.textColour.Name = "textColour";
            this.textColour.Size = new System.Drawing.Size(160, 21);
            this.textColour.TabIndex = 23;
            this.textColour.SelectedIndexChanged += new System.EventHandler(this.textColour_SelectedIndexChanged);
            // 
            // textyaxis
            // 
            this.textyaxis.Enabled = false;
            this.textyaxis.Location = new System.Drawing.Point(860, 62);
            this.textyaxis.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.textyaxis.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textyaxis.Name = "textyaxis";
            this.textyaxis.Size = new System.Drawing.Size(65, 20);
            this.textyaxis.TabIndex = 22;
            this.textyaxis.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.textyaxis.ValueChanged += new System.EventHandler(this.textyaxis_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 67);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Font Size:";
            // 
            // fontSize
            // 
            this.fontSize.Enabled = false;
            this.fontSize.Location = new System.Drawing.Point(66, 60);
            this.fontSize.Maximum = new decimal(new int[] {
            700,
            0,
            0,
            0});
            this.fontSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fontSize.Name = "fontSize";
            this.fontSize.Size = new System.Drawing.Size(44, 20);
            this.fontSize.TabIndex = 21;
            this.fontSize.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.fontSize.ValueChanged += new System.EventHandler(this.fontSize_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Text:";
            // 
            // OverlayText
            // 
            this.OverlayText.Location = new System.Drawing.Point(66, 21);
            this.OverlayText.Name = "OverlayText";
            this.OverlayText.Size = new System.Drawing.Size(637, 20);
            this.OverlayText.TabIndex = 0;
            this.OverlayText.TextChanged += new System.EventHandler(this.OverlayText_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 569);
            this.Controls.Add(this.TextOverlayOptions);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExportBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Video Water Marker (v2.0) - Written by Spencer Elliott";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.WatermarkOptions.ResumeLayout(false);
            this.WatermarkOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoxaxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoyaxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatermarkXsize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WatermarkYsize)).EndInit();
            this.ResizeOptions.ResumeLayout(false);
            this.ResizeOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Xaxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yaxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbNailPicture)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.TextOverlayOptions.ResumeLayout(false);
            this.TextOverlayOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TransparencySlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textxaxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textyaxis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fontSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExportBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog VideoFileChooser;
        private System.Windows.Forms.Button ChooseVidBtn;
        private System.Windows.Forms.ComboBox FormatChooser;
        private System.Windows.Forms.PictureBox ThumbNailPicture;
        private System.Windows.Forms.CheckBox EnableResize;
        private System.Windows.Forms.GroupBox ResizeOptions;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Xaxis;
        private System.Windows.Forms.NumericUpDown Yaxis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SelectWaterMarkBtn;
        private System.Windows.Forms.OpenFileDialog WatermarkFileChooser;
        private System.Windows.Forms.CheckBox EnableWatermarkChkBx;
        private System.Windows.Forms.GroupBox WatermarkOptions;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown WatermarkXsize;
        private System.Windows.Forms.NumericUpDown WatermarkYsize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown logoxaxis;
        private System.Windows.Forms.NumericUpDown logoyaxis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox EnableTextOverlayChk;
        private System.Windows.Forms.GroupBox TextOverlayOptions;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox OverlayText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown fontSize;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox textColour;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown textxaxis;
        private System.Windows.Forms.NumericUpDown textyaxis;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox textfont;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TrackBar TransparencySlider;
    }
}

