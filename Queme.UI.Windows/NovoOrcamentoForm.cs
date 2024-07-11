using Queme.Db;
using Queme.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Queme.Models.Enums;
using Queme.Models.DTOs;
using Org.BouncyCastle.Crypto;
using Queme.Services;
using System.Diagnostics;

namespace Queme.UI.Windows
{
    public partial class NovoOrcamentoForm : Form
    {
        private static ReadOrcamentoDto orcamento;
        private static CondicaoDePagamento condicaoDePagamento;
        private static decimal totalCustosAdicionais;
        private static decimal totalServicos;

        public NovoOrcamentoForm()
        {
            InitializeComponent();
        }
        public NovoOrcamentoForm(Cliente cliente)
        {
            InitializeComponent();
            // Teste transferencia de dados do form de busca para o form de orçamentos
            PreenchimentoDeCamposDoCliente(cliente);
            orcamento = new ReadOrcamentoDto();

        }

        public NovoOrcamentoForm(int idOrcamento)
        {
            InitializeComponent();
            orcamento = OrcamentoDb.GetOrcamentoById(idOrcamento);
            PreenchimentoDeCamposDoCliente(orcamento.Cliente);
            AtualizarViewServicos(orcamento.Id);
            AtualizarViewCustosAdicionais(orcamento.Id);
            //to:do metodo para preencher informações referentes ao orçamento no form
            PreenchimentoDeDadosDoOrc(orcamento);
            AtualizarViewCondicoesDePagamento();

            AlterarCliente.Enabled = false;
            excluirCustoAddButton.Enabled = false;
            excluirServicoButton.Enabled = false;


        }

        private void NovoOrcamentoForm_Load(object sender, EventArgs e)
        {
            // carregar tabelas de preços

            TabelaDePrecosComboBox.Items.Clear();
            List<string> tabelas = TabelaDePrecoDb.getTabelas();
            foreach (string tabela in tabelas)
            {
                TabelaDePrecosComboBox.Items.Add(tabela);
            }

            inclusoRadioButton.Checked = true;
            simComissaoRadioButton.Checked = true;
            simArtRadioButton.Checked = true;
            excluirServicoButton.Enabled = false;
            excluirCustoAddButton.Enabled = false;


        }

        private void NomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AlterarCliente_Click(object sender, EventArgs e)
        {
            BuscaClienteForm.AlterarClienteOrc();

        }

        private void TabelaDePrecosComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TabelaDePrecosComboBox_SelectedIndexChanged(object sender, MouseEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            // método para consultar valor na tabela de PrecosPorDisciplina
            custoPorHoraTextBox.Text = CustoPorTipoDb.getValorEtapa(TabelaDePrecosComboBox.Text, disciplinaComboBox.Text).ToString();
        }

        private void estimativaHorasTextBox_TextChanged(object sender, EventArgs e)
        {
            bool EstimativaParse = double.TryParse(estimativaHorasTextBox.Text, out double estimativaDehoras);
            //método para calcular total do serviço
            if (EstimativaParse)
            {
                double totalEtapa = estimativaDehoras * Convert.ToDouble(custoPorHoraTextBox.Text);
                valorTotalEtapaTextBox.Text = totalEtapa.ToString("F2", CultureInfo.GetCultureInfo("pt-br"));
            }
            else if (estimativaHorasTextBox.Text != string.Empty)
            {
                MessageBox.Show("Usar o formato \"0.000,00\" para a estimativa de horas.");
            }
        }

        private void adicionarServicoButton_Click(object sender, EventArgs e)
        {
            if (nOrcTextBox.Text == string.Empty)
            {
                if (!ValidacaoDeDados.ValidacaoInputCep(CepTextBox.Text) || ComplementoTextBox.Text == string.Empty || int.Parse(numeroTextBox.Text) <= 0)
                {
                    MessageBox.Show("Formato do Endereço inválido");
                    return;
                };
                int id_cliente = int.Parse(id_clienteLabel.Text);
                int idTabelaDeCustos = TabelaDePrecoDb.CapturarId(TabelaDePrecosComboBox.Text);
                Orcamento orc = new Orcamento(id_cliente, idTabelaDeCustos);
                var db = new OrcamentoDb();
                int id = db.Incluir(orc);

                orc.Endereco = EnderecoObraDb.IncluirEndereco(id, CepTextBox.Text, ComplementoTextBox.Text, int.Parse(numeroTextBox.Text));
                nOrcTextBox.Text = id.ToString();
                orcamento.Id = id;
            }
            ServicosDb servicoDb = new ServicosDb();
            Servico servico = new Servico();
            servico.Id_orcamento = int.Parse(nOrcTextBox.Text);
            servico.Etapa = Enum.Parse<EtapasServico>(etapaComboBox.Text);
            servico.TipoServico = Enum.Parse<TipoServico>(disciplinaComboBox.Text);
            servico.Qtd_horas = int.Parse(estimativaHorasTextBox.Text);
            servico.ValorHora = double.Parse(custoPorHoraTextBox.Text, CultureInfo.GetCultureInfo("pt-br"));
            servico.TotalServico = double.Parse(valorTotalEtapaTextBox.Text, CultureInfo.GetCultureInfo("pt-br"));
            servicoDb.IncluirServico(servico);

            // atualizar dataGridView a cada inserção

            AtualizarViewServicos(servico.Id_orcamento);
        }

