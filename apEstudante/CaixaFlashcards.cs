﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apEstudante
{
    public partial class CaixaFlashcards : UserControl
    {
        private List<Flashcard> flashcards = new List<Flashcard>();
        private int numeroCaixa = 1, frequencia = 1;

        public CaixaFlashcards()
        {
            InitializeComponent();
        }

        public int QuantosFlashcards { get => flashcards.Count; }
        public int NumeroCaixa
        {
            get => numeroCaixa;
            set
            {
                if (value > 0)
                {
                    numeroCaixa = value;
                    lblCaixa.Text = "Caixa " + value;
                }
            }
        }
        public int Frequencia
        {
            get => frequencia;
            set
            {
                if (value > 0)
                {
                    frequencia = value;
                    lblFrequencia.Text = "Frequência: ";

                    if (frequencia == 1)
                        lblFrequencia.Text += "todo dia";
                    else
                        lblFrequencia.Text += "a cada " + frequencia + " dias";
                }
            }
        }
        public void AdicionarFlashcard(Flashcard flashcard)
        {
            flashcards.Add(flashcard);
            dgvFlashcards.RowCount++;
            dgvFlashcards.Rows[flashcards.Count - 1].Cells[0].Value = flashcard.PalavraChave;
            dgvFlashcards.Rows[flashcards.Count - 1].Cells[1].Value = flashcard.Categoria;

            AtualizarCorFlashcard(flashcard);
        }
        public void RemoverFlashcard(Flashcard flashcard)
        {
            dgvFlashcards.Rows.RemoveAt(flashcards.FindIndex(new Predicate<Flashcard>(flsc => flsc == flashcard)));
            flashcards.Remove(flashcard);    
        }
        public Flashcard this[int indice] { get => flashcards[indice]; }
        public void MandarFlashcardPara(Flashcard flashcard, CaixaFlashcards outraCaixa)
        {
            RemoverFlashcard(flashcard);
            outraCaixa.AdicionarFlashcard(flashcard);
        }

        public void PassarDia()
        {
            foreach (Flashcard flsc in flashcards)
            {
                flsc.QuantosDiasParaRevisar--;
                AtualizarCorFlashcard(flsc);
            }
        }
        private void AtualizarCorFlashcard(Flashcard flsc)
        {
            int indiceFlashcard = flashcards.FindIndex(new Predicate<Flashcard>(flashcard => flashcard == flsc));

            if (indiceFlashcard != -1)
            {
                Color corDeFundo = flsc.QuantosDiasParaRevisar == 0 ? Color.Orange : dgvFlashcards.DefaultCellStyle.BackColor;
                Color corDeFundoSelecao = flsc.QuantosDiasParaRevisar == 0 ? Color.DarkOrange : Color.Silver;

                foreach (DataGridViewCell celula in dgvFlashcards.Rows[indiceFlashcard].Cells)
                {
                    celula.Style.BackColor = corDeFundo;
                    celula.Style.SelectionBackColor = corDeFundoSelecao;
                }
            }
        }
    }
}
