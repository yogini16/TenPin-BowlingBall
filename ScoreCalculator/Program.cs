
using BowlingBall;
using BowlingBall.Rules;
using System;
using System.Collections.Generic;

namespace ScoreCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Bowling Game!");

            var game = new Game();
            CalculateScore(game);
            Console.WriteLine($"Your final score is: {game.Score}");
                   
                
            
        }


        private static void CalculateScore(Game game)
        {
            Console.WriteLine("Enter the first roll of the frame:");
            var firstRoll = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second roll of the frame:");
            var secondRoll = int.Parse(Console.ReadLine());
            var ruleEngine = new RuleEngine();
            game.Frames = new List<Frame>();
            var frame = new Frame
            {
                FirstRoll = firstRoll,
                SecondRoll = secondRoll
            };

            if (frame.FirstRoll == 10)
            {
                Console.WriteLine("STRIKE!");
            }

            if (frame.FirstRoll + frame.SecondRoll == 10)
            {
                Console.WriteLine("SPARE!");
            }

            game.Frames.Add(frame);

            ruleEngine.CalculateScore(game);
        }
    }
}