        public void AtualizarViewServicos(int id_orcamento)
        {
            ServicosDb servicoDb = new ServicosDb();
            servicosDataGridView.DataSource = servicoDb.GetServicoList(id_orcamento);
            servicosDataGridView.AutoGenerateColumns = true;
            servicosDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            servicosDataGridView.ReadOnly = false;
            servicosDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            servicosDataGridView.RowHeadersVisible = false;
            servicosDataGridView.EnableHeadersVisualStyles = false;
            servicosDataGridView.Columns["id_orcamento"].Visible = false;
            servicosDataGridView.Columns["Id"].Visible = false;

            servicosDataGridView.Columns["TipoServico"].HeaderText = "Disciplina";
            servicosDataGridView.Columns["Qtd_horas"].HeaderText = "Quantidade Horas";
            servicosDataGridView.Columns["ValorHora"].HeaderText = "Valor/Hora (R$)";
            servicosDataGridView.Columns["TotalServico"].HeaderText = "Valor Total (R$)";


            servicosDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            servicosDataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            totalServicos = OrcamentoDb.TotalServicos(id_orcamento);
            totalServicosTextBox.Text = totalServicos.ToString("c", CultureInfo.GetCultureInfo("pt-br"));

            if (servicosDataGridView.Rows.Count != 0)
            {
                TabelaDePrecosComboBox.Enabled = false;
            }
            else
            {
                TabelaDePrecosComboBox.Enabled = true;

            }

        }

        public void PreenchimentoDeCamposDoCliente(Cliente cliente)
        {
            NomeTextBox.Text = cliente.Name.ToString();
            EmailTextBox.Text = cliente.Email.ToString();
            TelTextBox.Text = cliente.Tel.ToString();
            id_clienteLabel.Text = cliente.ID.ToString();
            id_clienteLabel.Visible = false;

            if (cliente.CNPJ != "")
            {
                RazaoTextBox.Text = cliente.razaoSocial.ToString();
                CnpjTextBox.Text = cliente.CNPJ.ToString();
                CnpjPanel.Visible = true;
                RazaoPanel.Visible = true;
                CpfPanel.Visible = false;
            }
            else if (cliente.CPF != "")
            {
                CpfTextBox.Text = cliente.CPF.ToString();
                CnpjPanel.Visible = false;
                RazaoPanel.Visible = false;
                CpfPanel.Visible = true;

            }
        }

        public void PreenchimentoDeDadosDoOrc(ReadOrcamentoDto orcamento)
        {
            TabelaDePrecosComboBox.Text = TabelaDePrecoDb.CapturarDesc(orcamento.IdTabelaDeCustos);
            CepTextBox.Text = orcamento.EnderecoObra.CEP;
            numeroTextBox.Text = orcamento.EnderecoObra.Numero.ToString();
            ComplementoTextBox.Text = orcamento.EnderecoObra.Complemento;
            nOrcTextBox.Text = orcamento.Id.ToString();

        }

        private void recolherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            percentImpstoMaskedTextBox.ReadOnly = true;
        }

