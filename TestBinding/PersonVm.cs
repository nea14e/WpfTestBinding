using System.Windows;

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

    public PersonVm()
    {
        PrintPerson2 = new DelegateCommand(() => { MessageBox.Show($"Person-2: {Person}"); });
        NewPerson2 = new DelegateCommand(() => { Person = new Person("Qwer", 124); });
    }

    public DelegateCommand PrintPerson2 { get; }

    public DelegateCommand NewPerson2 { get; }
}