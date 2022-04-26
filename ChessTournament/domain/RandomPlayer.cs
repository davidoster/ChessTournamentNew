using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.domain
{
    class RandomPlayer : Player
    {
        private static Random _rand = new Random((int)DateTime.Now.Ticks);
        private PlayerDetails _playerDetails;
        private int[] _idDetails;
        private int[] _rankingDetails;
        private int[] _nameDetails;

        public RandomPlayer()
        {
            _idDetails = new int[2];
            _idDetails[0] = 1;
            _idDetails[1] = 201;
            this.Id = CreateRandomNumber(_idDetails[0], _idDetails[1]);

            _nameDetails = new int[3];
            _nameDetails[0] = 65;
            _nameDetails[1] = 91;
            _nameDetails[2] = 4;
            this.Name = CreateRandomName(_nameDetails[0], _nameDetails[1], _nameDetails[2]);

            _rankingDetails = new int[2];
            _rankingDetails[0] = 1000;
            _rankingDetails[1] = 2001;
            this.Ranking = CreateRandomNumber(_rankingDetails[0], _rankingDetails[1]);
        }

        public RandomPlayer(int[] idDetails, int[] nameDetails, int[] rankingDetails)
        {
            _idDetails = idDetails;
            _nameDetails = nameDetails;
            _rankingDetails = rankingDetails;
            this.Id = CreateRandomNumber(_idDetails[0], _idDetails[1]);
            this.Name = CreateRandomName(_nameDetails[0], _nameDetails[1], _nameDetails[2]);
            this.Ranking = CreateRandomNumber(_rankingDetails[0], _rankingDetails[1]);
        }

        public RandomPlayer(PlayerDetails playerDetails)
        {
            _playerDetails = playerDetails;
            Id = CreateRandomNumber(_playerDetails.Id.Min, _playerDetails.Id.Max);
            Ranking = CreateRandomNumber(_playerDetails.Ranking.Min, _playerDetails.Ranking.Max);
            Name = CreateRandomName(_playerDetails.Name.Min, _playerDetails.Name.Max, _playerDetails.Name.Length);
 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Player { Id: ").Append(Id).Append("\tName: ")
              .Append(Name).Append("\tRanking: ").Append(Ranking).Append(" }");
            return sb.ToString();
        }

        private int CreateRandomNumber(int min, int max)
        {
            int result = 0;
            result = _rand.Next(min, max);
            return (result);
        }

        private string CreateRandomName(int min, int max, int noOfChars)
        {
            string result = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < noOfChars; i++)
            {
                sb.Append((char)_rand.Next(min, max));
            }
            result = sb.ToString();
            return (result);
        }
    }
}
