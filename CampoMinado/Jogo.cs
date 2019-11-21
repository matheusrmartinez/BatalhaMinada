using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Jogo
    {
        private Tabuleiro campo;
        private Boolean ganhou;
        public Boolean apertouUmaVez;

        public Jogo()
        {

        }

        public Tabuleiro GetCampo()
        {
            return this.campo;
        }

        public Boolean GetGanhou()
        {
            return this.ganhou;
        }

        public void IniciarPartida()
        {
            campo = new Tabuleiro();
        }

        public void Jogar(int linha, int coluna)
        {
            if (!apertouUmaVez)
            {
                campo.GeraTabuleiro(linha, coluna);
                apertouUmaVez = true;
                AgoraVai.timer.Enabled = true;
                AgoraVai.relogio.Start();              
            }
            if (campo.GetTabuleiro()[linha, coluna].GetBomba() == 'N' && campo.GetTabuleiro()[linha, coluna].GetPodeMarcar())
            {
                campo.GetTabuleiro()[linha, coluna].SetSelecionado(false);
                campo.GetTabuleiro()[linha, coluna].SetPodeMarcar(false);
                campo.VerificaVazio(linha, coluna);
            }
            else if (campo.GetTabuleiro()[linha, coluna].GetPodeMarcar())
            {
                campo.GetTabuleiro()[linha, coluna].SetSelecionado(false);
                campo.GetTabuleiro()[linha, coluna].SetPodeMarcar(false);
            }
            if (FimJogo(linha, coluna))
            {
                for (int i = 0; i < campo.GetTabuleiro().GetLength(0); i++)
                {
                    for (int j = 0; j < campo.GetTabuleiro().GetLength(1); j++)
                    {
                        campo.GetTabuleiro()[i, j].SetPodeMarcar(false);
                        campo.GetTabuleiro()[i, j].SetSelecionado(false);
                    }
                }
            }
        }

        public void Marcar(int linha, int coluna)
        {
            if (campo.GetTabuleiro()[linha, coluna].GetPodeMarcar())
            {
                campo.GetTabuleiro()[linha, coluna].SetSelecionado(true);
                campo.GetTabuleiro()[linha, coluna].SetPodeMarcar(false);
                campo.SetQtdParaMarcar(-1);
            }
            else if (campo.GetTabuleiro()[linha, coluna].GetSelecionado())
            {
                campo.GetTabuleiro()[linha, coluna].SetSelecionado(false);
                campo.GetTabuleiro()[linha, coluna].SetPodeMarcar(true);
                campo.SetQtdParaMarcar(1);
            }
        }

        public Boolean FimJogo(int linha, int coluna)
        {
            int contador = 0;
            if (campo.GetTabuleiro()[linha, coluna].GetTemBomba())
            {
                ganhou = false;
                return true;
            }
            else
            {
                for (int i = 0; i < campo.GetTabuleiro().GetLength(0); i++)
                {
                    for (int j = 0; j < campo.GetTabuleiro().GetLength(1); j++)
                    {
                        if ((campo.GetTabuleiro()[i, j].GetPodeMarcar() || campo.GetTabuleiro()[i, j].GetSelecionado()) && campo.GetTabuleiro()[i, j].GetTemBomba() == false)
                        {
                            contador++;
                        }
                    }
                }
                if (contador == 0)
                {
                    ganhou = true;
                    return true;
                }
            }
            return false;
        }
    }
}
