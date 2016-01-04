/// <summary>
/// hw2
/// Fabio Gottlicher
/// A01647928
/// </summary>
using System;

namespace ShowClass
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Yay, car class!");

			Car car1 = new Car(6, 193, BodyStyle.SEDAN, "BMW", "328i", 1998);

			Console.WriteLine ("You car has " + car1.getHp () + " hp");
		}
	}
}
