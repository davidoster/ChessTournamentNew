using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.domain
{
    class DataInput
    {
        public int noOfPlayers { get; set; }
        public MinMax id { get; set; }
        public MinMax ranking { get; set; }
        public NameMinMax name { get; set; }

        public override string ToString()
        {
            return ($"{noOfPlayers} {id} {ranking} {name}");
        }
    }
}
