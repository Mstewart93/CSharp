using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




    

public class deck {

            public deck() { //constructor name is always the same as the class
                //We are going to create a nested loop for our purposes it will enable use to go through all 13 faces and pair them with the 4 suits
                Cards = new List<card>();
                List<string> Suits = new List<string>() {"Clubs", "Hearts","Diamonds", "Spades"};
                List<string> Faces = new List<string>() 
                {
            
                    "Two", "Three", "Four", "Five", "Six", "Seven",
                     "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
                };
                foreach (string face in Faces ) 
                {
                    foreach (string suit in Suits )
                    {
                        card card = new card();
                        card.Suit = suit;
                        card.Face = face; 
                        Cards.Add(card);
                        //this creates a new card, that has each face and each suit for a total of 52 cards.
                    }
                }
               
            }
            public List<card> Cards {get; set; }
}