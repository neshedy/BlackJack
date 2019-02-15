#include <iostream>
// a simple blackjack program written in cpp
using namespace std;

class Card{
	public:
		char type;
		int value;
		char suite;
};

class Player{
	public:
		int handValue = 0;
		int aceCount = 0;
};

class Computer{
	public:
		Card card[52];
		Player player;
		int handValue = 0;
		int aceCount = 0;
		int cardCount = 0;
		char suiteA[52] = {'D','C','H','S','D','C','H','S',
		'D','C','H','S','D','C','H','S','D','C',
		'H','S','D','C','H','S','D','C','H','S',
		'D','C','H','S','D','C','H','S','D','C',
		'H','S','D','C','H','S','D','C','H','S',
		'D','C','H','S'};
		char typeA[52] = {'A','2','3','4','5','6','7','8',
		'9','T','J','Q','K','A','2','3','4','5','6','7','8',
		'9','T','J','Q','K','A','2','3','4','5','6','7','8',
		'9','T','J','Q','K','A','2','3','4','5','6','7','8',
		'9','T','J','Q','K',};
		void DealCard() {
			for (cardCount; cardCount < 52; cardCount++) {
				cout << card[cardCount].type << card[cardCount].suite << endl;
				player.handValue += card[cardCount].value;
				if (card[cardCount].value == 1) {
					player.aceCount++;
				}
				cardCount++;
				break;
			}
		}

		void Shuffle() {
			for (int i = 0; i < 52; i++) {
				int r = rand() % 52;
				int temp = suiteA[i];
				suiteA[i] = suiteA[r];
				suiteA[r] = temp;
			}			
			for (int i = 0; i < 52; i++) {
				int r = rand() % 52;
				int temp = typeA[i];
				typeA[i] = typeA[r];
				typeA[r] = temp;
			}
			for (int i = 0; i < 52; i++) {
				card[i].suite = suiteA[i];
				card[i].type = typeA[i];
			}
			for (int i = 0; i < 52; i++){
				switch(card[i].type) {
					case 'A': card[i].value = 1;
					break;
					case '2': card[i].value = 2;
					break;
					case '3': card[i].value = 3;
					break;
					case '4': card[i].value = 4;
					break;
					case '5': card[i].value = 5;
					break;
					case '6': card[i].value = 6;
					break;
					case '7': card[i].value = 7;
					break;
					case '8': card[i].value = 8;
					break;
					case '9': card[i].value = 9;
					break;
					case 'T': card[i].value = 10;
					break;
					case 'J': card[i].value = 10;
					break;
					case 'Q': card[i].value = 10;
					break;
					case 'K': card[i].value = 10;
					break;
				}
			}
		};
		
		void IfN() {
                if (player.handValue < 11 && player.aceCount > 0)
                {
                    cout << player.handValue + 10 << endl;
                }
                else if (player.handValue == 21 ||
                         (player.handValue == 11 && player.aceCount == 1))
                {
                    cout << "21" << endl;
                }
                else if (player.handValue < 21)
                {
                    cout << player.handValue << endl;
                }
                else if (player.handValue > 21)
                {
                    cout << "Bust" << endl;
                }
                player.handValue = 0;
				player.aceCount = 0;
		};
};

int main() {
	cout << "s to shuffle, y to deal card, n to pass" << endl;
	Computer computer;
	computer.Shuffle();
	bool shouldplay = true;
	while (shouldplay == true) {
		char tempchar;
		cin >> tempchar;
		if (tempchar == 'y') {
		computer.DealCard();
		}
		else if (tempchar == 's') {
			computer.Shuffle();
		}
		else if (tempchar == 'n') {
			computer.IfN();
		}
	}
}
