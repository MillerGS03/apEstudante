using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apEstudante
{
    class Conteudo
    {
        public Conteudo(string nome, bool negrito)
        {
            Nome = nome;
            Negrito = negrito;
            Feito = false;
        }
        public Conteudo(string nome, bool negrito, bool feito)
        {
            Nome = nome;
            Negrito = negrito;
            Feito = feito;
        }
        public string Nome { get; set; }
        public bool Feito { get; set; }
        public bool Negrito { get; set; }
        public override string ToString()
        {
            string feito = "",
                   negrito = "";
            if (Feito)
                feito = "1";
            else
                feito = "0";
            if (Negrito)
                negrito = "1";
            else
                negrito = "0";
            return Nome.PadRight(34) + feito + negrito;
        }
    }
}
