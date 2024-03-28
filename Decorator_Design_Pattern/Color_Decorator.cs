namespace Decorator_Design_Pattern;

public class ColorDecoratorPattern : Decorator<string>
{
    public ColorDecoratorPattern(Component_Interface<string> component) : base(component) { }
    public override string GetText()
    {
        return $"\u001b[36m\u001b[43m{base.GetText()}\u001b[0m";
    }
}
