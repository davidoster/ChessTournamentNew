using ChessTournament.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.domain
{
    class RandomPlayer : Player
    {
        
        private PlayerDetails _playerDetails;
        private int[] _idDetails;
        private int[] _rankingDetails;
        private int[] _nameDetails;

        public RandomPlayer()
        {
            _idDetails = new int[2];
            _idDetails[0] = 1;
            _idDetails[1] = 201;
            this.Id = RandomService.Number(_idDetails[0], _idDetails[1]);

            _nameDetails = new int[3];
            _nameDetails[0] = 65;
            _nameDetails[1] = 91;
            _nameDetails[2] = 4;
            this.Name = RandomService.Name(_nameDetails[0], _nameDetails[1], _nameDetails[2]);

            _rankingDetails = new int[2];
            _rankingDetails[0] = 1000;
            _rankingDetails[1] = 2001;
            this.Ranking = RandomService.Number(_rankingDetails[0], _rankingDetails[1]);
        }

        public RandomPlayer(int[] idDetails, int[] nameDetails, int[] rankingDetails)
        {
            _idDetails = idDetails;
            _nameDetails = nameDetails;
            _rankingDetails = rankingDetails;
            this.Id = RandomService.Number(_idDetails[0], _idDetails[1]);
            this.Name = RandomService.Name(_nameDetails[0], _nameDetails[1], _nameDetails[2]);
            this.Ranking = RandomService.Number(_rankingDetails[0], _rankingDetails[1]);
        }

        public RandomPlayer(PlayerDetails playerDetails)
        {
            _playerDetails = playerDetails;
            Id = RandomService.Number(_playerDetails.Id.Min, _playerDetails.Id.Max);
            Ranking = RandomService.Number(_playerDetails.Ranking.Min, _playerDetails.Ranking.Max);
            Name = RandomService.Name(_playerDetails.Name.Min, _playerDetails.Name.Max, _playerDetails.Name.Length);
 
        }

        public RandomPlayer(PlayerDetails playerDetails, int id)
        {
            _playerDetails = playerDetails;
            Id = id;
            Ranking = RandomService.Number(_playerDetails.Ranking.Min, _playerDetails.Ranking.Max);
            Name = RandomService.Name(_playerDetails.Name.Min, _playerDetails.Name.Max, _playerDetails.Name.Length);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Player { Id: ").Append(Id).Append("\tName: ")
              .Append(Name).Append("\tRanking: ").Append(Ranking).Append(" }");
            return sb.ToString();
        }

        
    }
}
