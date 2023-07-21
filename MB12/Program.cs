using System;

namespace MB12
{
    static class Program {
        static void Main(string[] args) {
            SearchScreen();
        }

        static void SearchScreen() {
            Console.Clear();
            new ArraySearchUI(10000000, 54).Print();

            Console.WriteLine();
            Console.WriteLine("Press any key for home screen!");
            Console.ReadKey(true);
        }
    }

}
