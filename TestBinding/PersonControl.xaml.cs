using System.Windows;
using System.Windows.Controls;

namespace TestBinding;

public partial class PersonControl : UserControl
{
    public static readonly DependencyProperty PersonProperty =
        DependencyProperty.Register("Person", typeof(Person), typeof(PersonControl));

    public PersonControl()
    {
        PrintPerson2 = new(() =>
        {
            MessageBox.Show($"Person-2: {Person}");
        });
        InitializeComponent();
    }

    public Person Person
    {
        get => (Person)GetValue(PersonProperty);
        set => SetValue(PersonProperty, value);
    }

    public DelegateCommand PrintPerson2
    {
        get;
    }
}