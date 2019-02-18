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
    public partial class MillerButton : UserControl
    {
        public MillerButton()
        {
            InitializeComponent();
        }

        int incRed,
            incGreen,
            incBlue,
            fadeSpeed = 6;
        bool autoFadeOut = true;
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
            FadeIn();
        }

        public void FadeOut()
        {
            estado = Animacao.FadeOut;
            tmrCor.Start();
        }
        public void FadeIn()
        {
            estado = Animacao.FadeIn;
            tmrCor.Start();
        }

        private void tmrCor_Tick(object sender, EventArgs e)
        {
            int r = BackColor.R, g = BackColor.G, b = BackColor.B;
            if (estado == Animacao.FadeIn)
            {
                if (BackColor != CorMouseHover)
                {
                    if (Math.Abs(BackColor.R - corMouseHover.R) > fadeSpeed - 1)
                        r += incRed * fadeSpeed;
                    else
                        r = corMouseHover.R;
                    if (Math.Abs(BackColor.G - corMouseHover.G) > fadeSpeed - 1)
                        g += incGreen * fadeSpeed;
                    else
                        g = corMouseHover.G;
                    if (Math.Abs(BackColor.B - corMouseHover.B) > fadeSpeed - 1)
                        b += incBlue * fadeSpeed;
                    else
                        b = corMouseHover.B;
                    BackColor = Color.FromArgb(r, g, b);
                }
                else
                    tmrCor.Stop();
            }
            else if (estado == Animacao.FadeOut)
            {
                if (BackColor != corPadrao)
                {
                    if (Math.Abs(BackColor.R - corPadrao.R) > fadeSpeed - 1)
                        r -= incRed * fadeSpeed;
                    else
                        r = corPadrao.R;
                    if (Math.Abs(BackColor.G - corPadrao.G) > fadeSpeed - 1)
                        g -= incGreen * fadeSpeed;
                    else
                        g = corPadrao.G;
                    if (Math.Abs(BackColor.B - corPadrao.B) > fadeSpeed - 1)
                        b -= incBlue * fadeSpeed;
                    else
                        b = corPadrao.B;
                    BackColor = Color.FromArgb(r, g, b);
                }
                else
                    tmrCor.Stop();
            }
        }

        private void MillerButton_MouseLeave(object sender, EventArgs e)
        {
            if (autoFadeOut)
                FadeOut();
        }

        Color corPadrao;
        Color corMouseHover;
        Color corBordas = Color.Black;
        Color corMouseClick = Color.White;
        public Color CorPadrao
        {
            get => corPadrao;
            set
            {
                corPadrao = value;

                incRed = corMouseHover.R - corPadrao.R;
                if (incRed > 0)
                    incRed = 1;
                else
                    incRed = -1;
                incGreen = corMouseHover.G - corPadrao.G;
                if (incGreen > 0)
                    incGreen = 1;
                else
                    incGreen = -1;
                incBlue = corMouseHover.B - corPadrao.B;
                if (incBlue > 0)
                    incBlue = 1;
                else
                    incBlue = -1;
            }
        }
        public Color CorMouseHover
        {
            get => corMouseHover; set
            {
                corMouseHover = value;
                incRed = corMouseHover.R - corPadrao.R;
                if (incRed > 0)
                    incRed = 1;
                else
                    incRed = -1;
                incGreen = corMouseHover.G - corPadrao.G;
                if (incGreen > 0)
                    incGreen = 1;
                else
                    incGreen = -1;
                incBlue = corMouseHover.B - corPadrao.B;
                if (incBlue > 0)
                    incBlue = 1;
                else
                    incBlue = -1;
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
        public Color CorMouseClick { get => corMouseClick; set => corMouseClick = value; }

        private void MillerButton_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = corMouseClick;
            tmrCor.Stop();
        }

        private void MillerButton_MouseUp(object sender, MouseEventArgs e)
        {
            BackColor = corMouseHover;
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

        public bool AutoFadeOut { get => autoFadeOut; set => autoFadeOut = value; }
        public int FadeSpeed { get => fadeSpeed; set => fadeSpeed = value; }
    }
}
