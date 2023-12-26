using System;

abstract class Student
{
    protected string name;
    protected int attendedClasses;

    public Student(string name, int attendedClasses)
    {
        this.name = name;
        this.attendedClasses = attendedClasses;
    }

    public abstract bool PassExam();
}

class OrdinaryStudent : Student
{
    public OrdinaryStudent(string name, int attendedClasses) : base(name, attendedClasses) { }

    public override bool PassExam()
    {
        if (attendedClasses == 20)
        {
            Console.WriteLine($"{name} сдал зачет.");
            return true;
        }
        else if (attendedClasses > 10)
        {
            Random rand = new Random();
            bool pass = rand.NextDouble() < 0.5;
            Console.WriteLine($"{name} {(pass ? "сдал" : "не сдал")} зачет.");
            return pass;
        }
        else
        {
            Console.WriteLine($"{name} не сдал зачет.");
            return false;
        }
    }
}

class SmartStudent : Student
{
    public SmartStudent(string name, int attendedClasses) : base(name, attendedClasses) { }

    public override bool PassExam()
    {
        if (attendedClasses == 20)
        {
            Console.WriteLine($"{name} сдал зачет.");
            return true;
        }
        else if (attendedClasses > 10)
        {
            Random rand = new Random();
            bool pass = rand.NextDouble() < 0.7;
            Console.WriteLine($"{name} {(pass ? "сдал" : "не сдал")} зачет.");
            return pass;
        }
        else
        {
            Console.WriteLine($"{name} не сдал зачет.");
            return false;
        }
    }
}

class GeniusStudent : Student
{
    public GeniusStudent(string name, int attendedClasses) : base(name, attendedClasses) { }

    public override bool PassExam()
    {
        if (attendedClasses > 0)
        {
            Console.WriteLine($"{name} сдал зачет.");
            return true;
        }
        else
        {
            Console.WriteLine($"{name} не сдал зачет.");
            return false;
        }
    }
}

class Program
{
    static void Main()
    {
        Student[] students = new Student[10];

        students[0] = new OrdinaryStudent("A", 20);
        students[1] = new OrdinaryStudent("Б", 15);
        students[2] = new OrdinaryStudent("В", 10);
        students[3] = new OrdinaryStudent("Г", 5);
        students[4] = new OrdinaryStudent("Д", 9);
        students[5] = new SmartStudent("Е", 20);
        students[6] = new SmartStudent("Ж", 15);
        students[7] = new SmartStudent("З", 10);
        students[8] = new SmartStudent("И", 12);
        students[9] = new GeniusStudent("К", 0);

        foreach (Student student in students)
        {
            student.PassExam();
        }
    }
}