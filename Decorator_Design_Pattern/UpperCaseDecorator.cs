namespace Decorator_Design_Pattern;

public class UpperCaseDecoratorPattern : Decorator<string>
{
    public UpperCaseDecoratorPattern(Component_Interface<string> component) : base(component) { }

    public override string GetText()
    {
        return base.GetText().ToUpper();
    }
}
