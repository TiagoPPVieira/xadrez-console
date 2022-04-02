namespace tabuleiro {
    class Peca {

        public Posicao posicao { get; set; }
        public Cor cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro tab { get; protected set; }
         
        public Peca(Tabuleiro tab, Cor cor) {
            this.posicao = null;
            this.tab = tab;
            this.cor = cor;
            this.qteMovimentos = 0;
        }
<<<<<<< HEAD
<<<<<<< HEAD

        public void incrementarQteMovimentos() {
            qteMovimentos++;
        }
<<<<<<< HEAD

        public void decrementarQteMovimentos() {
            qteMovimentos--;
        }

        public bool existeMovimentosPossiveis() {
            bool[,] mat = movimentosPossiveis();
            for (int i=0; i<tab.linhas; i++) {
                for (int j=0; j<tab.colunas; j++) {
                    if (mat[i, j]) {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool movimentoPossivel(Posicao pos) {
            return movimentosPossiveis()[pos.linha, pos.coluna];
        }

        public abstract bool[,] movimentosPossiveis();
=======
>>>>>>> parent of 886a293 (Fazendo os primeiros testes de movimentacao)
=======
>>>>>>> parent of 886a293 (Fazendo os primeiros testes de movimentacao)
=======
>>>>>>> parent of cb64c95 (Testes iniciais com movimentos possiveis das pecas)
    }
}