        private void inclusoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            percentImpstoMaskedTextBox.ReadOnly = false;
        }

        private void naoComissaoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            percentComissaoMaskedTextBox.ReadOnly = true;
        }

        private void simComissaoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            percentComissaoMaskedTextBox.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoriaDeCustoAdicional categoria = Enum.Parse<CategoriaDeCustoAdicional>(categoriaComboBox.Text);
            CustoAdicional custoAdicional = new CustoAdicional(int.Parse(nOrcTextBox.Text), categoria, descricaoTextBox.Text, decimal.Parse(valorUnTextBox.Text), int.Parse(qtdTextBox.Text), decimal.Parse(totalTextBox.Text));
            CustosAdicionaisDb.IncluirCustoAdicional(custoAdicional);

            AtualizarViewCustosAdicionais(custoAdicional.Id_orcamento);

        }

        private void AtualizarViewCustosAdicionais(int id_orcamento)
        {
            custosAdicionaisDataGridView.DataSource = CustosAdicionaisDb.GetCustosAdicionaisList(id_orcamento);
            custosAdicionaisDataGridView.AutoGenerateColumns = true;
            custosAdicionaisDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            custosAdicionaisDataGridView.ReadOnly = false;
            custosAdicionaisDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            custosAdicionaisDataGridView.RowHeadersVisible = false;
            custosAdicionaisDataGridView.EnableHeadersVisualStyles = false;
            custosAdicionaisDataGridView.Columns["id_orcamento"].Visible = false;
            custosAdicionaisDataGridView.Columns["ValorUN"].HeaderText = "Valor Unitário (R$)";
            custosAdicionaisDataGridView.Columns["ValorTotal"].HeaderText = "Valor Total (R$)";
            custosAdicionaisDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            custosAdicionaisDataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            totalCustosAdicionais = OrcamentoDb.TotalCustosAdicionais(id_orcamento);
            totalCustosAdicionaisTextBox.Text = totalCustosAdicionais.ToString("c", CultureInfo.CreateSpecificCulture("pt-br"));
        }

        private void valorTotalEtapaTextBox_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException("Função não implementada");
        }

        private void qtdTextBox_TextChanged(object sender, EventArgs e)
        {

            if (qtdTextBox.Text != string.Empty && valorUnTextBox.Text != string.Empty)
            {
                int.TryParse(qtdTextBox.Text, out int qtd);
                decimal.TryParse(valorUnTextBox.Text, out decimal valorUn);

                decimal totalCustoAdicional = qtd * valorUn;

                totalTextBox.Text = totalCustoAdicional.ToString("F2", CultureInfo.GetCultureInfo("pt-br"));
            }
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            double imposto = 0;
            double comissao = 0;
            bool incluirArt = true;
            if (inclusoRadioButton.Checked)
            {
                double.TryParse(percentImpstoMaskedTextBox.Text.Replace(".", ","), out imposto);
            }

            if (simComissaoRadioButton.Checked)
            {
                double.TryParse(percentComissaoMaskedTextBox.Text.Replace(".", ","), out comissao);
            }

            if (naoArtRadioButton.Checked)
            {
                incluirArt = false;
            }

            decimal total = CalculosDeOrcamento.ValorTotalOrcamento(totalServicos, totalCustosAdicionais, incluirArt, imposto, comissao);
            orcamento.ValorTotal = total;
            condicaoDePagamento = new CondicaoDePagamento(double.Parse(percentualEntradaMaskedTextBox.Text.Replace('.', ',')), int.Parse(parcelasComboBox.Text), int.Parse(periodicidadeComboBox.Text), total, double.Parse(descontoMaskedTextBox.Text.Replace('.', ',')), int.Parse(nOrcTextBox.Text));

            condicaoDePagamentoLabel.Text = condicaoDePagamento.ToString();

        }

        private void AdicionarCondicaoButton_Click(object sender, EventArgs e)
        {
            int idOrcamento = int.Parse(nOrcTextBox.Text);
            if (inclusoRadioButton.Checked)
            {
                double imposto = double.Parse(percentImpstoMaskedTextBox.Text, CultureInfo.GetCultureInfo("pt-br"));
                OrcamentoDb.SetOrUpdateTax(imposto, idOrcamento);
            }
            CondicoesDePagamentoDb.Incluir(idOrcamento, condicaoDePagamento);
            //orcamento.CondicaoDePagamentos.Add(condicaoDePagamento);
            AtualizarViewCondicoesDePagamento();

        }

        public void AtualizarViewCondicoesDePagamento()
        {
            orcamento.CondicaoDePagamentos = CondicoesDePagamentoDb.GetListCondicoes(int.Parse(nOrcTextBox.Text));
            CondicoesDePagamentoLabel.Text = "";
            for (int i = 0; i < orcamento.CondicaoDePagamentos.Count; i++)
            {
                CondicoesDePagamentoLabel.Text += $"{i + 1} - {orcamento.CondicaoDePagamentos[i]} \r\n";
            }
        }

        private void servicosDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (servicosDataGridView.SelectedRows.Count > 0)
            {
                excluirServicoButton.Enabled = true;
            }
            else
            {
                excluirServicoButton.Enabled = false;
            }
        }

        private void excluirServicoButton_Click(object sender, EventArgs e)
        {
            //int indiceSelecionado = dataGridView1.SelectedRows[0].Index;
            //SeuObjeto objetoSelecionado = listaDeObjetos[indiceSelecionado];
            ServicosDb servicoDb = new ServicosDb();
            List<Servico> listaServicos = servicoDb.GetServicoList(orcamento.Id);
            int indiceNoDataGrid = servicosDataGridView.SelectedRows[0].Index;
            Servico servicoExluir = listaServicos[indiceNoDataGrid];

            try
            {
                servicoDb.Excluir(servicoExluir);
                AtualizarViewServicos(orcamento.Id);
                MessageBox.Show("Serviço excluido.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir Serviço." + ex.Message);
            }
        }

        private void custosAdicionaisDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (custosAdicionaisDataGridView.SelectedRows.Count > 0)
            {
                excluirCustoAddButton.Enabled = true;

            }
            else
            {
                excluirCustoAddButton.Enabled = false;
            }
        }

        private void excluirCustoAddButton_Click(object sender, EventArgs e)
        {
            List<CustoAdicional> custosAdicionais = CustosAdicionaisDb.GetCustosAdicionaisList(orcamento.Id);
            int indiceNoDataGrid = custosAdicionaisDataGridView.SelectedRows[0].Index;
            CustoAdicional custoExcluir = custosAdicionais[indiceNoDataGrid];

            try
            {
                CustosAdicionaisDb.Excluir(custoExcluir);
                AtualizarViewCustosAdicionais(orcamento.Id);
                MessageBox.Show("Custo adicional excluido.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao excluir o custo adicinal. " + ex.Message);
            }

        }

        private void gerarPropostaButton_Click(object sender, EventArgs e)
        {
            PropostaComercial propostaComercial = new PropostaComercial();
            propostaComercial.Cliente = orcamento.Cliente;
            string html = PropostaService.GerarProposta(propostaComercial);
            ExibirHTML(html);

        }

        private static void ExibirHTML(string htmlContent)
        {
            // Criação de um arquivo temporário para exibição no WebBrowser
            Directory.SetCurrentDirectory(AppDomain.CurrentDomain.BaseDirectory);
            string tempFilePath = Path.GetFullPath(Path.Combine("..", "..", "..", "Templates", "temp.html"));
            File.WriteAllText(tempFilePath, htmlContent);

            // Abre o arquivo temporário no WebBrowser
            //WebBrowser webBrowser = new WebBrowser();
            //webBrowser.Size = new Size(900, 2970);
            //webBrowser.Navigate(tempFilePath);
            //Form form = new Form();
            //form.StartPosition = FormStartPosition.CenterScreen;
            //form.Size = new Size(900, 2970);
            //form.Controls.Add(webBrowser);
            //form.ShowDialog();

            //Abrindo o browser padrão pelo cmd

            var browserProcess = new Process();
            browserProcess.StartInfo = new ProcessStartInfo(tempFilePath)
            {
                UseShellExecute = true
            };
            browserProcess.Start();

        }

        private void valorUnTextBox_TextChanged(object sender, EventArgs e)
        {
            if (qtdTextBox.Text != string.Empty && valorUnTextBox.Text != string.Empty)
            {
                int.TryParse(qtdTextBox.Text, out int qtd);
                decimal.TryParse(valorUnTextBox.Text, out decimal valorUn);

                decimal totalCustoAdicional = qtd * valorUn;

                totalTextBox.Text = totalCustoAdicional.ToString("F2", CultureInfo.GetCultureInfo("pt-BR"));
            }
        }

        private void totalTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExibirDescricaoDisciplinas();
        }
        public void ExibirDescricaoDisciplinas()
        {
            //Refatorar esta função
            //test
            ServicosDb servicodb = new ServicosDb();
            List<string> disciplinas = servicodb.DisciplinasDoOrcamento(orcamento.Id);
            //to-do: lógica para verificação das disciplinas do orçamento e exibição da caixa para descrição
            foreach (TextBox textBox in descricoesServicosFlowLayoutPanel.Controls)
            {
                textBox.Visible = false;
            }

            if (disciplinas.Contains("Consultoria"))
            {
                consultoriaTextBox.Visible = true;
            }
            if (disciplinas.Contains("Estrutural"))
            {
                estruturalTextBox.Visible = true;
            }
            if (disciplinas.Contains("Arquitetura"))
            {
                arquiteturaTextBox.Visible = true;
            }
            if (disciplinas.Contains("Elétrico"))
            {
                eletricoTextBox.Visible = true;
            }
            if (disciplinas.Contains("Hidrossanitário"))
            {
                hidroTextBox.Visible = true;
            }
            if (disciplinas.Contains("HVAC"))
            {
                HVACTextBox.Visible = true;
            }
        }

        private void excluirCondicoesButton_Click(object sender, EventArgs e)
        {
            ExcluirCondicaoDePagamento form = new ExcluirCondicaoDePagamento(orcamento.Id);
            form.Show();
        }

        private void numeroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void custoPorHoraTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
