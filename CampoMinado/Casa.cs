using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Casa
    {
        private Boolean temBomba;
        private Boolean selecionado;
        private Boolean podeMarcar = true;
        private char bomba;
        private int qtdBombas;

        public Casa()
        {

        }
        public Casa(char bomba)
        {
            this.bomba = bomba;
        }
        public Casa(int qtdBombas)
        {
            this.qtdBombas = qtdBombas;
        }

        public Boolean GetSelecionado()
        {
            return this.selecionado;
        }

        public void SetSelecionado(Boolean selecionado)
        {
            this.selecionado = selecionado;
        }

        public Boolean GetPodeMarcar()
        {
            return this.podeMarcar;
        }

        public void SetPodeMarcar(Boolean podeMarcar)
        {
            this.podeMarcar = podeMarcar;
        }

        public Boolean GetTemBomba()
        {
            return this.temBomba;
        }

        public int GetValor()
        {
            return this.qtdBombas;
        }

        public char GetBomba()
        {
            return this.bomba;
        }

        public void SetTemBomba(Boolean temBomba)
        {
            this.temBomba = temBomba;
        }
    }
}
