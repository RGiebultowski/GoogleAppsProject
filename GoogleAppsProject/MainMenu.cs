using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleAppsProject
{
    public class MainMenu
    {
        private int option = 1;
        private bool isSelected = false;
        private ConsoleKeyInfo consoleKeyInfo;
        private List<string> menu = new List<string>() 
        {
            "1. Display all apltication names",
            "2. Display by user rating",
            "3. Exit app",
        };
        private string arrow = "> ";

        public int DrawMenu()
        {
            while (!isSelected) 
            {
                for (int i = 1; i <= menu.Count; i++) 
                {
                    Console.WriteLine($"{(option == i ? arrow : "")}{menu[i-1]}");
                }

                consoleKeyInfo = Console.ReadKey();

                switch (consoleKeyInfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        option = (option == 3 ? 1 : option + 1);
                        break;
                    case ConsoleKey.UpArrow:
                        option = (option == 1 ? 3 : option - 1);
                        break;
                    case ConsoleKey.Enter:
                        isSelected = true;
                        break;
                }
                Console.Clear();
            }
            return option;
        }
    }
}
