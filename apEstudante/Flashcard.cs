using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
        public bool UsandoImagem { get => usandoImagem; set => usandoImagem = value; }

        private bool usandoImagem = false; 
        public Image DefinicaoImagem { get; set; }

        public override string ToString()
        {
            string saida = PalavraChave + "\r\n";
            if (usandoImagem)
                saida += "1";
            else
                saida += "0";

            int qtasLinhas = 1;
            for (int i = 0; i < Definicao.Length; i++)
                if (Definicao[i] == '\n')
                    qtasLinhas++;

            saida += "\r\n" + qtasLinhas + "\r\n" + Definicao.PadRight(240) + "\r\n";
            return saida;
        }
        public static Flashcard LerRegistro(StreamReader arquivo)
        {
            if (arquivo.EndOfStream)
                throw new Exception("Arquivo terminado");

            string nomeFlashcard = arquivo.ReadLine().Trim();
            Flashcard flsc = null;

            bool usandoImagem = arquivo.ReadLine() == "1";

            if (!usandoImagem)
            {
                int qtasLinhas = int.Parse(arquivo.ReadLine());
                string definicao = "";
                for (int j = 0; j < qtasLinhas - 1; j++)
                    definicao += arquivo.ReadLine() + "\r\n";
                definicao += arquivo.ReadLine().TrimEnd();
                flsc = new Flashcard(nomeFlashcard, definicao);
            }
            else
            {
                arquivo.ReadLine();
                flsc = new Flashcard(nomeFlashcard, new Bitmap(1, 1));
            }

            return flsc;
        }
    }
}
