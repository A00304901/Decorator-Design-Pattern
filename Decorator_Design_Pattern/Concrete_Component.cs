namespace Decorator_Design_Pattern;

public class ConcreteComponent : Component_Interface<string>
{
    public string GetText()
    {
        return "I have successfully get the output";
    }
}
