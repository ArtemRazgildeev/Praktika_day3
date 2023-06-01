using System;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("fio", 10000, 1);
            List<Employee> employees = new List<Employee>()
            {
                new ("Бирюков Леонтий Евсеевич", 770000, 1),
                new ("Маслов Флор Адольфович", 17040, 2),
                new ("Ковалёв Валерий Агафонович", 350000, 5),
                new ("Королёв Ян Федотович", 40000, 4),
                new ("Шарапов Лаврентий Давидович", 50000, 3),
                new ("Горбачёва Властилина Владленовна", 20000, 1),
                new ("Киселёва Азалия Васильевна", 69040, 2),
                new ("Симонова Эльвира Кирилловна", 9000, 5),
                new ("Ковалёва Илена Михаиловна", 990000, 4),
                new ("Шарова Радослава Владиславовна", 640000, 3)
            };
            void Day3()
            {
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
                    int count = 0;
                    double summa = 0;
                    foreach (var emp in employees)
                    {
                        count++;
                        summa += emp.Salary;
                    }
                    Console.WriteLine($"Среднее значение ЗП: {summa / count}");
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
                Console.WriteLine("День 3: ");
                TaskA();
                Console.WriteLine();
                TaskB();
                Console.WriteLine();
                TaskC();
                Console.WriteLine();
                TaskD();
                Console.WriteLine();
                TaskE();
                Console.WriteLine();
                TaskF();
                employee.Id0();
                Console.WriteLine();
            }
            void Day4()
            {
                void IndexSalary()
                {
                    Console.WriteLine("День 4 Задание 1");
                    double index = 1.2;
                    foreach (var emp in employees)
                    {
                        Console.WriteLine($"Зарплата увеличена на 20%: {emp.Salary * index}");
                    }
                    Console.WriteLine();
                }
                void PoNomeruOtdela()
                {
                    Console.WriteLine("День 4 Задание 2: ");
                    Console.WriteLine("Введите номер отдела: ");
                    int chooseOtdel = Convert.ToInt32(Console.ReadLine());
                    void MinSalary()
                    {
                        double min = 99999999999;
                        foreach (var emp in employees)
                        {
                            if (emp.Salary < min)
                            {
                                if (chooseOtdel == emp.Otdel)
                                {
                                    min = emp.Salary;
                                }
                            }
                        }
                        Console.WriteLine($"Минимальная ЗП {min} в отделе №{chooseOtdel}");
                    }
                    void MaxSalary()
                    {
                        double max = 0;
                        foreach (var emp in employees)
                        {
                            if (emp.Salary > max)
                            {
                                if (chooseOtdel == emp.Otdel)
                                {
                                    max = emp.Salary;
                                }
                            }
                        }
                        Console.WriteLine($"Максимальная ЗП {max} в отделе №{chooseOtdel}");
                    }
                    void MidleSalary()
                    {
                        int count = 0;
                        double summa = 0;
                        foreach (var emp in employees)
                        {
                            if (chooseOtdel == emp.Otdel)
                            {
                                count++;
                                summa += emp.Salary;
                            }
                        }
                        Console.WriteLine($"Среднее значение ЗП: {summa / count}");
                    }
                    void IndexSalaryPoOtdelu()
                    {
                        double index = 1.2;
                        foreach (var emp in employees)
                        {
                            if (chooseOtdel == emp.Otdel)
                            {
                                Console.WriteLine($"Зарплата увеличена на 20%: {emp.Salary * index}");
                            }
                        }
                    }
                    void DanniePoOtdelu()
                    {
                        foreach (var emp in employees)
                        {
                            if (chooseOtdel == emp.Otdel)
                            {
                                Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}");
                            }
                        }
                    }
                    Console.WriteLine();
                    MinSalary();
                    Console.WriteLine();
                    MaxSalary();
                    Console.WriteLine();
                    MidleSalary();
                    Console.WriteLine();
                    IndexSalaryPoOtdelu();
                    Console.WriteLine();
                    DanniePoOtdelu();
                    Console.WriteLine();
                }
                void PoChislu()
                {
                    Console.WriteLine("День 4 Задание 3: ");
                    Console.WriteLine("Введите число: ");
                    double chislo = Convert.ToInt32(Console.ReadLine());
                    void TaskA()
                    {
                        Console.WriteLine("Зарплата меньше числа: ");
                        foreach (var emp in employees)
                        {
                            if (chislo > emp.Salary)
                            {
                                Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}");
                            }
                        }
                    }
                    void TaskB()
                    {
                        Console.WriteLine("Зарплата больше числа: ");
                        foreach (var emp in employees)
                        {
                            if (chislo <= emp.Salary)
                            {
                                Console.WriteLine($"Id: {employee.Id()} ФИО: {emp.Fio}, Зарплата: {emp.Salary}");
                            }
                        }
                    }
                    TaskA();
                    Console.WriteLine();
                    TaskB();
                    Console.WriteLine();
                }
                IndexSalary();
                employee.Id0();
                Console.WriteLine();
                PoNomeruOtdela();
                employee.Id0();
                Console.WriteLine();
                PoChislu();
                employee.Id0();
                Console.ReadKey();
            }
            Day3();
            Day4();
        }
        }
}