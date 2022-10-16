namespace NET6RazorPageCustomRoutingUsingEFCoreWithPostgreSQL.Entities
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }
}
