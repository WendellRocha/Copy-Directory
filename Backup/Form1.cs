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
            try {
                iniciarBackup.Enabled = false;
                retorno.Text = "Processando...";
                CopyDirectory(caminho, destino, true);
                //FileSystem.CopyDirectory(caminho, destino, UIOption.AllDialogs);
                retorno.Text = "Cópia concluída";
                iniciarBackup.Enabled = true;
            } catch (System.OperationCanceledException ocEx) {
                retorno.Text = ocEx.Message;
                iniciarBackup.Enabled = true;
            }
        }

        private void CopyDirectory(string source, string dest, bool copySubsDirs) {
            var dir = new DirectoryInfo(source);
            var dirs = dir.GetDirectories();

            if (!dir.Exists)
                retorno.Text = "O diretório não existe ou não pôde ser encontrado: " + source;

            if (!Directory.Exists(dest))
                Directory.CreateDirectory(dest);

            var files = dir.GetFiles();

            foreach (var file in files) {
                var tempPath = Path.Combine(dest, file.Name);
                file.CopyTo(tempPath, true);
            }

            if (!copySubsDirs)
                return;

            foreach (var subdir in dirs) {
                var tempPath = Path.Combine(dest, subdir.Name);
                CopyDirectory(subdir.Name, tempPath, true);

            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {

        }
    }
}
