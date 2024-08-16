namespace Queme.UI.Windows
{
    partial class DefinirDescricaoDaCondicaoDePagamento
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
            textoDescricaoLabel = new Label();
            DescricaoTextBox = new TextBox();
            SalvarBtn = new Button();
            LimparBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(LimparBtn);
            panel1.Controls.Add(SalvarBtn);
            panel1.Controls.Add(DescricaoTextBox);
            panel1.Controls.Add(textoDescricaoLabel);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 124);
            panel1.TabIndex = 0;
            // 
            // textoDescricaoLabel
            // 
            textoDescricaoLabel.AutoSize = true;
            textoDescricaoLabel.Location = new Point(15, 10);
            textoDescricaoLabel.Name = "textoDescricaoLabel";
            textoDescricaoLabel.Size = new Size(278, 15);
            textoDescricaoLabel.TabIndex = 0;
            textoDescricaoLabel.Text = "Digite uma breve descrição da Condição/Proposta: ";
            // 
            // DescricaoTextBox
            // 
            DescricaoTextBox.Location = new Point(15, 37);
            DescricaoTextBox.Multiline = true;
            DescricaoTextBox.Name = "DescricaoTextBox";
            DescricaoTextBox.Size = new Size(479, 39);
            DescricaoTextBox.TabIndex = 1;
            // 
            // SalvarBtn
            // 
            SalvarBtn.BackColor = Color.FromArgb(192, 255, 192);
            SalvarBtn.Location = new Point(15, 86);
            SalvarBtn.Name = "SalvarBtn";
            SalvarBtn.Size = new Size(75, 23);
            SalvarBtn.TabIndex = 2;
            SalvarBtn.Text = "Salvar";
            SalvarBtn.UseVisualStyleBackColor = false;
            // 
            // LimparBtn
            // 
            LimparBtn.Location = new Point(107, 86);
            LimparBtn.Name = "LimparBtn";
            LimparBtn.Size = new Size(98, 23);
            LimparBtn.TabIndex = 2;
            LimparBtn.Text = "Limpar Texto";
            LimparBtn.UseVisualStyleBackColor = true;
            // 
            // DefinirDescricaoDaCondicaoDePagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 151);
            Controls.Add(panel1);
            Name = "DefinirDescricaoDaCondicaoDePagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DefinirDescricaoDaCondicaoDePagamento";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button LimparBtn;
        private Button SalvarBtn;
        private TextBox DescricaoTextBox;
        private Label textoDescricaoLabel;
    }
}