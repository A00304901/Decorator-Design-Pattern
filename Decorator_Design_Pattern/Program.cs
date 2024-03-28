namespace Decorator_Design_Pattern;

class Program
{
   
    static void Main()
    {
        Component_Interface<string> component = new ConcreteComponent();

        var plainDeco = new PlainDecorator(component);
        var upperCaseDeco = new UpperCaseDecorator(component);
        var colorDeco = new ColorDecorator(component);

        Console.WriteLine(plainDeco.GetText());
        Console.WriteLine(upperCaseDeco.GetText());
        Console.WriteLine(colorDeco.GetText());
    }
}
