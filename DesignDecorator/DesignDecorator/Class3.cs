public class PlainTextDecorator : ContentDecorator<string>
{
    public PlainTextDecorator(IComponent<string> content) : base(content) { }

    public override string FetchContent()
    {
        return $"[Plain]: {wrappedContent.FetchContent()}";
    }
}

