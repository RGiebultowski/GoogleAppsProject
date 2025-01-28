using System;
using GoogleAppsProject;

internal class Program
{
    private static List<GoogleApp> allApps;
    private static MainMenu mainMenu = new MainMenu();
    private static int selectedOption;

    private static void Main(string[] args)
    {
        allApps = CsvLoader.LoadCsv();

        Console.WriteLine("Google Apps filter app.....");

        selectedOption = mainMenu.DrawMenu();

        //TODO: Create some methods for user
        switch (selectedOption)
        {
            case 1:
                DisplayAllAppsByName(allApps);
                break;
            case 2:
                MethodHandler(selectedOption);
                break;
            case 3:
                Environment.Exit(0);
                break;
        }

        Console.WriteLine("Google Apps filter app.....");
    }

    private static void MethodHandler(int option)
    {
        Console.WriteLine("Provide input");
        double userRating = Convert.ToDouble(Console.ReadLine());

        ViewAllAppsSortedByRating(allApps, userRating);
    }
    private static void DisplayAllAppsByName(List<GoogleApp> googleApps)
    {
        foreach(GoogleApp app in googleApps)
            Console.WriteLine(app.Name);
    }

    private static void ViewAllAppsSortedByRating(IEnumerable<GoogleApp> googleApps, double raiting)
    {
        var sortedByRating = googleApps.Where(app => app.Rating > raiting);
        Display(sortedByRating);
    }

    private static void Display(IEnumerable<GoogleApp> googleApps)
    {
        foreach (GoogleApp app in googleApps)
            Console.WriteLine($"{app.Name} | {app.Rating} | {app.Category}");
    }
}