using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apEstudante
{
    class CategoriaFlashcard
    {
        public string Nome { get; set; }
        public List<Flashcard> flashcards = new List<Flashcard>();
        public CategoriaFlashcard(string nome)
        {
            Nome = nome;
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
