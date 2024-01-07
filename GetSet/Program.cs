class Student
{

    public int birthYear;
    public int Age
    {
        get
        {
            return DateTime.Now.Year - birthYear;
        }
        set
        {
            if (value <= DateTime.Now.Year - birthYear && value > 0)
            {
                birthYear = DateTime.Now.Year - birthYear - value;
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();
        Console.Write("Please enter age or year: ");
        student.Age = int.Parse(Console.ReadLine()!);
        Console.WriteLine(student.birthYear);
        Console.WriteLine(student.Age);
    }

}
