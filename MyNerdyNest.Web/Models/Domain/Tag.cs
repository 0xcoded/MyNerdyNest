namespace MyNerdyNest.Web.Models.Domain
{
    public class Tag
    {
        public Guid id { get; set; }
        public String Name { get; set; }
        public String DisplayName { get; set; }
        public ICollection<BlogPost> BlogPosts { get; set; }
    }
}
