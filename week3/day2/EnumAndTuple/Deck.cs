using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace EnumAndTuple
{
    class Deck
    {
        public Card card;
        public List<Card> DeckList { get; set; }

        public Deck()
        {
            this.DeckList=new List<Card>();
            Array rank = Enum.GetValues(typeof(Card.CardRank));
            Array suit = Enum.GetValues(typeof(Card.CardSuit));
            foreach (var r in rank)
            {
                foreach (var s in suit)
                {                  
                    if ((Card.CardSuit)s == Card.CardSuit.hearts || (Card.CardSuit)s == Card.CardSuit.diamonds)
                    {
                        this.DeckList.Add(new Card((Card.CardRank)r,(Card.CardSuit)s,Card.CardColor.red));
                    }
                    else
                    {
                        Card c=new Card((Card.CardRank)r, (Card.CardSuit)s, Card.CardColor.black);
                        this.DeckList.Add(c);
                    }
                }
            }
        }
        public void ShuffleDeck()
        {
            List<Card> shuffled=new List<Card>();
            Random r=new Random();
            while (this.DeckList.Count!=0)
            {
                int ind = r.Next(this.DeckList.Count);
                shuffled.Add(this.DeckList[ind]);
                this.DeckList.RemoveAt(ind);
            }

            this.DeckList = shuffled;
        }

        public Card PullFirst()
        {
            return this.DeckList[0];
        }

        public Card PullLast()
        {
            return this.DeckList[this.DeckList.Count - 1];

        }

        public Card PullRandom()
        {
            Random r= new Random();
            Card c= this.DeckList[r.Next(this.DeckList.Count)];
            Console.WriteLine(c.Rank+" "+(int)c.Rank);
            return c;
        }
    }
}
