using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.domain
{
    class NameMinMax: MinMax
    {
        private int _length;

        public int Length
        {
            get { return _length; }
            set { _length = value; }
        }

        public NameMinMax(int min, int max, int length): base(min, max)
        {
            _length = length;
        }

        public override string ToString()
        {
            return($"NameMinMax {{ Min: {Min} Max: {Max} Length: {Length} }}");
        }

    }
}
