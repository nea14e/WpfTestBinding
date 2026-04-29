using System.Windows;

namespace TestBinding;

public class MainWindowVm : BindableBase
{
    private Person _person = new("Qwerty", 123);

    public Person Person
    {
        get => _person;
        set
        {
            Console.WriteLine($"MainWindowVm: set: {value}");
            SetProperty(ref _person, value);
        }
    }

    public DelegateCommand PrintPerson => new DelegateCommand(() => { MessageBox.Show($"Person: {Person}"); });
    public DelegateCommand NewPerson => new DelegateCommand(() => { Person = new Person(); });
}