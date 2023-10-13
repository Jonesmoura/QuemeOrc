namespace Queme.UI.Windows
{
    partial class BuscaClienteForm
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
            TitleLabel = new Label();
            InfoBuscaPanel = new Panel();
            BuscarClienteButton = new Button();
            BuscaFlowLayoutPanel = new FlowLayoutPanel();
            BuscaRazaoPanel = new Panel();
            RazaoTextBox = new TextBox();
            RazaoLabel = new Label();
            BuscaNomePanel = new Panel();
            NomeTextBox = new TextBox();
            NomeLabel = new Label();
            PFRadioButton = new RadioButton();
            PJRadioButton = new RadioButton();
            ClientesEncontradosPanel = new Panel();
            ClientesEncontradosDataGridView = new DataGridView();
            SelecionarClienteButton = new Button();
            botoesSelecaoPanel = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            InfoBuscaPanel.SuspendLayout();
            BuscaFlowLayoutPanel.SuspendLayout();
            BuscaRazaoPanel.SuspendLayout();
            BuscaNomePanel.SuspendLayout();
            ClientesEncontradosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ClientesEncontradosDataGridView).BeginInit();
            botoesSelecaoPanel.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TitleLabel.Location = new Point(328, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(140, 25);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Buscar Clientes";
            // 
            // InfoBuscaPanel
            // 
            InfoBuscaPanel.Controls.Add(BuscarClienteButton);
            InfoBuscaPanel.Controls.Add(BuscaFlowLayoutPanel);
            InfoBuscaPanel.Location = new Point(4, 67);
            InfoBuscaPanel.Name = "InfoBuscaPanel";
            InfoBuscaPanel.Size = new Size(750, 39);
            InfoBuscaPanel.TabIndex = 1;
            // 
            // BuscarClienteButton
            // 
            BuscarClienteButton.Location = new Point(530, 6);
            BuscarClienteButton.Name = "BuscarClienteButton";
            BuscarClienteButton.Size = new Size(70, 27);
            BuscarClienteButton.TabIndex = 1;
            BuscarClienteButton.Text = "Buscar";
            BuscarClienteButton.UseVisualStyleBackColor = true;
            BuscarClienteButton.Click += BuscarClienteButton_Click;
            // 
            // BuscaFlowLayoutPanel
            // 
            BuscaFlowLayoutPanel.Controls.Add(BuscaRazaoPanel);
            BuscaFlowLayoutPanel.Controls.Add(BuscaNomePanel);
            BuscaFlowLayoutPanel.Location = new Point(112, 3);
            BuscaFlowLayoutPanel.Name = "BuscaFlowLayoutPanel";
            BuscaFlowLayoutPanel.Size = new Size(398, 67);
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
            // PFRadioButton
            // 
            PFRadioButton.AutoSize = true;
            PFRadioButton.Location = new Point(292, 41);
            PFRadioButton.Name = "PFRadioButton";
            PFRadioButton.Size = new Size(93, 19);
            PFRadioButton.TabIndex = 2;
            PFRadioButton.TabStop = true;
            PFRadioButton.Text = "Pessoa Física";
            PFRadioButton.UseVisualStyleBackColor = true;
            PFRadioButton.CheckedChanged += PFRadioButton_CheckedChanged;
            // 
            // PJRadioButton
            // 
            PJRadioButton.AutoSize = true;
            PJRadioButton.Location = new Point(392, 41);
            PJRadioButton.Name = "PJRadioButton";
            PJRadioButton.Size = new Size(104, 19);
            PJRadioButton.TabIndex = 2;
            PJRadioButton.TabStop = true;
            PJRadioButton.Text = "Pessoa Jurídica";
            PJRadioButton.UseVisualStyleBackColor = true;
            PJRadioButton.CheckedChanged += PJRadioButton_CheckedChanged;
            // 
            // ClientesEncontradosPanel
            // 
            ClientesEncontradosPanel.Controls.Add(ClientesEncontradosDataGridView);
            ClientesEncontradosPanel.Location = new Point(5, 113);
            ClientesEncontradosPanel.Name = "ClientesEncontradosPanel";
            ClientesEncontradosPanel.Size = new Size(749, 229);
            ClientesEncontradosPanel.TabIndex = 3;
            // 
            // ClientesEncontradosDataGridView
            // 
            ClientesEncontradosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ClientesEncontradosDataGridView.Location = new Point(3, 3);
            ClientesEncontradosDataGridView.Name = "ClientesEncontradosDataGridView";
            ClientesEncontradosDataGridView.RowTemplate.Height = 25;
            ClientesEncontradosDataGridView.Size = new Size(743, 218);
            ClientesEncontradosDataGridView.TabIndex = 0;
            ClientesEncontradosDataGridView.CellContentClick += ClientesEncontradosDataGridView_CellContentClick;
            // 
            // SelecionarClienteButton
            // 
            SelecionarClienteButton.Location = new Point(3, 3);
            SelecionarClienteButton.Name = "SelecionarClienteButton";
            SelecionarClienteButton.Size = new Size(118, 23);
            SelecionarClienteButton.TabIndex = 4;
            SelecionarClienteButton.Text = "Selecionar Cliente";
            SelecionarClienteButton.UseVisualStyleBackColor = true;
            SelecionarClienteButton.Click += SelecionarClienteButton_Click;
            // 
            // botoesSelecaoPanel
            // 
            botoesSelecaoPanel.Controls.Add(flowLayoutPanel1);
            botoesSelecaoPanel.Location = new Point(5, 348);
            botoesSelecaoPanel.Name = "botoesSelecaoPanel";
            botoesSelecaoPanel.Size = new Size(254, 37);
            botoesSelecaoPanel.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(SelecionarClienteButton);
            flowLayoutPanel1.Location = new Point(3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(251, 30);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // BuscaClienteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(766, 450);
            Controls.Add(botoesSelecaoPanel);
            Controls.Add(ClientesEncontradosPanel);
            Controls.Add(PJRadioButton);
            Controls.Add(PFRadioButton);
            Controls.Add(InfoBuscaPanel);
            Controls.Add(TitleLabel);
            Name = "BuscaClienteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BuscaClienteForm";
            Load += BuscaClienteForm_Load;
            InfoBuscaPanel.ResumeLayout(false);
            BuscaFlowLayoutPanel.ResumeLayout(false);
            BuscaRazaoPanel.ResumeLayout(false);
            BuscaRazaoPanel.PerformLayout();
            BuscaNomePanel.ResumeLayout(false);
            BuscaNomePanel.PerformLayout();
            ClientesEncontradosPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ClientesEncontradosDataGridView).EndInit();
            botoesSelecaoPanel.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLabel;
        private Panel InfoBuscaPanel;
        private RadioButton PFRadioButton;
        private RadioButton PJRadioButton;
        private FlowLayoutPanel BuscaFlowLayoutPanel;
        private Panel BuscaRazaoPanel;
        private Panel BuscaNomePanel;
        private TextBox RazaoTextBox;
        private Label RazaoLabel;
        private Label NomeLabel;
        private Button BuscarClienteButton;
        private TextBox NomeTextBox;
        private Panel ClientesEncontradosPanel;
        private DataGridView ClientesEncontradosDataGridView;
        private Button SelecionarClienteButton;
        private Panel botoesSelecaoPanel;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}