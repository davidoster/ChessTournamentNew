using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessTournament.services
{
    class RandomService
    {
        private static Random _rand = new Random((int)DateTime.Now.Ticks);
        public static int Number(int min, int max)
        {
            int result = 0;
            result = _rand.Next(min, max);
            return (result);
        }

        public static string Name(int min, int max, int noOfChars)
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
