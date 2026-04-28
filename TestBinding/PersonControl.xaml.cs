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
                new Person("Qwery", 123),
                FrameworkPropertyMetadataOptions.BindsTwoWayByDefault
            )
        );

    public PersonControl()
    {
        PrintPerson2 = new(() => { MessageBox.Show($"Person-2: {Person}"); });
        InitializeComponent();
    }

    public Person Person
    {
        get => (Person)GetValue(PersonProperty);
        set
        {
            Console.WriteLine($"PersonControl: set: {value}");
            SetValue(PersonProperty, value);
            value.PropertyChanged += (obj, _) => { Console.WriteLine($"PersonControl: changed: {obj}"); };
        }
    }

    public DelegateCommand PrintPerson2 { get; }
}