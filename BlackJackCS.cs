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
			Console.WriteLine("s to shuffle y to draw card n to end turn");
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
					BlackJackObject.CheckNo();
                }
				else if (tempChar == "s")
				{
					BlackJackObject.IfS();
				}
            }
        }
    }

    class BlackJackClass
    {
        public int totalNum = 0;
        public int aceCount = 0;
        public int decknum = 0;
        public string[] cards = {"AH","2H", "3H", "4H", "5H", "6H", "7H", "8H", "9H", "10H", "JH", "QH", "KH",
        "AC","2C", "3C", "4C", "5C", "6C", "7C", "8C", "9C", "10C", "JC", "QC", "KC",
        "AD","2D", "3D", "4D", "5D", "6D", "7D", "8D", "9D", "10D", "JD", "QD", "KD",
        "AS","2S", "3S", "4S", "5S", "6S", "7S", "8S", "9S", "10S", "JS", "QS", "KS"};
		
        public void DrawCard()
        {
            for (int i = decknum; i < 52; i++)
            {
                Console.WriteLine(cards[i]);
                decknum++;
				switch (cards[i])
				{
					case "AH":
						totalNum += 1;
						aceCount++;
						break;
					case "AD":
						totalNum += 1;
						aceCount++;
						break;
					case "AS":
						totalNum += 1;
						aceCount++;
						break;
					case "AC":
						totalNum += 1;
						aceCount++;
						break;
					case "2H":
						totalNum += 2;
						break;
					case "2C":
						totalNum += 2;
						break;
					case "2D":
						totalNum += 2;
						break;
					case "2S":
						totalNum += 2;
						break;
					case "3H":
						totalNum += 3;
						break;
					case "3C":
						totalNum += 3;
						break;
					case "3D":
						totalNum += 3;
						break;
					case "3S":
						totalNum += 3;
						break;
					case "4H":
						totalNum += 4;
						break;
					case "4C":
						totalNum += 4;
						break;
					case "4D":
						totalNum += 4;
						break;
					case "4S":
						totalNum += 4;
						break;
					case "5H":
						totalNum += 5;
						break;
					case "5C":
						totalNum += 5;
						break;
					case "5D":
						totalNum += 5;
						break;
					case "5S":
						totalNum += 5;
						break;
					case "6S":
						totalNum += 6;
						break;
					case "6H":
						totalNum += 6;
						break;
					case "6C":
						totalNum += 6;
						break;
					case "6D":
						totalNum += 6;
						break;
					case "7H":
						totalNum += 7;
						break;
					case "7C":
						totalNum += 7;
						break;
					case "7D":
						totalNum += 7;
						break;
					case "7S":
						totalNum += 7;
						break;
					case "8H":
						totalNum += 8;
						break;
					case "8C":
						totalNum += 8;
						break;
					case "8D":
						totalNum += 8;
						break;
					case "8S":
						totalNum += 8;
						break;
					case "9H":
						totalNum += 9;
						break;
					case "9C":
						totalNum += 9;
						break;
					case "9D":
						totalNum += 9;
						break;
					case "9S":
						totalNum += 9;
						break;
					case "10H":
						totalNum += 10;
						break;
					case "10C":
						totalNum += 10;
						break;
					case "10D":
						totalNum += 10;
						break;
					case "10S":
						totalNum += 10;
						break;
					case "JH":
						totalNum += 10;
						break;
					case "JC":
						totalNum += 10;
						break;
					case "JD":
						totalNum += 10;
						break;
					case "JS":
						totalNum += 10;
						break;
					case "QH":
						totalNum += 10;
						break;
					case "QC":
						totalNum += 10;
						break;
					case "QD":
						totalNum += 10;
						break;
					case "QS":
						totalNum += 10;
						break;
					case "KH":
						totalNum += 10;
						break;
					case "KC":
						totalNum += 10;
						break;
					case "KD":
						totalNum += 10;
						break;
					case "KS":
						totalNum += 10;
						break;
				}
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

        public void IfS() {
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
				aceCount = 0;
			}
		}
	}
}
