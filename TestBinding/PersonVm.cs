namespace TestBinding;

public class PersonVm : BindableBase
{
    private Person _person = new("Qwer", 124);

    public Person Person
    {
        get
        {
            Console.WriteLine($"PersonVm: get: {_person}");
            return _person;
        }
        set
        {
            Console.WriteLine($"PersonVm: set: {value}");
            SetProperty(ref _person, value);
        }
    }
}