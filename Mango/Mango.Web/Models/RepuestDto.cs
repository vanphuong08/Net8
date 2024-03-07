namespace Mango.Web.Models
{
    public class RepuestDto
    {
        public string ApiType { get; set; } = "Get";
        public string Url { get; set; }
        public object Data { get; set; }
        public string AccessToken { get; set; }
    }
}
