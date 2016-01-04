using System;
using ShowClass;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ShowClass
{

	public enum BodyStyle 
	{
		HATCHBACK,
		COUPE,
		SEDAN,
		ESTATE,
		CONVERTIBLE
	}

	public class Car
	{
		private int numOfCylinders;
		private int hp;
		private BodyStyle bodyStyle;
		private string brand;
		private string model;
		private int year;


		public Car ()
		{
			//default boring car
			this.numOfCylinders = 4;
			this.hp = 136;
			this.bodyStyle = BodyStyle.SEDAN;
			this.brand = "Toyota";
			this.model = "Camry";
			this.year = 1999;

		}

		public Car(int numOfCylinders, int hp, BodyStyle bodyStyle, string brand, string model, int year)
		{
			int currYear = Convert.ToInt32(DateTime.Now.Year.ToString());
			this.numOfCylinders = numOfCylinders;
			this.hp = hp;
			this.bodyStyle = bodyStyle;
			this.brand = brand;
			this.model = model;
			if (year > 1894 || year <= currYear) 
			{
				this.year = year;
			}
		}

		// Setters and Getters
		public int getNumOfCylinders()
		{
			return this.numOfCylinders;
		}

		public int getHp()
		{
			return this.hp;
		}

		public BodyStyle getBodyStyle()
		{
			return this.bodyStyle;
		}

		public string  getBrand()
		{
			return this.brand;
		}

		public string getModel()
		{
			return this.model;
		}

		public int getYear()
		{
			return this.year;
		}

		public void setNumOfCylinders(int numOfCylinders)
		{
			this.numOfCylinders = numOfCylinders;
		}

		public void setHp(int hp)
		{
			this.hp = hp;
		}

		public void setBodyStyle(BodyStyle bodyStyle)
		{
			this.bodyStyle = bodyStyle;
		}

		public void setBrand(string brand)
		{
			this.brand = brand;
		}

		public void setModel(string model)
		{
			this.model = model;
		}

		public void setYear(int year){
			this.year = year;
		}

		//Methods
		public void turbochargeIt()
		{
			//pretty vague value, but it's pretty representative of average
			hp += 80;
		}

		public void riceIt()
		{
			hp = 0;
		}

	}
}

