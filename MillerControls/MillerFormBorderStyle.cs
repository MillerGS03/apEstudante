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
    public partial class MillerFormBorderStyle : UserControl
    {
        public MillerFormBorderStyle()
        {
            InitializeComponent();
        }

        Form formulario;
        private void pnMinimizar_MouseClick(object sender, MouseEventArgs e)
        {
            formulario.SizeChanged += new EventHandler(Formulario_SizeChanged);
            estadoAnimacao = Animacao.Minimizar;
            tmrWindowState.Start();
        }
        private void pnFechar_MouseClick(object sender, MouseEventArgs e)
        {
            estadoAnimacao = Animacao.Fechar;
            tmrWindowState.Start();
        }
        private enum Animacao { Fechar, Minimizar, Restaurar, Normal }
        Animacao estadoAnimacao = Animacao.Normal;

        private void tmrWindowState_Tick(object sender, EventArgs e)
        {
            switch (estadoAnimacao)
            {
                case Animacao.Restaurar:
                    formulario.Opacity += 0.1;
                    if (formulario.Opacity == 1)
                    {
                        tmrWindowState.Stop();
                        estadoAnimacao = Animacao.Normal;
                    }
                    break;
                case Animacao.Normal: break;
                default:
                    formulario.Opacity -= 0.1;
                    if (formulario.Opacity == 0)
                    {
                        if (estadoAnimacao == Animacao.Minimizar)
                        {
                            tmrWindowState.Stop();
                            estadoAnimacao = Animacao.Normal;
                            formulario.WindowState = FormWindowState.Minimized;
                        }
                        else
                        {
                            tmrWindowState.Stop();
                            formulario.Close();
                        }
                    }
                    break;

            }
        }

        Point ultimaPosicao;
        bool arrastando;

        private void pnTopo_MouseDown(object sender, MouseEventArgs e)
        {
            arrastando = true;
            ultimaPosicao = e.Location;
        }
        private void pnTopo_MouseUp(object sender, MouseEventArgs e)
        {
            arrastando = false;
        }
        private void pnTopo_MouseMove(object sender, MouseEventArgs e)
        {
            if (arrastando)
            {
                formulario.Left += e.X - ultimaPosicao.X;
                formulario.Top += e.Y - ultimaPosicao.Y;
            }
        }

        public void AtivarBordas()
        {
            panelB1.BackColor = corBorda;
            panelB1.Location = new Point(formulario.Width - tamanhoBordas, 40);
            panelB1.Size = new Size(tamanhoBordas, formulario.Height - 40);

            panelB2.BackColor = corBorda;
            panelB2.Location = new Point(0, 40);
            panelB2.Size = new Size(tamanhoBordas, formulario.Height - 40);

            panelB3.BackColor = corBorda;
            panelB3.Location = new Point(0, formulario.Height - tamanhoBordas);
            panelB3.Size = new Size(formulario.Width, tamanhoBordas);

            formulario.Controls.Add(panelB1);
            formulario.Controls.Add(panelB2);
            formulario.Controls.Add(panelB3);

            panelB1.BringToFront();
            panelB2.BringToFront();
            panelB3.BringToFront();
        }
        private void Formulario_SizeChanged(object sender, EventArgs e)
        {
            try
            {
                formulario = FindForm();
                if (formulario.WindowState == FormWindowState.Normal)
                {
                    estadoAnimacao = Animacao.Restaurar;
                    tmrWindowState.Start();
                }
            }
            catch { }
        }
        private void Formulario_Load(object sender, EventArgs e)
        {
            AtivarBordas();
        }

        Panel panelB1 = new Panel();
        Panel panelB2 = new Panel();
        Panel panelB3 = new Panel();

        int tamanhoBordas = 2;

        public string Titulo
        {
            get => lbTitulo.Text;
            set => lbTitulo.Text = value;
        }
        public int TamanhoBordas
        {
            get => tamanhoBordas;
            set
            {
                if (value <= 10 && value >= 0)
                {
                    tamanhoBordas = value;
                    panel1.Height = value;
                    panel2.Width = value;
                    panel3.Width = value;
                    panel4.Height = value;
                }
            }
        }
        public bool IconeVisivel
        {
            get => pnIcone.Visible;
            set
            {
                pnIcone.Visible = value;
                if (!value)
                    lbTitulo.Left = 5;
                else
                    lbTitulo.Left = 40;
            }
        }
        public bool TituloVisivel
        {
            get => lbTitulo.Visible;
            set => lbTitulo.Visible = value;
        }
        public Image Icone
        {
            get => pnIcone.BackgroundImage;
            set => pnIcone.BackgroundImage = value;
        }
        public Image FecharImg
        {
            get => pnFechar.BackgroundImage;
            set => pnFechar.BackgroundImage = value;
        }
        public Image MinimizarImg
        {
            get => pnMinimizar.BackgroundImage;
            set => pnMinimizar.BackgroundImage = value;
        }
        Color corBorda = Color.Black;
        public Color CorBorda
        {
            get => corBorda;
            set
            {
                corBorda = value;
                panelB1.BackColor = corBorda;
                panelB2.BackColor = corBorda;
                panelB3.BackColor = corBorda;
                panel1.BackColor = corBorda;
                panel2.BackColor = corBorda;
                panel3.BackColor = corBorda;
                panel4.BackColor = corBorda;
            }
        }
        private void MillerFormBorderStyle_Load(object sender, EventArgs e)
        {
            formulario = FindForm();
            (formulario.Controls.Find(Name, true)[0] as MillerFormBorderStyle).Dock = DockStyle.Top;
            formulario.Load += new EventHandler(Formulario_Load);
            Height = 40;
            Font = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);

            pnTopo.BackColor = BackColor;
            lbTitulo.ForeColor = ForeColor;
        }

        private void MillerFormBorderStyle_BackColorChanged(object sender, EventArgs e)
        {
            pnTopo.BackColor = BackColor;
        }

        private void MillerFormBorderStyle_ForeColorChanged(object sender, EventArgs e)
        {
            lbTitulo.ForeColor = ForeColor;
        }
    }
}
