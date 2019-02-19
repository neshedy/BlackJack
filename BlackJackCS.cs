using System;

namespace MyProgram
{
	class MyClass
	{
		static void Main(string[] args)
		{
			BJClass BJObject = new BJClass();
			bool shouldplay = true;
			while (shouldplay == true)
			{
				char tempchar = Console.ReadLine()[0];
				switch(tempchar)
				{
					case 'y': BJObject.IfY();
					break;
					case 'n': BJObject.IfN();
					break;
					case 's': {BJObject.ShuffleA();BJObject.InitializeValue();}
					break;
				}
			}
		}
	}
	
	public class BJClass
	{
		char[] typeA = new char[52] {'A','2','3','4','5','6','7','8','9','T','J','Q','K',
		'A','2','3','4','5','6','7','8','9','T','J','Q','K',
		'A','2','3','4','5','6','7','8','9','T','J','Q','K',
		'A','2','3','4','5','6','7','8','9','T','J','Q','K'};
		char[] suiteA = new char[52] {'D','C','H','S','D','C','H','S','D','C','H','S',
		'D','C','H','S','D','C','H','S','D','C','H','S','D','C','H','S','D','C','H','S',
		'D','C','H','S','D','C','H','S','D','C','H','S','D','C','H','S','D','C','H','S',};
		int[] valueA = new int[52] {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',
		' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',
		' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' '};
		public int cardCount = 0;
		public int aceCount = 0;
		public int handValue = 0;
		
		public BJClass() 
		{
			ShuffleA();
			InitializeValue();
		}
		
		public void ShuffleA() {
			Shuffle(typeA);
			Shuffle(suiteA);
		}
		
		public char[] Shuffle(char[] wordArray)
        {
            Random random = new Random();
            for (int i = wordArray.Length - 1; i > 0; i--)
            {
                int swapIndex = random.Next(i + 1);
                char temp = wordArray[i];
                wordArray[i] = wordArray[swapIndex];
                wordArray[swapIndex] = temp;
            }
            return wordArray;
        }
		
		public void InitializeValue() 
		{
			for (int i = 0; i < 52; i++)
			{
				switch(typeA[i]) 
				{
				case 'A': valueA[i] = 1;
				break;
				case '2': valueA[i] = 2;
				break;
				case '3': valueA[i] = 3;
				break;
				case '4': valueA[i] = 4;
				break;
				case '5': valueA[i] = 5;
				break;
				case '6': valueA[i] = 6;
				break;
				case '7': valueA[i] = 7;
				break;
				case '8': valueA[i] = 8;
				break;
				case '9': valueA[i] = 9;
				break;
				case 'T': valueA[i] = 10;
				break;
				case 'J': valueA[i] = 10;
				break;
				case 'Q': valueA[i] = 10;
				break;
				case 'K': valueA[i] = 10;
				break;
				}
			}
		}
		
		void DealCard() 
		{
			if (valueA[cardCount] == 1)
			{
				aceCount++;
			}
			if (cardCount < 52)
			{
				Console.Write(typeA[cardCount]);
				Console.WriteLine(suiteA[cardCount]);
			}
			else
			{
				cardCount = 0;
				ShuffleA();
				InitializeValue();
			}
		}

		public void IfY() 
		{
			handValue += valueA[cardCount];
			DealCard();
			cardCount++;
		}
		public void IfN()
		{
			if (handValue <= 11 && aceCount >= 1)
				Console.WriteLine(10 + handValue);
			else if (handValue < 21)
				Console.WriteLine(handValue);
			else if (handValue == 21)
				Console.WriteLine(handValue);
			else if (handValue > 21)
				Console.WriteLine("Bust");
			aceCount = 0;
			handValue = 0;
		}
	}
}
