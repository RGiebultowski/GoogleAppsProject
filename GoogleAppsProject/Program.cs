using GoogleAppsProject;

internal class Program
{
    private static List<Option> menuOptions;
    private static List<GoogleApp> allApps;

    private static void Main(string[] args)
    { 
        allApps = CsvLoader.LoadCsv();
        //TODO Menu for user

        menuOptions = new List<Option>
        {
            new("Display all apltication names",() => Display(allApps)),
            new("Exit application....",() => Environment.Exit(0)),
        };


        Console.WriteLine("Google Apps filter app.....");
    }

    private static void Display(List<GoogleApp> googleApps)
    {
        foreach(GoogleApp app in googleApps)
            Console.WriteLine(app.Name);
    }
}