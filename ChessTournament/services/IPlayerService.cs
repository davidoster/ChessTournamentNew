using ChessTournament.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.services
{
    interface IPlayerService
    {
        void Initialize();
        void Initialize(int[] idDetails, int[] nameDetails, int[] rankingDetails);
        //List<Player> GeneratePlayers();
    }
}
