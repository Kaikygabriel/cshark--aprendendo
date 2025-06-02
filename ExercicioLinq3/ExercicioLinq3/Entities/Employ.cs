using ExercicioLinq3.Entities.Exceptions;

namespace ExercicioLinq3.Entities;

public class Employ
{
    public Employ(){}

    public Employ(string line)
    {
        string[] vect = line.Split(',');
        if (vect.Length < 0)
            throw new DominioException("Error Constructor Employ");
        Name = vect[0];
        Email = vect[1];
        Salary =double.Parse(vect[2]);
    }
    public string Name { get;private set; }
    public double Salary { get;private set; }
    public string Email { get; private set; }

    public override string ToString()
        => $"{Name} -- email {Email} -- salary R${Salary.ToString("F2")}";

    public override int GetHashCode()
        => Name.GetHashCode();
}