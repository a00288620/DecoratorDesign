using System;

class Program
{
    static void Main(string[] args)
    {
        
        IComponent<string> baseContent = new BaseContent();

        
        IComponent<string> plainText = new PlainTextDecorator(baseContent);
        IComponent<string> colorText = new ColorTextDecorator(plainText);
        IComponent<string> upperCaseText = new UpperCaseTextDecorator(colorText);

        
        Console.WriteLine("Original: " + baseContent.FetchContent());
        Console.WriteLine("With PlainTextDecorator: " + plainText.FetchContent());
        Console.WriteLine("With ColorTextDecorator: " + colorText.FetchContent());
        Console.WriteLine("With UpperCaseTextDecorator: " + upperCaseText.FetchContent());
    }
}
