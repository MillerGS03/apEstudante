using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apEstudante
{
    public partial class BotaoMenu : UserControl
    {
        Color corPadrao,
              corSelecionada;
        int incRed,
            incGreen,
            incBlue;
        UserControl telaASerMostrada;
        public BotaoMenu()
        {
            InitializeComponent();
            corPadrao = BackColor;
            corSelecionada = BackColor;
        }
        public string Titulo
        {
            get => lbTitulo.Text;
            set
            {
                lbTitulo.Text = value;
                lbTitulo.Left = 150 - lbTitulo.Width / 2;
            }
        }
        public Image Icone
        {
            get => pnIcone.BackgroundImage;
            set => pnIcone.BackgroundImage = value;
        }

        private enum Animacao { FadeIn, FadeOut, Normal }
        Animacao estado = Animacao.Normal;
        private void BotaoMenu_MouseEnter(object sender, EventArgs e)
        {
            estado = Animacao.FadeIn;
            tmrCor.Start();
        }
        public void FadeOut()
        {
            estado = Animacao.FadeOut;
            tmrCor.Start();
        }
        public void CancelarFadeOut()
        {
            estado = Animacao.FadeIn;
        }

        public Color CorPadrao
        {
            get => corPadrao;
            set
            {
                corPadrao = value;

                incRed = corSelecionada.R - corPadrao.R;
                if (incRed > 0)
                    incRed = 1;
                else
                    incRed = -1;
                incGreen = corSelecionada.G - corPadrao.G;
                if (incGreen > 0)
                    incGreen = 1;
                else
                    incGreen = -1;
                incBlue = corSelecionada.B - corPadrao.B;
                if (incBlue > 0)
                    incBlue = 1;
                else
                    incBlue = -1;
            }
        }

        private void tmrCor_Tick(object sender, EventArgs e)
        {
            int r = BackColor.R, g = BackColor.G, b = BackColor.B;
            if (estado == Animacao.FadeIn)
            {
                if (BackColor != CorSelecionada)
                {
                    if (Math.Abs(BackColor.R - corSelecionada.R) > 5)
                        r += incRed * 6;
                    else
                        r = corSelecionada.R;
                    if (Math.Abs(BackColor.G - corSelecionada.G) > 5)
                        g += incGreen * 6;
                    else
                        g = corSelecionada.G;
                    if (Math.Abs(BackColor.B - corSelecionada.B) > 5)
                        b += incBlue * 6;
                    else
                        b = corSelecionada.B;
                    BackColor = Color.FromArgb(r, g, b);
                }
                else
                    tmrCor.Stop();
            }
            else if (estado == Animacao.FadeOut)
            {
                if (BackColor != corPadrao)
                {
                    if (Math.Abs(BackColor.R - corPadrao.R) > 5)
                        r -= incRed * 6;
                    else
                        r = corPadrao.R;
                    if (Math.Abs(BackColor.G - corPadrao.G) > 5)
                        g -= incGreen * 6;
                    else
                        g = corPadrao.G;
                    if (Math.Abs(BackColor.B - corPadrao.B) > 5)
                        b -= incBlue * 6;
                    else
                        b = corPadrao.B;
                    BackColor = Color.FromArgb(r, g, b);
                }
                else
                    tmrCor.Stop();
            }
        }

        public Color CorSelecionada
        {
            get => corSelecionada; set
            {
                corSelecionada = value;
                incRed = corSelecionada.R - corPadrao.R;
                if (incRed > 0)
                    incRed = 1;
                else
                    incRed = -1;
                incGreen = corSelecionada.G - corPadrao.G;
                if (incGreen > 0)
                    incGreen = 1;
                else
                    incGreen = -1;
                incBlue = corSelecionada.B - corPadrao.B;
                if (incBlue > 0)
                    incBlue = 1;
                else
                    incBlue = -1;
            }
        }

        public UserControl TelaASerMostrada { get => telaASerMostrada; set => telaASerMostrada = value; }
        public void MostrarTela()
        {
        }
    }
}
