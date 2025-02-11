using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace CW
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Image<Bgr, byte> sourceImage;

        private void Load_Click(object sender, EventArgs e)
        {
            Res.Image = null;
            OpenFileDialog ofd = new OpenFileDialog();
            var result = ofd.ShowDialog();

            if (result == DialogResult.OK)
            {
                string filename = ofd.FileName;
                sourceImage = new Image<Bgr, byte>(filename);
                OG.Image = sourceImage.Resize(OG.Width, OG.Height, Inter.LinearExact);
            }
        }

        private void Brightness_Scroll(object sender, EventArgs e)
        {
            var brightnessImg = sourceImage.Copy();
            double alpha = Brightness.Value * 10;

            for (int channel = 0; channel < 3; channel++)
                for (int y = 0; y < brightnessImg.Height; y++)
                    for (int x = 0; x < brightnessImg.Width; x++)
                    {
                        if ((brightnessImg.Data[y, x, channel] + alpha) > 255)
                            brightnessImg.Data[y, x, channel] = 255;
                        else
                            brightnessImg.Data[y, x, channel] = Convert.ToByte(brightnessImg.Data[y, x, channel] + alpha);
                    }

            Res.Image = brightnessImg.Resize(Res.Width, Res.Height, Inter.LinearExact);
        }

        private void Contrast_Scroll(object sender, EventArgs e)
        {
            var contrastImg = sourceImage.Copy();
            double beta = Contrast.Value * 0.2;

            for (int channel = 0; channel < 3; channel++)
                for (int y = 0; y < contrastImg.Height; y++)
                    for (int x = 0; x < contrastImg.Width; x++)
                    {
                        if ((contrastImg.Data[y, x, channel] * beta) > 255)
                            contrastImg.Data[y, x, channel] = 255;
                        else
                            contrastImg.Data[y, x, channel] = Convert.ToByte(contrastImg.Data[y, x, channel] * beta);
                    }

            Res.Image = contrastImg.Resize(Res.Width, Res.Height, Inter.LinearExact);
        }

        private void AquarelleFilter_Click(object sender, EventArgs e)
        {
            Res.Image = null;

            Image<Bgr, byte> mask = new Image<Bgr, byte>("D:\\VS\\Projects\\АОЦИ\\CW\\Resources\\Images\\aquarelle.jpg");

            if(mask != null && sourceImage != null && mask.Size != sourceImage.Size)
                mask = mask.Resize(sourceImage.Width, sourceImage.Height, Inter.LinearExact);

            if (sourceImage.NumberOfChannels != mask.NumberOfChannels || sourceImage.Mat.Depth != mask.Mat.Depth)
            {
                MessageBox.Show("ERROR! Images should have the same depth and number of channels.");
            }
            
            else
            {
                CvInvoke.AddWeighted(sourceImage, 0.5, mask, 0.6, 0, sourceImage);
            }
                
            Res.Image = sourceImage.Resize(Res.Width, Res.Height, Inter.LinearExact);
        }

        private void BlurBar_Scroll(object sender, EventArgs e)
        {
            Image<Bgr, byte> blurImg = sourceImage.CopyBlank();
            int kernelSize = BlurBar.Value * 2 + 1; 
            int shift = kernelSize / 2;
            List<byte> l = new List<byte>();

            for (int ch = 0; ch < 3; ch++)
            {
                for (int y = shift; y < sourceImage.Height - shift; y++)
                {
                    for (int x = shift; x < sourceImage.Width - shift; x++)
                    {
                        l.Clear();
                        
                        for (int i = -shift; i <= shift; i++)
                            for (int j = -shift; j <= shift; j++)
                            {
                                l.Add(sourceImage.Data[i + y, j + x, ch]);
                            }
                        
                        l.Sort();
                        
                        blurImg.Data[y, x, ch] = l[l.Count / 2]; 
                    }
                }
            }
            
            Res.Image = blurImg.Resize(Res.Width, Res.Height, Inter.LinearExact);
        }
    }
}
