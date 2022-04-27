using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessTournament.services;
using ChessTournament.domain;

namespace ChessTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfPlayers = 30;
            MinMax Id = new MinMax(100, 200);
            MinMax Ranking = new MinMax(1000, 2000);
            NameMinMax Name = new NameMinMax(65, 91, 4);

            PlayerDetails playerDetails = new PlayerDetails(Id, Ranking, Name);
            Tournament tournament = new Tournament(playerDetails, noOfPlayers);
            tournament.Start(); 

            //Player p1 = CreateRandomPlayer(); // new Player(1, "Pasparov", 0);
            //Console.WriteLine(p1);
            

        }

        //public static Player CreateRandomPlayer()
        //{
        //    return (new RandomPlayer());
        //    //return (new Player(CreateRandomNumber(1,201), CreateRandomName(65,91,4), 
        //    //                   CreateRandomNumber(1000,2001)));
        //}

        //public static int CreateRandomNumber(int min, int max)
        //{
        //    int result = 0;
        //    Random rand = new Random();
        //    result = rand.Next(min, max);
        //    return (result);
        //}

        //public static string CreateRandomName(int min, int max, int noOfChars)
        //{
        //    string result = "";
        //    StringBuilder sb = new StringBuilder();
        //    Random rand = new Random();
        //    for(int i = 0; i < noOfChars; i++)
        //    {
        //        sb.Append((char)rand.Next(min, max));
        //    }
        //    result = sb.ToString();
        //    return (result);
        //}
    }
}
