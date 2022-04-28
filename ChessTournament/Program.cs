using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessTournament.services;
using ChessTournament.domain;

namespace ChessTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = @"C:\Users\george.pasparakis\source\repos\ChessTournamentNew\ChessTournament\TournamentData.json";
                //@"C:\Users\george.pasparakis\source\repos\ChessTournamentNew\ChessTournament\TournamentData.csv";
            Tournament tournament = new Tournament(new JSONDataInputService(fileName));
            tournament.Start();
            Console.ReadKey();
        }

        
    }
}
