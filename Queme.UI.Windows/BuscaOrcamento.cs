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

            //Alimentar comboBox de status com a listaStatus


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
    }
}
