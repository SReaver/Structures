using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public enum roles { Boss = 1,Manager =2, Klerk=3, }

    public class Sotrudnik
    {
        public string name { get; set; }
        public roles role { get; set; }
        public double salary { get; set; }
        public DateTime dateCome { get; set; }

        public void sotrudnikInfo()
        {
            Console.WriteLine($"Имя: {name}\nДолжность: {role}\nЗарплата: {salary}\nДата устройства: {dateCome}");
        }

    }
}
