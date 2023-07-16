using System;

namespace MB02
{
    public class ArraySearchUI {

        private readonly int _datasize;
        public ArraySearchUI(int datasize, int tableWith) {
            this._datasize = datasize;
            this._tableWidth = tableWith;
        }

        public void Print() {
            this.PrintLine();
            this.PrintRow("Ticks needed to search an item in " + _datasize + " integers");
            this.PrintLine();

            this.PrintLine();
            this.PrintRow("", "Linear", "Binary");
            this.PrintLine();

            this.PrintRow("Sorted, uniform distribution array");
            this.PrintLine();
            IArrayDataProvider dataProvider = new SortedAndUniformProvider(this._datasize);
            PrintGrid(
                Search(new LinearSearch(), dataProvider, false),
                Search(new BinarySearch(), dataProvider, false)
            );

            this.PrintRow("Sorted, not evenly distributed array");
            this.PrintLine();
            dataProvider = new SortedProvider(this._datasize);
            PrintGrid(
                Search(new LinearSearch(), dataProvider, false),
                Search(new BinarySearch(), dataProvider, false)
            );

            this.PrintRow("Unsorted (random) array");
            this.PrintLine();
            dataProvider = new UnsortedProvider(this._datasize);
            PrintGrid(
                Search(new LinearSearch(), dataProvider, true),
                Search(new BinarySearch(), dataProvider, true)
            );

            var color = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Target found, ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Target not found!");
            Console.WriteLine();
            Console.ForegroundColor = color;
        }

        private SearchResults Search(ISearch algorithm, IArrayDataProvider provider, bool sort) {

            var searchResults = new SearchResults {
                ArrayCount = provider.Data.Length,
                MinValue = algorithm.Find(provider.Data, provider.MinValue, sort),
                AvgValue = algorithm.Find(provider.Data, provider.AvgValue, sort),
                MaxValue = algorithm.Find(provider.Data, provider.MaxValue, sort),
                RandomValue = algorithm.Find(provider.Data, provider.RandomValue, sort),
                NotFoundValue = algorithm.Find(provider.Data, provider.NotFoundValue, sort)
            };


            return searchResults;
        }

        private void PrintGrid(SearchResults l, SearchResults b) {

            this.PrintRow("Min",
                (l.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.MinValue.Ticks.ToString("00000000"),
                (b.MinValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.MinValue.Ticks.ToString("00000000")
            );
            this.PrintRow("Avg",
                (l.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.AvgValue.Ticks.ToString("00000000"),
                (b.AvgValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.AvgValue.Ticks.ToString("00000000")
            );
            this.PrintRow("Max",
                (l.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.MaxValue.Ticks.ToString("00000000"),
                (b.MaxValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.MaxValue.Ticks.ToString("00000000")
            );
            this.PrintRow("NotFound",
                (l.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + l.NotFoundValue.Ticks.ToString("00000000"),
                (b.NotFoundValue.PositionFound != null ? ConsoleColor.Blue : ConsoleColor.Red) + "|" + b.NotFoundValue.Ticks.ToString("00000000")
            );
            this.PrintLine();
        }

        readonly int _tableWidth;
        readonly ConsoleColor DefaultColor = Console.ForegroundColor;

        private void PrintLine() {
            Console.WriteLine(new string('-', _tableWidth+1));
        }

        private void PrintRow(params string[] columns) {
            var width = (_tableWidth - columns.Length) / columns.Length;
            Console.Write("|");

            foreach (var column in columns) {
                var color = DefaultColor;
                var text = column;
                if (column.Contains("|")) {
                    color = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), column.Split('|')[0]);
                    text = column.Split('|')[1];
                }
                Console.ForegroundColor = color;
                Console.Write(AlignCentre(text, width));
                Console.ForegroundColor = DefaultColor;
                Console.Write("|");
            }

            Console.WriteLine();
        }

        private string AlignCentre(string text, int width) {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            return string.IsNullOrEmpty(text) ? new string(' ', width) : text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
        }
    }
}
