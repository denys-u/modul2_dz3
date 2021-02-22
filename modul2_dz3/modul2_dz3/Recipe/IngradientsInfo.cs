using modul2_dz3.notification_ingredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace modul2_dz3.Recipe
{
    public class IngradientsInfo
    {
        public  Ingradients[] _calories;
        public void CaloriesInfo()
        {
            _calories = new Ingradients[]
            {
                new Ingradients{Name="Кальмары", Calories=122, Gram=100},
                new Ingradients{Name="Креветки", Calories=99, Gram=100},
                new Ingradients{Name="Капуста", Calories=24, Gram=200},
                new Ingradients{Name="Маслины", Calories=115, Gram=100},
                new Ingradients{Name="Яйцо", Calories=155},
                new Ingradients{Name="Перец", Calories=10, Gram=2},
                new Ingradients{Name="Масло растительное", Calories=177, Gram=20},
                new Ingradients{Name="Горчица", Calories=4, Gram=15},
                new Ingradients{Name="Морская соль", Calories=0, Gram=3}
            };
        }
        public Ingradients[] GetAll()
        {
            return _calories;
        }
    }
}
