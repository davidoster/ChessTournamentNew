using ChessTournament.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.services
{
    class Tournament
    {
        public void Start()
        {
            int[] idDetails = new int[2];
            idDetails[0] = 200;
            idDetails[1] = 300;

            int[] nameDetails = new int[3];
            nameDetails[0] = 65;
            nameDetails[1] = 91;
            nameDetails[2] = 4;

            int[] rankingDetails = new int[2];
            rankingDetails[0] = 1000;
            rankingDetails[1] = 2001;

            //PlayerService playerService = new PlayerService();
            PlayerService playerService1 = new PlayerService(idDetails, nameDetails, rankingDetails, 15);
            
            foreach(RandomPlayer player in playerService1.Players)
            {
                Console.WriteLine(player);
            }

            // GameService starts
            // print the games

            // Run the games from the gameService
            // printResults
            // store the game results - DIFFICULT
        }
    }
}
