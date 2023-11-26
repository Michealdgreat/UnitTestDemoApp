// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Red(check for errors), Green(make sure they all pass the test), Refactor(figure out how you can make it better)
public class DisplayMessage
{
    public string Greeting(string firstName, int hourOftheDay)
    {
        string output = "";
        if (hourOftheDay < 12)
        {
            output = $"Good Morning {firstName}";
        }
        else if (hourOftheDay < 18)
        {
            output = $"Good Afternoon {firstName}";
        }
        else
        {
            output = $"Good Evening {firstName}";
        }

        return output;
    }
}
