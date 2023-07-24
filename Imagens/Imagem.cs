using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math;
using System.Runtime.Remoting.Messaging;

namespace Imagens
{
    internal class Imagem
    {
        private string nome;
        private string caminho;
        private string localizacao;
        private string grau;

        public string Nome { get => nome; set => nome = value; }
        public string Caminho { get => caminho; set => caminho = value; }
        public string Localizacao { get => localizacao; set => localizacao = value; }
        public string Grau { get => grau; set => grau = value; }

        public Imagem() { }

        public Imagem(string _nome, string _caminho)
        {
            nome = _nome;
            caminho = _caminho;
        }

        public Imagem(string _nome, string _caminho, string _localizacao, string _grau)
        {
            nome = _nome;
            caminho = _caminho;
            localizacao = _localizacao;
            grau = _grau;
        }

        public virtual double mean(Bitmap imagem)
        {
            int rows = imagem.Width;
            int cols = imagem.Height;

            int sumR = 0;
            int sumG = 0;
            int sumB = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Color pixel = imagem.GetPixel(i, j);

                    sumR += pixel.R;
                    sumG += pixel.G;
                    sumB += pixel.B;

                }
            }

            double mean;

            mean = (sumR + sumG + sumB) / (rows * cols);

            return mean;
        }

        public virtual double std(Bitmap imagem)
        {
            int totalPixels = imagem.Width * imagem.Height;
            double sumRedSquared = 0;
            double sumGreenSquared = 0;
            double sumBlueSquared = 0;
            double sumRed = 0;
            double sumGreen = 0;
            double sumBlue = 0;

            for (int y = 0; y < imagem.Height; y++)
            {
                for (int x = 0; x < imagem.Width; x++)
                {
                    Color pixelColor = imagem.GetPixel(x, y);
                    double red = pixelColor.R;
                    double green = pixelColor.G;
                    double blue = pixelColor.B;

                    sumRed += red;
                    sumGreen += green;
                    sumBlue += blue;

                    sumRedSquared += red * red;
                    sumGreenSquared += green * green;
                    sumBlueSquared += blue * blue;
                }
            }

            double meanRed = sumRed / totalPixels;
            double meanGreen = sumGreen / totalPixels;
            double meanBlue = sumBlue / totalPixels;

            double varianceRed = (sumRedSquared / totalPixels) - (meanRed * meanRed);
            double varianceGreen = (sumGreenSquared / totalPixels) - (meanGreen * meanGreen);
            double varianceBlue = (sumBlueSquared / totalPixels) - (meanBlue * meanBlue);

            double stdDeviationRed = Math.Sqrt(varianceRed);
            double stdDeviationGreen = Math.Sqrt(varianceGreen);
            double stdDeviationBlue = Math.Sqrt(varianceBlue);

            return (stdDeviationRed + stdDeviationGreen + stdDeviationBlue) / 3;
        }

        public virtual double median(Bitmap image)
        {
            List<int> pixelValues = new List<int>();

            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixelColor = image.GetPixel(x, y);
                    int grayValue = (pixelColor.R + pixelColor.G + pixelColor.B) / 3;
                    pixelValues.Add(grayValue);
                }
            }

            pixelValues.Sort();

            double median;
            if (pixelValues.Count % 2 == 0)
            {
                int middleIndex1 = pixelValues.Count / 2 - 1;
                int middleIndex2 = middleIndex1 + 1;
                median = (pixelValues[middleIndex1] + pixelValues[middleIndex2]) / 2.0;
            }
            else
            {
                int middleIndex = pixelValues.Count / 2;
                median = pixelValues[middleIndex];
            }

            return median;
        }

        public Bitmap transformarCinza(Bitmap imagem)
        {
            Bitmap imgCinza = imagem;

            int rows = imagem.Width;
            int cols = imagem.Height;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Color pixel = imgCinza.GetPixel(i, j);

                    int r, g, b;
                    r = pixel.R;
                    g = pixel.G;
                    b = pixel.B;

                    float media = (r + g + b) / 3;
                    int m = Convert.ToInt32(media);

                    imgCinza.SetPixel(i, j, Color.FromArgb(m, m, m));
                }
            }

            return imgCinza;
        }

        public Bitmap canalR(Bitmap imagem)
        {
            Bitmap imagemVermelha = new Bitmap(imagem.Width, imagem.Height);

            for (int x = 0; x < imagem.Width; x++)
            {
                for (int y = 0; y < imagem.Height; y++)
                {
                    // Obtém a cor do pixel da imagem original
                    Color corOriginal = imagem.GetPixel(x, y);

                    // Cria uma nova cor com o canal vermelho isolado
                    Color corVermelha = Color.FromArgb(corOriginal.R, 0, 0);

                    // Define a cor na imagem vermelha
                    imagemVermelha.SetPixel(x, y, corVermelha);
                }
            }
            return imagemVermelha;
        }

        public Bitmap canalG(Bitmap imagem)
        {
            Bitmap imagemVerde = new Bitmap(imagem.Width, imagem.Height);

            for (int x = 0; x < imagem.Width; x++)
            {
                for (int y = 0; y < imagem.Height; y++)
                {
                    // Obtém a cor do pixel da imagem original
                    Color corOriginal = imagem.GetPixel(x, y);

                    // Cria uma nova cor com o canal vermelho isolado
                    Color corVerde = Color.FromArgb(0, corOriginal.G, 0);

                    // Define a cor na imagem vermelha
                    imagemVerde.SetPixel(x, y, corVerde);
                }
            }
            return imagemVerde;

        }

        public Bitmap canalB(Bitmap imagem)
        {
            Bitmap imagemAzul = new Bitmap(imagem.Width, imagem.Height);

            for (int x = 0; x < imagem.Width; x++)
            {
                for (int y = 0; y < imagem.Height; y++)
                {
                    // Obtém a cor do pixel da imagem original
                    Color corOriginal = imagem.GetPixel(x, y);

                    // Cria uma nova cor com o canal vermelho isolado
                    Color corAzul = Color.FromArgb(0, 0, corOriginal.B);

                    // Define a cor na imagem vermelha
                    imagemAzul.SetPixel(x, y, corAzul);
                }
            }
            return imagemAzul;

        }

        //public Chart histograma(Bitmap imagem)
        // {
        //     Histogram histograma = new Histogram(imagem);

        //     HistogramChart graficoHistograma = new HistogramChart(histograma);

        //     // Exibe o gráfico em uma nova janela
        //     Form formHistograma = new Form();
        //     formHistograma.Text = "Histograma";
        //     formHistograma.ClientSize = new Size(400, 300);
        //     formHistograma.Controls.Add(graficoHistograma);
        //     formHistograma.ShowDialog();
        // }

        public Bitmap limiarizacao(Bitmap imagem)
        {
            double media = mean(imagem);
            double desvio = std(imagem);
            double med = median(imagem);

            double limiar = Math.Round(media + desvio + med);

            Bitmap imgProcessada = imagem;

            int rows = imagem.Width;
            int cols = imagem.Height;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Color pixel = imagem.GetPixel(i, j);

                    int r, g, b;
                    r = pixel.R;
                    g = pixel.G;
                    b = pixel.B;

                    if (r <= limiar)
                    {
                        r = 0;
                    }
                    if (g <= limiar)
                    {
                        g = 0;
                    }
                    if (b <= limiar)
                    {
                        b = 0;
                    }

                    imgProcessada.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
            return imgProcessada;
        }

        public Bitmap maisBrilho(Bitmap imagem)
        {

            Bitmap imagemBrilhoAumentado = imagem;

            for (int x = 0; x < imagem.Width; x++)
            {
                for (int y = 0; y < imagem.Height; y++)
                {
                    Color corOriginal = imagem.GetPixel(x, y);
                    int brilhoAumentadoR = corOriginal.R + 10;
                    int brilhoAumentadoG = corOriginal.G + 10;
                    int brilhoAumentadoB = corOriginal.B + 10;

                    if (brilhoAumentadoR > 255 || brilhoAumentadoG > 255 || brilhoAumentadoB > 255)
                    {
                        brilhoAumentadoR = 255;
                        brilhoAumentadoG = 255;
                        brilhoAumentadoB = 255;
                    }

                    Color corBrilhoAumentado = Color.FromArgb(brilhoAumentadoR, brilhoAumentadoG, brilhoAumentadoB);
                    imagemBrilhoAumentado.SetPixel(x, y, corBrilhoAumentado);
                }
            }

            return imagemBrilhoAumentado;
        }

        public Bitmap menosBrilho(Bitmap imagem)
        {

            Bitmap imagemBrilhoReduzido = imagem;

            for (int x = 0; x < imagem.Width; x++)
            {
                for (int y = 0; y < imagem.Height; y++)
                {
                    Color corOriginal = imagem.GetPixel(x, y);
                    int brilhoReduzidoR = corOriginal.R - 10;
                    int brilhoReduzidoG = corOriginal.G - 10;
                    int brilhoReduzidoB = corOriginal.B - 10;

                    if (brilhoReduzidoR <= 0 || brilhoReduzidoG <= 0 || brilhoReduzidoB <= 0)
                    {
                        brilhoReduzidoR = 0;
                        brilhoReduzidoG = 0;
                        brilhoReduzidoB = 0;
                    }

                    Color corBrilhoReduzido = Color.FromArgb(brilhoReduzidoR, brilhoReduzidoG, brilhoReduzidoB);
                    imagemBrilhoReduzido.SetPixel(x, y, corBrilhoReduzido);
                }
            }

            return imagemBrilhoReduzido;
        }

    }
}
