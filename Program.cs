using System;
public class Student
{
    private string _fio;
    private int _ocenka1;
    private int _ocenka2;

    public string FIO
    {
        get { return _fio; }
        set { _fio = value; }
    }

    public int Ocenka1
    {
        get { return _ocenka1; }
        set { _ocenka1 = value; }
    }

    public int Ocenka2
    {
        get { return _ocenka2; }
        set { _ocenka2 = value; }
    }

    public Student()
    {
        _fio = "Неизвестный студент";
        _ocenka1 = 0;
        _ocenka2 = 0;
    }

    public Student(string fio, int ocenka1, int ocenka2)
    {
        _fio = fio;
        _ocenka1 = ocenka1;
        _ocenka2 = ocenka2;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"ФИО: {_fio}");
        Console.WriteLine($"Оценка 1: {_ocenka1}");
        Console.WriteLine($"Оценка 2: {_ocenka2}");
    }

    public float SredOcenka()
    {
        return (float)(_ocenka1 + _ocenka2) / 2;
    }
}



public class Program
{
    public static void Main(string[] args)
    {

        Student studentIvanov = new Student("Иванов", 3, 5);

        Student studentAnonim = new Student();

        studentAnonim.FIO = "Петров";
        studentAnonim.Ocenka1 = 4;
        studentAnonim.Ocenka2 = 5;


        Console.WriteLine("Данные о студенте Иванов:");
        studentIvanov.PrintInfo();
        Console.WriteLine();

        Console.WriteLine("Данные о студенте Петров:");
        studentAnonim.PrintInfo();
        Console.WriteLine();


        Console.WriteLine($"Средняя оценка студента Иванов: {studentIvanov.SredOcenka()}");
        Console.WriteLine($"Средняя оценка студента Петров: {studentAnonim.SredOcenka()}");


        Console.ReadKey();
    }
}
