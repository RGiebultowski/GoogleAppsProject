using GoogleAppsProject;

internal class Program
{
    private static void Main(string[] args)
    {
        List<GoogleApp> allApps = CsvLoader.LoadCsv();

        Console.WriteLine("Google Apps filter app.....");

        //TODO Menu for user

        Console.WriteLine("Provide number:");
        int userInput = Convert.ToInt32(Console.ReadLine());
        while (userInput != 0)
        {
            switch (userInput) 
            {
                case 5:
                    Console.WriteLine("Exit...");
                    break;
                case 1:
                    Display(allApps);
                    break;
                
            }
            userInput = default;
        }
        
    }

    static void Display(List<GoogleApp> x)
    {
        foreach(GoogleApp app in x)
            Console.WriteLine(app.Name);
    }
}