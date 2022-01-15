using System;
using System.Collections.Generic;
using System.Text;

namespace AlphabetPattern
{
    class printAlphabet
    {
        public void printA()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row == 1 || row == 3 || column == 1 || column == 5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printB()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row == 1 || row == 3 || column == 1 || column == 5 || row == 5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        public void printC()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row == 1 || column == 1 || row == 5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printD()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row == 1 || column == 1 || row == 5 || column == 5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printE()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row == 1 || column == 1 || row == 5 || row == 3)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printF()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row == 1 || column == 1 || row == 3)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printG()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if(row==1 || column==1 || row==5 || column==5 && row>=4 || row==3 && column>=3)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printH()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (column == 1 || column == 5 || row == 3)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printI()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row == 1 || column == 3 || row == 5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printJ()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row==1 || column==3 || row==5 && column<=3 || column==1 &&row>=3)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printK()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (column==1 || row+column==5 || row-column==1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printL()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row == 5 || column == 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printM()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (column==1 || column==5 || row==2&&column>=2&&column<=2 || row==3 && column>=3 && column<=3 || row==2&&column>=4&&column<=4 || row==1 && column>=5 && column<=5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printN()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 7; column++)
                {
                    if (column == 1 || column == 5 || row-column==0)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printO()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row == 5 || column == 1 || row == 1 || column == 5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printP()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row==1 || column==1 || column==5 && row<=3 || row==3)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printQ()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row==5 || column==1 || row==1 || column==5 || row==4&&column<=4&&column>=4 || row==3 && column<=3 && column>=3)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printR()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row==1 || column==1 || column==5 && row<=3 || row==3 || row==4&&column<=3&&column>=3 || row == 5 && column <= 5 && column >= 5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printS()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row == 1 || row==5 || row==3 || column==1 && row<=3 || column == 5 && row >= 3)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printT()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row == 1 || column == 3)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printU()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row == 5 || column == 5 || column == 1)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printV()
        {
            int row, column;
            for (row = 1; row <= 4; row++)
            {
                for (column = 1; column <= 7; column++)
                {
                    if (row-column==0||row+column==8)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printW()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 10; column++)
                {
                    if (column == 1 || column == 10 || row+column==6||column-row==5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printX()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row-column==0||row+column==6)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printY()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (column==3 &&row>=3 ||row==1 && column>=1 && column<=1 || row==2 && column >= 2 && column <= 2 || row == 3 && column >= 3 && column <= 3 || row == 2 && column >= 4 && column <= 4 || row == 1 && column >= 5 && column <= 5)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        public void printZ()
        {
            int row, column;
            for (row = 1; row <= 5; row++)
            {
                for (column = 1; column <= 5; column++)
                {
                    if (row==1 || row==5 || row + column == 6)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
    }

}