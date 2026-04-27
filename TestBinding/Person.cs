namespace TestBinding;

public class Person
{
    public string Name { get; set; }
    public int Number { get; set; }

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