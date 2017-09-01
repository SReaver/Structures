using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public enum eda { Рыба=2, Мышь=1, Сосиска=0, Колбаса=3, Курица=5 }
    public class Cat
    {
        public int hungryLevel { get; set; }
        public int EatSomething(int food)
        {
            hungryLevel +=  food;
            return hungryLevel;
        }
    }
}
