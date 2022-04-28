using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessTournament.domain;

namespace ChessTournament.services
{
    class CSVDataInputService
    {
        private PlayerDetails _playerDetails;

        public PlayerDetails PlayerDetails
        {
            get { return _playerDetails; }
            set { _playerDetails = value; }
        }

        private int _noOfPlayers;

        public int NoOfPlayers
        {
            get { return _noOfPlayers; }
            set { _noOfPlayers = value; }
        }

        public CSVDataInputService()
        {

        }

        public CSVDataInputService(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                var counter = 0;
                MinMax id;
                MinMax ranking;
                NameMinMax name;
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (counter > 0)
                    {
                        //var line = reader.ReadLine();
                        var values = line.Split(';');
                        NoOfPlayers = Convert.ToInt32(values[0]);
                        id = new MinMax(Convert.ToInt32(values[1]), Convert.ToInt32(values[2]));
                        ranking = new MinMax(Convert.ToInt32(values[3]), Convert.ToInt32(values[4]));
                        name = new NameMinMax(Convert.ToInt32(values[5]), Convert.ToInt32(values[6]), Convert.ToInt32(values[7]));
                        PlayerDetails = new PlayerDetails(id, ranking, name);
                    }
                    counter++;
                }
            }
            Console.WriteLine(NoOfPlayers);
            Console.WriteLine(PlayerDetails);
        }
    }
}
