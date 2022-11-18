using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._11._2022
{  
    
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IT компании был задан проект - создать сайт");
            Console.WriteLine("Над проектом работает 10 человек: " + '\n' + "Вадим" + '\n' + "Руслан" + '\n' + "Коля" + '\n' + "Кирилл" + '\n' + "Настя" + '\n' + "Максим" + '\n' + "Дима" + '\n' + "Алина" + '\n' + "Яна");
            Console.WriteLine("Кратко опишите проект ");
            string description = Console.ReadLine();
            Console.WriteLine("Введите дедлайн");
            DateTime deadline = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите имя заказчика");
            string customer = Console.ReadLine();
            Console.WriteLine("Вы являетесь ответсвенным за выполнение проекта.Введите ваше имя");
            string teamlead = Console.ReadLine();
            Project project = new Project();
            project.Description = description;
            project.Deadline = deadline;
            project.Customer = customer;
            project.Teamlead = teamlead;

            Task task1 = new Task();
            task1.Techtask(1);
            Task task2 = new Task();
            task2.Techtask(2);
            Task task3 = new Task();
            task3.Techtask(3);
            Task task4 = new Task();
            task4.Techtask(4);
            Task task5 = new Task();
            task5.Techtask(5);
            Task task6 = new Task();
            task6.Techtask(6);
            Task task7 = new Task();
            task7.Techtask(7);
            Task task8 = new Task();
            task8.Techtask(8);
            Task task9 = new Task();
            task9.Techtask(9);
            Task task10 = new Task();
            task10.Techtask(10);
        }
    }
}
