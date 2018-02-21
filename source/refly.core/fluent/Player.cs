using System;
using System.Collections.Generic;
using System.Text;

using refly.core.models;
using refly.core.repository;

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
        public static string CurrentPlayerName { get; set; }

        public static string Description
        {
            get
            {
                return StoryRepository.PlayerData[CurrentPlayerName].Description;
            }
            set
            {
                StoryRepository.PlayerData[CurrentPlayerName].Description = value;
            }
        }

        public static string Location
        {
            get
            {
                return StoryRepository.PlayerData[CurrentPlayerName].Location;
            }
            set
            {
                StoryRepository.PlayerData[CurrentPlayerName].Location = value;
            }
        }

        public static void Has(List<string> switches)
        {
            foreach(string sw in switches)
            {
                string newSwitch = sw.Remove('!');
                if (sw.Substring(0,1) == "!")
                {
                    StoryRepository.PlayerData[CurrentPlayerName].Switches.Add(newSwitch, false);
                } else
                {
                    StoryRepository.PlayerData[CurrentPlayerName].Switches.Add(newSwitch, true);
                }
            }
        }

        public static bool Has(string switchName)
        {
            return StoryRepository.PlayerData[CurrentPlayerName].Switches[switchName];
        }

        public static Player Create(string name)
        {
            StoryRepository.PlayerData.Add(name, new PlayerModel() { Name = name });
            Player.CurrentPlayerName = name;

            return new Player(); // this is a throwaway instance
        }

    }
}
