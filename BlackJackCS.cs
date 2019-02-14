using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackCS
{
    class Program
    {
        static void Main(string[] args)
        {
            BlackJackClass BlackJackObject = new BlackJackClass();
            bool shouldPlay = true;
            while (shouldPlay == true)
            {
                string tempChar;
                tempChar = Console.ReadLine();
                if (tempChar == "y")
                {
                    BlackJackObject.DrawCard();
                    BlackJackObject.CountTotal();
                }
                else if (tempChar == "n")
                {
                    if (BlackJackObject.totalNum < 11 && BlackJackObject.aceCount > 0)
                    {
                        Console.WriteLine(BlackJackObject.totalNum + 10);
                    }
                    else if (BlackJackObject.totalNum == 21 ||
                             (BlackJackObject.totalNum == 11 && BlackJackObject.aceCount == 1))
                    {
                        Console.WriteLine("21");
                    }
                    else if (BlackJackObject.totalNum < 21)
                    {
                        Console.WriteLine(BlackJackObject.totalNum);
                    }
                    else if (BlackJackObject.totalNum > 21)
                    {
                        Console.WriteLine("Bust");
                    }
                        BlackJackObject.totalNum = 0;
                }
            }
        }
    }

    class BlackJackClass
    {
        public string[] deck = { "ace", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "jack", "queen", "king" };
        public string[] suite = { "hearts", "clubs", "diamonds", "spades" };
        public int randomCard;
        public int randomSuite;
        public static Random r = new Random();
        public static Random r2 = new Random();
        public int totalNum = 0;
        public int aceCount = 0;
        public void DrawCard()
        {         
            randomCard = r.Next(13);
            randomSuite = r2.Next(4);
            Console.WriteLine(deck[randomCard] + " of " + suite[randomSuite]);
        }

        public void CountTotal() {
            switch (randomCard)
            {
                case 0:
                    totalNum += 1;
                    aceCount++;
                    break;
                case 1:
                    totalNum += 2;
                    break;
                case 2:
                    totalNum += 3;
                    break;
                case 3:
                    totalNum += 4;
                    break;
                case 4:
                    totalNum += 5;
                    break;
                case 5:
                    totalNum += 6;
                    break;
                case 6:
                    totalNum += 7;
                    break;
                case 7:
                    totalNum += 8;
                    break;
                case 8:
                    totalNum += 9;
                    break;
                case 9:
                    totalNum += 10;
                    break;
                case 10:
                    totalNum += 10;
                    break;
                case 11:
                    totalNum += 10;
                    break;
                case 12:
                    totalNum += 10;
                    break;
            }
        }
        

    }
}
