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
    public partial class DefinirDescricaoDaCondicaoDePagamento : Form
    {
        public string DescricaoCondicao { get; set; }
        public DefinirDescricaoDaCondicaoDePagamento()
        {
            InitializeComponent();
        }

        private void SalvarBtn_Click(object sender, EventArgs e)
        {
            if (DescricaoTextBox.Text == "")
            {
                MessageBox.Show("É necessário inserir uma descrição para a condição");
            }
            else
            {
                DescricaoCondicao = DescricaoTextBox.Text;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        public string ReturnDescription()
        {
            return DescricaoCondicao;
        }

    }
}
