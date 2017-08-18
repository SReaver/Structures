using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structures
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Сколько будет сотрудников: ");
            int ans = Int32.Parse(Console.ReadLine());
            List<Sotrudnik> LS = new List<Sotrudnik>();
            for (int i = 1; i <= ans; i++)
              {
                Sotrudnik s = new Sotrudnik();
                Console.Write("Введите имя сотрудника: ");
                s.name = Console.ReadLine();
                Console.Write("Введите должность сотрудника: ");
                s.role = Console.ReadLine();
                Console.Write("Введите зарплату сотрудника: ");

                double tDouble=0;
                double.TryParse(Console.ReadLine(), out tDouble);
                s.salary = tDouble;
                Console.Write("Введите дату устройства сотрудника: ");
                DateTime dt = DateTime.Now;
                DateTime.TryParse(Console.ReadLine(), out dt);
                s.dateCome = dt;
                LS.Add(s);
                Console.WriteLine();

            }

            foreach (var item in LS)
            {
                item.sotrudnikInfo();
            }

            foreach (var item in LS)
            {

            }

        }
    }
}
