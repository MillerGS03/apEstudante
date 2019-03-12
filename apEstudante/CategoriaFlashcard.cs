using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apEstudante
{
    public class CategoriaFlashcard
    {
        public string Nome { get; set; }
        public List<Flashcard> flashcards = new List<Flashcard>();
        public CategoriaFlashcard(string nome)
        {
            Nome = nome;
        }
        public void AdicionarFlashcard(Flashcard flashcard)
        {
            flashcards.Add(flashcard);
            flashcard.Categoria = this;
        }
        public bool Existe(string palavraChave)
        {
            foreach (Flashcard flsc in flashcards)
                if (palavraChave == flsc.PalavraChave)
                    return true;
            return false;
        }
        public void Exibir(ref ListBox listbox)
        {
            listbox.Items.Clear();
            foreach (Flashcard flsc in flashcards)
                listbox.Items.Add(flsc.PalavraChave);
        }
        public override string ToString()
        {
            string saida = Nome.PadRight(50) + flashcards.Count + "\r\n";
            foreach (Flashcard flsc in flashcards)
                saida += flsc.ToString();
            return saida;
        }
        public static CategoriaFlashcard LerRegistro(StreamReader arquivo, string caminhoImagensFlashcards)
        {
            if (arquivo.EndOfStream)
                throw new Exception("Arquivo terminado");
            string linha = arquivo.ReadLine();
            if (linha == "")
                return null;
            string nomeCategoria = linha.Substring(0, 50).Trim();
            int qtosFlashcards = int.Parse(linha.Substring(50));
            CategoriaFlashcard ctg = new CategoriaFlashcard(nomeCategoria);
            for (int i = 0; i < qtosFlashcards; i++)
                ctg.flashcards.Add(Flashcard.LerRegistro(arquivo, caminhoImagensFlashcards + "\\" + nomeCategoria));
            return ctg;
        }
    }
}
