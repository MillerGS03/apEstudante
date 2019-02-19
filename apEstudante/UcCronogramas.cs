using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apEstudante
{
    public enum DiasDaSemana { Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado }

    public partial class UcCronogramas : UserControl
    {
        List<MateriaCr> materiasCronograma = new List<MateriaCr>();
        List<MateriaMt> materias = new List<MateriaMt>();

        string caminhoCronograma = Application.LocalUserAppDataPath + "\\cronograma.txt";
        string caminhoMaterias = Application.LocalUserAppDataPath + "\\materias.txt";
        public UcCronogramas()
        {
            InitializeComponent();
        }

        private void UcCronogramas_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < dgCronogramas.ColumnCount; i++)
            {
                dgCronogramas.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgCronogramas.Columns[i].HeaderCell.Style.Font = new Font("Century Gothic", (float)12.5, FontStyle.Bold);
            }
            if (!File.Exists(caminhoCronograma))
                File.Create(caminhoCronograma).Close();
            StreamReader arquivoCronogramas = new StreamReader(caminhoCronograma, Encoding.Default);
            while (!arquivoCronogramas.EndOfStream)
            {
                string linha = arquivoCronogramas.ReadLine();

                string nomeMateria = linha.Substring(0, 50).Trim();
                string horario = linha.Substring(50, 5);
                string dia = linha.Substring(55);

                Adicionar(horario, nomeMateria, dia);
            }
            arquivoCronogramas.Close();
            dgCronogramas.ClearSelection();
            if (!File.Exists(caminhoMaterias))
                File.Create(caminhoMaterias).Close();
            StreamReader arquivoMaterias = new StreamReader(caminhoMaterias, Encoding.Default);
            while (!arquivoMaterias.EndOfStream)
            {
                string linha = arquivoMaterias.ReadLine();
                string nomeMateria = linha.Substring(0, 30).Trim();
                materias.Add(new MateriaMt(nomeMateria));
                switcher1.Adicionar(nomeMateria);
                for (int i = 0; i < (linha.Length - 30) / 36; i++)
                {
                    int indiceComecoConteudo = 30 + i * 36;
                    string nomeConteudo = linha.Substring(indiceComecoConteudo, 34).Trim();
                    bool feito = linha[indiceComecoConteudo + 34] == '1';
                    bool negrito = linha[indiceComecoConteudo + 35] == '1';
                    materias[materias.Count - 1].conteudos.Add(new Conteudo(nomeConteudo, negrito, feito));
                    btnRemoverConteudo.Enabled = true;
                    btnCheckUncheck.Enabled = true;
                }
                switcher1_IndiceAtualMudou(this, new EventArgs());
                btnRemoverMateria.Enabled = true;
            }
            arquivoMaterias.Close();
        }
        public void GravarDados()
        {
            StreamWriter arquivoCronograma = new StreamWriter(caminhoCronograma, false, Encoding.Default);
            foreach (MateriaCr materia in materiasCronograma)
                arquivoCronograma.WriteLine(materia.ToString());
            arquivoCronograma.Close();
            StreamWriter arquivoMaterias = new StreamWriter(caminhoMaterias, false, Encoding.Default);
            foreach (MateriaMt materia in materias)
                arquivoMaterias.WriteLine(materia.ToString());
            arquivoMaterias.Close();
        }
        public static DiasDaSemana CodigoDoDia(string dia)
        {
            switch (dia)
            {
                case "Domingo":
                    return DiasDaSemana.Domingo;
                case "Segunda":
                    return DiasDaSemana.Segunda;
                case "Terça":
                    return DiasDaSemana.Terca;
                case "Terca":
                    return DiasDaSemana.Terca;
                case "Quarta":
                    return DiasDaSemana.Quarta;
                case "Quinta":
                    return DiasDaSemana.Quinta;
                case "Sexta":
                    return DiasDaSemana.Sexta;
                case "Sábado":
                    return DiasDaSemana.Sabado;
                case "Sabado":
                    return DiasDaSemana.Sabado;
            }
            throw new Exception("Dia Inválido");
        }
        private void dgCronogramas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1 &&
                dgCronogramas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null &&
                dgCronogramas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() != "")
                btnRemoverSelecionado.Enabled = true;
            else
                btnRemoverSelecionado.Enabled = false;
        }
        private void btnRemoverSelecionado_Click(object sender, EventArgs e)
        {

            Remover(dgCronogramas.SelectedCells[0].RowIndex,
                    dgCronogramas.SelectedCells[0].ColumnIndex);

            btnRemoverSelecionado.Enabled = false;

        }
        public void Remover(int indiceLinha, int indiceColuna)
        {
            try
            {
                for (int i = 0; i < materiasCronograma.Count; i++)
                    if (materiasCronograma[i].Dia == CodigoDoDia(dgCronogramas.Rows[0].Cells[indiceColuna].OwningColumn.HeaderCell.Value.ToString()) &&
                        materiasCronograma[i].Horario == dgCronogramas.Rows[indiceLinha].HeaderCell.Value.ToString())
                        materiasCronograma.RemoveAt(i);
                dgCronogramas.Rows[indiceLinha].Cells[indiceColuna].Value = "";
                // Remover linha se não tiver mais nenhuma matéria
                bool linhaVazia = true;
                for (int c = 0; c < dgCronogramas.ColumnCount; c++)
                    if (dgCronogramas.Rows[indiceLinha].Cells[c].Value != null && dgCronogramas.Rows[indiceLinha].Cells[c].Value.ToString() != "")
                    {
                        linhaVazia = false;
                        break;
                    }
                if (linhaVazia)
                    dgCronogramas.Rows.RemoveAt(indiceLinha);
            }
            catch { }

            VerificarInformacoes();
        }
        public void Adicionar(string horario, string nomeMateria, string dia)
        {
            if (horario.IndexOf(':') == 1)
                horario = 0 + horario;

            foreach (MateriaCr materia in materiasCronograma)
                if (materia.Horario == horario && materia.Dia == CodigoDoDia(dia))
                {
                    if (nomeMateria.Trim() != "")
                    {
                        materia.Nome = nomeMateria;

                        foreach (DataGridViewRow linha in dgCronogramas.Rows)
                            if (linha.HeaderCell.Value.ToString() == horario)
                                linha.Cells[(int)CodigoDoDia(dia)].Value = nomeMateria;
                    }
                    else
                    {
                        for (int i = 0; i < dgCronogramas.RowCount; i++)
                            if (dgCronogramas.Rows[i].HeaderCell.Value.ToString() == horario)
                                Remover(i, (int)CodigoDoDia(dia));
                    }
                    return;
                }

            MateriaCr novaMateria = new MateriaCr(nomeMateria, horario, CodigoDoDia(dia));
            materiasCronograma.Add(novaMateria);
            bool existeHorario = false;
            int qualLinha = 0;
            for (int i = 0; i < dgCronogramas.RowCount; i++)
                if (dgCronogramas.Rows[i].HeaderCell.Value.ToString() == horario)
                {
                    existeHorario = true;
                    qualLinha = i;
                    break;
                }
            if (!existeHorario)
            {
                int indiceDoisPontos = horario.IndexOf(':');
                int tempoNovaMateria = int.Parse(horario.Substring(0, indiceDoisPontos)) * 60 +
                    int.Parse(horario.Substring(indiceDoisPontos + 1));
                int tempoAtual;
                //dgCronogramas.RowCount++;

                bool achouLugarInterior = false;
                for (int i = 0; i < dgCronogramas.RowCount; i++) // Percorre as linhas até achar o lugar certo
                {
                    try
                    {
                        string horarioAtual = dgCronogramas.Rows[i].HeaderCell.Value.ToString();
                        indiceDoisPontos = horarioAtual.IndexOf(':');
                        tempoAtual = int.Parse(horarioAtual.Substring(0, indiceDoisPontos)) * 60 +
                                     int.Parse(horarioAtual.Substring(indiceDoisPontos + 1));
                    }
                    catch { tempoAtual = int.MaxValue; }
                    if (tempoNovaMateria < tempoAtual)
                    {
                        achouLugarInterior = true;
                        qualLinha = i;
                        break;
                    }
                }
                if (!achouLugarInterior)
                    qualLinha = dgCronogramas.RowCount;

                if (dgCronogramas.RowCount == 0)
                {
                    dgCronogramas.RowCount++;
                    dgCronogramas.Rows[0].Height = 35;
                    dgCronogramas.Rows[0].HeaderCell.Style.Font = new Font("Century Gothic", 12, FontStyle.Bold);
                    for (int j = 0; j < dgCronogramas.ColumnCount; j++)
                    {
                        dgCronogramas.Rows[0].Cells[j].Style.Font = new Font("Century Gothic", (float)9.5, FontStyle.Regular);
                        dgCronogramas.Rows[0].Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    dgCronogramas.Rows[0].HeaderCell.Value = horario;
                    dgCronogramas.Rows[0].Cells[(int)CodigoDoDia(dia)].Value = nomeMateria;
                }
                else
                {
                    DataGridViewRow linha = (DataGridViewRow)dgCronogramas.Rows[0].Clone();
                    for (int i = 0; i < dgCronogramas.ColumnCount; i++)
                        linha.Cells[i].Value = "";
                    linha.HeaderCell.Value = horario;
                    linha.Cells[(int)CodigoDoDia(dia)].Value = nomeMateria;
                    dgCronogramas.Rows.Insert(qualLinha, linha);
                }
            }
            else
                dgCronogramas.Rows[qualLinha].Cells[(int)CodigoDoDia(dia)].Value = nomeMateria;

        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string horario = txtHorario.Text;
            string nomeMateria = txtMateria.Text;
            string dia = cbxDia.SelectedItem.ToString();
            Adicionar(horario, nomeMateria.Trim(), dia);
            btnAdicionar.Text = "Atualizar";
        }
        private void VerificarInformacoes()
        {
            try
            {
                int hora = int.Parse(txtHorario.Text.Substring(0, txtHorario.Text.IndexOf(':')));
                int minutos = int.Parse(txtHorario.Text.Substring(txtHorario.Text.IndexOf(':') + 1, 2));
                if (minutos >= 60 || hora >= 24 || hora < 0 || minutos < 0)
                    throw new Exception();
                bool existe = false;
                string horarioATestar = txtHorario.Text;
                if (horarioATestar.IndexOf(':') == 1)
                    horarioATestar = 0 + txtHorario.Text;
                for (int i = 0; i < materiasCronograma.Count; i++)
                    if (materiasCronograma[i].Dia == CodigoDoDia(cbxDia.SelectedItem.ToString()) && materiasCronograma[i].Horario == horarioATestar)
                        existe = true;

                btnAdicionar.Enabled = cbxDia.SelectedIndex >= 0 && cbxDia.SelectedIndex < 7 && (existe || txtMateria.Text.Trim() != "");
                btnAdicionar.Text = existe ? "Atualizar" : "Adicionar";
            }
            catch
            {
                btnAdicionar.Enabled = false;
                btnAdicionar.Text = "Adicionar";
            }
        }
        private void txtHorario_TextChanged(object sender, EventArgs e)
        {
            VerificarInformacoes();
        }
        private void cbxDia_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerificarInformacoes();
        }
        private void txtMateria_TextChanged(object sender, EventArgs e)
        {
            if (btnAdicionar.Text == "Adicionar" || txtMateria.Text.Trim() == "")
                VerificarInformacoes();
            else
                btnAdicionar.Enabled = true;
        }

        private void dgCronogramas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtHorario.Text = dgCronogramas.Rows[e.RowIndex].HeaderCell.Value.ToString();
                cbxDia.SelectedIndex = e.ColumnIndex;

                DataGridViewCell celula = dgCronogramas.Rows[e.RowIndex].Cells[e.ColumnIndex];
                if (celula.Value == null || celula.Value.ToString() == "")
                {
                    txtMateria.Text = null;
                    btnAdicionar.Text = "Adicionar";
                    btnAdicionar.Enabled = false;
                }
                else
                {
                    txtMateria.Text = celula.Value.ToString();
                    btnAdicionar.Text = "Atualizar";
                    btnAdicionar.Enabled = true;
                }
            }
        }

        private void txtMateria2_TextChanged(object sender, EventArgs e)
        {
            bool existe = false;
            for (int i = 0; i < materias.Count; i++)
                if (materias[i].Nome == txtMateria2.Text.Trim())
                {
                    existe = true;
                    break;
                }
            btnAdicionarMateria2.Enabled = !existe && txtMateria2.Text.Trim() != "";
        }

        private void btnAdicionarMateria2_Click(object sender, EventArgs e)
        {
            materias.Add(new MateriaMt(txtMateria2.Text.Trim()));
            switcher1.Adicionar(txtMateria2.Text.Trim());
            btnAdicionarMateria2.Enabled = false;
            txtConteudo.Enabled = true;
            chkNegrito.Enabled = true;
            btnRemoverMateria.Enabled = true;
        }

        private void txtConteudo_TextChanged(object sender, EventArgs e)
        {
            bool existe = false;
            if (materias.Count > 0)
            {
                List<Conteudo> conteudos = materias[switcher1.IndiceAtual].conteudos;
                for (int i = 0; i < conteudos.Count; i++)
                    if (txtConteudo.Text.Trim() == conteudos[i].Nome)
                    {
                        existe = true;
                        break;
                    }
            }
            btnAdicionarConteudo.Enabled = !existe && txtConteudo.Text.Trim() != "";
        }

        private void btnAdicionarConteudo_Click(object sender, EventArgs e)
        {
            materias[switcher1.IndiceAtual].conteudos.Add(new Conteudo(txtConteudo.Text.Trim(), chkNegrito.Checked));
            dgvConteudos.RowCount++;
            dgvConteudos.Rows[dgvConteudos.RowCount - 1].Cells[0].Value = txtConteudo.Text.Trim();
            dgvConteudos.Rows[dgvConteudos.RowCount - 1].Height = 30;
            if (chkNegrito.Checked)
                dgvConteudos.Rows[dgvConteudos.RowCount - 1].Cells[0].Style.Font = new Font(
                    dgvConteudos.DefaultCellStyle.Font, FontStyle.Bold);
            dgvConteudos.ClearSelection();
            btnRemoverConteudo.Enabled = false;
            btnCheckUncheck.Enabled = false;
            ((DataGridViewImageCell)dgvConteudos.Rows[dgvConteudos.RowCount - 1].Cells[1]).ValueIsIcon = false;
            btnAdicionarConteudo.Enabled = false;
        }

        private void switcher1_IndiceAtualMudou(object sender, EventArgs e)
        {
            List<Conteudo> conteudos = materias[switcher1.IndiceAtual].conteudos;
            dgvConteudos.RowCount = conteudos.Count;
            for (int i = 0; i < conteudos.Count; i++)
            {
                dgvConteudos.Rows[i].Cells[0].Value = conteudos[i].Nome;
                dgvConteudos.Rows[i].Height = 30;
                if (conteudos[i].Feito)
                    ((DataGridViewImageCell)dgvConteudos.Rows[i].Cells[1]).Value = Properties.Resources.checked_1;
                else
                    ((DataGridViewImageCell)dgvConteudos.Rows[i].Cells[1]).Value = null;
                if (conteudos[i].Negrito)
                    dgvConteudos.Rows[i].Cells[0].Style.Font = new Font(
                        dgvConteudos.DefaultCellStyle.Font, FontStyle.Bold);
                else
                    dgvConteudos.Rows[i].Cells[0].Style.Font = dgvConteudos.DefaultCellStyle.Font;
            }
            txtConteudo_TextChanged(this, new EventArgs());
            dgvConteudos.ClearSelection();
            btnCheckUncheck.Enabled = false;
            btnRemoverConteudo.Enabled = false;
        }

        private void btnRemoverConteudo_Click(object sender, EventArgs e)
        {
            materias[switcher1.IndiceAtual].conteudos.RemoveAt(dgvConteudos.SelectedCells[0].RowIndex);
            dgvConteudos.Rows.RemoveAt(dgvConteudos.SelectedCells[0].RowIndex);
            txtConteudo_TextChanged(this, new EventArgs());
            btnRemoverConteudo.Enabled = false;
            btnCheckUncheck.Enabled = false;
            dgvConteudos.ClearSelection();

        }

        private void dgvConteudos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!materias[switcher1.IndiceAtual].conteudos[e.RowIndex].Feito)
                    btnCheckUncheck.Text = "Check";
                else
                    btnCheckUncheck.Text = "Uncheck";
                btnRemoverConteudo.Enabled = dgvConteudos.SelectedCells.Count > 0;
                btnCheckUncheck.Enabled = dgvConteudos.SelectedCells.Count > 0;
            }
            catch { }
        }

        private void btnCheckUncheck_Click(object sender, EventArgs e)
        {
            int indiceLinha = dgvConteudos.SelectedCells[0].RowIndex;
            materias[switcher1.IndiceAtual].conteudos[indiceLinha].Feito =
            !materias[switcher1.IndiceAtual].conteudos[indiceLinha].Feito;
            if (btnCheckUncheck.Text == "Check")
            {
                dgvConteudos.Rows[indiceLinha].Cells[1].Value = Properties.Resources.checked_1;
                btnCheckUncheck.Text = "Uncheck";
            }
            else
            {
                dgvConteudos.Rows[indiceLinha].Cells[1].Value = null;
                btnCheckUncheck.Text = "Check";
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            dgvConteudos.ClearSelection();
            btnRemoverConteudo.Enabled = false;
            btnCheckUncheck.Enabled = false;
        }

        private void btnRemoverMateria_Click(object sender, EventArgs e)
        {
            materias.RemoveAt(switcher1.IndiceAtual);
            switcher1.Remover(switcher1.ItemAtual);
            txtConteudo_TextChanged(this, new EventArgs());
            txtMateria2_TextChanged(this, new EventArgs());
            if (switcher1.QtosItens == 0)
            {
                dgvConteudos.RowCount = 0;
                txtConteudo.Enabled = false;
                chkNegrito.Enabled = false;
                btnAdicionarConteudo.Enabled = false;
            }
        }

        private void UcCronogramas_Resize(object sender, EventArgs e)
        {
            label1.Left = (Width - label1.Width) / 2;

            int tamanhoColunas = (dgCronogramas.Width - 82) / 7;
            for (int i = 0; i < 7; i++)
                dgCronogramas.Columns[i].Width = tamanhoColunas;

            gbAdicionar.Left = (Width - gbAdicionar.Width) / 2;
            btnRemoverSelecionado.Left = (Width - btnRemoverSelecionado.Width) / 2;
            pnlControleDaLista.Width = 311 + (Width - 718) / 3;
            if (pnlControleDaLista.Width > 468)
            {
                pnlControleDaLista.Width = 468;
                pnlLista.Width = tabPage2.Width - 473;
            }
            else
                pnlLista.Width = 409 + 2 * (Width - 718) / 3;

            btnCheckUncheck.Width = pnlLista.Width / 2 - 7;
            btnRemoverConteudo.Width = btnCheckUncheck.Width;
            btnRemoverConteudo.Left = pnlLista.Width - btnRemoverConteudo.Width - 2;
        }

        private void dgCronogramas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string horario = (dgCronogramas.Rows[e.RowIndex].HeaderCell.Value).ToString();
            object valor = dgCronogramas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            string nomeMateria = valor == null ? "" : valor.ToString().Trim();

            if (nomeMateria.Trim().Length > 50)
            {
                nomeMateria = nomeMateria.Substring(0, 50);
                dgCronogramas.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = nomeMateria;
            }
            string dia = cbxDia.Items[e.ColumnIndex].ToString();

            if (nomeMateria.Trim() == "")
                btnRemoverSelecionado.PerformClick();
            else
                Adicionar(horario, nomeMateria, dia);
        }

        private void dgCronogramas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                btnRemoverSelecionado.PerformClick();
        }
    }
}
