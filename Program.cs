using System;
using InspectorLib;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var inspector = new FunctionInsp();

            Console.WriteLine(inspector.GetCarInspection());
            Console.WriteLine(inspector.GetInspector());

            // Попробуем установить нового главного инспектора
            if (inspector.SetInspector("Иванов И.И."))
            {
                Console.WriteLine("Главный инспектор изменен на: " + inspector.GetInspector());
            }
            else
            {
                Console.WriteLine("Не удалось изменить главного инспектора.");
            }

            // Генерация госномера
            string number = inspector.GenerateNumber('A', 1234, 75);
            Console.WriteLine("Сгенерированный госномер: " + number);

            // Вывод списка сотрудников
            Console.WriteLine("Список сотрудников: ");
            foreach (var worker in inspector.GetWorker())
            {
                Console.WriteLine(worker);
            }

            // Добавление нового сотрудника
            inspector.AddWorker("Сидоров С.С.");
            Console.WriteLine("После добавления нового сотрудника:");

            // Вывод обновленного списка сотрудников
            foreach (var worker in inspector.GetWorker())
            {
                Console.WriteLine(worker);
            }
        }
    }
}
