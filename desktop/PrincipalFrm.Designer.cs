﻿namespace Festival.desktop
{
    partial class PrincipalFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.eventoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastrarEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListarEvento = new System.Windows.Forms.ToolStripMenuItem();
            this.cayegoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastrarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListarCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.juriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastrarJurado = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListarJurado = new System.Windows.Forms.ToolStripMenuItem();
            this.cantoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastrarCantor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListarCantor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirFichasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atribuirNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testarListaDinamicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 24);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventoToolStripMenuItem,
            this.cayegoriaToolStripMenuItem,
            this.juriToolStripMenuItem,
            this.cantoresToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.notasToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // eventoToolStripMenuItem
            // 
            this.eventoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastrarEvento,
            this.mnuListarEvento});
            this.eventoToolStripMenuItem.Name = "eventoToolStripMenuItem";
            this.eventoToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.eventoToolStripMenuItem.Text = "Evento";
            // 
            // mnuCadastrarEvento
            // 
            this.mnuCadastrarEvento.Name = "mnuCadastrarEvento";
            this.mnuCadastrarEvento.Size = new System.Drawing.Size(124, 22);
            this.mnuCadastrarEvento.Text = "Cadastrar";
            this.mnuCadastrarEvento.Click += new System.EventHandler(this.cadastrarToolStripMenuItem_Click);
            // 
            // mnuListarEvento
            // 
            this.mnuListarEvento.Name = "mnuListarEvento";
            this.mnuListarEvento.Size = new System.Drawing.Size(124, 22);
            this.mnuListarEvento.Text = "Listar";
            this.mnuListarEvento.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // cayegoriaToolStripMenuItem
            // 
            this.cayegoriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastrarCategoria,
            this.mnuListarCategoria});
            this.cayegoriaToolStripMenuItem.Name = "cayegoriaToolStripMenuItem";
            this.cayegoriaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.cayegoriaToolStripMenuItem.Text = "Categoria";
            // 
            // mnuCadastrarCategoria
            // 
            this.mnuCadastrarCategoria.Name = "mnuCadastrarCategoria";
            this.mnuCadastrarCategoria.Size = new System.Drawing.Size(124, 22);
            this.mnuCadastrarCategoria.Text = "Cadastrar";
            this.mnuCadastrarCategoria.Click += new System.EventHandler(this.cadastrarToolStripMenuItem1_Click);
            // 
            // mnuListarCategoria
            // 
            this.mnuListarCategoria.Name = "mnuListarCategoria";
            this.mnuListarCategoria.Size = new System.Drawing.Size(124, 22);
            this.mnuListarCategoria.Text = "Listar";
            this.mnuListarCategoria.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // juriToolStripMenuItem
            // 
            this.juriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastrarJurado,
            this.mnuListarJurado});
            this.juriToolStripMenuItem.Name = "juriToolStripMenuItem";
            this.juriToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.juriToolStripMenuItem.Text = "Juri";
            // 
            // mnuCadastrarJurado
            // 
            this.mnuCadastrarJurado.Name = "mnuCadastrarJurado";
            this.mnuCadastrarJurado.Size = new System.Drawing.Size(124, 22);
            this.mnuCadastrarJurado.Text = "Cadastrar";
            this.mnuCadastrarJurado.Click += new System.EventHandler(this.mnuCadastrarJurado_Click);
            // 
            // mnuListarJurado
            // 
            this.mnuListarJurado.Name = "mnuListarJurado";
            this.mnuListarJurado.Size = new System.Drawing.Size(124, 22);
            this.mnuListarJurado.Text = "Listar";
            this.mnuListarJurado.Click += new System.EventHandler(this.mnuListarJurado_Click);
            // 
            // cantoresToolStripMenuItem
            // 
            this.cantoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCadastrarCantor,
            this.mnuListarCantor});
            this.cantoresToolStripMenuItem.Name = "cantoresToolStripMenuItem";
            this.cantoresToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cantoresToolStripMenuItem.Text = "Cantores";
            // 
            // mnuCadastrarCantor
            // 
            this.mnuCadastrarCantor.Name = "mnuCadastrarCantor";
            this.mnuCadastrarCantor.Size = new System.Drawing.Size(124, 22);
            this.mnuCadastrarCantor.Text = "Cadastrar";
            this.mnuCadastrarCantor.Click += new System.EventHandler(this.mnuCadastrarCantor_Click);
            // 
            // mnuListarCantor
            // 
            this.mnuListarCantor.Name = "mnuListarCantor";
            this.mnuListarCantor.Size = new System.Drawing.Size(124, 22);
            this.mnuListarCantor.Text = "Listar";
            this.mnuListarCantor.Click += new System.EventHandler(this.mnuListarCantor_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem1.Text = ".";
            this.toolStripMenuItem1.Visible = false;
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem2.Text = ".";
            this.toolStripMenuItem2.Visible = false;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem3.Text = ".";
            this.toolStripMenuItem3.Visible = false;
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem4.Text = ".";
            this.toolStripMenuItem4.Visible = false;
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem5.Text = ".";
            this.toolStripMenuItem5.Visible = false;
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem6.Text = ".";
            this.toolStripMenuItem6.Visible = false;
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(22, 20);
            this.toolStripMenuItem7.Text = ".";
            this.toolStripMenuItem7.Visible = false;
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imprimirFichasToolStripMenuItem,
            this.atribuirNotasToolStripMenuItem,
            this.testarListaDinamicaToolStripMenuItem});
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // imprimirFichasToolStripMenuItem
            // 
            this.imprimirFichasToolStripMenuItem.Name = "imprimirFichasToolStripMenuItem";
            this.imprimirFichasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.imprimirFichasToolStripMenuItem.Text = "Imprimir Fichas";
            // 
            // atribuirNotasToolStripMenuItem
            // 
            this.atribuirNotasToolStripMenuItem.Name = "atribuirNotasToolStripMenuItem";
            this.atribuirNotasToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.atribuirNotasToolStripMenuItem.Text = "Atribuir Notas";
            this.atribuirNotasToolStripMenuItem.Click += new System.EventHandler(this.atribuirNotasToolStripMenuItem_Click);
            // 
            // testarListaDinamicaToolStripMenuItem
            // 
            this.testarListaDinamicaToolStripMenuItem.Name = "testarListaDinamicaToolStripMenuItem";
            this.testarListaDinamicaToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.testarListaDinamicaToolStripMenuItem.Text = "Testar Lista Dinamica";
            this.testarListaDinamicaToolStripMenuItem.Click += new System.EventHandler(this.testarListaDinamicaToolStripMenuItem_Click);
            // 
            // PrincipalFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Festival.Properties.Resources.fundomusicaacordes;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalFrm";
            this.Text = "Festival ";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem eventoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastrarEvento;
        private System.Windows.Forms.ToolStripMenuItem mnuListarEvento;
        private System.Windows.Forms.ToolStripMenuItem cayegoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastrarCategoria;
        private System.Windows.Forms.ToolStripMenuItem mnuListarCategoria;
        private System.Windows.Forms.ToolStripMenuItem juriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastrarJurado;
        private System.Windows.Forms.ToolStripMenuItem mnuListarJurado;
        private System.Windows.Forms.ToolStripMenuItem cantoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastrarCantor;
        private System.Windows.Forms.ToolStripMenuItem mnuListarCantor;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirFichasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atribuirNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testarListaDinamicaToolStripMenuItem;
    }
}