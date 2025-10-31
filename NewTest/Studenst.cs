using System.ComponentModel;

public class Students
{

    private string Name;
    private int Age;
    private int SolutinsNuber;
    private int CorrectSolutinsNuber;

    private bool Flag;


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

    public bool GetFlag(int number)
    {
        if (number == 1)
        {
            Flag = true;
        }
        else
        {
            Flag = false;
        }
        return Flag;
    }
    
    public void GetCorrectSolutinsNu(bool n)
    {   
        if (n == true)
        {
            SolutinsNuber++;
            CorrectSolutinsNuber++;
           
        } else
        {
            SolutinsNuber++;
        }
    
    }
}