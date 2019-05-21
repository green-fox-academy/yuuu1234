using System;
using System.Collections.Generic;
using System.Text;

namespace EnumAndTuple
{
    class Game
    {
        public int OpponentScore { get; set; }
        public int MyScore { get; set; }
        public bool Stop;
        public Deck TheDeck { get; set; }
        public Game()
        {
            this.TheDeck=new Deck();
            SetOpponentScore();
            this.Stop = false;
            this.MyScore = 0;
        }
        public void SetOpponentScore()
        {
            Random r=new Random();
            this.OpponentScore = r.Next(15, 22);
        }

        public void AskDraw()
        {
            while (this.Stop == false)
            {
                Console.WriteLine("Continue[1] or stop[2]");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    this.Stop = false;
                    this.TheDeck.ShuffleDeck();
                    Console.WriteLine("pull first[1]\npull last[2]\npull random[3]");
                    int pull = int.Parse(Console.ReadLine());
                    if (pull == 1)
                    {
                        this.MyScore += (int)this.TheDeck.PullFirst().Rank;
                        Console.WriteLine("card--> " + this.TheDeck.PullFirst().Color.ToString() +
                                          " " + this.TheDeck.PullFirst().Suit.ToString() + " " +
                                          this.TheDeck.PullFirst().Rank.ToString()+"\n" +
                                          "your score: "+ this.MyScore);
                        JudegeEveryRound();
                        
                    }
                    else if (pull == 2)
                    {                        
                        this.MyScore += (int)this.TheDeck.PullLast().Rank;
                        Console.WriteLine("card--> " +this.TheDeck.PullLast().Color.ToString() +
                                          " " + this.TheDeck.PullLast().Suit.ToString() + " " +
                                         this.TheDeck.PullLast().Rank.ToString() + "\n" +
                                          "your score: " + this.MyScore);
                        JudegeEveryRound();
                        
                    }
                    else if (pull == 3)
                    {
                        Card random = this.TheDeck.PullRandom();
                        this.MyScore += (int)random.Rank;
                        Console.WriteLine("card--> " + random.Color.ToString() +
                                          " " + random.Suit.ToString() + " " +
                                          random.Rank.ToString() + "\n" +
                                          "your score: " + this.MyScore);
                        JudegeEveryRound();

                    }

                }
                else if (answer == 2)
                {
                    Console.WriteLine("Game stops manually, the oppnents score is "+ this.OpponentScore+
                                      " your score is "+this.MyScore);
                    JudgeWhenStop();                   
                    this.Stop = true;
                    

                }
            }
        }

        public void JudegeEveryRound()
        {
            if (this.MyScore > 21)
            {
                this.Stop = true;
                Console.WriteLine("Lost!! your score "+this.MyScore+" already above 21!");
            }
        }

        public void JudgeWhenStop()
        {
            if (this.MyScore < this.OpponentScore)
            {
                Console.WriteLine("Lost!! your score is below the opponent's score ");
            }

            if ((this.MyScore > this.OpponentScore) & (this.MyScore <= 21))
            {
                Console.WriteLine("Congratulations!! you won!!");
            }
        }
      
    }
}
