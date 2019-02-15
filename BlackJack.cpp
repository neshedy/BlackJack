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
		};
		
		void InitializeValue() {
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
};

int main() {
	Computer computer;
	computer.Shuffle();
	computer.InitializeValue();
	bool shouldplay = true;
	while (shouldplay == true) {
	char tempchar;
	cin >> tempchar;
	if (tempchar == 'y') {
	computer.DealCard();
	}
	else if (tempchar == 'n') {
                if (computer.player.handValue < 11 && computer.player.aceCount > 0)
                {
                    cout << computer.player.handValue + 10 << endl;
                }
                else if (computer.player.handValue == 21 ||
                         (computer.player.handValue == 11 && computer.player.aceCount == 1))
                {
                    cout << "21" << endl;
                }
                else if (computer.player.handValue < 21)
                {
                    cout << computer.player.handValue << endl;
                }
                else if (computer.player.handValue > 21)
                {
                    cout << "Bust" << endl;
                }
                computer.player.handValue = 0;
				computer.player.aceCount = 0;
			}
		}
	int tempint;
	cin >> tempint;
	return 0;
}
