using System;
using System.Collections.Generic;
using System.IO;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apEstudante
{
    public partial class UcFlashcards : UserControl
    {
        List<CategoriaFlashcard> categorias = new List<CategoriaFlashcard>();
        string caminhoFlashcards = Application.LocalUserAppDataPath + "\\flashcards.txt";
        //List<Flashcard> flashcards = new List<Flashcard>();
        public UcFlashcards()
        {
            InitializeComponent();
        }

        private void UcFlashcards_Load(object sender, EventArgs e)
        {
            txtDefinicao.Location = new Point(148, 98);

            if (File.Exists(caminhoFlashcards))
            {
                StreamReader arquivo = new StreamReader(caminhoFlashcards);

                while (!arquivo.EndOfStream)          
                    AdicionarCategoria(CategoriaFlashcard.LerRegistro(arquivo));
                arquivo.Close();
            }
        }

        private void rbImagem_CheckedChanged(object sender, EventArgs e)
        {
            txtDefinicao.Hide();
            pnImagem.Show();
            btnEscolherImagem.Show();
            txtPalavraChave_TextChanged(this, new EventArgs());
        }
        private void rbTexto_CheckedChanged(object sender, EventArgs e)
        {
            txtDefinicao.Show();
            pnImagem.Hide();
            btnEscolherImagem.Hide();
            txtPalavraChave_TextChanged(this, new EventArgs());
        }

        private void btnEscolherImagem_Click(object sender, EventArgs e)
        {
            if (ofdImgFlashcard.ShowDialog() == DialogResult.OK)
            {
                pnImagem.BackgroundImage = Image.FromFile(ofdImgFlashcard.FileName);
                txtPalavraChave_TextChanged(this, new EventArgs());
            }
        }

        private void txtMateria_TextChanged(object sender, EventArgs e)
        {
            if (txtMateria.Text.Trim() != "" && txtMateria.Text != null)
            {
                bool existe = false;
                foreach (CategoriaFlashcard cat in categorias)
                    if (txtMateria.Text.Trim() == cat.Nome)
                    {
                        existe = true;
                        break;
                    }
                btnAdicionarCategoria.Enabled = !existe;
            }
            else
                btnAdicionarCategoria.Enabled = false;
        }

        private void btnAdicionarCategoria_Click(object sender, EventArgs e)
        {
            AdicionarCategoria(new CategoriaFlashcard(txtMateria.Text.Trim()));
        }
        private void AdicionarCategoria(CategoriaFlashcard categoria)
        {
            if (categoria != null)
            {
                categorias.Add(categoria);
                lsbCategorias.Items.Add(categoria.Nome);
                cbxCategoria.Items.Add(categoria.Nome);
                cbxExibirCategoria.Items.Add(categoria.Nome);
                txtMateria_TextChanged(this, new EventArgs());
                gbNovoFlashcard.Enabled = true;
            }
        }

        private void lsbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoverCategoria.Enabled = lsbCategorias.SelectedIndex != -1;
        }

        private void txtPalavraChave_TextChanged(object sender, EventArgs e)
        {
            if (txtPalavraChave.Text.Trim() != "" && txtPalavraChave.Text.Trim() != null && cbxCategoria.SelectedIndex != -1 &&
                ((rbTexto.Checked && txtDefinicao.Text.Trim() != "" && txtDefinicao.Text.Trim() != null) || (rbImagem.Checked && pnImagem.BackgroundImage != null)))
            {
                if (btnAdicionarEditarFlashcard.Text == "Atualizar")
                {
                    btnAdicionarEditarFlashcard.Enabled = true;
                    return;
                }
                bool existe = false;
                foreach (CategoriaFlashcard cat in categorias)
                    foreach (Flashcard flsc in cat.flashcards)
                        if (txtPalavraChave.Text.Trim() == flsc.PalavraChave)
                        {
                            existe = true;
                            break;
                        }
                btnAdicionarEditarFlashcard.Enabled = !existe;
            }
            else
                btnAdicionarEditarFlashcard.Enabled = false;
        }

        private void txtDefinicao_TextChanged(object sender, EventArgs e)
        {
            txtPalavraChave_TextChanged(this, new EventArgs());
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtPalavraChave_TextChanged(this, new EventArgs());
        }

        private void btnRemoverCategoria_Click(object sender, EventArgs e)
        {
            categorias.RemoveAt(lsbCategorias.SelectedIndex);
            cbxCategoria.Items.RemoveAt(lsbCategorias.SelectedIndex);
            cbxExibirCategoria.Items.RemoveAt(lsbCategorias.SelectedIndex);
            lsbCategorias.Items.RemoveAt(lsbCategorias.SelectedIndex);

            txtPalavraChave_TextChanged(this, new EventArgs());
            MostrarItens();
            gbNovoFlashcard.Enabled = categorias.Count > 0;
            txtMateria_TextChanged(this, new EventArgs());
        }

        private void btnAdicionarEditarFlashcard_Click(object sender, EventArgs e)
        {
            if (btnAdicionarEditarFlashcard.Text == "Atualizar")
            {
                flscEmEdicao.PalavraChave = txtPalavraChave.Text.Trim();
                flscEmEdicao.UsandoImagem = rbImagem.Checked;
                if (rbImagem.Checked)
                {
                    flscEmEdicao.Definicao = "";
                    flscEmEdicao.DefinicaoImagem = pnImagem.BackgroundImage;
                }
                else
                {
                    flscEmEdicao.Definicao = txtDefinicao.Text;
                    flscEmEdicao.DefinicaoImagem = null;
                }
                btnCancelarEdicao.PerformClick();
            }
            else
            {
                if (rbTexto.Checked)
                    categorias[cbxCategoria.SelectedIndex].flashcards.Add(
                        new Flashcard(txtPalavraChave.Text.Trim(), txtDefinicao.Text.Trim()));
                else
                    categorias[cbxCategoria.SelectedIndex].flashcards.Add(
                        new Flashcard(txtPalavraChave.Text.Trim(), pnImagem.BackgroundImage));
            }
            txtPalavraChave_TextChanged(this, new EventArgs());
            MostrarItens();
        }

        private void cbxExibirCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarItens();
        }
        private void MostrarItens()
        {
            lsbFlashcards.Items.Clear();
            if (cbxExibirCategoria.SelectedIndex != -1)
                foreach (Flashcard flsc in categorias[cbxExibirCategoria.SelectedIndex].flashcards)
                    lsbFlashcards.Items.Add(flsc.PalavraChave);
        }

        private void tpGerenciar_Click(object sender, EventArgs e)
        {
            lsbFlashcards.ClearSelected();
            lsbCategorias.ClearSelected();
        }

        public void GravarDados()
        {
            StreamWriter arquivo = new StreamWriter(caminhoFlashcards);
            foreach (CategoriaFlashcard ctfc in categorias)
                arquivo.WriteLine(ctfc.ToString());
            arquivo.Close();
        }

        private void lsbFlashcards_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemoverFlashcard.Enabled = lsbFlashcards.SelectedIndex != -1;
            btnEditarFlashcard.Enabled = lsbFlashcards.SelectedIndex != -1;
        }

        private void btnRemoverFlashcard_Click(object sender, EventArgs e)
        {
            categorias[cbxExibirCategoria.SelectedIndex].flashcards.RemoveAt(lsbFlashcards.SelectedIndex);
            lsbFlashcards.Items.RemoveAt(lsbFlashcards.SelectedIndex);
            txtPalavraChave_TextChanged(this, new EventArgs());
        }

        private void UcFlashcards_Resize(object sender, EventArgs e)
        {
            label1.Left = (Width - label1.Width) / 2;
        }

        private void pnlListaItens_Resize(object sender, EventArgs e)
        {
            cbxExibirCategoria.Width = lsbFlashcards.Width;
            lblCategoria.Width = lsbFlashcards.Width;

            if (cbxExibirCategoria.Width >= 340)
            {
                cbxExibirCategoria.Width = 340;
                cbxExibirCategoria.Left = (pnlListaItens.Width - cbxExibirCategoria.Width) / 2;
                lblCategoria.Width = 340;
                lblCategoria.Left = (pnlListaItens.Width - lblCategoria.Width) / 2;
            }
            else
            {
                lblCategoria.Left = 9;
                cbxExibirCategoria.Left = 9;
            }

            btnEditarFlashcard.Width = 110 + (pnlListaItens.Width - 238) / 2;
            btnRemoverFlashcard.Width = btnEditarFlashcard.Width;
            btnRemoverFlashcard.Left = lsbFlashcards.Right - btnRemoverFlashcard.Width;
        }

        private void tpGerenciar_Resize(object sender, EventArgs e)
        {
            pnlNovoFlashcard.Height = tpGerenciar.Height / 2 - 1;
            pnlDivisaoHorizontal.Top = tpGerenciar.Height / 2;
            pnlCategorias.Top = tpGerenciar.Height / 2 + 1;
            pnlCategorias.Height = tpGerenciar.Height / 2 - 2;

            pnlListaItens.Width = 238 + 2 * (tpGerenciar.Width - 708) / 3;
            pnlNovoFlashcard.Width = 466 + (tpGerenciar.Width - 708) / 3;
            pnlCategorias.Width = pnlNovoFlashcard.Width;
            pnlDivisaoHorizontal.Width = pnlNovoFlashcard.Width;

            pnlDivisaoVertical.Left = pnlListaItens.Left + pnlListaItens.Width;
            pnlNovoFlashcard.Left = pnlDivisaoVertical.Left;
            pnlCategorias.Left = pnlDivisaoVertical.Left;
            pnlDivisaoHorizontal.Left = pnlDivisaoVertical.Left;
        }

        private void btnEditarFlashcard_Click(object sender, EventArgs e)
        {
            lblNovoEditarFlashcard.Text = "Editar Flashcard";
            btnAdicionarEditarFlashcard.Text = "Atualizar";

            btnAdicionarEditarFlashcard.Left = gbNovoFlashcard.Width / 2 - btnAdicionarEditarFlashcard.Width - 5;
            btnCancelarEdicao.Left = gbNovoFlashcard.Width / 2 + 5;
            btnCancelarEdicao.Show();

            flscEmEdicao = categorias[cbxExibirCategoria.SelectedIndex].flashcards[lsbFlashcards.SelectedIndex];
            txtPalavraChave.Text = flscEmEdicao.PalavraChave;
            cbxCategoria.SelectedIndex = cbxExibirCategoria.SelectedIndex;
            rbTexto.Checked = !flscEmEdicao.UsandoImagem;
            if (flscEmEdicao.UsandoImagem)
                pnImagem.BackgroundImage = flscEmEdicao.DefinicaoImagem;
            else
                txtDefinicao.Text = flscEmEdicao.Definicao;
        }
        Flashcard flscEmEdicao = null;

        private void pnlNovoFlashcard_Resize(object sender, EventArgs e)
        {
            if (btnCancelarEdicao.Visible)
            {
                btnAdicionarEditarFlashcard.Left = gbNovoFlashcard.Width / 2 - btnAdicionarEditarFlashcard.Width - 5;
                btnCancelarEdicao.Left = gbNovoFlashcard.Width / 2 + 5;
            }
            else
                btnAdicionarEditarFlashcard.Left = (gbNovoFlashcard.Width - btnAdicionarEditarFlashcard.Width) / 2;
        }

        private void pnlCategorias_Resize(object sender, EventArgs e)
        {
            gbAdicionarCategoria.Top = (pnlCategorias.Height - gbAdicionarCategoria.Height) / 2;
            lsbCategorias.Width = 186 + (pnlCategorias.Width - 466) / 2;
            lsbCategorias.Height = btnRemoverCategoria.Top - 10 - lsbCategorias.Top;

            btnRemoverCategoria.Width = lsbCategorias.Width;
            gbAdicionarCategoria.Width = 265 + (pnlCategorias.Width - 466) / 2;
            gbAdicionarCategoria.Left = lsbCategorias.Right + 3;
        }

        private void btnCancelarEdicao_Click(object sender, EventArgs e)
        {
            btnAdicionarEditarFlashcard.Text = "Adicionar";
            btnAdicionarEditarFlashcard.Left = (gbNovoFlashcard.Width - btnAdicionarEditarFlashcard.Width) / 2;
            btnCancelarEdicao.Hide();
            txtPalavraChave.Text = "";
            txtDefinicao.Text = "";
            rbTexto.Select();
            pnImagem.BackgroundImage = null;
            flscEmEdicao = null;
        }

        private void gbAdicionarCategoria_Resize(object sender, EventArgs e)
        {
            btnAdicionarCategoria.Left = txtMateria.Left + (txtMateria.Width - btnAdicionarCategoria.Width) / 2;
        }
    }
}
