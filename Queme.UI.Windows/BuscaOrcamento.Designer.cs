namespace Queme.UI.Windows
{
    partial class BuscaOrcamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            botoesSelecaoPanel = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SelecionarOrcButton = new Button();
            ClientesEncontradosPanel = new Panel();
            ClientesEncontradosDataGridView = new DataGridView();
            PJRadioButton = new RadioButton();
            nOrcRadioButton = new RadioButton();
            InfoBuscaPanel = new Panel();
            BuscarClienteButton = new Button();
            BuscaFlowLayoutPanel = new FlowLayoutPanel();
            BuscaRazaoPanel = new Panel();
            RazaoTextBox = new TextBox();
            RazaoLabel = new Label();
            BuscaNomePanel = new Panel();
            NomeTextBox = new TextBox();
            NomeLabel = new Label();
            IdPanel = new Panel();
            IdTextBox = new TextBox();
            IdLabel = new Label();
            buscarOrcamentoLabel = new Label();
            PesquisaGroupBox = new GroupBox();
            PFRadioButton = new RadioButton();
            groupBox1 = new GroupBox();
            DatasBtn = new Button();
            ateDataLabel = new Label();
            apartirDataLabel = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            groupBox2 = new GroupBox();
            statusComboBox = new ComboBox();
            botoesSelecaoPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ClientesEncontradosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClientesEncontradosDataGridView).BeginInit();
            InfoBuscaPanel.SuspendLayout();
            BuscaFlowLayoutPanel.SuspendLayout();
            BuscaRazaoPanel.SuspendLayout();
            BuscaNomePanel.SuspendLayout();
            IdPanel.SuspendLayout();
            PesquisaGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // botoesSelecaoPanel
            // 
            botoesSelecaoPanel.Controls.Add(flowLayoutPanel1);
            botoesSelecaoPanel.Location = new Point(6, 391);
            botoesSelecaoPanel.Name = "botoesSelecaoPanel";
            botoesSelecaoPanel.Size = new Size(157, 37);
            botoesSelecaoPanel.TabIndex = 12;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(SelecionarOrcButton);
            flowLayoutPanel1.Location = new Point(3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(146, 30);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // SelecionarOrcButton
            // 
            SelecionarOrcButton.Location = new Point(3, 3);
            SelecionarOrcButton.Name = "SelecionarOrcButton";
            SelecionarOrcButton.Size = new Size(142, 23);
            SelecionarOrcButton.TabIndex = 4;
            SelecionarOrcButton.Text = "Selecionar Orçamento";
            SelecionarOrcButton.UseVisualStyleBackColor = true;
            // 
            // ClientesEncontradosPanel
            // 
            ClientesEncontradosPanel.Controls.Add(ClientesEncontradosDataGridView);
            ClientesEncontradosPanel.Location = new Point(6, 156);
            ClientesEncontradosPanel.Name = "ClientesEncontradosPanel";
            ClientesEncontradosPanel.Size = new Size(749, 229);
            ClientesEncontradosPanel.TabIndex = 11;
            // 
            // ClientesEncontradosDataGridView
            // 
            ClientesEncontradosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClientesEncontradosDataGridView.Location = new Point(3, 0);
            ClientesEncontradosDataGridView.Name = "ClientesEncontradosDataGridView";
            ClientesEncontradosDataGridView.RowTemplate.Height = 25;
            ClientesEncontradosDataGridView.Size = new Size(743, 221);
            ClientesEncontradosDataGridView.TabIndex = 0;
            // 
            // PJRadioButton
            // 
            PJRadioButton.AutoSize = true;
            PJRadioButton.Location = new Point(103, 22);
            PJRadioButton.Name = "PJRadioButton";
            PJRadioButton.Size = new Size(90, 19);
            PJRadioButton.TabIndex = 9;
            PJRadioButton.TabStop = true;
            PJRadioButton.Text = "Razão Social";
            PJRadioButton.UseVisualStyleBackColor = true;
            PJRadioButton.CheckedChanged += PJRadioButton_CheckedChanged;
            // 
            // nOrcRadioButton
            // 
            nOrcRadioButton.AutoSize = true;
            nOrcRadioButton.Location = new Point(6, 22);
            nOrcRadioButton.Name = "nOrcRadioButton";
            nOrcRadioButton.Size = new Size(91, 19);
            nOrcRadioButton.TabIndex = 10;
            nOrcRadioButton.TabStop = true;
            nOrcRadioButton.Text = "Número (ID)";
            nOrcRadioButton.UseVisualStyleBackColor = true;
            nOrcRadioButton.CheckedChanged += nOrcRadioButton_CheckedChanged;
            // 
            // InfoBuscaPanel
            // 
            InfoBuscaPanel.Controls.Add(BuscarClienteButton);
            InfoBuscaPanel.Controls.Add(BuscaFlowLayoutPanel);
            InfoBuscaPanel.Location = new Point(36, 104);
            InfoBuscaPanel.Name = "InfoBuscaPanel";
            InfoBuscaPanel.Size = new Size(499, 48);
            InfoBuscaPanel.TabIndex = 8;
            // 
            // BuscarClienteButton
            // 
            BuscarClienteButton.Location = new Point(423, 6);
            BuscarClienteButton.Name = "BuscarClienteButton";
            BuscarClienteButton.Size = new Size(70, 27);
            BuscarClienteButton.TabIndex = 1;
            BuscarClienteButton.Text = "Buscar";
            BuscarClienteButton.UseVisualStyleBackColor = true;
            // 
            // BuscaFlowLayoutPanel
            // 
            BuscaFlowLayoutPanel.Controls.Add(BuscaRazaoPanel);
            BuscaFlowLayoutPanel.Controls.Add(BuscaNomePanel);
            BuscaFlowLayoutPanel.Controls.Add(IdPanel);
            BuscaFlowLayoutPanel.Location = new Point(5, 3);
            BuscaFlowLayoutPanel.Name = "BuscaFlowLayoutPanel";
            BuscaFlowLayoutPanel.Size = new Size(398, 38);
            BuscaFlowLayoutPanel.TabIndex = 0;
            // 
            // BuscaRazaoPanel
            // 
            BuscaRazaoPanel.Controls.Add(RazaoTextBox);
            BuscaRazaoPanel.Controls.Add(RazaoLabel);
            BuscaRazaoPanel.Location = new Point(3, 3);
            BuscaRazaoPanel.Name = "BuscaRazaoPanel";
            BuscaRazaoPanel.Size = new Size(385, 28);
            BuscaRazaoPanel.TabIndex = 0;
            // 
            // RazaoTextBox
            // 
            RazaoTextBox.Location = new Point(92, 3);
            RazaoTextBox.Name = "RazaoTextBox";
            RazaoTextBox.Size = new Size(283, 23);
            RazaoTextBox.TabIndex = 1;
            // 
            // RazaoLabel
            // 
            RazaoLabel.AutoSize = true;
            RazaoLabel.Location = new Point(11, 6);
            RazaoLabel.Name = "RazaoLabel";
            RazaoLabel.Size = new Size(75, 15);
            RazaoLabel.TabIndex = 0;
            RazaoLabel.Text = "Razão Social:";
            // 
            // BuscaNomePanel
            // 
            BuscaNomePanel.Controls.Add(NomeTextBox);
            BuscaNomePanel.Controls.Add(NomeLabel);
            BuscaNomePanel.Location = new Point(3, 37);
            BuscaNomePanel.Name = "BuscaNomePanel";
            BuscaNomePanel.Size = new Size(385, 28);
            BuscaNomePanel.TabIndex = 1;
            // 
            // NomeTextBox
            // 
            NomeTextBox.Location = new Point(92, 2);
            NomeTextBox.Name = "NomeTextBox";
            NomeTextBox.Size = new Size(283, 23);
            NomeTextBox.TabIndex = 1;
            // 
            // NomeLabel
            // 
            NomeLabel.AutoSize = true;
            NomeLabel.Location = new Point(11, 6);
            NomeLabel.Name = "NomeLabel";
            NomeLabel.Size = new Size(43, 15);
            NomeLabel.TabIndex = 0;
            NomeLabel.Text = "Nome:";
            // 
            // IdPanel
            // 
            IdPanel.Controls.Add(IdTextBox);
            IdPanel.Controls.Add(IdLabel);
            IdPanel.Location = new Point(3, 71);
            IdPanel.Name = "IdPanel";
            IdPanel.Size = new Size(385, 28);
            IdPanel.TabIndex = 2;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(92, 2);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(283, 23);
            IdTextBox.TabIndex = 1;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(11, 6);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "ID:";
            // 
            // buscarOrcamentoLabel
            // 
            buscarOrcamentoLabel.AutoSize = true;
            buscarOrcamentoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            buscarOrcamentoLabel.Location = new Point(329, 9);
            buscarOrcamentoLabel.Name = "buscarOrcamentoLabel";
            buscarOrcamentoLabel.Size = new Size(175, 25);
            buscarOrcamentoLabel.TabIndex = 7;
            buscarOrcamentoLabel.Text = "Buscar Orçamentos";
            // 
            // PesquisaGroupBox
            // 
            PesquisaGroupBox.Controls.Add(PFRadioButton);
            PesquisaGroupBox.Controls.Add(nOrcRadioButton);
            PesquisaGroupBox.Controls.Add(PJRadioButton);
            PesquisaGroupBox.Location = new Point(5, 49);
            PesquisaGroupBox.Name = "PesquisaGroupBox";
            PesquisaGroupBox.Size = new Size(338, 47);
            PesquisaGroupBox.TabIndex = 13;
            PesquisaGroupBox.TabStop = false;
            PesquisaGroupBox.Text = "Parâmetro de Pesquisa:";
            // 
            // PFRadioButton
            // 
            PFRadioButton.AutoSize = true;
            PFRadioButton.Location = new Point(199, 22);
            PFRadioButton.Name = "PFRadioButton";
            PFRadioButton.Size = new Size(137, 19);
            PFRadioButton.TabIndex = 11;
            PFRadioButton.TabStop = true;
            PFRadioButton.Text = "Nome (Pessoa Física)";
            PFRadioButton.UseVisualStyleBackColor = true;
            PFRadioButton.CheckedChanged += PFRadioButton_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(DatasBtn);
            groupBox1.Controls.Add(ateDataLabel);
            groupBox1.Controls.Add(apartirDataLabel);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Location = new Point(550, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(190, 99);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data:";
            // 
            // DatasBtn
            // 
            DatasBtn.Location = new Point(16, 70);
            DatasBtn.Name = "DatasBtn";
            DatasBtn.Size = new Size(148, 23);
            DatasBtn.TabIndex = 2;
            DatasBtn.Text = "Limpar Datas";
            DatasBtn.UseVisualStyleBackColor = true;
            // 
            // ateDataLabel
            // 
            ateDataLabel.AutoSize = true;
            ateDataLabel.Location = new Point(16, 47);
            ateDataLabel.Name = "ateDataLabel";
            ateDataLabel.Size = new Size(28, 15);
            ateDataLabel.TabIndex = 1;
            ateDataLabel.Text = "Até:";
            // 
            // apartirDataLabel
            // 
            apartirDataLabel.AutoSize = true;
            apartirDataLabel.Location = new Point(10, 18);
            apartirDataLabel.Name = "apartirDataLabel";
            apartirDataLabel.Size = new Size(46, 15);
            apartirDataLabel.TabIndex = 1;
            apartirDataLabel.Text = "Apartir:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(61, 43);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(103, 23);
            dateTimePicker2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(61, 14);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(103, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(statusComboBox);
            groupBox2.Location = new Point(349, 51);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(186, 47);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Status:";
            // 
            // statusComboBox
            // 
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(34, 16);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(121, 23);
            statusComboBox.TabIndex = 0;
            statusComboBox.SelectedIndexChanged += statusComboBox_SelectedIndexChanged;
            // 
            // BuscaOrcamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(PesquisaGroupBox);
            Controls.Add(botoesSelecaoPanel);
            Controls.Add(ClientesEncontradosPanel);
            Controls.Add(InfoBuscaPanel);
            Controls.Add(buscarOrcamentoLabel);
            Name = "BuscaOrcamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Orçamento";
            Load += BuscaOrcamento_Load;
            botoesSelecaoPanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ClientesEncontradosPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ClientesEncontradosDataGridView).EndInit();
            InfoBuscaPanel.ResumeLayout(false);
            BuscaFlowLayoutPanel.ResumeLayout(false);
            BuscaRazaoPanel.ResumeLayout(false);
            BuscaRazaoPanel.PerformLayout();
            BuscaNomePanel.ResumeLayout(false);
            BuscaNomePanel.PerformLayout();
            IdPanel.ResumeLayout(false);
            IdPanel.PerformLayout();
            PesquisaGroupBox.ResumeLayout(false);
            PesquisaGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel botoesSelecaoPanel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button SelecionarOrcButton;
        private Panel ClientesEncontradosPanel;
        private DataGridView ClientesEncontradosDataGridView;
        private RadioButton PJRadioButton;
        private RadioButton nOrcRadioButton;
        private Panel InfoBuscaPanel;
        private Button BuscarClienteButton;
        private FlowLayoutPanel BuscaFlowLayoutPanel;
        private Panel BuscaRazaoPanel;
        private TextBox RazaoTextBox;
        private Label RazaoLabel;
        private Panel BuscaNomePanel;
        private TextBox NomeTextBox;
        private Label NomeLabel;
        private Label buscarOrcamentoLabel;
        private GroupBox PesquisaGroupBox;
        private RadioButton PFRadioButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Panel IdPanel;
        private TextBox IdTextBox;
        private Label IdLabel;
        private DateTimePicker dateTimePicker1;
        private Label apartirDataLabel;
        private DateTimePicker dateTimePicker2;
        private Label ateDataLabel;
        private ComboBox statusComboBox;
        private Button DatasBtn;
    }
}