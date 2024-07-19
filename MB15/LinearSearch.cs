namespace MB15
{
    public class LinearSearch : ISearch {
        /// <summary>
        /// Linear Search [Time: O(n), Space: O(1)]
        /// </summary>
        /// <param name="data">The array to search</param>
        /// <param name="value">The value to search</param>
        /// <param name="unsorted">Database unsorted?</param>
        /// <returns>SearchResult object with statistics</returns>
        public SearchResult Find(int[] data, int value, bool unsorted) {
            var searchResult = new SearchResult ();
            var watch = System.Diagnostics.Stopwatch.StartNew();

            for (var i = 0; i < data.Length; i++) {
                if (data[i] == value) {
                    searchResult.PositionFound = i;
                    break;
                }
            }

            watch.Stop();
            searchResult.Ticks = watch.ElapsedTicks;
            return searchResult;
        }
    }
}
