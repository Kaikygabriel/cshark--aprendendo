namespace ExercicioLinq2.Entities;

public class Employ
{
    public Employ(){}

    public Employ(string Line)
    {
        string[] vect = Line.Split(',');
        if (vect.Length < 0)
            throw new Exception("Error sem argumetnos no construtor employ");
        Email = vect[1];
        Salary = double.Parse(vect[2]);
        Nome = vect[0];
    }

    public string Email { get;protected set; }
    public double Salary { get;protected set; }
    public  string Nome{ get;protected set; }

    public override string ToString()
        => $"{Nome} -- {Email} -- R${Salary.ToString("F2")}";
}