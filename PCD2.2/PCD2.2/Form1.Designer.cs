namespace PCD2._2
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
            this.Asal = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Hasil = new System.Windows.Forms.PictureBox();
            this.Menu = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox3 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox4 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox5 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox6 = new Emgu.CV.UI.HistogramBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pointer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Asal)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hasil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // Asal
            // 
            this.Asal.Image = global::PCD2._2.Properties.Resources.resize;
            this.Asal.Location = new System.Drawing.Point(12, 27);
            this.Asal.Name = "Asal";
            this.Asal.Size = new System.Drawing.Size(227, 191);
            this.Asal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Asal.TabIndex = 0;
            this.Asal.TabStop = false;
            this.Asal.Click += new System.EventHandler(this.Asal_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.creditToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(631, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // creditToolStripMenuItem
            // 
            this.creditToolStripMenuItem.Name = "creditToolStripMenuItem";
            this.creditToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.creditToolStripMenuItem.Text = "Credit";
            // 
            // Hasil
            // 
            this.Hasil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Hasil.Location = new System.Drawing.Point(392, 27);
            this.Hasil.Name = "Hasil";
            this.Hasil.Size = new System.Drawing.Size(227, 191);
            this.Hasil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hasil.TabIndex = 2;
            this.Hasil.TabStop = false;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Menu.FormattingEnabled = true;
            this.Menu.Items.AddRange(new object[] {
            "Brightness",
            "Invert",
            "Grayscale Perataan",
            "Grayscale Pembobotan",
            "Thresholding",
            "Histogram Equalization",
            "Contrast Stretching"});
            this.Menu.Location = new System.Drawing.Point(246, 50);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(140, 21);
            this.Menu.TabIndex = 1;
            this.Menu.Text = "Pilihan";
            this.Menu.SelectedIndexChanged += new System.EventHandler(this.Menu_SelectedIndexChanged_1);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(245, 88);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(140, 45);
            this.trackBar1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(246, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Prosses";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // histogramBox1
            // 
            this.histogramBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.histogramBox1.Location = new System.Drawing.Point(12, 269);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(177, 129);
            this.histogramBox1.TabIndex = 6;
            // 
            // histogramBox2
            // 
            this.histogramBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.histogramBox2.Location = new System.Drawing.Point(234, 269);
            this.histogramBox2.Name = "histogramBox2";
            this.histogramBox2.Size = new System.Drawing.Size(177, 129);
            this.histogramBox2.TabIndex = 7;
            // 
            // histogramBox3
            // 
            this.histogramBox3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.histogramBox3.Location = new System.Drawing.Point(442, 269);
            this.histogramBox3.Name = "histogramBox3";
            this.histogramBox3.Size = new System.Drawing.Size(177, 129);
            this.histogramBox3.TabIndex = 8;
            // 
            // histogramBox4
            // 
            this.histogramBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.histogramBox4.Location = new System.Drawing.Point(442, 433);
            this.histogramBox4.Name = "histogramBox4";
            this.histogramBox4.Size = new System.Drawing.Size(177, 129);
            this.histogramBox4.TabIndex = 11;
            // 
            // histogramBox5
            // 
            this.histogramBox5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.histogramBox5.Location = new System.Drawing.Point(234, 433);
            this.histogramBox5.Name = "histogramBox5";
            this.histogramBox5.Size = new System.Drawing.Size(177, 129);
            this.histogramBox5.TabIndex = 10;
            // 
            // histogramBox6
            // 
            this.histogramBox6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.histogramBox6.Location = new System.Drawing.Point(12, 433);
            this.histogramBox6.Name = "histogramBox6";
            this.histogramBox6.Size = new System.Drawing.Size(177, 129);
            this.histogramBox6.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Sesudah ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sebelum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "R";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(526, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "G";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "G";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(94, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(94, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "B";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(293, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Koord";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pointer
            // 
            this.pointer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pointer.Location = new System.Drawing.Point(246, 163);
            this.pointer.Name = "pointer";
            this.pointer.Size = new System.Drawing.Size(140, 23);
            this.pointer.TabIndex = 21;
            this.pointer.Text = "Pointer";
            this.pointer.UseVisualStyleBackColor = false;
            this.pointer.Click += new System.EventHandler(this.pointer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 573);
            this.Controls.Add(this.pointer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.histogramBox4);
            this.Controls.Add(this.histogramBox5);
            this.Controls.Add(this.histogramBox6);
            this.Controls.Add(this.histogramBox3);
            this.Controls.Add(this.histogramBox2);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.Hasil);
            this.Controls.Add(this.Asal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Asal)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Hasil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Asal;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditToolStripMenuItem;
        private System.Windows.Forms.PictureBox Hasil;
        private System.Windows.Forms.ComboBox Menu;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private Emgu.CV.UI.HistogramBox histogramBox2;
        private Emgu.CV.UI.HistogramBox histogramBox3;
        private Emgu.CV.UI.HistogramBox histogramBox4;
        private Emgu.CV.UI.HistogramBox histogramBox5;
        private Emgu.CV.UI.HistogramBox histogramBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button pointer;
    }
}

