using Queme.Db;
using Queme.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Queme.UI.Windows
{
    public partial class BuscaOrcamento : Form
    {
        public BuscaOrcamento()
        {
            InitializeComponent();
        }

        private void PJRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BuscaRazaoPanel.Visible = true;
            BuscaNomePanel.Visible = false;
            IdPanel.Visible = false;

        }

        private void PFRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BuscaNomePanel.Visible = true;
            BuscaRazaoPanel.Visible = false;
            IdPanel.Visible = false;

        }

        private void BuscaOrcamento_Load(object sender, EventArgs e)
        {

            PJRadioButton.Checked = true;
            StatusOrcamento[] listaStatus = (StatusOrcamento[])Enum.GetValues(typeof(StatusOrcamento));

            foreach (var status in listaStatus)
            {
                statusComboBox.Items.Add(status);
            }

        }

        private void nOrcRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            BuscaNomePanel.Visible = false;
            BuscaRazaoPanel.Visible = false;
            IdPanel.Visible = true;
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DatasBtn_Click(object sender, EventArgs e)
        {
            apartirDateTimePicker.Value = DateTime.Parse("01/01/" + DateTime.Now.Year);
            ateDateTimePicker.Value = DateTime.Now;
        }

        private void BuscarClienteButton_Click(object sender, EventArgs e)
        {
            // passagem de parâmetros para busca do orçamento
            DateTime apartir = apartirDateTimePicker.Value;
            DateTime ate = ateDateTimePicker.Value;
            string parametroDePesquisa = PesquisaGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            string status = statusComboBox.Text;
            string textoPesquisa = "";
            switch (parametroDePesquisa)
            {
                case "Número (ID)":
                    textoPesquisa = IdTextBox.Text;
                    break;
                case "Nome (Pessoa Física)":
                    textoPesquisa = NomeTextBox.Text;
                    break;
                case "Razão Social":
                    textoPesquisa = razaoTextBox.Text;
                    break;

            }

            // to-do: criar variações para nome e Razao Social

            MessageBox.Show(apartir.ToString() + " " + ate.ToString() + " " + parametroDePesquisa + " " + status + " " + textoPesquisa);

            OrcamentoDb.getOrcamentosList(apartir, ate, parametroDePesquisa, status, textoPesquisa);


        }

        private void apartirDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
