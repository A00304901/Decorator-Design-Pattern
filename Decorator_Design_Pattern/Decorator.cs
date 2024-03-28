namespace Decorator_Design_Pattern;

public abstract class Decorator<T> : Component_Interface<T>
{
    protected Component_Interface<T> component;

    public Decorator(Component_Interface<T> component) 
    {
        this.component = component;
    }

    public virtual T GetText()
    {
        return component.GetText();
    }
}
