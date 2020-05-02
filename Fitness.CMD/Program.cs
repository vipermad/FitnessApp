using Fitness.BL.Controller;
using Fitness.BL.Model;
using System;


namespace Fitness.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение Fitness.");
            Console.WriteLine("Введите имя пользователя:");
            var name = Console.ReadLine();

            Console.WriteLine("Введите пол:");
            var gender = Console.ReadLine();

            Console.WriteLine("Введите дату рождения:");
            var birthDate = DateTime.Parse(Console.ReadLine()); //TODO: переписать

            Console.WriteLine("Введите ваш вес:");
            var weigth = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите ваш рост:");
            var heigth = double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthDate, weigth, heigth);
            userController.Save();


        }
    }
}
