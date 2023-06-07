using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controller;

namespace View
{
    public class ProgramRunner : IProgramRunner
    {
        private IMenu menu;

        public ProgramRunner(IMenu menu)
        {
            this.menu = menu;
        }

        public void Run()
        {


            Dictionary<MenuItem, Action> command = new Dictionary<MenuItem, Action>()
            {
                { MenuItem.Letter, menu.WriteLetter},
                { MenuItem.Order, menu.WriteOrder},
                { MenuItem.Directive, menu.WriteDirective},
                { MenuItem.Resourserequest, menu.WriteResourceRequest},

            };

            string ans = "";
            Console.WriteLine($"1. {MenuItem.Letter}\n" + $"2. {MenuItem.Order}\n" + $"3. {MenuItem.Directive}\n" + $"4. {MenuItem.Resourserequest}\n"
                );

            while (!ans.ToLower().Contains("yes"))
            {
                Console.WriteLine("Enter a number of option:");
                int num = int.Parse(Console.ReadLine());
                if (Enum.TryParse((num - 1).ToString(), out MenuItem queryType) && command.ContainsKey(queryType))
                {
                    command[queryType]();
                }
                else
                {
                    Console.WriteLine("Invalid option number.");
                }
                Console.WriteLine("Do you wish to exit?");
                ans = Console.ReadLine();
            }
        }

        public enum MenuItem
        {
            Letter,
            Order,
            Directive,
            Resourserequest
        }
    }
}
