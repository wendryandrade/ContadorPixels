using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TesteSyngenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var contaPixels = 0;
            var contaPixelsPretos = 0;
            var contaPixelsBrancos = 0;
            var contaPixelsVerdes = 0;

            Bitmap imagem = new Bitmap(pictureBox1.Image);

            for (var x = 0; x < imagem.Width; x++)
            {
                for (var y = 0; y < imagem.Height; y++)
                {
                    contaPixels++;

                    var corPixel = imagem.GetPixel(x, y).ToArgb();

                    if (corPixel == Color.Black.ToArgb())
                    {
                        contaPixelsPretos++;
                        //imagem.SetPixel(x, y, Color.White);
                    }

                    else if (corPixel == Color.White.ToArgb())
                    {
                        contaPixelsBrancos++;
                        //imagem.SetPixel(x, y, Color.Black);
                    }

                    else
                    {
                        contaPixelsVerdes++;
                        //imagem.SetPixel(x, y, Color.Red);
                    }
                }
            }

            pictureBox1.Image = imagem;

            label2.Text = String.Format("A imagem contém " + contaPixels + " pixels, " + 
                                        contaPixelsVerdes + " são verdes, " + 
                                        contaPixelsPretos + " são pretos e " + 
                                        contaPixelsBrancos + " são brancos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "bmp|*.bmp";
            if (file.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = file.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
