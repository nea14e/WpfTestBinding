using System.Windows;
using System.Windows.Controls;

namespace TestBinding;

public partial class PersonControl : UserControl
{
    public static readonly DependencyProperty PersonProperty =
        DependencyProperty.Register(
            "Person",
            typeof(Person),
            typeof(PersonControl),
            new FrameworkPropertyMetadata(
                new Person("Qwery", 124),
                FrameworkPropertyMetadataOptions.BindsTwoWayByDefault
            )
        );

    public PersonControl()
    {
        PrintPerson2 = new(() => { MessageBox.Show($"Person-2: {Person}"); });
        NewPerson2 = new(() => { Person = new Person("Qwery", 124); });
        InitializeComponent();
    }

    public Person Person
    {
        get => (Person)GetValue(PersonProperty);
        set
        {
            Console.WriteLine($"PersonControl: set: {value}");
            SetValue(PersonProperty, value);
        }
    }

    public DelegateCommand PrintPerson2 { get; }
    public DelegateCommand NewPerson2 { get; }
}