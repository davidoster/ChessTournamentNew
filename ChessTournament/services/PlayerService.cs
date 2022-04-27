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
            var newPlayer = new RandomPlayer(_playerDetails);
            players.Add(newPlayer);
            var newId = 0;

            for (int i = 0; i < _noOfPlayers; i++)
            {
                bool notFound = true;
                //var newId = RandomService.Number(_playerDetails.Id.Min, _playerDetails.Id.Max);
                while (notFound) // για οσο δεν βρισκω αυτο το μοναδικο Id
                {
                    newId = RandomService.Number(_playerDetails.Id.Min, _playerDetails.Id.Max);
                    foreach (Player p in players)
                    {
                        if(p.Id == newId)
                        {
                            // just found out that the newId is not unique
                            break;
                        } 
                        if(players.Last() == p)
                        {
                            notFound = false;
                        }
                        // αν ειμαι στον τελευταίο RandomPlayer της λίστας και δεν έχω βρεί ακόμα το newId 
                        // τότε σιγουρα εχω μοναδικό Id
                        // notFound = false;
                    }
                
                }
                // προσθεσε εναν RandmoPlayer με αυτό το newId
                players.Add(new RandomPlayer(_playerDetails, newId));
            }
            return (players);

            //players.Add(new RandomPlayer());
            //players.Add(new RandomPlayer(_idDetails, _nameDetails, _rankingDetails));

            // how to make sure we have unique player ids
            //players.Add(new RandomPlayer(_playerDetails));
           
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
