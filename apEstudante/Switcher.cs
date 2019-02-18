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
        List<string> itens = new List<string>();
        int indiceAtual = -1;

        public Switcher()
        {
            InitializeComponent();
        }
        public List<string> Itens { get => itens; }
        public int IndiceAtual { get => indiceAtual; }
        public int QtosItens { get => itens.Count; }
        public string ItemAtual { get => itens[indiceAtual]; }
        public void Adicionar(string item)
        {
            indiceAtual = QtosItens;
            IndiceAtualMudou.Invoke(this, new EventArgs());
            itens.Add(item);

            lbTitulo.Text = item;
            lbTitulo.Left = Width / 2 - lbTitulo.Width / 2;
            lbTitulo.Show();

            TestarBotoes();
        }
        public void Remover(string item)
        {
            for (int i = 0; i < QtosItens; i++)
                if (itens[i] == item)
                {
                    itens.RemoveAt(i);
                    break;
                }
            if (QtosItens == 0)
                lbTitulo.Hide();
            else
            {
                indiceAtual--;
                lbTitulo.Text = itens[indiceAtual];
                lbTitulo.Left = Width / 2 - lbTitulo.Width / 2;
                IndiceAtualMudou.Invoke(this, new EventArgs());
            }
            TestarBotoes();
        }
        private void TestarBotoes()
        {
            btnEsquerda.Enabled = indiceAtual > 0;
            btnDireita.Enabled = indiceAtual < QtosItens - 1;
        }

        public event EventHandler<EventArgs> IndiceAtualMudou;

        private void btnEsquerda_Click(object sender, EventArgs e)
        {
            lbTitulo.Focus();
            indiceAtual--;
            lbTitulo.Text = itens[indiceAtual];
            lbTitulo.Left = Width / 2 - lbTitulo.Width / 2;
            TestarBotoes();
            IndiceAtualMudou.Invoke(this, new EventArgs());

        }
        private void btnDireita_Click(object sender, EventArgs e)
        {
            lbTitulo.Focus();
            indiceAtual++;
            lbTitulo.Text = itens[indiceAtual];
            lbTitulo.Left = Width / 2 - lbTitulo.Width / 2;
            TestarBotoes();
            IndiceAtualMudou.Invoke(this, new EventArgs());
        }
    }
}
