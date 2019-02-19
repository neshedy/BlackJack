/*
 * A simple blackjack program in java
 * 
 */
package blackjackjava;

import java.util.Scanner;

public class BlackJackJAVA {

    public static void main(String[] args) {
        Dealer dealer = new Dealer();
        System.out.println("y to deal card, n to pass, s to shuffle");
        boolean shouldplay = true;
        while (shouldplay == true) {
            char tempchar;
            Scanner s = new Scanner(System.in);
            tempchar = (s.nextLine()).charAt(0);
            switch(tempchar) {
                case 'y': dealer.IfY();
                break;
                case 'n': dealer.IfN();
                break;
                case 's': {dealer.Shuffle(); dealer.InitializeValue();}
                break;
            }
        }
    }
}
