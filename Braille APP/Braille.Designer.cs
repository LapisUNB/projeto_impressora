using System;
using System.Drawing;
using System.Windows.Forms;

namespace Braille_APP
{
    partial class Braille
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gpbText = new System.Windows.Forms.GroupBox();
            this.btn_Traduzir = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errpCon = new System.Windows.Forms.ErrorProvider(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.gpbText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpCon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(687, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.salvarComoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            this.arquivoToolStripMenuItem.MouseEnter += new System.EventHandler(this.MenuItem_MouseEnter);
            this.arquivoToolStripMenuItem.MouseLeave += new System.EventHandler(this.MenuItem_MouseLeave);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarComoToolStripMenuItem
            // 
            this.salvarComoToolStripMenuItem.Name = "salvarComoToolStripMenuItem";
            this.salvarComoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.salvarComoToolStripMenuItem.Text = "Salvar Como";
            this.salvarComoToolStripMenuItem.Click += new System.EventHandler(this.salvarComoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // gpbText
            // 
            this.gpbText.BackColor = System.Drawing.Color.Transparent;
            this.gpbText.Controls.Add(this.btn_Traduzir);
            this.gpbText.Controls.Add(this.txtValue);
            this.gpbText.Controls.Add(this.label1);
            this.gpbText.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gpbText.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gpbText.Location = new System.Drawing.Point(12, 27);
            this.gpbText.Name = "gpbText";
            this.gpbText.Padding = new System.Windows.Forms.Padding(12);
            this.gpbText.Size = new System.Drawing.Size(665, 197);
            this.gpbText.TabIndex = 4;
            this.gpbText.TabStop = false;
            this.gpbText.Text = "Insira o Texto";
            // 
            // btn_Traduzir
            // 
            this.btn_Traduzir.Location = new System.Drawing.Point(531, 149);
            this.btn_Traduzir.Name = "btn_Traduzir";
            this.btn_Traduzir.Size = new System.Drawing.Size(124, 30);
            this.btn_Traduzir.TabIndex = 6;
            this.btn_Traduzir.Text = "Traduzir";
            this.btn_Traduzir.UseVisualStyleBackColor = true;
            this.btn_Traduzir.Click += new System.EventHandler(this.btn_Traduzir_Click);
            // 
            // txtValue
            // 
            this.txtValue.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValue.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.txtValue.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.txtValue.Location = new System.Drawing.Point(19, 51);
            this.txtValue.MaxLength = 750;
            this.txtValue.Multiline = true;
            this.txtValue.Name = "txtValue";
            this.txtValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtValue.Size = new System.Drawing.Size(636, 92);
            this.txtValue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Por favor, insira o valor necessário no campo:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // errpCon
            // 
            this.errpCon.ContainerControl = this;
            // 
            // Braille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 232);
            this.Controls.Add(this.gpbText);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Braille";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impressora Braille";
            this.Load += new System.EventHandler(this.Braille_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpbText.ResumeLayout(false);
            this.gpbText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errpCon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpbText;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.ErrorProvider errpCon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_Traduzir;
    }
}

