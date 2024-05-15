using System;

struct Student
{
   // Поля структуры: полное имя, номер группы, массив с оценками
    public string FullName;
    public string GroupNumber;
    public int[] Performance;

    // Метод, который вычисляет средний балл студента
    public double GetAveragePerformance()
    {
        // Инициализируем переменную для хранения суммы оценок
        double sum = 0;

        // Проходим по массиву оценок и суммируем их
        foreach (int mark in Performance)
        {
            sum += mark;
        }

        // Возвращаем средний балл, который равен сумме оценок, деленной на количество оценок
        return sum / Performance.Length;
    }
}

// Основной класс программы
class Program
{
    // Точка входа в программу
    static void Main(string[] args)
    {
        // Создаем массив из 7 студентов с заданными параметрами
        Student[] students = new Student[7]
        {
            new Student { FullName = "Гурдин Р.Н", GroupNumber = "Группа 22ИТ35", Performance = new int[]{4, 5, 3, 5, 4} },
            new Student { FullName = "Антипкин Д.В.", GroupNumber = "Группа 22ИТ35", Performance = new int[]{3, 4, 4, 5, 5} },
            new Student { FullName = "Самойлов С.С.", GroupNumber = "Группа 21ПТ12", Performance = new int[]{5, 5, 5, 5, 5} },
            new Student { FullName = "Козлов К.Р.", GroupNumber = "Группа 21ПТ12", Performance = new int[]{2, 3, 4, 3, 2} },
            new Student { FullName = "Слуцкий Е.И.", GroupNumber = "Группа 23ИТ12", Performance = new int[]{5, 5, 4, 5, 5} },
            new Student { FullName = "Жимонова А.П.", GroupNumber = "Группа 23ИТ12", Performance = new int[]{4, 4, 4, 4, 4} },
            new Student { FullName = "Новиков А.А", GroupNumber = "Группа 23ИТ12", Performance = new int[]{3, 3, 2, 4, 3} }
        };

        // Сортируем массив студентов по возрастанию среднего балла
        Array.Sort(students, (x, y) => x.GetAveragePerformance().CompareTo(y.GetAveragePerformance()));

        // Выводим информацию о каждом студенте
        foreach (var student in students)
        {
            Console.WriteLine($"Студент: {student.FullName}, Группа: {student.GroupNumber}, Средний балл: {student.GetAveragePerformance()}");
        }
    }
}
