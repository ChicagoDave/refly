using System;
using System.Collections.Generic;
using System.Text;

using refly.models;
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

        public Player() { }

        public Player(IPlayerService playerService)
        {
            Player.playerService = playerService;
        }

        public static string Description
        {
            get
            {
                if (CurrentPlayerName == null)
                {
                    throw new Exception("Fluent interaction requires using .Create(playerName) first.");
                }

                return playerService.Get(CurrentPlayerName).Description;
            }
            set
            {
                PlayerModel player = playerService.Get(CurrentPlayerName);
                player.Description = value;
                playerService.Save(player);
            }
        }

        public static string Location
        {
            get
            {
                if (CurrentPlayerName == null)
                {
                    throw new Exception("Fluent interaction requires using .Create(playerName) first.");
                }

                return playerService.Get(CurrentPlayerName).Location;
            }
            set
            {
                PlayerModel player = playerService.Get(CurrentPlayerName);
                player.Location = value;
                playerService.Save(player);
            }
        }

        public static Player Create(string name)
        {
            playerService.Save(new PlayerModel() { Name = name });
            Player.CurrentPlayerName = name;

            return new Player(); // this is a throwaway instance
        }

    }
}
