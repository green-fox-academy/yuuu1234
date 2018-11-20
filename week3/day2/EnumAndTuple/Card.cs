using System;
using System.Collections.Generic;
using System.Text;

namespace EnumAndTuple
{
    class Card
    {
        public CardColor Color { get; set; }
        public CardRank Rank { get; set; }
        public CardSuit Suit { get; set; }
        public enum CardColor
        {
            red,black
        }

        public enum CardSuit
        {
            clubs, diamonds, hearts, spades
        }

        public enum CardRank
        {
          A=1,two,three,four,five,six,seven,eight,nine,ten, J, Q, K
        }

        public Card(CardRank rank,CardSuit suit,CardColor color)
        {
            this.Rank = rank;
            this.Color = color;
            this.Suit = suit;
        }
    }
}
