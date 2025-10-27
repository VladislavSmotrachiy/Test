public class Program
{


    public static void Main(string[] args)
    {
        Students students = new Students("Егор", 25);
        students.GetCorrectSolutinsNu();
        System.Console.WriteLine($" Студент {students.Fullname()} лет \n Процент решение задач {students.GetProcentageCorrectSolutinsNuber()}%");

    }
}

