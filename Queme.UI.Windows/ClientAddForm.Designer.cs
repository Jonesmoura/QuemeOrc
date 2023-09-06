namespace Queme.UI.Windows
{
    partial class ClientAddForm
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
            IDlabel = new Label();
            IDtextBox = new TextBox();
            NomeLabel = new Label();
            NomeTextBox = new TextBox();
            label3 = new Label();
            EmailTextBox = new TextBox();
            label4 = new Label();
            TelTextBox = new TextBox();
            AddBtn = new Button();
            TurnBtn = new Button();
            SuspendLayout();
            // 
            // IDlabel
            // 
            IDlabel.AutoSize = true;
            IDlabel.Location = new Point(95, 56);
            IDlabel.Name = "IDlabel";
            IDlabel.Size = new Size(18, 15);
            IDlabel.TabIndex = 0;
            IDlabel.Text = "ID";
            // 
            // IDtextBox
            // 
            IDtextBox.Location = new Point(161, 53);
            IDtextBox.Name = "IDtextBox";
            IDtextBox.Size = new Size(194, 23);
            IDtextBox.TabIndex = 1;
            // 
            // NomeLabel
            // 
            NomeLabel.AutoSize = true;
            NomeLabel.Location = new Point(95, 96);
            NomeLabel.Name = "NomeLabel";
            NomeLabel.Size = new Size(43, 15);
            NomeLabel.TabIndex = 0;
            NomeLabel.Text = "Nome:";
            // 
            // NomeTextBox
            // 
            NomeTextBox.Location = new Point(161, 93);
            NomeTextBox.Name = "NomeTextBox";
            NomeTextBox.Size = new Size(194, 23);
            NomeTextBox.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 137);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "E-mail:";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(161, 134);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(194, 23);
            EmailTextBox.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(95, 175);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 0;
            label4.Text = "Telefone:";
            // 
            // TelTextBox
            // 
            TelTextBox.Location = new Point(161, 172);
            TelTextBox.Name = "TelTextBox";
            TelTextBox.Size = new Size(194, 23);
            TelTextBox.TabIndex = 1;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(200, 222);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "Incluir";
            AddBtn.UseVisualStyleBackColor = true;
            // 
            // TurnBtn
            // 
            TurnBtn.Location = new Point(281, 222);
            TurnBtn.Name = "TurnBtn";
            TurnBtn.Size = new Size(75, 23);
            TurnBtn.TabIndex = 2;
            TurnBtn.Text = "Voltar";
            TurnBtn.UseVisualStyleBackColor = true;
            // 
            // ClientAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 450);
            Controls.Add(TurnBtn);
            Controls.Add(AddBtn);
            Controls.Add(TelTextBox);
            Controls.Add(label4);
            Controls.Add(EmailTextBox);
            Controls.Add(label3);
            Controls.Add(NomeTextBox);
            Controls.Add(NomeLabel);
            Controls.Add(IDtextBox);
            Controls.Add(IDlabel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ClientAddForm";
            Text = "Inclusão de Cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label IDlabel;
        private TextBox IDtextBox;
        private Label NomeLabel;
        private TextBox NomeTextBox;
        private Label label3;
        private TextBox EmailTextBox;
        private Label label4;
        private TextBox TelTextBox;
        private Button AddBtn;
        private Button TurnBtn;
    }
}