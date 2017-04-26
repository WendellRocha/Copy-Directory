namespace Backup {
    partial class Form1 {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.abrirCaminho = new System.Windows.Forms.Button();
            this.abrirDestino = new System.Windows.Forms.Button();
            this.caminhoDoArquivo = new System.Windows.Forms.TextBox();
            this.destinoDoArquivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.selecionarCaminho = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.iniciarBackup = new System.Windows.Forms.Button();
            this.selecionarDestino = new System.Windows.Forms.FolderBrowserDialog();
            this.retorno = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // abrirCaminho
            // 
            this.abrirCaminho.Location = new System.Drawing.Point(357, 40);
            this.abrirCaminho.Name = "abrirCaminho";
            this.abrirCaminho.Size = new System.Drawing.Size(75, 23);
            this.abrirCaminho.TabIndex = 3;
            this.abrirCaminho.Text = "Abrir";
            this.abrirCaminho.UseVisualStyleBackColor = true;
            this.abrirCaminho.Click += new System.EventHandler(this.abrirCaminho_Click);
            // 
            // abrirDestino
            // 
            this.abrirDestino.Location = new System.Drawing.Point(357, 85);
            this.abrirDestino.Name = "abrirDestino";
            this.abrirDestino.Size = new System.Drawing.Size(75, 23);
            this.abrirDestino.TabIndex = 4;
            this.abrirDestino.Text = "Abrir";
            this.abrirDestino.UseVisualStyleBackColor = true;
            this.abrirDestino.Click += new System.EventHandler(this.abrirDestino_Click);
            // 
            // caminhoDoArquivo
            // 
            this.caminhoDoArquivo.Location = new System.Drawing.Point(12, 42);
            this.caminhoDoArquivo.Name = "caminhoDoArquivo";
            this.caminhoDoArquivo.Size = new System.Drawing.Size(307, 20);
            this.caminhoDoArquivo.TabIndex = 5;
            // 
            // destinoDoArquivo
            // 
            this.destinoDoArquivo.Location = new System.Drawing.Point(12, 85);
            this.destinoDoArquivo.Name = "destinoDoArquivo";
            this.destinoDoArquivo.Size = new System.Drawing.Size(307, 20);
            this.destinoDoArquivo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Destino do backup";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Caminho da pasta";
            // 
            // iniciarBackup
            // 
            this.iniciarBackup.Location = new System.Drawing.Point(357, 127);
            this.iniciarBackup.Name = "iniciarBackup";
            this.iniciarBackup.Size = new System.Drawing.Size(75, 23);
            this.iniciarBackup.TabIndex = 10;
            this.iniciarBackup.Text = "Iniciar";
            this.iniciarBackup.UseVisualStyleBackColor = true;
            this.iniciarBackup.Click += new System.EventHandler(this.iniciarBackup_Click);
            // 
            // retorno
            // 
            this.retorno.AutoSize = true;
            this.retorno.Location = new System.Drawing.Point(12, 157);
            this.retorno.Name = "retorno";
            this.retorno.Size = new System.Drawing.Size(0, 13);
            this.retorno.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 179);
            this.Controls.Add(this.retorno);
            this.Controls.Add(this.iniciarBackup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.destinoDoArquivo);
            this.Controls.Add(this.caminhoDoArquivo);
            this.Controls.Add(this.abrirDestino);
            this.Controls.Add(this.abrirCaminho);
            this.Name = "Form1";
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button abrirCaminho;
        private System.Windows.Forms.Button abrirDestino;
        private System.Windows.Forms.TextBox caminhoDoArquivo;
        private System.Windows.Forms.TextBox destinoDoArquivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog selecionarCaminho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button iniciarBackup;
        private System.Windows.Forms.FolderBrowserDialog selecionarDestino;
        private System.Windows.Forms.Label retorno;
    }
}

