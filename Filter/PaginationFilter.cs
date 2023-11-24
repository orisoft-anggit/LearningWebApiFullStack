namespace Web.Api.Filter
{
    public class PaginationFilter
    {
        public PaginationFilter()
        {
            this.PageNumber = 1;
            
            this.PageSize = 10;
        }

        public int PageNumber { get; set; }

        public int PageSize { get; set; }

        public string? Search { get; set; }

        public PaginationFilter(int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber < 1 ? 1 : pageNumber;
            this.PageSize = pageSize > 10 ? 10 : pageSize;
        }
    }
}