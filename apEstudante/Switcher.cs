using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apAplicativos
{
    public partial class Switcher : UserControl
    {
        public Switcher()
        {
            InitializeComponent();
        }
        public List<string> Itens { get; } = new List<string>();
        public int IndiceAtual { get; private set; } = -1;
        public int QtosItens { get => Itens.Count; }
        public string ItemAtual { get => Itens[IndiceAtual]; }
        public void Adicionar(string item)
        {
            IndiceAtual = QtosItens;
            IndiceAtualMudou.Invoke(this, new EventArgs());
            Itens.Add(item);

            lbTitulo.Text = item;
            lbTitulo.Show();

            TestarBotoes();
        }
        public void Remover(string item)
        {
            for (int i = 0; i < QtosItens; i++)
                if (Itens[i] == item)
                {
                    Itens.RemoveAt(i);
                    break;
                }
            if (QtosItens == 0)
                lbTitulo.Hide();
            else
            {
                IndiceAtual--;
                lbTitulo.Text = Itens[IndiceAtual];
                IndiceAtualMudou.Invoke(this, new EventArgs());
            }
            TestarBotoes();
        }
        private void TestarBotoes()
        {
            btnEsquerda.Enabled = IndiceAtual > 0;
            btnDireita.Enabled = IndiceAtual < QtosItens - 1;
        }

        public event EventHandler<EventArgs> IndiceAtualMudou;

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            lbTitulo.Focus();
            IndiceAtual--;
            lbTitulo.Text = Itens[IndiceAtual];
            TestarBotoes();
            IndiceAtualMudou.Invoke(this, new EventArgs());

        }
        private void btnDireita_Click(object sender, EventArgs e)
        {
            lbTitulo.Focus();
            IndiceAtual++;
            lbTitulo.Text = Itens[IndiceAtual];
            TestarBotoes();
            IndiceAtualMudou.Invoke(this, new EventArgs());
        }
    }
}
