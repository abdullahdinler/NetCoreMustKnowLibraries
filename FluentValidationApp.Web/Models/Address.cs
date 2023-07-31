namespace FluentValidationApp.Web.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Provice { get; set; }
        public string PostCode { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
