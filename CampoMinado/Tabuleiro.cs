using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Tabuleiro
    {
        private Int32 qtdBombas;
        private Casa[,] tabuleiro;
        private int qtdParaMarcar = 24;

        public Tabuleiro()
        {
            tabuleiro = new Casa[16, 10];
        }

        public void SetQtdParaMarcar(int qtdParaMarcar)
        {
            if(qtdParaMarcar == 1)
            {
                this.qtdParaMarcar++;
            }
            else
            {
                this.qtdParaMarcar--;
            }
           
        }

        public int GetQtdParaMarcar()
        {
            return this.qtdParaMarcar;
        }

        public Casa[,] GetTabuleiro()
        {
            return this.tabuleiro;
        }

        private void VerificaEsqCima(int i, int j)
        {
            if (tabuleiro[i - 1, j - 1] != null && tabuleiro[i - 1, j - 1].GetTemBomba())
            {
                qtdBombas++;
            }
        }

        private void VerificaDirCima(int i, int j)
        {
            if (tabuleiro[i - 1, j + 1] != null && tabuleiro[i - 1, j + 1].GetTemBomba())
            {
                qtdBombas++;
            }
        }

        private void VerificaEsqBaixo(int i, int j)
        {
            if (tabuleiro[i + 1, j - 1] != null && tabuleiro[i + 1, j - 1].GetTemBomba())
            {
                qtdBombas++;
            }
        }

        private void VerificaDirBaixo(int i, int j)
        {
            if (tabuleiro[i + 1, j + 1] != null && tabuleiro[i + 1, j + 1].GetTemBomba())
            {
                qtdBombas++;
            }
        }

        private void VerificaCima(int i, int j)
        {
            if (tabuleiro[i - 1, j] != null && tabuleiro[i - 1, j].GetTemBomba())
            {
                qtdBombas++;
            }
        }

        private void VerificaBaixo(int i, int j)
        {
            if (tabuleiro[i + 1, j] != null && tabuleiro[i + 1, j].GetTemBomba())
            {
                qtdBombas++;
            }
        }

        private void VerificaEsq(int i, int j)
        {
            if (tabuleiro[i, j - 1] != null && tabuleiro[i, j - 1].GetTemBomba())
            {
                qtdBombas++;
            }
        }

        private void VerificaDir(int i, int j)
        {

            if (tabuleiro[i, j + 1] != null && tabuleiro[i, j + 1].GetTemBomba())
            {
                qtdBombas++;
            }
        }

        private void VerificaDirVazio(int i, int j)
        {
            if (tabuleiro[i, j + 1].GetBomba() == 'N' || tabuleiro[i, j + 1].GetValor() != 0)
            {
                tabuleiro[i, j + 1].SetPodeMarcar(false);
            }
        }

        private void VerificaEsqVazio(int i, int j)
        {
            if (tabuleiro[i, j - 1].GetBomba() == 'N' || tabuleiro[i, j - 1].GetValor() != 0)
            {
                tabuleiro[i, j - 1].SetPodeMarcar(false);
            }
        }

        private void VerificaBaixoVazio(int i, int j)
        {
            if (tabuleiro[i + 1, j].GetBomba() == 'N' || tabuleiro[i + 1, j].GetValor() != 0)
            {
                tabuleiro[i + 1, j].SetPodeMarcar(false);
            }
        }

        private void VerificaCimaVazio(int i, int j)
        {
            if (tabuleiro[i - 1, j].GetBomba() == 'N' || tabuleiro[i - 1, j].GetValor() != 0)
            {
                tabuleiro[i - 1, j].SetPodeMarcar(false);
            }
        }

        private void VerificaEsqCimaVazio(int i, int j)
        {
            if (tabuleiro[i - 1, j - 1].GetBomba() == 'N' || tabuleiro[i - 1, j - 1].GetValor() != 0)
            {
                tabuleiro[i - 1, j - 1].SetPodeMarcar(false);
            }
        }

        private void VerificaDirBaixoVazio(int i, int j)
        {
            if (tabuleiro[i + 1, j + 1].GetBomba() == 'N' || tabuleiro[i + 1, j + 1].GetValor() != 0)
            {
                tabuleiro[i + 1, j + 1].SetPodeMarcar(false);
            }
        }

        private void VerificaEsqBaixoVazio(int i, int j)
        {
            if (tabuleiro[i + 1, j - 1].GetBomba() == 'N' || tabuleiro[i + 1, j - 1].GetValor() != 0)
            {
                tabuleiro[i + 1, j - 1].SetPodeMarcar(false);
            }
        }

        private void VerificaDirCimaVazio(int i, int j)
        {
            if (tabuleiro[i - 1, j + 1].GetBomba() == 'N' || tabuleiro[i - 1, j + 1].GetValor() != 0)
            {
                tabuleiro[i - 1, j + 1].SetPodeMarcar(false);
            }
        }

        public void VerificaVazio(int linha, int coluna)
        {

            if (linha == 0 && coluna == 0)
            {
                VerificaDirBaixoVazio(linha, coluna);
                VerificaDirVazio(linha, coluna);
                VerificaBaixoVazio(linha, coluna);
            }
            else if (linha == 0 && coluna == 9)
            {
                VerificaBaixoVazio(linha, coluna);
                VerificaEsqVazio(linha, coluna);
                VerificaEsqBaixoVazio(linha, coluna);
            }
            else if (linha == 15 && coluna == 0)
            {
                VerificaCimaVazio(linha, coluna);
                VerificaDirVazio(linha, coluna);
                VerificaDirCimaVazio(linha, coluna);

            }
            else if (linha == 15 && coluna == 9)
            {
                VerificaEsqVazio(linha, coluna);
                VerificaCimaVazio(linha, coluna);
                VerificaEsqCimaVazio(linha, coluna);
            }
            else if (coluna == 0)
            {
                VerificaBaixoVazio(linha, coluna);
                VerificaCimaVazio(linha, coluna);
                VerificaDirVazio(linha, coluna);
                VerificaDirCimaVazio(linha, coluna);
                VerificaDirBaixoVazio(linha, coluna);
            }
            else if (linha == 0)
            {
                VerificaBaixoVazio(linha, coluna);
                VerificaDirVazio(linha, coluna);
                VerificaEsqVazio(linha, coluna);
                VerificaEsqBaixoVazio(linha, coluna);
                VerificaDirBaixoVazio(linha, coluna);
            }
            else if (coluna == 9)
            {
                VerificaBaixoVazio(linha, coluna);
                VerificaCimaVazio(linha, coluna);
                VerificaEsqVazio(linha, coluna);
                VerificaEsqCimaVazio(linha, coluna);
                VerificaEsqBaixoVazio(linha, coluna);
            }
            else if (linha == 15)
            {
                VerificaCimaVazio(linha, coluna);
                VerificaDirVazio(linha, coluna);
                VerificaEsqVazio(linha, coluna);
                VerificaEsqCimaVazio(linha, coluna);
                VerificaDirCimaVazio(linha, coluna);
            }
            else
            {
                VerificaBaixoVazio(linha, coluna);
                VerificaCimaVazio(linha, coluna);
                VerificaDirVazio(linha, coluna);
                VerificaEsqVazio(linha, coluna);
                VerificaEsqCimaVazio(linha, coluna);
                VerificaEsqBaixoVazio(linha, coluna);
                VerificaDirCimaVazio(linha, coluna);
                VerificaDirBaixoVazio(linha, coluna);
            }

        }

        private void VerificaBombas()
        {
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    if (tabuleiro[i, j] == null)
                    {
                        if (i == 0 && j == 0)
                        {
                            VerificaDirBaixo(i, j);
                            VerificaDir(i, j);
                            VerificaBaixo(i, j);
                            AdicionaQtdBombas(i, j);
                        }
                        else if (i == 0 && j == 9)
                        {
                            VerificaBaixo(i, j);
                            VerificaEsq(i, j);
                            VerificaEsqBaixo(i, j);
                            AdicionaQtdBombas(i, j);
                        }
                        else if (i == 15 && j == 0)
                        {
                            VerificaCima(i, j);
                            VerificaDir(i, j);
                            VerificaDirCima(i, j);
                            AdicionaQtdBombas(i, j);
                        }
                        else if (i == 15 && j == 9)
                        {
                            VerificaEsq(i, j);
                            VerificaCima(i, j);
                            VerificaEsqCima(i, j);
                            AdicionaQtdBombas(i, j);
                        }
                        else if (j == 0)
                        {
                            VerificaBaixo(i, j);
                            VerificaCima(i, j);
                            VerificaDir(i, j);
                            VerificaDirCima(i, j);
                            VerificaDirBaixo(i, j);
                            AdicionaQtdBombas(i, j);
                        }
                        else if (i == 0)
                        {
                            VerificaBaixo(i, j);
                            VerificaDir(i, j);
                            VerificaEsq(i, j);
                            VerificaEsqBaixo(i, j);
                            VerificaDirBaixo(i, j);
                            AdicionaQtdBombas(i, j);
                        }
                        else if (j == 9)
                        {
                            VerificaBaixo(i, j);
                            VerificaCima(i, j);
                            VerificaEsq(i, j);
                            VerificaEsqCima(i, j);
                            VerificaEsqBaixo(i, j);
                            AdicionaQtdBombas(i, j);
                        }
                        else if (i == 15)
                        {
                            VerificaCima(i, j);
                            VerificaDir(i, j);
                            VerificaEsq(i, j);
                            VerificaEsqCima(i, j);
                            VerificaDirCima(i, j);
                            AdicionaQtdBombas(i, j);
                        }
                        else
                        {
                            VerificaBaixo(i, j);
                            VerificaCima(i, j);
                            VerificaDir(i, j);
                            VerificaEsq(i, j);
                            VerificaEsqCima(i, j);
                            VerificaEsqBaixo(i, j);
                            VerificaDirCima(i, j);
                            VerificaDirBaixo(i, j);
                            AdicionaQtdBombas(i, j);
                        }
                    }
                }
            }
        }

        private void AdicionaQtdBombas(int i, int j)
        {
            if (qtdBombas != 0)
            {
                tabuleiro[i, j] = new Casa(qtdBombas);
                qtdBombas = 0;
            }
            else
            {
                tabuleiro[i, j] = new Casa('N');
            }
        }

        public void GeraTabuleiro(int linhaEspecial, int colunaEspecial)
        {
            Random numeroRand = new Random();
            int linha;
            int coluna;
            int qtdBombasTabuleiro = 0;

            while (qtdBombasTabuleiro != 24)
            {
                linha = numeroRand.Next(16);
                coluna = numeroRand.Next(10);

                if (tabuleiro[linha, coluna] == null)
                {
                    tabuleiro[linha, coluna] = new Casa('B');
                    tabuleiro[linha, coluna].SetTemBomba(true);
                    qtdBombasTabuleiro++;
                }
                if (tabuleiro[linhaEspecial, colunaEspecial] != null && tabuleiro[linhaEspecial, colunaEspecial].GetTemBomba())
                {
                    tabuleiro[linhaEspecial, colunaEspecial] = null;
                    qtdBombasTabuleiro--;
                }
            }
            VerificaBombas();
        }

        public void TabuleiroInverso()
        {
            for (int i = tabuleiro.GetLength(0) - 1; i >= 0; i--)
            {
                for (int j = tabuleiro.GetLength(1) - 1; j >= 0; j--)
                {
                    if (tabuleiro[i, j].GetPodeMarcar() == false)
                    {
                        if (tabuleiro[i, j].GetSelecionado() == false)
                        {
                            if (tabuleiro[i, j].GetBomba() == 'N')
                            {
                                VerificaVazio(i, j);
                            }
                        }
                    }
                }
            }
        }

        public void TabuleiroNormal()
        {
            for (int i = 0; i < tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < tabuleiro.GetLength(1); j++)
                {
                    if (tabuleiro[i, j].GetPodeMarcar() == false)
                    {
                        if (tabuleiro[i, j].GetSelecionado() == false)
                        {
                            if (tabuleiro[i, j].GetBomba() == 'N')
                            {
                                VerificaVazio(i, j);
                            }
                        }
                    }
                }
            }
        }
    }
}
