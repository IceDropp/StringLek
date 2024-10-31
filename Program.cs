namespace StringLek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Your name is " + name);
            Console.WriteLine("\nEnter a long text with both uppercase and lowercase: ");
            String text = Console.ReadLine();
            Console.WriteLine("Lenght of the text");
            Console.WriteLine(text.Length);
            Console.WriteLine("What is the letter of the letter in position 4:");
            Console.WriteLine(text[4]);
            Console.WriteLine( "Is Hello in the text?");
            Console.WriteLine(text.Contains("Hello"));
            Console.WriteLine("Is the letter l in the text and its place?");
            Console.WriteLine(text.IndexOf('l'));
            Console.WriteLine("Letter at possition 3 and two more letters");
            Console.WriteLine(text.Substring(3, 2));
            Console.WriteLine("To Lower and to Upper");
            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
         //   Console.WriteLine(text.ToUpper);
        }
    }
}
