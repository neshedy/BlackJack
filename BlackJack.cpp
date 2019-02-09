#include <iostream>
using namespace std;

int randnum;
int cardtotal = 0;
char drawcard;
bool shouldplay = true;
int numberofcards = 0;
int acecount = 0, twocount = 0, threecount = 0, fourcount = 0,
fivecount = 0, sixcount = 0, sevencount = 0, eightcount = 0,
ninecount = 0, tencount = 0, jackcount = 0, queencount = 0,
kingcount = 0;
int ace = 1, two = 2, three = 3, four = 4, five = 5, six = 6, seven = 7, 
	eight = 8, nine = 9, ten = 10, jack = 10, queen = 10, king = 10;
int deck[13] = {ace,two,three,four,five,six,seven,eight,nine,ten,jack,queen,king};

class PlayerClass {
	public:
	void drawcardy() {
		drawcardstart:
		randnum = rand() % 13;
		if (randnum == 0) {
			acecount++;
			if(acecount < 5)
				cout << "ace" << endl;
			else goto drawcardstart;
		}
		if (randnum == 1) {
			twocount++;
			if(twocount < 5)
				cout << deck[randnum] << endl;
			else goto drawcardstart;
		}
		if (randnum == 2) {
			threecount++;
			if(threecount < 5)
				cout << deck[randnum] << endl;
			else goto drawcardstart;
		}
		if (randnum == 3) {
			fourcount++;
			if(fourcount < 5)
				cout << deck[randnum] << endl;
			else goto drawcardstart;
		}
		if (randnum == 4) {
			fivecount++;
			if(fivecount < 5)
				cout << deck[randnum] << endl;
			else goto drawcardstart;
		}
		if (randnum == 5) {
			sixcount++;
			if(sixcount < 5)
				cout << deck[randnum] << endl;
			else goto drawcardstart;
		}
		if (randnum == 6) {
			sevencount++;
			if(sevencount < 5)
				cout << deck[randnum] << endl;
			else goto drawcardstart;
		}
		if (randnum == 7) {
			eightcount++;
			if(eightcount < 5)
				cout << deck[randnum] << endl;
			else goto drawcardstart;
		}
		if(randnum == 8) {
			ninecount++;
			if(eightcount < 5)
				cout << deck[randnum] << endl;
			else goto drawcardstart;
		}
		if(randnum == 9) {
			tencount++;
			if(tencount < 5)
				cout << deck[randnum] << endl;
			else goto drawcardstart;
		}
		if(randnum == 10) {
			jackcount++;
			if(jackcount < 5)
				cout << "jack" << endl;
			else goto drawcardstart;
		}
		if(randnum == 11) {
			queencount++;
			if(queencount < 5)
				cout << "queen" << endl;
			else goto drawcardstart;
		}
		if(randnum == 12) {
			kingcount++;
			if(kingcount < 5)
				cout << "king" << endl;
			else goto drawcardstart;
		}
		cardtotal += deck[randnum];
	}
};

void ifn() {
	if (cardtotal == 21 ||
		(cardtotal == 11 && acecount == 1))
			cout << "21" << endl;
	else if (cardtotal > 21)
		cout << "bust" << endl;
	else if (cardtotal < 21)
		cout << cardtotal << endl;
	cout << "acecount = " << acecount << endl;
	cardtotal = 0;
	acecount = 0;
}

int main() {
	PlayerClass playerObj;
	while (shouldplay == true) {
		cout << "Draw Card y/n" << endl;
		cin >> drawcard;
		if (drawcard == 'y') {
			playerObj.drawcardy();
		}
		else if (drawcard == 'n') {
			ifn();
		}
	}
	int tempint;
	cin >> tempint;
	return 0;
}
