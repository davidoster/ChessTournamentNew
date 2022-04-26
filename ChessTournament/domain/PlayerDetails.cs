﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.domain
{
    class PlayerDetails
    {
        private MinMax _id;

        public MinMax Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private MinMax _ranking;

        public MinMax Ranking
        {
            get { return _ranking; }
            set { _ranking = value; }
        }

        private NameMinMax _name;

        public NameMinMax Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}