using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apEstudante
{
    class Flashcard
    {
        public Flashcard(string palavraChave, string definicao)
        {
            PalavraChave = palavraChave;
            Definicao = definicao;
            usandoImagem = false;
        }
        public Flashcard(string palavraChave, Image definicaoImagem)
        {
            PalavraChave = palavraChave;
            Definicao = "";
            DefinicaoImagem = definicaoImagem;
            usandoImagem = true;
        }
        public string PalavraChave { get; set; }
        public string Definicao { get; set; }
        public bool UsandoImagem { get => usandoImagem; }

        private bool usandoImagem = false; 
        public Image DefinicaoImagem { get; set; }

        public override string ToString()
        {
            string saida = PalavraChave.PadRight(50);
            if (usandoImagem)
                saida += "1";
            else
                saida += "0";
            saida += Definicao.PadRight(120);
            return saida;
        }
    }
}
