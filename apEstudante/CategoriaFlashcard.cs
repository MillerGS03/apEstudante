using System;
using System.Collections.Generic;
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
            string saida = Nome.PadRight(30);
            foreach (Flashcard flsc in flashcards)
                saida += flsc.ToString();
            return saida;
        }
    }
}
