using ChessTournament.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.services
{
    class PlayerService : IPlayerService
    {
        private int _noOfPlayers;
        private int[] _idDetails;
        private int[] _nameDetails;
        private int[] _rankingDetails;
        private PlayerDetails _playerDetails;

        public List<Player> Players { get; private set; }

        public PlayerService()
        {
            Initialize();
            Players = GeneratePlayers();
        }

        public PlayerService(int[] idDetails, int[] nameDetails, int[] rankingDetails, int noOfPlayers)
        {
            _noOfPlayers = noOfPlayers;
            Initialize(idDetails, nameDetails, rankingDetails);
            Players = GeneratePlayers();
        }

        public PlayerService(PlayerDetails playerDetails, int noOfPlayers)
        {
            _playerDetails = playerDetails;
            _noOfPlayers = noOfPlayers;
            Players = GeneratePlayers();
        }

        private List<Player> GeneratePlayers()
        {
            List<Player> players = new List<Player>();
            for(int i = 0; i < _noOfPlayers; i++)
            {
                //players.Add(new RandomPlayer());
                //players.Add(new RandomPlayer(_idDetails, _nameDetails, _rankingDetails));
                players.Add(new RandomPlayer(_playerDetails));
            }
            return (players);
        }

        public void Initialize()
        {
            _noOfPlayers = 10;
            
        }

        public void Initialize(int[] idDetails, int[] nameDetails, int[] rankingDetails)
        {
            _idDetails = idDetails;
            _nameDetails = nameDetails;
            _rankingDetails = rankingDetails;
        }
    }
}
