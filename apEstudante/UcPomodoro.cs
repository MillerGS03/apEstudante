using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace apEstudante
{
    public partial class UcPomodoro : UserControl
    {
        private enum Status { Parado, Rodando, IntervaloCurto, IntervaloLongo, EsperandoIntervalo, EsperandoRodar };
        private Status status = Status.Parado;
        private int qtosCiclosFeitos = 0;
        private SoundPlayer tocaAlarme = new SoundPlayer(Properties.Resources.old_fashioned_door_bell_daniel_simon);

        public int QtosCiclosFeitos
        {
            get => qtosCiclosFeitos;
            set
            {
                qtosCiclosFeitos = value;
                lblCiclosRealizados.Text = "Ciclos realizados: " + value;
                lblRestantes.Text = 4 - value % 4 + " restante" + (value % 4 != 3 ? "s" : "") + " até o próximo intervalo longo.";
            }
        }

        public UcPomodoro()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Hide();
            btnParar.Show();
            btnPausar.Show();
            pnlBarra.Enabled = true;
            barra.Value = 0;

            if (status == Status.Parado || status == Status.EsperandoRodar)
            {
                lbl1.Left = barra.Left + barra.Width / 5 - lbl1.Width / 2;
                lbl2.Left = barra.Left + 2 * barra.Width / 5 - lbl2.Width / 2;
                Label lblEncontrada = null;
                for (int i = 0; i <= 5; i++)
                {
                    lblEncontrada = ((Label)(pnlBarra.Controls.Find("lbl" + i, false)[0]));
                    lblEncontrada.Text = i * 5 + "";
                    lblEncontrada.Show();
                }

                barra.Maximum = 1500;
                status = Status.Rodando;
                lblStatus.Text = "Status: Rodando";
                lblSubStatus.Text = "Concentre-se em suas tarefas!";
            }
            else if (status == Status.EsperandoIntervalo)
            {
                QtosCiclosFeitos++;
                status = QtosCiclosFeitos % 4 != 0 ? Status.IntervaloCurto : Status.IntervaloLongo;

                if (status == Status.IntervaloCurto)
                {
                    lblStatus.Text = "Status: Intervalo curto";
                    lblSubStatus.Text = "Descanse! Pode esticar suas pernas e beber uma água.";
                    barra.Maximum = 300;

                    lbl1.Left = barra.Left + barra.Width / 5 - lbl1.Width / 2;
                    lbl2.Left = barra.Left + 2 * barra.Width / 5 - lbl2.Width / 2;
                    Label lblEncontrada = null;
                    for (int i = 0; i <= 5; i++)
                    {
                        lblEncontrada = ((Label)(pnlBarra.Controls.Find("lbl" + i, false)[0]));
                        lblEncontrada.Text = i + "";
                        lblEncontrada.Show();
                    }
                }
                else
                {
                    lblStatus.Text = "Status: Intervalo longo";
                    lblSubStatus.Text = "Descanse! Use esse tempo maior para refrescar sua cabeça.";
                    barra.Maximum = 900;

                    lbl1.Left = barra.Left + barra.Width / 3 - lbl1.Width /2 ;
                    lbl2.Left = barra.Left + 2 * barra.Width / 3 - lbl2.Width / 2;
                    lbl1.Text = "5";
                    lbl2.Text = "10";
                    lbl3.Hide();
                    lbl4.Hide();
                    lbl5.Text = "15";
                }
            }

            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            barra.PerformStep();
            if (barra.Value == barra.Maximum)
            {
                btnIniciar.Show();
                btnParar.Hide();
                btnPausar.Hide();
                pnlBarra.Enabled = false;

                if (status == Status.Rodando)
                {
                    status = Status.EsperandoIntervalo;
                    lblStatus.Text = "Status: Ciclo terminado";
                    lblSubStatus.Text = "Aperte \"Iniciar\" para entrar no intervalo!";
                }
                else
                {
                    status = Status.EsperandoRodar;
                    lblStatus.Text = "Status: Intervalo terminado";
                    lblSubStatus.Text = "Aperte \"Iniciar\" para voltar ao ciclo!";
                }

                tocaAlarme.Play();
                timer.Stop();
            }
        }

        private void btnParar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente parar?", "Confirme parada", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                btnIniciar.Show();
                btnParar.Hide();
                btnPausar.Hide();
                pnlBarra.Enabled = false;
                barra.Value = 0;
                status = Status.Parado;
                timer.Stop();
                QtosCiclosFeitos = 0;
                btnPausar.Text = "Pausar";
                lblStatus.Text = "Status: Parado";
                lblSubStatus.Text = "Aperte iniciar!";
            }
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (btnPausar.Text == "Pausar")
            {
                btnPausar.Text = "Despausar";
                timer.Stop();
                lblStatus.Text = "Status: Pausado";
                lblSubStatus.Text = "Aperte \"Despausar\" para continuar!";
            }
            else
            {
                btnPausar.Text = "Pausar";
                timer.Start();

                if (status == Status.IntervaloCurto)
                {
                    lblStatus.Text = "Status: Intervalo curto";
                    lblSubStatus.Text = "Descanse! Pode esticar suas pernas e beber uma água, por exemplo.";
                }
                else if (status == Status.IntervaloLongo)
                {
                    lblStatus.Text = "Status: Intervalo longo";
                    lblSubStatus.Text = "Descanse! Use esse tempo maior para refrescar sua cabeça.";
                }
                else
                {
                    lblStatus.Text = "Status: Rodando";
                    lblSubStatus.Text = "Concentre-se em suas tarefas!";
                }
            }
        }

        private void UcPomodoro_Resize(object sender, EventArgs e)
        {
            btnIniciar.Left = (Width - btnIniciar.Width) / 2;
            btnPausar.Left = (Width - btnIniciar.Width) / 2 - 67;
            btnParar.Left = (Width - btnIniciar.Width) / 2 + 84;

            if (!lbl3.Visible)
            {
                lbl1.Left = barra.Left + barra.Width / 3 - lbl1.Width / 2;
                lbl2.Left = barra.Left + 2 * barra.Width / 3 - lbl2.Width / 2;
            }
            else
            {
                lbl1.Left = barra.Left + barra.Width / 5 - lbl1.Width / 2;
                lbl2.Left = barra.Left + 2 * barra.Width / 5 - lbl2.Width / 2;
                lbl3.Left = barra.Left + 3 * barra.Width / 5 - lbl3.Width / 2;
                lbl4.Left = barra.Left + 4 * barra.Width / 5 - lbl4.Width / 2;
            }
        }
    }
}
