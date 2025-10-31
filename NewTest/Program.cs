public class Program
{


    public static void Main(string[] args)
    {
        Students students = new Students("Егор", 25);
       
        int count = 0;
        System.Console.WriteLine("Будет 10 задачь тебе нужно отвтеить правильно решина каждаяд");
        while (count < 10)
        {
         count++;
         int number = Convert.ToInt32(Console.ReadLine());
         students.GetCorrectSolutinsNu(students.GetFlag(number));

        }
        System.Console.WriteLine($" Студент {students.Fullname()} лет \n Процент решение задач {students.GetProcentageCorrectSolutinsNuber()}%");

    

    }
}

