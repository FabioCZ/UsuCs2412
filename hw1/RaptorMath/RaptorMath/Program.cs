using System;

/// <summary>
/// Fabio Gottlicher, A01647928, CS 2412-002
/// Main Class of Raptor Math homework. Everything is inside of this.
/// </summary>
using System.Runtime.InteropServices;


namespace RaptorMath
{
	class MainClass
	{
		/// <summary>
		/// The entry point of the program, where the program control starts and ends.
		/// </summary>
		/// <param name="args">The command-line arguments.</param>
		public static void Main (string[] args)
		{
			bool run = true;
			string name;

			Console.WriteLine ("Raptor Quiz 2014, by Fabio Gottlicher");
			Console.Write ("Enter name: ");
			name = Console.ReadLine ();

			// This loop executes the option choosing and calls and appropriate function, eh, sorry, method to perform choice.
			while (run) 
			{
				int choice;

				Console.WriteLine ("");
				Console.WriteLine ("How would " + name + " survive?");
				Console.WriteLine ("#1: Running");
				Console.WriteLine ("#2: Hiding");
				Console.WriteLine ("#3: Just give up");
				Console.Write ("Enter choice (1-3): ");
				int.TryParse (Console.ReadLine (), out choice);

				switch (choice) 
				{
				case 1:
					runFromRaptor (name);
					break;
				case 2:
					hideFromRaptor (name);
					break;
				case 3:
					run = false;
					Console.WriteLine ("Giving up.");
					break;
				default:
					Console.WriteLine ("Wrong choice. You just got eaten. Know your numbers.");
					break;
				}
			}
		}

		/// <summary>
		/// This method does stuff for running from Raptor.
		/// </summary>
		/// <param name="name">Name of the person</param>
		public static void runFromRaptor (string name)
		{
			bool parsedProperly;
			double maxSpeed = 10.0f;
			double speed = 0;
			double startUserPosition = 0;
			double userPosition = 0;
			double raptorPosition = 0;
			bool caught = false;
			double timeElapsed =0;

			if (0 == name.ToLower ().CompareTo ("usain bolt")) 
			{
				maxSpeed = 12.27;
			}
			Console.Write ("Enter your top speed, with a max of: " + maxSpeed + " m/s: ");
			parsedProperly = Double.TryParse (Console.ReadLine (), out speed);
			if (speed > maxSpeed || speed < 0 || !parsedProperly) 
			{
				Console.WriteLine ("Invalid speed.");
				return;
			}

			Console.Write ("Enter starting distance from raptor, in meters: ");
			parsedProperly = Double.TryParse (Console.ReadLine (), out startUserPosition);
			if (startUserPosition < 0 || !parsedProperly) 
			{
				Console.WriteLine ("Invalid distance.");
				return;
			}

			//Brute-force coding this because simplicity
			while (!caught) 
			{
				userPosition = startUserPosition + speed * timeElapsed;
				if (timeElapsed < 7) 
				{
					raptorPosition = 0.5 * 4 * timeElapsed * timeElapsed;
				} 
				else 
				{
					//raptor has passed 78.125m once he is up to full speed.
					raptorPosition = 78.125 + 25 * timeElapsed;
				}
				if (raptorPosition >= userPosition) 
				{
					// Does C# suck at doing float operations just like java? well, if yeah, this should fix it.
					timeElapsed = Math.Round (timeElapsed, 1);	
					Console.WriteLine (name + " would survive approximately " + (timeElapsed) + " seconds.");
					return;
				}

				timeElapsed+=0.1;
			}
		}

		/// <summary>
		/// This method does stuff for hiding from raptor
		/// </summary>
		/// <param name="name">Name of the person</param>
		public static void hideFromRaptor (string name)
		{
			char[,] positions = new char[3, 2];
			bool parsedProperly;
			int userRoom;
			int userRoomX;
			int userRoomY;
			int raptorRoom;
			int raptorRoomX;
			int raptorRoomY;
			int distBetween;
			double timeToDie = 0;

			Console.Write ("Enter " + name + "'s  room (1-6): ");
			parsedProperly = int.TryParse (Console.ReadLine (), out userRoom);
			if (userRoom < 0 || userRoom > 6 || !parsedProperly) 
			{
				Console.WriteLine ("Wrong room number");
				return;
			}

			Console.Write ("Enter Raptor's room (1-6): ");
			int.TryParse (Console.ReadLine (), out raptorRoom);
			if (raptorRoom < 0 || raptorRoom > 6 || !parsedProperly) 
			{
				Console.WriteLine ("Wrong room number");
				return;
			}

			if (raptorRoom == userRoom) 
			{
				if (0 == name.ToLower ().CompareTo ("chuck norris")) 
				{
					Console.WriteLine ("Chuck and raptor are in the same room. Raptor dies.");
					return;
				}
				Console.WriteLine ("You and raptor are in the same room. Tough luck, you die immediately.");
				return;
			}

			findRoomIndexes (userRoom, out userRoomX, out userRoomY);
			positions [userRoomX, userRoomY] = 'u';

			findRoomIndexes (raptorRoom, out raptorRoomX, out raptorRoomY);
			positions [raptorRoomX, raptorRoomY] = 'r';

			for (int y = 0; y < 2; y++) 
			{
				for (int x = 0; x < 3; x++) {
					Console.Write ("|" + positions [x, y] + "|");
				}
				Console.WriteLine ("");
			}

			distBetween = Math.Abs (raptorRoomX - userRoomX) + Math.Abs (raptorRoomY - userRoomY);
			Console.WriteLine ("Dist between: " + distBetween);

			if (distBetween == 1) 
			{
				timeToDie = 5;
			}
			else if (distBetween == 2) 
			{
				timeToDie = 7.5;
			}
			else if (distBetween == 3) 
			{
				timeToDie = 8.75;
			} 

			if (0 == name.ToLower ().CompareTo ("chuck norris")) 
			{
				Console.WriteLine ("Chuck Norris executes a roundhouse kick on the raptor in " + timeToDie + " minutes. Raptor dies.");
			} else {
				Console.Write (name + " has " + timeToDie + " minutes left before (s)he is eaten by the raptor.");
			}

		}

		public static void findRoomIndexes (int roomNumber, out int x, out int y)
		{
			y = roomNumber <= 3 ? 0 : 1;

			if (roomNumber % 3 == 1)
				x = 0;
			else if (roomNumber % 3 == 2)
				x = 1;
			else
				x = 2;
		}
	}
}
