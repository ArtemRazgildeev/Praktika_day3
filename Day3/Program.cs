namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("fio", 10000, 1);
            List<Employee> employees = new List<Employee>()
            {
                new ("Бирюков Леонтий Евсеевич", 20000, 1),
                new ("Маслов Флор Адольфович", 17040, 2),
                new ("Ковалёв Валерий Агафонович", 350000, 5),
                new ("Королёв Ян Федотович", 40000, 4),
                new ("Шарапов Лаврентий Давидович", 50000, 3),
                new ("Горбачёва Властилина Владленовна", 20000, 1),
                new ("Киселёва Азалия Васильевна", 17040, 2),
                new ("Симонова Эльвира Кирилловна", 350000, 5),
                new ("Ковалёва Илена Михаиловна", 40000, 4),
                new ("Шарова Радослава Владиславовна", 50000, 3)
            };
            TaskA();
            TaskB();
            TaskC();
            TaskD();
            TaskE();
            TaskF();
            void TaskA()
            {
                Console.WriteLine("Task A");
                foreach (var emp in employees)
                {
                    
                    Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}, Отдел: {emp.Otdel}");
                }
            }
            void TaskB()
            {
                Console.WriteLine("Task B");
                double summa = 0;
                foreach (var emp in employees)
                {
                    summa += emp.Salary;
                }
                Console.WriteLine($"Сумма затрат на ЗП в месяц: {summa}");
            }
            void TaskC()
            {
                Console.WriteLine("Task C");
                double min = 99999999999;
                foreach (var emp in employees)
                {
                    if (emp.Salary < min)
                    {
                        min = emp.Salary;
                    }
                }
                Console.WriteLine("Минимальная ЗП " + min);
            }
            void TaskD()
            {
                Console.WriteLine("Task D");
                double max = 0;
                foreach (var emp in employees)
                {
                    if (emp.Salary > max)
                    {
                        max = emp.Salary;
                    }
                }
                Console.WriteLine("Максимальная ЗП " + max);
            }
            void TaskE()
            {
                Console.WriteLine("Task E");
                int count=0;
                double summa = 0;
                foreach (var emp in employees)
                {
                    count++;
                    summa += emp.Salary;
                }
                Console.WriteLine($"Среднее значение ЗП: {summa/count}");
            }
            void TaskF()
            {
                Console.WriteLine("Task F");
                foreach (var emp in employees)
                {
                    Console.WriteLine("ФИО " + emp.Fio);
                }
                Console.ReadKey();
            }
        }
        }
}