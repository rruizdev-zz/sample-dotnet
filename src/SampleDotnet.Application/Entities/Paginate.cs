namespace SampleDotnet.Application.Entities
{
    public class Paginated<T>
    {
        public int Page { get; set; }

        public int Pages { get; set; }

        public int ItemsPerPage { get; set; }

        public IList<T>? Items { get; set; }
    }
}
