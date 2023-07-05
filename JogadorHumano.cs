
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabalho_pratico;

namespace MeuTrabalhoATP
{
    internal class JogadorHumano
    {
        public char[,] Tabuleiro;
        public int Pontuacao;
        public string[] PosTirosDados = new string[100];

        public JogadorHumano(int numLinhas, int numColunas)
        {
            Tabuleiro = new char[numLinhas, numColunas];
            Pontuacao = 0;
        }

        // Solicita ao Humano uma posição no tabueiro para ser atacado
        public Posicao EscolherAtaque()
        {
            return Posicao.ObterPosicao("Informe uma posição para o ataque. Ex: (0,0):");
        }

        public bool ReceberAtaque(Posicao posicao)
        {
            var tiro = Tabuleiro[posicao.Linha, posicao.Coluna];

            if (tiro == 'A')
            {
                Tabuleiro[posicao.Linha, posicao.Coluna] = 'X';
                return false;
            }
            else
            {
                Tabuleiro[posicao.Linha, posicao.Coluna] = 'T';
                return true;
            }
        }

    }
}
