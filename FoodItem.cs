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

		private int _Protein;
		public int Protein
		{
			get { return _Protein; }
			set { _Protein = value; }
		}



		public FoodItem()
		{
		}


		public FoodItem(string FoodId, string Name, int Energy, int Protein)
		{
			_FoodId = FoodId;
			_Name = Name;
			_Energy = Energy;
			_Protein = Protein;
		}
	}
}