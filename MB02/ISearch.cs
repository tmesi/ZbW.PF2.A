namespace MB02
{
    public interface ISearch {
        SearchResult Find(int[] data, int value, bool sort);
    }
}
