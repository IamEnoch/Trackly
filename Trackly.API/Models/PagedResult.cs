namespace TracklyApi.Models
{
    public class PagedResult<T>
    {
        public int PageNumber { get; set; }
        public int TotalCount { get; set; }
        public int RecordNumber { get; set; }
        public IList<T> Items { get; set; }
    }
}
