using System;
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
        private int numeroCaixa = 1, frequencia = 1, proximoEm = 1;

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
            lsbFlashcards.Items.Add(flashcard.PalavraChave);
        }
        public void RemoverFlashcard(Flashcard flashcard)
        {
            flashcards.Remove(flashcard);
            lsbFlashcards.Items.Remove(flashcard.PalavraChave);
        }
        public Flashcard this[int indice] { get => flashcards[indice]; }
        public void MandarFlashcardPara(Flashcard flashcard, CaixaFlashcards outraCaixa)
        {
            RemoverFlashcard(flashcard);
            outraCaixa.AdicionarFlashcard(flashcard);
        }
        public void PassarDia()
        {
            proximoEm--;
            if (proximoEm == 0)
            {
                proximoEm = frequencia;
                lblProximaSessao.Text = "Próxima sessão: hoje";
            }
            else if (proximoEm == 1)
                lblProximaSessao.Text = "Próxima sessão: amanhã";
            else
                lblProximaSessao.Text = "Próxima sessão: em " + proximoEm + " dias";
               
        }
    }
}
