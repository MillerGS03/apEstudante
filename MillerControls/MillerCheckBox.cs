using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MillerControls
{
    public partial class MillerCheckBox : UserControl
    {
        public MillerCheckBox()
        {
            InitializeComponent();
        }
        public bool Checked
        {
            get => BackgroundImageLayout == ImageLayout.Zoom;
            set
            {
                if (value)
                    BackgroundImageLayout = ImageLayout.Zoom;
                else
                    BackgroundImageLayout = ImageLayout.None;
            }
        }

        Color backColorChecked = Color.Silver;
        Color backColorUnchecked = Color.Silver;
        Color checkedSymbolColor = Color.Black;
        Color corBordas = Color.Black;

        public Color BackColorChecked
        {
            get => backColorChecked;
            set
            {
                backColorChecked = value;
                if (Checked)
                    BackColor = backColorChecked;
            }
        }
        public Color BackColorUnchecked
        {
            get => backColorUnchecked;
            set
            {
                backColorUnchecked = value;
                if (!Checked)
                    BackColor = backColorUnchecked;
            }
        }
        public Color CheckedSymbolColor
        {
            get => checkedSymbolColor;
            set
            {
                checkedSymbolColor = value;
                BackgroundImage = MudarCor((Bitmap)BackgroundImage, value);
            }
        }
        public Color CorBordas
        {
            get => corBordas;
            set
            {
                corBordas = value;
                panel1.BackColor = value;
                panel2.BackColor = value;
                panel3.BackColor = value;
                panel4.BackColor = value;
            }
        }
        public int TamanhoBordas
        {
            get => panel1.Width;
            set
            {
                if (value < 10 && value >= 0)
                {
                    panel1.Width = value;
                    panel2.Width = value;
                    panel3.Height = value;
                    panel4.Height = value;
                }
            }
        }

        public static Bitmap MudarCor(Bitmap scrBitmap, Color novaCor)
        {
            Color corAtual;
            Bitmap imagem = new Bitmap(scrBitmap.Width, scrBitmap.Height);

            for (int i = 0; i < scrBitmap.Width; i++)
            {
                for (int j = 0; j < scrBitmap.Height; j++)
                {
                    corAtual = scrBitmap.GetPixel(i, j);
                    if (corAtual.A > 150)
                        imagem.SetPixel(i, j, novaCor);
                    else
                        imagem.SetPixel(i, j, corAtual);
                }
            }
            return imagem;
        }

        private void MillerCheckBox_Click(object sender, EventArgs e)
        {
            Checked = !Checked;
        }
    }
}
