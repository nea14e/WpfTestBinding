using System.Windows;

namespace TestBinding;

public class MainWindowVm : BindableBase
{
    public PersonVm PersonVm { get; set; }

    private Person _person = new("Qwerty", 123);

    public Person Person
    {
        get
        {
            Console.WriteLine($"MainWindowVm: get: {_person}");
            return _person;
        }
        set
        {
            Console.WriteLine($"MainWindowVm: set: {value}");
            SetProperty(ref _person, value);
            PersonVm.Person = value;
        }
    }

    public MainWindowVm()
    {
        PersonVm = new PersonVm
        {
            Person = _person
        };
        PersonVm.PropertyChanged += (obj, _) => { Person = ((PersonVm)obj!).Person; };
    }

    public DelegateCommand PrintPerson => new DelegateCommand(() => { MessageBox.Show($"Person: {Person}"); });
    public DelegateCommand NewPerson => new DelegateCommand(() => { Person = new Person(); });
}