using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apEstudante
{
    class MateriaMt
    {
        public MateriaMt(string nome)
        {
            Nome = nome;
        }
        public string Nome { get; set; }
        public List<Conteudo> conteudos = new List<Conteudo>();
        public override string ToString()
        {
            string saida = Nome.PadRight(30);
            foreach (Conteudo cnt in conteudos)
                saida += cnt.ToString();
            return saida;
        }
    }
}
