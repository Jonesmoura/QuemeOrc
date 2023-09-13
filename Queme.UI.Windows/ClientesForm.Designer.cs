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
            flowLayoutPanel2 = new FlowLayoutPanel();
            IDPanel = new Panel();
            IDtextBox = new TextBox();
            IDlabel = new Label();
            NamePanel = new Panel();
            NameTextBox = new TextBox();
            NomeLabel = new Label();
            RazaoSocialPanel = new Panel();
            RazaoSocialTextBox = new TextBox();
            RazaoSocialLabel = new Label();
            CNPJPanel = new Panel();
            CNPJtextBox = new TextBox();
            CNPJlabel = new Label();
            CPFPanel = new Panel();
            CPFtextBox = new TextBox();
            CPFlabel = new Label();
            EmailPanel = new Panel();
            EmailTextBox = new TextBox();
            label3 = new Label();
            TelPanel = new Panel();
            TelTextBox = new TextBox();
            label4 = new Label();
            PFradioButton = new RadioButton();
            PJradioButton = new RadioButton();
            listaDataGridView = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ConteudoPanel.SuspendLayout();
            FichaPanel.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            IDPanel.SuspendLayout();
            NamePanel.SuspendLayout();
            RazaoSocialPanel.SuspendLayout();
            CNPJPanel.SuspendLayout();
            CPFPanel.SuspendLayout();
            EmailPanel.SuspendLayout();
            TelPanel.SuspendLayout();
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
            FichaPanel.Controls.Add(flowLayoutPanel2);
            FichaPanel.Controls.Add(PFradioButton);
            FichaPanel.Controls.Add(PJradioButton);
            FichaPanel.Location = new Point(13, 28);
            FichaPanel.Name = "FichaPanel";
            FichaPanel.Size = new Size(380, 350);
            FichaPanel.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(IDPanel);
            flowLayoutPanel2.Controls.Add(NamePanel);
            flowLayoutPanel2.Controls.Add(RazaoSocialPanel);
            flowLayoutPanel2.Controls.Add(CNPJPanel);
            flowLayoutPanel2.Controls.Add(CPFPanel);
            flowLayoutPanel2.Controls.Add(EmailPanel);
            flowLayoutPanel2.Controls.Add(TelPanel);
            flowLayoutPanel2.Dock = DockStyle.Bottom;
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(0, 47);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(40, 0, 40, 0);
            flowLayoutPanel2.Size = new Size(380, 303);
            flowLayoutPanel2.TabIndex = 1;
            // 
            // IDPanel
            // 
            IDPanel.Controls.Add(IDtextBox);
            IDPanel.Controls.Add(IDlabel);
            IDPanel.Location = new Point(43, 3);
            IDPanel.Name = "IDPanel";
            IDPanel.Size = new Size(287, 30);
            IDPanel.TabIndex = 11;
            // 
            // IDtextBox
            // 
            IDtextBox.Location = new Point(106, 5);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new Size(178, 23);
            IDtextBox.TabIndex = 9;
            // 
            // IDlabel
            // 
            IDlabel.AutoSize = true;
            IDlabel.Location = new Point(3, 8);
            IDlabel.Name = "IDlabel";
            IDlabel.Size = new Size(18, 15);
            IDlabel.TabIndex = 5;
            IDlabel.Text = "ID";
            // 
            // NamePanel
            // 
            NamePanel.Controls.Add(NameTextBox);
            NamePanel.Controls.Add(NomeLabel);
            NamePanel.Location = new Point(43, 39);
            NamePanel.Name = "NamePanel";
            NamePanel.Size = new Size(287, 30);
            NamePanel.TabIndex = 17;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(107, 4);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(179, 23);
            NameTextBox.TabIndex = 8;
            // 
            // NomeLabel
            // 
            NomeLabel.AutoSize = true;
            NomeLabel.Location = new Point(3, 7);
            NomeLabel.Name = "NomeLabel";
            NomeLabel.Size = new Size(89, 15);
            NomeLabel.TabIndex = 4;
            NomeLabel.Text = "Nome Contato:";
            // 
            // RazaoSocialPanel
            // 
            RazaoSocialPanel.Controls.Add(RazaoSocialTextBox);
            RazaoSocialPanel.Controls.Add(RazaoSocialLabel);
            RazaoSocialPanel.Location = new Point(43, 75);
            RazaoSocialPanel.Name = "RazaoSocialPanel";
            RazaoSocialPanel.Size = new Size(287, 30);
            RazaoSocialPanel.TabIndex = 13;
            // 
            // RazaoSocialTextBox
            // 
            RazaoSocialTextBox.Location = new Point(106, 3);
            RazaoSocialTextBox.Name = "RazaoSocialTextBox";
            RazaoSocialTextBox.Size = new Size(179, 23);
            RazaoSocialTextBox.TabIndex = 6;
            // 
            // RazaoSocialLabel
            // 
            RazaoSocialLabel.AutoSize = true;
            RazaoSocialLabel.Location = new Point(3, 9);
            RazaoSocialLabel.Name = "RazaoSocialLabel";
            RazaoSocialLabel.Size = new Size(75, 15);
            RazaoSocialLabel.TabIndex = 2;
            RazaoSocialLabel.Text = "Razão Social:";
            // 
            // CNPJPanel
            // 
            CNPJPanel.Controls.Add(CNPJtextBox);
            CNPJPanel.Controls.Add(CNPJlabel);
            CNPJPanel.Location = new Point(43, 111);
            CNPJPanel.Name = "CNPJPanel";
            CNPJPanel.Size = new Size(287, 30);
            CNPJPanel.TabIndex = 14;
            // 
            // CNPJtextBox
            // 
            CNPJtextBox.Location = new Point(106, 3);
            CNPJtextBox.Name = "CNPJtextBox";
            CNPJtextBox.Size = new Size(179, 23);
            CNPJtextBox.TabIndex = 6;
            // 
            // CNPJlabel
            // 
            CNPJlabel.AutoSize = true;
            CNPJlabel.Location = new Point(3, 6);
            CNPJlabel.Name = "CNPJlabel";
            CNPJlabel.Size = new Size(37, 15);
            CNPJlabel.TabIndex = 2;
            CNPJlabel.Text = "CNPJ:";
            // 
            // CPFPanel
            // 
            CPFPanel.Controls.Add(CPFtextBox);
            CPFPanel.Controls.Add(CPFlabel);
            CPFPanel.Location = new Point(43, 147);
            CPFPanel.Name = "CPFPanel";
            CPFPanel.Size = new Size(287, 30);
            CPFPanel.TabIndex = 12;
            // 
            // CPFtextBox
            // 
            CPFtextBox.Location = new Point(106, 3);
            CPFtextBox.Name = "CPFtextBox";
            CPFtextBox.Size = new Size(179, 23);
            CPFtextBox.TabIndex = 6;
            // 
            // CPFlabel
            // 
            CPFlabel.AutoSize = true;
            CPFlabel.Location = new Point(3, 8);
            CPFlabel.Name = "CPFlabel";
            CPFlabel.Size = new Size(31, 15);
            CPFlabel.TabIndex = 2;
            CPFlabel.Text = "CPF:";
            // 
            // EmailPanel
            // 
            EmailPanel.Controls.Add(EmailTextBox);
            EmailPanel.Controls.Add(label3);
            EmailPanel.Location = new Point(43, 183);
            EmailPanel.Name = "EmailPanel";
            EmailPanel.Size = new Size(287, 30);
            EmailPanel.TabIndex = 16;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(106, 4);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(179, 23);
            EmailTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 7);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 3;
            label3.Text = "E-mail:";
            // 
            // TelPanel
            // 
            TelPanel.Controls.Add(TelTextBox);
            TelPanel.Controls.Add(label4);
            TelPanel.Location = new Point(43, 219);
            TelPanel.Name = "TelPanel";
            TelPanel.Size = new Size(287, 30);
            TelPanel.TabIndex = 15;
            // 
            // TelTextBox
            // 
            TelTextBox.Location = new Point(107, 3);
            TelTextBox.Name = "TelTextBox";
            TelTextBox.Size = new Size(179, 23);
            TelTextBox.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 6);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 2;
            label4.Text = "Telefone:";
            // 
            // PFradioButton
            // 
            PFradioButton.AutoSize = true;
            PFradioButton.Location = new Point(207, 15);
            PFradioButton.Name = "PFradioButton";
            PFradioButton.Size = new Size(93, 19);
            PFradioButton.TabIndex = 10;
            PFradioButton.TabStop = true;
            PFradioButton.Text = "Pessoa Física";
            PFradioButton.UseVisualStyleBackColor = true;
            PFradioButton.CheckedChanged += PFradioButton_CheckedChanged;
            // 
            // PJradioButton
            // 
            PJradioButton.AutoSize = true;
            PJradioButton.Location = new Point(86, 15);
            PJradioButton.Name = "PJradioButton";
            PJradioButton.Size = new Size(104, 19);
            PJradioButton.TabIndex = 10;
            PJradioButton.TabStop = true;
            PJradioButton.Text = "Pessoa Jurídica";
            PJradioButton.UseVisualStyleBackColor = true;
            PJradioButton.CheckedChanged += PJradioButton_CheckedChanged;
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
            flowLayoutPanel2.ResumeLayout(false);
            IDPanel.ResumeLayout(false);
            IDPanel.PerformLayout();
            NamePanel.ResumeLayout(false);
            NamePanel.PerformLayout();
            RazaoSocialPanel.ResumeLayout(false);
            RazaoSocialPanel.PerformLayout();
            CNPJPanel.ResumeLayout(false);
            CNPJPanel.PerformLayout();
            CPFPanel.ResumeLayout(false);
            CPFPanel.PerformLayout();
            EmailPanel.ResumeLayout(false);
            EmailPanel.PerformLayout();
            TelPanel.ResumeLayout(false);
            TelPanel.PerformLayout();
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
        private Button VoltarButton;
        private RadioButton PFradioButton;
        private RadioButton PJradioButton;
        private TextBox CPFtextBox;
        private Label CPFlabel;
        private TextBox RazaoSocialTextBox;
        private TextBox CNPJtextBox;
        private Label RazaoSocialLabel;
        private Label CNPJlabel;
        private TextBox TelTextBox;
        private Label label4;
        private TextBox EmailTextBox;
        private Label label3;
        private TextBox NameTextBox;
        private Label NomeLabel;
        private TextBox IDtextBox;
        private Label IDlabel;
        private Panel CNPJPanel;
        private Panel RazaoSocialPanel;
        private Panel CPFPanel;
        private Panel IDPanel;
        private Panel NamePanel;
        private Panel EmailPanel;
        private Panel TelPanel;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}