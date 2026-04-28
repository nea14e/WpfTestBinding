namespace TestBinding;

public class Person : BindableBase
{
    private string _name;

    public string Name
    {
        get => _name;
        set
        {
            Console.WriteLine($"Person: set: {value}");
            SetProperty(ref _name, value);
        }
    }

    private int _number;

    public int Number
    {
        get => _number;
        set
        {
            Console.WriteLine($"Person: set: {value}");
            SetProperty(ref _number, value);
        }
    }

    public Person() : this("Qwerty", 123)
    {
    }

    public Person(string name, int number)
    {
        Name = name;
        Number = number;
    }

    public override string ToString()
    {
        return $"'{Name}', {Number}";
    }
}