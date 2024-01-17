using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Queme.Db;

namespace Queme.UI.Windows
{
    public partial class ExcluirCondicaoDePagamento : Form
    {
        public ExcluirCondicaoDePagamento()
        {
            InitializeComponent();
        }
        public ExcluirCondicaoDePagamento(int idOrcamento)
        {
            InitializeComponent();
            condicoesDePagDataGridView.DataSource = CondicoesDePagamentoDb.GetListCondicoes(idOrcamento);
            //formatar layout
            condicoesDePagDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            condicoesDePagDataGridView.ReadOnly = false;
            condicoesDePagDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            condicoesDePagDataGridView.RowHeadersVisible = false;
            condicoesDePagDataGridView.EnableHeadersVisualStyles = false;

            condicoesDePagDataGridView.Columns["Id"].Visible = false;
            condicoesDePagDataGridView.Columns["OrcamentoId"].Visible = false;
            condicoesDePagDataGridView.Columns["PercentualDeEntrada"].HeaderText = "Entrada (%)";
            condicoesDePagDataGridView.Columns["QuantidadeDeParcelas"].HeaderText = "Parcelas";
            condicoesDePagDataGridView.Columns["PeriodicidadeDeParcela"].HeaderText = "Periodicidade";
            condicoesDePagDataGridView.Columns["ValorTotalOrcamento"].HeaderText = "Valor Total";
            condicoesDePagDataGridView.Columns["Desconto"].HeaderText = "Desconto (%)";

            //to-do: Formatação de dados
        }

        private void ExcluirCondicaoDePagamento_Load(object sender, EventArgs e)
        {
            // to-do: Captura do id da condição e execução da função para exclusão, com mensagem de retorno positiva ou negativa
        }
    }
}
