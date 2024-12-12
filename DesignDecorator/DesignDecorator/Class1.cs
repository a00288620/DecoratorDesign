public class BaseContent : IComponent<string>
{
    public string FetchContent()
    {
        return "Hello, Decorator Pattern!";
    }
}

