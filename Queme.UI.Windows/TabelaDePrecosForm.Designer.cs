namespace Queme.UI.Windows
{
    partial class TabelaDePrecosForm
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
            cadastroPrecosPanel = new Panel();
            hvacValorTextBox = new TextBox();
            hidroValorTextBox = new TextBox();
            eletricoValorTextBox = new TextBox();
            arquiteturaValorTextBox = new TextBox();
            estruturalValorTextBox = new TextBox();
            consultoriaValorTextBox = new TextBox();
            CadastrarTabelaButton = new Button();
            HVACLabel = new Label();
            EletricoLabel = new Label();
            hidrossanitarioLabel = new Label();
            arquiteturaLabel = new Label();
            EstruturalLabel = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            moedaLabel = new Label();
            ConsultoriaLabel = new Label();
            ObsTabelaTextBox = new TextBox();
            ObsLabel = new Label();
            descricaoTabelaTextBox = new TextBox();
            nomeTabelaLabel = new Label();
            tituloCadastrolabel = new Label();
            CustosPorHoraLabel = new Label();
            cadastroPrecosPanel.SuspendLayout();
            SuspendLayout();
            // 
            // cadastroPrecosPanel
            // 
            cadastroPrecosPanel.Controls.Add(hvacValorTextBox);
            cadastroPrecosPanel.Controls.Add(hidroValorTextBox);
            cadastroPrecosPanel.Controls.Add(eletricoValorTextBox);
            cadastroPrecosPanel.Controls.Add(arquiteturaValorTextBox);
            cadastroPrecosPanel.Controls.Add(estruturalValorTextBox);
            cadastroPrecosPanel.Controls.Add(consultoriaValorTextBox);
            cadastroPrecosPanel.Controls.Add(CadastrarTabelaButton);
            cadastroPrecosPanel.Controls.Add(HVACLabel);
            cadastroPrecosPanel.Controls.Add(EletricoLabel);
            cadastroPrecosPanel.Controls.Add(hidrossanitarioLabel);
            cadastroPrecosPanel.Controls.Add(arquiteturaLabel);
            cadastroPrecosPanel.Controls.Add(EstruturalLabel);
            cadastroPrecosPanel.Controls.Add(label5);
            cadastroPrecosPanel.Controls.Add(label4);
            cadastroPrecosPanel.Controls.Add(label3);
            cadastroPrecosPanel.Controls.Add(label2);
            cadastroPrecosPanel.Controls.Add(label1);
            cadastroPrecosPanel.Controls.Add(moedaLabel);
            cadastroPrecosPanel.Controls.Add(ConsultoriaLabel);
            cadastroPrecosPanel.Controls.Add(ObsTabelaTextBox);
            cadastroPrecosPanel.Controls.Add(ObsLabel);
            cadastroPrecosPanel.Controls.Add(descricaoTabelaTextBox);
            cadastroPrecosPanel.Controls.Add(nomeTabelaLabel);
            cadastroPrecosPanel.Controls.Add(CustosPorHoraLabel);
            cadastroPrecosPanel.Controls.Add(tituloCadastrolabel);
            cadastroPrecosPanel.Location = new Point(2, 1);
            cadastroPrecosPanel.Name = "cadastroPrecosPanel";
            cadastroPrecosPanel.Size = new Size(378, 419);
            cadastroPrecosPanel.TabIndex = 0;
            // 
            // hvacValorTextBox
            // 
            hvacValorTextBox.Location = new Point(274, 304);
            hvacValorTextBox.Name = "hvacValorTextBox";
            hvacValorTextBox.Size = new Size(57, 23);
            hvacValorTextBox.TabIndex = 6;
            hvacValorTextBox.KeyPress += TxtKeyPress;
            // 
            // hidroValorTextBox
            // 
            hidroValorTextBox.Location = new Point(274, 274);
            hidroValorTextBox.Name = "hidroValorTextBox";
            hidroValorTextBox.Size = new Size(57, 23);
            hidroValorTextBox.TabIndex = 5;
            hidroValorTextBox.KeyPress += TxtKeyPress;
            // 
            // eletricoValorTextBox
            // 
            eletricoValorTextBox.Location = new Point(274, 245);
            eletricoValorTextBox.Name = "eletricoValorTextBox";
            eletricoValorTextBox.Size = new Size(57, 23);
            eletricoValorTextBox.TabIndex = 4;
            eletricoValorTextBox.KeyPress += TxtKeyPress;
            // 
            // arquiteturaValorTextBox
            // 
            arquiteturaValorTextBox.Location = new Point(274, 215);
            arquiteturaValorTextBox.Name = "arquiteturaValorTextBox";
            arquiteturaValorTextBox.Size = new Size(57, 23);
            arquiteturaValorTextBox.TabIndex = 3;
            arquiteturaValorTextBox.KeyPress += TxtKeyPress;
            // 
            // estruturalValorTextBox
            // 
            estruturalValorTextBox.Location = new Point(274, 186);
            estruturalValorTextBox.Name = "estruturalValorTextBox";
            estruturalValorTextBox.Size = new Size(57, 23);
            estruturalValorTextBox.TabIndex = 2;
            estruturalValorTextBox.KeyPress += TxtKeyPress;
            // 
            // consultoriaValorTextBox
            // 
            consultoriaValorTextBox.Location = new Point(274, 157);
            consultoriaValorTextBox.Name = "consultoriaValorTextBox";
            consultoriaValorTextBox.Size = new Size(57, 23);
            consultoriaValorTextBox.TabIndex = 1;
            consultoriaValorTextBox.TextChanged += consultoriaValorTextBox_TextChanged;
            consultoriaValorTextBox.KeyPress += TxtKeyPress;
            // 
            // CadastrarTabelaButton
            // 
            CadastrarTabelaButton.Location = new Point(145, 354);
            CadastrarTabelaButton.Name = "CadastrarTabelaButton";
            CadastrarTabelaButton.Size = new Size(89, 31);
            CadastrarTabelaButton.TabIndex = 33;
            CadastrarTabelaButton.Text = "Cadastrar";
            CadastrarTabelaButton.UseVisualStyleBackColor = true;
            CadastrarTabelaButton.Click += CadastrarTabelaButton_Click;
            // 
            // HVACLabel
            // 
            HVACLabel.AutoSize = true;
            HVACLabel.Location = new Point(50, 307);
            HVACLabel.Name = "HVACLabel";
            HVACLabel.Size = new Size(41, 15);
            HVACLabel.TabIndex = 1;
            HVACLabel.Text = "HVAC:";
            // 
            // EletricoLabel
            // 
            EletricoLabel.AutoSize = true;
            EletricoLabel.Location = new Point(50, 248);
            EletricoLabel.Name = "EletricoLabel";
            EletricoLabel.Size = new Size(49, 15);
            EletricoLabel.TabIndex = 1;
            EletricoLabel.Text = "Elétrico:";
            // 
            // hidrossanitarioLabel
            // 
            hidrossanitarioLabel.AutoSize = true;
            hidrossanitarioLabel.Location = new Point(50, 277);
            hidrossanitarioLabel.Name = "hidrossanitarioLabel";
            hidrossanitarioLabel.Size = new Size(90, 15);
            hidrossanitarioLabel.TabIndex = 1;
            hidrossanitarioLabel.Text = "Hidrossanitário:";
            // 
            // arquiteturaLabel
            // 
            arquiteturaLabel.AutoSize = true;
            arquiteturaLabel.Location = new Point(50, 218);
            arquiteturaLabel.Name = "arquiteturaLabel";
            arquiteturaLabel.Size = new Size(70, 15);
            arquiteturaLabel.TabIndex = 1;
            arquiteturaLabel.Text = "Arquiterura:";
            // 
            // EstruturalLabel
            // 
            EstruturalLabel.AutoSize = true;
            EstruturalLabel.Location = new Point(50, 189);
            EstruturalLabel.Name = "EstruturalLabel";
            EstruturalLabel.Size = new Size(60, 15);
            EstruturalLabel.TabIndex = 1;
            EstruturalLabel.Text = "Estrutural:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(242, 304);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 1;
            label5.Text = "R$ :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(242, 277);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 1;
            label4.Text = "R$ :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(242, 248);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 1;
            label3.Text = "R$ :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 218);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 1;
            label2.Text = "R$ :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 189);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 1;
            label1.Text = "R$ :";
            // 
            // moedaLabel
            // 
            moedaLabel.AutoSize = true;
            moedaLabel.Location = new Point(242, 160);
            moedaLabel.Name = "moedaLabel";
            moedaLabel.Size = new Size(26, 15);
            moedaLabel.TabIndex = 1;
            moedaLabel.Text = "R$ :";
            // 
            // ConsultoriaLabel
            // 
            ConsultoriaLabel.AutoSize = true;
            ConsultoriaLabel.Location = new Point(50, 159);
            ConsultoriaLabel.Name = "ConsultoriaLabel";
            ConsultoriaLabel.Size = new Size(71, 15);
            ConsultoriaLabel.TabIndex = 1;
            ConsultoriaLabel.Text = "Consultoria:";
            // 
            // ObsTabelaTextBox
            // 
            ObsTabelaTextBox.Location = new Point(151, 87);
            ObsTabelaTextBox.Name = "ObsTabelaTextBox";
            ObsTabelaTextBox.Size = new Size(180, 23);
            ObsTabelaTextBox.TabIndex = 30;
            // 
            // ObsLabel
            // 
            ObsLabel.AutoSize = true;
            ObsLabel.Location = new Point(50, 90);
            ObsLabel.Name = "ObsLabel";
            ObsLabel.Size = new Size(93, 15);
            ObsLabel.TabIndex = 1;
            ObsLabel.Text = "Obs. (Opcional):";
            // 
            // descricaoTabelaTextBox
            // 
            descricaoTabelaTextBox.Location = new Point(151, 58);
            descricaoTabelaTextBox.Name = "descricaoTabelaTextBox";
            descricaoTabelaTextBox.Size = new Size(180, 23);
            descricaoTabelaTextBox.TabIndex = 31;
            // 
            // nomeTabelaLabel
            // 
            nomeTabelaLabel.AutoSize = true;
            nomeTabelaLabel.Location = new Point(50, 61);
            nomeTabelaLabel.Name = "nomeTabelaLabel";
            nomeTabelaLabel.Size = new Size(95, 15);
            nomeTabelaLabel.TabIndex = 1;
            nomeTabelaLabel.Text = "Nome da Tabela:";
            // 
            // tituloCadastrolabel
            // 
            tituloCadastrolabel.AutoSize = true;
            tituloCadastrolabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tituloCadastrolabel.Location = new Point(92, 11);
            tituloCadastrolabel.Name = "tituloCadastrolabel";
            tituloCadastrolabel.Size = new Size(211, 21);
            tituloCadastrolabel.TabIndex = 0;
            tituloCadastrolabel.Text = "Cadastro de Tabela de Preços";
            // 
            // CustosPorHoraLabel
            // 
            CustosPorHoraLabel.AutoSize = true;
            CustosPorHoraLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CustosPorHoraLabel.Location = new Point(134, 123);
            CustosPorHoraLabel.Name = "CustosPorHoraLabel";
            CustosPorHoraLabel.Size = new Size(117, 20);
            CustosPorHoraLabel.TabIndex = 0;
            CustosPorHoraLabel.Text = "Custos Por Hora:";
            // 
            // TabelaDePrecosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 420);
            Controls.Add(cadastroPrecosPanel);
            Name = "TabelaDePrecosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TabelaDePrecosForm";
            Load += TabelaDePrecosForm_Load;
            cadastroPrecosPanel.ResumeLayout(false);
            cadastroPrecosPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel cadastroPrecosPanel;
        private Label nomeTabelaLabel;
        private Label tituloCadastrolabel;
        private Label ConsultoriaLabel;
        private TextBox descricaoTabelaTextBox;
        private Label HVACLabel;
        private Label EletricoLabel;
        private Label hidrossanitarioLabel;
        private Label arquiteturaLabel;
        private Label EstruturalLabel;
        private TextBox consultoriaValorTextBox;
        private TextBox estruturalValorTextBox;
        private TextBox arquiteturaValorTextBox;
        private TextBox eletricoValorTextBox;
        private TextBox hidroValorTextBox;
        private TextBox hvacValorTextBox;
        private Button CadastrarTabelaButton;
        private TextBox ObsTabelaTextBox;
        private Label ObsLabel;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label moedaLabel;
        private Label CustosPorHoraLabel;
    }
}