using System;
using System.Collections.Generic;
using tabuleiro;

namespace xadrez_console {
    class Tela {

        public static void imprimirPartida(PartidaDeXadrez partida) {
            imprimirTabuleiro(partida.tab);
            Console.WriteLine();
            imprimirPecasCapturadas(partida);
            Console.WriteLine();
            Console.WriteLine("Turno: " + partida.turno);
            if (!partida.terminada) {
                Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);
                if (partida.xeque) {
                    Console.WriteLine("XEQUE!");
                }
            }
            else {
                Console.WriteLine("XEQUEMATE!");
                Console.WriteLine("Vencedor: " + partida.jogadorAtual);
            }
        }

        public static void imprimirPecasCapturadas(PartidaDeXadrez partida) {
            Console.WriteLine("Peças capturadas:");
            Console.Write("Brancas: ");
            imprimirConjunto(partida.pecasCapturadas(Cor.Branca));
            Console.WriteLine();
            Console.Write("Pretas: ");
            ConsoleColor aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            imprimirConjunto(partida.pecasCapturadas(Cor.Preta));
            Console.ForegroundColor = aux;
            Console.WriteLine();
        }

        public static void imprimirConjunto(HashSet<Peca> conjunto) {
            Console.Write("[");
            foreach (Peca x in conjunto) {
                Console.Write(x + " ");
            }
            Console.Write("]");
        }

        public static void imprimirTabuleiro(Tabuleiro tab) {

            for (int i=0; i<tab.linhas; i++) {
                Console.Write(8 - i + " ");
                for (int j=0; j<tab.colunas; j++) {
                   imprimirPeca(tab.peca(i, j));
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void imprimirTabuleiro(Tabuleiro tab, bool[,] posicoePossiveis) {

            ConsoleColor fundoOriginal = Console.BackgroundColor;
            ConsoleColor fundoAlterado = ConsoleColor.DarkGray;

            for (int i = 0; i < tab.linhas; i++) {
                Console.Write(8 - i + " ");
                for (int j = 0; j < tab.colunas; j++) {
                    if (posicoePossiveis[i, j]) {
                        Console.BackgroundColor = fundoAlterado;
                    }
                    else {
                        Console.BackgroundColor = fundoOriginal;
                    }
                    imprimirPeca(tab.peca(i, j));
                    Console.BackgroundColor = fundoOriginal;
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
<<<<<<< HEAD
            Console.BackgroundColor = fundoOriginal;
=======
>>>>>>> parent of 886a293 (Fazendo os primeiros testes de movimentacao)
        }

        public static void imprimirPeca(Peca peca) {

            if (peca == null) {
                Console.Write("- ");
            }
            else {
                if (peca.cor == Cor.Branca) {
                    Console.Write(peca);
                }
                else {
                    ConsoleColor aux = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(peca);
                    Console.ForegroundColor = aux;
                }
                Console.Write(" ");
            }
        }

    }
}
