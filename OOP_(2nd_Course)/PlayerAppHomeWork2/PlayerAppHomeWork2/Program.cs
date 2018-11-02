using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAppHomeWork2
{
    class Program
    {
        static void PrintPlayerProfile(Player player)
        {
            Console.WriteLine("*** Player Profile ***");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"Name:\t{player.FirstName} {player.LastName}");
            Console.WriteLine($"Age:\t{player.Age}");
            Console.WriteLine($"Weight:\t{player.Weight}");
            Console.WriteLine($"Height:\t{player.Height}");
            Console.WriteLine($"Club:\t{player.Club}");
            Console.WriteLine($"Possition: {player.Possition}");
            Console.WriteLine($"Shirt Number: {player.ShirtNumber}");
            Console.WriteLine($"Nationality: {player.Nationality}");
            Console.ResetColor();
            Console.WriteLine(new string('*', 23));
        }
        static void Main(string[] args)
        {
            Competitor club1 = new Competitor();
            club1.ClubName = "Barcelona";
            Competitor club2= new Competitor();
            club2.ClubName = "Juventus";

            Player player1 = new Player();
            player1.FirstName = "Lionel";
            player1.LastName = "Messi";
            player1.Height = 169;
            player1.Weight = 72;
            player1.Born = 1987;
            player1.ShirtNumber = 10;
            player1.Possition = "forward";
            player1.Club = "Barcelona";
            player1.Nationality = "Argentina";

            Player player2 = new Player();
            player2.FirstName = "Gerard";
            player2.LastName = "Pique";
            player2.Height = 193;
            player2.Weight = 85;
            player2.Born = 1987;
            player2.ShirtNumber = 3;
            player2.Possition = "DEFENDER";
            player2.Club = "Barcelona";
            player2.Nationality = "Spain";

            Player player3 = new Player()
            {
                FirstName = "Cristiano",
                LastName = "Ronaldo",
                Height = 185,
                Weight = 80,
                Born = 1985,
                ShirtNumber = 7,
                Possition = "DEFENDER",
                Club = "Juventus",
                Nationality = "Portugal",
            }; 

            Player player4 = new Player()
            {
                FirstName = "Sami",
                LastName = "Khedira",
                Height = 189,
                Weight = 90,
                Born = 1987,
                ShirtNumber = 6,
                Possition = "MIDFIELDER",
                Club = "Juventus",
                Nationality = "Germany",
            };
            Player[] playerList = { player1, player2, player3, player4 };
            
            string[] list1 = club1.GetClubPlayers(playerList, club1);
            string[] list2 = club1.GetClubPlayers(playerList, club2);

            PrintPlayerProfile(player1);
            PrintPlayerProfile(player2);
            PrintPlayerProfile(player3);
            Console.Write("Barcelona Players List: ");
           for (int i = 0; i < list1.Length; i++)
           {
                Console.Write($"{list1[i]}, ");
           }
            Console.WriteLine(); // *****************************
            Console.Write("Juventus Players List: ");
            for (int j = 0; j < list2.Length; j++)
            {
                Console.Write($"{list2[j]}, ");
            }


            Console.ReadKey();
        }
    }
}
