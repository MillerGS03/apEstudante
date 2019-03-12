using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apEstudante
{
    public class Flashcard : ICloneable
    {
        public Flashcard(string palavraChave, string definicao, int nivel, int qtosDiasParaRevisar)
        {
            PalavraChave = palavraChave;
            Definicao = definicao;
            usandoImagem = false;
            Nivel = nivel;
            QuantosDiasParaRevisar = qtosDiasParaRevisar;
        }
        public Flashcard(string palavraChave, Image definicaoImagem, int nivel, int qtosDiasParaRevisar)
        {
            PalavraChave = palavraChave;
            Definicao = "";
            DefinicaoImagem = definicaoImagem;
            usandoImagem = true;
            Nivel = nivel;
            QuantosDiasParaRevisar = qtosDiasParaRevisar;
        }
        public CategoriaFlashcard Categoria { get; set; }
        public string PalavraChave { get; set; }
        public string Definicao { get; set; }
        public bool UsandoImagem { get => usandoImagem; set => usandoImagem = value; }
        public int Nivel { get; set; }
        public int QuantosDiasParaRevisar { get; set; }

        private bool usandoImagem = false;
        public Image DefinicaoImagem { get; set; }

        public override string ToString()
        {
            string saida = PalavraChave + "\r\n";
            if (usandoImagem)
                saida += "1" + Nivel + QuantosDiasParaRevisar;
            else
            {
                saida += "0" + Nivel + QuantosDiasParaRevisar;

                int qtasLinhas = 1;
                for (int i = 0; i < Definicao.Length; i++)
                    if (Definicao[i] == '\n')
                        qtasLinhas++;

                saida += "\r\n" + qtasLinhas + "\r\n" + Definicao;
            }

            return saida + "\r\n";
        }
        public static Flashcard LerRegistro(StreamReader arquivo, string caminhoImagens)
        {
            if (arquivo.EndOfStream)
                throw new Exception("Arquivo terminado");

            string nomeFlashcard = arquivo.ReadLine().Trim();
            Flashcard flsc = null;

            string linhaComNumeros = arquivo.ReadLine();
            bool usandoImagem = linhaComNumeros[0] == '1';
            int nivel = int.Parse(linhaComNumeros[1].ToString());
            int qtosDiasParaRevisar = int.Parse(linhaComNumeros.Substring(2));

            if (!usandoImagem)
            {
                int qtasLinhas = int.Parse(arquivo.ReadLine());
                string definicao = "";
                for (int j = 0; j < qtasLinhas - 1; j++)
                    definicao += arquivo.ReadLine() + "\r\n";
                definicao += arquivo.ReadLine().TrimEnd();
                flsc = new Flashcard(nomeFlashcard, definicao, nivel, qtosDiasParaRevisar);
            }
            else
            {
                Bitmap imagemLida = (Bitmap)Image.FromFile(caminhoImagens + "\\" + nomeFlashcard + ".bmp");
                flsc = new Flashcard(nomeFlashcard, new Bitmap(imagemLida), nivel, qtosDiasParaRevisar);
                imagemLida.Dispose();
            }

            return flsc;
        }
        public Flashcard(Flashcard outroFlashcard)
        {
            if (outroFlashcard == null)
                throw new Exception();

            Categoria = outroFlashcard.Categoria;
            PalavraChave = outroFlashcard.PalavraChave;
            Definicao = outroFlashcard.Definicao;
            UsandoImagem = outroFlashcard.UsandoImagem;
            DefinicaoImagem = outroFlashcard.DefinicaoImagem;
            Nivel = outroFlashcard.Nivel;
            QuantosDiasParaRevisar = outroFlashcard.QuantosDiasParaRevisar;
        }
        public object Clone()
        {
            return new Flashcard(this);
        }
    }
}
