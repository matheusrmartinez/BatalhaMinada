using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Interface
{
    public partial class AgoraVai : Form
    {
        private Jogo jogo = new Jogo();
        private Button[,] tabuleiro = new Button[16, 10];
        private Button voltarInstrucoes = new Button();
        private Button voltarJogo = new Button();
        private Button reiniciar = new Button();
        private GroupBox coisas = new GroupBox();
        private FlowLayoutPanel grid = new FlowLayoutPanel();
        private Label tempo = new Label();
        private Label instrucoes = new Label();
        public static Label marcados = new Label();
        public static Stopwatch relogio = new Stopwatch();
        public static Timer timer = new Timer();

        public AgoraVai()
        {
            timer.Enabled = false;
            timer.Interval = 1000;
            timer.Tick += new EventHandler(TimerTick);
            InitializeComponent();
        }

        private void JogarClick(object sender, EventArgs e)
        {
            botoes.Visible = false;

            coisas.Height = 580;
            coisas.Width = 620;

            grid.Height = 580;
            grid.Width = 370;

            tempo.SetBounds(370, 20, 200, 20);
            tempo.Font = new Font("Arial", 10);
            tempo.Text = "Tempo: 00:00";

            marcados.SetBounds(370, 40, 200, 20);
            marcados.Font = new Font("Arial", 10);
            marcados.Text = "Quantidade: 10";

            reiniciar.SetBounds(370, 60, 100, 30);
            reiniciar.Font = new Font("Arial", 10);
            reiniciar.Text = "Reiniciar";
            reiniciar.Click += new EventHandler(ReiniciarClick);

            voltarJogo.SetBounds(370, 95, 100, 30);
            voltarJogo.Font = new Font("Arial", 10);
            voltarJogo.Text = "Voltar";
            voltarJogo.Click += new EventHandler(VoltarJogoClick);
            voltarJogo.Visible = true;

            PreencheGrid();

            coisas.Controls.Add(grid);
            coisas.Controls.Add(tempo);
            coisas.Controls.Add(marcados);
            coisas.Controls.Add(reiniciar);
            coisas.Controls.Add(voltarJogo);
            this.Controls.Add(coisas);
            coisas.Visible = true;

            jogo.IniciarPartida();
        }

        private void SairClick(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ReiniciarClick(Object sender, EventArgs e)
        {
            relogio.Reset();
            timer.Stop();
            tempo.Text = "Tempo: 00:00";
            marcados.Text = "Quantidade: 24";
            coisas.Controls.Remove(grid);
            grid.Controls.Clear();
            jogo.IniciarPartida();
            PreencheGrid();
            coisas.Controls.Add(grid);
            jogo.apertouUmaVez = false;
        }

        private void PreencheGrid()
        {
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    tabuleiro[i, j] = new Button();
                    tabuleiro[i, j].MouseDown += new MouseEventHandler(ButtonClick);
                    tabuleiro[i, j].Width = 30;
                    tabuleiro[i, j].Height = 30;
                    tabuleiro[i, j].Font = new Font("Arial", 16, FontStyle.Bold);
                    tabuleiro[i, j].Enabled = true;
                    grid.Controls.Add(tabuleiro[i, j]);
                }
            }
        }

        private void ButtonClick(Object sender, MouseEventArgs e)
        {
            Button botao = (Button)sender;
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    if (tabuleiro[i, j].Equals(botao))
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            jogo.Jogar(i, j);
                            AtualizaTabuleiro();
                            if (jogo.FimJogo(i, j) && jogo.GetGanhou())
                            {
                                relogio.Stop();
                                timer.Enabled = false;
                                Gabarito();
                                MessageBox.Show("Joga demais!\nTeu tempo aí: " + relogio.Elapsed.Minutes.ToString().PadLeft(2, '0') + ":" + relogio.Elapsed.Seconds.ToString().PadLeft(2, '0'), "Ganhou");
                            }
                            else if (jogo.FimJogo(i, j) && !jogo.GetGanhou())
                            {
                                relogio.Stop();
                                timer.Enabled = false;
                                Gabarito();
                                MessageBox.Show("Perdeu, irmão!", "Perdeu");
                            }                           
                        }
                        else if (e.Button == MouseButtons.Right)
                        {
                            if (!jogo.apertouUmaVez)
                            {
                                timer.Enabled = true;
                                relogio.Start();
                                jogo.GetCampo().GeraTabuleiro(i, j);
                                jogo.apertouUmaVez = true;
                                jogo.Marcar(i, j);
                                tabuleiro[i, j].Text = "?";
                                marcados.Text = "Quantidade: " + jogo.GetCampo().GetQtdParaMarcar();
                            }
                            else
                            {
                                if (jogo.GetCampo().GetQtdParaMarcar() > 0)
                                {
                                    if (jogo.GetCampo().GetTabuleiro()[i, j].GetPodeMarcar())
                                    {
                                        jogo.Marcar(i, j);
                                        tabuleiro[i, j].Text = "?";
                                    }
                                    else if (jogo.GetCampo().GetTabuleiro()[i, j].GetSelecionado())
                                    {
                                        jogo.Marcar(i, j);
                                        tabuleiro[i, j].Text = null;
                                    }
                                }
                                else
                                {
                                    if (jogo.GetCampo().GetTabuleiro()[i, j].GetSelecionado())
                                    {
                                        jogo.Marcar(i, j);
                                        tabuleiro[i, j].Text = null;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void Gabarito()
        {
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    tabuleiro[i, j].Text = null;

                    if (jogo.GetCampo().GetTabuleiro()[i, j].GetPodeMarcar() == false)
                    {
                        if (jogo.GetCampo().GetTabuleiro()[i, j].GetSelecionado() == false)
                        {
                            if (jogo.GetCampo().GetTabuleiro()[i, j].GetBomba() == 'N')
                            {
                                tabuleiro[i, j].Text = null;
                            }
                            else if (jogo.GetCampo().GetTabuleiro()[i, j].GetTemBomba())
                            {
                                tabuleiro[i, j].Image = global::CampoMinado.Properties.Resources.bomba;
                            }
                            else if (jogo.GetCampo().GetTabuleiro()[i, j].GetValor() != 0)
                            {
                                tabuleiro[i, j].Text = jogo.GetCampo().GetTabuleiro()[i, j].GetValor().ToString();
                            }
                        }
                    }
                }
            }
        }

        private void AtualizaTabuleiro()
        {
            jogo.GetCampo().TabuleiroNormal();
            jogo.GetCampo().TabuleiroInverso();
            jogo.GetCampo().TabuleiroNormal();
            jogo.GetCampo().TabuleiroInverso();

            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    if (jogo.GetCampo().GetTabuleiro()[i, j].GetPodeMarcar() == false)
                    {
                        if (jogo.GetCampo().GetTabuleiro()[i, j].GetSelecionado() == false)
                        {
                            if (jogo.GetCampo().GetTabuleiro()[i, j].GetBomba() == 'N')
                            {
                                tabuleiro[i, j].Text = null;
                                tabuleiro[i, j].Enabled = false;
                            }
                            else if (jogo.GetCampo().GetTabuleiro()[i, j].GetValor() != 0)
                            {
                                tabuleiro[i, j].Text = jogo.GetCampo().GetTabuleiro()[i, j].GetValor().ToString();
                                tabuleiro[i, j].Enabled = false;
                            }
                        }
                        else
                        {
                            tabuleiro[i, j].Text = "?";
                        }
                    }
                }
            }
        }

        private void InformacoesClick(object sender, EventArgs e)
        {
            voltarInstrucoes.Visible = true;
            voltarInstrucoes.Font = new Font("Arial", 14);
            voltarInstrucoes.Text = "Voltar";
            voltarInstrucoes.SetBounds(300, 500, 100, 30);
            voltarInstrucoes.Click += new EventHandler(VoltarInstrucoesClick);

            botoes.Visible = false;

            instrucoes.Visible = true;
            instrucoes.Height = 330;
            instrucoes.Width = 450;
            instrucoes.Text = "\n\n\n\n\n\n\n\n\n\n 1 - Esquerdo do mouse: Revela o que tem na casa.\n 2 - Direito do mouse: Marca possível bomba.";
            instrucoes.Font = new Font("Arial", 14);

            this.Controls.Add(instrucoes);
            this.Controls.Add(voltarInstrucoes);
        }

        private void VoltarJogoClick(object sender, EventArgs e)
        {
            Button botao = (Button)sender;                       
            botoes.Visible = true;
            voltarJogo.Visible = false;
            coisas.Visible = false;
            relogio.Reset();
            timer.Stop();
            tempo.Text = "Tempo: 00:00";
            marcados.Text = "Quantidade: 24";
            coisas.Controls.Remove(grid);
            grid.Controls.Clear();
            jogo.apertouUmaVez = false;
        }

        private void VoltarInstrucoesClick(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            botoes.Visible = true;
            instrucoes.Visible = false;
            voltarInstrucoes.Visible = false;
        }

        private void TimerTick(object sender, EventArgs e)
        {
            tempo.Text = "Tempo: " + relogio.Elapsed.Minutes.ToString().PadLeft(2, '0') + ":" + relogio.Elapsed.Seconds.ToString().PadLeft(2, '0');
            marcados.Text = "Quantidade: " + jogo.GetCampo().GetQtdParaMarcar();
        }
    }
}
