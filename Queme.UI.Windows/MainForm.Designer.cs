namespace Queme.UI.Windows
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            arquivosToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            fornecedoresToolStripMenuItem = new ToolStripMenuItem();
            serviçosToolStripMenuItem = new ToolStripMenuItem();
            orçamentosToolStripMenuItem = new ToolStripMenuItem();
            TesteBDBtn = new Button();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { arquivosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            arquivosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, fornecedoresToolStripMenuItem, serviçosToolStripMenuItem, orçamentosToolStripMenuItem });
            arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            arquivosToolStripMenuItem.Size = new Size(66, 20);
            arquivosToolStripMenuItem.Text = "Arquivos";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(145, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(145, 22);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // serviçosToolStripMenuItem
            // 
            serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            serviçosToolStripMenuItem.Size = new Size(145, 22);
            serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // orçamentosToolStripMenuItem
            // 
            orçamentosToolStripMenuItem.Name = "orçamentosToolStripMenuItem";
            orçamentosToolStripMenuItem.Size = new Size(145, 22);
            orçamentosToolStripMenuItem.Text = "Orçamentos";
            // 
            // TesteBDBtn
            // 
            TesteBDBtn.Location = new Point(255, 119);
            TesteBDBtn.Name = "TesteBDBtn";
            TesteBDBtn.Size = new Size(138, 23);
            TesteBDBtn.TabIndex = 1;
            TesteBDBtn.Text = "Teste Banco de dados";
            TesteBDBtn.UseVisualStyleBackColor = true;
            TesteBDBtn.Click += TesteBDBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 173);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(TesteBDBtn);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "Form1";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem arquivosToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem fornecedoresToolStripMenuItem;
        private ToolStripMenuItem serviçosToolStripMenuItem;
        private ToolStripMenuItem orçamentosToolStripMenuItem;
        private Button TesteBDBtn;
        private Label label1;
    }
}