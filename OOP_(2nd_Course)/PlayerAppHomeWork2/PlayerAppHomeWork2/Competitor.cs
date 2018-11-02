using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerAppHomeWork2
{
    class Competitor
    {
        //private string clubName;
        public string ClubName { set; get; }
        public Competitor()
        {

        }
        private Player player = new Player();

        public string[] GetClubPlayers(Player[] player, Competitor club)
        {
            int count = 0;

            for (int i = 0; i < player.Length; i++)
            {
                if (player[i].Club == club.ClubName)
                {
                    count++;
                }
            }
            string[] playersList = new string[count];
            for (int i = 0; i < playersList.Length;)
            {
                for (int j = i; j < player.Length; j++)
                {
                    if (player[j].Club == club.ClubName && i < playersList.Length)
                    {
                        playersList[i] = $"{player[j].FirstName} {player[j].LastName}";
                        i++;
                    }
                    
                }

            }
            return playersList;

        }

    }
}
