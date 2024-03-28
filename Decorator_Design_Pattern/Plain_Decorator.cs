namespace Decorator_Design_Pattern;

public class PlainDecoratorPattern : Decorator<string>
{
    public PlainDecoratorPattern(Component_Interface<string> component) : base(component) { }

    public override string GetText()
    {
        return base.GetText();
    }
}
