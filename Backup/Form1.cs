using System;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.ComponentModel;
using Microsoft.VisualBasic.FileIO;

namespace Backup {
    public partial class Form1 : Form {

        string caminho;
        string destino;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            progressBar1.Enabled = false;
        }

        private void abrirCaminho_Click(object sender, EventArgs e) {
            selecionarCaminho.Description = "Selecione a pasta para backup";
            DialogResult dr = this.selecionarCaminho.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK) {
                caminho = @selecionarCaminho.SelectedPath;
                caminhoDoArquivo.Text = caminho;
            }
        }

        private void abrirDestino_Click(object sender, EventArgs e) {
            selecionarDestino.Description = "Selecione o destino do backup";
            DialogResult dr = this.selecionarDestino.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK) {
                destino = @selecionarDestino.SelectedPath;
                destinoDoArquivo.Text = destino;
            }
        }

        private void iniciarBackup_Click(object sender, EventArgs e) {
            progressBar1.Enabled = true;
            iniciarBackup.Enabled = false;
            retorno.Text = "Processando...";
            backgroundWorker1.RunWorkerAsync();
            //CopyDirectory(caminho, destino, true);
            //FileSystem.CopyDirectory(caminho, destino, UIOption.AllDialogs);
        }

        private void CopyDirectory(string source, string dest, bool copySubsDirs) {
            var dir = new DirectoryInfo(source);
            var dirs = dir.GetDirectories();
            var files = dir.GetFiles();
            int progress = 0;
            int numberOfItens = dirs.Length + files.Length; 

            if (!dir.Exists) {
                retorno.Text = "O diretório não existe ou não pôde ser encontrado: " + source;
            }

            if (!Directory.Exists(dest)) {
                Directory.CreateDirectory(dest);
            }

            foreach (var file in files) {
                var tempPath = Path.Combine(dest, file.Name);
                file.CopyTo(tempPath, true);
                progress++;
                this.backgroundWorker1.ReportProgress(100 * progress / numberOfItens);
            }

            if (!copySubsDirs) {
                return;
            }

            foreach (var subdir in dirs) {
                var tempPath = Path.Combine(dest, subdir.Name);
                CopyDirectory(subdir.Name, tempPath, true);
                progress++;
                this.backgroundWorker1.ReportProgress(100 * progress / numberOfItens);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            CopyDirectory(caminho, destino, true);

            if(backgroundWorker1.CancellationPending) {
                e.Cancel = true;
                backgroundWorker1.ReportProgress(0);
                return;
            }

            backgroundWorker1.ReportProgress(100);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            progressBar1.Value = e.ProgressPercentage;
            report.Text = e.ProgressPercentage.ToString() + "%";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (e.Error != null) {
                retorno.Text = "Aconteceu algum erro durante a execução do processo.";
            } else {
                retorno.Text = "Cópia concluída";
            }

            iniciarBackup.Enabled = true;
        }
    }
}
