using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputLines = int.Parse(Console.ReadLine());
            List<Team> teamList = new List<Team>();
            int count = 1;
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }
                string[] tempParse = input.Split(new char[] { '-' });
                string member = tempParse[0];
                
                if (count <= 2)
                {
                    string team = tempParse[1];
                    if (teamList.Any(d => d.Creator == member))
                    {
                        Console.WriteLine($"- {member} cannot create another team!");
                    }
                    else if (teamList.Any(x => x.Name == team))
                    {
                        Console.WriteLine($"Team {team} was already created!");
                    }
                    else
                    {
                        Team theTeam = new Team { Name = team, Creator = member, Members = new List<string>() };
                        teamList.Add(theTeam);
                        Console.WriteLine($"Team {team} has been created by {member}!");
                    }
                    count++;
                }
                else
                {
                    string team = tempParse[1].Trim('>');
                    if (!teamList.Any(x => x.Name == team))
                    {
                        Console.WriteLine($"Team {team} does not exist!");
                    }
                    else if (teamList.Any(x => x.Creator == member))
                    {
                        continue;
                    }
                    else
                    {
                        Team currentTeam = teamList.First(x => x.Name == team);
                        if (currentTeam.Members.Contains(member))
                        {
                            Console.WriteLine($"Member {member} cannot join team {team}!");
                        }
                        else if (currentTeam.Creator == member)
                        {
                            Console.WriteLine($"Member {member} cannot join team {team}!");
                        }
                        else
                        {
                            currentTeam.Members.Add(member);
                        }
                    }
                    count++;
                }
            }

            foreach (var team in teamList.OrderByDescending(x => x.Members.Count).ThenBy(s => s.Name).Where(k => k.Members.Count > 0))
            {
                Console.WriteLine(team.Name);
                Console.WriteLine($"- {team.Creator}");
                team.Members.Sort();
                foreach (var member in team.Members.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamList.OrderBy(s => s.Name).Where(g => g.Members.Count == 0))
            {
                Console.WriteLine(team.Name);
            }
        }
    }
    class Team
    {
        public string Creator { get; set; }
        public List<string> Members { get; set; }
        public string Name { get; set; }
    }
}
