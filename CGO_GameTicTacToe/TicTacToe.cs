using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_GameTicTacToe
{
    class TicTacToe
    {
		//Khoi tao
        public TicTacToe(){
            play();
        }
        
        //Luot choi
        public void play() {
            int moveCounter = 0;
            Board gameBoard = new Board();
            int k=0;
            Console.WriteLine("1: Dau voi nguoi");
            Console.WriteLine("2: Dau voi may");
            k = int.Parse(Console.ReadLine());
            while (k != 1 && k != 2)
            {
                Console.Write("Nhap sai, moi nhap lai: ");
                k = int.Parse(Console.ReadLine());
            }
            if (k == 1) Console.WriteLine("Ban chon dau voi nguoi!");
            if (k == 2) Console.WriteLine("Ban chon dau voi may!");        
            Player playerX = new Player('X');
            Player playerO = new Player('O');
            Robot playerR = new Robot('O');
            Player currentPlayer = playerX;
            
            bool play = true;
            while (play)
            {
                gameBoard.printBoard();
                Console.WriteLine("Player: {0} Enter the field in which you want to put the character: ", currentPlayer.getSign());

                try
                {
                    if (k == 1)
                    {
                        gameBoard.putMark(currentPlayer, playerX.takeTurn());
                    }
                    if (k == 2)
                    {
                        if (currentPlayer.getSign() == 'X') gameBoard.putMark(currentPlayer, playerX.takeTurn());
                        if (currentPlayer.getSign() == 'O') gameBoard.putMark2(playerR, playerR.takeTurn());
                    }
                    gameBoard.clearBoard();
                    moveCounter++;

                    if (currentPlayer.checkWin(gameBoard))
                    {
                        Console.WriteLine("Player: {0} won!", currentPlayer.getSign());
                        gameBoard.printBoard();
                        play = false;
                    }
                    else if (checkDraw(moveCounter))
                    {
                        Console.WriteLine("DRAW");
                        gameBoard.printBoard();
                        play = false;
                    }
                    currentPlayer = (moveCounter % 2 == 0) ? playerX : playerO;
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input. Please enter number between 1-9!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
      
        //Kiem tra luot di cuoi
        private bool checkDraw(int turnCounter)
        {
            if (turnCounter == 9)
                return true;
            return false;
        }

    }

}

