using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._11._2022
{
    internal class Task
    {
        public string description;
        public DateTime deadline;
        public string executor;
        public string[] status = new string[4] { "назначена", "в работе", "на проверке", "выполнена" };


        public void Techtask(int num)
        {
            Console.WriteLine("Введите описание задачи номер : " + num);
            description = Console.ReadLine();

            Console.WriteLine("Введите дедлайн");
            deadline = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Введите имя исполнителя задачи");
            executor = Console.ReadLine();


        }
    }
}
