namespace Queme.UI.Windows
{
    partial class ClientesForm
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
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            NovoButton = new Button();
            AlterarButton = new Button();
            ExcluirButton = new Button();
            SairButton = new Button();
            ConfirmarInclusaoButton = new Button();
            confirmarAlterarButton = new Button();
            ConfirmarExcluirButton = new Button();
            VoltarButton = new Button();
            ConteudoPanel = new Panel();
            FichaPanel = new Panel();
            TelTextBox = new TextBox();
            label4 = new Label();
            EmailTextBox = new TextBox();
            label3 = new Label();
            NameTextBox = new TextBox();
            NomeLabel = new Label();
            IDtextBox = new TextBox();
            IDlabel = new Label();
            listaDataGridView = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ConteudoPanel.SuspendLayout();
            FichaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)listaDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 384);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 66);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(NovoButton);
            flowLayoutPanel1.Controls.Add(AlterarButton);
            flowLayoutPanel1.Controls.Add(ExcluirButton);
            flowLayoutPanel1.Controls.Add(SairButton);
            flowLayoutPanel1.Controls.Add(ConfirmarInclusaoButton);
            flowLayoutPanel1.Controls.Add(confirmarAlterarButton);
            flowLayoutPanel1.Controls.Add(ConfirmarExcluirButton);
            flowLayoutPanel1.Controls.Add(VoltarButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(30, 20, 0, 0);
            flowLayoutPanel1.Size = new Size(800, 66);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // NovoButton
            // 
            NovoButton.Location = new Point(33, 23);
            NovoButton.Name = "NovoButton";
            NovoButton.Size = new Size(97, 23);
            NovoButton.TabIndex = 0;
            NovoButton.Text = "Novo Cliente";
            NovoButton.UseVisualStyleBackColor = true;
            NovoButton.Click += NovoButton_Click;
            // 
            // AlterarButton
            // 
            AlterarButton.Location = new Point(136, 23);
            AlterarButton.Name = "AlterarButton";
            AlterarButton.Size = new Size(75, 23);
            AlterarButton.TabIndex = 1;
            AlterarButton.Text = "Alterar";
            AlterarButton.UseVisualStyleBackColor = true;
            AlterarButton.Click += AlterarButton_Click;
            // 
            // ExcluirButton
            // 
            ExcluirButton.Location = new Point(217, 23);
            ExcluirButton.Name = "ExcluirButton";
            ExcluirButton.Size = new Size(75, 23);
            ExcluirButton.TabIndex = 2;
            ExcluirButton.Text = "Excluir";
            ExcluirButton.UseVisualStyleBackColor = true;
            ExcluirButton.Click += ExcluirButton_Click;
            // 
            // SairButton
            // 
            SairButton.Location = new Point(298, 23);
            SairButton.Name = "SairButton";
            SairButton.Size = new Size(75, 23);
            SairButton.TabIndex = 3;
            SairButton.Text = "Sair";
            SairButton.UseVisualStyleBackColor = true;
            SairButton.Click += SairButton_Click;
            // 
            // ConfirmarInclusaoButton
            // 
            ConfirmarInclusaoButton.Location = new Point(379, 23);
            ConfirmarInclusaoButton.Name = "ConfirmarInclusaoButton";
            ConfirmarInclusaoButton.Size = new Size(75, 23);
            ConfirmarInclusaoButton.TabIndex = 4;
            ConfirmarInclusaoButton.Text = "Gravar";
            ConfirmarInclusaoButton.UseVisualStyleBackColor = true;
            ConfirmarInclusaoButton.Click += ConfirmarInclusaoButton_Click;
            // 
            // confirmarAlterarButton
            // 
            confirmarAlterarButton.Location = new Point(460, 23);
            confirmarAlterarButton.Name = "confirmarAlterarButton";
            confirmarAlterarButton.Size = new Size(75, 23);
            confirmarAlterarButton.TabIndex = 5;
            confirmarAlterarButton.Text = "Alterar";
            confirmarAlterarButton.UseVisualStyleBackColor = true;
            confirmarAlterarButton.Click += confirmarAlterarButton_Click;
            // 
            // ConfirmarExcluirButton
            // 
            ConfirmarExcluirButton.Location = new Point(541, 23);
            ConfirmarExcluirButton.Name = "ConfirmarExcluirButton";
            ConfirmarExcluirButton.Size = new Size(157, 23);
            ConfirmarExcluirButton.TabIndex = 6;
            ConfirmarExcluirButton.Text = "Confirmar Exclusão";
            ConfirmarExcluirButton.UseVisualStyleBackColor = true;
            ConfirmarExcluirButton.Click += ConfirmarExcluirButton_Click;
            // 
            // VoltarButton
            // 
            VoltarButton.Location = new Point(704, 23);
            VoltarButton.Name = "VoltarButton";
            VoltarButton.Size = new Size(75, 23);
            VoltarButton.TabIndex = 7;
            VoltarButton.Text = "Voltar";
            VoltarButton.UseVisualStyleBackColor = true;
            VoltarButton.Click += VoltarButton_Click;
            // 
            // ConteudoPanel
            // 
            ConteudoPanel.Controls.Add(FichaPanel);
            ConteudoPanel.Controls.Add(listaDataGridView);
            ConteudoPanel.Dock = DockStyle.Fill;
            ConteudoPanel.Location = new Point(0, 0);
            ConteudoPanel.Name = "ConteudoPanel";
            ConteudoPanel.Padding = new Padding(10);
            ConteudoPanel.Size = new Size(800, 384);
            ConteudoPanel.TabIndex = 1;
            // 
            // FichaPanel
            // 
            FichaPanel.Controls.Add(TelTextBox);
            FichaPanel.Controls.Add(label4);
            FichaPanel.Controls.Add(EmailTextBox);
            FichaPanel.Controls.Add(label3);
            FichaPanel.Controls.Add(NameTextBox);
            FichaPanel.Controls.Add(NomeLabel);
            FichaPanel.Controls.Add(IDtextBox);
            FichaPanel.Controls.Add(IDlabel);
            FichaPanel.Location = new Point(31, 28);
            FichaPanel.Name = "FichaPanel";
            FichaPanel.Size = new Size(353, 319);
            FichaPanel.TabIndex = 1;
            // 
            // TelTextBox
            // 
            TelTextBox.Location = new Point(113, 136);
            TelTextBox.Name = "TelTextBox";
            TelTextBox.Size = new Size(194, 23);
            TelTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 139);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 2;
            label4.Text = "Telefone:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(113, 98);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(194, 23);
            EmailTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 101);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 3;
            label3.Text = "E-mail:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(113, 57);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(194, 23);
            NameTextBox.TabIndex = 8;
            // 
            // NomeLabel
            // 
            NomeLabel.AutoSize = true;
            NomeLabel.Location = new Point(47, 60);
            NomeLabel.Name = "NomeLabel";
            NomeLabel.Size = new Size(43, 15);
            NomeLabel.TabIndex = 4;
            NomeLabel.Text = "Nome:";
            // 
            // IDtextBox
            // 
            IDtextBox.Location = new Point(113, 17);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new Size(194, 23);
            IDtextBox.TabIndex = 9;
            // 
            // IDlabel
            // 
            IDlabel.AutoSize = true;
            IDlabel.Location = new Point(47, 20);
            IDlabel.Name = "IDlabel";
            IDlabel.Size = new Size(18, 15);
            IDlabel.TabIndex = 5;
            IDlabel.Text = "ID";
            // 
            // listaDataGridView
            // 
            listaDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            listaDataGridView.Location = new Point(399, 28);
            listaDataGridView.Name = "listaDataGridView";
            listaDataGridView.RowTemplate.Height = 25;
            listaDataGridView.Size = new Size(388, 319);
            listaDataGridView.TabIndex = 0;
            // 
            // ClientesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ConteudoPanel);
            Controls.Add(panel1);
            Name = "ClientesForm";
            Text = "ClientesForm";
            Load += ClientesForm_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ConteudoPanel.ResumeLayout(false);
            FichaPanel.ResumeLayout(false);
            FichaPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)listaDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button NovoButton;
        private Button AlterarButton;
        private Button ExcluirButton;
        private Button SairButton;
        private Button ConfirmarInclusaoButton;
        private Button confirmarAlterarButton;
        private Button ConfirmarExcluirButton;
        private Panel ConteudoPanel;
        private Panel FichaPanel;
        private DataGridView listaDataGridView;
        private TextBox TelTextBox;
        private Label label4;
        private TextBox EmailTextBox;
        private Label label3;
        private TextBox NameTextBox;
        private Label NomeLabel;
        private TextBox IDtextBox;
        private Label IDlabel;
        private Button VoltarButton;
    }
}