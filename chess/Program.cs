﻿using tabuleiro;
using xadrez;

namespace chess{
    class Program
    {
        private static void Main(string[] args){


            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine(pos);

            //try { 
            //    Tabuleiro tab = new Tabuleiro(8, 8);

            //    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            //    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            //    tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            //    Tela.imprimirTabuleiro(tab);
            //}catch (TabuleiroException ex){
            //    Console.WriteLine(ex.Message);
            //}
            Console.ReadLine();

        }
    }
}
