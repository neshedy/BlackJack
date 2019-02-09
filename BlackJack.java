package javaapplication4;

import java.util.*;
import java.io.*;
import java.util.Scanner;
import java.util.Random;

public class JavaApplication4 {
    public static int ace = 1, jack = 10, queen = 10, king = 10;
    public static int bjarray[] = {ace,2,3,4,5,6,7,8,9,10,
        jack,queen,king};
    public static int acecount = 0, twocount = 0, threecount = 0,
            fourcount = 0, fivecount = 0, sixcount = 0, sevencount = 0,
            eightcount = 0, ninecount = 0, tencount = 0, jackcount = 0,
            queencount = 0, kingcount = 0;
    public static int numcount = 0;
    
    public static void main(String[] args) {
        JavaApplication4 myObj = new JavaApplication4();
        char drawcardchar = ' ';
        boolean shouldplay = true;
        while (shouldplay == true) {
        Scanner newscanner = new Scanner(System.in);
        System.out.println("Draw card? y/n");
        String drawcardstring = newscanner.nextLine();
        for (int i = 0; i < drawcardstring.length(); i++) {
        drawcardchar = drawcardstring.charAt(i);
        }
        if (drawcardchar == 'y') {
            ify();
        }
        else if (drawcardchar == 'n') {
            ifn();
            if (numcount == 21 || (numcount == 20 && acecount == 1) ||
                    (numcount == 11 && acecount == 2)) {
                System.out.println("21");
            }
            else if (numcount < 21) {
                System.out.println(numcount);
            }
            else if (numcount > 21) {
                System.out.println("bust");
            }
            numcount = 0;
            acecount = 0; twocount = 0; threecount = 0;
            fourcount = 0; fivecount = 0; sixcount = 0; sevencount = 0;
            eightcount = 0; ninecount = 0; tencount = 0; jackcount = 0;
            queencount = 0; kingcount = 0;
            
            }
        }
    }

    public static int RandNum() {
    Random rand = new Random();
    int num = rand.nextInt(13);
    return num;
    }
    
    public static void ify() {
        System.out.println("y");
        int cardnum;
        cardnum = RandNum();
        boolean yesplay = true;
        boolean yesplaytwo = true;
        while (yesplaytwo == true) {
        while (yesplay == true) {
            if (cardnum == 0 && acecount < 5){
                System.out.println("ace");
                acecount++;
                numcount += bjarray[cardnum];
            }
            else if (acecount > 4)
                break;
            if (cardnum == 1 && twocount < 5) {
                System.out.println(cardnum);
                twocount++;
                numcount += bjarray[cardnum];
            }
            else if (twocount > 4)
                break;
            if (cardnum == 2 && threecount < 5) {
                System.out.println(cardnum);
                threecount++;
                numcount += bjarray[cardnum];
            }
            else if (threecount > 4)
                break;
            if (cardnum == 3 && threecount < 5) {
                System.out.println(cardnum);
                fourcount++;
                numcount += bjarray[cardnum];
            }
            else if (fourcount > 4)
                break;
            if (cardnum == 4 && fivecount < 5) {
                System.out.println(cardnum);
                fivecount++;
                numcount += bjarray[cardnum];
            }
            else if (fivecount > 4)
                break;
            if (cardnum == 5 && sixcount < 5) {
                System.out.println(cardnum);
                fivecount++;
                numcount += bjarray[cardnum];
            }
            else if (sixcount > 4)
                break;
            if (cardnum == 6 && sevencount < 5) {
                System.out.println(cardnum);
                sevencount++;
                numcount += bjarray[cardnum];
            }
            else if (sevencount > 4)
                break;
            if (cardnum == 7 && eightcount < 5) {
                System.out.println(cardnum);
                eightcount++;
                numcount += bjarray[cardnum];
            }
            else if (eightcount > 4)
                break;
            if (cardnum == 8 && ninecount < 5) {
                System.out.println(cardnum);
                ninecount++;
                numcount += bjarray[cardnum];
            }
            else if (ninecount > 4)
                break;
            if (cardnum == 9 && tencount < 5) {
                System.out.println(cardnum);
                tencount++;
                numcount += bjarray[cardnum];
            }
            else if (tencount > 4)
                break;
            if (cardnum == 10 && jackcount < 5) {
                System.out.println("jack");
                jackcount++;
                numcount += bjarray[cardnum];
            }
            else if (jackcount > 4)
                break;
            if (cardnum == 11 && queencount < 5) {
                System.out.println("queen");
                queencount++;
                numcount += bjarray[cardnum];
            }
            else if (queencount > 4)
                break;
            if (cardnum == 12 && kingcount < 5) {
                System.out.println("king");
                kingcount++;
                numcount += bjarray[cardnum];
            }
            else if (kingcount > 4)
                break;
            break;
        }
        break;
    }
    }
    
    public static void ifn() {
        System.out.println("n");
    }
}
