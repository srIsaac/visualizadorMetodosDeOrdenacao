using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace PraticaOrdenacao {
    public partial class FormOrdenacao : Form {
        int[] vet = new int[500]; // vetor interno para a animação

        public FormOrdenacao() {
            InitializeComponent();
            panel.Paint += new PaintEventHandler(panel_Paint);
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel, new object[] { true });
        }

        private void panel_Paint(object sender, PaintEventArgs e) {
            for (int i = 0; i < vet.Length; i++) {
                e.Graphics.DrawLine(System.Drawing.Pens.Red, i, 299, i, 299 - vet[i]);
            }
        }

        private void bolhaToolStripMenuItem_Click(object sender, EventArgs e) {
            iniciaAnimacao(() => OrdenacaoGrafica.Bolha(vet, panel));
        }

        // TODO: animação e estatísticas dos demais métodos de ordenação

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show(this, 
                "Métodos de Ordenação - 2018/1\n\nDesenvolvido por:\n71800778 - GABRIEL DIAS PEREIRA\nProf. Virgílio Borges de Oliveira\n\nAlgoritmos e Estruturas de Dados\nFaculdade COTEMIG\nSomente para fins didáticos.", 
                "Sobre o trabalho...", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void iniciaAnimacao(Action a) {
          if (bgw.IsBusy != true) {

                if (radioButton2.Checked)
                {
                    Preenchimento.Aleatorio(vet, 299);
                }
                else if (radioButton1.Checked)
                {
                    Preenchimento.Crescente(vet, 299);
                }
                else
                {
                    Preenchimento.Decrescente(vet, 299);
                }
                bgw.RunWorkerAsync(a);
            }
            else
            {
                MessageBox.Show(this,
                   "Aguarde o fim da execução atual...",
                   "Métodos de Ordenação - 2018/1",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Exclamation);
            }
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e) {
            Action a = (Action)e.Argument;
            a();
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            MessageBox.Show(this,
               "Animação concluída!",
               "Métodos de Ordenação - 2018/1",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        private void bolhaToolStripMenuItem1_Click_1(object sender, EventArgs e) {

            int tam = int.Parse(cbxvet.Text);
            string ordem = "";
            int[] vetor = new int[tam]; // TODO
           // OrdenacaoEstatistica.contc;
            if (radioButton2.Checked)
            {
                Preenchimento.Aleatorio(vetor, tam);
                ordem = "Aleatorio";
            }
            else if (radioButton1.Checked)
            {
                Preenchimento.Crescente(vetor, tam);
                ordem = "Crescente";
            }
            else
            {
                Preenchimento.Decrescente(vetor, tam);
                ordem = "Decrescente";
            }

           // Preenchimento.Aleatorio(vetor, 1000); // TODO

            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.Bolha(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tam +
                  "\nOrdenação inicial: " + ordem + 
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " +OrdenacaoEstatistica.cc+
                  "\nNº de trocas: " +OrdenacaoEstatistica.ct,
                  "Estatísticas do Método Bolha",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }

        private void seleçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.selecao(vet, panel));
        }

        private void inserçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.insercao(vet, panel));
        }

        private void shellSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.shellSort(vet, panel));
        }
        private void heapSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaAnimacao(() => OrdenacaoGrafica.heapSort(vet, panel));
        }

        private void quickSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
           iniciaAnimacao(() => OrdenacaoGrafica.quickSort(vet, 0, vet.Length-1, panel));
        }


        private void mergeSortToolStripMenuItem_Click(object sender, EventArgs e)
        {
           iniciaAnimacao(() => OrdenacaoGrafica.mergeSort(vet,2,3, panel));
        }

        private void seleçãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int tam = int.Parse(cbxvet.Text);
            string ordem = "";
            int[] vetor = new int[tam]; // TODO
                                        // OrdenacaoEstatistica.contc;
            if (radioButton2.Checked)
            {
                Preenchimento.Aleatorio(vetor, tam);
                ordem = "Aleatorio";
            }
            else if (radioButton1.Checked)
            {
                Preenchimento.Crescente(vetor, tam);
                ordem = "Crescente";
            }
            else
            {
                Preenchimento.Decrescente(vetor, tam);
                ordem = "Decrescente";
            }

            // Preenchimento.Aleatorio(vetor, 1000); // TODO

            var stopwatch = new Stopwatch();
            stopwatch.Start(); // inicia cronômetro
            OrdenacaoEstatistica.Bolha(vetor);
            stopwatch.Stop(); // interrompe cronômetro
            long elapsed_time = stopwatch.ElapsedMilliseconds; // calcula o tempo decorrido
            MessageBox.Show(this,
                  "Tamanho do vetor: " + tam +
                  "\nOrdenação inicial: " + ordem +
                  "\n\nTempo de execução: " + String.Format("{0:F4} seg", elapsed_time / 1000.0) +
                  "\nNº de comparações: " + OrdenacaoEstatistica.cc +
                  "\nNº de trocas: " + OrdenacaoEstatistica.ct,
                  "Estatísticas do Método Seleção",
                  MessageBoxButtons.OK,
                  MessageBoxIcon.Information);
        }
    }
}
