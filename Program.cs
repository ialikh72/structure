using System;

struct Student { public int Id; public string Name; }

class Program
{
    static void Main()
    {
        Student[] s = new Student[2];
        s[0] = new Student { Id = 1, Name = "Alex" };
        s[1] = new Student { Id = 2, Name = "Sam" };

        for (int i = 0; i < s.Length; i++)
            Console.WriteLine($"{s[i].Id}: {s[i].Name}");
    }
}