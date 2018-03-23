using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;


using Emgu.CV;
using Emgu.CV.Structure;

namespace PCD2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(Asal.Image); //awal
            Bitmap bmp2 = new Bitmap(Asal.Image); //hasil

            int r, g, b, gs;

            float val;

            Color c;
            if (Menu.Text == "Pilihan") val = 0;
            else val = (float)Convert.ToDouble(trackBar1.Value*10);

            Cursor = Cursors.WaitCursor;
            for (int i = 0; i < bmp1.Width; i++)
            {
                for (int j = 0; j < bmp1.Height; j++)
                {
                    c = bmp1.GetPixel(i, j);

                    if (Menu.SelectedIndex == 0)
                    {
                        r = c.R + (int)val;
                        g = c.G + (int)val;
                        b = c.B + (int)val;
                        if (r > 255) r = 255;
                        if (g > 255) g = 255;
                        if (b > 255) b = 255;
                        if (r < 0) r = 0;
                        if (g < 0) g = 0;
                        if (b < 0) b = 0;
                        bmp2.SetPixel(i, j, Color.FromArgb(r, g, b));
                    }
                    else if (Menu.SelectedIndex == 1)
                    {
                        bmp2.SetPixel(i, j, Color.FromArgb(255, (255 - c.R), (255 - c.G), (255 - c.B)));
                    }
                    else if (Menu.SelectedIndex == 2)
                    {
                        gs = (c.R + c.G + c.B) / 3;
                        bmp2.SetPixel(i, j, Color.FromArgb(gs, gs, gs));
                    }
                    else if (Menu.SelectedIndex == 2)
                    {
                        gs = (int)(c.R * 0.299 + c.G * 0.587 + c.B * 0.114);
                        bmp2.SetPixel(i, j, Color.FromArgb(gs, gs, gs));
                    }
                    else if (Menu.SelectedIndex == 3)
                    {
                        int a;
                        gs = (int)(c.R * 0.299 + c.G * 0.587 + c.B * 0.114);
                        if (gs > (val * 255)) a = 255;
                        else a = 0;

                        bmp2.SetPixel(i, j, Color.FromArgb(a, a, a));
                    }
                    else if (Menu.SelectedIndex == 4)
                    {
                        //r = (GetRValue(rgb) - min) * 255 / (max - min);
                        //g = (GetGValue(rgb) - min) * 255 / (max - min);
                        //b = (GetBValue(rgb) - min) * 255 / (max - min);
                        //dc.SetPixel(x, y, RGB(r, g, b));
                    }
                }
            }

            Hasil.Image = bmp2;
            Cursor = Cursors.Default;
            var asal = new Image<Bgr, Byte>(new Bitmap(bmp1));
            var hasil = new Image<Bgr, Byte>(new Bitmap(bmp2));
            histogramBox1.ClearHistogram();
            histogramBox2.ClearHistogram();
            histogramBox3.ClearHistogram();
            histogramBox4.ClearHistogram();
            histogramBox5.ClearHistogram();
            histogramBox6.ClearHistogram();
            histogramBox1.GenerateHistograms(asal[0], 256);
            histogramBox2.GenerateHistograms(asal[1], 256);
            histogramBox3.GenerateHistograms(asal[2], 256);
            histogramBox4.GenerateHistograms(asal[0], 256);
            histogramBox5.GenerateHistograms(asal[1], 256);
            histogramBox6.GenerateHistograms(asal[2], 256);
            histogramBox1.Refresh();
            histogramBox2.Refresh();
            histogramBox3.Refresh();
            histogramBox4.Refresh();
            histogramBox5.Refresh();
            histogramBox6.Refresh();
        }

        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Menu.SelectedIndex == 0) trackBar1.Visible = true;
            else if (Menu.SelectedIndex == 1) trackBar1.Visible = false;
            else if (Menu.SelectedIndex == 2) trackBar1.Visible = false;
            else if (Menu.SelectedIndex == 3) trackBar1.Visible = false;
            else if (Menu.SelectedIndex == 4) trackBar1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void Asal_Click(object sender, EventArgs e)
        {
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;

            label9.Text = "Posisi : " + Convert.ToString(X) + ", " + Convert.ToString(Y);
        }

        private void Menu_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void pointer_Click(object sender, EventArgs e)
        {
            Bitmap bmp1 = new Bitmap(Asal.Image); //awal
            Bitmap bmp2 = new Bitmap(Asal.Image); //hasil
            konversi2GreyViaPointer(bmp1);
        }
        
        private void konversi2GreyViaPointer(Bitmap bmp)
        {
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* p = (byte*)(void*)bmpData.Scan0.ToPointer();
                int stopAddress = (int)p + bmpData.Stride * bmpData.Height;
                while ((int)p != stopAddress)
                {
                    p[0] = (byte)(.299 * p[2] + .587 * p[1] + .114 * p[2]);
                    p[1] = p[0];
                    p[2] = p[0];
                    p += 3;
                }
            }
            bmp.UnlockBits(bmpData);
            Hasil.Image = bmp;

        }
    }
}
