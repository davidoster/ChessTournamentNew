using ChessTournament.domain;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.services
{
    class JSONDataInputService: CSVDataInputService
    {
        public JSONDataInputService(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                var json = reader.ReadToEnd();
                DataInput dataInput = JsonConvert.DeserializeObject<DataInput>(json);
                NoOfPlayers = dataInput.noOfPlayers;
                PlayerDetails = new PlayerDetails(dataInput.id, dataInput.ranking, dataInput.name);
            }
        }
    }
}
