namespace Decorator_Design_Pattern;

public class UpperCaseDecorator : Decorator<string>
{
    public UpperCaseDecorator(Component_Interface<string> component) : base(component) { }

    public override string GetText()
    {
        return base.GetText().ToUpper();
    }
}
