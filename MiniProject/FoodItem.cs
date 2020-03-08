using System;

namespace MiniProject
{
	public class FoodItem
	{
		// Properties
		private string _FoodId;
		public string FoodId
		{
			get { return _FoodId; }
			set { _FoodId = value; }
		}

		private string _Name;
		public string Name
		{
			get { return _Name; }
			set { _Name = value; }
		}

		private int _Energy;
		public int Energy
		{
			get { return _Energy; }
			set { _Energy = value; }
		}

		private double _Protein;
		public double Protein
		{
			get { return _Protein; }
			set { _Protein = value; }
		}



		public string print()
		{
			return "Id: " + FoodId + " | Name: " + Name + " | Energy: " + Energy + " | Protein: " + Protein;
		}


		public FoodItem()
		{
		}


		public FoodItem(string FoodId, string Name)
		{
			_FoodId = FoodId;
			_Name = Name;
		}


		public FoodItem(string[] PropertyArray)
		{
			_FoodId = PropertyArray[0];
			_Name = PropertyArray[1];
			_Energy = Convert.ToInt16(PropertyArray[2]);
			_Protein = Convert.ToDouble(PropertyArray[3]);
		}
	}
}