using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    public class Sotrudnik
    {
        public string name { get; set; }
        public string role { get; set; }
        public double salary { get; set; }
        public DateTime dateCome { get; set; }

        public void sotrudnikInfo()
        {
            Console.WriteLine($"Имя: {name}\nФамилия: {role}\nЗарплата: {salary}\nДата устройства: {dateCome}");
        }

    }
}
