using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apEstudante
{
    public partial class frmAplicativo : Form
    {
        public frmAplicativo()
        {
            InitializeComponent();
        }

        private void btnCronogramas_MouseEnter(object sender, EventArgs e)
        {
            btnCronogramas.FadeOut();
            btnFlashcards.FadeOut();
            btnResumos.FadeOut();
            btnPomodoro.FadeOut();
            ucCronogramas1.Visible = ucCronogramas1 == (sender as BotaoMenu).TelaASerMostrada;
            ucFlashcards1.Visible = ucFlashcards1 == (sender as BotaoMenu).TelaASerMostrada;
            ucResumos1.Visible = ucResumos1 == (sender as BotaoMenu).TelaASerMostrada;
            ucPomodoro1.Visible = ucPomodoro1 == (sender as BotaoMenu).TelaASerMostrada;
            (sender as BotaoMenu).CancelarFadeOut();
        }

        private void frmAplicativo_FormClosing(object sender, FormClosingEventArgs e)
        {
            ucCronogramas1.GravarDados();
            ucFlashcards1.GravarDados();
        }

        private void frmAplicativo_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }
    }
}
