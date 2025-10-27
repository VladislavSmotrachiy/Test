 public class Students
{

    private string Name;
    private int Age;
    private int SolutinsNuber;
    private int CorrectSolutinsNuber;


public Students(string name, int age)
    {
        Name = name;
        Age = age;

    }

    public double GetProcentageCorrectSolutinsNuber()
    {
        return CorrectSolutinsNuber * 100 / SolutinsNuber;
    }

    public string Fullname()
    {
        return ($"{Name}  {Age} ");
    }
    
    public void GetCorrectSolutinsNu()
    {   
        while (SolutinsNuber < 10)
        {
            SolutinsNuber++;
            System.Console.WriteLine($"Задача {SolutinsNuber} решил правильно? ");

            string answer = Console.ReadLine();

            if (answer == "да" || answer == "yes" || answer == "y")
            {
                CorrectSolutinsNuber++;

            }
            System.Console.WriteLine($"количесвто задач {SolutinsNuber} решено {CorrectSolutinsNuber}");
        }

    }
}