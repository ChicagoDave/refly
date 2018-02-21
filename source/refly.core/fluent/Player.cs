using System;
using System.Collections.Generic;
using System.Text;

using refly.core.models;
using refly.core.services;

namespace refly.core.fluent
{
    //         Create
    //             .Player("Adventurer")
    //                      indexed on name using Dictionary<string,PlayerModel>
    //             .Description("As handsome as ever!")
    //             .Location("foyer")
    //             .Has({ "general" })
    //             .PlayerCharacter(true);
    public class Player
    {
        static IPlayerService playerService { get; set; } = null;

        public static string CurrentPlayerName { get; set; }

        public static string Description
        {
            get
            {
                return PlayerRepository.PlayerData[CurrentPlayerName].Description;
            }
            set
            {
                PlayerRepository.PlayerData[CurrentPlayerName].Description = value;
            }
        }

        public static string Location
        {
            get
            {
                return PlayerRepository.PlayerData[CurrentPlayerName].Location;
            }
            set
            {
                PlayerRepository.PlayerData[CurrentPlayerName].Location = value;
            }
        }

        public static void Has(List<string> switches)
        {
            foreach(string sw in switches)
            {
                string newSwitch = sw.Remove('!');
                if (sw.Substring(0,1) == "!")
                {
                    PlayerRepository.PlayerData[CurrentPlayerName].Switches.Add(newSwitch, false);
                } else
                {
                    PlayerRepository.PlayerData[CurrentPlayerName].Switches.Add(newSwitch, true);
                }
            }
        }

        public static bool Has(string switchName)
        {
            return PlayerRepository.PlayerData[CurrentPlayerName].Switches[switchName];
        }

        public static Player Create(string name)
        {
            playerService = config.AutofacConfig.Container.Resolve<IPlayerService>();

            PlayerRepository.PlayerData.Add(name, new PlayerModel() { Name = name });
            Player.CurrentPlayerName = name;

            return new Player(); // this is a throwaway instance
        }

    }
}
