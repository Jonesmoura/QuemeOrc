using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void ExcluirCondicaoDePagamento_Load(object sender, EventArgs e)
        {

        }
    }
}
