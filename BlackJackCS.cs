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
                    BlackJackObject.IfYes();
                }
                else if (tempChar == "n")
                {
                    BlackJackObject.IfNo();
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
        public int decknum = 0;
        public string[] cards = {"AH","2H", "3H", "4H", "5H", "6H", "7H", "8H", "9H", "10H", "JH", "QH", "KH",
        "AC","2C", "3C", "4C", "5C", "6C", "7C", "8C", "9C", "10C", "JC", "QC", "KC",
        "AD","2D", "3D", "4D", "5D", "6D", "7D", "8D", "9D", "10D", "JD", "QD", "KD",
        "AS","2S", "3S", "4S", "5S", "6S", "7S", "8S", "9S", "10S", "JS", "QS", "KS",};

        public void DrawCard()
        {
            for (int i = decknum; i < 52; i++)
            {
                Console.WriteLine(cards[i]);
                decknum++;
                break;
            }
        }

        public void DisplayDeck() {
            for (int i = 0; i < 52; i++)
            {
                Console.Write(cards[i] + " ");
            }
        }

        public string[] Shuffle(string[] wordArray)
        {
            Random random = new Random();
            for (int i = wordArray.Length - 1; i > 0; i--)
            {
                int swapIndex = random.Next(i + 1);
                string temp = wordArray[i];
                wordArray[i] = wordArray[swapIndex];
                wordArray[swapIndex] = temp;
            }
            return wordArray;
        }

        public void IfNo() {
            decknum = 0;
            Shuffle(cards);
            DisplayDeck();
        }

        public void IfYes() {
            DrawCard();
        }

        public void CheckNo() {
            {
                if (totalNum < 11 && aceCount > 0)
                {
                    Console.WriteLine(totalNum + 10);
                }
                else if (totalNum == 21 ||
                         (totalNum == 11 && aceCount == 1))
                {
                    Console.WriteLine("21");
                }
                else if (totalNum < 21)
                {
                    Console.WriteLine(totalNum);
                }
                else if (totalNum > 21)
                {
                    Console.WriteLine("Bust");
                }
                totalNum = 0;
            }
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
