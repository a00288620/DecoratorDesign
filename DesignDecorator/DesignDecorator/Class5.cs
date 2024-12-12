public class UpperCaseTextDecorator : ContentDecorator<string>
{
    public UpperCaseTextDecorator(IComponent<string> content) : base(content) { }

    public override string FetchContent()
    {
        return wrappedContent.FetchContent().ToUpper();
    }
}
