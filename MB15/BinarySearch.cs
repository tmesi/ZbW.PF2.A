using System;

namespace MB15
{
    public class BinarySearch :ISearch  {
        /// <summary>
        /// Binary Search  [Time: O(log(n)), Space: O(1)]
        /// </summary>
        /// <param name="data">The array to search</param>
        /// <param name="value">The value to search</param>
        /// <param name="unsorted">Database unsorted?</param>
        /// <returns>SearchResult object with statistics</returns>
        public SearchResult Find(int[] data, int value, bool unsorted) {
            var searchResult = new SearchResult();
            var watch = System.Diagnostics.Stopwatch.StartNew();

            if (unsorted) {
                Array.Sort(data);
            }
            
            var start = 0;
            var end = data.Length - 1;
            var middle = (end - start) / 2;   //floor

            while (start < end) {
                if (data[middle] == value)
                    break;

                if (value > data[middle])
                    start = middle + 1;
                else
                    end = middle - 1;

                middle = start + ((end - start) / 2);
            }

            watch.Stop();
            searchResult.Ticks = watch.ElapsedTicks;

            if (data[middle] == value)
                searchResult.PositionFound = middle;

            return searchResult;
        }
    }
}
