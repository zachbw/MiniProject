using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    class Recipe
    {

        // Properties

        private FoodItem[] Ingredients = new FoodItem[5];
        private double _NumberOfServings;
        private int _ServingSize;


        public double NumberOfServings
        {
            get { return _NumberOfServings; }
        }


        public int ServingSize
        {
            get { return _ServingSize; }
            set { _ServingSize = value; _NumberOfServings = GetTotalGrams() / _ServingSize;  }
        }


        public double GetTotalGrams()
        {
            return 0;
        }


        public double NutritionalInfoPer100g()
        {
            return 0;
        }


        public double NutritionalInfoPerAvgServing()
        {
            return NutritionalInfoPer100g() * (_ServingSize / 100);
        }
    }
}
