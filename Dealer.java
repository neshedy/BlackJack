package blackjackjava;

import java.util.*;
import java.util.concurrent.ThreadLocalRandom;

public class Dealer {
    public Card[] card = new Card[52];
    public int handValue = 0;
    public int cardCount = 0;
    public static int aceCount = 0;
    public static char[] value = {' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',
    ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',};
    public static char suiteA[] = {'D','C','H','S','D','C','H','S','D','C','H','S','D','C','H','S','D','C','H','S','D','C','H','S','D','C','H','S','D','C','H','S','D','C','H','S','D','C','H','S','D','C','H','S','D','C','H','S','D','C','H','S'};
    public static char typeA[] = {'A','2','3','4','5','6','7','8','9','T','J','Q','K','A','2','3','4','5','6','7','8','9','T','J','Q','K','A','2','3','4','5','6','7','8','9','T','J','Q','K','A','2','3','4','5','6','7','8','9','T','J','Q','K',};
    Dealer() {
    Shuffle();
    InitializeValue();
    }
    static void Shuffle() {
        // If running on Java 6 or older, use `new Random()` on RHS here
        Random rnd = ThreadLocalRandom.current();
        for (int i = suiteA.length - 1; i > 0; i--)
        {
            int index = rnd.nextInt(i + 1);
            // Simple swap
            char a = suiteA[index];
            suiteA[index] = suiteA[i];
            suiteA[i] = a;
        }
        for (int i = suiteA.length - 1; i > 0; i--)
        {
            int index = rnd.nextInt(i + 1);
            // Simple swap
            char a = typeA[index];
            typeA[index] = typeA[i];
            typeA[i] = a;
        }
    }
    public static void InitializeValue(){
        for (int i = 0; i < 52; i++) {
            switch(typeA[i]) {
                case 'A': value[i] = 1;
                break;
                case '2': value[i] = 2;
                break;
                case '3': value[i] = 3;
                break;
                case '4': value[i] = 4;
                break;
                case '5': value[i] = 5;
                break;
                case '6': value[i] = 6;
                break;
                case '7': value[i] = 7;
                break;
                case '8': value[i] = 8;
                break;
                case '9': value[i] = 9;
                break;
                case 'T': value[i] = 10;
                break;
                case 'J': value[i] = 10;
                break;
                case 'Q': value[i] = 10;
                break;
                case 'K': value[i] = 10;
                break;
            }
        }
    }
    public void DealCard() {
       if (cardCount < 52) {
            System.out.print(typeA[cardCount]);
            System.out.print(suiteA[cardCount]);
        }
       else {
           Shuffle();
           InitializeValue();
           cardCount = 0;
       }
    }
    public void IfY() {
    DealCard();
    handValue += value[cardCount];
    cardCount++;
    if (value[cardCount] == 1)
        aceCount++;
    }
    public void IfN() {
    if(handValue < 11 && aceCount >= 1) {
        System.out.println(handValue + 10);
    }
    else if(handValue < 21) {
        System.out.println(handValue);
    }
    else if(handValue == 21 || (handValue == 11 && aceCount == 1)) {
        System.out.println("21");
    }
    else if(handValue > 21) {
        System.out.println("Bust");
    }
    aceCount = 0;
    handValue = 0;
    }
}
