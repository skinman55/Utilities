using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var tg = new TeamGenerator();
            tg.Run();
        }
    }

    class TeamGenerator
    {
        private const int NUMBER_OF_TEAMS = 3;

        private readonly List<string> allTeamMembers = new List<string>();
        private Dictionary<string,List<string>> generatedTeams = new Dictionary<string, List<string>>();
        public void Run()
        {
            ParseInput();
            allTeamMembers.Shuffle();
            GenerateTeams();
            PrintResults();
            Console.ReadLine();
        }

        private void PrintResults()
        {
            var output = new StringBuilder();
            foreach (var team in generatedTeams)
            {
                output.AppendLine(team.Key);
                output.AppendLine("---------------");
                foreach (var teammember in team.Value)
                {
                    output.AppendLine(teammember);
                }
                output.AppendLine("---------------");
                output.AppendLine("");
            }

            Console.WriteLine(output.ToString());
            File.WriteAllText("output.txt", output.ToString());
        }

        private void GenerateTeams()
        {
            var teamSize = Math.Round(allTeamMembers.Count / (decimal)NUMBER_OF_TEAMS);

            for (var x = 1; x <= NUMBER_OF_TEAMS; x++)
            {
                var team = new List<string>();
                team.AddRange(allTeamMembers.Take((int)Math.Min(teamSize,allTeamMembers.Count)));

                foreach (var teamMember in team)
                {
                    allTeamMembers.Remove(teamMember);
                }

                generatedTeams.Add($"Team{x}",team);
            }
        }

     

        private void ParseInput()
        {
            var input = File.ReadAllLines("input.txt");
            foreach (var line in input)
            {
                allTeamMembers.Add(line);
            }
        }
    }
}

