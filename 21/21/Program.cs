using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{

    static void Main(string[] args)

    {
        deck deck = new deck();
        //deck.Cards = new List<card>();    THIS would enable you to fill it out one by one
       // card cardOne = new card();        HOWEVER, that would be a lot for 52 cards there is an easier way.
        //cardOne.Face =  "Queen";
        //cardOne.Suit = "Spades";

       // deck.Cards.Add(cardOne); 

       foreach(Card in deck.Cards)

    Console.WriteLine(deck.Cards[1].Face + "Of" + deck.Cards[1].Suit);
    Console.ReadLine();

    }



}


