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
            StreamReader arquivo = new StreamReader(caminhoFlashcards);
            while (!arquivo.EndOfStream)
            {
                string linha = arquivo.ReadLine();
                string categoria = linha.Substring(0, 30).Trim();
                categorias.Add(new CategoriaFlashcard(categoria));
                lsbCategorias.Items.Add(categoria);
                cbxCategoria.Items.Add(categoria);
                cbxExibirCategoria.Items.Add(categoria);
                txtMateria_TextChanged(this, new EventArgs());
                gbNovoFlashcard.Enabled = true;

                for (int i = 0; i < (linha.Length - 30) / 121; i++)
                {
                    int indiceComeco = 30 + i * (linha.Length - 30);
                    string palavraChave = linha.Substring(indiceComeco, 30).Trim();
                    bool usaImagem = linha[indiceComeco + 30] == '1';
                    if (!usaImagem)
                    {
                        string definicao = linha.Substring(indiceComeco + 31).Trim();
                        categorias[categorias.Count - 1].flashcards.Add(new Flashcard(palavraChave, definicao));
                    }
                    else
                        categorias[categorias.Count - 1].flashcards.Add(new Flashcard(palavraChave, new Bitmap(1, 1)));
                }
            }
            arquivo.Close();
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
            categorias.Add(new CategoriaFlashcard(txtMateria.Text.Trim()));
            lsbCategorias.Items.Add(txtMateria.Text.Trim());
            cbxCategoria.Items.Add(txtMateria.Text.Trim());
            cbxExibirCategoria.Items.Add(txtMateria.Text.Trim());
            txtMateria_TextChanged(this, new EventArgs());
            gbNovoFlashcard.Enabled = true;
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
                bool existe = false;
                foreach (CategoriaFlashcard cat in categorias)
                    foreach (Flashcard flsc in cat.flashcards)
                        if (txtPalavraChave.Text.Trim() == flsc.PalavraChave)
                        {
                            existe = true;
                            break;
                        }
                btnAdicionarFlashcard.Enabled = !existe;
            }
            else
                btnAdicionarFlashcard.Enabled = false;
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

        private void btnAdicionarFlashcard_Click(object sender, EventArgs e)
        {
            if (rbTexto.Checked)
                categorias[cbxCategoria.SelectedIndex].flashcards.Add(
                    new Flashcard(txtPalavraChave.Text.Trim(), txtDefinicao.Text.Trim()));
            else
                categorias[cbxCategoria.SelectedIndex].flashcards.Add(
                    new Flashcard(txtPalavraChave.Text.Trim(), pnImagem.BackgroundImage));
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
        }

        private void btnRemoverFlashcard_Click(object sender, EventArgs e)
        {
            categorias[cbxExibirCategoria.SelectedIndex].flashcards.RemoveAt(lsbFlashcards.SelectedIndex);
            lsbFlashcards.Items.RemoveAt(lsbFlashcards.SelectedIndex);
            txtPalavraChave_TextChanged(this, new EventArgs());
        }
    }
}
