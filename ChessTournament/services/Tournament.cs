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

        public Tournament(UserInputService userInputService)
        {
            //PlayerDetails = userInputService.PlayerDetails;
            //NoOfPlayers = userInputService.NoOfPlayers;
        }

        public Tournament(CSVDataInputService csvDataInputService)
        {
            NoOfPlayers = csvDataInputService.NoOfPlayers;
            PlayerDetails = csvDataInputService.PlayerDetails;
        }

        public Tournament(JSONDataInputService jSONDataInputService)
        {
            //NoOfPlayers = jSONDataInputService.NoOfPlayers;
            //PlayerDetails = jSONDataInputService.PlayerDetails;
        }
        
        public void Start()
        {
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
