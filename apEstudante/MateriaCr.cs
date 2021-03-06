﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apEstudante
{
    class MateriaCr
    {
        string nome;
        string horario;
        DiasDaSemana dia;

        public MateriaCr(string nome, string horario, DiasDaSemana dia)
        {
            this.nome = nome;
            this.horario = horario;
            this.dia = dia;
        }

        public string Nome { get => nome; set => nome = value; }
        public string Horario { get => horario; set => horario = value; }
        public DiasDaSemana Dia { get => dia; set => dia = value; }

        public override string ToString()
        {
            string diaFormatado = dia.ToString();
            if (dia == DiasDaSemana.Terca)
                diaFormatado = "Terça";
            return Nome.Trim().PadRight(50) + Horario.PadLeft(5, '0') + diaFormatado;
        }
    }
}
