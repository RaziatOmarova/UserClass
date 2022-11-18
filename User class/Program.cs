using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new List<User>
             {
                 new User("Георгий", "Миронов",23),
                 new User("Щльга", "Сорокина",16),
                 new User("Михаил", "Соколов",17),
                 new User("Софья", "Цветкова",20)
             };
            var age = users.Where(item => item.Age >= 18).ToList();
            int n = 0;
            foreach(var item in age)
            {
                n++;
            }
            Console.WriteLine($"Пользователи 18 лет и старше: {n}");
            Console.ReadKey();
        }
    }
}
