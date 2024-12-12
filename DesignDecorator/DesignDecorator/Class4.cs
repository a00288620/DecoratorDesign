public class ColorTextDecorator : ContentDecorator<string>
{
    public ColorTextDecorator(IComponent<string> content) : base(content) { }

    public override string FetchContent()
    {
        return $"[Color: Red]: {wrappedContent.FetchContent()}";
    }
}

