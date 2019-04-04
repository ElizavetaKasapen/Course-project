using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Generic.KeyValuePair<string, int>;

namespace Course_project
{
    class Game_board
    {
        List<Figure> black = new List<Figure>(12);
        List<Figure> white = new List<Figure>(12);

        Cell[,] board = new Cell[8, 8];

        public Game_board()
        {
            //объявляем элементы массива
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    board[i, j] = new Cell();
                }
            }
            Fill_diagonals();
            First_placement_of_our_figures();


        }
        //задаем диагонали 
        private void Fill_diagonals()
        {
            int k = 7;
            //заполняем 1 диагональ
            for (int i = 0; i < 8; i++)
            {
                board[i, k].First_way = 1;
                board[k, i].First_way = 1;
                k--;
            }
            //заполняем 2 диагональ
            k = 7;
            for (int i = 2; i < 5; i++)
            {
                board[i, k].First_way = 2;
                board[k, i].First_way = 2;
                k--;
            }
            //заполняем 3 диагональ
            k = 5;
            for (int i = 0; i < 3; i++)
            {
                board[i, k].First_way = 3;
                board[k, i].First_way = 3;
                k--;
            }
            //заполняем 4 диагональ
            k = 3;
            for (int i = 0; i < 2; i++)
            {
                board[i, k].First_way = 4;
                board[k, i].First_way = 4;
                k--;
            }
            //заполняем 5 диагональ
            board[1, 0].First_way = 5;
            board[0, 1].First_way = 5;

            //заполняем 6 диагональ
            k = 7;
            for (int i = 4; i < 6; i++)
            {
                board[i, k].First_way = 6;
                board[k, i].First_way = 6;
                k--;
            }

            //заполняем 7 диагональ
            board[7, 6].First_way = 7;
            board[6, 7].First_way = 7;

            //заполняем 8 диагональ
            k = 1;
            for (int i = 0; i < 7; i++)
            {
                if (board[i, k].First_way == 0) board[i, k].First_way = 8;
                else board[i, k].Second_way = 8;
                k++;
            }

            //заполняем 9 диагональ
            k = 1;
            for (int i = 0; i < 7; i++)
            {
                if (board[k, i].First_way == 0) board[k, i].First_way = 9;
                else board[k, i].Second_way = 9;
                k++;
            }

            //заполняем 10 диагональ
            k = 3;
            for (int i = 0; i < 5; i++)
            {
                if (board[k, i].First_way == 0) board[k, i].First_way = 10;
                else board[k, i].Second_way = 10;
                k++;
            }

            //заполняем 11 диагональ
            k = 5;
            for (int i = 0; i < 3; i++)
            {
                if (board[k, i].First_way == 0) board[k, i].First_way = 11;
                else board[k, i].Second_way = 11;
                k++;
            }

            //заполняем 12 диагональ
            k = 0;
            for (int i = 5; i < 8; i++)
            {
                if (board[k, i].First_way == 0) board[k, i].First_way = 12;
                else board[k, i].Second_way = 12;
                k++;
            }

            //заполняем 13 диагональ
            k = 0;
            for (int i = 3; i < 8; i++)
            {
                if (board[k, i].First_way == 0) board[k, i].First_way = 13;
                else board[k, i].Second_way = 13;
                k++;
            }
        }

        //первоначальное положение шашек
        private void First_placement_of_our_figures()
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    if ((i + j) % 2 == 0 || i==3||i==4) { board[i, j].Figure_color = "empty"; continue; }
                    if (i < 3)
                    { board[i, j].Figure_color = "black"; }
                    else { board[i, j].Figure_color = "white"; }
                }
            }
        }
    }
}
