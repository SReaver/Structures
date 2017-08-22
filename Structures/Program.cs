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
                Console.Write("Введите должность сотрудника: 1 - Босс, 2 - Менеджер, 3 - Клерк : ");
                var srole = Int32.Parse(Console.ReadLine());
                s.role = (roles)Enum.Parse(typeof(roles), srole.ToString());
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
            Console.WriteLine("Все сотрудники");
            foreach (var item in LS)
            {
                item.sotrudnikInfo();
            }
            Console.WriteLine("Отсортированный список менеджеров");
            List<Sotrudnik> Mangers = LS.Where(w => w.role == roles.Manager).ToList();
            List<Sotrudnik> Klerks = LS.Where(w => w.role == roles.Klerk).ToList();
            var temp = Mangers.Sum(s => s.salary) / (Klerks.Sum(s => s.salary) / Klerks.Count());
            List<Sotrudnik> ManZarplats = Mangers.Where(W => W.salary >= temp).ToList();

            foreach (var item in ManZarplats.OrderBy(w => w.name))
                item.sotrudnikInfo();
            Console.WriteLine("Все сотрудники, принятые на работу позже босса");

            var b = LS.FirstOrDefault(w => w.role == roles.Boss);
            foreach (var item in LS.Where(w=>w.role!=b.role && w.dateCome>b.dateCome))
            {

                item.sotrudnikInfo();
            }
        }
    }
}
