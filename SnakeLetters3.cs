using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


    class SnakeLetters3
    {
       
        static void Main(string[] args)
        {

            // The two players of the game.
            int player1 = 1;
            int player2 = 1;
            int num;

            // The opening of the game.
            Console.ForegroundColor = (ConsoleColor)14;
            Console.WriteLine("\t\t\t\t\t Welcom to Snake and Letters game");
            Console.ForegroundColor = (ConsoleColor)4;

            // Drawing to open the game
            String dudu = @"
                                          ---_ ......._-_--.
                                          (|\ /      / /| \  \
                                          /  /     .'  -=-'   `.
                                         /  /    .'             )
                                       _/  /   .'        _.)   /
                                      / o   o        _.-' /  .'
                                      \          _.-'    / .'*|
                                       \______.-'//    .'.' \*|
                                        \|  \ | //   .'.' _ |*|
                                         `   \|//  .'.'_ _ _|*|
                                          .  .// .'.' | _ _ \*|
                                          \`-|\_/ /    \ _ _ \*\
                                           `/'\__/      \ _ _ \*\
                                          /^|            \ _ _ \*
                                         '  `             \ _ _ \      
                                                           \_


            ";
            Console.WriteLine(dudu);

            // Drawing for the winner of the game
            String dudu2 = @"
                                          .-=========-.
                                          \'-=======-'/
                                          _|   .=.   |_
                                         ((|  {{1}}  |))
                                          \|   /|\   |/
                                           \__ '`' __/
                                             _`) (`_
                                           _/_______\_
                                          /___________\

            ";


            // Explanation of the game
            Console.ForegroundColor = (ConsoleColor)1;
            Kave2();
            Console.Write(" The blue numbers are the letters ");
            Kave2();
            Console.WriteLine();

            Console.ForegroundColor = (ConsoleColor)4;
            Kave2();
            Console.Write(" The red numbers are the snakes   ");
            Kave2();
            Console.WriteLine();

            Console.ForegroundColor = (ConsoleColor)2;
            Kave2();
            Console.Write(" The players colors are green     ");
            Kave2();
            Console.WriteLine();

            Console.ForegroundColor = (ConsoleColor)14;
            Kave2();
            Console.Write(" To start the game press Enter    ");
            Kave2();
            Console.WriteLine();


            // To start the game you need to press Enter.
            char ch = (char)Console.Read();
            while (ch != 'a')
            {
                Console.WriteLine("To start the game press Enter:");
                ch = (char)Console.Read();
            }
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
           

            // The loop that give to both players to play,
            // until ome of them get to 25 (win the game)
            while (player1 != 100 && player2 != 100)
            {
                // The turn of the first player.
                num = Dice();
                Console.WriteLine($"You rolled {num}");
                Thread.Sleep(2000);

                player1 += num;
                player1 = Snakeletters(player1);
                Board(player1, player2);

                if (player1 != 100)
                {

                    Console.WriteLine("THe next player torn, press Enter:");
                    ch = (char)Console.Read();
                    while (ch != 'a')
                    {

                        ch = (char)Console.Read();
                    }
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                    // The turn of teh second player.
                    num = Dice();
                    Console.WriteLine($"You rolled {num}");
                    Thread.Sleep(2000);
                    player2 += num;
                    player2 = Snakeletters(player2);
                    Board(player1, player2);

                   
                    Console.WriteLine("THe next player torn, press Enter:");
                    ch = (char)Console.Read();
                    while (ch != 'a')
                    {

                        ch = (char)Console.Read();
                    }
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                }
            }
            

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            
            // The announcement of the winner of the game.
            // Or the first player or the second player.
            if (player1 == 100)
                Console.WriteLine("\t\t\t\t\t The winer is Player1");
            else
                Console.WriteLine("\t\t\t\t\t The winer is Player2");
            Console.WriteLine(dudu2);
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n");
        }





        // Funcion of the board of the game.
        public static void Board(int p1, int p2)
        {
            Console.ForegroundColor = (ConsoleColor)14;
            Kave();
            int num = 91;
            int x = 10;

            for (int i = 0; i < 10; i++)
            {

                for (int k = 0; k < 10; k++)
                {
                    int[] snakes = { 17, 23, 51, 50, 31, 30, 98, 84, 76, 66, 54, 5 };
                    int[] letters = { 34, 27, 14, 7, 73, 89, 91, 45, 57, 63, 79 };
                    if (i % 2 != 0)
                        k = k * -1;
                    x = num + k;


                    if (x == 100)
                    {

                        Console.Write("| ");
                        if (x == p1)
                        {
                            Console.ForegroundColor = (ConsoleColor)2;
                            Console.Write("P1");
                        }
                        else if (x == p2)
                        {
                            Console.ForegroundColor = (ConsoleColor)2;
                            Console.Write("P2");
                        }
                        else
                            Console.Write(x);
                        Console.ForegroundColor = (ConsoleColor)14;
                        
                    }


                    else if (x > 9)
                    {

                        Console.Write("| ");

                        if (Array.IndexOf(snakes, x) != -1)
                            Console.ForegroundColor = (ConsoleColor)4;

                        if (Array.IndexOf(letters, x) != -1)
                            Console.ForegroundColor = (ConsoleColor)1;

                        if (x == p1)
                        {
                            Console.ForegroundColor = (ConsoleColor)2;
                            Console.Write("P1");
                        }
                        else if (x == p2)
                        {
                            Console.ForegroundColor = (ConsoleColor)2;
                            Console.Write("P2");
                        }
                        else
                            Console.Write(x);
                        Console.ForegroundColor = (ConsoleColor)14;
                        Console.Write(" ");

                    }

                    else
                    {
                        Console.Write("|");
                        if (Array.IndexOf(snakes, x) != -1)
                            Console.ForegroundColor = (ConsoleColor)4;

                        if (Array.IndexOf(letters, x) != -1)
                            Console.ForegroundColor = (ConsoleColor)1;

                        if (x == p1)
                        {
                            Console.ForegroundColor = (ConsoleColor)2;
                            Console.Write(" " + "P1" + " ");
                        }
                        else if (x == p2)
                        {
                            Console.ForegroundColor = (ConsoleColor)2;
                            Console.Write(" " + "P2" + " ");
                        }
                        else
                            Console.Write("  " + (x) + " ");
                        Console.ForegroundColor = (ConsoleColor)14;
                    }
                    if (i % 2 != 0)
                        k = k * -1;



                }
                if (i % 2 == 0)
                    num -= 1;
                else
                    num -= 19;

                Console.WriteLine("|");
                Kave();



            }
        }

        // Function of the Dice of  the game.
        public static int Dice()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }

        // Function of the snake and the letters of the game.
        public static int Snakeletters(int num)
        {
            if (num < 101)
            {
                switch (num)
                {
                    case 23:
                        return 5;
                        break;
                    case 51:
                        return 30;
                        break;
                    case 98:
                        return 54;
                        break;
                    case 73:
                        return 91;
                        break;
                    case 45:
                        return 79;
                    case 7:
                        return 34;

                    default:
                        return num;
                }
            }
            else
                return 100;
        }




        //Two functions to create lines
        public static void Kave()
        {
            String kav = "+";
            for (int i = 0; i < 10; i++)
            {
                kav += "----+";
            }
            Console.WriteLine(kav);
        }

        public static void Kave2()
        {
            String kav = "";
            for (int i = 0; i < 9; i++)
            {
                kav += "****";
            }
            kav += "*";
            Console.Write(kav);


        }


    }


