using System;

struct Student
{
    public string FullName;
    public string GroupNumber;
    public int[] Performance;

    public double GetAveragePerformance()
    {
        double sum = 0;
        foreach (int mark in Performance)
        {
            sum += mark;
        }
        return sum / Performance.Length;
    }
}

class Program
{
    static void Main(string[] args)
    {
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

        Array.Sort(students, (x, y) => x.GetAveragePerformance().CompareTo(y.GetAveragePerformance()));

        foreach (var student in students)
        {
            Console.WriteLine($"Студент: {student.FullName}, Группа: {student.GroupNumber}, Средний балл: {student.GetAveragePerformance()}");
        }
    }
}