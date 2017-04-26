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
                FileSystem.CopyDirectory(caminho, destino, UIOption.AllDialogs);
                retorno.Text = "Cópia concluída";
                iniciarBackup.Enabled = true;
            } catch (System.OperationCanceledException ocEx) {
                retorno.Text = ocEx.Message;
                iniciarBackup.Enabled = true;
            }
        }
    }
}
