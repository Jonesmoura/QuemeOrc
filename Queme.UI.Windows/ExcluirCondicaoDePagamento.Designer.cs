namespace Queme.UI.Windows
{
    partial class ExcluirCondicaoDePagamento
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
            condicoesDePagDataGridView = new DataGridView();
            excluirCondicaoSelecionadaButton = new Button();
            ((System.ComponentModel.ISupportInitialize)condicoesDePagDataGridView).BeginInit();
            SuspendLayout();
            // 
            // condicoesDePagDataGridView
            // 
            condicoesDePagDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            condicoesDePagDataGridView.Location = new Point(12, 12);
            condicoesDePagDataGridView.Name = "condicoesDePagDataGridView";
            condicoesDePagDataGridView.RowTemplate.Height = 25;
            condicoesDePagDataGridView.Size = new Size(776, 275);
            condicoesDePagDataGridView.TabIndex = 0;
            // 
            // excluirCondicaoSelecionadaButton
            // 
            excluirCondicaoSelecionadaButton.Location = new Point(12, 302);
            excluirCondicaoSelecionadaButton.Name = "excluirCondicaoSelecionadaButton";
            excluirCondicaoSelecionadaButton.Size = new Size(75, 23);
            excluirCondicaoSelecionadaButton.TabIndex = 1;
            excluirCondicaoSelecionadaButton.Text = "Excluir";
            excluirCondicaoSelecionadaButton.UseVisualStyleBackColor = true;
            excluirCondicaoSelecionadaButton.Click += excluirCondicaoSelecionadaButton_Click;
            // 
            // ExcluirCondicaoDePagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 343);
            Controls.Add(excluirCondicaoSelecionadaButton);
            Controls.Add(condicoesDePagDataGridView);
            Name = "ExcluirCondicaoDePagamento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ExcluirCondicaoDePagamento";
            Load += ExcluirCondicaoDePagamento_Load;
            ((System.ComponentModel.ISupportInitialize)condicoesDePagDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView condicoesDePagDataGridView;
        private Button excluirCondicaoSelecionadaButton;
    }
}