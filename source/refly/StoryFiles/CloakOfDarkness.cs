using refly.core.fluent;

namespace refly.StoryFiles
{
    public class CloakOfDarkness
    {
        public CloakOfDarkness()
        {

            // CLOAK OF DARKNESS

            Story.Create
                .Title("Cloak of Darkness")
                .Headline("An example IF story")
                .Author("David Cornelson")
                .Version("1.0.0")
                .CreateDate("20-Feb-2018")
                .MaximumScore(2);

            //         Create
            //             .Player("player")
            //             .Description("As handsome as ever!")
            //             .Location("foyer")
            //             .Has({ "general" });

            //         Create
            //             .Item("cloak")
            //             .Title("velvet cloak")
            //             .Adjectives({ "handsome","dark","black","velvet","satin","cloak"})
            //	.Description("A handsome cloak, of velvet trimmed with satin, and slightly spattered with raindrops.Its blackness is so deep that it almost seems to suck light from the room.")
            //	.Has({ "general" })
            //	.Wearable();

            //Create
            //	.Rule("dropping the cloak rule")
            //		.Instead(VerbDrop, "cloak", () => {
            //			if (Player.Location("cloakroom"))
            //				if (Item("cloak").Has("general"))
            //				{
            //					Room("bar").Has({ "light" });
            //					Item("cloak").Loses("general");
            //					Player.Score(1);
            //				}
            //			} else {
            //				Story.Print("#notice#", "This isn't the best place to leave a smart cloak lying around.");
            //			}
            //		});

            //Create
            //	.Rule("taking the cloak rule")
            //		.Instead(VerbTake, "cloak", () => {
            //			Item("bar").Has({ "light" });
            //		});

            //Create
            //	.Room("foyer")
            //	.Title("Foyer of the Opera House")
            //	.Description("You are standing in a spacious hall, splendidly decorated in red and gold, with glittering chandeliers overhead. The entrance from the street is to the north, and there are doorways south and west.")
            //	.Exit(CompassSouth, "bar")
            //	.Exit(CompassWest, "cloakroom")
            //	.Exit(CompassNorth, "#notice#", "You've only just arrived, and besides, the weather outside seems to be getting worse.")
            //	.Has({ "light" });

            //Create
            //	.Room("cloakroom")
            //	.Title("Cloakroom")
            //	.Description("The walls of this small room were clearly once lined with hooks, though now only one remains. The exit is a door to the east.")
            //	.Exit(CompassEast, "foyer")
            //	.Has({ "light" })

            //Create
            //	.Scenery("hook")
            //	.Title("small brass hook")
            //	.Description(() => {
            //		Story.PrintPartial("#notice#", "It's just a small brass hook, ");
            //	});
        }
    }
}
