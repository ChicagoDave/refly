# refly

refly is an experimental fluent C# Interactive Fiction platform. The /refly/StoryFiles/CloakOfDarkness.cs file is a very early and rough draft of how I think the implementation might look.

The platform borrows from Inform 6, 7, and FyreVM, but will compile to a .NET executable (for now).

## Design Points

* Fluent Syntax - Everything is an object within an object.

            // CLOAK OF DARKNESS

            Story
                .Title("Cloak of Darkness")
                .Headline("A basic IF demonstration")
                .Author("David Cornelson")
                .CreateDate("19-Feb-2018")
                .Version(1)
                .MaxScore(2)
                .Initialize({

            });

            Create
                .Player("player")
                .Description("As handsome as ever!")
                .Location("foyer")
                .Has({ "general" });

            Create
                .Item("cloak")
                .Title("velvet cloak")
                .Adjectives({ "handsome","dark","black","velvet","satin","cloak"})
				.Description("A handsome cloak, of velvet trimmed with satin, and slightly spattered with raindrops.Its blackness is so deep that it almost seems to suck light from the room.")
				.Has({ "general" })
				.Wearable();
  
			Create
				.Rule("dropping the cloak rule")
					.Instead(VerbDrop, "cloak", () => {
						if (Player.Location("cloakroom"))
							if (Item("cloak").Has("general"))
							{
								Room("bar").Has({ "light" });
								Item("cloak").Loses("general");
								Player.Score(1);
							}
						} else {
							Story.Print("#notice#", "This isn't the best place to leave a smart cloak lying around.");
						}
					});

			Create
				.Rule("taking the cloak rule")
					.Instead(VerbTake, "cloak", () => {
						Item("bar").Has({ "light" });
					});
			  
			Create
				.Room("foyer")
				.Title("Foyer of the Opera House")
				.Description("You are standing in a spacious hall, splendidly decorated in red and gold, with glittering chandeliers overhead. The entrance from the street is to the north, and there are doorways south and west.")
				.Exit(CompassSouth, "bar")
				.Exit(CompassWest, "cloakroom")
				.Exit(CompassNorth, "#notice#", "You've only just arrived, and besides, the weather outside seems to be getting worse.")
				.Has({ "light" });

			Create
				.Room("cloakroom")
				.Title("Cloakroom")
				.Description("The walls of this small room were clearly once lined with hooks, though now only one remains. The exit is a door to the east.")
				.Exit(CompassEast, "foyer")
				.Has({ "light" })

			Create
				.Scenery("hook")
				.Title("small brass hook")
				.Description(() => {
					Story.PrintPartial("#notice#", "It's just a small brass hook, ");
				});

* Templated output system - All printing requires a token (though this may change). The idea is that any given template would have a list of tokens to be replaced. When all of the processing is completed for a given turn, the print service will construct the template from all available token replacements and emit it to the console. Future versions could possible emit web templates, but that's not an initial criteria for V1. Even so, the print service will be entitely replaceable.
* Text aggregation - The author can identify text parts and an internal service will put all of a "turn's" stored text together properly. So there could be a sentence prefix, a sentence section, and a sentence suffix. Sentences themselves can be ordered or prioritized by context. The text aggregation service will be replaceable.
* Rules similar to Inform 7

