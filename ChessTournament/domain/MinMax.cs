using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.domain
{
    class MinMax
    {
        private int _min;

        public int Min
        {
            get { return _min; }
            set { _min = value; }
        }

        private int _max;

        public int Max
        {
            get { return _max; }
            set { _max = value; }
        }

        public MinMax(int min, int max)
        {
            Min = min; // 200
            Max = max; // 100
            // conditional statements
            if(min > max) // specific business logic
            {
                Max = min + max;
            }
        }

        public override string ToString()
        {
            return ($"MinMax {{ Min: {Min} Max: {Max} }}");
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
