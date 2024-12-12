public abstract class ContentDecorator<T> : IComponent<T>
{
    protected IComponent<T> wrappedContent;

    public ContentDecorator(IComponent<T> content)
    {
        this.wrappedContent = content;
    }

    public virtual T FetchContent()
    {
        return wrappedContent.FetchContent();
    }
}
