[![Build Status](https://travis-ci.org/ChicagoDave/refly.svg?branch=master)](https://travis-ci.org/ChicagoDave/refly)

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
				.Instead(Verb.Drop, "cloak", () => {
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
				.Instead(Verb.Take, "cloak", () => {
					Item("bar").Has({ "light" });
				});

		Create
			.Room("foyer")
			.Title("Foyer of the Opera House")
			.Description("You are standing in a spacious hall, splendidly decorated in red and gold, with glittering chandeliers overhead. The entrance from the street is to the north, and there are doorways south and west
