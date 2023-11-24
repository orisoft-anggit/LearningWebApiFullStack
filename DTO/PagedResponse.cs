namespace Web.Api.DTO
{
    public class PagedResponse<T>
    {
        public List<T> Data { get; set; }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public int TotalRecords { get; set; }
    }
}