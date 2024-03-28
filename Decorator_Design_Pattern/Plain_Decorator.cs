namespace Decorator_Design_Pattern;

public class PlainDecorator : Decorator<string>
{
    public PlainDecorator(Component_Interface<string> component) : base(component) { }

    public override string GetText()
    {
        return base.GetText();
    }
}
