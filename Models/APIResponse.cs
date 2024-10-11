using System.Net;

namespace XitiqueAPI.Models
{
    public class APIResponse
    {
        public bool IsSuccess { get; set; } = false;
        public HttpStatusCode StatusCode { get; set; }
        public object ResultData { get; set; }
        public List<string> ErrorMessages { get; set; }
    }
}