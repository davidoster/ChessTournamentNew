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
        private PlayerDetails _playerDetails;

        public PlayerDetails PlayerDetails
        {
            get { return _playerDetails; }
            set { _playerDetails = value; }
        }

        private int _noOfPlayers;

        public int NoOfPlayers
        {
            get { return _noOfPlayers; }
            set { _noOfPlayers = value; }
        }


        public Tournament(PlayerDetails playerDetails, int noOfPlayers)
        {
            PlayerDetails = playerDetails;
            NoOfPlayers = noOfPlayers;
        }

        public void Start()
        {
            //int[] idDetails = new int[2];
            //idDetails[0] = 200;
            //idDetails[1] = 300;

            //int[] nameDetails = new int[3];
            //nameDetails[0] = 65;
            //nameDetails[1] = 91;
            //nameDetails[2] = 4;

            //int[] rankingDetails = new int[2];
            //rankingDetails[0] = 1000;
            //rankingDetails[1] = 2001;

            //PlayerService playerService = new PlayerService();
            //PlayerService playerService1 = new PlayerService(idDetails, nameDetails, rankingDetails, 15);
            PlayerService playerService = new PlayerService(_playerDetails, _noOfPlayers);
            
            foreach(RandomPlayer player in playerService.Players)
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
