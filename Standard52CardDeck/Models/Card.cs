using System;
using System.Collections.Generic;
using System.Text;

namespace Standard52CardDeck.Models
{
    public class Card
    {
        public StandardSuits Suit { get; set; }
        public StandardColors Color { get; set; }
        public StandardValues Value { get; set; }

        public Card() { }
        public Card(StandardValues value, StandardSuits suit)
        {
            Value = value;
            Suit = suit;
            switch (suit)
            {
                case StandardSuits.Heart:
                    Color = StandardColors.Red;
                    break;
                case StandardSuits.Diamond:
                    Color = StandardColors.Red;
                    break;
                case StandardSuits.Spade:
                    Color = StandardColors.Black;
                    break;
                case StandardSuits.Club:
                    Color = StandardColors.Black;
                    break;
            }
        }
    }

}
