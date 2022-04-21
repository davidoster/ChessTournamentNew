using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.domain
{
    abstract class Player
    {
        //public Player()
        //{

        //}

        //public Player(int id, string name, int ranking)
        //{
        //    this.Id = id;
        //    this.Name = name;
        //    this.Ranking = ranking;
        //}

        // Id, Name, Ranking
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name.ToUpper(); }
            set { _name = value; }
        }

        private int _ranking;

        public int Ranking
        {
            get { return _ranking; }
            set { _ranking = value; }
        }

        public abstract override string ToString();

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
