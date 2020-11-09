using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TeamDistribution
{
	class Program
	{
		static void Main(string[] args)
		{

			var listOfStudents = File.ReadAllLines(@"C:\Users\andre\source\repos\Tendencias de desarrollo de aplicaciones\Students.txt").ToList();
			var listOfTopics = File.ReadAllLines(@"C:\Users\andre\source\repos\Tendencias de desarrollo de aplicaciones\Class Topics.txt").ToList();
			int studentCount = listOfStudents.Count;
			int topicCount = listOfTopics.Count;

			Console.WriteLine("Number of groups you wish to create: ");
			int numberOfTeams = int.Parse(Console.ReadLine());
			int numberOfMembers = (listOfStudents.Count / numberOfTeams) + 1;
			int numberOfTopics = (listOfTopics.Count/ numberOfTeams);

			listOfStudents = listOfStudents.OrderBy(i => Guid.NewGuid()).ToList();
			listOfTopics = listOfTopics.OrderBy(i => Guid.NewGuid()).ToList();

			var TeamsOfStudents = new string[numberOfTeams, numberOfMembers];
			var TeamsAndTopics = new string[numberOfTeams, numberOfMembers];

			if (listOfStudents !=null && listOfTopics !=null && numberOfTeams >= 1)
			{
				if (listOfStudents.Count > numberOfTeams && listOfTopics.Count > numberOfTeams)
				{
					for (int i = 0; i < numberOfTeams && studentCount > 0; i++)
					{
						for (int j = 0; j < numberOfMembers && studentCount > 0; j++)
						{
							TeamsOfStudents[i, j] = listOfStudents[--studentCount];
						}
					}

					for (int i = 0; i < numberOfTeams && topicCount > 0; i++)
					{
						for (int j = 0; j < numberOfTopics && topicCount > 0; j++)
						{
							TeamsAndTopics[i, j] = listOfTopics[--topicCount];
						}
					}


					for (int i = 0; i < numberOfTeams; i++)
					{
						Console.WriteLine("Grupo {0}:                Topics", i + 1);

						for (int j = 0; j < numberOfMembers; j++)
						{
							Console.WriteLine("{0}                  {1} ", TeamsOfStudents[i, j], TeamsAndTopics[i, j]);
						}
						Console.WriteLine("\n");
					}

				}

			}
		Console.ReadLine();
		}
	}
}
