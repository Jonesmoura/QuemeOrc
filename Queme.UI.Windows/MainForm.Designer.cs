﻿namespace Queme.UI.Windows
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
            novoOrçamentoToolStripMenuItem = new ToolStripMenuItem();
            carregarOrçamentoToolStripMenuItem = new ToolStripMenuItem();
            tabelasDePreçosToolStripMenuItem = new ToolStripMenuItem();
            VersaoLabel = new Label();
            QuemeLogoPictureBox = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)QuemeLogoPictureBox).BeginInit();
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
            clientesToolStripMenuItem.Size = new Size(180, 22);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // fornecedoresToolStripMenuItem
            // 
            fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            fornecedoresToolStripMenuItem.Size = new Size(180, 22);
            fornecedoresToolStripMenuItem.Text = "Fornecedores";
            // 
            // serviçosToolStripMenuItem
            // 
            serviçosToolStripMenuItem.Name = "serviçosToolStripMenuItem";
            serviçosToolStripMenuItem.Size = new Size(180, 22);
            serviçosToolStripMenuItem.Text = "Serviços";
            // 
            // orçamentosToolStripMenuItem
            // 
            orçamentosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { novoOrçamentoToolStripMenuItem, carregarOrçamentoToolStripMenuItem, tabelasDePreçosToolStripMenuItem });
            orçamentosToolStripMenuItem.Name = "orçamentosToolStripMenuItem";
            orçamentosToolStripMenuItem.Size = new Size(180, 22);
            orçamentosToolStripMenuItem.Text = "Orçamentos";
            // 
            // novoOrçamentoToolStripMenuItem
            // 
            novoOrçamentoToolStripMenuItem.Name = "novoOrçamentoToolStripMenuItem";
            novoOrçamentoToolStripMenuItem.Size = new Size(177, 22);
            novoOrçamentoToolStripMenuItem.Text = "Novo Orçamento";
            novoOrçamentoToolStripMenuItem.Click += novoOrçamentoToolStripMenuItem_Click;
            // 
            // carregarOrçamentoToolStripMenuItem
            // 
            carregarOrçamentoToolStripMenuItem.Name = "carregarOrçamentoToolStripMenuItem";
            carregarOrçamentoToolStripMenuItem.Size = new Size(177, 22);
            carregarOrçamentoToolStripMenuItem.Text = "Buscar Orçamentos";
            carregarOrçamentoToolStripMenuItem.Click += carregarOrçamentoToolStripMenuItem_Click;
            // 
            // tabelasDePreçosToolStripMenuItem
            // 
            tabelasDePreçosToolStripMenuItem.Name = "tabelasDePreçosToolStripMenuItem";
            tabelasDePreçosToolStripMenuItem.Size = new Size(177, 22);
            tabelasDePreçosToolStripMenuItem.Text = "Tabelas De Preços";
            tabelasDePreçosToolStripMenuItem.Click += tabelasDePreçosToolStripMenuItem_Click;
            // 
            // VersaoLabel
            // 
            VersaoLabel.AutoSize = true;
            VersaoLabel.Location = new Point(707, 435);
            VersaoLabel.Name = "VersaoLabel";
            VersaoLabel.Size = new Size(93, 15);
            VersaoLabel.TabIndex = 1;
            VersaoLabel.Text = "Versão 0.1 (Beta)";
            // 
            // QuemeLogoPictureBox
            // 
            QuemeLogoPictureBox.Image = Properties.Resources.LOGO_QUEME;
            QuemeLogoPictureBox.Location = new Point(255, 68);
            QuemeLogoPictureBox.Name = "QuemeLogoPictureBox";
            QuemeLogoPictureBox.Size = new Size(325, 287);
            QuemeLogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            QuemeLogoPictureBox.TabIndex = 2;
            QuemeLogoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(QuemeLogoPictureBox);
            Controls.Add(VersaoLabel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)QuemeLogoPictureBox).EndInit();
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
        private ToolStripMenuItem novoOrçamentoToolStripMenuItem;
        private Label VersaoLabel;
        private PictureBox QuemeLogoPictureBox;
        private ToolStripMenuItem tabelasDePreçosToolStripMenuItem;
        private ToolStripMenuItem carregarOrçamentoToolStripMenuItem;
    }
}